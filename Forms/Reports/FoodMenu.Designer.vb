<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoodMenu))
        Me.Items_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.billing_systemDataSet = New WindowsApplication1.billing_systemDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Items_TableTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.Items_TableTableAdapter()
        CType(Me.Items_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Items_TableBindingSource
        '
        Me.Items_TableBindingSource.DataMember = "Items_Table"
        Me.Items_TableBindingSource.DataSource = Me.billing_systemDataSet
        '
        'billing_systemDataSet
        '
        Me.billing_systemDataSet.DataSetName = "billing_systemDataSet"
        Me.billing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Items_TableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.FoodMenu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 308)
        Me.ReportViewer1.TabIndex = 0
        '
        'Items_TableTableAdapter
        '
        Me.Items_TableTableAdapter.ClearBeforeFill = True
        '
        'FoodMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 308)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FoodMenu"
        Me.Text = "Food Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Items_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Items_TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents billing_systemDataSet As WindowsApplication1.billing_systemDataSet
    Friend WithEvents Items_TableTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.Items_TableTableAdapter
End Class
