Public Class Calculate

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        'validates the combobox and returns the control to calling form
        If cboDiscountPercentage.SelectedIndex <> -1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'returns the control to calling form
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class