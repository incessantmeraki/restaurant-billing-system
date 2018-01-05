<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyFoodItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyFoodItems))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cboCategoryName = New System.Windows.Forms.ComboBox()
        Me.tlstripMain = New System.Windows.Forms.ToolStrip()
        Me.btnAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEditSelectedItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRemoveSelectedItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAddCategory = New System.Windows.Forms.ToolStripButton()
        Me.btnDeleteCategory = New System.Windows.Forms.ToolStripButton()
        Me.bsCategoryName = New System.Windows.Forms.BindingSource(Me.components)
        Me.Billing_systemDataSet = New WindowsApplication1.billing_systemDataSet()
        Me.Category_TableTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.Category_TableTableAdapter()
        Me.Items_TableTableAdapter = New WindowsApplication1.billing_systemDataSetTableAdapters.Items_TableTableAdapter()
        Me.bsFoodItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Category_NameLabel = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlstripMain.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.bsCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billing_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFoodItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Category_NameLabel
        '
        Category_NameLabel.AutoSize = True
        Category_NameLabel.Location = New System.Drawing.Point(12, 40)
        Category_NameLabel.Name = "Category_NameLabel"
        Category_NameLabel.Size = New System.Drawing.Size(83, 13)
        Category_NameLabel.TabIndex = 3
        Category_NameLabel.Text = "Category Name:"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.bsFoodItems
        Me.DGV.Location = New System.Drawing.Point(12, 73)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(486, 252)
        Me.DGV.TabIndex = 5
        '
        'cboCategoryName
        '
        Me.cboCategoryName.DataSource = Me.bsCategoryName
        Me.cboCategoryName.DisplayMember = "CategoryName"
        Me.cboCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoryName.FormattingEnabled = True
        Me.cboCategoryName.Location = New System.Drawing.Point(101, 37)
        Me.cboCategoryName.Name = "cboCategoryName"
        Me.cboCategoryName.Size = New System.Drawing.Size(138, 21)
        Me.cboCategoryName.TabIndex = 4
        Me.cboCategoryName.ValueMember = "Category Name"
        '
        'tlstripMain
        '
        Me.tlstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddNewItem, Me.ToolStripSeparator3, Me.btnEditSelectedItem, Me.ToolStripSeparator1, Me.btnRemoveSelectedItem})
        Me.tlstripMain.Location = New System.Drawing.Point(0, 0)
        Me.tlstripMain.Name = "tlstripMain"
        Me.tlstripMain.Size = New System.Drawing.Size(510, 25)
        Me.tlstripMain.TabIndex = 6
        Me.tlstripMain.Text = "ToolStrip1"
        '
        'btnAddNewItem
        '
        Me.btnAddNewItem.Image = CType(resources.GetObject("btnAddNewItem.Image"), System.Drawing.Image)
        Me.btnAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddNewItem.Name = "btnAddNewItem"
        Me.btnAddNewItem.Size = New System.Drawing.Size(103, 22)
        Me.btnAddNewItem.Text = "Add New Item"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEditSelectedItem
        '
        Me.btnEditSelectedItem.Image = CType(resources.GetObject("btnEditSelectedItem.Image"), System.Drawing.Image)
        Me.btnEditSelectedItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditSelectedItem.Name = "btnEditSelectedItem"
        Me.btnEditSelectedItem.Size = New System.Drawing.Size(121, 22)
        Me.btnEditSelectedItem.Text = "Edit Selected Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnRemoveSelectedItem
        '
        Me.btnRemoveSelectedItem.Image = CType(resources.GetObject("btnRemoveSelectedItem.Image"), System.Drawing.Image)
        Me.btnRemoveSelectedItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRemoveSelectedItem.Name = "btnRemoveSelectedItem"
        Me.btnRemoveSelectedItem.Size = New System.Drawing.Size(144, 22)
        Me.btnRemoveSelectedItem.Text = "Remove Selected Item"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddCategory, Me.btnDeleteCategory})
        Me.ToolStrip1.Location = New System.Drawing.Point(261, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(73, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddCategory
        '
        Me.btnAddCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAddCategory.Image = CType(resources.GetObject("btnAddCategory.Image"), System.Drawing.Image)
        Me.btnAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(23, 22)
        Me.btnAddCategory.Text = "Add Category"
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDeleteCategory.Image = CType(resources.GetObject("btnDeleteCategory.Image"), System.Drawing.Image)
        Me.btnDeleteCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(23, 22)
        Me.btnDeleteCategory.Text = "Remove Category"
        '
        'bsCategoryName
        '
        Me.bsCategoryName.DataMember = "Category_Table"
        Me.bsCategoryName.DataSource = Me.Billing_systemDataSet
        '
        'Billing_systemDataSet
        '
        Me.Billing_systemDataSet.DataSetName = "billing_systemDataSet"
        Me.Billing_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Category_TableTableAdapter
        '
        Me.Category_TableTableAdapter.ClearBeforeFill = True
        '
        'Items_TableTableAdapter
        '
        Me.Items_TableTableAdapter.ClearBeforeFill = True
        '
        'bsFoodItems
        '
        Me.bsFoodItems.DataMember = "Items_Table"
        Me.bsFoodItems.DataSource = Me.Billing_systemDataSet
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
        'ModifyFoodItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 337)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tlstripMain)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Category_NameLabel)
        Me.Controls.Add(Me.cboCategoryName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModifyFoodItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyFoodItems"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlstripMain.ResumeLayout(False)
        Me.tlstripMain.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.bsCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billing_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFoodItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents cboCategoryName As System.Windows.Forms.ComboBox
    Friend WithEvents tlstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEditSelectedItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRemoveSelectedItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAddCategory As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDeleteCategory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsFoodItems As System.Windows.Forms.BindingSource
    Friend WithEvents Billing_systemDataSet As WindowsApplication1.billing_systemDataSet
    Friend WithEvents bsCategoryName As System.Windows.Forms.BindingSource
    Friend WithEvents Category_TableTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.Category_TableTableAdapter
    Friend WithEvents Items_TableTableAdapter As WindowsApplication1.billing_systemDataSetTableAdapters.Items_TableTableAdapter
End Class
