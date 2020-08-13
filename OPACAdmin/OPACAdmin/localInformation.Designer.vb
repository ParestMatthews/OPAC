<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class localInformation
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
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.callNumber = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.languageText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.locationText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(7, 46)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(139, 15)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Subject Classification *"
        '
        'callNumber
        '
        Me.callNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.callNumber.BackColor = System.Drawing.Color.White
        Me.callNumber.BorderRadius = 0
        Me.callNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.callNumber.ForeColor = System.Drawing.Color.Black
        Me.callNumber.Items = New String() {"", "FIL", "COM", "E", "THRO", "HRM", "FS", "CRIM"}
        Me.callNumber.Location = New System.Drawing.Point(12, 66)
        Me.callNumber.Name = "callNumber"
        Me.callNumber.NomalColor = System.Drawing.Color.White
        Me.callNumber.onHoverColor = System.Drawing.Color.White
        Me.callNumber.selectedIndex = -1
        Me.callNumber.Size = New System.Drawing.Size(173, 32)
        Me.callNumber.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(6, 6)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(208, 19)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Local and Other Information"
        '
        'languageText
        '
        Me.languageText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.languageText.BackColor = System.Drawing.Color.White
        Me.languageText.BorderRadius = 0
        Me.languageText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.languageText.ForeColor = System.Drawing.Color.Black
        Me.languageText.Items = New String() {"", "English", "Filipino", "Spanish", "Japanese", "Korean", "Other"}
        Me.languageText.Location = New System.Drawing.Point(10, 130)
        Me.languageText.Name = "languageText"
        Me.languageText.NomalColor = System.Drawing.Color.White
        Me.languageText.onHoverColor = System.Drawing.Color.White
        Me.languageText.selectedIndex = -1
        Me.languageText.Size = New System.Drawing.Size(175, 32)
        Me.languageText.TabIndex = 6
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(7, 111)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 15)
        Me.BunifuCustomLabel4.TabIndex = 5
        Me.BunifuCustomLabel4.Text = "Language *"
        '
        'locationText
        '
        Me.locationText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.locationText.BackColor = System.Drawing.Color.White
        Me.locationText.BorderColorFocused = System.Drawing.Color.DimGray
        Me.locationText.BorderColorIdle = System.Drawing.Color.DimGray
        Me.locationText.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.locationText.BorderThickness = 1
        Me.locationText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.locationText.Enabled = False
        Me.locationText.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationText.ForeColor = System.Drawing.Color.Black
        Me.locationText.isPassword = False
        Me.locationText.Location = New System.Drawing.Point(10, 194)
        Me.locationText.Margin = New System.Windows.Forms.Padding(4)
        Me.locationText.Name = "locationText"
        Me.locationText.Size = New System.Drawing.Size(175, 32)
        Me.locationText.TabIndex = 7
        Me.locationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(7, 175)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(56, 15)
        Me.BunifuCustomLabel5.TabIndex = 8
        Me.BunifuCustomLabel5.Text = "Location"
        '
        'localInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(585, 312)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.locationText)
        Me.Controls.Add(Me.languageText)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.callNumber)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "localInformation"
        Me.Text = "localInformationFormvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents callNumber As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents languageText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents locationText As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
