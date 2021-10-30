<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingredient
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
        Dim CodeLabel As System.Windows.Forms.Label
        Dim Stock_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingredient))
        Me.VBPROJECTDataSet = New BINGSU.VBPROJECTDataSet()
        Me.IngredientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngredientsTableAdapter = New BINGSU.VBPROJECTDataSetTableAdapters.IngredientsTableAdapter()
        Me.TableAdapterManager = New BINGSU.VBPROJECTDataSetTableAdapters.TableAdapterManager()
        Me.IngredientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IngredientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.IngredientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.preBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CodeLabel = New System.Windows.Forms.Label()
        Stock_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        CType(Me.VBPROJECTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IngredientsBindingNavigator.SuspendLayout()
        CType(Me.IngredientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(55, 29)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 1
        CodeLabel.Text = "Code:"
        '
        'Stock_IDLabel
        '
        Stock_IDLabel.AutoSize = True
        Stock_IDLabel.Location = New System.Drawing.Point(55, 55)
        Stock_IDLabel.Name = "Stock_IDLabel"
        Stock_IDLabel.Size = New System.Drawing.Size(52, 13)
        Stock_IDLabel.TabIndex = 3
        Stock_IDLabel.Text = "Stock ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(55, 81)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(55, 107)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 7
        QuantityLabel.Text = "Quantity:"
        '
        'VBPROJECTDataSet
        '
        Me.VBPROJECTDataSet.DataSetName = "VBPROJECTDataSet"
        Me.VBPROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IngredientsBindingSource
        '
        Me.IngredientsBindingSource.DataMember = "Ingredients"
        Me.IngredientsBindingSource.DataSource = Me.VBPROJECTDataSet
        '
        'IngredientsTableAdapter
        '
        Me.IngredientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FlavourTableAdapter = Nothing
        Me.TableAdapterManager.HandpackedTableAdapter = Nothing
        Me.TableAdapterManager.IceCreamBaseTableAdapter = Nothing
        Me.TableAdapterManager.IngredientsTableAdapter = Me.IngredientsTableAdapter
        Me.TableAdapterManager.ListStockCategoryTableAdapter = Nothing
        Me.TableAdapterManager.ToppingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BINGSU.VBPROJECTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IngredientsBindingNavigator
        '
        Me.IngredientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IngredientsBindingNavigator.BindingSource = Me.IngredientsBindingSource
        Me.IngredientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IngredientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IngredientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IngredientsBindingNavigatorSaveItem})
        Me.IngredientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IngredientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IngredientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IngredientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IngredientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IngredientsBindingNavigator.Name = "IngredientsBindingNavigator"
        Me.IngredientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IngredientsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.IngredientsBindingNavigator.TabIndex = 0
        Me.IngredientsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IngredientsBindingNavigatorSaveItem
        '
        Me.IngredientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IngredientsBindingNavigatorSaveItem.Image = CType(resources.GetObject("IngredientsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IngredientsBindingNavigatorSaveItem.Name = "IngredientsBindingNavigatorSaveItem"
        Me.IngredientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IngredientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientsBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(113, 26)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(191, 20)
        Me.CodeTextBox.TabIndex = 2
        '
        'Stock_IDTextBox
        '
        Me.Stock_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientsBindingSource, "Stock ID", True))
        Me.Stock_IDTextBox.Location = New System.Drawing.Point(113, 52)
        Me.Stock_IDTextBox.Name = "Stock_IDTextBox"
        Me.Stock_IDTextBox.Size = New System.Drawing.Size(191, 20)
        Me.Stock_IDTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(113, 78)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(191, 20)
        Me.NameTextBox.TabIndex = 6
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IngredientsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(113, 104)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(191, 20)
        Me.QuantityTextBox.TabIndex = 8
        '
        'IngredientsDataGridView
        '
        Me.IngredientsDataGridView.AutoGenerateColumns = False
        Me.IngredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngredientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.IngredientsDataGridView.DataSource = Me.IngredientsBindingSource
        Me.IngredientsDataGridView.Location = New System.Drawing.Point(34, 32)
        Me.IngredientsDataGridView.Name = "IngredientsDataGridView"
        Me.IngredientsDataGridView.Size = New System.Drawing.Size(443, 154)
        Me.IngredientsDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Stock ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Stock ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.White
        Me.addBtn.Location = New System.Drawing.Point(498, 54)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(81, 28)
        Me.addBtn.TabIndex = 10
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.Location = New System.Drawing.Point(498, 106)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(81, 28)
        Me.saveBtn.TabIndex = 11
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(498, 158)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(81, 28)
        Me.deleteBtn.TabIndex = 12
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'preBtn
        '
        Me.preBtn.BackColor = System.Drawing.Color.White
        Me.preBtn.Location = New System.Drawing.Point(618, 80)
        Me.preBtn.Name = "preBtn"
        Me.preBtn.Size = New System.Drawing.Size(81, 28)
        Me.preBtn.TabIndex = 13
        Me.preBtn.Text = "PREVIOUS"
        Me.preBtn.UseVisualStyleBackColor = False
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.White
        Me.nextBtn.Location = New System.Drawing.Point(618, 132)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(81, 28)
        Me.nextBtn.TabIndex = 14
        Me.nextBtn.Text = "NEXT"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(69, 478)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 30)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "BACK"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CodeTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.Stock_IDTextBox)
        Me.GroupBox1.Controls.Add(Stock_IDLabel)
        Me.GroupBox1.Controls.Add(CodeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 147)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingredients"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IngredientsDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(69, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 210)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingredients Stock List"
        '
        'Ingredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 520)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.preBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.IngredientsBindingNavigator)
        Me.Name = "Ingredient"
        Me.Text = "BINGSU | Ingredients"
        CType(Me.VBPROJECTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IngredientsBindingNavigator.ResumeLayout(False)
        Me.IngredientsBindingNavigator.PerformLayout()
        CType(Me.IngredientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VBPROJECTDataSet As VBPROJECTDataSet
    Friend WithEvents IngredientsBindingSource As BindingSource
    Friend WithEvents IngredientsTableAdapter As VBPROJECTDataSetTableAdapters.IngredientsTableAdapter
    Friend WithEvents TableAdapterManager As VBPROJECTDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IngredientsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IngredientsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents Stock_IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents IngredientsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents addBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents preBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
