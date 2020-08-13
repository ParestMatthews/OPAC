<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class archiveBooks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.booksDataTable = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.booksDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'booksDataTable
        '
        Me.booksDataTable.AllowUserToAddRows = False
        Me.booksDataTable.AllowUserToDeleteRows = False
        Me.booksDataTable.AllowUserToResizeColumns = False
        Me.booksDataTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.booksDataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.booksDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.booksDataTable.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.booksDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.booksDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.booksDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.booksDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.booksDataTable.ColumnHeadersHeight = 40
        Me.booksDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.booksDataTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.booksDataTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.booksDataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.booksDataTable.DoubleBuffered = True
        Me.booksDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.booksDataTable.EnableHeadersVisualStyles = False
        Me.booksDataTable.GridColor = System.Drawing.Color.White
        Me.booksDataTable.HeaderBgColor = System.Drawing.Color.IndianRed
        Me.booksDataTable.HeaderForeColor = System.Drawing.Color.White
        Me.booksDataTable.Location = New System.Drawing.Point(0, 0)
        Me.booksDataTable.MultiSelect = False
        Me.booksDataTable.Name = "booksDataTable"
        Me.booksDataTable.ReadOnly = True
        Me.booksDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.booksDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.booksDataTable.RowHeadersVisible = False
        Me.booksDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.booksDataTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.booksDataTable.RowTemplate.Height = 30
        Me.booksDataTable.RowTemplate.ReadOnly = True
        Me.booksDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.booksDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.booksDataTable.ShowEditingIcon = False
        Me.booksDataTable.Size = New System.Drawing.Size(594, 330)
        Me.booksDataTable.TabIndex = 15
        '
        'archiveBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(594, 330)
        Me.Controls.Add(Me.booksDataTable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "archiveBooks"
        Me.Text = "archiveBooks"
        CType(Me.booksDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents booksDataTable As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
