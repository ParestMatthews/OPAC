<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class logReturnForm
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
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.logReturnPanel = New System.Windows.Forms.Panel()
        Me.bunifuReturns = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuLog = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.searchText = New System.Windows.Forms.TextBox()
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
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(17, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(297, 25)
        Me.BunifuCustomLabel1.TabIndex = 6
        Me.BunifuCustomLabel1.Text = "Library Book Logs and Returns"
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
        Me.BunifuSeparator1.TabIndex = 7
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'logReturnPanel
        '
        Me.logReturnPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logReturnPanel.Location = New System.Drawing.Point(22, 108)
        Me.logReturnPanel.Name = "logReturnPanel"
        Me.logReturnPanel.Size = New System.Drawing.Size(594, 330)
        Me.logReturnPanel.TabIndex = 8
        '
        'bunifuReturns
        '
        Me.bunifuReturns.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuReturns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuReturns.BackColor = System.Drawing.Color.Maroon
        Me.bunifuReturns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuReturns.BorderRadius = 0
        Me.bunifuReturns.ButtonText = "Returns"
        Me.bunifuReturns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuReturns.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuReturns.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuReturns.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuReturns.Iconimage = Nothing
        Me.bunifuReturns.Iconimage_right = Nothing
        Me.bunifuReturns.Iconimage_right_Selected = Nothing
        Me.bunifuReturns.Iconimage_Selected = Nothing
        Me.bunifuReturns.IconMarginLeft = 0
        Me.bunifuReturns.IconMarginRight = 0
        Me.bunifuReturns.IconRightVisible = True
        Me.bunifuReturns.IconRightZoom = 0R
        Me.bunifuReturns.IconVisible = True
        Me.bunifuReturns.IconZoom = 90.0R
        Me.bunifuReturns.IsTab = True
        Me.bunifuReturns.Location = New System.Drawing.Point(527, 62)
        Me.bunifuReturns.Name = "bunifuReturns"
        Me.bunifuReturns.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuReturns.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuReturns.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuReturns.selected = False
        Me.bunifuReturns.Size = New System.Drawing.Size(89, 36)
        Me.bunifuReturns.TabIndex = 10
        Me.bunifuReturns.Text = "Returns"
        Me.bunifuReturns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuReturns.Textcolor = System.Drawing.Color.White
        Me.bunifuReturns.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuLog
        '
        Me.bunifuLog.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuLog.BackColor = System.Drawing.Color.Maroon
        Me.bunifuLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuLog.BorderRadius = 0
        Me.bunifuLog.ButtonText = "Logs"
        Me.bunifuLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuLog.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuLog.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuLog.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuLog.Iconimage = Nothing
        Me.bunifuLog.Iconimage_right = Nothing
        Me.bunifuLog.Iconimage_right_Selected = Nothing
        Me.bunifuLog.Iconimage_Selected = Nothing
        Me.bunifuLog.IconMarginLeft = 0
        Me.bunifuLog.IconMarginRight = 0
        Me.bunifuLog.IconRightVisible = True
        Me.bunifuLog.IconRightZoom = 0R
        Me.bunifuLog.IconVisible = True
        Me.bunifuLog.IconZoom = 90.0R
        Me.bunifuLog.IsTab = True
        Me.bunifuLog.Location = New System.Drawing.Point(432, 62)
        Me.bunifuLog.Name = "bunifuLog"
        Me.bunifuLog.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuLog.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuLog.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuLog.selected = True
        Me.bunifuLog.Size = New System.Drawing.Size(89, 36)
        Me.bunifuLog.TabIndex = 11
        Me.bunifuLog.Text = "Logs"
        Me.bunifuLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuLog.Textcolor = System.Drawing.Color.White
        Me.bunifuLog.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchText.Location = New System.Drawing.Point(22, 77)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(303, 21)
        Me.searchText.TabIndex = 12
        '
        'logReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(639, 450)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.bunifuLog)
        Me.Controls.Add(Me.bunifuReturns)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.logReturnPanel)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logReturnForm"
        Me.Text = "logReturnForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents logReturnPanel As Panel
    Friend WithEvents bunifuLog As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuReturns As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents searchText As TextBox
End Class
