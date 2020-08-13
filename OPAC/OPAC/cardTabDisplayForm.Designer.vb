<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cardTabDisplayForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cardTabDisplayForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.bunifuCardButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuTabButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cardTabPanel = New System.Windows.Forms.Panel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.bunifuAddButton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'bunifuCardButton
        '
        Me.bunifuCardButton.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuCardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuCardButton.BackColor = System.Drawing.Color.Maroon
        Me.bunifuCardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuCardButton.BorderRadius = 0
        Me.bunifuCardButton.ButtonText = "Card Display"
        Me.bunifuCardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuCardButton.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuCardButton.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuCardButton.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuCardButton.Iconimage = Nothing
        Me.bunifuCardButton.Iconimage_right = Nothing
        Me.bunifuCardButton.Iconimage_right_Selected = Nothing
        Me.bunifuCardButton.Iconimage_Selected = Nothing
        Me.bunifuCardButton.IconMarginLeft = 0
        Me.bunifuCardButton.IconMarginRight = 0
        Me.bunifuCardButton.IconRightVisible = False
        Me.bunifuCardButton.IconRightZoom = 0R
        Me.bunifuCardButton.IconVisible = False
        Me.bunifuCardButton.IconZoom = 100.0R
        Me.bunifuCardButton.IsTab = True
        Me.bunifuCardButton.Location = New System.Drawing.Point(352, 4)
        Me.bunifuCardButton.Name = "bunifuCardButton"
        Me.bunifuCardButton.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuCardButton.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuCardButton.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuCardButton.selected = True
        Me.bunifuCardButton.Size = New System.Drawing.Size(122, 42)
        Me.bunifuCardButton.TabIndex = 5
        Me.bunifuCardButton.Text = "Card Display"
        Me.bunifuCardButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuCardButton.Textcolor = System.Drawing.Color.White
        Me.bunifuCardButton.TextFont = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bunifuTabButton
        '
        Me.bunifuTabButton.Activecolor = System.Drawing.Color.Firebrick
        Me.bunifuTabButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuTabButton.BackColor = System.Drawing.Color.Maroon
        Me.bunifuTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuTabButton.BorderRadius = 0
        Me.bunifuTabButton.ButtonText = "Tab Display"
        Me.bunifuTabButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTabButton.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuTabButton.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuTabButton.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuTabButton.Iconimage = Nothing
        Me.bunifuTabButton.Iconimage_right = Nothing
        Me.bunifuTabButton.Iconimage_right_Selected = Nothing
        Me.bunifuTabButton.Iconimage_Selected = Nothing
        Me.bunifuTabButton.IconMarginLeft = 0
        Me.bunifuTabButton.IconMarginRight = 0
        Me.bunifuTabButton.IconRightVisible = False
        Me.bunifuTabButton.IconRightZoom = 0R
        Me.bunifuTabButton.IconVisible = False
        Me.bunifuTabButton.IconZoom = 100.0R
        Me.bunifuTabButton.IsTab = True
        Me.bunifuTabButton.Location = New System.Drawing.Point(480, 4)
        Me.bunifuTabButton.Name = "bunifuTabButton"
        Me.bunifuTabButton.Normalcolor = System.Drawing.Color.Maroon
        Me.bunifuTabButton.OnHovercolor = System.Drawing.Color.Firebrick
        Me.bunifuTabButton.OnHoverTextColor = System.Drawing.Color.White
        Me.bunifuTabButton.selected = False
        Me.bunifuTabButton.Size = New System.Drawing.Size(122, 42)
        Me.bunifuTabButton.TabIndex = 6
        Me.bunifuTabButton.Text = "Tab Display"
        Me.bunifuTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bunifuTabButton.Textcolor = System.Drawing.Color.White
        Me.bunifuTabButton.TextFont = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cardTabPanel
        '
        Me.cardTabPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cardTabPanel.AutoScroll = True
        Me.cardTabPanel.Location = New System.Drawing.Point(9, 71)
        Me.cardTabPanel.Name = "cardTabPanel"
        Me.cardTabPanel.Size = New System.Drawing.Size(595, 225)
        Me.cardTabPanel.TabIndex = 0
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 1
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.PapayaWhip
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Return"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 1
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton21.Location = New System.Drawing.Point(9, -2)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(104, 52)
        Me.BunifuThinButton21.TabIndex = 7
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bunifuAddButton.ButtonText = "Loan Book"
        Me.bunifuAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuAddButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuAddButton.ForeColor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleBorderThickness = 1
        Me.bunifuAddButton.IdleCornerRadius = 1
        Me.bunifuAddButton.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.IdleForecolor = System.Drawing.Color.White
        Me.bunifuAddButton.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuAddButton.Location = New System.Drawing.Point(498, 304)
        Me.bunifuAddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bunifuAddButton.Name = "bunifuAddButton"
        Me.bunifuAddButton.Size = New System.Drawing.Size(104, 58)
        Me.bunifuAddButton.TabIndex = 3
        Me.bunifuAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cardTabDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(615, 376)
        Me.Controls.Add(Me.bunifuTabButton)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.cardTabPanel)
        Me.Controls.Add(Me.bunifuCardButton)
        Me.Controls.Add(Me.bunifuAddButton)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cardTabDisplayForm"
        Me.Text = "cardTabDisplayForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents bunifuAddButton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bunifuTabButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bunifuCardButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cardTabPanel As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
End Class
