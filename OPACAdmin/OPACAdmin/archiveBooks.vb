Imports MySql.Data.MySqlClient
Public Class archiveBooks
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub returnDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Function loadBooksTable()
        booksDataTable.Columns.Clear()
        Dim restoreColumn As New DataGridViewButtonColumn()
        restoreColumn.Text = "Restore"
        restoreColumn.UseColumnTextForButtonValue = True
        booksDataTable.Columns.Add(restoreColumn)
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   book.bookCallNumber, book.bookTitle, book.bookEdition
                 FROM
                   opac.book
                 WHERE
                    bookArchived = 1
               
                ORDER BY
                    bookCallNumber
                ASC
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            booksDataTable.DataSource = bindSource




            With booksDataTable
                .Columns(1).HeaderCell.Value = "Book Call Number"
                .Columns(2).HeaderCell.Value = "Book Name"
                .Columns(3).HeaderCell.Value = "Book Edition"

                .Columns(0).Width = Me.Width / 12
                .Columns(1).Width = Me.Width / 10
                .Columns(2).Width = Me.Width / 2
                .Columns(3).Width = Me.Width / 8

                .Columns(1).HeaderCell.Style.Font = New Font(booksDataTable.Font, FontStyle.Bold)
                .Columns(2).HeaderCell.Style.Font = New Font(booksDataTable.Font, FontStyle.Bold)
                .Columns(3).HeaderCell.Style.Font = New Font(booksDataTable.Font, FontStyle.Bold)
            End With

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub archiveBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBooksTable()
    End Sub

    Private Sub booksDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles booksDataTable.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim callNumber As String = booksDataTable.Rows(e.RowIndex).Cells(1).Value
            Try
                dbConn = dbFunction()
                dbConn.Open()
                dbQuery = "
                 UPDATE
                    book
                 SET
                   bookArchived = 0
                 WHERE 
                   bookCallNumber = @cNumber
                "
                dbCommand = New MySqlCommand(dbQuery, dbConn)
                dbCommand.Parameters.AddWithValue("@cNumber", callNumber)
                dbCommand.ExecuteNonQuery()
                dbConn.Close()
                loadBooksTable()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class