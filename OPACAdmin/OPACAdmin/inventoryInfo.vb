Imports MySql.Data.MySqlClient
Public Class inventoryInfo
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub inventoryInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        allInfoPanels(infoOne)

    End Sub
    Sub allInfoPanels(ByVal panel As Form)
        allInfoPanel.Controls.Clear()
        panel.TopLevel = False
        allInfoPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub bunifuAddButton_Click(sender As Object, e As EventArgs) Handles bunifuReturn.Click
        resetUpdate()
        resetTable()

        InventoryForm.inventoryPanels(inventoryTable)
    End Sub

    Private Sub allInfoPanel_Paint(sender As Object, e As PaintEventArgs) Handles allInfoPanel.Paint

    End Sub

    Private Sub bunifuButtonOne_Click(sender As Object, e As EventArgs) Handles bunifuButtonOne.Click
        allInfoPanels(infoOne)
    End Sub

    Private Sub bunifuButtonTwo_Click(sender As Object, e As EventArgs) Handles bunifuButtonTwo.Click
        allInfoPanels(infoTwo)
    End Sub

    Private Sub bunifuButtonThree_Click(sender As Object, e As EventArgs) Handles bunifuButtonThree.Click
        allInfoPanels(infoThree)
    End Sub

    Private Sub bunifuUpdateSave_Click(sender As Object, e As EventArgs) Handles bunifuUpdateSave.Click
        If bunifuUpdateSave.IdleFillColor = Color.Maroon Then
            bunifuUpdateSave.ButtonText = "Save"
            bunifuUpdateSave.ActiveFillColor = Color.FromArgb(46, 139, 87)
            bunifuUpdateSave.ActiveLineColor = Color.FromArgb(46, 139, 87)
            bunifuUpdateSave.IdleFillColor = Color.FromArgb(36, 129, 77)
            bunifuUpdateSave.IdleLineColor = Color.FromArgb(36, 129, 77)

            infoOne.titleText.Enabled = True
            infoOne.titleText.BackColor = Color.White


            infoOne.languageText.Enabled = True
            infoOne.languageText.BackColor = Color.White

            infoTwo.otherTitleText.Enabled = True
            infoTwo.otherTitleText.BackColor = Color.White
            infoTwo.parallelTitleText.Enabled = True
            infoTwo.parallelTitleText.BackColor = Color.White
            infoTwo.authorText.Enabled = True
            infoTwo.authorText.BackColor = Color.White
            infoTwo.corpAuthorText.Enabled = True
            infoTwo.corpAuthorText.BackColor = Color.White
            infoTwo.otherAuthorText.Enabled = True
            infoTwo.otherAuthorText.BackColor = Color.White
            infoTwo.editorText.Enabled = True
            infoTwo.editorText.BackColor = Color.White

            infoThree.publishedText.Enabled = True
            infoThree.publishedText.BackColor = Color.White
            infoThree.publisherText.Enabled = True
            infoThree.publisherText.BackColor = Color.White
            infoThree.yearPublishedText.Enabled = True
            infoThree.yearPublishedText.BackColor = Color.White
            infoThree.pagesText.Enabled = True
            infoThree.pagesText.BackColor = Color.White
            infoThree.editionText.Enabled = True
            infoThree.editionText.BackColor = Color.White
            infoThree.seriesText.Enabled = True
            infoThree.seriesText.BackColor = Color.White
            infoThree.generalNotesText.Enabled = True
            infoThree.generalNotesText.BackColor = Color.White
            infoThree.isbnText.Enabled = True
            infoThree.isbnText.BackColor = Color.White
            infoThree.otherDetailsText.Enabled = True
            infoThree.otherDetailsText.BackColor = Color.White

            bunifuAdd.Visible = False
            bunifuRemove.Visible = False
        Else
            resetUpdate() 'public function
            dbConn = dbFunction()
            Try
                dbConn.Open()
                dbQuery = "
                 UPDATE
                    book
                 SET
                    bookTitle = @title,
                    bookAuthor = @author,
                    bookLocation = @location,
                    bookPublished = @published,
                    bookISBN = @isbn,
                    bookEdition = @edition,
                    bookLanguage = @language,
                    bookOtherTitle = @otherTitle,
                    bookParallelTitle = @parallelTitle,
                    bookOtherAuthor = @otherAuthor,
                    bookEditor = @editor,
                    bookCorpAuthor = @corpAuthor,
                    bookPublisher = @publisher,
                    bookYearPublished = @yearPublished,
                    bookPages = @pages,
                    bookSeries = @series,
                    bookGeneralNotes = @generalNotes,
                    bookOtherDetails = @otherDetails
                 WHERE 
                   bookTitle = '" & inventoryTable.bookTitle & "' AND bookEdition = '" & inventoryTable.bookEdition & "'
                "
                dbCommand = New MySqlCommand(dbQuery, dbConn)
                dbCommand.Parameters.AddWithValue("@title", infoOne.titleText.Text)
                dbCommand.Parameters.AddWithValue("@author", infoTwo.authorText.Text)
                dbCommand.Parameters.AddWithValue("@location", infoOne.locationText.Text)
                dbCommand.Parameters.AddWithValue("@published", infoThree.publishedText.Text)
                dbCommand.Parameters.AddWithValue("@isbn", infoThree.isbnText.Text)
                dbCommand.Parameters.AddWithValue("@edition", infoThree.editionText.Text)
                dbCommand.Parameters.AddWithValue("@language", infoOne.languageText.Text)
                dbCommand.Parameters.AddWithValue("@otherTitle", infoTwo.otherTitleText.Text)
                dbCommand.Parameters.AddWithValue("@parallelTitle", infoTwo.parallelTitleText.Text)
                dbCommand.Parameters.AddWithValue("@otherAuthor", infoTwo.otherAuthorText.Text)
                dbCommand.Parameters.AddWithValue("@editor", infoTwo.editorText.Text)
                dbCommand.Parameters.AddWithValue("@corpAuthor", infoTwo.corpAuthorText.Text)
                dbCommand.Parameters.AddWithValue("@publisher", infoThree.publisherText.Text)
                dbCommand.Parameters.AddWithValue("@yearPublished", infoThree.yearPublishedText.Text)
                dbCommand.Parameters.AddWithValue("@pages", infoThree.pagesText.Text)
                dbCommand.Parameters.AddWithValue("@series", infoThree.seriesText.Text)
                dbCommand.Parameters.AddWithValue("@generalNotes", infoThree.generalNotesText.Text)
                dbCommand.Parameters.AddWithValue("@otherDetails", infoThree.otherDetailsText.Text)
                dbCommand.ExecuteNonQuery()
                inventoryTable.bookTitle = infoOne.titleText.Text
                inventoryTable.bookEdition = infoThree.editionText.Text
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            bunifuAdd.Visible = True
            bunifuRemove.Visible = True
        End If
    End Sub
    Public Function resetUpdate()
        bunifuUpdateSave.ButtonText = "Update"
        bunifuUpdateSave.ActiveFillColor = Color.Firebrick
        bunifuUpdateSave.ActiveLineColor = Color.Firebrick

        bunifuUpdateSave.IdleFillColor = Color.Maroon
        bunifuUpdateSave.IdleLineColor = Color.Maroon

        infoOne.titleText.Enabled = False
        infoOne.titleText.BackColor = Color.WhiteSmoke

        infoOne.locationText.Enabled = False
        infoOne.locationText.BackColor = Color.WhiteSmoke
        infoOne.languageText.Enabled = False
        infoOne.languageText.BackColor = Color.WhiteSmoke

        infoTwo.otherTitleText.Enabled = False
        infoTwo.otherTitleText.BackColor = Color.WhiteSmoke
        infoTwo.parallelTitleText.Enabled = False
        infoTwo.parallelTitleText.BackColor = Color.WhiteSmoke
        infoTwo.authorText.Enabled = False
        infoTwo.authorText.BackColor = Color.WhiteSmoke
        infoTwo.corpAuthorText.Enabled = False
        infoTwo.corpAuthorText.BackColor = Color.WhiteSmoke
        infoTwo.otherAuthorText.Enabled = False
        infoTwo.otherAuthorText.BackColor = Color.WhiteSmoke
        infoTwo.editorText.Enabled = False
        infoTwo.editorText.BackColor = Color.WhiteSmoke

        infoThree.publishedText.Enabled = False
        infoThree.publishedText.BackColor = Color.WhiteSmoke
        infoThree.publisherText.Enabled = False
        infoThree.publisherText.BackColor = Color.WhiteSmoke
        infoThree.yearPublishedText.Enabled = False
        infoThree.yearPublishedText.BackColor = Color.WhiteSmoke
        infoThree.pagesText.Enabled = False
        infoThree.pagesText.BackColor = Color.WhiteSmoke
        infoThree.editionText.Enabled = False
        infoThree.editionText.BackColor = Color.WhiteSmoke
        infoThree.seriesText.Enabled = False
        infoThree.seriesText.BackColor = Color.WhiteSmoke
        infoThree.generalNotesText.Enabled = False
        infoThree.generalNotesText.BackColor = Color.WhiteSmoke
        infoThree.isbnText.Enabled = False
        infoThree.isbnText.BackColor = Color.WhiteSmoke
        infoThree.otherDetailsText.Enabled = False
        infoThree.otherDetailsText.BackColor = Color.WhiteSmoke

        bunifuAdd.Visible = True
        bunifuRemove.Visible = True
        Return 0
    End Function
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
            inventoryTable.searchDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Private Sub bunifuAdd_Click(sender As Object, e As EventArgs) Handles bunifuAdd.Click
        entryOne.addStyleStatus = "existingBook"
        customMessageBox.ShowDialog()


    End Sub

    Private Sub bunifuRemove_Click(sender As Object, e As EventArgs) Handles bunifuRemove.Click
        bookDeleteTable()
        customMessageBoxThree.ShowDialog()

    End Sub
    Public Function bookDeleteTable()

        nonDeletedBooks()
        loanedBooks()
    End Function
    Public Function nonDeletedBooks()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
            SELECT book.bookCallNumber
            FROM book
            WHERE book.bookTitle = '" & infoOne.titleText.Text & "'
            AND bookEdition = '" & infoThree.editionText.Text & "'
            AND bookArchived  = 0
            AND bookLoaned = 0
            ORDER BY bookCallNumber ASC
                "
            Dim command As New MySqlCommand(dbQuery, dbConn)
            Dim reader As MySqlDataReader
            reader = command.ExecuteReader()
            deleteOne.CheckedListBox1.Items.Clear()
            deleteOne.CheckedListBox1.Items.Add("Select All")
            While reader.Read()
                deleteOne.CheckedListBox1.Items.Add(reader.GetString("bookCallNumber"))
            End While
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function loanedBooks()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
            SELECT book.bookCallNumber
            FROM book
            WHERE book.bookTitle = '" & infoOne.titleText.Text & "'
            AND bookEdition = '" & infoThree.editionText.Text & "'
            AND bookArchived  = 0
            AND bookLoaned = 1
            ORDER BY bookCallNumber ASC
                "
            Dim command As New MySqlCommand(dbQuery, dbConn)
            Dim reader As MySqlDataReader
            reader = command.ExecuteReader()

            While reader.Read()
                deleteOne.CheckedListBox1.Items.Add(reader.GetString("bookCallNumber") + " (Out/Pending)")
            End While
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class

