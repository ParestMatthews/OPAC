<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabDisplay
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tabDisplayTable = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Field = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tabDisplayTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'tabDisplayTable
        '
        Me.tabDisplayTable.AllowUserToAddRows = False
        Me.tabDisplayTable.AllowUserToDeleteRows = False
        Me.tabDisplayTable.AllowUserToResizeColumns = False
        Me.tabDisplayTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.tabDisplayTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tabDisplayTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabDisplayTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabDisplayTable.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.tabDisplayTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabDisplayTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tabDisplayTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabDisplayTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tabDisplayTable.ColumnHeadersHeight = 40
        Me.tabDisplayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tabDisplayTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Field, Me.Data})
        Me.tabDisplayTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabDisplayTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.tabDisplayTable.DoubleBuffered = True
        Me.tabDisplayTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tabDisplayTable.EnableHeadersVisualStyles = False
        Me.tabDisplayTable.GridColor = System.Drawing.Color.White
        Me.tabDisplayTable.HeaderBgColor = System.Drawing.Color.IndianRed
        Me.tabDisplayTable.HeaderForeColor = System.Drawing.Color.White
        Me.tabDisplayTable.Location = New System.Drawing.Point(1, 0)
        Me.tabDisplayTable.MultiSelect = False
        Me.tabDisplayTable.Name = "tabDisplayTable"
        Me.tabDisplayTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabDisplayTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tabDisplayTable.RowHeadersVisible = False
        Me.tabDisplayTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.tabDisplayTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tabDisplayTable.RowTemplate.Height = 30
        Me.tabDisplayTable.RowTemplate.ReadOnly = True
        Me.tabDisplayTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabDisplayTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabDisplayTable.Size = New System.Drawing.Size(595, 225)
        Me.tabDisplayTable.TabIndex = 6
        '
        'Field
        '
        Me.Field.HeaderText = "Field"
        Me.Field.Name = "Field"
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        '
        'tabDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 225)
        Me.Controls.Add(Me.tabDisplayTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tabDisplay"
        Me.Text = "tabDisplay"
        CType(Me.tabDisplayTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tabDisplayTable As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Field As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
End Class
