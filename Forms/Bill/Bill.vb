
Public Class Bill


    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        '**************************************
        '*     Code Handling Add Item Form    *  
        '**************************************

        'declare and initialise the variable which later stores the result sent by additem bill
        Dim result As DialogResult = Nothing
        Try
            Do
                'creates an instance of add item form and displays it
                Dim addItem As New Additem

                'displays additem form
                result = addItem.ShowDialog()

                'if the user clicks ok or cancel button then the control is returned back to bill form
                If result = Windows.Forms.DialogResult.Cancel Or result = Windows.Forms.DialogResult.OK Then Exit Do

                '***Code that checks if the user selected item already exists in the bill form***

                'stores the item name of the selected row in variable named selecteditem
                Dim selectedItem As String = addItem.Tag
                'creates a boolean which is used later to tell if the items selected already exists in the bill
                Dim alreadyPresent As Boolean = False
                'Variable that stores the row of the item if it already exists in main bill
                Dim rowNumber As Integer
                'loops through each row and its column to check if selected item is already there
                For i As Integer = 0 To DGV.Rows.Count - 1
                    If DGV.Rows(i).Cells(1).Value = selectedItem Then
                        alreadyPresent = True
                        rowNumber = i
                        Exit For
                    End If
                Next

                'if the item already exists in the bill form then count and total is updated
                If alreadyPresent = True Then
                    Dim count As Integer = DGV.Rows(rowNumber).Cells(4).Value
                    DGV.Rows(rowNumber).Cells(4).Value = count + CInt(addItem.cboQuantity.Text)
                    DGV.Rows(rowNumber).Cells(5).Value = (DGV.Rows(rowNumber).Cells(2).Value) * (count + CInt(addItem.cboQuantity.Text))
                    Exit Sub

                End If


                '***If the item is not present in bill following lines of code run***

                'creates an instance of items table adapter
                Dim myTableAdapter As New billing_systemDataSetTableAdapters.Items_TableTableAdapter

                'uses table adapter to query the database for the item name sent from additem form
                Dim tb = myTableAdapter.GetDataByItemName(addItem.Tag)

                'displays the the item name, and other information in the datagrid 
                DGV.Rows.Add(tb.Rows(0).Item(0), tb.Rows(0).Item(1), tb.Rows(0).Item(2), tb.Rows(0).Item(3), CInt(addItem.cboQuantity.Text), CInt(addItem.cboQuantity.Text) * CInt(tb.Rows(0).Item(2)))

            Loop While result = Windows.Forms.DialogResult.Retry
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        '***removes the selected row***
        If DGV.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        'code to remove the selected row from the bill
        DGV.Rows.Remove(DGV.SelectedRows(0))
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            'displays error message if no item is present in data grid view
            If DGV.Rows.Count < 1 Then
                MessageBox.Show("No Items Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'activates the paid button
            btnPaid.Enabled = True

            'creates a new instance of calculate form 
            Dim calculate As New Calculate
            'displays calculate form and performs further processes based on what user clicked in calculate form
            If calculate.ShowDialog = Windows.Forms.DialogResult.OK Then
                'declaring total variable
                Dim total As Integer
                'calculates total by looping through each row
                For i = 0 To DGV.Rows.Count - 1
                    total += DGV.Rows(i).Cells(5).Value
                Next
                'Displays the required information of the bill in the bill form 
                txtTotal.Text = total
                Dim discount As Integer = (CDec(calculate.cboDiscountPercentage.Text) / 100) * total
                txtDiscount.Text = discount
                txtGrandTotal.Text = (total - discount).ToString
                txtRemarks.Text = calculate.txtRemarks.Text
            End If
        Catch ex As Exception
            'handles the runtime error
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaid.Click


        '**************************************
        '*     Saves the bill record in DB    *  
        '**************************************
        Dim MyConnection As OleDb.OleDbConnection = Nothing
        Dim MyTransaction As OleDb.OleDbTransaction = Nothing

        Try


            ' create the connection and  transaction object
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\billing_system.accdb;Jet OLEDB:Database Password=thenewboston"
            MyConnection = New OleDb.OleDbConnection(connectionString)
            MyConnection.Open()
            MyTransaction = MyConnection.BeginTransaction

            ' insert the new recipt

            Dim SQL As String = "INSERT INTO CustomerBill_table ([Date], [TableNumber], Discount, [GrandTotal], Remarks)VALUES        (:0, :1, :2, :3, :4)"
            Dim CMD1 As New OleDb.OleDbCommand
            CMD1.Connection = MyConnection
            CMD1.Transaction = MyTransaction
            CMD1.CommandText = SQL
            CMD1.Parameters.AddWithValue(":0", Now.Date.Date)
            CMD1.Parameters.AddWithValue(":1", CInt(Me.Tag))
            CMD1.Parameters.AddWithValue(":2", CDec(txtDiscount.Text))
            CMD1.Parameters.AddWithValue(":3", CDec(txtGrandTotal.Text))
            CMD1.Parameters.AddWithValue(":4", txtRemarks.Text)
            CMD1.ExecuteNonQuery()
            CMD1.Dispose()

            ' get the id for the recipt
            SQL = "select max([BillNumber]) as MAXID from CustomerBill_Table"
            Dim CMD2 As New OleDb.OleDbCommand
            CMD2.Connection = MyConnection
            CMD2.Transaction = MyTransaction
            CMD2.CommandText = SQL
            Dim ReciptID As Long = CMD2.ExecuteScalar()
            CMD2.Dispose()

            ' insert the details of the recipt
            Dim I As Integer
            For I = 0 To DGV.Rows.Count - 1

                ' get the values
                Dim itemID As String = DGV.Rows(I).Cells(0).Value
                Dim quantity As Decimal = DGV.Rows(I).Cells(4).Value
                Dim price As Decimal = DGV.Rows(I).Cells(2).Value


                ' next create a command
                Dim CMD3 As New OleDb.OleDbCommand
                SQL = "insert into BillDetails_Table " & _
                      "([BillNumber],ID,Quantity,Price) " & _
                      "values " & _
                      "(:0      ,:1     ,:2       ,:3   )"
                CMD3.Connection = MyConnection
                CMD3.Transaction = MyTransaction
                CMD3.CommandText = SQL
                CMD3.Parameters.AddWithValue(":0", ReciptID)
                CMD3.Parameters.AddWithValue(":1", itemID)
                CMD3.Parameters.AddWithValue(":2", quantity)
                CMD3.Parameters.AddWithValue(":3", price)


                CMD3.ExecuteNonQuery()
                CMD3.Dispose()

            Next


            ' all well save the changes
            MyTransaction.Commit()

            ' close connection
            MyTransaction.Dispose()
            MyConnection.Close()
            MyConnection.Dispose()



            'Displays the bill for printing
            Dim myreceipt As New Receipt
            myreceipt.Show()
            Me.Close()

        Catch ex As Exception
            '***handles the runtime error

            'if failure occurs previous state of data will be recovered
            If MyTransaction IsNot Nothing Then
                MyTransaction.Rollback()
            End If
            'closes the connection if it is still open
            If MyConnection IsNot Nothing Then
                If MyConnection.State = ConnectionState.Open Then
                    MyConnection.Close()
                End If
            End If

            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Bill_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'displays the function of active mdichild form at in status bar
        Main.sbMain.Items(1).Text = "Processes the bill of " & Me.Text
    End Sub

    Private Sub Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class