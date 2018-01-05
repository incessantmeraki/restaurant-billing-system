<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlySalesReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonthlySalesReport))
        Me.CustomerBill_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.billing_systemDataSet = New WindowsApplication1.billing_systemDataSet()
        Me.grpCriteria = New System.Windows.Forms.GroupBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.rvMonthly = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CustomerBill_tableTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.CustomerBill_tableTableAdapter()
        CType(Me.CustomerBill_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCriteria.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerBill_tableBindingSource
        '
        Me.CustomerBill_tableBindingSource.DataMember = "CustomerBill_table"
        Me.CustomerBill_tableBindingSource.DataSource = Me.billing_systemDataSet
        '
        'billing_systemDataSet
        '
        Me.billing_systemDataSet.DataSetName = "billing_systemDataSet"
        Me.billing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpCriteria
        '
        Me.grpCriteria.Controls.Add(Me.cboMonth)
        Me.grpCriteria.Controls.Add(Me.cboYear)
        Me.grpCriteria.Controls.Add(Me.Label2)
        Me.grpCriteria.Controls.Add(Me.Label1)
        Me.grpCriteria.Controls.Add(Me.btnShow)
        Me.grpCriteria.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpCriteria.Location = New System.Drawing.Point(0, 0)
        Me.grpCriteria.Name = "grpCriteria"
        Me.grpCriteria.Size = New System.Drawing.Size(405, 130)
        Me.grpCriteria.TabIndex = 0
        Me.grpCriteria.TabStop = False
        Me.grpCriteria.Text = "Search Criteria"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cboMonth.Location = New System.Drawing.Point(227, 26)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(82, 21)
        Me.cboMonth.TabIndex = 4
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2012" & Global.Microsoft.VisualBasic.ChrW(9), "2013", "2014", "2015", "2016"})
        Me.cboYear.Location = New System.Drawing.Point(65, 26)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(60, 21)
        Me.cboYear.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Month"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(22, 77)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(200, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Report"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'rvMonthly
        '
        Me.rvMonthly.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CustomerBill_tableBindingSource
        Me.rvMonthly.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvMonthly.LocalReport.ReportEmbeddedResource = "WindowsApplication1.MonthlySalesReport.rdlc"
        Me.rvMonthly.Location = New System.Drawing.Point(0, 130)
        Me.rvMonthly.Name = "rvMonthly"
        Me.rvMonthly.Size = New System.Drawing.Size(405, 206)
        Me.rvMonthly.TabIndex = 1
        '
        'CustomerBill_tableTableAdapter
        '
        Me.CustomerBill_tableTableAdapter.ClearBeforeFill = True
        '
        'MonthlySalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 336)
        Me.Controls.Add(Me.rvMonthly)
        Me.Controls.Add(Me.grpCriteria)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MonthlySalesReport"
        Me.Text = "Monthly Sales Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CustomerBill_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCriteria.ResumeLayout(False)
        Me.grpCriteria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCriteria As System.Windows.Forms.GroupBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents rvMonthly As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerBill_tableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents billing_systemDataSet As WindowsApplication1.billing_systemDataSet
    Friend WithEvents CustomerBill_tableTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.CustomerBill_tableTableAdapter
End Class
