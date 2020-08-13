Imports MySql.Data.MySqlClient
Public Class cardTabDisplayForm
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub cardTabDisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cardTabReset()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bunifuCardButton_Click(sender As Object, e As EventArgs) Handles bunifuCardButton.Click
        showPanel(cardDisplay)


    End Sub
    Sub showPanel(ByVal panel As Form)
        cardTabPanel.Controls.Clear()
        panel.TopLevel = False
        cardTabPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub bunifuAddButton_Click(sender As Object, e As EventArgs) Handles bunifuAddButton.Click
        accession()
        customMessageBox.ShowDialog()
    End Sub
    Function accession()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT book.bookCallNumber
            FROM book
            WHERE book.bookTitle = '" & booksTable.bookTitle & "'
            AND bookLoaned = 0 
            AND bookEdition = '" & booksTable.bookEdition & "'
            AND bookArchived = 0
            ORDER BY bookCallNumber ASC
            "
        conn.Open()
        Dim command As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader()
        listAccession.CheckedListBox1.Items.Clear()

        While reader.Read()
            listAccession.CheckedListBox1.Items.Add(reader.GetString("bookCallNumber"))
        End While
        conn.Close()
    End Function

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        booksForm.showPanel(booksTable)
        cardTabReset()

    End Sub
    Public Function resetTable()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   MIN(bookTitle)
                 AS
                   bookTitle,
                   bookEdition
                 FROM
                   opac.book
                 GROUP BY bookTitle, bookEdition
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            booksTable.searchDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Private Sub bunifuTabButton_Click(sender As Object, e As EventArgs) Handles bunifuTabButton.Click
        showPanel(tabDisplay)
    End Sub
    Public Function cardTabReset()
        bunifuCardButton.selected = True
        bunifuTabButton.selected = False
        showPanel(cardDisplay)
    End Function

    Private Sub cardTabPanel_Paint(sender As Object, e As PaintEventArgs) Handles cardTabPanel.Paint

    End Sub
End Class