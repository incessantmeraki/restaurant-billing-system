Public Class DailySalesReport

    Private Sub DailySalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'billing_systemDataSet.CustomerBill_table' table. You can move, or remove it, as needed.
        Me.CustomerBill_tableTableAdapter.Fill(Me.billing_systemDataSet.CustomerBill_table)

    End Sub

    
    

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'TODO: This line of code loads data into the 'billing_systemDataSet.CustomerBill_table' table. You can move, or remove it, as needed.
        Me.CustomerBill_tableTableAdapter.FillByDate(Me.billing_systemDataSet.CustomerBill_table, DateTimePicker1.Value.Date)
        Me.rvDaily.RefreshReport()
    End Sub
End Class