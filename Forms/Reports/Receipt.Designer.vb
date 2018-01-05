<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt))
        Me.ReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.billing_systemDataSet = New WindowsApplication1.billing_systemDataSet()
        Me.rvReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReceiptTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.ReceiptTableAdapter()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReceiptBindingSource
        '
        Me.ReceiptBindingSource.DataMember = "Receipt"
        Me.ReceiptBindingSource.DataSource = Me.billing_systemDataSet
        '
        'billing_systemDataSet
        '
        Me.billing_systemDataSet.DataSetName = "billing_systemDataSet"
        Me.billing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvReceipt
        '
        Me.rvReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReceiptBindingSource
        Me.rvReceipt.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvReceipt.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Receipt.rdlc"
        Me.rvReceipt.Location = New System.Drawing.Point(0, 0)
        Me.rvReceipt.Name = "rvReceipt"
        Me.rvReceipt.Size = New System.Drawing.Size(423, 312)
        Me.rvReceipt.TabIndex = 0
        '
        'ReceiptTableAdapter
        '
        Me.ReceiptTableAdapter.ClearBeforeFill = True
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 312)
        Me.Controls.Add(Me.rvReceipt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvReceipt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReceiptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents billing_systemDataSet As WindowsApplication1.billing_systemDataSet
    Friend WithEvents ReceiptTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.ReceiptTableAdapter
End Class
