<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userEdit))
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
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.bunifuReturn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuEditButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuPasswordButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuErrorTwo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorThree = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorFour = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorFive = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorSix = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuErrorSeven = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.departmentText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.yearLevelText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.courseText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.deleteUser = New Bunifu.Framework.UI.BunifuThinButton2()
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
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(221, 145)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(83, 15)
        Me.BunifuCustomLabel7.TabIndex = 117
        Me.BunifuCustomLabel7.Text = "Department *"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(424, 81)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(75, 15)
        Me.BunifuCustomLabel8.TabIndex = 119
        Me.BunifuCustomLabel8.Text = "Year Level *"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(221, 212)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(56, 15)
        Me.BunifuCustomLabel9.TabIndex = 120
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
        Me.passwordText.Location = New System.Drawing.Point(18, 329)
        Me.passwordText.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.Size = New System.Drawing.Size(175, 32)
        Me.passwordText.TabIndex = 121
        Me.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(15, 310)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(102, 15)
        Me.BunifuCustomLabel10.TabIndex = 122
        Me.BunifuCustomLabel10.Text = "New Password *"
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
        Me.idText.Location = New System.Drawing.Point(18, 98)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(175, 32)
        Me.idText.TabIndex = 115
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(15, 81)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(122, 15)
        Me.BunifuCustomLabel3.TabIndex = 109
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
        Me.firstNameText.Location = New System.Drawing.Point(19, 163)
        Me.firstNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.firstNameText.Name = "firstNameText"
        Me.firstNameText.Size = New System.Drawing.Size(175, 32)
        Me.firstNameText.TabIndex = 110
        Me.firstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(15, 145)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(78, 15)
        Me.BunifuCustomLabel4.TabIndex = 111
        Me.BunifuCustomLabel4.Text = "First Name *"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(15, 212)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(82, 15)
        Me.BunifuCustomLabel5.TabIndex = 112
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
        Me.lastNameText.Location = New System.Drawing.Point(224, 98)
        Me.lastNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.lastNameText.Name = "lastNameText"
        Me.lastNameText.Size = New System.Drawing.Size(175, 32)
        Me.lastNameText.TabIndex = 113
        Me.lastNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(221, 81)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(78, 15)
        Me.BunifuCustomLabel6.TabIndex = 114
        Me.BunifuCustomLabel6.Text = "Last Name *"
        '
        'middleNameText
        '
        Me.middleNameText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.middleNameText.BackColor = System.Drawing.Color.White
        Me.middleNameText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.middleNameText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.middleNameText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.middleNameText.BorderThickness = 1
        Me.middleNameText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.middleNameText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middleNameText.ForeColor = System.Drawing.Color.Black
        Me.middleNameText.isPassword = False
        Me.middleNameText.Location = New System.Drawing.Point(18, 229)
        Me.middleNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.middleNameText.Name = "middleNameText"
        Me.middleNameText.Size = New System.Drawing.Size(175, 32)
        Me.middleNameText.TabIndex = 116
        Me.middleNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(14, 45)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(98, 19)
        Me.BunifuCustomLabel2.TabIndex = 125
        Me.BunifuCustomLabel2.Text = "Edit Account"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(14, 277)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(137, 19)
        Me.BunifuCustomLabel1.TabIndex = 126
        Me.BunifuCustomLabel1.Text = "Change Password"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(18, 49)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(94, 35)
        Me.BunifuSeparator1.TabIndex = 127
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(18, 282)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(133, 35)
        Me.BunifuSeparator2.TabIndex = 128
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
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
        Me.bunifuReturn.TabIndex = 129
        Me.bunifuReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuEditButton
        '
        Me.bunifuEditButton.ActiveBorderThickness = 1
        Me.bunifuEditButton.ActiveCornerRadius = 1
        Me.bunifuEditButton.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuEditButton.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuEditButton.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuEditButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bunifuEditButton.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuEditButton.BackgroundImage = CType(resources.GetObject("bunifuEditButton.BackgroundImage"), System.Drawing.Image)
        Me.bunifuEditButton.ButtonText = "Update"
        Me.bunifuEditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuEditButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuEditButton.ForeColor = System.Drawing.Color.White
        Me.bunifuEditButton.IdleBorderThickness = 1
        Me.bunifuEditButton.IdleCornerRadius = 1
        Me.bunifuEditButton.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuEditButton.IdleForecolor = System.Drawing.Color.White
        Me.bunifuEditButton.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuEditButton.Location = New System.Drawing.Point(498, 211)
        Me.bunifuEditButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bunifuEditButton.Name = "bunifuEditButton"
        Me.bunifuEditButton.Size = New System.Drawing.Size(104, 58)
        Me.bunifuEditButton.TabIndex = 130
        Me.bunifuEditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuPasswordButton
        '
        Me.bunifuPasswordButton.ActiveBorderThickness = 1
        Me.bunifuPasswordButton.ActiveCornerRadius = 1
        Me.bunifuPasswordButton.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuPasswordButton.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuPasswordButton.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bunifuPasswordButton.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuPasswordButton.BackgroundImage = CType(resources.GetObject("bunifuPasswordButton.BackgroundImage"), System.Drawing.Image)
        Me.bunifuPasswordButton.ButtonText = "Update Password"
        Me.bunifuPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuPasswordButton.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuPasswordButton.ForeColor = System.Drawing.Color.White
        Me.bunifuPasswordButton.IdleBorderThickness = 1
        Me.bunifuPasswordButton.IdleCornerRadius = 1
        Me.bunifuPasswordButton.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuPasswordButton.IdleForecolor = System.Drawing.Color.White
        Me.bunifuPasswordButton.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuPasswordButton.Location = New System.Drawing.Point(498, 313)
        Me.bunifuPasswordButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuPasswordButton.Name = "bunifuPasswordButton"
        Me.bunifuPasswordButton.Size = New System.Drawing.Size(104, 58)
        Me.bunifuPasswordButton.TabIndex = 131
        Me.bunifuPasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuErrorTwo
        '
        Me.bunifuErrorTwo.AutoSize = True
        Me.bunifuErrorTwo.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorTwo.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorTwo.Location = New System.Drawing.Point(16, 197)
        Me.bunifuErrorTwo.Name = "bunifuErrorTwo"
        Me.bunifuErrorTwo.Size = New System.Drawing.Size(55, 13)
        Me.bunifuErrorTwo.TabIndex = 133
        Me.bunifuErrorTwo.Text = "Error Two"
        Me.bunifuErrorTwo.Visible = False
        '
        'bunifuErrorThree
        '
        Me.bunifuErrorThree.AutoSize = True
        Me.bunifuErrorThree.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorThree.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorThree.Location = New System.Drawing.Point(16, 263)
        Me.bunifuErrorThree.Name = "bunifuErrorThree"
        Me.bunifuErrorThree.Size = New System.Drawing.Size(63, 13)
        Me.bunifuErrorThree.TabIndex = 134
        Me.bunifuErrorThree.Text = "Error Three"
        Me.bunifuErrorThree.Visible = False
        '
        'bunifuErrorFour
        '
        Me.bunifuErrorFour.AutoSize = True
        Me.bunifuErrorFour.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorFour.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorFour.Location = New System.Drawing.Point(221, 132)
        Me.bunifuErrorFour.Name = "bunifuErrorFour"
        Me.bunifuErrorFour.Size = New System.Drawing.Size(56, 13)
        Me.bunifuErrorFour.TabIndex = 135
        Me.bunifuErrorFour.Text = "Error Four"
        Me.bunifuErrorFour.Visible = False
        '
        'bunifuErrorFive
        '
        Me.bunifuErrorFive.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuErrorFive.AutoSize = True
        Me.bunifuErrorFive.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorFive.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorFive.Location = New System.Drawing.Point(221, 197)
        Me.bunifuErrorFive.Name = "bunifuErrorFive"
        Me.bunifuErrorFive.Size = New System.Drawing.Size(54, 13)
        Me.bunifuErrorFive.TabIndex = 136
        Me.bunifuErrorFive.Text = "Error Five"
        Me.bunifuErrorFive.Visible = False
        '
        'bunifuErrorSix
        '
        Me.bunifuErrorSix.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bunifuErrorSix.AutoSize = True
        Me.bunifuErrorSix.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorSix.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorSix.Location = New System.Drawing.Point(424, 132)
        Me.bunifuErrorSix.Name = "bunifuErrorSix"
        Me.bunifuErrorSix.Size = New System.Drawing.Size(49, 13)
        Me.bunifuErrorSix.TabIndex = 137
        Me.bunifuErrorSix.Text = "Error Six"
        Me.bunifuErrorSix.Visible = False
        '
        'bunifuErrorSeven
        '
        Me.bunifuErrorSeven.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuErrorSeven.AutoSize = True
        Me.bunifuErrorSeven.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuErrorSeven.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuErrorSeven.Location = New System.Drawing.Point(222, 263)
        Me.bunifuErrorSeven.Name = "bunifuErrorSeven"
        Me.bunifuErrorSeven.Size = New System.Drawing.Size(64, 13)
        Me.bunifuErrorSeven.TabIndex = 138
        Me.bunifuErrorSeven.Text = "Error Seven"
        Me.bunifuErrorSeven.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.departmentText)
        Me.Panel1.Location = New System.Drawing.Point(224, 163)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 32)
        Me.Panel1.TabIndex = 143
        '
        'departmentText
        '
        Me.departmentText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.departmentText.BackColor = System.Drawing.Color.Transparent
        Me.departmentText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.departmentText.BorderRadius = 0
        Me.departmentText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentText.ForeColor = System.Drawing.Color.Black
        Me.departmentText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.departmentText.Items = New String(-1) {}
        Me.departmentText.Location = New System.Drawing.Point(1, 1)
        Me.departmentText.Name = "departmentText"
        Me.departmentText.NomalColor = System.Drawing.Color.White
        Me.departmentText.onHoverColor = System.Drawing.Color.White
        Me.departmentText.selectedIndex = -1
        Me.departmentText.Size = New System.Drawing.Size(174, 31)
        Me.departmentText.TabIndex = 133
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.yearLevelText)
        Me.Panel2.Location = New System.Drawing.Point(427, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 32)
        Me.Panel2.TabIndex = 144
        '
        'yearLevelText
        '
        Me.yearLevelText.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.courseText)
        Me.Panel3.Location = New System.Drawing.Point(225, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(175, 32)
        Me.Panel3.TabIndex = 145
        '
        'courseText
        '
        Me.courseText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.courseText.BackColor = System.Drawing.Color.Transparent
        Me.courseText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
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
        'deleteUser
        '
        Me.deleteUser.ActiveBorderThickness = 1
        Me.deleteUser.ActiveCornerRadius = 1
        Me.deleteUser.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.deleteUser.ActiveForecolor = System.Drawing.Color.White
        Me.deleteUser.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.deleteUser.BackColor = System.Drawing.Color.PapayaWhip
        Me.deleteUser.BackgroundImage = CType(resources.GetObject("deleteUser.BackgroundImage"), System.Drawing.Image)
        Me.deleteUser.ButtonText = "Delete"
        Me.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteUser.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteUser.ForeColor = System.Drawing.Color.White
        Me.deleteUser.IdleBorderThickness = 1
        Me.deleteUser.IdleCornerRadius = 1
        Me.deleteUser.IdleFillColor = System.Drawing.Color.Maroon
        Me.deleteUser.IdleForecolor = System.Drawing.Color.White
        Me.deleteUser.IdleLineColor = System.Drawing.Color.Maroon
        Me.deleteUser.Location = New System.Drawing.Point(520, -6)
        Me.deleteUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.deleteUser.Name = "deleteUser"
        Me.deleteUser.Size = New System.Drawing.Size(82, 45)
        Me.deleteUser.TabIndex = 146
        Me.deleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'userEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(615, 385)
        Me.Controls.Add(Me.deleteUser)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bunifuErrorSeven)
        Me.Controls.Add(Me.bunifuErrorSix)
        Me.Controls.Add(Me.bunifuErrorFive)
        Me.Controls.Add(Me.bunifuErrorFour)
        Me.Controls.Add(Me.bunifuErrorThree)
        Me.Controls.Add(Me.bunifuErrorTwo)
        Me.Controls.Add(Me.bunifuPasswordButton)
        Me.Controls.Add(Me.bunifuEditButton)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
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
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.bunifuReturn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userEdit"
        Me.Text = "editUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
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
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents bunifuReturn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuPasswordButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuEditButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuErrorSeven As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorSix As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorFive As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorFour As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorThree As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuErrorTwo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents yearLevelText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents courseText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents departmentText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents deleteUser As Bunifu.Framework.UI.BunifuThinButton2
End Class
