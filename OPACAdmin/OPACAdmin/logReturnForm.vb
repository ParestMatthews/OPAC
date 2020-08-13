Imports MySql.Data.MySqlClient
Public Class logReturnForm
    Dim searchFlag As String = "log"
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub logReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(searchText, "Search Record by Call Number, User ID, or User Name")
        bunifuLog.selected = True
        pagePanel(logForm)
    End Sub
    Sub pagePanel(ByVal panel As Form)
        logReturnPanel.Controls.Clear()
        panel.TopLevel = False
        logReturnPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub bunifuLog_Click(sender As Object, e As EventArgs) Handles bunifuLog.Click
        pagePanel(logForm)
        searchText.ResetText()
        searchFlag = "log"
        SetCueText(searchText, "Search Record by Call Number, User ID, or User Name")
    End Sub

    Private Sub bunifuReturns_Click(sender As Object, e As EventArgs) Handles bunifuReturns.Click
        pagePanel(returnForm)
        searchText.ResetText()
        searchFlag = "return"
        SetCueText(searchText, "Search Returns by Call Number, User ID, or User Name")
    End Sub

    Private Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        If searchFlag = "log" Then
            searchQuery()
        ElseIf searchFlag = "return" Then
            searchQueryTwo()
        End If
    End Sub
    Function searchQuery()
        If logForm.radioStatusQuery = "all" Then
            Try
                dbConn = dbFunction()
                dbConn.Open()
                dbQuery = "
                 SELECT 
                   loan.bookCallNumber, loan.clientId, loan.dateLoaned, loan.dateDue, loan.loanStatus
                 FROM
                   loan
                 INNER JOIN
                    client ON loan.clientId = client.clientId 
                WHERE 
                    loan.bookCallNumber LIKE @callnumber or
                    loan.clientId LIKE @userid or
                    CONCAT(client.clientFirstName,' ',client.clientLastName) LIKE @clientname
                 ORDER BY
                    loan.dateLoaned
                 DESC
                "
                Dim dbTable As New DataTable
                Dim dbAdapter As New MySqlDataAdapter
                Dim bindSource As New BindingSource
                dbCommand = New MySqlCommand(dbQuery, dbConn)
                dbCommand.Parameters.AddWithValue("@callnumber", "%" & searchText.Text & "%")
                dbCommand.Parameters.AddWithValue("@userid", "%" & searchText.Text & "%")
                dbCommand.Parameters.AddWithValue("@clientname", "%" & searchText.Text & "%")
                dbAdapter.SelectCommand = dbCommand
                dbAdapter.Fill(dbTable)
                bindSource.DataSource = dbTable
                logForm.logDataTable.DataSource = bindSource

                dbAdapter.Update(dbTable)
                dbConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim condition As String = logForm.radioStatusQuery
            Try
                dbConn = dbFunction()
                dbConn.Open()
                dbQuery = "
                 SELECT 
                   loan.bookCallNumber, loan.clientId, loan.dateLoaned, loan.dateDue, loan.loanStatus
                 FROM
                   loan
                 INNER JOIN
                    client ON loan.clientId = client.clientId
                WHERE 
                    (loan.bookCallNumber LIKE @callnumber or
                    loan.clientId LIKE @userid or
                    CONCAT(client.clientFirstName,' ',client.clientLastName) LIKE @clientname) AND
                    loanStatus = '" & condition & "'

                 ORDER BY
                    loan.dateLoaned
                 DESC
                "
                Dim dbTable As New DataTable
                Dim dbAdapter As New MySqlDataAdapter
                Dim bindSource As New BindingSource
                dbCommand = New MySqlCommand(dbQuery, dbConn)
                dbCommand.Parameters.AddWithValue("@callnumber", "%" & searchText.Text & "%")
                dbCommand.Parameters.AddWithValue("@userid", "%" & searchText.Text & "%")
                dbCommand.Parameters.AddWithValue("@clientname", "%" & searchText.Text & "%")
                dbAdapter.SelectCommand = dbCommand
                dbAdapter.Fill(dbTable)
                bindSource.DataSource = dbTable
                logForm.logDataTable.DataSource = bindSource

                dbAdapter.Update(dbTable)
                dbConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Function
    Function searchQueryTwo()
        Try
            dbConn = dbFunction()
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   loan.bookCallNumber, CONCAT(book.bookTitle,' ',book.bookEdition), loan.clientId, loan.dateDue
                 FROM
                   opac.loan
                 INNER JOIN
                    client ON loan.clientId = client.clientId
                 INNER JOIN
                    book ON book.bookCallNumber = loan.bookCallNumber
                 WHERE
                    loan.loanStatus = 'In-use' AND
                    (loan.bookCallNumber LIKE @callnumber OR
                    loan.clientId LIKE @userid OR
                    CONCAT(client.clientFirstName,' ',client.clientLastName) LIKE @clientname)
                 ORDER BY
                    loan.dateLoaned
                 DESC
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@callnumber", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@userid", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@clientname", "%" & searchText.Text & "%")
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            returnForm.returnDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class