<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoThree
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
        Me.isbnText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.otherDetailsText = New System.Windows.Forms.TextBox()
        Me.publishedText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.publisherText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.generalNotesText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.pagesText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.seriesText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.yearPublishedText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.editionText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'isbnText
        '
        Me.isbnText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.isbnText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.isbnText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.isbnText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.isbnText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.isbnText.BorderThickness = 1
        Me.isbnText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.isbnText.Enabled = False
        Me.isbnText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnText.ForeColor = System.Drawing.Color.Black
        Me.isbnText.isPassword = False
        Me.isbnText.Location = New System.Drawing.Point(203, 205)
        Me.isbnText.Margin = New System.Windows.Forms.Padding(4)
        Me.isbnText.Name = "isbnText"
        Me.isbnText.Size = New System.Drawing.Size(175, 32)
        Me.isbnText.TabIndex = 67
        Me.isbnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'otherDetailsText
        '
        Me.otherDetailsText.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.otherDetailsText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.otherDetailsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.otherDetailsText.Enabled = False
        Me.otherDetailsText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otherDetailsText.Location = New System.Drawing.Point(409, 17)
        Me.otherDetailsText.Multiline = True
        Me.otherDetailsText.Name = "otherDetailsText"
        Me.otherDetailsText.Size = New System.Drawing.Size(176, 93)
        Me.otherDetailsText.TabIndex = 66
        '
        'publishedText
        '
        Me.publishedText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.publishedText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.publishedText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.publishedText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.publishedText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.publishedText.BorderThickness = 1
        Me.publishedText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.publishedText.Enabled = False
        Me.publishedText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publishedText.ForeColor = System.Drawing.Color.Black
        Me.publishedText.isPassword = False
        Me.publishedText.Location = New System.Drawing.Point(0, 18)
        Me.publishedText.Margin = New System.Windows.Forms.Padding(4)
        Me.publishedText.Name = "publishedText"
        Me.publishedText.Size = New System.Drawing.Size(175, 32)
        Me.publishedText.TabIndex = 56
        Me.publishedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(405, -3)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(81, 15)
        Me.BunifuCustomLabel10.TabIndex = 65
        Me.BunifuCustomLabel10.Text = "Other Details"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(-3, -1)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(107, 15)
        Me.BunifuCustomLabel1.TabIndex = 50
        Me.BunifuCustomLabel1.Text = "Place Published *"
        '
        'publisherText
        '
        Me.publisherText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.publisherText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.publisherText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.publisherText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.publisherText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.publisherText.BorderThickness = 1
        Me.publisherText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.publisherText.Enabled = False
        Me.publisherText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisherText.ForeColor = System.Drawing.Color.Black
        Me.publisherText.isPassword = False
        Me.publisherText.Location = New System.Drawing.Point(0, 79)
        Me.publisherText.Margin = New System.Windows.Forms.Padding(4)
        Me.publisherText.Name = "publisherText"
        Me.publisherText.Size = New System.Drawing.Size(175, 32)
        Me.publisherText.TabIndex = 51
        Me.publisherText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(200, 186)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(45, 15)
        Me.BunifuCustomLabel7.TabIndex = 64
        Me.BunifuCustomLabel7.Text = "ISBN *"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(-3, 60)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(69, 15)
        Me.BunifuCustomLabel3.TabIndex = 52
        Me.BunifuCustomLabel3.Text = "Publisher *"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(-3, 122)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(101, 15)
        Me.BunifuCustomLabel4.TabIndex = 53
        Me.BunifuCustomLabel4.Text = "Year Published *"
        '
        'generalNotesText
        '
        Me.generalNotesText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.generalNotesText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.generalNotesText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.generalNotesText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.generalNotesText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.generalNotesText.BorderThickness = 1
        Me.generalNotesText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.generalNotesText.Enabled = False
        Me.generalNotesText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generalNotesText.ForeColor = System.Drawing.Color.Black
        Me.generalNotesText.isPassword = False
        Me.generalNotesText.Location = New System.Drawing.Point(203, 143)
        Me.generalNotesText.Margin = New System.Windows.Forms.Padding(4)
        Me.generalNotesText.Name = "generalNotesText"
        Me.generalNotesText.Size = New System.Drawing.Size(175, 32)
        Me.generalNotesText.TabIndex = 63
        Me.generalNotesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pagesText
        '
        Me.pagesText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pagesText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pagesText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.pagesText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.pagesText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.pagesText.BorderThickness = 1
        Me.pagesText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pagesText.Enabled = False
        Me.pagesText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pagesText.ForeColor = System.Drawing.Color.Black
        Me.pagesText.isPassword = False
        Me.pagesText.Location = New System.Drawing.Point(0, 205)
        Me.pagesText.Margin = New System.Windows.Forms.Padding(4)
        Me.pagesText.Name = "pagesText"
        Me.pagesText.Size = New System.Drawing.Size(175, 32)
        Me.pagesText.TabIndex = 54
        Me.pagesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(200, 124)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(88, 15)
        Me.BunifuCustomLabel9.TabIndex = 62
        Me.BunifuCustomLabel9.Text = "General Notes"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(-3, 186)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(92, 15)
        Me.BunifuCustomLabel5.TabIndex = 55
        Me.BunifuCustomLabel5.Text = "Pages/Extent *"
        '
        'seriesText
        '
        Me.seriesText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.seriesText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.seriesText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.seriesText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.seriesText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.seriesText.BorderThickness = 1
        Me.seriesText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.seriesText.Enabled = False
        Me.seriesText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seriesText.ForeColor = System.Drawing.Color.Black
        Me.seriesText.isPassword = False
        Me.seriesText.Location = New System.Drawing.Point(203, 79)
        Me.seriesText.Margin = New System.Windows.Forms.Padding(4)
        Me.seriesText.Name = "seriesText"
        Me.seriesText.Size = New System.Drawing.Size(175, 32)
        Me.seriesText.TabIndex = 61
        Me.seriesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'yearPublishedText
        '
        Me.yearPublishedText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.yearPublishedText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.yearPublishedText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.yearPublishedText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.yearPublishedText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.yearPublishedText.BorderThickness = 1
        Me.yearPublishedText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yearPublishedText.Enabled = False
        Me.yearPublishedText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearPublishedText.ForeColor = System.Drawing.Color.Black
        Me.yearPublishedText.isPassword = False
        Me.yearPublishedText.Location = New System.Drawing.Point(0, 141)
        Me.yearPublishedText.Margin = New System.Windows.Forms.Padding(4)
        Me.yearPublishedText.Name = "yearPublishedText"
        Me.yearPublishedText.Size = New System.Drawing.Size(175, 32)
        Me.yearPublishedText.TabIndex = 57
        Me.yearPublishedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'editionText
        '
        Me.editionText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.editionText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.editionText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.editionText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.editionText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.editionText.BorderThickness = 1
        Me.editionText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.editionText.Enabled = False
        Me.editionText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editionText.ForeColor = System.Drawing.Color.Black
        Me.editionText.isPassword = False
        Me.editionText.Location = New System.Drawing.Point(203, 18)
        Me.editionText.Margin = New System.Windows.Forms.Padding(4)
        Me.editionText.Name = "editionText"
        Me.editionText.Size = New System.Drawing.Size(175, 32)
        Me.editionText.TabIndex = 60
        Me.editionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(200, -1)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(45, 15)
        Me.BunifuCustomLabel8.TabIndex = 58
        Me.BunifuCustomLabel8.Text = "Edition"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(200, 60)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(43, 15)
        Me.BunifuCustomLabel6.TabIndex = 59
        Me.BunifuCustomLabel6.Text = "Series"
        '
        'infoThree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(591, 259)
        Me.Controls.Add(Me.isbnText)
        Me.Controls.Add(Me.otherDetailsText)
        Me.Controls.Add(Me.publishedText)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.publisherText)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.generalNotesText)
        Me.Controls.Add(Me.pagesText)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.seriesText)
        Me.Controls.Add(Me.yearPublishedText)
        Me.Controls.Add(Me.editionText)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "infoThree"
        Me.Text = "infoThree"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents isbnText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents otherDetailsText As TextBox
    Friend WithEvents publishedText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents publisherText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents generalNotesText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents pagesText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents seriesText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents yearPublishedText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents editionText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
