<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class infoOne
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
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.locationText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.titleText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.languageText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bookInText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bookCountText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bookOutText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.timesOutText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(192, 127)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(56, 15)
        Me.BunifuCustomLabel5.TabIndex = 18
        Me.BunifuCustomLabel5.Text = "Location"
        '
        'locationText
        '
        Me.locationText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.locationText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.locationText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.locationText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.locationText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.locationText.BorderThickness = 1
        Me.locationText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.locationText.Enabled = False
        Me.locationText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationText.ForeColor = System.Drawing.Color.Black
        Me.locationText.isPassword = False
        Me.locationText.Location = New System.Drawing.Point(195, 146)
        Me.locationText.Margin = New System.Windows.Forms.Padding(4)
        Me.locationText.Name = "locationText"
        Me.locationText.Size = New System.Drawing.Size(175, 32)
        Me.locationText.TabIndex = 17
        Me.locationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(192, 63)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 15)
        Me.BunifuCustomLabel4.TabIndex = 15
        Me.BunifuCustomLabel4.Text = "Language *"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(-1, 63)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(67, 15)
        Me.BunifuCustomLabel3.TabIndex = 14
        Me.BunifuCustomLabel3.Text = "Accession"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(398, 56)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(95, 25)
        Me.BunifuCustomLabel2.TabIndex = 22
        Me.BunifuCustomLabel2.Text = "Book Count"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(499, 59)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(80, 18)
        Me.BunifuCustomLabel6.TabIndex = 23
        Me.BunifuCustomLabel6.Text = "On Shelf"
        Me.BunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titleText
        '
        Me.titleText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.titleText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.titleText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.titleText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.titleText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.titleText.BorderThickness = 1
        Me.titleText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.titleText.Enabled = False
        Me.titleText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleText.ForeColor = System.Drawing.Color.Black
        Me.titleText.isPassword = False
        Me.titleText.Location = New System.Drawing.Point(2, 18)
        Me.titleText.Margin = New System.Windows.Forms.Padding(4)
        Me.titleText.Name = "titleText"
        Me.titleText.Size = New System.Drawing.Size(369, 32)
        Me.titleText.TabIndex = 34
        Me.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(-1, -1)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(41, 15)
        Me.BunifuCustomLabel9.TabIndex = 33
        Me.BunifuCustomLabel9.Text = "Title *"
        '
        'languageText
        '
        Me.languageText.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.languageText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.languageText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.languageText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.languageText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.languageText.BorderThickness = 1
        Me.languageText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.languageText.Enabled = False
        Me.languageText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.languageText.ForeColor = System.Drawing.Color.Black
        Me.languageText.isPassword = False
        Me.languageText.Location = New System.Drawing.Point(195, 82)
        Me.languageText.Margin = New System.Windows.Forms.Padding(4)
        Me.languageText.Name = "languageText"
        Me.languageText.Size = New System.Drawing.Size(175, 32)
        Me.languageText.TabIndex = 35
        Me.languageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.bookInText)
        Me.Panel4.Location = New System.Drawing.Point(496, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(83, 44)
        Me.Panel4.TabIndex = 37
        '
        'bookInText
        '
        Me.bookInText.BackColor = System.Drawing.Color.Transparent
        Me.bookInText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookInText.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookInText.ForeColor = System.Drawing.Color.Black
        Me.bookInText.Location = New System.Drawing.Point(0, 0)
        Me.bookInText.Name = "bookInText"
        Me.bookInText.Size = New System.Drawing.Size(83, 44)
        Me.bookInText.TabIndex = 26
        Me.bookInText.Text = "XXX"
        Me.bookInText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.bookCountText)
        Me.Panel5.Location = New System.Drawing.Point(402, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(83, 44)
        Me.Panel5.TabIndex = 29
        '
        'bookCountText
        '
        Me.bookCountText.BackColor = System.Drawing.Color.Transparent
        Me.bookCountText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookCountText.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookCountText.ForeColor = System.Drawing.Color.Black
        Me.bookCountText.Location = New System.Drawing.Point(0, 0)
        Me.bookCountText.Name = "bookCountText"
        Me.bookCountText.Size = New System.Drawing.Size(83, 44)
        Me.bookCountText.TabIndex = 25
        Me.bookCountText.Text = "XXX"
        Me.bookCountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 83)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(175, 160)
        Me.ListBox1.TabIndex = 37
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(398, 143)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(87, 25)
        Me.BunifuCustomLabel7.TabIndex = 38
        Me.BunifuCustomLabel7.Text = "Out"
        Me.BunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(491, 143)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(95, 25)
        Me.BunifuCustomLabel10.TabIndex = 39
        Me.BunifuCustomLabel10.Text = "Times Out"
        Me.BunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.bookOutText)
        Me.Panel1.Location = New System.Drawing.Point(402, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(83, 44)
        Me.Panel1.TabIndex = 40
        '
        'bookOutText
        '
        Me.bookOutText.BackColor = System.Drawing.Color.Transparent
        Me.bookOutText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookOutText.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookOutText.ForeColor = System.Drawing.Color.Black
        Me.bookOutText.Location = New System.Drawing.Point(0, 0)
        Me.bookOutText.Name = "bookOutText"
        Me.bookOutText.Size = New System.Drawing.Size(83, 44)
        Me.bookOutText.TabIndex = 25
        Me.bookOutText.Text = "XXX"
        Me.bookOutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.timesOutText)
        Me.Panel2.Location = New System.Drawing.Point(496, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(83, 44)
        Me.Panel2.TabIndex = 41
        '
        'timesOutText
        '
        Me.timesOutText.BackColor = System.Drawing.Color.Transparent
        Me.timesOutText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timesOutText.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timesOutText.ForeColor = System.Drawing.Color.Black
        Me.timesOutText.Location = New System.Drawing.Point(0, 0)
        Me.timesOutText.Name = "timesOutText"
        Me.timesOutText.Size = New System.Drawing.Size(83, 44)
        Me.timesOutText.TabIndex = 25
        Me.timesOutText.Text = "XXX"
        Me.timesOutText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'infoOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(591, 259)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.languageText)
        Me.Controls.Add(Me.titleText)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.locationText)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "infoOne"
        Me.Text = "Form1"
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents locationText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents titleText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents languageText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents bookCountText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bookInText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents timesOutText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bookOutText As Bunifu.Framework.UI.BunifuCustomLabel
End Class
