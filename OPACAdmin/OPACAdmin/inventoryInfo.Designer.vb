<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventoryInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventoryInfo))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.allInfoPanel = New System.Windows.Forms.Panel()
        Me.bunifuButtonThree = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuButtonTwo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuButtonOne = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuRemove = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuUpdateSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuReturn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'allInfoPanel
        '
        Me.allInfoPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.allInfoPanel.Location = New System.Drawing.Point(12, 46)
        Me.allInfoPanel.Name = "allInfoPanel"
        Me.allInfoPanel.Size = New System.Drawing.Size(591, 259)
        Me.allInfoPanel.TabIndex = 4
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
        Me.bunifuButtonThree.Location = New System.Drawing.Point(322, 318)
        Me.bunifuButtonThree.Name = "bunifuButtonThree"
        Me.bunifuButtonThree.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuButtonThree.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonThree.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuButtonThree.selected = False
        Me.bunifuButtonThree.Size = New System.Drawing.Size(35, 36)
        Me.bunifuButtonThree.TabIndex = 7
        Me.bunifuButtonThree.Text = "3"
        Me.bunifuButtonThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuButtonThree.Textcolor = System.Drawing.Color.White
        Me.bunifuButtonThree.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bunifuButtonTwo.Location = New System.Drawing.Point(281, 318)
        Me.bunifuButtonTwo.Name = "bunifuButtonTwo"
        Me.bunifuButtonTwo.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuButtonTwo.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonTwo.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuButtonTwo.selected = False
        Me.bunifuButtonTwo.Size = New System.Drawing.Size(35, 36)
        Me.bunifuButtonTwo.TabIndex = 6
        Me.bunifuButtonTwo.Text = "2"
        Me.bunifuButtonTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuButtonTwo.Textcolor = System.Drawing.Color.White
        Me.bunifuButtonTwo.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bunifuButtonOne.Location = New System.Drawing.Point(240, 318)
        Me.bunifuButtonOne.Name = "bunifuButtonOne"
        Me.bunifuButtonOne.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuButtonOne.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuButtonOne.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuButtonOne.selected = True
        Me.bunifuButtonOne.Size = New System.Drawing.Size(35, 36)
        Me.bunifuButtonOne.TabIndex = 5
        Me.bunifuButtonOne.Text = "1"
        Me.bunifuButtonOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuButtonOne.Textcolor = System.Drawing.Color.White
        Me.bunifuButtonOne.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuAdd
        '
        Me.bunifuAdd.ActiveBorderThickness = 1
        Me.bunifuAdd.ActiveCornerRadius = 1
        Me.bunifuAdd.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuAdd.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuAdd.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuAdd.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuAdd.BackgroundImage = CType(resources.GetObject("bunifuAdd.BackgroundImage"), System.Drawing.Image)
        Me.bunifuAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuAdd.ButtonText = "Add"
        Me.bunifuAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuAdd.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuAdd.ForeColor = System.Drawing.Color.White
        Me.bunifuAdd.IdleBorderThickness = 1
        Me.bunifuAdd.IdleCornerRadius = 1
        Me.bunifuAdd.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuAdd.IdleForecolor = System.Drawing.Color.White
        Me.bunifuAdd.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuAdd.Location = New System.Drawing.Point(324, -6)
        Me.bunifuAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuAdd.Name = "bunifuAdd"
        Me.bunifuAdd.Size = New System.Drawing.Size(89, 45)
        Me.bunifuAdd.TabIndex = 11
        Me.bunifuAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuRemove
        '
        Me.bunifuRemove.ActiveBorderThickness = 1
        Me.bunifuRemove.ActiveCornerRadius = 1
        Me.bunifuRemove.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuRemove.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuRemove.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuRemove.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuRemove.BackgroundImage = CType(resources.GetObject("bunifuRemove.BackgroundImage"), System.Drawing.Image)
        Me.bunifuRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuRemove.ButtonText = "Delete"
        Me.bunifuRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuRemove.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuRemove.ForeColor = System.Drawing.Color.White
        Me.bunifuRemove.IdleBorderThickness = 1
        Me.bunifuRemove.IdleCornerRadius = 1
        Me.bunifuRemove.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuRemove.IdleForecolor = System.Drawing.Color.White
        Me.bunifuRemove.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuRemove.Location = New System.Drawing.Point(419, -6)
        Me.bunifuRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuRemove.Name = "bunifuRemove"
        Me.bunifuRemove.Size = New System.Drawing.Size(89, 45)
        Me.bunifuRemove.TabIndex = 10
        Me.bunifuRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuUpdateSave
        '
        Me.bunifuUpdateSave.ActiveBorderThickness = 1
        Me.bunifuUpdateSave.ActiveCornerRadius = 1
        Me.bunifuUpdateSave.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuUpdateSave.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuUpdateSave.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuUpdateSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuUpdateSave.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuUpdateSave.BackgroundImage = CType(resources.GetObject("bunifuUpdateSave.BackgroundImage"), System.Drawing.Image)
        Me.bunifuUpdateSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuUpdateSave.ButtonText = " Update "
        Me.bunifuUpdateSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuUpdateSave.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuUpdateSave.ForeColor = System.Drawing.Color.White
        Me.bunifuUpdateSave.IdleBorderThickness = 1
        Me.bunifuUpdateSave.IdleCornerRadius = 1
        Me.bunifuUpdateSave.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuUpdateSave.IdleForecolor = System.Drawing.Color.White
        Me.bunifuUpdateSave.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuUpdateSave.Location = New System.Drawing.Point(514, -6)
        Me.bunifuUpdateSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuUpdateSave.Name = "bunifuUpdateSave"
        Me.bunifuUpdateSave.Size = New System.Drawing.Size(89, 45)
        Me.bunifuUpdateSave.TabIndex = 9
        Me.bunifuUpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuReturn
        '
        Me.bunifuReturn.ActiveBorderThickness = 1
        Me.bunifuReturn.ActiveCornerRadius = 1
        Me.bunifuReturn.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuReturn.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuReturn.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuReturn.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuReturn.BackgroundImage = CType(resources.GetObject("bunifuReturn.BackgroundImage"), System.Drawing.Image)
        Me.bunifuReturn.ButtonText = "Return"
        Me.bunifuReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuReturn.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuReturn.ForeColor = System.Drawing.Color.White
        Me.bunifuReturn.IdleBorderThickness = 1
        Me.bunifuReturn.IdleCornerRadius = 1
        Me.bunifuReturn.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuReturn.IdleForecolor = System.Drawing.Color.White
        Me.bunifuReturn.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuReturn.Location = New System.Drawing.Point(12, -6)
        Me.bunifuReturn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuReturn.Name = "bunifuReturn"
        Me.bunifuReturn.Size = New System.Drawing.Size(82, 45)
        Me.bunifuReturn.TabIndex = 8
        Me.bunifuReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'inventoryInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(615, 385)
        Me.Controls.Add(Me.bunifuAdd)
        Me.Controls.Add(Me.bunifuRemove)
        Me.Controls.Add(Me.bunifuUpdateSave)
        Me.Controls.Add(Me.bunifuReturn)
        Me.Controls.Add(Me.bunifuButtonThree)
        Me.Controls.Add(Me.bunifuButtonTwo)
        Me.Controls.Add(Me.bunifuButtonOne)
        Me.Controls.Add(Me.allInfoPanel)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventoryInfo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents allInfoPanel As Panel
    Friend WithEvents bunifuButtonThree As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuButtonTwo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuButtonOne As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuReturn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuAdd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuRemove As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuUpdateSave As Bunifu.Framework.UI.BunifuThinButton2
End Class
