<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logForm
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
        Me.logDataTable = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.allRadio = New System.Windows.Forms.RadioButton()
        Me.pendingRadio = New System.Windows.Forms.RadioButton()
        Me.inuseRadio = New System.Windows.Forms.RadioButton()
        Me.returnedRadio = New System.Windows.Forms.RadioButton()
        Me.cancelledRadio = New System.Windows.Forms.RadioButton()
        CType(Me.logDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 0
        Me.BunifuElipse1.TargetControl = Me
        '
        'logDataTable
        '
        Me.logDataTable.AllowUserToAddRows = False
        Me.logDataTable.AllowUserToDeleteRows = False
        Me.logDataTable.AllowUserToResizeColumns = False
        Me.logDataTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.logDataTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.logDataTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.logDataTable.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.logDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.logDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.logDataTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.logDataTable.ColumnHeadersHeight = 40
        Me.logDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.logDataTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.NullValue = "- - / - - / - - - -"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.logDataTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.logDataTable.DoubleBuffered = True
        Me.logDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.logDataTable.EnableHeadersVisualStyles = False
        Me.logDataTable.GridColor = System.Drawing.Color.White
        Me.logDataTable.HeaderBgColor = System.Drawing.Color.IndianRed
        Me.logDataTable.HeaderForeColor = System.Drawing.Color.White
        Me.logDataTable.Location = New System.Drawing.Point(-1, 27)
        Me.logDataTable.MultiSelect = False
        Me.logDataTable.Name = "logDataTable"
        Me.logDataTable.ReadOnly = True
        Me.logDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.logDataTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.logDataTable.RowHeadersVisible = False
        Me.logDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.logDataTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.logDataTable.RowTemplate.Height = 30
        Me.logDataTable.RowTemplate.ReadOnly = True
        Me.logDataTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.logDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.logDataTable.ShowEditingIcon = False
        Me.logDataTable.Size = New System.Drawing.Size(594, 303)
        Me.logDataTable.TabIndex = 13
        '
        'allRadio
        '
        Me.allRadio.AutoSize = True
        Me.allRadio.Location = New System.Drawing.Point(1, 4)
        Me.allRadio.Name = "allRadio"
        Me.allRadio.Size = New System.Drawing.Size(38, 17)
        Me.allRadio.TabIndex = 14
        Me.allRadio.TabStop = True
        Me.allRadio.Text = "All"
        Me.allRadio.UseVisualStyleBackColor = True
        '
        'pendingRadio
        '
        Me.pendingRadio.AutoSize = True
        Me.pendingRadio.Location = New System.Drawing.Point(54, 4)
        Me.pendingRadio.Name = "pendingRadio"
        Me.pendingRadio.Size = New System.Drawing.Size(65, 17)
        Me.pendingRadio.TabIndex = 15
        Me.pendingRadio.TabStop = True
        Me.pendingRadio.Text = "Pending"
        Me.pendingRadio.UseVisualStyleBackColor = True
        '
        'inuseRadio
        '
        Me.inuseRadio.AutoSize = True
        Me.inuseRadio.Location = New System.Drawing.Point(137, 4)
        Me.inuseRadio.Name = "inuseRadio"
        Me.inuseRadio.Size = New System.Drawing.Size(55, 17)
        Me.inuseRadio.TabIndex = 16
        Me.inuseRadio.TabStop = True
        Me.inuseRadio.Text = "In-use"
        Me.inuseRadio.UseVisualStyleBackColor = True
        '
        'returnedRadio
        '
        Me.returnedRadio.AutoSize = True
        Me.returnedRadio.Location = New System.Drawing.Point(208, 4)
        Me.returnedRadio.Name = "returnedRadio"
        Me.returnedRadio.Size = New System.Drawing.Size(70, 17)
        Me.returnedRadio.TabIndex = 17
        Me.returnedRadio.TabStop = True
        Me.returnedRadio.Text = "Returned"
        Me.returnedRadio.UseVisualStyleBackColor = True
        '
        'cancelledRadio
        '
        Me.cancelledRadio.AutoSize = True
        Me.cancelledRadio.Location = New System.Drawing.Point(297, 4)
        Me.cancelledRadio.Name = "cancelledRadio"
        Me.cancelledRadio.Size = New System.Drawing.Size(74, 17)
        Me.cancelledRadio.TabIndex = 18
        Me.cancelledRadio.TabStop = True
        Me.cancelledRadio.Text = "Cancelled"
        Me.cancelledRadio.UseVisualStyleBackColor = True
        '
        'logForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(594, 330)
        Me.Controls.Add(Me.cancelledRadio)
        Me.Controls.Add(Me.returnedRadio)
        Me.Controls.Add(Me.inuseRadio)
        Me.Controls.Add(Me.pendingRadio)
        Me.Controls.Add(Me.allRadio)
        Me.Controls.Add(Me.logDataTable)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logForm"
        Me.Text = "logForm"
        CType(Me.logDataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents logDataTable As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents cancelledRadio As RadioButton
    Friend WithEvents inuseRadio As RadioButton
    Friend WithEvents pendingRadio As RadioButton
    Friend WithEvents allRadio As RadioButton
    Friend WithEvents returnedRadio As RadioButton
End Class
