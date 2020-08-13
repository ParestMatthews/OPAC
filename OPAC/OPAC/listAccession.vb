Imports MySql.Data.MySqlClient
Public Class listAccession
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Public checkedAccessionCount As Integer = 0

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        Dim accessionArray As New List(Of String)
        For Each callNumber In CheckedListBox1.CheckedItems
            accessionArray.Add(callNumber.ToString())
            checkedAccessionCount += 1
        Next

        Dim totalCountChecked As Integer = checkedAccessionCount + userLoaned()

        If checkedAccessionCount = 0 Then
            accessionError.Visible = True
            accessionError.Text = "Select the following options"
            checkedAccessionCount = 0
            totalCountChecked = 0

        ElseIf totalCountChecked > 5 Then
            accessionError.Visible = True
            accessionError.Text = "You cannot exceed your loan limit (5)"
            checkedAccessionCount = 0
            totalCountChecked = 0
        Else
            accessionError.Visible = False
            Try

                dbConn = dbFunction()
                dbConn.Open()
                For Each iteration In accessionArray
                    dbQuery = "
                INSERT INTO opac.loan (
	                clientId,
                    bookCallNumber,
                    dateLoaned,
                    loanStatus
                    ) 
                      VALUES(
                    @clientId,
                    @callNumber,
                    @dateLoaned,
                    @loanStatus
                   )"
                    dbCommand = New MySqlCommand(dbQuery, dbConn)
                    Dim callNumber As String = iteration.ToString()
                    dbCommand.Parameters.AddWithValue("@clientId", clientDashboard.userID)
                    dbCommand.Parameters.AddWithValue("@callNumber", callNumber)
                    dbCommand.Parameters.AddWithValue("@dateLoaned", Date.Today)
                    dbCommand.Parameters.AddWithValue("@loanStatus", "Pending")

                    dbCommand.ExecuteNonQuery()
                    updateLoanFlag(callNumber)
                Next
                dbConn.Close()
                accessionArray.Clear()
                booksTable.bookNumbers()
                booksForm.bookLimit()
                customMessageBox.pagePanel(successForm)
                successForm.addedText.Visible = False
                BunifuTransition1.ShowSync(successForm.addedText, True)
                checkedAccessionCount = 0
                totalCountChecked = 0
                logForm.resetTable()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        customMessageBox.Hide()
        accessionError.Visible = False
    End Sub
    Function updateLoanFlag(ByVal bookCallNumber As String)
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            UPDATE book
            SET bookLoaned = @status
            WHERE bookCallNumber = '" & bookCallNumber & "'
            "
        conn.Open()
        dbCommand = New MySqlCommand(query, conn)

        dbCommand.Parameters.AddWithValue("@status", True)
        dbCommand.ExecuteNonQuery()

        conn.Close()

    End Function
    Function userLoaned()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT clientID
            FROM loan
            WHERE clientId = '" & clientDashboard.userID & "' AND (loanStatus LIKE '%In-use%' OR loanStatus LIKE '%Pending%')
            "
        Dim loanedCount As Integer = 0
        conn.Open()
        Dim command As New MySqlCommand(query, conn)

        Dim reader As MySqlDataReader
        reader = command.ExecuteReader()

        While reader.Read()
            loanedCount = loanedCount + 1
        End While
        conn.Close()
        Return loanedCount
    End Function

    Private Sub listAccession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class