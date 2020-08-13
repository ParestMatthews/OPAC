Imports MySql.Data.MySqlClient
Public Class booksForm
    Private Sub booksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showPanel(booksTable)
        bookLimit()
        'showPanel(cardTabDisplayForm)
    End Sub
    Sub showPanel(ByVal panel As Form)
        bookPanel1.Controls.Clear()
        panel.TopLevel = False
        bookPanel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub bookPanel1_Paint(sender As Object, e As PaintEventArgs) Handles bookPanel1.Paint

    End Sub
    Function bookLimit()
        Dim conn As MySqlConnection = dbFunction()
        Dim query As String
        query = "
            SELECT clientId
            FROM loan
            WHERE clientId = '" & clientDashboard.userID & "'  AND (loanStatus LIKE '%In-use%' OR loanStatus LIKE '%Pending%')
            "
        Dim limitCount As Integer = 0
        conn.Open()
        Dim command As New MySqlCommand(query, conn)

        Dim reader As MySqlDataReader
        reader = command.ExecuteReader()

        While reader.Read()
            limitCount = limitCount + 1
        End While
        conn.Close()
        limitText.Text = "Current Loans: " + limitCount.ToString + "/5"
        Return limitCount
    End Function

    Private Sub limitText_Click(sender As Object, e As EventArgs) Handles limitText.Click

    End Sub
End Class