Public Class ModifyFoodItems

    Private Sub ModifyFoodItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewItem.Click
        Dim myAddNewItem As New AddFoodItem
        If myAddNewItem.ShowDialog = Windows.Forms.DialogResult.OK Then
            'shows the updated data after the addition in the datagrid
            Me.Items_TableTableAdapter.FillByCategoryName(Me.Billing_systemDataSet.Items_Table, cboCategoryName.Text)
        End If
    End Sub

    
    Private Sub btnRemoveSelectedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSelectedItem.Click

        ' make sure a single item is being selected
        If DGV.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        ' get the itemname of the item
        Dim itemName As String = DGV.SelectedRows(0).Cells(0).Value

        Try
            ' remove the item
            Items_TableTableAdapter.DeleteByItemName(itemName)
            'shows the updated data after the addition in the datagrid
            Me.Items_TableTableAdapter.FillByCategoryName(Me.Billing_systemDataSet.Items_Table, cboCategoryName.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btnEditSelectedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSelectedItem.Click
        'make sure an item is selected
        If DGV.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        ' get the food item name
        Dim itemName As String = DGV.SelectedRows(0).Cells(0).Value

        ' create the edit window
        Dim EditItemWindow As New EditSelectedItem

        ' fill the window with information
        EditItemWindow.FillItemInfo(itemName)
        
        If EditItemWindow.ShowDialog = Windows.Forms.DialogResult.OK Then

            'shows the updated data after the addition in the datagrid
            Me.Items_TableTableAdapter.FillByCategoryName(Me.Billing_systemDataSet.Items_Table, cboCategoryName.Text)
        End If
    End Sub

    

    Private Sub btnAddCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCategory.Click
        'create an instace of add category table and displays it
        Dim myAddCategory As New AddCategory
        myAddCategory.ShowDialog()
        'shows the updated category name 
        Me.Category_TableTableAdapter.Fill(Me.Billing_systemDataSet.Category_Table)
        'selects the category name recently added
        Me.cboCategoryName.SelectedIndex = cboCategoryName.Items.Count - 1
    End Sub

    Private Sub btnDeleteCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCategory.Click
        'creates a new table adapter
        Dim TA As New billing_systemDataSetTableAdapters.Category_TableTableAdapter
        'deletes the category name selected
        TA.Delete(cboCategoryName.Text)
        'displays the updated information
        Me.Category_TableTableAdapter.Fill(Me.Billing_systemDataSet.Category_Table)


    End Sub
End Class