<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookEntryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookEntryForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.threePage = New System.Windows.Forms.Panel()
        Me.bunifuButtonOne = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuButtonTwo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuButtonThree = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.bunifuAddButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'threePage
        '
        Me.threePage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.threePage.Location = New System.Drawing.Point(12, 62)
        Me.threePage.Name = "threePage"
        Me.threePage.Size = New System.Drawing.Size(604, 312)
        Me.threePage.TabIndex = 0
        '
        'bunifuButtonOne
        '
        Me.bunifuButtonOne.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonOne.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuButtonOne.BackColor = System.Drawing.Color.Maroon
        Me.bunifuButtonOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuButtonOne.BorderRadius = 0
        Me.bunifuButtonOne.ButtonText = "1"
        Me.bunifuButtonOne.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuButtonOne.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuButtonOne.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuButtonOne.Iconimage = Nothing
        Me.bunifuButtonOne.Iconimage_right = Nothing
        Me.bunifuButtonOne.Iconimage_right_Selected = Nothing
        Me.bunifuButtonOne.Iconimage_Selected = Nothing
        Me.bunifuButtonOne.IconMarginLeft = 0
        Me.bunifuButtonOne.IconMarginRight = 0
        Me.bunifuButtonOne.IconRightVisible = True
        Me.bunifuButtonOne.IconRightZoom = 0R
        Me.bunifuButtonOne.IconVisible = True
        Me.bunifuButtonOne.IconZoom = 90.0R
        Me.bunifuButtonOne.IsTab = True
        Me.bunifuButtonOne.Location = New System.Drawing.Point(252, 380)
        Me.bunifuButtonOne.Name = "bunifuButtonOne"
        Me.bunifuButtonOne.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuButtonOne.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonOne.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuButtonOne.selected = True
        Me.bunifuButtonOne.Size = New System.Drawing.Size(35, 36)
        Me.bunifuButtonOne.TabIndex = 0
        Me.bunifuButtonOne.Text = "1"
        Me.bunifuButtonOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuButtonOne.Textcolor = System.Drawing.Color.White
        Me.bunifuButtonOne.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuButtonTwo
        '
        Me.bunifuButtonTwo.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonTwo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuButtonTwo.BackColor = System.Drawing.Color.Maroon
        Me.bunifuButtonTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuButtonTwo.BorderRadius = 0
        Me.bunifuButtonTwo.ButtonText = "2"
        Me.bunifuButtonTwo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuButtonTwo.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuButtonTwo.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuButtonTwo.Iconimage = Nothing
        Me.bunifuButtonTwo.Iconimage_right = Nothing
        Me.bunifuButtonTwo.Iconimage_right_Selected = Nothing
        Me.bunifuButtonTwo.Iconimage_Selected = Nothing
        Me.bunifuButtonTwo.IconMarginLeft = 0
        Me.bunifuButtonTwo.IconMarginRight = 0
        Me.bunifuButtonTwo.IconRightVisible = True
        Me.bunifuButtonTwo.IconRightZoom = 0R
        Me.bunifuButtonTwo.IconVisible = True
        Me.bunifuButtonTwo.IconZoom = 90.0R
        Me.bunifuButtonTwo.IsTab = True
        Me.bunifuButtonTwo.Location = New System.Drawing.Point(293, 380)
        Me.bunifuButtonTwo.Name = "bunifuButtonTwo"
        Me.bunifuButtonTwo.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuButtonTwo.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonTwo.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuButtonTwo.selected = False
        Me.bunifuButtonTwo.Size = New System.Drawing.Size(35, 36)
        Me.bunifuButtonTwo.TabIndex = 1
        Me.bunifuButtonTwo.Text = "2"
        Me.bunifuButtonTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuButtonTwo.Textcolor = System.Drawing.Color.White
        Me.bunifuButtonTwo.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuButtonThree
        '
        Me.bunifuButtonThree.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonThree.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuButtonThree.BackColor = System.Drawing.Color.Maroon
        Me.bunifuButtonThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuButtonThree.BorderRadius = 0
        Me.bunifuButtonThree.ButtonText = "3"
        Me.bunifuButtonThree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuButtonThree.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuButtonThree.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuButtonThree.Iconimage = Nothing
        Me.bunifuButtonThree.Iconimage_right = Nothing
        Me.bunifuButtonThree.Iconimage_right_Selected = Nothing
        Me.bunifuButtonThree.Iconimage_Selected = Nothing
        Me.bunifuButtonThree.IconMarginLeft = 0
        Me.bunifuButtonThree.IconMarginRight = 0
        Me.bunifuButtonThree.IconRightVisible = True
        Me.bunifuButtonThree.IconRightZoom = 0R
        Me.bunifuButtonThree.IconVisible = True
        Me.bunifuButtonThree.IconZoom = 90.0R
        Me.bunifuButtonThree.IsTab = True
        Me.bunifuButtonThree.Location = New System.Drawing.Point(334, 380)
        Me.bunifuButtonThree.Name = "bunifuButtonThree"
        Me.bunifuButtonThree.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuButtonThree.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonThree.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuButtonThree.selected = False
        Me.bunifuButtonThree.Size = New System.Drawing.Size(35, 36)
        Me.bunifuButtonThree.TabIndex = 2
        Me.bunifuButtonThree.Text = "3"
        Me.bunifuButtonThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuButtonThree.Textcolor = System.Drawing.Color.White
        Me.bunifuButtonThree.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(181, 25)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Library Book Entry"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(22, 21)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(594, 35)
        Me.BunifuSeparator1.TabIndex = 6
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'bunifuAddButton
        '
        Me.bunifuAddButton.ActiveBorderThickness = 1
        Me.bunifuAddButton.ActiveCornerRadius = 1
        Me.bunifuAddButton.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuAddButton.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuAddButton.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuAddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuAddButton.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuAddButton.BackgroundImage = CType(resources.GetObject("bunifuAddButton.BackgroundImage"), System.Drawing.Image)
        Me.bunifuAddButton.ButtonText = "Add Book"
        Me.bunifuAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuAddButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuAddButton.ForeColor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleBorderThickness = 1
        Me.bunifuAddButton.IdleCornerRadius = 1
        Me.bunifuAddButton.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.IdleForecolor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.Location = New System.Drawing.Point(512, 374)
        Me.bunifuAddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bunifuAddButton.Name = "bunifuAddButton"
        Me.bunifuAddButton.Size = New System.Drawing.Size(104, 58)
        Me.bunifuAddButton.TabIndex = 0
        Me.bunifuAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bookEntryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(639, 450)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.bunifuButtonThree)
        Me.Controls.Add(Me.bunifuButtonTwo)
        Me.Controls.Add(Me.bunifuButtonOne)
        Me.Controls.Add(Me.threePage)
        Me.Controls.Add(Me.bunifuAddButton)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "bookEntryForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents threePage As Panel
    Friend WithEvents bunifuButtonOne As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuButtonThree As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuButtonTwo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents bunifuAddButton As Bunifu.Framework.UI.BunifuThinButton2
End Class
