<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deleteOne
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deleteOne))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.testLabelSorry = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.confirmButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.deleteError = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 1
        Me.BunifuElipse1.TargetControl = Me
        '
        'testLabelSorry
        '
        Me.testLabelSorry.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.testLabelSorry, BunifuAnimatorNS.DecorationType.None)
        Me.testLabelSorry.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.testLabelSorry.Location = New System.Drawing.Point(7, -2)
        Me.testLabelSorry.Name = "testLabelSorry"
        Me.testLabelSorry.Size = New System.Drawing.Size(266, 19)
        Me.testLabelSorry.TabIndex = 12
        Me.testLabelSorry.Text = "Select Book Call Number(s) to delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Cancel"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(160, 111)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Firebrick
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(88, 46)
        Me.BunifuFlatButton2.TabIndex = 11
        Me.BunifuFlatButton2.Text = "Cancel"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'confirmButton
        '
        Me.confirmButton.Activecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.confirmButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.confirmButton.BorderRadius = 0
        Me.confirmButton.ButtonText = "Confirm"
        Me.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.confirmButton, BunifuAnimatorNS.DecorationType.None)
        Me.confirmButton.DisabledColor = System.Drawing.Color.Gray
        Me.confirmButton.Iconcolor = System.Drawing.Color.Transparent
        Me.confirmButton.Iconimage = Nothing
        Me.confirmButton.Iconimage_right = Nothing
        Me.confirmButton.Iconimage_right_Selected = Nothing
        Me.confirmButton.Iconimage_Selected = Nothing
        Me.confirmButton.IconMarginLeft = 0
        Me.confirmButton.IconMarginRight = 0
        Me.confirmButton.IconRightVisible = True
        Me.confirmButton.IconRightZoom = 0R
        Me.confirmButton.IconVisible = True
        Me.confirmButton.IconZoom = 90.0R
        Me.confirmButton.IsTab = False
        Me.confirmButton.Location = New System.Drawing.Point(30, 111)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.confirmButton.OnHovercolor = System.Drawing.Color.SeaGreen
        Me.confirmButton.OnHoverTextColor = System.Drawing.Color.White
        Me.confirmButton.selected = False
        Me.confirmButton.Size = New System.Drawing.Size(88, 46)
        Me.confirmButton.TabIndex = 10
        Me.confirmButton.Text = "Confirm"
        Me.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.confirmButton.Textcolor = System.Drawing.Color.White
        Me.confirmButton.TextFont = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        Me.BunifuTransition1.Interval = 1000
        Me.BunifuTransition1.MaxAnimationTime = 2500
        '
        'deleteError
        '
        Me.deleteError.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.deleteError, BunifuAnimatorNS.DecorationType.None)
        Me.deleteError.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteError.ForeColor = System.Drawing.Color.Red
        Me.deleteError.Location = New System.Drawing.Point(53, 91)
        Me.deleteError.Name = "deleteError"
        Me.deleteError.Size = New System.Drawing.Size(66, 13)
        Me.deleteError.TabIndex = 16
        Me.deleteError.Text = "Delete Error"
        Me.deleteError.Visible = False
        '
        'CheckedListBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.CheckedListBox1, BunifuAnimatorNS.DecorationType.None)
        Me.CheckedListBox1.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(56, 20)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(164, 68)
        Me.CheckedListBox1.TabIndex = 17
        '
        'deleteOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(279, 157)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.deleteError)
        Me.Controls.Add(Me.testLabelSorry)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.confirmButton)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "deleteOne"
        Me.Text = "removeOne"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents testLabelSorry As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents confirmButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents deleteError As Bunifu.Framework.UI.BunifuCustomLabel
End Class
