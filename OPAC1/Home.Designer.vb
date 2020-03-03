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
        Me.ams = New System.Windows.Forms.Label()
        Me.lsb = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.piclsb = New System.Windows.Forms.PictureBox()
        Me.SelectUser = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVerify = New System.Windows.Forms.PictureBox()
        Me.searchDataTable = New System.Windows.Forms.DataGridView()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.piclsb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.searchDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'searchDataTable
        '
        Me.searchDataTable.AllowUserToAddRows = False
        Me.searchDataTable.AllowUserToDeleteRows = False
        Me.searchDataTable.AllowUserToResizeColumns = False
        Me.searchDataTable.AllowUserToResizeRows = False
        Me.searchDataTable.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.searchDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.searchDataTable.ColumnHeadersHeight = 29
        Me.searchDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.searchDataTable.Location = New System.Drawing.Point(213, 132)
        Me.searchDataTable.MultiSelect = False
        Me.searchDataTable.Name = "searchDataTable"
        Me.searchDataTable.ReadOnly = True
        Me.searchDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.searchDataTable.RowHeadersVisible = False
        Me.searchDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.searchDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.searchDataTable.Size = New System.Drawing.Size(689, 361)
        Me.searchDataTable.StandardTab = True
        Me.searchDataTable.TabIndex = 25
        '
        'searchText
        '
        Me.searchText.Location = New System.Drawing.Point(213, 106)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(332, 20)
        Me.searchText.TabIndex = 26
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(914, 505)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.searchDataTable)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SelectUser)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Home"
        Me.Text = "OPAC"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.piclsb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.searchDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ams As Label
    Friend WithEvents lsb As Label
    Friend WithEvents piclsb As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnClear As PictureBox
    Friend WithEvents btnDelete As PictureBox
    Friend WithEvents btnPrint As PictureBox
    Friend WithEvents btnSave As PictureBox
    Friend WithEvents SelectUser As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVerify As PictureBox
    Friend WithEvents searchDataTable As DataGridView
    Friend WithEvents searchText As TextBox
End Class
