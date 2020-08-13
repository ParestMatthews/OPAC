Imports MySql.Data.MySqlClient
Public Class archiveUser
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub bunifuBooks_Click(sender As Object, e As EventArgs) Handles bunifuBooks.Click

    End Sub

    Private Sub bunifuUsers_Click(sender As Object, e As EventArgs) Handles bunifuUsers.Click

    End Sub

    Private Sub usersDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersDataTable.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim id As String = usersDataTable.Rows(e.RowIndex).Cells(1).Value
            Try
                dbConn = dbFunction()
                dbConn.Open()
                dbQuery = "
                 UPDATE
                    client
                 SET
                   clientArchived = 0
                 WHERE 
                   clientId = @id
                "
                dbCommand = New MySqlCommand(dbQuery, dbConn)
                dbCommand.Parameters.AddWithValue("@id", id)
                dbCommand.ExecuteNonQuery()
                dbConn.Close()
                loadUsersTable()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Function loadUsersTable()
        usersDataTable.Columns.Clear()
        Dim restoreColumn As New DataGridViewButtonColumn()
        restoreColumn.Text = "Restore"
        restoreColumn.UseColumnTextForButtonValue = True
        usersDataTable.Columns.Add(restoreColumn)
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   client.clientID, CONCAT(client.clientFirstName,' ',client.clientLastName), client.clientCourse, client.clientYearLevel
                 FROM
                   opac.client
                 WHERE
                    clientArchived = 1
                ORDER BY
                    clientFirstName
                ASC
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            usersDataTable.DataSource = bindSource




            With usersDataTable
                .Columns(1).HeaderCell.Value = "ID"
                .Columns(2).HeaderCell.Value = "Full Name"
                .Columns(3).HeaderCell.Value = "Course"
                .Columns(4).HeaderCell.Value = "Year Level"

                .Columns(0).Width = Me.Width / 20
                .Columns(1).Width = Me.Width / 10
                .Columns(2).Width = Me.Width / 8
                .Columns(3).Width = Me.Width / 8
                .Columns(4).Width = Me.Width / 8

                .Columns(1).HeaderCell.Style.Font = New Font(usersDataTable.Font, FontStyle.Bold)
                .Columns(2).HeaderCell.Style.Font = New Font(usersDataTable.Font, FontStyle.Bold)
                .Columns(3).HeaderCell.Style.Font = New Font(usersDataTable.Font, FontStyle.Bold)
                .Columns(4).HeaderCell.Style.Font = New Font(usersDataTable.Font, FontStyle.Bold)
            End With

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub archiveUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsersTable()
    End Sub
End Class