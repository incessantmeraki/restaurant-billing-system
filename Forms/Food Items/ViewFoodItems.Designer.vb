<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFoodItems
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
        Dim Category_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewFoodItems))
        Me.cboCategoryName = New System.Windows.Forms.ComboBox()
        Me.Items_TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.Billing_systemDataSet = New WindowsApplication1.billing_systemDataSet()
        Me.bsCategoryName = New System.Windows.Forms.BindingSource(Me.components)
        Me.Category_TableTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.Category_TableTableAdapter()
        Me.bsFoodItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.Items_TableTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.Items_TableTableAdapter()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Category_NameLabel = New System.Windows.Forms.Label()
        CType(Me.Items_TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFoodItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Category_NameLabel
        '
        Category_NameLabel.AutoSize = True
        Category_NameLabel.Location = New System.Drawing.Point(34, 23)
        Category_NameLabel.Name = "Category_NameLabel"
        Category_NameLabel.Size = New System.Drawing.Size(83, 13)
        Category_NameLabel.TabIndex = 1
        Category_NameLabel.Text = "Category Name:"
        '
        'cboCategoryName
        '
        Me.cboCategoryName.DataSource = Me.bsCategoryName
        Me.cboCategoryName.DisplayMember = "CategoryName"
        Me.cboCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoryName.FormattingEnabled = True
        Me.cboCategoryName.Location = New System.Drawing.Point(123, 20)
        Me.cboCategoryName.Name = "cboCategoryName"
        Me.cboCategoryName.Size = New System.Drawing.Size(138, 21)
        Me.cboCategoryName.TabIndex = 2
        Me.cboCategoryName.ValueMember = "Category Name"
        '
        'Items_TableDataGridView
        '
        Me.Items_TableDataGridView.AllowUserToAddRows = False
        Me.Items_TableDataGridView.AllowUserToDeleteRows = False
        Me.Items_TableDataGridView.AllowUserToResizeColumns = False
        Me.Items_TableDataGridView.AllowUserToResizeRows = False
        Me.Items_TableDataGridView.AutoGenerateColumns = False
        Me.Items_TableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Items_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Items_TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.Items_TableDataGridView.DataSource = Me.bsFoodItems
        Me.Items_TableDataGridView.Location = New System.Drawing.Point(22, 62)
        Me.Items_TableDataGridView.MultiSelect = False
        Me.Items_TableDataGridView.Name = "Items_TableDataGridView"
        Me.Items_TableDataGridView.ReadOnly = True
        Me.Items_TableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Items_TableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Items_TableDataGridView.Size = New System.Drawing.Size(462, 251)
        Me.Items_TableDataGridView.TabIndex = 2
        '
        'Billing_systemDataSet
        '
        Me.Billing_systemDataSet.DataSetName = "billing_systemDataSet"
        Me.Billing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsCategoryName
        '
        Me.bsCategoryName.DataMember = "Category_Table"
        Me.bsCategoryName.DataSource = Me.Billing_systemDataSet
        '
        'Category_TableTableAdapter
        '
        Me.Category_TableTableAdapter.ClearBeforeFill = True
        '
        'bsFoodItems
        '
        Me.bsFoodItems.DataMember = "Items_Table"
        Me.bsFoodItems.DataSource = Me.Billing_systemDataSet
        '
        'Items_TableTableAdapter
        '
        Me.Items_TableTableAdapter.ClearBeforeFill = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewFoodItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 337)
        Me.Controls.Add(Me.Items_TableDataGridView)
        Me.Controls.Add(Category_NameLabel)
        Me.Controls.Add(Me.cboCategoryName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewFoodItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Food Items"
        CType(Me.Items_TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFoodItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCategoryName As System.Windows.Forms.ComboBox
    Friend WithEvents Items_TableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Billing_systemDataSet As WindowsApplication1.billing_systemDataSet
    Friend WithEvents bsCategoryName As System.Windows.Forms.BindingSource
    Friend WithEvents Category_TableTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.Category_TableTableAdapter
    Friend WithEvents bsFoodItems As System.Windows.Forms.BindingSource
    Friend WithEvents Items_TableTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.Items_TableTableAdapter
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
