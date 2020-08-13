Imports MySql.Data.MySqlClient
Public Class approvalForm
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub approvalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        approvalDataTable.Columns.Clear() 'important AF
        Dim buttonColumn As New DataGridViewButtonColumn()

        buttonColumn.Text = "Approve"
        buttonColumn.UseColumnTextForButtonValue = True
        approvalDataTable.Columns.Add(buttonColumn)
        dim rejectColumn As New DataGridViewButtonColumn()
        rejectColumn.Text = "Cancel"
        rejectColumn.UseColumnTextForButtonValue = True
        approvalDataTable.Columns.Add(rejectColumn)
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   loan.bookCallNumber, CONCAT(book.bookTitle,' ',book.bookEdition) as bookComplete, loan.clientId, CONCAT(client.clientFirstName,' ',client.clientLastName) AS fullName
                 FROM
                   opac.loan
                 INNER JOIN
                    client ON loan.clientId = client.clientId
                 INNER JOIN
                    book ON book.bookCallNumber = loan.bookCallNumber
                 WHERE
                    loan.loanStatus = 'Pending'
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
            approvalDataTable.DataSource = bindSource
            With approvalDataTable
                .Columns(2).HeaderCell.Value = "Book Call Number"
                .Columns(3).HeaderCell.Value = "Book Name"
                .Columns(4).HeaderCell.Value = "User ID"
                .Columns(5).HeaderCell.Value = "User Name"

                .Columns(0).Width = Me.Width / 16
                .Columns(1).Width = Me.Width / 16
                .Columns(2).Width = Me.Width / 16
                .Columns(3).Width = Me.Width / 4
                .Columns(4).Width = Me.Width / 14
                .Columns(5).Width = Me.Width / 8

                .Columns(2).HeaderCell.Style.Font = New Font(approvalDataTable.Font, FontStyle.Bold)
                .Columns(3).HeaderCell.Style.Font = New Font(approvalDataTable.Font, FontStyle.Bold)
                .Columns(4).HeaderCell.Style.Font = New Font(approvalDataTable.Font, FontStyle.Bold)
                .Columns(5).HeaderCell.Style.Font = New Font(approvalDataTable.Font, FontStyle.Bold)
            End With
            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub approvalForm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

    End Sub

    Private Sub approvalDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles approvalDataTable.CellContentClick

        If e.ColumnIndex = 0 Then
            Dim callNumber As String = approvalDataTable.Rows(e.RowIndex).Cells(2).Value
            Dim userId As Integer = approvalDataTable.Rows(e.RowIndex).Cells(4).Value
            statusUpdate(callNumber, userId, "In-use")
        ElseIf e.ColumnIndex = 1 Then
            Dim callNumber As String = approvalDataTable.Rows(e.RowIndex).Cells(2).Value
            Dim userId As Integer = approvalDataTable.Rows(e.RowIndex).Cells(4).Value
            statusUpdate(callNumber, userId, "Cancelled")
        End If
    End Sub
    Function statusUpdate(ByVal cNumber As String, ByVal uID As Integer, ByVal nextStatus As String)
        Dim dateToday As Nullable(Of DateTime) = Date.Today
        Dim dateDue As Nullable(Of DateTime) = DateAdd("d", 2, Date.Today)
        If nextStatus = "Cancelled" Then
            dateDue = Nothing
            updateBookAvailability(cNumber)
        End If
        Try
            dbConn.Open()
            dbQuery = "
                 UPDATE
                    loan
                 SET
                    dateLoaned = @dateLoaned,
                    dateDue = @dateDue,
                    loanStatus = @status
                 WHERE 
                   bookCallNumber = '" & cNumber & "' 
                   AND clientId = '" & uID & "'
                   AND loanStatus = 'Pending'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@dateLoaned", dateToday)
            dbCommand.Parameters.AddWithValue("@dateDue", dateDue)
            dbCommand.Parameters.AddWithValue("@status", nextStatus)
            dbCommand.ExecuteNonQuery()
            dbConn.Close()
            resetApprovals()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Function resetApprovals()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   loan.bookCallNumber, CONCAT(book.bookTitle,' ',book.bookEdition) as bookComplete, loan.clientId, CONCAT(client.clientFirstName,' ',client.clientLastName) AS fullName
                 FROM
                   opac.loan
                 INNER JOIN
                    client ON loan.clientId = client.clientId
                 INNER JOIN
                    book ON book.bookCallNumber = loan.bookCallNumber
                 WHERE
                    loan.loanStatus = 'Pending'
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
            approvalDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function updateBookAvailability(ByVal callNumber As String)
        Try
            dbConn.Open()
            dbQuery = "
                 UPDATE
                    book
                 SET
                    bookLoaned = @flag
                 WHERE 
                   bookCallNumber = '" & callNumber & "'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@flag", False)
            dbCommand.ExecuteNonQuery()
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class