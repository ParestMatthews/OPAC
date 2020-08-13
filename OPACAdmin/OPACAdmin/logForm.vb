Imports MySql.Data.MySqlClient
Public Class logForm
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Public Shared radioStatusQuery As String = "all"
    Private Sub logForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookCallNumber, clientID, dateLoaned, dateDue, loanStatus
                 FROM
                   opac.loan
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
                .Columns(1).HeaderCell.Value = "User ID"
                .Columns(2).HeaderCell.Value = "Date Loaned/Cancelled"
                .Columns(3).HeaderCell.Value = "Date Due"
                .Columns(4).HeaderCell.Value = "Status"

                .Columns(0).Width = Me.Width / 4
                .Columns(1).Width = Me.Width / 4
                .Columns(2).Width = Me.Width / 4
                .Columns(3).Width = Me.Width / 4
                .Columns(4).Width = Me.Width / 4

                .Columns(0).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
                .Columns(1).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
                .Columns(2).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
                .Columns(3).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
                .Columns(4).HeaderCell.Style.Font = New Font(logDataTable.Font, FontStyle.Bold)
            End With
            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function logReset()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookCallNumber, clientID, dateLoaned, dateDue, loanStatus
                 FROM
                   opac.loan
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
            If row.Cells(4).Value = "Pending" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(102, 51, 0)
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(102, 51, 0)
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 128)
            ElseIf row.Cells(4).Value = "Cancelled" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(128, 0, 0)
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 153)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 0, 0)
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 153, 153)
            ElseIf row.Cells(4).Value = "In-use" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(25, 77, 25)
                row.DefaultCellStyle.BackColor = Color.FromArgb(179, 255, 179)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(25, 77, 25)
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 255, 179)
            ElseIf row.Cells(4).Value = "Returned" Then
                row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 77, 0)
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 77, 0)
            End If
        Next

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles pendingRadio.CheckedChanged
        logTableFilter("Pending")
        radioStatusQuery = "pending"
        logReturnForm.searchText.ResetText()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles cancelledRadio.CheckedChanged
        logTableFilter("Cancelled")
        radioStatusQuery = "cancelled"
        logReturnForm.searchText.ResetText()
    End Sub
    Function logTableFilter(ByVal condition As String)
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookCallNumber, clientID, dateLoaned, dateDue, loanStatus
                 FROM
                   opac.loan
                 WHERE 
                   loanStatus = '" & condition & "'
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

    Private Sub returnedRadio_CheckedChanged(sender As Object, e As EventArgs) Handles returnedRadio.CheckedChanged
        logTableFilter("Returned")
        radioStatusQuery = "returned"
        logReturnForm.searchText.ResetText()
        logReturnForm.searchText.ResetText()
    End Sub

    Private Sub inuseRadio_CheckedChanged(sender As Object, e As EventArgs) Handles inuseRadio.CheckedChanged
        logTableFilter("In-use")
        radioStatusQuery = "in-use"
    End Sub

    Private Sub allRadio_CheckedChanged(sender As Object, e As EventArgs) Handles allRadio.CheckedChanged
        logReset()
        radioStatusQuery = "all"

        logReturnForm.searchText.ResetText()
    End Sub

End Class