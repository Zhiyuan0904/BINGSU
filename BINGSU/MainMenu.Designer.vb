<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ingredientBtn = New System.Windows.Forms.Button()
        Me.toppingBtn = New System.Windows.Forms.Button()
        Me.flavourBtn = New System.Windows.Forms.Button()
        Me.handpackedBtn = New System.Windows.Forms.Button()
        Me.icecreambaseBtn = New System.Windows.Forms.Button()
        Me.liststockcategoryBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ingredientBtn
        '
        Me.ingredientBtn.BackColor = System.Drawing.Color.White
        Me.ingredientBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingredientBtn.Location = New System.Drawing.Point(372, 46)
        Me.ingredientBtn.Name = "ingredientBtn"
        Me.ingredientBtn.Size = New System.Drawing.Size(99, 46)
        Me.ingredientBtn.TabIndex = 0
        Me.ingredientBtn.Text = "Ingredients"
        Me.ingredientBtn.UseVisualStyleBackColor = False
        '
        'toppingBtn
        '
        Me.toppingBtn.BackColor = System.Drawing.Color.White
        Me.toppingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toppingBtn.Location = New System.Drawing.Point(479, 46)
        Me.toppingBtn.Name = "toppingBtn"
        Me.toppingBtn.Size = New System.Drawing.Size(99, 46)
        Me.toppingBtn.TabIndex = 1
        Me.toppingBtn.Text = "Topping"
        Me.toppingBtn.UseVisualStyleBackColor = False
        '
        'flavourBtn
        '
        Me.flavourBtn.BackColor = System.Drawing.Color.White
        Me.flavourBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flavourBtn.Location = New System.Drawing.Point(593, 46)
        Me.flavourBtn.Name = "flavourBtn"
        Me.flavourBtn.Size = New System.Drawing.Size(99, 46)
        Me.flavourBtn.TabIndex = 2
        Me.flavourBtn.Text = "Flavour"
        Me.flavourBtn.UseVisualStyleBackColor = False
        '
        'handpackedBtn
        '
        Me.handpackedBtn.BackColor = System.Drawing.Color.White
        Me.handpackedBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.handpackedBtn.Location = New System.Drawing.Point(372, 115)
        Me.handpackedBtn.Name = "handpackedBtn"
        Me.handpackedBtn.Size = New System.Drawing.Size(99, 46)
        Me.handpackedBtn.TabIndex = 3
        Me.handpackedBtn.Text = "Handpacked"
        Me.handpackedBtn.UseVisualStyleBackColor = False
        '
        'icecreambaseBtn
        '
        Me.icecreambaseBtn.BackColor = System.Drawing.Color.White
        Me.icecreambaseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icecreambaseBtn.Location = New System.Drawing.Point(479, 115)
        Me.icecreambaseBtn.Name = "icecreambaseBtn"
        Me.icecreambaseBtn.Size = New System.Drawing.Size(99, 46)
        Me.icecreambaseBtn.TabIndex = 4
        Me.icecreambaseBtn.Text = "Ice Cream Base"
        Me.icecreambaseBtn.UseVisualStyleBackColor = False
        '
        'liststockcategoryBtn
        '
        Me.liststockcategoryBtn.BackColor = System.Drawing.Color.White
        Me.liststockcategoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liststockcategoryBtn.Location = New System.Drawing.Point(593, 115)
        Me.liststockcategoryBtn.Name = "liststockcategoryBtn"
        Me.liststockcategoryBtn.Size = New System.Drawing.Size(99, 46)
        Me.liststockcategoryBtn.TabIndex = 5
        Me.liststockcategoryBtn.Text = "List Stock Category"
        Me.liststockcategoryBtn.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.liststockcategoryBtn)
        Me.Controls.Add(Me.icecreambaseBtn)
        Me.Controls.Add(Me.handpackedBtn)
        Me.Controls.Add(Me.flavourBtn)
        Me.Controls.Add(Me.toppingBtn)
        Me.Controls.Add(Me.ingredientBtn)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ingredientBtn As Button
    Friend WithEvents toppingBtn As Button
    Friend WithEvents flavourBtn As Button
    Friend WithEvents handpackedBtn As Button
    Friend WithEvents icecreambaseBtn As Button
    Friend WithEvents liststockcategoryBtn As Button
End Class
