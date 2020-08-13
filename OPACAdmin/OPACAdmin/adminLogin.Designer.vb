<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminLogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bunifuPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.exitButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuRemember = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.bunifuErrorOne = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorTwo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuLoginBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTitlePage = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.loginErrorText = New Bunifu.Framework.UI.BunifuCustomLabel()
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
        Me.bunifuPassword.Location = New System.Drawing.Point(403, 226)
        Me.bunifuPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuPassword.Name = "bunifuPassword"
        Me.bunifuPassword.Size = New System.Drawing.Size(305, 44)
        Me.bunifuPassword.TabIndex = 3
        Me.bunifuPassword.TabStop = False
        Me.bunifuPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'headerPanel
        '
        Me.headerPanel.Controls.Add(Me.exitButton)
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(739, 36)
        Me.headerPanel.TabIndex = 4
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitButton.Image = Global.OPACAdmin.My.Resources.Resources.closeButtonForReal
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
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(395, 70)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(131, 44)
        Me.BunifuCustomLabel3.TabIndex = 1
        Me.BunifuCustomLabel3.Text = "Sign In"
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
        Me.bunifuRemember.TabIndex = 8
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(426, 314)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(105, 18)
        Me.BunifuCustomLabel4.TabIndex = 9
        Me.BunifuCustomLabel4.Text = "Remember me"
        '
        'bunifuUsername
        '
        Me.bunifuUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuUsername.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuUsername.ForeColor = System.Drawing.Color.Black
        Me.bunifuUsername.HintForeColor = System.Drawing.Color.DimGray
        Me.bunifuUsername.HintText = "Username"
        Me.bunifuUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bunifuUsername.isPassword = False
        Me.bunifuUsername.LineFocusedColor = System.Drawing.Color.Black
        Me.bunifuUsername.LineIdleColor = System.Drawing.Color.Black
        Me.bunifuUsername.LineMouseHoverColor = System.Drawing.Color.Black
        Me.bunifuUsername.LineThickness = 3
        Me.bunifuUsername.Location = New System.Drawing.Point(403, 146)
        Me.bunifuUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuUsername.Name = "bunifuUsername"
        Me.bunifuUsername.Size = New System.Drawing.Size(305, 44)
        Me.bunifuUsername.TabIndex = 2
        Me.bunifuUsername.TabStop = False
        Me.bunifuUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifuErrorOne
        '
        Me.bunifuErrorOne.AutoSize = True
        Me.bunifuErrorOne.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorOne.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorOne.Location = New System.Drawing.Point(402, 194)
        Me.bunifuErrorOne.Name = "bunifuErrorOne"
        Me.bunifuErrorOne.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorOne.TabIndex = 10
        Me.bunifuErrorOne.Text = "Error One"
        Me.bunifuErrorOne.Visible = False
        '
        'bunifuErrorTwo
        '
        Me.bunifuErrorTwo.AutoSize = True
        Me.bunifuErrorTwo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorTwo.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorTwo.Location = New System.Drawing.Point(402, 273)
        Me.bunifuErrorTwo.Name = "bunifuErrorTwo"
        Me.bunifuErrorTwo.Size = New System.Drawing.Size(55, 13)
        Me.bunifuErrorTwo.TabIndex = 11
        Me.bunifuErrorTwo.Text = "Error Two"
        Me.bunifuErrorTwo.Visible = False
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
        Me.bunifuLoginBtn.TabIndex = 7
        Me.bunifuLoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.OPACAdmin.My.Resources.Resources.libraryBg2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuTitlePage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 453)
        Me.Panel1.TabIndex = 5
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(34, 276)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(320, 57)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Lorem ipsum dolor sit amet, consectetur " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "adipiscing elit, sed do eiusmod tempor " &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "incididunt ut labore et dolore magna aliqua. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(30, 117)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(260, 44)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Administration"
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
        Me.loginErrorText.Location = New System.Drawing.Point(368, 122)
        Me.loginErrorText.Name = "loginErrorText"
        Me.loginErrorText.Size = New System.Drawing.Size(368, 20)
        Me.loginErrorText.TabIndex = 23
        Me.loginErrorText.Text = "Login Error"
        Me.loginErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.loginErrorText.Visible = False
        '
        'adminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(739, 453)
        Me.Controls.Add(Me.loginErrorText)
        Me.Controls.Add(Me.bunifuErrorTwo)
        Me.Controls.Add(Me.bunifuErrorOne)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.bunifuRemember)
        Me.Controls.Add(Me.bunifuLoginBtn)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bunifuPassword)
        Me.Controls.Add(Me.bunifuUsername)
        Me.Controls.Add(Me.headerPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminLogin"
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
    Friend WithEvents BunifuTitlePage As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents exitButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents headerPanel As Panel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuRemember As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents bunifuLoginBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents bunifuErrorTwo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorOne As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents loginErrorText As Bunifu.Framework.UI.BunifuCustomLabel
End Class
