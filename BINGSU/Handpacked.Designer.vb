<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Handpacked
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Handpacked))
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.preBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.VBPROJECTDataSet = New BINGSU.VBPROJECTDataSet()
        Me.HandpackedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HandpackedTableAdapter = New BINGSU.VBPROJECTDataSetTableAdapters.HandpackedTableAdapter()
        Me.TableAdapterManager = New BINGSU.VBPROJECTDataSetTableAdapters.TableAdapterManager()
        Me.HandpackedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HandpackedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.HandpackedDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CodeLabel = New System.Windows.Forms.Label()
        Stock_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        CType(Me.VBPROJECTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HandpackedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HandpackedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HandpackedBindingNavigator.SuspendLayout()
        CType(Me.HandpackedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(43, 31)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 20
        CodeLabel.Text = "Code:"
        '
        'Stock_IDLabel
        '
        Stock_IDLabel.AutoSize = True
        Stock_IDLabel.Location = New System.Drawing.Point(43, 57)
        Stock_IDLabel.Name = "Stock_IDLabel"
        Stock_IDLabel.Size = New System.Drawing.Size(52, 13)
        Stock_IDLabel.TabIndex = 22
        Stock_IDLabel.Text = "Stock ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(43, 83)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 24
        NameLabel.Text = "Name:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(43, 109)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 26
        QuantityLabel.Text = "Quantity:"
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.White
        Me.nextBtn.Location = New System.Drawing.Point(615, 117)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(81, 28)
        Me.nextBtn.TabIndex = 19
        Me.nextBtn.Text = "NEXT"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'preBtn
        '
        Me.preBtn.BackColor = System.Drawing.Color.White
        Me.preBtn.Location = New System.Drawing.Point(615, 65)
        Me.preBtn.Name = "preBtn"
        Me.preBtn.Size = New System.Drawing.Size(81, 28)
        Me.preBtn.TabIndex = 18
        Me.preBtn.Text = "PREVIOUS"
        Me.preBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(495, 143)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(81, 28)
        Me.deleteBtn.TabIndex = 17
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.Location = New System.Drawing.Point(495, 91)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(81, 28)
        Me.saveBtn.TabIndex = 16
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.White
        Me.addBtn.Location = New System.Drawing.Point(495, 39)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(81, 28)
        Me.addBtn.TabIndex = 15
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'VBPROJECTDataSet
        '
        Me.VBPROJECTDataSet.DataSetName = "VBPROJECTDataSet"
        Me.VBPROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HandpackedBindingSource
        '
        Me.HandpackedBindingSource.DataMember = "Handpacked"
        Me.HandpackedBindingSource.DataSource = Me.VBPROJECTDataSet
        '
        'HandpackedTableAdapter
        '
        Me.HandpackedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FlavourTableAdapter = Nothing
        Me.TableAdapterManager.HandpackedTableAdapter = Me.HandpackedTableAdapter
        Me.TableAdapterManager.IceCreamBaseTableAdapter = Nothing
        Me.TableAdapterManager.IngredientsTableAdapter = Nothing
        Me.TableAdapterManager.ListStockCategoryTableAdapter = Nothing
        Me.TableAdapterManager.ToppingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BINGSU.VBPROJECTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HandpackedBindingNavigator
        '
        Me.HandpackedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HandpackedBindingNavigator.BindingSource = Me.HandpackedBindingSource
        Me.HandpackedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HandpackedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HandpackedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HandpackedBindingNavigatorSaveItem})
        Me.HandpackedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HandpackedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HandpackedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HandpackedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HandpackedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HandpackedBindingNavigator.Name = "HandpackedBindingNavigator"
        Me.HandpackedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HandpackedBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.HandpackedBindingNavigator.TabIndex = 20
        Me.HandpackedBindingNavigator.Text = "BindingNavigator1"
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
        'HandpackedBindingNavigatorSaveItem
        '
        Me.HandpackedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HandpackedBindingNavigatorSaveItem.Image = CType(resources.GetObject("HandpackedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HandpackedBindingNavigatorSaveItem.Name = "HandpackedBindingNavigatorSaveItem"
        Me.HandpackedBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HandpackedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'HandpackedDataGridView
        '
        Me.HandpackedDataGridView.AutoGenerateColumns = False
        Me.HandpackedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HandpackedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.HandpackedDataGridView.DataSource = Me.HandpackedBindingSource
        Me.HandpackedDataGridView.Location = New System.Drawing.Point(46, 29)
        Me.HandpackedDataGridView.Name = "HandpackedDataGridView"
        Me.HandpackedDataGridView.Size = New System.Drawing.Size(443, 146)
        Me.HandpackedDataGridView.TabIndex = 20
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
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HandpackedBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(118, 28)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(127, 20)
        Me.CodeTextBox.TabIndex = 21
        '
        'Stock_IDTextBox
        '
        Me.Stock_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HandpackedBindingSource, "Stock ID", True))
        Me.Stock_IDTextBox.Location = New System.Drawing.Point(118, 54)
        Me.Stock_IDTextBox.Name = "Stock_IDTextBox"
        Me.Stock_IDTextBox.Size = New System.Drawing.Size(127, 20)
        Me.Stock_IDTextBox.TabIndex = 23
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HandpackedBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(118, 80)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(127, 20)
        Me.NameTextBox.TabIndex = 25
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HandpackedBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(118, 106)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(127, 20)
        Me.QuantityTextBox.TabIndex = 27
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(51, 437)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(81, 28)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "BACK"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(CodeLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.CodeTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Stock_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Stock_IDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 151)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Handpacked"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.HandpackedDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 226)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 197)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Handpacked Stock List"
        '
        'Handpacked
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 477)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.HandpackedBindingNavigator)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.preBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Name = "Handpacked"
        Me.Text = "Handpacked"
        CType(Me.VBPROJECTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HandpackedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HandpackedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HandpackedBindingNavigator.ResumeLayout(False)
        Me.HandpackedBindingNavigator.PerformLayout()
        CType(Me.HandpackedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextBtn As Button
    Friend WithEvents preBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents VBPROJECTDataSet As VBPROJECTDataSet
    Friend WithEvents HandpackedBindingSource As BindingSource
    Friend WithEvents HandpackedTableAdapter As VBPROJECTDataSetTableAdapters.HandpackedTableAdapter
    Friend WithEvents TableAdapterManager As VBPROJECTDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HandpackedBindingNavigator As BindingNavigator
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
    Friend WithEvents HandpackedBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents HandpackedDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents Stock_IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
