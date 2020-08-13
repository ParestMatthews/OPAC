<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userAdd))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.passwordText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.idText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.firstNameText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lastNameText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.middleNameText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuAddButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.bunifuReturn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.departmentText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.bunifuErrorOne = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorTwo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorThree = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorFive = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorSix = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorSeven = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorEight = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.courseText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.yearLevelText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(218, 220)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(83, 15)
        Me.BunifuCustomLabel7.TabIndex = 101
        Me.BunifuCustomLabel7.Text = "Department *"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(423, 155)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(75, 15)
        Me.BunifuCustomLabel8.TabIndex = 103
        Me.BunifuCustomLabel8.Text = "Year Level *"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(424, 89)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(56, 15)
        Me.BunifuCustomLabel9.TabIndex = 104
        Me.BunifuCustomLabel9.Text = "Course *"
        '
        'passwordText
        '
        Me.passwordText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.passwordText.BackColor = System.Drawing.Color.White
        Me.passwordText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.passwordText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.passwordText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.passwordText.BorderThickness = 1
        Me.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordText.ForeColor = System.Drawing.Color.Black
        Me.passwordText.isPassword = True
        Me.passwordText.Location = New System.Drawing.Point(16, 173)
        Me.passwordText.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.Size = New System.Drawing.Size(175, 32)
        Me.passwordText.TabIndex = 105
        Me.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(13, 157)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(73, 15)
        Me.BunifuCustomLabel10.TabIndex = 106
        Me.BunifuCustomLabel10.Text = "Password *"
        '
        'idText
        '
        Me.idText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.idText.BackColor = System.Drawing.Color.White
        Me.idText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.idText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.idText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.idText.BorderThickness = 1
        Me.idText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idText.ForeColor = System.Drawing.Color.Black
        Me.idText.isPassword = False
        Me.idText.Location = New System.Drawing.Point(16, 109)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(175, 32)
        Me.idText.TabIndex = 99
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(13, 90)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(122, 15)
        Me.BunifuCustomLabel3.TabIndex = 93
        Me.BunifuCustomLabel3.Text = "Student/Faculty ID *"
        '
        'firstNameText
        '
        Me.firstNameText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.firstNameText.BackColor = System.Drawing.Color.White
        Me.firstNameText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.firstNameText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.firstNameText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.firstNameText.BorderThickness = 1
        Me.firstNameText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstNameText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameText.ForeColor = System.Drawing.Color.Black
        Me.firstNameText.isPassword = False
        Me.firstNameText.Location = New System.Drawing.Point(16, 238)
        Me.firstNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.firstNameText.Name = "firstNameText"
        Me.firstNameText.Size = New System.Drawing.Size(175, 32)
        Me.firstNameText.TabIndex = 94
        Me.firstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(14, 222)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(78, 15)
        Me.BunifuCustomLabel4.TabIndex = 95
        Me.BunifuCustomLabel4.Text = "First Name *"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(218, 89)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(82, 15)
        Me.BunifuCustomLabel5.TabIndex = 96
        Me.BunifuCustomLabel5.Text = "Middle Name"
        '
        'lastNameText
        '
        Me.lastNameText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lastNameText.BackColor = System.Drawing.Color.White
        Me.lastNameText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.lastNameText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.lastNameText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.lastNameText.BorderThickness = 1
        Me.lastNameText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastNameText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameText.ForeColor = System.Drawing.Color.Black
        Me.lastNameText.isPassword = False
        Me.lastNameText.Location = New System.Drawing.Point(221, 172)
        Me.lastNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.lastNameText.Name = "lastNameText"
        Me.lastNameText.Size = New System.Drawing.Size(175, 32)
        Me.lastNameText.TabIndex = 97
        Me.lastNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(218, 156)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(78, 15)
        Me.BunifuCustomLabel6.TabIndex = 98
        Me.BunifuCustomLabel6.Text = "Last Name *"
        '
        'middleNameText
        '
        Me.middleNameText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.middleNameText.BackColor = System.Drawing.Color.White
        Me.middleNameText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.middleNameText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.middleNameText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.middleNameText.BorderThickness = 1
        Me.middleNameText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.middleNameText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middleNameText.ForeColor = System.Drawing.Color.Black
        Me.middleNameText.isPassword = False
        Me.middleNameText.Location = New System.Drawing.Point(221, 108)
        Me.middleNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.middleNameText.Name = "middleNameText"
        Me.middleNameText.Size = New System.Drawing.Size(175, 32)
        Me.middleNameText.TabIndex = 100
        Me.middleNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 48)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(99, 19)
        Me.BunifuCustomLabel2.TabIndex = 92
        Me.BunifuCustomLabel2.Text = "Add Account"
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
        Me.bunifuAddButton.ButtonText = "Add User"
        Me.bunifuAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuAddButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuAddButton.ForeColor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleBorderThickness = 1
        Me.bunifuAddButton.IdleCornerRadius = 1
        Me.bunifuAddButton.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.IdleForecolor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.Location = New System.Drawing.Point(497, 317)
        Me.bunifuAddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bunifuAddButton.Name = "bunifuAddButton"
        Me.bunifuAddButton.Size = New System.Drawing.Size(104, 58)
        Me.bunifuAddButton.TabIndex = 109
        Me.bunifuAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(16, 52)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(95, 35)
        Me.BunifuSeparator1.TabIndex = 110
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
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
        Me.bunifuReturn.Location = New System.Drawing.Point(16, -6)
        Me.bunifuReturn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuReturn.Name = "bunifuReturn"
        Me.bunifuReturn.Size = New System.Drawing.Size(82, 45)
        Me.bunifuReturn.TabIndex = 130
        Me.bunifuReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'departmentText
        '
        Me.departmentText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.departmentText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.departmentText.BackColor = System.Drawing.Color.Transparent
        Me.departmentText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.departmentText.BorderRadius = 0
        Me.departmentText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentText.ForeColor = System.Drawing.Color.Black
        Me.departmentText.Items = New String(-1) {}
        Me.departmentText.Location = New System.Drawing.Point(1, 1)
        Me.departmentText.Name = "departmentText"
        Me.departmentText.NomalColor = System.Drawing.Color.White
        Me.departmentText.onHoverColor = System.Drawing.Color.White
        Me.departmentText.selectedIndex = -1
        Me.departmentText.Size = New System.Drawing.Size(174, 31)
        Me.departmentText.TabIndex = 133
        '
        'bunifuErrorOne
        '
        Me.bunifuErrorOne.AutoSize = True
        Me.bunifuErrorOne.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorOne.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorOne.Location = New System.Drawing.Point(14, 143)
        Me.bunifuErrorOne.Name = "bunifuErrorOne"
        Me.bunifuErrorOne.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorOne.TabIndex = 134
        Me.bunifuErrorOne.Text = "Error One"
        Me.bunifuErrorOne.Visible = False
        '
        'bunifuErrorTwo
        '
        Me.bunifuErrorTwo.AutoSize = True
        Me.bunifuErrorTwo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorTwo.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorTwo.Location = New System.Drawing.Point(14, 207)
        Me.bunifuErrorTwo.Name = "bunifuErrorTwo"
        Me.bunifuErrorTwo.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorTwo.TabIndex = 135
        Me.bunifuErrorTwo.Text = "Error One"
        Me.bunifuErrorTwo.Visible = False
        '
        'bunifuErrorThree
        '
        Me.bunifuErrorThree.AutoSize = True
        Me.bunifuErrorThree.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorThree.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorThree.Location = New System.Drawing.Point(14, 272)
        Me.bunifuErrorThree.Name = "bunifuErrorThree"
        Me.bunifuErrorThree.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorThree.TabIndex = 136
        Me.bunifuErrorThree.Text = "Error One"
        Me.bunifuErrorThree.Visible = False
        '
        'bunifuErrorFive
        '
        Me.bunifuErrorFive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuErrorFive.AutoSize = True
        Me.bunifuErrorFive.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorFive.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorFive.Location = New System.Drawing.Point(218, 206)
        Me.bunifuErrorFive.Name = "bunifuErrorFive"
        Me.bunifuErrorFive.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorFive.TabIndex = 138
        Me.bunifuErrorFive.Text = "Error One"
        Me.bunifuErrorFive.Visible = False
        '
        'bunifuErrorSix
        '
        Me.bunifuErrorSix.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuErrorSix.AutoSize = True
        Me.bunifuErrorSix.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorSix.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorSix.Location = New System.Drawing.Point(218, 272)
        Me.bunifuErrorSix.Name = "bunifuErrorSix"
        Me.bunifuErrorSix.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorSix.TabIndex = 139
        Me.bunifuErrorSix.Text = "Error One"
        Me.bunifuErrorSix.Visible = False
        '
        'bunifuErrorSeven
        '
        Me.bunifuErrorSeven.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bunifuErrorSeven.AutoSize = True
        Me.bunifuErrorSeven.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorSeven.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorSeven.Location = New System.Drawing.Point(425, 142)
        Me.bunifuErrorSeven.Name = "bunifuErrorSeven"
        Me.bunifuErrorSeven.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorSeven.TabIndex = 140
        Me.bunifuErrorSeven.Text = "Error One"
        Me.bunifuErrorSeven.Visible = False
        '
        'bunifuErrorEight
        '
        Me.bunifuErrorEight.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bunifuErrorEight.AutoSize = True
        Me.bunifuErrorEight.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorEight.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorEight.Location = New System.Drawing.Point(426, 206)
        Me.bunifuErrorEight.Name = "bunifuErrorEight"
        Me.bunifuErrorEight.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorEight.TabIndex = 141
        Me.bunifuErrorEight.Text = "Error One"
        Me.bunifuErrorEight.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.departmentText)
        Me.Panel1.Location = New System.Drawing.Point(221, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 32)
        Me.Panel1.TabIndex = 142
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.courseText)
        Me.Panel2.Location = New System.Drawing.Point(428, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 32)
        Me.Panel2.TabIndex = 143
        '
        'courseText
        '
        Me.courseText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.courseText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.courseText.BackColor = System.Drawing.Color.Transparent
        Me.courseText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.courseText.BorderRadius = 0
        Me.courseText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseText.ForeColor = System.Drawing.Color.Black
        Me.courseText.Items = New String(-1) {}
        Me.courseText.Location = New System.Drawing.Point(1, 1)
        Me.courseText.Name = "courseText"
        Me.courseText.NomalColor = System.Drawing.Color.White
        Me.courseText.onHoverColor = System.Drawing.Color.White
        Me.courseText.selectedIndex = -1
        Me.courseText.Size = New System.Drawing.Size(174, 31)
        Me.courseText.TabIndex = 133
        '
        'yearLevelText
        '
        Me.yearLevelText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.yearLevelText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.yearLevelText.BackColor = System.Drawing.Color.Transparent
        Me.yearLevelText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.yearLevelText.BorderRadius = 0
        Me.yearLevelText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLevelText.ForeColor = System.Drawing.Color.Black
        Me.yearLevelText.Items = New String(-1) {}
        Me.yearLevelText.Location = New System.Drawing.Point(1, 1)
        Me.yearLevelText.Name = "yearLevelText"
        Me.yearLevelText.NomalColor = System.Drawing.Color.White
        Me.yearLevelText.onHoverColor = System.Drawing.Color.White
        Me.yearLevelText.selectedIndex = -1
        Me.yearLevelText.Size = New System.Drawing.Size(174, 31)
        Me.yearLevelText.TabIndex = 133
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.yearLevelText)
        Me.Panel3.Location = New System.Drawing.Point(428, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(175, 32)
        Me.Panel3.TabIndex = 144
        '
        'userAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(615, 385)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bunifuErrorEight)
        Me.Controls.Add(Me.bunifuErrorSeven)
        Me.Controls.Add(Me.bunifuErrorSix)
        Me.Controls.Add(Me.bunifuErrorFive)
        Me.Controls.Add(Me.bunifuErrorThree)
        Me.Controls.Add(Me.bunifuErrorTwo)
        Me.Controls.Add(Me.bunifuErrorOne)
        Me.Controls.Add(Me.bunifuReturn)
        Me.Controls.Add(Me.bunifuAddButton)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.firstNameText)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lastNameText)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.middleNameText)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userAdd"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bunifuAddButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents passwordText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents firstNameText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lastNameText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents middleNameText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents bunifuReturn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents departmentText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents bunifuErrorEight As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorSeven As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorSix As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorFive As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorThree As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorTwo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorOne As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents courseText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents yearLevelText As Bunifu.Framework.UI.BunifuDropdown
End Class
