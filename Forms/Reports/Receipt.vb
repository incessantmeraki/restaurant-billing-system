Public Class Receipt

    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyConnection As OleDb.OleDbConnection = Nothing
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\billing_system.accdb;Jet OLEDB:Database Password=thenewboston"
        MyConnection = New OleDb.OleDbConnection(connectionString)
        MyConnection.Open()
        ' get the id for the recipt
        Dim Sql As String = "select max([BillNumber]) as MAXID from CustomerBill_Table"
        Dim CMD2 As New OleDb.OleDbCommand
        CMD2.Connection = MyConnection
        CMD2.CommandText = Sql
        Dim ReciptID As Integer = CMD2.ExecuteScalar()
        CMD2.Dispose()
        MyConnection.Close()

        'TODO: This line of code loads data into the 'billing_systemDataSet.Receipt' table. You can move, or remove it, as needed.
        Me.ReceiptTableAdapter.Fill(Me.billing_systemDataSet.Receipt, ReciptID)

        Me.rvReceipt.RefreshReport()
    End Sub

    Private Sub rvReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rvReceipt.Load

    End Sub
End Class