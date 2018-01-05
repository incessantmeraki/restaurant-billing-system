Public Class ViewFoodItems

        Private Sub ViewFoodItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Billing_systemDataSet.Items_Table' table. You can move, or remove it, as needed.
        Me.Items_TableTableAdapter.Fill(Me.Billing_systemDataSet.Items_Table)
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
End Class