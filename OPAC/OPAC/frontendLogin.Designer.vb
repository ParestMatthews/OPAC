<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frontendLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frontendLogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.exitButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.bunifuError2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuError1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuRemember = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuId = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.bunifuLoginBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTitlePage = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.loginErrorText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.headerPanel.SuspendLayout()
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.Transparent
        Me.headerPanel.Controls.Add(Me.exitButton)
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(739, 36)
        Me.headerPanel.TabIndex = 15
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.Image = CType(resources.GetObject("exitButton.Image"), System.Drawing.Image)
        Me.exitButton.ImageActive = Nothing
        Me.exitButton.Location = New System.Drawing.Point(714, 12)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(13, 13)
        Me.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.exitButton.TabIndex = 0
        Me.exitButton.TabStop = False
        Me.exitButton.Zoom = 1
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.headerPanel
        Me.BunifuDragControl2.Vertical = True
        '
        'bunifuError2
        '
        Me.bunifuError2.AutoSize = True
        Me.bunifuError2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuError2.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuError2.Location = New System.Drawing.Point(402, 274)
        Me.bunifuError2.Name = "bunifuError2"
        Me.bunifuError2.Size = New System.Drawing.Size(55, 13)
        Me.bunifuError2.TabIndex = 21
        Me.bunifuError2.Text = "Error Two"
        Me.bunifuError2.Visible = False
        '
        'bunifuError1
        '
        Me.bunifuError1.AutoSize = True
        Me.bunifuError1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuError1.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuError1.Location = New System.Drawing.Point(402, 194)
        Me.bunifuError1.Name = "bunifuError1"
        Me.bunifuError1.Size = New System.Drawing.Size(54, 13)
        Me.bunifuError1.TabIndex = 20
        Me.bunifuError1.Text = "Error One"
        Me.bunifuError1.Visible = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(426, 314)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(105, 18)
        Me.BunifuCustomLabel4.TabIndex = 19
        Me.BunifuCustomLabel4.Text = "Remember me"
        '
        'bunifuRemember
        '
        Me.bunifuRemember.BackColor = System.Drawing.Color.DarkKhaki
        Me.bunifuRemember.ChechedOffColor = System.Drawing.Color.DarkKhaki
        Me.bunifuRemember.Checked = False
        Me.bunifuRemember.CheckedOnColor = System.Drawing.Color.Firebrick
        Me.bunifuRemember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuRemember.ForeColor = System.Drawing.Color.White
        Me.bunifuRemember.Location = New System.Drawing.Point(403, 313)
        Me.bunifuRemember.Name = "bunifuRemember"
        Me.bunifuRemember.Size = New System.Drawing.Size(20, 20)
        Me.bunifuRemember.TabIndex = 18
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(395, 70)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(131, 44)
        Me.BunifuCustomLabel3.TabIndex = 12
        Me.BunifuCustomLabel3.Text = "Sign In"
        '
        'bunifuId
        '
        Me.bunifuId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuId.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuId.ForeColor = System.Drawing.Color.Black
        Me.bunifuId.HintForeColor = System.Drawing.Color.DimGray
        Me.bunifuId.HintText = "ID"
        Me.bunifuId.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bunifuId.isPassword = False
        Me.bunifuId.LineFocusedColor = System.Drawing.Color.Black
        Me.bunifuId.LineIdleColor = System.Drawing.Color.Black
        Me.bunifuId.LineMouseHoverColor = System.Drawing.Color.Black
        Me.bunifuId.LineThickness = 3
        Me.bunifuId.Location = New System.Drawing.Point(403, 146)
        Me.bunifuId.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuId.Name = "bunifuId"
        Me.bunifuId.Size = New System.Drawing.Size(305, 44)
        Me.bunifuId.TabIndex = 13
        Me.bunifuId.TabStop = False
        Me.bunifuId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifuLoginBtn
        '
        Me.bunifuLoginBtn.ActiveBorderThickness = 1
        Me.bunifuLoginBtn.ActiveCornerRadius = 40
        Me.bunifuLoginBtn.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuLoginBtn.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuLoginBtn.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuLoginBtn.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuLoginBtn.BackgroundImage = CType(resources.GetObject("bunifuLoginBtn.BackgroundImage"), System.Drawing.Image)
        Me.bunifuLoginBtn.ButtonText = "Login"
        Me.bunifuLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuLoginBtn.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuLoginBtn.ForeColor = System.Drawing.Color.White
        Me.bunifuLoginBtn.IdleBorderThickness = 1
        Me.bunifuLoginBtn.IdleCornerRadius = 40
        Me.bunifuLoginBtn.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuLoginBtn.IdleForecolor = System.Drawing.Color.White
        Me.bunifuLoginBtn.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuLoginBtn.Location = New System.Drawing.Point(585, 364)
        Me.bunifuLoginBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bunifuLoginBtn.Name = "bunifuLoginBtn"
        Me.bunifuLoginBtn.Size = New System.Drawing.Size(123, 56)
        Me.bunifuLoginBtn.TabIndex = 17
        Me.bunifuLoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuTitlePage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 453)
        Me.Panel1.TabIndex = 16
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(34, 305)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(297, 78)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "The official online public access catalog for Students and Faculty of Lyceum Subi" &
    "c Bay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(30, 117)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(301, 92)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Student-Faculty Portal"
        '
        'BunifuTitlePage
        '
        Me.BunifuTitlePage.AutoSize = True
        Me.BunifuTitlePage.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTitlePage.Font = New System.Drawing.Font("Roboto", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTitlePage.ForeColor = System.Drawing.Color.White
        Me.BunifuTitlePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuTitlePage.Location = New System.Drawing.Point(28, 59)
        Me.BunifuTitlePage.Name = "BunifuTitlePage"
        Me.BunifuTitlePage.Size = New System.Drawing.Size(148, 58)
        Me.BunifuTitlePage.TabIndex = 1
        Me.BunifuTitlePage.Text = "OPAC"
        '
        'loginErrorText
        '
        Me.loginErrorText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginErrorText.ForeColor = System.Drawing.Color.Crimson
        Me.loginErrorText.Location = New System.Drawing.Point(369, 122)
        Me.loginErrorText.Name = "loginErrorText"
        Me.loginErrorText.Size = New System.Drawing.Size(366, 20)
        Me.loginErrorText.TabIndex = 22
        Me.loginErrorText.Text = "Login Error"
        Me.loginErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginErrorText.Visible = False
        '
        'bunifuPassword
        '
        Me.bunifuPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuPassword.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuPassword.ForeColor = System.Drawing.Color.Black
        Me.bunifuPassword.HintForeColor = System.Drawing.Color.DimGray
        Me.bunifuPassword.HintText = "Password"
        Me.bunifuPassword.isPassword = True
        Me.bunifuPassword.LineFocusedColor = System.Drawing.Color.Black
        Me.bunifuPassword.LineIdleColor = System.Drawing.Color.Black
        Me.bunifuPassword.LineMouseHoverColor = System.Drawing.Color.Black
        Me.bunifuPassword.LineThickness = 3
        Me.bunifuPassword.Location = New System.Drawing.Point(405, 226)
        Me.bunifuPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuPassword.Name = "bunifuPassword"
        Me.bunifuPassword.Size = New System.Drawing.Size(305, 44)
        Me.bunifuPassword.TabIndex = 23
        Me.bunifuPassword.TabStop = False
        Me.bunifuPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frontendLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(739, 453)
        Me.Controls.Add(Me.bunifuPassword)
        Me.Controls.Add(Me.loginErrorText)
        Me.Controls.Add(Me.bunifuError2)
        Me.Controls.Add(Me.bunifuError1)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.bunifuRemember)
        Me.Controls.Add(Me.bunifuLoginBtn)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bunifuId)
        Me.Controls.Add(Me.headerPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frontendLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.headerPanel.ResumeLayout(False)
        CType(Me.exitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents headerPanel As Panel
    Friend WithEvents exitButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bunifuError2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuError1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuRemember As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents bunifuLoginBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTitlePage As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuId As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents loginErrorText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
