<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userInfo))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.departmentText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.yearLevelText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.courseText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.idText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.firstNameText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lastNameText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.middleNameText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuNewPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuOldPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.bunifuConfirmPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuAddButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuError1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuError2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.bunifuError3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 1
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 1
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(103, 25)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "User Data"
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
        Me.BunifuSeparator1.TabIndex = 14
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(17, 254)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(182, 25)
        Me.BunifuCustomLabel2.TabIndex = 15
        Me.BunifuCustomLabel2.Text = "Change Password"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(22, 266)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(594, 35)
        Me.BunifuSeparator2.TabIndex = 16
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'departmentText
        '
        Me.departmentText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.departmentText.BackColor = System.Drawing.Color.White
        Me.departmentText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.departmentText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.departmentText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.departmentText.BorderThickness = 1
        Me.departmentText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.departmentText.Enabled = False
        Me.departmentText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentText.ForeColor = System.Drawing.Color.Black
        Me.departmentText.isPassword = False
        Me.departmentText.Location = New System.Drawing.Point(234, 131)
        Me.departmentText.Margin = New System.Windows.Forms.Padding(4)
        Me.departmentText.Name = "departmentText"
        Me.departmentText.Size = New System.Drawing.Size(175, 32)
        Me.departmentText.TabIndex = 65
        Me.departmentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(231, 112)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(74, 15)
        Me.BunifuCustomLabel7.TabIndex = 59
        Me.BunifuCustomLabel7.Text = "Department"
        '
        'yearLevelText
        '
        Me.yearLevelText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.yearLevelText.BackColor = System.Drawing.Color.White
        Me.yearLevelText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.yearLevelText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.yearLevelText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.yearLevelText.BorderThickness = 1
        Me.yearLevelText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yearLevelText.Enabled = False
        Me.yearLevelText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLevelText.ForeColor = System.Drawing.Color.Black
        Me.yearLevelText.isPassword = False
        Me.yearLevelText.Location = New System.Drawing.Point(234, 192)
        Me.yearLevelText.Margin = New System.Windows.Forms.Padding(4)
        Me.yearLevelText.Name = "yearLevelText"
        Me.yearLevelText.Size = New System.Drawing.Size(175, 32)
        Me.yearLevelText.TabIndex = 60
        Me.yearLevelText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(231, 173)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(66, 15)
        Me.BunifuCustomLabel8.TabIndex = 61
        Me.BunifuCustomLabel8.Text = "Year Level"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(438, 48)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(47, 15)
        Me.BunifuCustomLabel9.TabIndex = 62
        Me.BunifuCustomLabel9.Text = "Course"
        '
        'courseText
        '
        Me.courseText.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.courseText.BackColor = System.Drawing.Color.White
        Me.courseText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.courseText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.courseText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.courseText.BorderThickness = 1
        Me.courseText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.courseText.Enabled = False
        Me.courseText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseText.ForeColor = System.Drawing.Color.Black
        Me.courseText.isPassword = False
        Me.courseText.Location = New System.Drawing.Point(441, 67)
        Me.courseText.Margin = New System.Windows.Forms.Padding(4)
        Me.courseText.Name = "courseText"
        Me.courseText.Size = New System.Drawing.Size(175, 32)
        Me.courseText.TabIndex = 66
        Me.courseText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.idText.Enabled = False
        Me.idText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idText.ForeColor = System.Drawing.Color.Black
        Me.idText.isPassword = False
        Me.idText.Location = New System.Drawing.Point(24, 67)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(175, 32)
        Me.idText.TabIndex = 57
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(21, 48)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(113, 15)
        Me.BunifuCustomLabel3.TabIndex = 51
        Me.BunifuCustomLabel3.Text = "Student/Faculty ID"
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
        Me.firstNameText.Enabled = False
        Me.firstNameText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameText.ForeColor = System.Drawing.Color.Black
        Me.firstNameText.isPassword = False
        Me.firstNameText.Location = New System.Drawing.Point(24, 131)
        Me.firstNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.firstNameText.Name = "firstNameText"
        Me.firstNameText.Size = New System.Drawing.Size(175, 32)
        Me.firstNameText.TabIndex = 52
        Me.firstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(21, 112)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(69, 15)
        Me.BunifuCustomLabel4.TabIndex = 53
        Me.BunifuCustomLabel4.Text = "First Name"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(21, 174)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(82, 15)
        Me.BunifuCustomLabel5.TabIndex = 54
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
        Me.lastNameText.Enabled = False
        Me.lastNameText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameText.ForeColor = System.Drawing.Color.Black
        Me.lastNameText.isPassword = False
        Me.lastNameText.Location = New System.Drawing.Point(234, 67)
        Me.lastNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.lastNameText.Name = "lastNameText"
        Me.lastNameText.Size = New System.Drawing.Size(175, 32)
        Me.lastNameText.TabIndex = 55
        Me.lastNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(231, 48)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(69, 15)
        Me.BunifuCustomLabel6.TabIndex = 56
        Me.BunifuCustomLabel6.Text = "Last Name"
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
        Me.middleNameText.Enabled = False
        Me.middleNameText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middleNameText.ForeColor = System.Drawing.Color.Black
        Me.middleNameText.isPassword = False
        Me.middleNameText.Location = New System.Drawing.Point(24, 193)
        Me.middleNameText.Margin = New System.Windows.Forms.Padding(4)
        Me.middleNameText.Name = "middleNameText"
        Me.middleNameText.Size = New System.Drawing.Size(175, 32)
        Me.middleNameText.TabIndex = 58
        Me.middleNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(21, 292)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(95, 15)
        Me.BunifuCustomLabel10.TabIndex = 67
        Me.BunifuCustomLabel10.Text = "Old Password *"
        '
        'bunifuNewPassword
        '
        Me.bunifuNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bunifuNewPassword.BackColor = System.Drawing.Color.White
        Me.bunifuNewPassword.BorderColorFocused = System.Drawing.Color.DimGray
        Me.bunifuNewPassword.BorderColorIdle = System.Drawing.Color.DimGray
        Me.bunifuNewPassword.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.bunifuNewPassword.BorderThickness = 1
        Me.bunifuNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuNewPassword.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuNewPassword.ForeColor = System.Drawing.Color.Black
        Me.bunifuNewPassword.isPassword = True
        Me.bunifuNewPassword.Location = New System.Drawing.Point(234, 311)
        Me.bunifuNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuNewPassword.Name = "bunifuNewPassword"
        Me.bunifuNewPassword.Size = New System.Drawing.Size(175, 32)
        Me.bunifuNewPassword.TabIndex = 68
        Me.bunifuNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(231, 292)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(102, 15)
        Me.BunifuCustomLabel11.TabIndex = 69
        Me.BunifuCustomLabel11.Text = "New Password *"
        '
        'bunifuOldPassword
        '
        Me.bunifuOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bunifuOldPassword.BackColor = System.Drawing.Color.White
        Me.bunifuOldPassword.BorderColorFocused = System.Drawing.Color.DimGray
        Me.bunifuOldPassword.BorderColorIdle = System.Drawing.Color.DimGray
        Me.bunifuOldPassword.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.bunifuOldPassword.BorderThickness = 1
        Me.bunifuOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuOldPassword.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuOldPassword.ForeColor = System.Drawing.Color.Black
        Me.bunifuOldPassword.isPassword = True
        Me.bunifuOldPassword.Location = New System.Drawing.Point(24, 311)
        Me.bunifuOldPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuOldPassword.Name = "bunifuOldPassword"
        Me.bunifuOldPassword.Size = New System.Drawing.Size(175, 32)
        Me.bunifuOldPassword.TabIndex = 70
        Me.bunifuOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bunifuConfirmPassword
        '
        Me.bunifuConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bunifuConfirmPassword.BackColor = System.Drawing.Color.White
        Me.bunifuConfirmPassword.BorderColorFocused = System.Drawing.Color.DimGray
        Me.bunifuConfirmPassword.BorderColorIdle = System.Drawing.Color.DimGray
        Me.bunifuConfirmPassword.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.bunifuConfirmPassword.BorderThickness = 1
        Me.bunifuConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bunifuConfirmPassword.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.bunifuConfirmPassword.isPassword = True
        Me.bunifuConfirmPassword.Location = New System.Drawing.Point(441, 311)
        Me.bunifuConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.bunifuConfirmPassword.Name = "bunifuConfirmPassword"
        Me.bunifuConfirmPassword.Size = New System.Drawing.Size(175, 32)
        Me.bunifuConfirmPassword.TabIndex = 71
        Me.bunifuConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(438, 292)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(149, 15)
        Me.BunifuCustomLabel12.TabIndex = 72
        Me.BunifuCustomLabel12.Text = "Confirm New Password *"
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
        Me.bunifuAddButton.ButtonText = "Change Password"
        Me.bunifuAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuAddButton.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuAddButton.ForeColor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleBorderThickness = 1
        Me.bunifuAddButton.IdleCornerRadius = 1
        Me.bunifuAddButton.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.IdleForecolor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.Location = New System.Drawing.Point(529, 374)
        Me.bunifuAddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bunifuAddButton.Name = "bunifuAddButton"
        Me.bunifuAddButton.Size = New System.Drawing.Size(87, 51)
        Me.bunifuAddButton.TabIndex = 73
        Me.bunifuAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bunifuError1
        '
        Me.bunifuError1.AutoSize = True
        Me.bunifuError1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuError1.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuError1.Location = New System.Drawing.Point(21, 347)
        Me.bunifuError1.Name = "bunifuError1"
        Me.bunifuError1.Size = New System.Drawing.Size(54, 13)
        Me.bunifuError1.TabIndex = 74
        Me.bunifuError1.Text = "Error One"
        Me.bunifuError1.Visible = False
        '
        'bunifuError2
        '
        Me.bunifuError2.AutoSize = True
        Me.bunifuError2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuError2.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuError2.Location = New System.Drawing.Point(231, 347)
        Me.bunifuError2.Name = "bunifuError2"
        Me.bunifuError2.Size = New System.Drawing.Size(55, 13)
        Me.bunifuError2.TabIndex = 75
        Me.bunifuError2.Text = "Error Two"
        Me.bunifuError2.Visible = False
        '
        'bunifuError3
        '
        Me.bunifuError3.AutoSize = True
        Me.bunifuError3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuError3.ForeColor = System.Drawing.Color.Crimson
        Me.bunifuError3.Location = New System.Drawing.Point(438, 347)
        Me.bunifuError3.Name = "bunifuError3"
        Me.bunifuError3.Size = New System.Drawing.Size(63, 13)
        Me.bunifuError3.TabIndex = 76
        Me.bunifuError3.Text = "Error Three"
        Me.bunifuError3.Visible = False
        '
        'userInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(639, 450)
        Me.Controls.Add(Me.bunifuError3)
        Me.Controls.Add(Me.bunifuError2)
        Me.Controls.Add(Me.bunifuError1)
        Me.Controls.Add(Me.bunifuConfirmPassword)
        Me.Controls.Add(Me.BunifuCustomLabel12)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.bunifuNewPassword)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.bunifuOldPassword)
        Me.Controls.Add(Me.departmentText)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.yearLevelText)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.courseText)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.firstNameText)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lastNameText)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.middleNameText)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.bunifuAddButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userInfo"
        Me.Text = "userInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents departmentText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents yearLevelText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents courseText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents firstNameText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lastNameText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents middleNameText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents bunifuConfirmPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuNewPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuOldPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents bunifuAddButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuError3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuError2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bunifuError1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
