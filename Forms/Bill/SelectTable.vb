Public Class frmTables

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'create an instance of newbill table
        Dim newBill As New Bill
        'tells that main form is the parent form of newbill
        newBill.MdiParent = Main
        'sets the text property of newbill to the number selected in combobox
        newBill.Text = "Table Number " & cboTableNumber.Text
        newBill.Tag = cboTableNumber.Text

        'if option in combobox is not selected newform is not displayed
        If cboTableNumber.SelectedIndex <> -1 Then
            Main.mnuTables.Visible = True 'adds tables menu to the main form
            newBill.Show()
            Main.LayoutMdi(MdiLayout.TileVertical) 'arranages newform in main form
            'closes show table form
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If

        
    End Sub
End Class