<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose1 = New System.Windows.Forms.Button()
        Me.btnRefresh1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFindL = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Khaki
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(-57, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(973, 46)
        Me.Panel3.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(407, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "LOAN BOOK"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 20)
        Me.TextBox1.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClose1)
        Me.GroupBox1.Controls.Add(Me.btnRefresh1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 59)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter ID of Accession Number of Materials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Accession"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID"
        '
        'btnClose1
        '
        Me.btnClose1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose1.ForeColor = System.Drawing.Color.Maroon
        Me.btnClose1.Location = New System.Drawing.Point(784, 24)
        Me.btnClose1.Name = "btnClose1"
        Me.btnClose1.Size = New System.Drawing.Size(64, 20)
        Me.btnClose1.TabIndex = 20
        Me.btnClose1.Text = "Close"
        Me.btnClose1.UseVisualStyleBackColor = False
        '
        'btnRefresh1
        '
        Me.btnRefresh1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnRefresh1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh1.ForeColor = System.Drawing.Color.Maroon
        Me.btnRefresh1.Location = New System.Drawing.Point(672, 24)
        Me.btnRefresh1.Name = "btnRefresh1"
        Me.btnRefresh1.Size = New System.Drawing.Size(71, 20)
        Me.btnRefresh1.TabIndex = 19
        Me.btnRefresh1.Text = "Refresh"
        Me.btnRefresh1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(385, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFindL)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(890, 121)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client Information"
        '
        'btnFindL
        '
        Me.btnFindL.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnFindL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindL.ForeColor = System.Drawing.Color.Maroon
        Me.btnFindL.Location = New System.Drawing.Point(722, 48)
        Me.btnFindL.Name = "btnFindL"
        Me.btnFindL.Size = New System.Drawing.Size(112, 33)
        Me.btnFindL.TabIndex = 31
        Me.btnFindL.Text = "Find"
        Me.btnFindL.UseVisualStyleBackColor = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(477, 87)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(194, 20)
        Me.TextBox7.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(390, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Book Loan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(410, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Type"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(477, 55)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(194, 20)
        Me.TextBox8.TabIndex = 27
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(477, 25)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(194, 20)
        Me.TextBox6.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(391, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "ID Number"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(109, 86)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(269, 20)
        Me.TextBox5.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Year Level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Dept./College"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(109, 55)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(270, 20)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(109, 25)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(270, 20)
        Me.TextBox4.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(890, 249)
        Me.DataGridView1.TabIndex = 20
        '
        'Loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(914, 505)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Loan"
        Me.Text = "Loan"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClose1 As Button
    Friend WithEvents btnRefresh1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnFindL As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
