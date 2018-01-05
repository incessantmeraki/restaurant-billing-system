Imports WindowsApplication1.Validator
Public Class EditSelectedItem

    Private Sub EditSelectedItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fills the category name text box with selected category
        txtCategory.Text = ModifyFoodItems.cboCategoryName.Text
    End Sub

    'this method is used to fill the information
    Public Sub FillItemInfo(ByVal itemname As String)
        ItemsTA.FillByItemName(MyDS.Items_Table, itemname)

    End Sub

    'Performs validation text using the validator class
    Private Function IsValidData() As Boolean
        Return IsPresent(txtFoodName) AndAlso IsPresent(txtPrice) AndAlso IsDecimal(txtPrice) AndAlso IsWithinRange(txtPrice, 10, 1500)
    End Function
    
    Private Sub txtUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If IsValidData() Then
            Try
                ' create the adapter
                Dim TA As New billing_systemDataSetTableAdapters.Items_TableTableAdapter

                'insert the item
                BS.EndEdit()
                TA.Update(MyDS.Items_Table)

                'returns result to the calling form as OK
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'closes the edit dialog box
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    

    
End Class