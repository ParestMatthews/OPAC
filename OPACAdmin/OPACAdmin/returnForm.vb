Imports MySql.Data.MySqlClient
Public Class returnForm
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Public callNumberShare As String
    Public userIdShare As New Integer
    Public costShare As New Decimal
    Private Sub logDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles returnDataTable.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim callNumber As String = returnDataTable.Rows(e.RowIndex).Cells(1).Value
            callNumberShare = callNumber
            Dim userId As New Integer
            userId = returnDataTable.Rows(e.RowIndex).Cells(3).Value
            userIdShare = userId
            Dim overDueStatus As String = returnDataTable.Rows(e.RowIndex).Cells(5).Value
            Dim cost As New Decimal


            If overDueStatus = "Yes" Then

                Dim dateDue As Date = returnDataTable.Rows(e.RowIndex).Cells(4).Value
                Dim costResult As String

                cost = Math.Round(Date.Today.Subtract(dateDue).TotalDays * 50, 2)
                costShare = cost
                costResult = "₱ " + Format(cost, "0.00").ToString
                returnOne.overCostText.Text = costResult
                customMessageBoxTwo.ShowDialog()

            ElseIf overDueStatus = "No" Then
                statusUpdate(callNumber, userId, "Returned", cost)
            End If


        End If
    End Sub

    Private Sub returnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetReturns()
    End Sub

    Private Sub returnDataTable_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles returnDataTable.CellFormatting

    End Sub

    Private Sub returnDataTable_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles returnDataTable.CellStateChanged


    End Sub

    Public Function statusUpdate(ByVal cNumber As String, ByVal uID As Integer, ByVal nextStatus As String, ByVal overDue As Decimal)

        If nextStatus = "Returned" Then

            updateBookAvailability(cNumber)
        End If
        Try
            dbConn.Open()
            dbQuery = "
                 UPDATE
                    loan
                 SET
                    loanStatus = @status,
                    overDuePay = @cost
                 WHERE 
                   bookCallNumber = '" & cNumber & "' 
                   AND clientId = '" & uID & "'
                   AND loanStatus = 'In-use'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@status", nextStatus)
            dbCommand.Parameters.AddWithValue("@cost", overDue)
            dbCommand.ExecuteNonQuery()
            dbConn.Close()
            adminDashboard.masterResets()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function resetReturns()
        returnDataTable.Columns.Clear()
        Dim returnColumn As New DataGridViewButtonColumn()
        returnColumn.Text = "Return"
        returnColumn.UseColumnTextForButtonValue = True
        returnDataTable.Columns.Add(returnColumn)
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   loan.bookCallNumber, CONCAT(book.bookTitle,' ',book.bookEdition), loan.clientId, loan.dateDue
                 FROM
                   opac.loan
                 
                 INNER JOIN
                    book ON book.bookCallNumber = loan.bookCallNumber
                 WHERE
                    loan.loanStatus = 'In-use'
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
            returnDataTable.DataSource = bindSource

            Dim overColumn As New DataGridViewTextBoxColumn()
            overColumn.HeaderText = "Over Due"
            returnDataTable.Columns.Add(overColumn)
            For Each row As DataGridViewRow In returnDataTable.Rows
                If Format(row.Cells(4).Value) < Format(Date.Today) Then
                    row.Cells(5).Value = "Yes"

                    row.DefaultCellStyle.ForeColor = Color.FromArgb(128, 0, 0)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 153)
                    row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 0, 0)
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 153, 153)

                ElseIf Format(row.Cells(4).Value) >= Format(Date.Today) Then
                    row.Cells(5).Value = "No"
                End If
            Next


            With returnDataTable


                .Columns(1).HeaderCell.Value = "Book Call Number"
                .Columns(2).HeaderCell.Value = "Book Name"
                .Columns(3).HeaderCell.Value = "User ID"
                .Columns(4).HeaderCell.Value = "Due Date"
                .Columns(5).HeaderCell.Value = "Over Due"

                .Columns(0).Width = Me.Width / 12
                .Columns(1).Width = Me.Width / 10
                .Columns(2).Width = Me.Width / 2
                .Columns(3).Width = Me.Width / 8
                .Columns(4).Width = Me.Width / 9
                .Columns(5).Width = Me.Width / 9

                .Columns(1).HeaderCell.Style.Font = New Font(returnDataTable.Font, FontStyle.Bold)
                .Columns(2).HeaderCell.Style.Font = New Font(returnDataTable.Font, FontStyle.Bold)
                .Columns(3).HeaderCell.Style.Font = New Font(returnDataTable.Font, FontStyle.Bold)
                .Columns(4).HeaderCell.Style.Font = New Font(returnDataTable.Font, FontStyle.Bold)
                .Columns(5).HeaderCell.Style.Font = New Font(returnDataTable.Font, FontStyle.Bold)


            End With

            dbAdapter.Update(dbTable)
            dbConn.Close()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function updateBookAvailability(ByVal callNumber As String)
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