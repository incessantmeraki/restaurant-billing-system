Public Class ChangePassword

    

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        '**************************************
        '*   Code Handling Password Changer   *  
        '**************************************
        Try


            ' validate the new password
            If txtNewPassword.Text = "" Then
                MessageBox.Show("You should enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPassword.Focus()
                Exit Sub
            End If

            If txtNewPassword.Text <> txtNewPasswordAgain.Text Then
                MessageBox.Show("The password does not match its confirmation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNewPassword.Focus()
                Exit Sub
            End If

            ' get the original password
            Dim myTableAdapter As New billing_systemDataSetTableAdapters.UserLoginTableAdapter
            Dim myDataTable As DataTable = myTableAdapter.GetDataByUsername(cboUsername.Text)
            Dim originalPassword As String = myDataTable.Rows(0).Item(1)

            'check if the old password is correct
            If originalPassword <> txtOldPassword.Text Then
                MessageBox.Show("The old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtOldPassword.Focus()
                Exit Sub
            End If

            ' everything went well, so we are going to update the password in the db
            Dim rowChanged As Integer = myTableAdapter.UpdatePassword(txtNewPassword.Text, cboUsername.Text)
            If rowChanged = 0 Then
                MessageBox.Show("Password not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK


        Catch ex As Exception
            ' handle the error
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            Exit Sub
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'user cancels the change
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Billing_systemDataSet.UserLogin' table. You can move, or remove it, as needed.
        Me.UserLoginTableAdapter.Fill(Me.Billing_systemDataSet.UserLogin)
        ' This line of code loads data into the 'Billing_systemDataSet.UserLogin' table.
        Me.UserLoginTableAdapter.Fill(Me.Billing_systemDataSet.UserLogin)

       
    End Sub
End Class