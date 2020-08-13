<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clientDashboard
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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clientDashboard))
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.sidebarPanel = New System.Windows.Forms.Panel()
        Me.bunifuUser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuHi = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.bunifuBooks = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuInventory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.iconBox = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.sidebarTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.fadeTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.sidebarPanel.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 0
        Me.BunifuElipse2.TargetControl = Me
        '
        'sidebarPanel
        '
        Me.sidebarPanel.BackColor = System.Drawing.Color.Maroon
        Me.sidebarPanel.Controls.Add(Me.bunifuUser)
        Me.sidebarPanel.Controls.Add(Me.bunifuLogout)
        Me.sidebarPanel.Controls.Add(Me.bunifuHi)
        Me.sidebarPanel.Controls.Add(Me.BunifuImageButton1)
        Me.sidebarPanel.Controls.Add(Me.bunifuBooks)
        Me.sidebarPanel.Controls.Add(Me.bunifuInventory)
        Me.sidebarPanel.Controls.Add(Me.bunifuName)
        Me.sidebarPanel.Controls.Add(Me.iconBox)
        Me.fadeTransition.SetDecoration(Me.sidebarPanel, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.sidebarPanel, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarPanel.Location = New System.Drawing.Point(0, 0)
        Me.sidebarPanel.Name = "sidebarPanel"
        Me.sidebarPanel.Size = New System.Drawing.Size(235, 483)
        Me.sidebarPanel.TabIndex = 3
        '
        'bunifuUser
        '
        Me.bunifuUser.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuUser.BackColor = System.Drawing.Color.Maroon
        Me.bunifuUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuUser.BorderRadius = 0
        Me.bunifuUser.ButtonText = "   Personal Information"
        Me.bunifuUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fadeTransition.SetDecoration(Me.bunifuUser, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.bunifuUser, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuUser.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuUser.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuUser.Iconimage = Global.OPAC.My.Resources.Resources.userIcon
        Me.bunifuUser.Iconimage_right = Nothing
        Me.bunifuUser.Iconimage_right_Selected = Nothing
        Me.bunifuUser.Iconimage_Selected = Nothing
        Me.bunifuUser.IconMarginLeft = 0
        Me.bunifuUser.IconMarginRight = 0
        Me.bunifuUser.IconRightVisible = True
        Me.bunifuUser.IconRightZoom = 0R
        Me.bunifuUser.IconVisible = True
        Me.bunifuUser.IconZoom = 35.0R
        Me.bunifuUser.IsTab = True
        Me.bunifuUser.Location = New System.Drawing.Point(-1, 213)
        Me.bunifuUser.Name = "bunifuUser"
        Me.bunifuUser.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuUser.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuUser.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuUser.selected = False
        Me.bunifuUser.Size = New System.Drawing.Size(236, 48)
        Me.bunifuUser.TabIndex = 8
        Me.bunifuUser.Text = "   Personal Information"
        Me.bunifuUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuUser.Textcolor = System.Drawing.Color.White
        Me.bunifuUser.TextFont = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuLogout
        '
        Me.bunifuLogout.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuLogout.BackColor = System.Drawing.Color.Maroon
        Me.bunifuLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuLogout.BorderRadius = 0
        Me.bunifuLogout.ButtonText = "   Logout"
        Me.bunifuLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fadeTransition.SetDecoration(Me.bunifuLogout, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.bunifuLogout, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuLogout.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuLogout.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuLogout.Iconimage = Global.OPAC.My.Resources.Resources.logoutBtn
        Me.bunifuLogout.Iconimage_right = Nothing
        Me.bunifuLogout.Iconimage_right_Selected = Nothing
        Me.bunifuLogout.Iconimage_Selected = Nothing
        Me.bunifuLogout.IconMarginLeft = 0
        Me.bunifuLogout.IconMarginRight = 0
        Me.bunifuLogout.IconRightVisible = True
        Me.bunifuLogout.IconRightZoom = 0R
        Me.bunifuLogout.IconVisible = True
        Me.bunifuLogout.IconZoom = 35.0R
        Me.bunifuLogout.IsTab = False
        Me.bunifuLogout.Location = New System.Drawing.Point(-1, 423)
        Me.bunifuLogout.Name = "bunifuLogout"
        Me.bunifuLogout.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuLogout.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuLogout.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuLogout.selected = False
        Me.bunifuLogout.Size = New System.Drawing.Size(236, 48)
        Me.bunifuLogout.TabIndex = 0
        Me.bunifuLogout.TabStop = False
        Me.bunifuLogout.Text = "   Logout"
        Me.bunifuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuLogout.Textcolor = System.Drawing.Color.White
        Me.bunifuLogout.TextFont = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuHi
        '
        Me.bunifuHi.AutoSize = True
        Me.sidebarTransition.SetDecoration(Me.bunifuHi, BunifuAnimatorNS.DecorationType.None)
        Me.fadeTransition.SetDecoration(Me.bunifuHi, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuHi.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuHi.ForeColor = System.Drawing.Color.White
        Me.bunifuHi.Location = New System.Drawing.Point(94, 53)
        Me.bunifuHi.Name = "bunifuHi"
        Me.bunifuHi.Size = New System.Drawing.Size(29, 23)
        Me.bunifuHi.TabIndex = 9
        Me.bunifuHi.Text = "Hi"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fadeTransition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.OPAC.My.Resources.Resources.hamburgerMenu
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(203, 9)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 8
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 1
        '
        'bunifuBooks
        '
        Me.bunifuBooks.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuBooks.BackColor = System.Drawing.Color.Maroon
        Me.bunifuBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuBooks.BorderRadius = 0
        Me.bunifuBooks.ButtonText = "   Loan History"
        Me.bunifuBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fadeTransition.SetDecoration(Me.bunifuBooks, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.bunifuBooks, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuBooks.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuBooks.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuBooks.Iconimage = Global.OPAC.My.Resources.Resources.historyIcon
        Me.bunifuBooks.Iconimage_right = Nothing
        Me.bunifuBooks.Iconimage_right_Selected = Nothing
        Me.bunifuBooks.Iconimage_Selected = Nothing
        Me.bunifuBooks.IconMarginLeft = 0
        Me.bunifuBooks.IconMarginRight = 0
        Me.bunifuBooks.IconRightVisible = True
        Me.bunifuBooks.IconRightZoom = 0R
        Me.bunifuBooks.IconVisible = True
        Me.bunifuBooks.IconZoom = 35.0R
        Me.bunifuBooks.IsTab = True
        Me.bunifuBooks.Location = New System.Drawing.Point(-1, 166)
        Me.bunifuBooks.Name = "bunifuBooks"
        Me.bunifuBooks.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuBooks.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuBooks.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuBooks.selected = False
        Me.bunifuBooks.Size = New System.Drawing.Size(236, 48)
        Me.bunifuBooks.TabIndex = 7
        Me.bunifuBooks.Text = "   Loan History"
        Me.bunifuBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuBooks.Textcolor = System.Drawing.Color.White
        Me.bunifuBooks.TextFont = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuInventory
        '
        Me.bunifuInventory.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuInventory.BackColor = System.Drawing.Color.Maroon
        Me.bunifuInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuInventory.BorderRadius = 0
        Me.bunifuInventory.ButtonText = "   Books"
        Me.bunifuInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fadeTransition.SetDecoration(Me.bunifuInventory, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.bunifuInventory, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuInventory.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuInventory.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuInventory.Iconimage = Global.OPAC.My.Resources.Resources.bookIcon
        Me.bunifuInventory.Iconimage_right = Nothing
        Me.bunifuInventory.Iconimage_right_Selected = Nothing
        Me.bunifuInventory.Iconimage_Selected = Nothing
        Me.bunifuInventory.IconMarginLeft = 0
        Me.bunifuInventory.IconMarginRight = 0
        Me.bunifuInventory.IconRightVisible = True
        Me.bunifuInventory.IconRightZoom = 0R
        Me.bunifuInventory.IconVisible = True
        Me.bunifuInventory.IconZoom = 40.0R
        Me.bunifuInventory.IsTab = True
        Me.bunifuInventory.Location = New System.Drawing.Point(-1, 119)
        Me.bunifuInventory.Name = "bunifuInventory"
        Me.bunifuInventory.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuInventory.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuInventory.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuInventory.selected = True
        Me.bunifuInventory.Size = New System.Drawing.Size(236, 48)
        Me.bunifuInventory.TabIndex = 3
        Me.bunifuInventory.Text = "   Books"
        Me.bunifuInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuInventory.Textcolor = System.Drawing.Color.White
        Me.bunifuInventory.TextFont = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuName
        '
        Me.bunifuName.AutoSize = True
        Me.sidebarTransition.SetDecoration(Me.bunifuName, BunifuAnimatorNS.DecorationType.None)
        Me.fadeTransition.SetDecoration(Me.bunifuName, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuName.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuName.ForeColor = System.Drawing.Color.White
        Me.bunifuName.Location = New System.Drawing.Point(94, 76)
        Me.bunifuName.Name = "bunifuName"
        Me.bunifuName.Size = New System.Drawing.Size(101, 23)
        Me.bunifuName.TabIndex = 2
        Me.bunifuName.Text = "NameHere"
        '
        'iconBox
        '
        Me.iconBox.BackColor = System.Drawing.Color.Transparent
        Me.iconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sidebarTransition.SetDecoration(Me.iconBox, BunifuAnimatorNS.DecorationType.None)
        Me.fadeTransition.SetDecoration(Me.iconBox, BunifuAnimatorNS.DecorationType.None)
        Me.iconBox.Image = Global.OPAC.My.Resources.Resources.boyIcon
        Me.iconBox.Location = New System.Drawing.Point(24, 47)
        Me.iconBox.Name = "iconBox"
        Me.iconBox.Size = New System.Drawing.Size(64, 59)
        Me.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconBox.TabIndex = 0
        Me.iconBox.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.fadeTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(235, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 37)
        Me.Panel1.TabIndex = 6
        '
        'exitButton
        '
        Me.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fadeTransition.SetDecoration(Me.exitButton, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.exitButton, BunifuAnimatorNS.DecorationType.None)
        Me.exitButton.Image = Global.OPAC.My.Resources.Resources.closeButtonForReal
        Me.exitButton.ImageActive = Nothing
        Me.exitButton.Location = New System.Drawing.Point(614, 12)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(13, 13)
        Me.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.exitButton.TabIndex = 2
        Me.exitButton.TabStop = False
        Me.exitButton.Zoom = 1
        '
        'sidebarTransition
        '
        Me.sidebarTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.sidebarTransition.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.sidebarTransition.DefaultAnimation = Animation2
        Me.sidebarTransition.Interval = 5
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.PapayaWhip
        Me.fadeTransition.SetDecoration(Me.mainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.sidebarTransition.SetDecoration(Me.mainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(235, 37)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(639, 446)
        Me.mainPanel.TabIndex = 7
        '
        'fadeTransition
        '
        Me.fadeTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.fadeTransition.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.fadeTransition.DefaultAnimation = Animation1
        Me.fadeTransition.Interval = 5
        '
        'clientDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(874, 483)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sidebarPanel)
        Me.sidebarTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.fadeTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clientDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.sidebarPanel.ResumeLayout(False)
        Me.sidebarPanel.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fadeTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents sidebarTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents sidebarPanel As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bunifuBooks As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuInventory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents iconBox As PictureBox
    Friend WithEvents exitButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mainPanel As Panel
    Friend WithEvents bunifuHi As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuUser As Bunifu.Framework.UI.BunifuFlatButton
End Class
