Public Class Additem

    

    Private Sub ViewFoodItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Billing_systemDataSet.Category_Table' table. You can move, or remove it, as needed.
        Me.Category_TableTableAdapter.Fill(Me.Billing_systemDataSet.Category_Table)
        'fills the combobox with category names
        Me.Category_TableTableAdapter.Fill(Me.Billing_systemDataSet.Category_Table)


    End Sub




    Private Sub cboCategoryName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategoryName.SelectedValueChanged
        'displays the the items of category chosen
        Try
            Me.Items_TableTableAdapter.FillByCategoryName(Me.Billing_systemDataSet.Items_Table, cboCategoryName.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'close this form
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        
        '***sends the name of the selected food item to the calling form***'

        'If none data is selected no processing will be done
        If Not DGV1.SelectedRows.Count = 0 Then
            'sets the tag property of the current form to the item name of the seleceted row
            Me.Tag = DGV1.SelectedRows(0).Cells(1).Value
            'If users don't select the quantity number then error is displayed
            If cboQuantity.SelectedIndex = -1 Then
                MessageBox.Show("You must select Quantity", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cboQuantity.Focus()
                Exit Sub
            End If
            'returns the control to the calling form
            DialogResult = Windows.Forms.DialogResult.Retry

        End If
    End Sub


    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        'returns the control to the calling form
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class