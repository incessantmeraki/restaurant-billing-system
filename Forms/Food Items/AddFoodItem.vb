'Used to import the namespace that contains the validator class
Imports WindowsApplication1.Validator
Public Class AddFoodItem

    Private Sub txtAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If IsValidData() Then
            Try
                'create a new table adapter of items table
                Dim myTableAdapter As New billing_systemDataSetTableAdapters.Items_TableTableAdapter
                'inserts the values entered in textobox to the database
                myTableAdapter.Insert(txtFoodName.Text, CDec(txtPrice.Text), txtCategory.Text)
                'returns result to the calling form as OK
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        Else
            Exit Sub
        End If
    End Sub

    'Performs validation text using the validator class
    Private Function IsValidData() As Boolean
        Return IsPresent(txtFoodName) AndAlso IsPresent(txtPrice) AndAlso IsDecimal(txtPrice) AndAlso IsWithinRange(txtPrice, 10, 1500)
    End Function

    Private Sub AddFoodItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCategory.Text = ModifyFoodItems.cboCategoryName.Text
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class