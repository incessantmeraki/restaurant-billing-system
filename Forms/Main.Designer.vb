<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPOSNewBill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFoodItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFoodItemsView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFoodItemsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportsDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportsMonthly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportsFoodMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintenance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintenanceBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintenanceRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintenanceChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExtra = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExtraCalculator = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExtraNotepad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNewBill = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnViewMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDailySales = New System.Windows.Forms.ToolStripButton()
        Me.btnMonthlySales = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBackup = New System.Windows.Forms.ToolStripButton()
        Me.btnRestore = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnHelp = New System.Windows.Forms.ToolStripButton()
        Me.sbMain = New System.Windows.Forms.StatusStrip()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDescription = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddNewBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditFoodItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailySalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlySalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.sbMain.SuspendLayout()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPOS, Me.mnuTables, Me.mnuFoodItems, Me.mnuReports, Me.mnuMaintenance, Me.mnuExtra, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.mnuTables
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuPOS
        '
        Me.mnuPOS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPOSNewBill})
        Me.mnuPOS.Name = "mnuPOS"
        Me.mnuPOS.Size = New System.Drawing.Size(41, 20)
        Me.mnuPOS.Text = "POS"
        '
        'mnuPOSNewBill
        '
        Me.mnuPOSNewBill.Image = CType(resources.GetObject("mnuPOSNewBill.Image"), System.Drawing.Image)
        Me.mnuPOSNewBill.Name = "mnuPOSNewBill"
        Me.mnuPOSNewBill.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuPOSNewBill.Size = New System.Drawing.Size(160, 22)
        Me.mnuPOSNewBill.Text = "New Bill"
        '
        'mnuTables
        '
        Me.mnuTables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuTables.Name = "mnuTables"
        Me.mnuTables.Size = New System.Drawing.Size(53, 20)
        Me.mnuTables.Text = "Tables"
        Me.mnuTables.Visible = False
        '
        'mnuFoodItems
        '
        Me.mnuFoodItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFoodItemsView, Me.mnuFoodItemsEdit})
        Me.mnuFoodItems.Name = "mnuFoodItems"
        Me.mnuFoodItems.Size = New System.Drawing.Size(78, 20)
        Me.mnuFoodItems.Text = "Food Items"
        '
        'mnuFoodItemsView
        '
        Me.mnuFoodItemsView.Image = CType(resources.GetObject("mnuFoodItemsView.Image"), System.Drawing.Image)
        Me.mnuFoodItemsView.Name = "mnuFoodItemsView"
        Me.mnuFoodItemsView.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuFoodItemsView.Size = New System.Drawing.Size(140, 22)
        Me.mnuFoodItemsView.Text = "View"
        '
        'mnuFoodItemsEdit
        '
        Me.mnuFoodItemsEdit.Image = CType(resources.GetObject("mnuFoodItemsEdit.Image"), System.Drawing.Image)
        Me.mnuFoodItemsEdit.Name = "mnuFoodItemsEdit"
        Me.mnuFoodItemsEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.mnuFoodItemsEdit.Size = New System.Drawing.Size(140, 22)
        Me.mnuFoodItemsEdit.Text = "Edit"
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportsDaily, Me.mnuReportsMonthly, Me.mnuReportsFoodMenu})
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(59, 20)
        Me.mnuReports.Text = "Reports"
        '
        'mnuReportsDaily
        '
        Me.mnuReportsDaily.Image = CType(resources.GetObject("mnuReportsDaily.Image"), System.Drawing.Image)
        Me.mnuReportsDaily.Name = "mnuReportsDaily"
        Me.mnuReportsDaily.Size = New System.Drawing.Size(186, 22)
        Me.mnuReportsDaily.Text = "Daily Sales Report"
        '
        'mnuReportsMonthly
        '
        Me.mnuReportsMonthly.Image = CType(resources.GetObject("mnuReportsMonthly.Image"), System.Drawing.Image)
        Me.mnuReportsMonthly.Name = "mnuReportsMonthly"
        Me.mnuReportsMonthly.Size = New System.Drawing.Size(186, 22)
        Me.mnuReportsMonthly.Text = "Monthly Sales Report"
        '
        'mnuReportsFoodMenu
        '
        Me.mnuReportsFoodMenu.Image = CType(resources.GetObject("mnuReportsFoodMenu.Image"), System.Drawing.Image)
        Me.mnuReportsFoodMenu.Name = "mnuReportsFoodMenu"
        Me.mnuReportsFoodMenu.Size = New System.Drawing.Size(186, 22)
        Me.mnuReportsFoodMenu.Text = "Food Menu"
        '
        'mnuMaintenance
        '
        Me.mnuMaintenance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMaintenanceBackup, Me.mnuMaintenanceRestore, Me.mnuMaintenanceChangePassword})
        Me.mnuMaintenance.Name = "mnuMaintenance"
        Me.mnuMaintenance.Size = New System.Drawing.Size(88, 20)
        Me.mnuMaintenance.Text = "Maintenance"
        '
        'mnuMaintenanceBackup
        '
        Me.mnuMaintenanceBackup.Image = CType(resources.GetObject("mnuMaintenanceBackup.Image"), System.Drawing.Image)
        Me.mnuMaintenanceBackup.Name = "mnuMaintenanceBackup"
        Me.mnuMaintenanceBackup.Size = New System.Drawing.Size(168, 22)
        Me.mnuMaintenanceBackup.Text = "Make Backup"
        '
        'mnuMaintenanceRestore
        '
        Me.mnuMaintenanceRestore.Image = CType(resources.GetObject("mnuMaintenanceRestore.Image"), System.Drawing.Image)
        Me.mnuMaintenanceRestore.Name = "mnuMaintenanceRestore"
        Me.mnuMaintenanceRestore.Size = New System.Drawing.Size(168, 22)
        Me.mnuMaintenanceRestore.Text = "Restore System"
        '
        'mnuMaintenanceChangePassword
        '
        Me.mnuMaintenanceChangePassword.Image = CType(resources.GetObject("mnuMaintenanceChangePassword.Image"), System.Drawing.Image)
        Me.mnuMaintenanceChangePassword.Name = "mnuMaintenanceChangePassword"
        Me.mnuMaintenanceChangePassword.Size = New System.Drawing.Size(168, 22)
        Me.mnuMaintenanceChangePassword.Text = "Change Password"
        '
        'mnuExtra
        '
        Me.mnuExtra.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExtraCalculator, Me.mnuExtraNotepad})
        Me.mnuExtra.Name = "mnuExtra"
        Me.mnuExtra.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuExtra.Size = New System.Drawing.Size(76, 20)
        Me.mnuExtra.Text = "Extra Tools"
        '
        'mnuExtraCalculator
        '
        Me.mnuExtraCalculator.Image = CType(resources.GetObject("mnuExtraCalculator.Image"), System.Drawing.Image)
        Me.mnuExtraCalculator.Name = "mnuExtraCalculator"
        Me.mnuExtraCalculator.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuExtraCalculator.Size = New System.Drawing.Size(193, 22)
        Me.mnuExtraCalculator.Text = "Notepad"
        '
        'mnuExtraNotepad
        '
        Me.mnuExtraNotepad.Image = CType(resources.GetObject("mnuExtraNotepad.Image"), System.Drawing.Image)
        Me.mnuExtraNotepad.Name = "mnuExtraNotepad"
        Me.mnuExtraNotepad.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuExtraNotepad.Size = New System.Drawing.Size(193, 22)
        Me.mnuExtraNotepad.Text = "Calculator"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpView, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpView
        '
        Me.mnuHelpView.Image = CType(resources.GetObject("mnuHelpView.Image"), System.Drawing.Image)
        Me.mnuHelpView.Name = "mnuHelpView"
        Me.mnuHelpView.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpView.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpView.Text = "View Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Image = CType(resources.GetObject("mnuHelpAbout.Image"), System.Drawing.Image)
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewBill, Me.ToolStripSeparator1, Me.btnViewMenu, Me.ToolStripSeparator2, Me.btnDailySales, Me.btnMonthlySales, Me.ToolStripSeparator3, Me.btnBackup, Me.btnRestore, Me.ToolStripSeparator4, Me.btnHelp})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(489, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNewBill
        '
        Me.btnNewBill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNewBill.Image = CType(resources.GetObject("btnNewBill.Image"), System.Drawing.Image)
        Me.btnNewBill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewBill.Name = "btnNewBill"
        Me.btnNewBill.Size = New System.Drawing.Size(23, 22)
        Me.btnNewBill.Text = "Add New Bill"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnViewMenu
        '
        Me.btnViewMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnViewMenu.Image = CType(resources.GetObject("btnViewMenu.Image"), System.Drawing.Image)
        Me.btnViewMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnViewMenu.Name = "btnViewMenu"
        Me.btnViewMenu.Size = New System.Drawing.Size(23, 22)
        Me.btnViewMenu.Text = "View Food Items"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnDailySales
        '
        Me.btnDailySales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDailySales.Image = CType(resources.GetObject("btnDailySales.Image"), System.Drawing.Image)
        Me.btnDailySales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDailySales.Name = "btnDailySales"
        Me.btnDailySales.Size = New System.Drawing.Size(23, 22)
        Me.btnDailySales.Text = "Daily Sales Report"
        '
        'btnMonthlySales
        '
        Me.btnMonthlySales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMonthlySales.Image = CType(resources.GetObject("btnMonthlySales.Image"), System.Drawing.Image)
        Me.btnMonthlySales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMonthlySales.Name = "btnMonthlySales"
        Me.btnMonthlySales.Size = New System.Drawing.Size(23, 22)
        Me.btnMonthlySales.Text = "Monthly Sales Report"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnBackup
        '
        Me.btnBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(23, 22)
        Me.btnBackup.Text = "Make Backup"
        '
        'btnRestore
        '
        Me.btnRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRestore.Image = CType(resources.GetObject("btnRestore.Image"), System.Drawing.Image)
        Me.btnRestore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(23, 22)
        Me.btnRestore.Text = "Restore"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnHelp
        '
        Me.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(23, 22)
        Me.btnHelp.Text = "Help"
        '
        'sbMain
        '
        Me.sbMain.BackColor = System.Drawing.SystemColors.Control
        Me.sbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDate, Me.lblDescription, Me.lblTime})
        Me.sbMain.Location = New System.Drawing.Point(0, 390)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.Size = New System.Drawing.Size(489, 22)
        Me.sbMain.TabIndex = 3
        Me.sbMain.Text = "StatusStrip1"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = False
        Me.lblDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(75, 17)
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescription.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblDescription.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(324, 17)
        Me.lblDescription.Spring = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = False
        Me.lblTime.BackColor = System.Drawing.SystemColors.Control
        Me.lblTime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(75, 17)
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "BackupFile|*.bkp"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        Me.OpenFileDialog.Filter = "Backup|*.bkp"
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBillToolStripMenuItem, Me.EditFoodItemsToolStripMenuItem, Me.BackupToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(157, 136)
        '
        'AddNewBillToolStripMenuItem
        '
        Me.AddNewBillToolStripMenuItem.Image = CType(resources.GetObject("AddNewBillToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewBillToolStripMenuItem.Name = "AddNewBillToolStripMenuItem"
        Me.AddNewBillToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AddNewBillToolStripMenuItem.Text = "Add New Bill"
        '
        'EditFoodItemsToolStripMenuItem
        '
        Me.EditFoodItemsToolStripMenuItem.Image = CType(resources.GetObject("EditFoodItemsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditFoodItemsToolStripMenuItem.Name = "EditFoodItemsToolStripMenuItem"
        Me.EditFoodItemsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EditFoodItemsToolStripMenuItem.Text = "Edit Food Items"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Image = CType(resources.GetObject("BackupToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Image = CType(resources.GetObject("RestoreToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailySalesReportToolStripMenuItem, Me.MonthlySalesReportToolStripMenuItem, Me.FoodMenuToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'DailySalesReportToolStripMenuItem
        '
        Me.DailySalesReportToolStripMenuItem.Image = CType(resources.GetObject("DailySalesReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DailySalesReportToolStripMenuItem.Name = "DailySalesReportToolStripMenuItem"
        Me.DailySalesReportToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DailySalesReportToolStripMenuItem.Text = "Daily Sales Report"
        '
        'MonthlySalesReportToolStripMenuItem
        '
        Me.MonthlySalesReportToolStripMenuItem.Image = CType(resources.GetObject("MonthlySalesReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MonthlySalesReportToolStripMenuItem.Name = "MonthlySalesReportToolStripMenuItem"
        Me.MonthlySalesReportToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MonthlySalesReportToolStripMenuItem.Text = "Monthly Sales Report"
        '
        'FoodMenuToolStripMenuItem
        '
        Me.FoodMenuToolStripMenuItem.Image = CType(resources.GetObject("FoodMenuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FoodMenuToolStripMenuItem.Name = "FoodMenuToolStripMenuItem"
        Me.FoodMenuToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.FoodMenuToolStripMenuItem.Text = "Food Menu"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(489, 412)
        Me.ContextMenuStrip = Me.ctxMenu
        Me.Controls.Add(Me.sbMain)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "5 Monkeys Billing System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.sbMain.ResumeLayout(False)
        Me.sbMain.PerformLayout()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFoodItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFoodItemsView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportsDaily As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportsMonthly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMaintenance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMaintenanceBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExtra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExtraCalculator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExtraNotepad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPOSNewBill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFoodItemsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNewBill As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnViewMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDailySales As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMonthlySales As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBackup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuHelpView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sbMain As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuTables As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMaintenanceRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMaintenanceChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnRestore As System.Windows.Forms.ToolStripButton
    Friend WithEvents ctxMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddNewBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditFoodItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDescription As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mnuReportsFoodMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailySalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlySalesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoodMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
