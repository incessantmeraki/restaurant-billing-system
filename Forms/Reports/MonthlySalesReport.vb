Public Class MonthlySalesReport

    Private Sub MonthlySalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub grpCriteria_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCriteria.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub rvMonthly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rvMonthly.Load

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'checks whether user has selected year and month or not
        If cboYear.SelectedIndex = -1 OrElse cboMonth.SelectedIndex = -1 Then
            MessageBox.Show("Year and Month must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' This line of code loads data into the 'billing_systemDataSet.CustomerBill_table' table. You can move, or remove it, as needed.
        Me.CustomerBill_tableTableAdapter.FillByYearandMonth(Me.billing_systemDataSet.CustomerBill_table, cboYear.Text, cboMonth.SelectedIndex + 1)

        Me.rvMonthly.RefreshReport()
    End Sub
End Class