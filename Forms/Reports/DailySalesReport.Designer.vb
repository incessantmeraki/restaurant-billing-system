<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailySalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailySalesReport))
        Me.CustomerBill_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.billing_systemDataSet = New WindowsApplication1.billing_systemDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.grpReport = New System.Windows.Forms.GroupBox()
        Me.rvDaily = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CustomerBill_tableTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.CustomerBill_tableTableAdapter()
        CType(Me.CustomerBill_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerBill_tableBindingSource
        '
        Me.CustomerBill_tableBindingSource.DataMember = "CustomerBill_table"
        Me.CustomerBill_tableBindingSource.DataSource = Me.billing_systemDataSet
        '
        'billing_systemDataSet
        '
        Me.billing_systemDataSet.DataSetName = "billing_systemDataset"
        Me.billing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Criteria"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(94, 55)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(200, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Day:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(94, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'grpReport
        '
        Me.grpReport.Controls.Add(Me.rvDaily)
        Me.grpReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpReport.Location = New System.Drawing.Point(0, 85)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(357, 247)
        Me.grpReport.TabIndex = 1
        Me.grpReport.TabStop = False
        Me.grpReport.Text = "Report"
        '
        'rvDaily
        '
        Me.rvDaily.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CustomerBill_tableBindingSource
        Me.rvDaily.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvDaily.LocalReport.ReportEmbeddedResource = "WindowsApplication1.DailySalesReport.rdlc"
        Me.rvDaily.Location = New System.Drawing.Point(3, 16)
        Me.rvDaily.Name = "rvDaily"
        Me.rvDaily.Size = New System.Drawing.Size(351, 228)
        Me.rvDaily.TabIndex = 0
        '
        'CustomerBill_tableTableAdapter
        '
        Me.CustomerBill_tableTableAdapter.ClearBeforeFill = True
        '
        'DailySalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 332)
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DailySalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Sales Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CustomerBill_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpReport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpReport As System.Windows.Forms.GroupBox
    Friend WithEvents rvDaily As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents CustomerBill_tableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents billing_systemDataSet As WindowsApplication1.billing_systemDataSet
    Friend WithEvents CustomerBill_tableTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.CustomerBill_tableTableAdapter
End Class
