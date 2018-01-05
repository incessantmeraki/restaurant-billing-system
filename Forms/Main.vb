Imports System.IO


Public Class Main


    Public Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        '**************************************
        '*     Code Handling Log in form      *  
        '**************************************
TryAgain:
        Try
            '***code that executes if user clicks OK button in login form***

            'create a new instance of the class login form
            Dim loginForm As New Login

            ' Displays login form as a dialog box and stores the result it returns 
            Dim result As DialogResult = loginForm.ShowDialog()

            'if user clickcs cancel button in login form the form is terminated
            If result = Windows.Forms.DialogResult.Cancel Then
                End
            End If

            'create a string which stores the password entered in the loginform
            Dim enteredPassword As String = loginForm.Tag

            'Database code to retreive the original password in the database
            Dim myTableAdapter As New billing_systemDataSetTableAdapters.UserLoginTableAdapter
            Dim myDataTable As DataTable = myTableAdapter.GetDataByUsername(loginForm.cboUsername.Text)

            'create a string which stores the original password in the database
            Dim originalPassword As String = myDataTable.Rows(0).Item(1)

            'compares entered password and orignial password
            If enteredPassword <> originalPassword Then
                MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GoTo TryAgain

            End If


            'enables and disables certain features according to the user selected
            Dim selectedUsername As String = myDataTable.Rows(0).Item(0)
            Select Case selectedUsername
                Case "Receptionist"
                    Me.mnuMaintenance.Visible = False
                    Me.mnuReports.Visible = False
                    Me.btnBackup.Visible = False
                    Me.btnDailySales.Visible = False
                    Me.btnRestore.Visible = False
                    Me.btnMonthlySales.Visible = False
                    Me.ToolStripSeparator3.Visible = False
                    Me.ToolStripSeparator4.Visible = False
                    Me.RestoreToolStripMenuItem.Visible = False
                    Me.BackupToolStripMenuItem.Visible = False
                    Me.ReportsToolStripMenuItem.Visible = False
                    Exit Select
                Case "Administrator"
                    Me.mnuPOS.Visible = False
                    Me.mnuTables.Visible = False
                    Me.ToolStripSeparator1.Visible = False
                    Me.btnNewBill.Visible = False
                    Me.AddNewBillToolStripMenuItem.Visible = False
                    Me.mnuPOSNewBill.ShortcutKeys = Nothing
            End Select
        Catch ex As Exception
            'handles error
            MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo TryAgain
        End Try
    End Sub


    Private Sub mnuMaintenanceChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaintenanceChangePassword.Click
        ' displays change password form
        Dim passwordChanger As New ChangePassword
        passwordChanger.ShowDialog()
    End Sub

    Private Sub ViewFoodItems()
        'creates new instance of viewfooditems form and displays it
        Dim myViewFoodItems As New ViewFoodItems
        myViewFoodItems.ShowDialog()
    End Sub

    Private Sub mnuFoodItemsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFoodItemsView.Click
        'calls sub procedure that dispalys the food item categorically
        Me.ViewFoodItems()
    End Sub

    Private Sub btnViewMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewMenu.Click
        'calls sub procedure that dispalys the food item categorically
        Me.ViewFoodItems()
    End Sub

    Private Sub EditFoodItems()
        'creates an instance of modify food items form 
        Dim myModifyFoodItems As New ModifyFoodItems
        'displays the modifyfood item
        ModifyFoodItems.ShowDialog()
    End Sub

    Private Sub mnuFoodItemsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFoodItemsEdit.Click
        'calls sub procedure that displays form to edit food items
        Me.EditFoodItems()
    End Sub

    Private Sub CreateNewBill()
        'displays the form that allows the user to select the table number
        Dim selectTable As New frmTables
        selectTable.ShowDialog()
    End Sub

    Private Sub mnuPOSNewBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPOSNewBill.Click
        'calls sub procedure that creates and handles new bill
        Me.CreateNewBill()
    End Sub

    Private Sub btnNewBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewBill.Click
        'call sub procedure that creates and handles new bill
        Me.CreateNewBill()
    End Sub

    Private Sub mnuExtraCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExtraCalculator.Click
        'opens notepad
        Process.Start("notepad.exe")
    End Sub

    Private Sub mnuExtraNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExtraNotepad.Click
        'opens system calculator
        Process.Start("calc.exe")
    End Sub

    Private Sub MakeBackup()
        'sets the title of backup dialog box
        SaveFileDialog.Title = "Make Backup"

        'opens the make backup dialog box and performs backup if user specifies the file name and its path
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            Try
                'stores the path of original database in a string
                Dim portfolioPath As String = My.Application.Info.DirectoryPath
                'creates a file name specified in make backup dialog box
                File.Create(SaveFileDialog.FileName).Close()
                'copies the original database
                FileCopy(portfolioPath & "\billing_system.accdb", SaveFileDialog.FileName)
                'displays successful backup message
                MessageBox.Show("Backup file created", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'handles the error by displaying error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub mnuMaintenanceBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaintenanceBackup.Click
        'calls sub procedure that displays create backup form

        Me.MakeBackup()
    End Sub

    Private Sub RestoreSystem()
        'sets the title of restore dialog box
        OpenFileDialog.Title = "Restore Backup"
        'Displays the restore dialog box and performs further process if user selects the backup file
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            Try
                'gets the path where the program resides
                Dim portfolioPath As String = My.Application.Info.DirectoryPath
                'Displays message informing user if he really want to restore the system
                If MessageBox.Show("Restoring the database will erase any changes you have made since you last backup. Are you sure you want to do this?", _
                            "Confirm Delete", _
                            MessageBoxButtons.OKCancel, _
                            MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
                    'Restore the database from a backup copy.
                    FileCopy(OpenFileDialog.FileName, portfolioPath & "\billing_system.accdb")
                    'Displays success message
                    MessageBox.Show("Database Restoration Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                'handles the error by displaying error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaintenanceRestore.Click
        'calls sub procedure that displays restore system form
        Me.RestoreSystem()
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        'calls sub procedure that displays create backup form
        Me.MakeBackup()
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        'calls sub procedure that displays restore system form
        Me.RestoreSystem()
    End Sub

    Private Sub AddNewBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewBillToolStripMenuItem.Click
        'call sub procedure that creates and handles new bill
        Me.CreateNewBill()
    End Sub

    Private Sub EditFoodItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFoodItemsToolStripMenuItem.Click
        'calls sub procedure that handles edit food items
        Me.EditFoodItems()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Displays date and time in the Status bar
        sbMain.Items(0).Text = DateTime.Today.ToShortDateString
        sbMain.Items(2).Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub mnuTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTables.Click

    End Sub
    Private Sub DisplayFoodMenu()
        'displays food menu 
        FoodMenu.Show()
    End Sub
    Private Sub FoodMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportsFoodMenu.Click
        'calls procedure that displays food menu
        Me.DisplayFoodMenu()
    End Sub

    Private Sub DisplayDailySales()
        'procedure that displays daily sales report
        DailySalesReport.Show()
    End Sub
    Private Sub mnuReportsDaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportsDaily.Click
        'calls procedure that displays daily sales report
        Me.DisplayDailySales()
    End Sub

    Private Sub btnMonthlySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthlySales.Click
        'calls procedure that disaplays monthly sales report
        Me.DisplayMonthlySales()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        'calls procedure that displays backup windows
        Me.MakeBackup()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        'calls procedure that dispalys restore windows
        Me.RestoreSystem()
    End Sub

    Private Sub DailySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailySalesReportToolStripMenuItem.Click
        'calls procedure that displays daily sales report
        Me.DisplayDailySales()
    End Sub

    Private Sub FoodMenuToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoodMenuToolStripMenuItem.Click
        'calls procedure that displays food menu
        Me.DisplayFoodMenu()
    End Sub

    Private Sub DisplayMonthlySales()
        'displays monthly sales report
        MonthlySalesReport.Show()
    End Sub
    Private Sub mnuReportsMonthly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReportsMonthly.Click
        'calls procedure that displays monthly sales report
        Me.DisplayMonthlySales()
    End Sub

    Private Sub MonthlySalesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlySalesReportToolStripMenuItem.Click
        'calls procedure that displays mothly sales report
        Me.DisplayMonthlySales()
    End Sub

    Private Sub btnDailySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDailySales.Click
        'calls procedure that displays daily sales report
        Me.DisplayDailySales()
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        'displays about form
        About.ShowDialog()
    End Sub
End Class
