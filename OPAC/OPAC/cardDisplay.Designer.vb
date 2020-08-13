<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cardDisplay
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.isbnText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pagesText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.publishText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.authorText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.locationText = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.locationLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.outLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.inLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.copiesLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCards1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCards1
        '
        Me.BunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCards1.BackColor = System.Drawing.Color.LightYellow
        Me.BunifuCards1.BorderRadius = 0
        Me.BunifuCards1.BottomSahddow = False
        Me.BunifuCards1.color = System.Drawing.Color.DarkRed
        Me.BunifuCards1.Controls.Add(Me.Panel7)
        Me.BunifuCards1.Controls.Add(Me.Panel6)
        Me.BunifuCards1.Controls.Add(Me.Panel1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(-1, 0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = False
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(595, 225)
        Me.BunifuCards1.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.isbnText)
        Me.Panel7.Controls.Add(Me.pagesText)
        Me.Panel7.Controls.Add(Me.publishText)
        Me.Panel7.Controls.Add(Me.authorText)
        Me.Panel7.Location = New System.Drawing.Point(147, 19)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(448, 152)
        Me.Panel7.TabIndex = 3
        '
        'isbnText
        '
        Me.isbnText.Dock = System.Windows.Forms.DockStyle.Top
        Me.isbnText.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnText.Location = New System.Drawing.Point(0, 97)
        Me.isbnText.Name = "isbnText"
        Me.isbnText.Size = New System.Drawing.Size(448, 18)
        Me.isbnText.TabIndex = 3
        Me.isbnText.Text = "ISBN"
        '
        'pagesText
        '
        Me.pagesText.Dock = System.Windows.Forms.DockStyle.Top
        Me.pagesText.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagesText.Location = New System.Drawing.Point(0, 79)
        Me.pagesText.Name = "pagesText"
        Me.pagesText.Size = New System.Drawing.Size(448, 18)
        Me.pagesText.TabIndex = 2
        Me.pagesText.Text = "Pages"
        '
        'publishText
        '
        Me.publishText.Dock = System.Windows.Forms.DockStyle.Top
        Me.publishText.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publishText.Location = New System.Drawing.Point(0, 43)
        Me.publishText.Name = "publishText"
        Me.publishText.Size = New System.Drawing.Size(448, 36)
        Me.publishText.TabIndex = 1
        Me.publishText.Text = "Title, Published place, Pubisher, Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'authorText
        '
        Me.authorText.Dock = System.Windows.Forms.DockStyle.Top
        Me.authorText.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorText.Location = New System.Drawing.Point(0, 0)
        Me.authorText.Name = "authorText"
        Me.authorText.Size = New System.Drawing.Size(448, 43)
        Me.authorText.TabIndex = 0
        Me.authorText.Text = "Author"
        Me.authorText.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.locationText)
        Me.Panel6.Location = New System.Drawing.Point(0, 19)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(147, 100)
        Me.Panel6.TabIndex = 2
        '
        'locationText
        '
        Me.locationText.Dock = System.Windows.Forms.DockStyle.Top
        Me.locationText.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationText.Location = New System.Drawing.Point(0, 0)
        Me.locationText.Name = "locationText"
        Me.locationText.Size = New System.Drawing.Size(147, 73)
        Me.locationText.TabIndex = 0
        Me.locationText.Text = "Location"
        Me.locationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 27)
        Me.Panel1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.locationLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(447, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(148, 27)
        Me.Panel5.TabIndex = 3
        '
        'locationLabel
        '
        Me.locationLabel.BackColor = System.Drawing.Color.IndianRed
        Me.locationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.locationLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.locationLabel.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationLabel.ForeColor = System.Drawing.Color.White
        Me.locationLabel.Location = New System.Drawing.Point(0, 0)
        Me.locationLabel.Name = "locationLabel"
        Me.locationLabel.Size = New System.Drawing.Size(148, 27)
        Me.locationLabel.TabIndex = 1
        Me.locationLabel.Text = "Location:"
        Me.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.outLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(294, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(153, 27)
        Me.Panel4.TabIndex = 2
        '
        'outLabel
        '
        Me.outLabel.BackColor = System.Drawing.Color.IndianRed
        Me.outLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outLabel.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outLabel.ForeColor = System.Drawing.Color.White
        Me.outLabel.Location = New System.Drawing.Point(0, 0)
        Me.outLabel.Name = "outLabel"
        Me.outLabel.Size = New System.Drawing.Size(153, 27)
        Me.outLabel.TabIndex = 1
        Me.outLabel.Text = "Out:"
        Me.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.inLabel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(147, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(147, 27)
        Me.Panel3.TabIndex = 1
        '
        'inLabel
        '
        Me.inLabel.BackColor = System.Drawing.Color.IndianRed
        Me.inLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.inLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inLabel.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inLabel.ForeColor = System.Drawing.Color.White
        Me.inLabel.Location = New System.Drawing.Point(0, 0)
        Me.inLabel.Name = "inLabel"
        Me.inLabel.Size = New System.Drawing.Size(147, 27)
        Me.inLabel.TabIndex = 1
        Me.inLabel.Text = "In:"
        Me.inLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.copiesLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 27)
        Me.Panel2.TabIndex = 0
        '
        'copiesLabel
        '
        Me.copiesLabel.BackColor = System.Drawing.Color.IndianRed
        Me.copiesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.copiesLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.copiesLabel.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copiesLabel.ForeColor = System.Drawing.Color.White
        Me.copiesLabel.Location = New System.Drawing.Point(0, 0)
        Me.copiesLabel.Name = "copiesLabel"
        Me.copiesLabel.Size = New System.Drawing.Size(147, 27)
        Me.copiesLabel.TabIndex = 0
        Me.copiesLabel.Text = "Copy count:"
        Me.copiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cardDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 225)
        Me.Controls.Add(Me.BunifuCards1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cardDisplay"
        Me.Text = "cardDisplay"
        Me.BunifuCards1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Panel7 As Panel
    Friend WithEvents isbnText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pagesText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents publishText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents authorText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents locationText As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents locationLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents outLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents inLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents copiesLabel As Bunifu.Framework.UI.BunifuCustomLabel
End Class
