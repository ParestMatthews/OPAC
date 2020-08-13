Imports MySql.Data.MySqlClient
Public Class archiveForm
    Dim searchFlag As String = "books"
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub archiveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(searchText, "Search Book by Call Number or Book Name")
        bunifuBooks.selected = True
        pagePanel(archiveBooks)
    End Sub
    Sub pagePanel(ByVal panel As Form)
        archivePanel.Controls.Clear()
        panel.TopLevel = False
        archivePanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub bunifuBooks_Click(sender As Object, e As EventArgs) Handles bunifuBooks.Click
        pagePanel(archiveBooks)
        searchText.ResetText()
        searchFlag = "books"
        SetCueText(searchText, "Search Book by Call Number or Book Name")
    End Sub

    Private Sub bunifuUsers_Click(sender As Object, e As EventArgs) Handles bunifuUsers.Click
        pagePanel(archiveUser)
        searchText.ResetText()
        searchFlag = "users"
        SetCueText(searchText, "Search User by ID, Name, or Course")
    End Sub

    Private Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        If searchFlag = "books" Then
            searchOne()
        ElseIf searchFlag = "users" Then
            searchTwo()
        End If
    End Sub
    Function searchOne()
        Try
            dbConn = dbFunction()
            dbConn.Open()
            dbQuery = "
                  SELECT 
                   book.bookCallNumber, book.bookTitle, book.bookEdition
                 FROM
                   opac.book
                 WHERE
                    bookArchived = 1
                      AND 
                    (
                    bookCallnumber LIKE @cNumber OR
                    bookTitle Like @title
                   )
                ORDER BY
                    bookCallNumber
                ASC
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@cNumber", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@title", "%" & searchText.Text & "%")
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            archiveBooks.booksDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function searchTwo()
        Try
            dbConn = dbFunction()
            dbConn.Open()
            dbQuery = "
                   SELECT 
                   client.clientId, CONCAT(client.clientFirstName,' ',client.clientLastName), client.clientCourse, client.clientYearLevel
                 FROM
                   opac.client
                 WHERE
                    clientArchived = 1
                        AND
                    (   
                    clientId LIKE @id OR
                    CONCAT(client.clientFirstName,' ',client.clientLastName) LIKE @name OR
                    clientCourse LIKE @course
                    )
                ORDER BY
                    clientFirstName
                ASC
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@id", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@name", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@course", "%" & searchText.Text & "%")
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            archiveUser.usersDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class