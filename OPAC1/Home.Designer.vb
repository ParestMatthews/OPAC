<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.btn_srchTitle = New System.Windows.Forms.Button()
        Me.btn_srchType = New System.Windows.Forms.Button()
        Me.btn_srchAuthor = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.comboauthor = New System.Windows.Forms.ComboBox()
        Me.combotype = New System.Windows.Forms.ComboBox()
        Me.combobook = New System.Windows.Forms.ComboBox()
        Me.ams = New System.Windows.Forms.Label()
        Me.lsb = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.piclsb = New System.Windows.Forms.PictureBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SelectUser = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVerify = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.piclsb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_srchTitle
        '
        Me.btn_srchTitle.Location = New System.Drawing.Point(205, 101)
        Me.btn_srchTitle.Name = "btn_srchTitle"
        Me.btn_srchTitle.Size = New System.Drawing.Size(164, 23)
        Me.btn_srchTitle.TabIndex = 0
        Me.btn_srchTitle.Text = "SEARCH BY TITLE"
        Me.btn_srchTitle.UseVisualStyleBackColor = True
        '
        'btn_srchType
        '
        Me.btn_srchType.Location = New System.Drawing.Point(463, 101)
        Me.btn_srchType.Name = "btn_srchType"
        Me.btn_srchType.Size = New System.Drawing.Size(164, 23)
        Me.btn_srchType.TabIndex = 1
        Me.btn_srchType.Text = "SEARCH BY TYPE"
        Me.btn_srchType.UseVisualStyleBackColor = True
        '
        'btn_srchAuthor
        '
        Me.btn_srchAuthor.Location = New System.Drawing.Point(721, 101)
        Me.btn_srchAuthor.Name = "btn_srchAuthor"
        Me.btn_srchAuthor.Size = New System.Drawing.Size(164, 23)
        Me.btn_srchAuthor.TabIndex = 2
        Me.btn_srchAuthor.Text = "SEARCH BY AUTHOR"
        Me.btn_srchAuthor.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.comboauthor)
        Me.Panel1.Controls.Add(Me.combotype)
        Me.Panel1.Controls.Add(Me.combobook)
        Me.Panel1.Location = New System.Drawing.Point(205, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 352)
        Me.Panel1.TabIndex = 3
        '
        'comboauthor
        '
        Me.comboauthor.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.comboauthor.FormattingEnabled = True
        Me.comboauthor.Location = New System.Drawing.Point(6, 6)
        Me.comboauthor.Name = "comboauthor"
        Me.comboauthor.Size = New System.Drawing.Size(382, 21)
        Me.comboauthor.TabIndex = 24
        Me.comboauthor.Text = "Search the author of the book"
        '
        'combotype
        '
        Me.combotype.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.combotype.FormattingEnabled = True
        Me.combotype.Location = New System.Drawing.Point(6, 6)
        Me.combotype.Name = "combotype"
        Me.combotype.Size = New System.Drawing.Size(382, 21)
        Me.combotype.TabIndex = 23
        Me.combotype.Text = "Search the type of the book"
        '
        'combobook
        '
        Me.combobook.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.combobook.FormattingEnabled = True
        Me.combobook.Location = New System.Drawing.Point(6, 6)
        Me.combobook.Name = "combobook"
        Me.combobook.Size = New System.Drawing.Size(382, 21)
        Me.combobook.TabIndex = 1
        Me.combobook.Text = "Search the title of the book"
        '
        'ams
        '
        Me.ams.AutoSize = True
        Me.ams.BackColor = System.Drawing.Color.Transparent
        Me.ams.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ams.ForeColor = System.Drawing.Color.White
        Me.ams.Location = New System.Drawing.Point(326, 41)
        Me.ams.Name = "ams"
        Me.ams.Size = New System.Drawing.Size(351, 24)
        Me.ams.TabIndex = 13
        Me.ams.Text = "Online Public Access Catalogue"
        Me.ams.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lsb
        '
        Me.lsb.AutoSize = True
        Me.lsb.BackColor = System.Drawing.Color.Transparent
        Me.lsb.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsb.ForeColor = System.Drawing.Color.DarkOrange
        Me.lsb.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lsb.Location = New System.Drawing.Point(341, 9)
        Me.lsb.Name = "lsb"
        Me.lsb.Size = New System.Drawing.Size(321, 35)
        Me.lsb.TabIndex = 11
        Me.lsb.Text = "LYCEUM SUBIC BAY"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.ams)
        Me.Panel3.Controls.Add(Me.lsb)
        Me.Panel3.Controls.Add(Me.piclsb)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(914, 79)
        Me.Panel3.TabIndex = 14
        '
        'piclsb
        '
        Me.piclsb.BackColor = System.Drawing.Color.Transparent
        Me.piclsb.Image = CType(resources.GetObject("piclsb.Image"), System.Drawing.Image)
        Me.piclsb.Location = New System.Drawing.Point(265, 3)
        Me.piclsb.Name = "piclsb"
        Me.piclsb.Size = New System.Drawing.Size(65, 73)
        Me.piclsb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclsb.TabIndex = 12
        Me.piclsb.TabStop = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(663, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 315)
        Me.VScrollBar1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.VScrollBar1)
        Me.Panel2.Location = New System.Drawing.Point(205, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 317)
        Me.Panel2.TabIndex = 4
        '
        'SelectUser
        '
        Me.SelectUser.FormattingEnabled = True
        Me.SelectUser.Items.AddRange(New Object() {"Student", "Admin"})
        Me.SelectUser.Location = New System.Drawing.Point(33, 193)
        Me.SelectUser.Name = "SelectUser"
        Me.SelectUser.Size = New System.Drawing.Size(148, 21)
        Me.SelectUser.TabIndex = 22
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(51, 279)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 33)
        Me.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSave.TabIndex = 21
        Me.btnSave.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(51, 459)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 33)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 16
        Me.btnClose.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(51, 413)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 33)
        Me.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClear.TabIndex = 17
        Me.btnClear.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(51, 324)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 33)
        Me.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(51, 368)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 33)
        Me.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'btnVerify
        '
        Me.btnVerify.Image = Global.OPAC1.My.Resources.Resources.verify1
        Me.btnVerify.Location = New System.Drawing.Point(51, 230)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(114, 33)
        Me.btnVerify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVerify.TabIndex = 24
        Me.btnVerify.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(914, 505)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SelectUser)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_srchAuthor)
        Me.Controls.Add(Me.btn_srchType)
        Me.Controls.Add(Me.btn_srchTitle)
        Me.Name = "Home"
        Me.Text = "OPAC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.piclsb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVerify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_srchTitle As Button
    Friend WithEvents btn_srchType As Button
    Friend WithEvents btn_srchAuthor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents combobook As ComboBox
    Friend WithEvents ams As Label
    Friend WithEvents lsb As Label
    Friend WithEvents piclsb As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnClear As PictureBox
    Friend WithEvents btnDelete As PictureBox
    Friend WithEvents btnPrint As PictureBox
    Friend WithEvents btnSave As PictureBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SelectUser As ComboBox
    Friend WithEvents combotype As ComboBox
    Friend WithEvents comboauthor As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVerify As PictureBox
End Class
