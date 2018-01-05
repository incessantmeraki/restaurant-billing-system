Public Class AddCategory

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            'validates the text entered in the textbox
            If Validator.IsPresent(txtCategoryName) AndAlso Validator.LengthCheck(txtCategoryName) Then
                'stores the text entered in textbox into variable named categoryName
                Dim categoryName As String = txtCategoryName.Text
                'creates an instance of table adapter for category table
                Dim TA As New billing_systemDataSetTableAdapters.Category_TableTableAdapter
                'insert the entered text into category table
                TA.Insert(categoryName)
            End If
            'stores the name of category 
            Me.Tag = txtCategoryName.Text
            'controls the transfer to the calling code
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class