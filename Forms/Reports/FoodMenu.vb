Public Class FoodMenu

    Private Sub FoodMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'billing_systemDataSet.CustomerBillForReport' table. You can move, or remove it, as needed.
       
        Me.Items_TableTableAdapter.Fill(Me.billing_systemDataSet.Items_Table)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class