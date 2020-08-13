Imports MySql.Data.MySqlClient
Public Class logForm
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub logForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookCallNumber, dateLoaned, dateDue, loanStatus
                 FROM
                   opac.loan
                 WHERE
                   clientId = '" & clientDashboard.userID & "'
                 ORDER BY
                    dateLoaned
                 DESC
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            logDataTable.DataSource = bindSource
            With logDataTable
                .Columns(0).HeaderCell.Value = "Book Call Number"
                .Columns(1).HeaderCell.Value = "Date Loaned"
                .Columns(2).HeaderCell.Value = "Date Due"
                .Columns(3).HeaderCell.Value = "Status"

                .Columns(0).Width = Me.Width / 4
                .Columns(1).Width = Me.Width / 4
                .Columns(2).Width = Me.Width / 4
                .Columns(3).Width = Me.Width / 4

                .Columns(0).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
                .Columns(1).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
                .Columns(2).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
                .Columns(3).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
            End With
            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function resetTable()
        Try
            dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookCallNumber, dateLoaned, dateDue, loanStatus
                 FROM
                   opac.loan
                 WHERE
                   clientId = '" & clientDashboard.userID & "'
                 ORDER BY
                    dateLoaned
                 DESC
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            logDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub logDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles logDataTable.CellContentClick

    End Sub

    Private Sub logDataTable_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles logDataTable.CellFormatting
        For Each row As DataGridViewRow In logDataTable.Rows
            If row.Cells(3).Value = "Pending" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(102, 51, 0)
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(102, 51, 0)
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 128)
            ElseIf row.Cells(3).Value = "Cancelled" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(128, 0, 0)
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 153)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 0, 0)
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 153, 153)
            ElseIf row.Cells(3).Value = "In-use" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(25, 77, 25)
                row.DefaultCellStyle.BackColor = Color.FromArgb(179, 255, 179)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 77, 25)
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 255, 179)
            ElseIf row.Cells(3).Value = "Returned" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 77, 0)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 77, 0)
            End If
        Next
    End Sub
End Class