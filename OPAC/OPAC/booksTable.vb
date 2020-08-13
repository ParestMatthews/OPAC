Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class booksTable
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Public bookTitle As String
    Public bookEdition As String
    Private Sub searchDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataTable.CellContentClick

    End Sub

    Private Sub searchDataTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataTable.CellDoubleClick
        Dim row As DataGridViewRow
        row = Me.searchDataTable.Rows(e.RowIndex)
        bookTitle = row.Cells("bookTitle").Value.ToString
        bookEdition = row.Cells("bookEdition").Value.ToString

        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                  *
                 FROM
                   opac.book
                 WHERE 
                   bookTitle = '" & bookTitle & "' AND
                   bookEdition = '" & bookEdition & "'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbReader = dbCommand.ExecuteReader()

            If dbReader.Read() Then
                Dim location As String = dbReader("bookLocation")
                Dim author As String = dbReader("bookAuthor")
                Dim title As String = dbReader("bookTitle")
                Dim published As String = dbReader("bookPublished")
                Dim publisher As String = dbReader("bookPublisher")
                Dim publishYear As String = dbReader("bookYearPublished")
                Dim pages As String = dbReader("bookPages")
                Dim isbn As String = dbReader("bookISBN")

                cardDisplay.locationText.Text = location
                cardDisplay.authorText.Text = author
                cardDisplay.publishText.Text = title + " - " + published + ": " + publisher + ", " + publishYear
                cardDisplay.pagesText.Text = pages
                cardDisplay.isbnText.Text = isbn
                bookNumbers()
                cardDisplay.locationLabel.Text = "Location: " + location
                tabDisplayTable(bookTitle, bookEdition)
            End If
            dbConn.Close()
            bookPanels(cardTabDisplayForm)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub booksTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(searchText, "Search Book by Name, Call Number, or Author")
        bookTableLoad()
    End Sub
    Function bookTableLoad()
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
    End Function
    Private Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        Try
            dbConn = dbFunction()
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   bookTitle
                 FROM
                   opac.book
                 WHERE
                   bookTitle LIKE @title or
                   bookAuthor LIKE @author or
                   bookCallNumber LIKE @callnumber
                 GROUP BY bookTitle
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
    Sub bookPanels(ByVal panel As Form)
        booksForm.bookPanel1.Controls.Clear()
        panel.TopLevel = False
        booksForm.bookPanel1.Controls.Add(panel)
        panel.Show()
    End Sub
    Function bookTotalCount()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT bookCallNumber 
            FROM book
            WHERE bookTitle = '" & bookTitle & "' AND
                  bookEdition = '" & bookEdition & "'
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
        cardDisplay.copiesLabel.Text = "Book Copies: " + bookCount.ToString()
        Return bookCount 'might need the value
    End Function
    Function bookOut()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT loan.bookCallNumber, book.bookCallNumber, book.bookTitle, book.bookEdition
            FROM loan
            LEFT JOIN book ON book.bookCallNumber = loan.bookCallNumber
            WHERE bookTitle = '" & bookTitle & "' AND
                  bookEdition = '" & bookEdition & "'
                  AND (loanStatus LIKE '%In-use%' OR loanStatus LIKE '%Pending%')
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
        cardDisplay.outLabel.Text = "Out: " + bookOutCount.ToString()
        Return bookOutCount
    End Function
    Function bookIn()
        Dim bookInValue As Integer = bookTotalCount() - bookOut()
        cardDisplay.inLabel.Text = "In: " + bookInValue.ToString
    End Function
    Function bookNumbers()
        bookTotalCount()
        bookOut()
        bookIn()
    End Function
    Function tabDisplayTable(ByVal bookNameArgs As String, ByVal bookEditionArgs As String)
        tabDisplay.tabDisplayTable.Rows.Clear()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                   *
                 FROM
                   book
                 WHERE 
                   bookTitle = '" & bookNameArgs & "' 
                 AND 
                   bookEdition = '" & bookEditionArgs & "'
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable

            Dim rowFields As New List(Of String)({"Title", "Author", "Location", "Published", "ISBN", "Edition", "Language", "Other Title", "Parallel Title", "Other Author", "Editor", "Corp. Author", "Publisher", "Year Published", "Pages", "Series", "General Notes", "Other Details"})
            Dim rowCellCount As Integer = 1

            For Each i As String In rowFields
                Dim value As String = dbTable.Rows(0).Item(rowCellCount).ToString()
                If value = Nothing Then
                    rowCellCount += 1
                    'Does nothing but count
                Else
                    tabDisplay.tabDisplayTable.Rows.Add({i, value})
                    rowCellCount += 1
                End If
            Next

            With tabDisplay.tabDisplayTable
                .Columns(0).Width = Me.Width / 4
                .Columns(0).DefaultCellStyle.Font = New Font(tabDisplay.tabDisplayTable.Font, FontStyle.Bold)
                .Columns(0).HeaderCell.Style.Font = New Font(tabDisplay.tabDisplayTable.Font, FontStyle.Bold)
                .Columns(1).HeaderCell.Style.Font = New Font(tabDisplay.tabDisplayTable.Font, FontStyle.Bold)
            End With
            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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