<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userTable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userTable))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.searchDataTable = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.bunifuAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.searchDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchText.Location = New System.Drawing.Point(10, 11)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(284, 21)
        Me.searchText.TabIndex = 6
        '
        'searchDataTable
        '
        Me.searchDataTable.AllowUserToAddRows = False
        Me.searchDataTable.AllowUserToDeleteRows = False
        Me.searchDataTable.AllowUserToResizeColumns = False
        Me.searchDataTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.searchDataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.searchDataTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.searchDataTable.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.searchDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.searchDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.searchDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.searchDataTable.ColumnHeadersHeight = 40
        Me.searchDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.searchDataTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.searchDataTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.searchDataTable.DoubleBuffered = True
        Me.searchDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.searchDataTable.EnableHeadersVisualStyles = False
        Me.searchDataTable.GridColor = System.Drawing.Color.White
        Me.searchDataTable.HeaderBgColor = System.Drawing.Color.IndianRed
        Me.searchDataTable.HeaderForeColor = System.Drawing.Color.White
        Me.searchDataTable.Location = New System.Drawing.Point(10, 49)
        Me.searchDataTable.MultiSelect = False
        Me.searchDataTable.Name = "searchDataTable"
        Me.searchDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.searchDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.searchDataTable.RowHeadersVisible = False
        Me.searchDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.searchDataTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.searchDataTable.RowTemplate.Height = 30
        Me.searchDataTable.RowTemplate.ReadOnly = True
        Me.searchDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.searchDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.searchDataTable.Size = New System.Drawing.Size(594, 324)
        Me.searchDataTable.TabIndex = 5
        '
        'bunifuAdd
        '
        Me.bunifuAdd.ActiveBorderThickness = 1
        Me.bunifuAdd.ActiveCornerRadius = 1
        Me.bunifuAdd.ActiveFillColor = System.Drawing.Color.Firebrick
        Me.bunifuAdd.ActiveForecolor = System.Drawing.Color.White
        Me.bunifuAdd.ActiveLineColor = System.Drawing.Color.Firebrick
        Me.bunifuAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuAdd.BackColor = System.Drawing.Color.PapayaWhip
        Me.bunifuAdd.BackgroundImage = CType(resources.GetObject("bunifuAdd.BackgroundImage"), System.Drawing.Image)
        Me.bunifuAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuAdd.ButtonText = "Add"
        Me.bunifuAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuAdd.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bunifuAdd.ForeColor = System.Drawing.Color.White
        Me.bunifuAdd.IdleBorderThickness = 1
        Me.bunifuAdd.IdleCornerRadius = 1
        Me.bunifuAdd.IdleFillColor = System.Drawing.Color.Maroon
        Me.bunifuAdd.IdleForecolor = System.Drawing.Color.White
        Me.bunifuAdd.IdleLineColor = System.Drawing.Color.Maroon
        Me.bunifuAdd.Location = New System.Drawing.Point(515, -3)
        Me.bunifuAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bunifuAdd.Name = "bunifuAdd"
        Me.bunifuAdd.Size = New System.Drawing.Size(89, 45)
        Me.bunifuAdd.TabIndex = 12
        Me.bunifuAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'userTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(615, 385)
        Me.Controls.Add(Me.bunifuAdd)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.searchDataTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userTable"
        Me.Text = "userTable"
        CType(Me.searchDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents searchText As TextBox
    Friend WithEvents searchDataTable As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents bunifuAdd As Bunifu.Framework.UI.BunifuThinButton2
End Class
