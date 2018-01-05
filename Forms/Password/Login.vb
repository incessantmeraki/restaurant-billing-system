Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Billing_systemDataSet.UserLogin' table. You can move, or remove it, as needed.
        Me.UserLoginTableAdapter.Fill(Me.Billing_systemDataSet.UserLogin)
        ' This line of code loads data into the 'Billing_systemDataSet.UserLogin' table
        Me.UserLoginTableAdapter.Fill(Me.Billing_systemDataSet.UserLogin)


    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Tag = txtPassword.Text
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class