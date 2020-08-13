Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class inventoryTable
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Public bookTitle As String
    Public bookEdition As String
    Private Sub inventoryTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(searchText, "Search Book by Name, Call Number, or Author")
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
            searchDataTable.DataSource = bindSource
            With searchDataTable
                .Columns(0).HeaderCell.Value = "Book Name"
                .Columns(1).HeaderCell.Value = "Book Edition"
                .Columns(0).Width = Me.Width
                .Columns(1).Width = Me.Width / 4
                .Columns(0).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
                .Columns(1).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
            End With
            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub searchDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataTable.CellContentClick

    End Sub

    Private Sub searchDataTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataTable.CellDoubleClick
        Dim row As DataGridViewRow
        row = Me.searchDataTable.Rows(e.RowIndex)
        bookTitle = row.Cells("bookTitle").Value.ToString
        bookEdition = row.Cells("bookEdition").Value.ToString
        inventoryPanels(inventoryInfo)
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                  *
                 FROM
                   opac.book
                 WHERE 
                   bookTitle = '" & bookTitle & "' AND bookEdition = '" & bookEdition & "'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbReader = dbCommand.ExecuteReader()

            If dbReader.Read() Then
                infoOne.titleText.Text = dbReader("bookTitle")
                infoOne.languageText.Text = dbReader("bookLanguage")
                infoOne.locationText.Text = dbReader("bookLocation")

                infoTwo.otherTitleText.Text = dbReader("bookOtherTitle")
                infoTwo.parallelTitleText.Text = dbReader("bookParallelTitle")
                infoTwo.authorText.Text = dbReader("bookAuthor")
                infoTwo.corpAuthorText.Text = dbReader("bookCorpAuthor")
                infoTwo.otherAuthorText.Text = dbReader("bookOtherAuthor")
                infoTwo.editorText.Text = dbReader("bookEditor")

                infoThree.publishedText.Text = dbReader("bookPublished")
                infoThree.publisherText.Text = dbReader("bookPublisher")
                infoThree.yearPublishedText.Text = dbReader("bookYearPublished")
                infoThree.pagesText.Text = dbReader("bookPages")
                infoThree.editionText.Text = dbReader("bookEdition")
                infoThree.seriesText.Text = dbReader("bookSeries")
                infoThree.generalNotesText.Text = dbReader("bookGeneralNotes")
                infoThree.isbnText.Text = dbReader("bookISBN")
                infoThree.otherDetailsText.Text = dbReader("bookOtherDetails")

            End If
            accessionQuery()
            bookNumbers()
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        Try
            dbConn = dbFunction()
            dbConn.Open()
            dbQuery = "
                 SELECT 
                    MIN(bookTitle)
                 AS
                   bookTitle, 
                   bookEdition
                 FROM
                   opac.book
                 WHERE
                   bookTitle LIKE @title or
                   bookAuthor LIKE @author or
                   bookCallNumber LIKE @callnumber
                 GROUP BY bookTitle, bookEdition
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@title", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@author", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@callnumber", "%" & searchText.Text & "%")
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            searchDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub inventoryPanels(ByVal panel As Form)
        InventoryForm.inventoryPanel.Controls.Clear()
        panel.TopLevel = False
        InventoryForm.inventoryPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Public Function accessionQuery()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT 
                bookCallNumber 
            FROM 
                book
            WHERE
              bookTitle = '" & infoOne.titleText.Text & "' AND bookEdition = '" & infoThree.editionText.Text & "'
            AND bookArchived = 0
            ORDER BY bookCallNumber ASC
            "

        conn.Open()
        Dim command As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader()
        infoOne.ListBox1.Items.Clear()

        While reader.Read()
            infoOne.ListBox1.Items.Add(reader.GetString("bookCallNumber"))
        End While
        conn.Close()
    End Function
    Function bookTotalCount()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT bookCallNumber 
            FROM book
            WHERE bookTitle = '" & infoOne.titleText.Text & "' AND bookEdition = '" & infoThree.editionText.Text & "'
            AND bookArchived = 0
            "
        Dim bookCount As Integer = 0
        conn.Open()
        Dim command As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader()

        While reader.Read()
            bookCount = bookCount + 1
        End While
        conn.Close()
        infoOne.bookCountText.Text = bookCount
        Return bookCount
    End Function
    Function bookOut()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT loan.bookCallNumber, book.bookCallNumber, book.bookTitle, book.bookEdition
            FROM loan
            LEFT JOIN book ON book.bookCallNumber = loan.bookCallNumber
            WHERE bookTitle = '" & infoOne.titleText.Text & "' AND
                  bookEdition = '" & infoThree.editionText.Text & "'
                  AND (loanStatus LIKE '%In-use%')
            "
        Dim bookOutCount As Integer = 0
        conn.Open()
        Dim command As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader()

        While reader.Read()
            bookOutCount = bookOutCount + 1
        End While
        conn.Close()
        infoOne.bookOutText.Text = bookOutCount
        Return bookOutCount
    End Function
    Function bookIn()
        Dim bookInValue As Integer = bookTotalCount() - bookOut()
        infoOne.bookInText.Text = bookInValue
    End Function
    Function bookTotalOut()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT loan.bookCallNumber, book.bookCallNumber, book.bookTitle, book.bookEdition
            FROM loan
            LEFT JOIN book ON book.bookCallNumber = loan.bookCallNumber
            WHERE bookTitle = '" & infoOne.titleText.Text & "' AND
                  bookEdition = '" & infoThree.editionText.Text & "'
                  AND (loanStatus LIKE '%In-use%' OR loanStatus LIKE '%Returned%')
            "
        Dim bookOutCount As Integer = 0
        conn.Open()
        Dim command As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader
        reader = command.ExecuteReader()

        While reader.Read()
            bookOutCount = bookOutCount + 1
        End While
        conn.Close()
        infoOne.timesOutText.Text = bookOutCount
        Return bookOutCount
    End Function
    Function bookNumbers()
        bookTotalCount()
        bookOut()
        bookIn()
        bookTotalOut()
    End Function
End Class
Public Module CueBannerText
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501

    Public Sub SetCueText(ByVal cntrl As Control, ByVal text As String)
        If TypeOf cntrl Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(cntrl.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf cntrl Is TextBox Then
            SendMessage(cntrl.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub

End Module
