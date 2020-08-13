<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booksTable
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.searchDataTable = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.searchDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 1
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
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 0
        Me.BunifuElipse2.TargetControl = Me
        '
        'searchDataTable
        '
        Me.searchDataTable.AllowUserToAddRows = False
        Me.searchDataTable.AllowUserToDeleteRows = False
        Me.searchDataTable.AllowUserToResizeColumns = False
        Me.searchDataTable.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.searchDataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.searchDataTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.searchDataTable.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.searchDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.searchDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.searchDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.searchDataTable.ColumnHeadersHeight = 40
        Me.searchDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.searchDataTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.searchDataTable.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.searchDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.searchDataTable.RowHeadersVisible = False
        Me.searchDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.searchDataTable.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.searchDataTable.RowTemplate.Height = 30
        Me.searchDataTable.RowTemplate.ReadOnly = True
        Me.searchDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.searchDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.searchDataTable.Size = New System.Drawing.Size(594, 325)
        Me.searchDataTable.TabIndex = 5
        '
        'booksTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(615, 385)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.searchDataTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "booksTable"
        Me.Text = "Form1"
        CType(Me.searchDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents searchText As TextBox
    Friend WithEvents searchDataTable As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
End Class
