<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListStockCategory
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim Stock_CategoryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListStockCategory))
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.preBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.VBPROJECTDataSet = New BINGSU.VBPROJECTDataSet()
        Me.ListStockCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListStockCategoryTableAdapter = New BINGSU.VBPROJECTDataSetTableAdapters.ListStockCategoryTableAdapter()
        Me.TableAdapterManager = New BINGSU.VBPROJECTDataSetTableAdapters.TableAdapterManager()
        Me.ListStockCategoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ListStockCategoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ListStockCategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Stock_CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        IDLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        Stock_CategoryLabel = New System.Windows.Forms.Label()
        CType(Me.VBPROJECTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListStockCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListStockCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListStockCategoryBindingNavigator.SuspendLayout()
        CType(Me.ListStockCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(72, 31)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 26
        IDLabel.Text = "ID:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(72, 57)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 28
        CodeLabel.Text = "Code:"
        '
        'Stock_CategoryLabel
        '
        Stock_CategoryLabel.AutoSize = True
        Stock_CategoryLabel.Location = New System.Drawing.Point(72, 83)
        Stock_CategoryLabel.Name = "Stock_CategoryLabel"
        Stock_CategoryLabel.Size = New System.Drawing.Size(83, 13)
        Stock_CategoryLabel.TabIndex = 30
        Stock_CategoryLabel.Text = "Stock Category:"
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.White
        Me.nextBtn.Location = New System.Drawing.Point(606, 115)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(81, 28)
        Me.nextBtn.TabIndex = 24
        Me.nextBtn.Text = "NEXT"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'preBtn
        '
        Me.preBtn.BackColor = System.Drawing.Color.White
        Me.preBtn.Location = New System.Drawing.Point(606, 63)
        Me.preBtn.Name = "preBtn"
        Me.preBtn.Size = New System.Drawing.Size(81, 28)
        Me.preBtn.TabIndex = 23
        Me.preBtn.Text = "PREVIOUS"
        Me.preBtn.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(486, 141)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(81, 28)
        Me.deleteBtn.TabIndex = 22
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.White
        Me.savebtn.Location = New System.Drawing.Point(486, 89)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(81, 28)
        Me.savebtn.TabIndex = 21
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.White
        Me.addBtn.Location = New System.Drawing.Point(486, 37)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(81, 28)
        Me.addBtn.TabIndex = 20
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'VBPROJECTDataSet
        '
        Me.VBPROJECTDataSet.DataSetName = "VBPROJECTDataSet"
        Me.VBPROJECTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListStockCategoryBindingSource
        '
        Me.ListStockCategoryBindingSource.DataMember = "ListStockCategory"
        Me.ListStockCategoryBindingSource.DataSource = Me.VBPROJECTDataSet
        '
        'ListStockCategoryTableAdapter
        '
        Me.ListStockCategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FlavourTableAdapter = Nothing
        Me.TableAdapterManager.HandpackedTableAdapter = Nothing
        Me.TableAdapterManager.IceCreamBaseTableAdapter = Nothing
        Me.TableAdapterManager.IngredientsTableAdapter = Nothing
        Me.TableAdapterManager.ListStockCategoryTableAdapter = Me.ListStockCategoryTableAdapter
        Me.TableAdapterManager.ToppingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BINGSU.VBPROJECTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListStockCategoryBindingNavigator
        '
        Me.ListStockCategoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListStockCategoryBindingNavigator.BindingSource = Me.ListStockCategoryBindingSource
        Me.ListStockCategoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListStockCategoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListStockCategoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListStockCategoryBindingNavigatorSaveItem})
        Me.ListStockCategoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ListStockCategoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListStockCategoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListStockCategoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListStockCategoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListStockCategoryBindingNavigator.Name = "ListStockCategoryBindingNavigator"
        Me.ListStockCategoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListStockCategoryBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ListStockCategoryBindingNavigator.TabIndex = 25
        Me.ListStockCategoryBindingNavigator.Text = "BindingNavigator1"
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
        'ListStockCategoryBindingNavigatorSaveItem
        '
        Me.ListStockCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListStockCategoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListStockCategoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListStockCategoryBindingNavigatorSaveItem.Name = "ListStockCategoryBindingNavigatorSaveItem"
        Me.ListStockCategoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListStockCategoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ListStockCategoryDataGridView
        '
        Me.ListStockCategoryDataGridView.AutoGenerateColumns = False
        Me.ListStockCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListStockCategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ListStockCategoryDataGridView.DataSource = Me.ListStockCategoryBindingSource
        Me.ListStockCategoryDataGridView.Location = New System.Drawing.Point(63, 19)
        Me.ListStockCategoryDataGridView.Name = "ListStockCategoryDataGridView"
        Me.ListStockCategoryDataGridView.Size = New System.Drawing.Size(344, 144)
        Me.ListStockCategoryDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Stock Category"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Stock Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(58, 421)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 28)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "BACK"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListStockCategoryBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(161, 28)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 27
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListStockCategoryBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(161, 54)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodeTextBox.TabIndex = 29
        '
        'Stock_CategoryTextBox
        '
        Me.Stock_CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListStockCategoryBindingSource, "Stock Category", True))
        Me.Stock_CategoryTextBox.Location = New System.Drawing.Point(161, 80)
        Me.Stock_CategoryTextBox.Name = "Stock_CategoryTextBox"
        Me.Stock_CategoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stock_CategoryTextBox.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.Stock_CategoryTextBox)
        Me.GroupBox1.Controls.Add(Stock_CategoryLabel)
        Me.GroupBox1.Controls.Add(CodeLabel)
        Me.GroupBox1.Controls.Add(Me.CodeTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 143)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Stock Category"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListStockCategoryDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(58, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(509, 181)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock Available"
        '
        'ListStockCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 469)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ListStockCategoryBindingNavigator)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.preBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.addBtn)
        Me.Name = "ListStockCategory"
        Me.Text = "ListStockCategory"
        CType(Me.VBPROJECTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListStockCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListStockCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListStockCategoryBindingNavigator.ResumeLayout(False)
        Me.ListStockCategoryBindingNavigator.PerformLayout()
        CType(Me.ListStockCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextBtn As Button
    Friend WithEvents preBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents VBPROJECTDataSet As VBPROJECTDataSet
    Friend WithEvents ListStockCategoryBindingSource As BindingSource
    Friend WithEvents ListStockCategoryTableAdapter As VBPROJECTDataSetTableAdapters.ListStockCategoryTableAdapter
    Friend WithEvents TableAdapterManager As VBPROJECTDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListStockCategoryBindingNavigator As BindingNavigator
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
    Friend WithEvents ListStockCategoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ListStockCategoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents Stock_CategoryTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
