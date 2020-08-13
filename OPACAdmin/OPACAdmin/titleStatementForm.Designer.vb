<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class titleStatementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.authorText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.otherTitleText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.titleText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.parallelTitleText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.corpAuthorText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.otherAuthorText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.editorText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 0
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(7, 226)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(84, 15)
        Me.BunifuCustomLabel5.TabIndex = 17
        Me.BunifuCustomLabel5.Text = "Main Author *"
        '
        'authorText
        '
        Me.authorText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.authorText.BackColor = System.Drawing.Color.White
        Me.authorText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.authorText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.authorText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.authorText.BorderThickness = 1
        Me.authorText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.authorText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorText.ForeColor = System.Drawing.Color.Black
        Me.authorText.isPassword = False
        Me.authorText.Location = New System.Drawing.Point(10, 245)
        Me.authorText.Margin = New System.Windows.Forms.Padding(4)
        Me.authorText.Name = "authorText"
        Me.authorText.Size = New System.Drawing.Size(175, 32)
        Me.authorText.TabIndex = 16
        Me.authorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(7, 162)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(77, 15)
        Me.BunifuCustomLabel4.TabIndex = 14
        Me.BunifuCustomLabel4.Text = "Parallel Title"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(7, 100)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(66, 15)
        Me.BunifuCustomLabel3.TabIndex = 13
        Me.BunifuCustomLabel3.Text = "Other Title"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(6, 6)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(287, 19)
        Me.BunifuCustomLabel2.TabIndex = 12
        Me.BunifuCustomLabel2.Text = "Title and Statement Responsibility Area"
        '
        'otherTitleText
        '
        Me.otherTitleText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.otherTitleText.BackColor = System.Drawing.Color.White
        Me.otherTitleText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.otherTitleText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.otherTitleText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.otherTitleText.BorderThickness = 1
        Me.otherTitleText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.otherTitleText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherTitleText.ForeColor = System.Drawing.Color.Black
        Me.otherTitleText.isPassword = False
        Me.otherTitleText.Location = New System.Drawing.Point(10, 119)
        Me.otherTitleText.Margin = New System.Windows.Forms.Padding(4)
        Me.otherTitleText.Name = "otherTitleText"
        Me.otherTitleText.Size = New System.Drawing.Size(175, 32)
        Me.otherTitleText.TabIndex = 10
        Me.otherTitleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(7, 39)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(41, 15)
        Me.BunifuCustomLabel1.TabIndex = 9
        Me.BunifuCustomLabel1.Text = "Title *"
        '
        'titleText
        '
        Me.titleText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.titleText.BackColor = System.Drawing.Color.White
        Me.titleText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.titleText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.titleText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.titleText.BorderThickness = 1
        Me.titleText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.titleText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleText.ForeColor = System.Drawing.Color.Black
        Me.titleText.isPassword = False
        Me.titleText.Location = New System.Drawing.Point(10, 58)
        Me.titleText.Margin = New System.Windows.Forms.Padding(4)
        Me.titleText.Name = "titleText"
        Me.titleText.Size = New System.Drawing.Size(175, 32)
        Me.titleText.TabIndex = 18
        Me.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'parallelTitleText
        '
        Me.parallelTitleText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.parallelTitleText.BackColor = System.Drawing.Color.White
        Me.parallelTitleText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.parallelTitleText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.parallelTitleText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.parallelTitleText.BorderThickness = 1
        Me.parallelTitleText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.parallelTitleText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parallelTitleText.ForeColor = System.Drawing.Color.Black
        Me.parallelTitleText.isPassword = False
        Me.parallelTitleText.Location = New System.Drawing.Point(10, 181)
        Me.parallelTitleText.Margin = New System.Windows.Forms.Padding(4)
        Me.parallelTitleText.Name = "parallelTitleText"
        Me.parallelTitleText.Size = New System.Drawing.Size(175, 32)
        Me.parallelTitleText.TabIndex = 19
        Me.parallelTitleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'corpAuthorText
        '
        Me.corpAuthorText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.corpAuthorText.BackColor = System.Drawing.Color.White
        Me.corpAuthorText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.corpAuthorText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.corpAuthorText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.corpAuthorText.BorderThickness = 1
        Me.corpAuthorText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.corpAuthorText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corpAuthorText.ForeColor = System.Drawing.Color.Black
        Me.corpAuthorText.isPassword = False
        Me.corpAuthorText.Location = New System.Drawing.Point(216, 181)
        Me.corpAuthorText.Margin = New System.Windows.Forms.Padding(4)
        Me.corpAuthorText.Name = "corpAuthorText"
        Me.corpAuthorText.Size = New System.Drawing.Size(175, 32)
        Me.corpAuthorText.TabIndex = 25
        Me.corpAuthorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'otherAuthorText
        '
        Me.otherAuthorText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.otherAuthorText.BackColor = System.Drawing.Color.White
        Me.otherAuthorText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.otherAuthorText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.otherAuthorText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.otherAuthorText.BorderThickness = 1
        Me.otherAuthorText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.otherAuthorText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherAuthorText.ForeColor = System.Drawing.Color.Black
        Me.otherAuthorText.isPassword = False
        Me.otherAuthorText.Location = New System.Drawing.Point(216, 58)
        Me.otherAuthorText.Margin = New System.Windows.Forms.Padding(4)
        Me.otherAuthorText.Name = "otherAuthorText"
        Me.otherAuthorText.Size = New System.Drawing.Size(175, 32)
        Me.otherAuthorText.TabIndex = 24
        Me.otherAuthorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(213, 162)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(76, 15)
        Me.BunifuCustomLabel6.TabIndex = 23
        Me.BunifuCustomLabel6.Text = "Corp. Author"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(213, 100)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(55, 15)
        Me.BunifuCustomLabel7.TabIndex = 22
        Me.BunifuCustomLabel7.Text = "Editor(s)"
        '
        'editorText
        '
        Me.editorText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.editorText.BackColor = System.Drawing.Color.White
        Me.editorText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.editorText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.editorText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.editorText.BorderThickness = 1
        Me.editorText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.editorText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editorText.ForeColor = System.Drawing.Color.Black
        Me.editorText.isPassword = False
        Me.editorText.Location = New System.Drawing.Point(216, 119)
        Me.editorText.Margin = New System.Windows.Forms.Padding(4)
        Me.editorText.Name = "editorText"
        Me.editorText.Size = New System.Drawing.Size(175, 32)
        Me.editorText.TabIndex = 21
        Me.editorText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(213, 39)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(78, 15)
        Me.BunifuCustomLabel8.TabIndex = 20
        Me.BunifuCustomLabel8.Text = "Other Author"
        '
        'titleStatementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(604, 312)
        Me.Controls.Add(Me.corpAuthorText)
        Me.Controls.Add(Me.otherAuthorText)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.editorText)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.parallelTitleText)
        Me.Controls.Add(Me.titleText)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.authorText)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.otherTitleText)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "titleStatementForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents authorText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents otherTitleText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents titleText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents corpAuthorText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents otherAuthorText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents editorText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents parallelTitleText As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
