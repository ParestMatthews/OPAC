Imports MySql.Data.MySqlClient
Public Class entryOne
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Public addStyleStatus As String
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        customMessageBox.Close()
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        Dim counter As Integer = counterText.Text

        If addStyleStatus = "newBook" Then

            For index As Integer = 1 To counter
                dbConn = dbFunction()
                dbConn.Open()
                Dim randomFinal As String = recursiveId()
                dbQuery = "
                INSERT INTO opac.book (
	                bookCallNumber,
                    bookLanguage,
                    bookLocation,
                    bookTitle,
                    bookOtherTitle, 
                    bookParallelTitle,
                    bookAuthor,
                    bookOtherAuthor,
                    bookEditor,
                    bookCorpauthor,
                    bookPublished,
                    bookPublisher,
                    bookYearPublished,
                    bookPages,
                    bookEdition,
                    bookSeries,
                    bookGeneralNotes,
                    bookISBN,
                    bookOtherDetails
                    ) 
                      VALUES(
                    '" & randomFinal & "',
                    @language,
                    @location,
                    @title,
                    @othertitle,
                    @paralleltitle,
                    @author,
                    @otherauthor,
                    @editor,
                    @corpauthor,
                    @published,
                    @publisher,
                    @yearpublished,
                    @pages,
                    @edition,
                    @series,
                    @generalnotes,
                    @isbn,
                    @otherdetails
                   )"
                dbCommand = New MySqlCommand(dbQuery, dbConn)

                dbCommand.Parameters.AddWithValue("@language", localInformation.languageText.selectedValue)
                dbCommand.Parameters.AddWithValue("@location", localInformation.locationText.Text)

                dbCommand.Parameters.AddWithValue("@title", titleStatementForm.titleText.Text)
                dbCommand.Parameters.AddWithValue("@othertitle", titleStatementForm.otherTitleText.Text)
                dbCommand.Parameters.AddWithValue("@paralleltitle", titleStatementForm.parallelTitleText.Text)
                dbCommand.Parameters.AddWithValue("@author", titleStatementForm.authorText.Text)
                dbCommand.Parameters.AddWithValue("@otherauthor", titleStatementForm.otherAuthorText.Text)
                dbCommand.Parameters.AddWithValue("@editor", titleStatementForm.editorText.Text)
                dbCommand.Parameters.AddWithValue("@corpauthor", titleStatementForm.corpAuthorText.Text)

                dbCommand.Parameters.AddWithValue("@published", pdiForm.publishedText.Text)
                dbCommand.Parameters.AddWithValue("@publisher", pdiForm.publisherText.Text)
                dbCommand.Parameters.AddWithValue("@yearpublished", pdiForm.yearPublishedText.Text)
                dbCommand.Parameters.AddWithValue("@pages", pdiForm.pagesText.Text)
                dbCommand.Parameters.AddWithValue("@edition", pdiForm.editionText.Text)
                dbCommand.Parameters.AddWithValue("@series", pdiForm.seriesText.Text)
                dbCommand.Parameters.AddWithValue("@generalnotes", pdiForm.generalNotesText.Text)
                dbCommand.Parameters.AddWithValue("@isbn", pdiForm.isbnText.Text)
                dbCommand.Parameters.AddWithValue("@otherdetails", pdiForm.otherDetailsText.Text)

                dbCommand.ExecuteNonQuery()


            Next
            localInformation.callNumber.selectedIndex = Nothing
            localInformation.languageText.selectedIndex = Nothing
            localInformation.locationText.ResetText()

            titleStatementForm.titleText.ResetText()
            titleStatementForm.otherTitleText.ResetText()
            titleStatementForm.parallelTitleText.ResetText()
            titleStatementForm.authorText.ResetText()
            titleStatementForm.otherAuthorText.ResetText()
            titleStatementForm.editorText.ResetText()
            titleStatementForm.corpAuthorText.ResetText()

            pdiForm.publishedText.ResetText()
            pdiForm.publisherText.ResetText()
            pdiForm.yearPublishedText.ResetText()
            pdiForm.pagesText.ResetText()
            pdiForm.editionText.ResetText()
            pdiForm.seriesText.ResetText()
            pdiForm.generalNotesText.ResetText()
            pdiForm.isbnText.ResetText()
            pdiForm.otherDetailsText.ResetText()
        ElseIf addStyleStatus = "existingBook" Then

            For index As Integer = 1 To counter
                dbConn = dbFunction()
                dbConn.Open()
                Dim randomFinal As String = recursiveId()
                dbQuery = "
                INSERT INTO opac.book (
	                bookCallNumber,
                    bookLanguage,
                    bookLocation,
                    bookTitle,
                    bookOtherTitle, 
                    bookParallelTitle,
                    bookAuthor,
                    bookOtherAuthor,
                    bookEditor,
                    bookCorpauthor,
                    bookPublished,
                    bookPublisher,
                    bookYearPublished,
                    bookPages,
                    bookEdition,
                    bookSeries,
                    bookGeneralNotes,
                    bookISBN,
                    bookOtherDetails
                    ) 
                      VALUES(
                    '" & randomFinal & "',
                    @language,
                    @location,
                    @title,
                    @othertitle,
                    @paralleltitle,
                    @author,
                    @otherauthor,
                    @editor,
                    @corpauthor,
                    @published,
                    @publisher,
                    @yearpublished,
                    @pages,
                    @edition,
                    @series,
                    @generalnotes,
                    @isbn,
                    @otherdetails
                   )"
                dbCommand = New MySqlCommand(dbQuery, dbConn)

                dbCommand.Parameters.AddWithValue("@language", infoOne.languageText.Text)
                dbCommand.Parameters.AddWithValue("@location", infoOne.locationText.Text)

                dbCommand.Parameters.AddWithValue("@title", infoOne.titleText.Text)
                dbCommand.Parameters.AddWithValue("@othertitle", infoTwo.otherTitleText.Text)
                dbCommand.Parameters.AddWithValue("@paralleltitle", infoTwo.parallelTitleText.Text)
                dbCommand.Parameters.AddWithValue("@author", infoTwo.authorText.Text)
                dbCommand.Parameters.AddWithValue("@otherauthor", infoTwo.otherAuthorText.Text)
                dbCommand.Parameters.AddWithValue("@editor", infoTwo.editorText.Text)
                dbCommand.Parameters.AddWithValue("@corpauthor", infoTwo.corpAuthorText.Text)

                dbCommand.Parameters.AddWithValue("@published", infoThree.publishedText.Text)
                dbCommand.Parameters.AddWithValue("@publisher", infoThree.publisherText.Text)
                dbCommand.Parameters.AddWithValue("@yearpublished", infoThree.yearPublishedText.Text)
                dbCommand.Parameters.AddWithValue("@pages", infoThree.pagesText.Text)
                dbCommand.Parameters.AddWithValue("@edition", infoThree.editionText.Text)
                dbCommand.Parameters.AddWithValue("@series", infoThree.seriesText.Text)
                dbCommand.Parameters.AddWithValue("@generalnotes", infoThree.generalNotesText.Text)
                dbCommand.Parameters.AddWithValue("@isbn", infoThree.isbnText.Text)
                dbCommand.Parameters.AddWithValue("@otherdetails", infoThree.otherDetailsText.Text)

                dbCommand.ExecuteNonQuery()


            Next
            inventoryTable.bookNumbers()
            inventoryTable.accessionQuery()
        End If

        customMessageBox.pagePanel(entryTwo)
        entryTwo.addedText.Visible = False

        BunifuTransition1.ShowSync(entryTwo.addedText, True)



        counterText.ResetText()



    End Sub
    Public Function recursiveId() As String
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        Dim randomNumber As New Random
        Dim numberRawRandom As Integer = randomNumber.Next(1, 100000) 'random number from 1 to 99999

        Dim numberString As String = numberRawRandom.ToString("00000")

        Dim randomStore As String = ""

        If addStyleStatus = "existingBook" Then
            randomStore = infoOne.locationText.Text & "-" & numberString 'changes if book exist
        ElseIf addStyleStatus = "newBook" Then
            randomStore = localInformation.callNumber.selectedValue & "-" & numberString
        End If



        conn.Open()
        query = "SELECT * FROM book where bookCallNumber = '" & randomStore & "'"
        Dim command As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            conn.Close()
            Return recursiveId() 'back to this function if id is duplicate in DB to keep generating the ID 
        Else
            conn.Close()
            Return randomStore

        End If
    End Function

    Private Sub counterText_OnValueChanged(sender As Object, e As EventArgs) Handles counterText.OnValueChanged

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click

    End Sub

    Private Sub entryOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class