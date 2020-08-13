<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class archiveUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.archivePanel = New System.Windows.Forms.Panel()
        Me.bunifuBooks = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.bunifuUsers = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.usersDataTable = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.usersDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(161, 25)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Library Archives"
        '
        'archivePanel
        '
        Me.archivePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.archivePanel.Location = New System.Drawing.Point(22, 108)
        Me.archivePanel.Name = "archivePanel"
        Me.archivePanel.Size = New System.Drawing.Size(594, 330)
        Me.archivePanel.TabIndex = 15
        '
        'bunifuBooks
        '
        Me.bunifuBooks.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuBooks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuBooks.BackColor = System.Drawing.Color.Firebrick
        Me.bunifuBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuBooks.BorderRadius = 0
        Me.bunifuBooks.ButtonText = "Books"
        Me.bunifuBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuBooks.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuBooks.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuBooks.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuBooks.Iconimage = Nothing
        Me.bunifuBooks.Iconimage_right = Nothing
        Me.bunifuBooks.Iconimage_right_Selected = Nothing
        Me.bunifuBooks.Iconimage_Selected = Nothing
        Me.bunifuBooks.IconMarginLeft = 0
        Me.bunifuBooks.IconMarginRight = 0
        Me.bunifuBooks.IconRightVisible = True
        Me.bunifuBooks.IconRightZoom = 0R
        Me.bunifuBooks.IconVisible = True
        Me.bunifuBooks.IconZoom = 90.0R
        Me.bunifuBooks.IsTab = True
        Me.bunifuBooks.Location = New System.Drawing.Point(432, 62)
        Me.bunifuBooks.Name = "bunifuBooks"
        Me.bunifuBooks.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuBooks.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuBooks.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuBooks.selected = True
        Me.bunifuBooks.Size = New System.Drawing.Size(89, 36)
        Me.bunifuBooks.TabIndex = 17
        Me.bunifuBooks.Text = "Books"
        Me.bunifuBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuBooks.Textcolor = System.Drawing.Color.White
        Me.bunifuBooks.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'bunifuUsers
        '
        Me.bunifuUsers.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuUsers.BackColor = System.Drawing.Color.Maroon
        Me.bunifuUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuUsers.BorderRadius = 0
        Me.bunifuUsers.ButtonText = "Users"
        Me.bunifuUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuUsers.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuUsers.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuUsers.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuUsers.Iconimage = Nothing
        Me.bunifuUsers.Iconimage_right = Nothing
        Me.bunifuUsers.Iconimage_right_Selected = Nothing
        Me.bunifuUsers.Iconimage_Selected = Nothing
        Me.bunifuUsers.IconMarginLeft = 0
        Me.bunifuUsers.IconMarginRight = 0
        Me.bunifuUsers.IconRightVisible = True
        Me.bunifuUsers.IconRightZoom = 0R
        Me.bunifuUsers.IconVisible = True
        Me.bunifuUsers.IconZoom = 90.0R
        Me.bunifuUsers.IsTab = True
        Me.bunifuUsers.Location = New System.Drawing.Point(527, 62)
        Me.bunifuUsers.Name = "bunifuUsers"
        Me.bunifuUsers.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuUsers.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuUsers.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuUsers.selected = False
        Me.bunifuUsers.Size = New System.Drawing.Size(89, 36)
        Me.bunifuUsers.TabIndex = 16
        Me.bunifuUsers.Text = "Users"
        Me.bunifuUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuUsers.Textcolor = System.Drawing.Color.White
        Me.bunifuUsers.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchText.Location = New System.Drawing.Point(22, 77)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(303, 21)
        Me.searchText.TabIndex = 18
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'usersDataTable
        '
        Me.usersDataTable.AllowUserToAddRows = False
        Me.usersDataTable.AllowUserToDeleteRows = False
        Me.usersDataTable.AllowUserToResizeColumns = False
        Me.usersDataTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.usersDataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.usersDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.usersDataTable.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.usersDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usersDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.usersDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usersDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.usersDataTable.ColumnHeadersHeight = 40
        Me.usersDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.usersDataTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.usersDataTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.usersDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usersDataTable.DoubleBuffered = True
        Me.usersDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.usersDataTable.EnableHeadersVisualStyles = False
        Me.usersDataTable.GridColor = System.Drawing.Color.White
        Me.usersDataTable.HeaderBgColor = System.Drawing.Color.IndianRed
        Me.usersDataTable.HeaderForeColor = System.Drawing.Color.White
        Me.usersDataTable.Location = New System.Drawing.Point(0, 0)
        Me.usersDataTable.MultiSelect = False
        Me.usersDataTable.Name = "usersDataTable"
        Me.usersDataTable.ReadOnly = True
        Me.usersDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usersDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.usersDataTable.RowHeadersVisible = False
        Me.usersDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.usersDataTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.usersDataTable.RowTemplate.Height = 30
        Me.usersDataTable.RowTemplate.ReadOnly = True
        Me.usersDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.usersDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.usersDataTable.ShowEditingIcon = False
        Me.usersDataTable.Size = New System.Drawing.Size(594, 330)
        Me.usersDataTable.TabIndex = 16
        '
        'archiveUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(594, 330)
        Me.Controls.Add(Me.usersDataTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "archiveUser"
        Me.Text = "archiveUser"
        CType(Me.usersDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents archivePanel As Panel
    Friend WithEvents bunifuBooks As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents bunifuUsers As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents searchText As TextBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents usersDataTable As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
