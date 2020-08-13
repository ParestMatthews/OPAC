Imports MySql.Data.MySqlClient
Public Class deleteOne
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Public checkedDeleteCount As Integer = 0
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        deleteError.Text = Nothing
        customMessageBoxThree.Close()
    End Sub

    Private Sub deleteOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        Dim deleteArray As New List(Of String)
        Dim trimedArray As New List(Of String)
        For Each callNumber In CheckedListBox1.CheckedItems
            deleteArray.Add(callNumber.ToString())
            'trims each element in array to get "(Out/Pending)"
            trimedArray.Add(callNumber.ToString.Substring(Math.Max(0, callNumber.ToString.Length - 13)))
            checkedDeleteCount += 1
        Next

        If checkedDeleteCount = 0 Then
            deleteError.Visible = True
            deleteError.Text = "Select the following options"
            checkedDeleteCount = 0
        ElseIf trimedArray.Contains("(Out/Pending)") Then
            deleteError.Visible = True
            deleteError.Text = "Book(s) still in used"
            checkedDeleteCount = 0
        Else
            deleteError.Visible = False
            checkedDeleteCount = 0
            Try
                dbConn = dbFunction()
                dbConn.Open()

                For i As Integer = 0 To deleteArray.Count - 1 'for some reason it doesnt query the "Select All" element
                    dbQuery = "
                 UPDATE
                    book
                 SET
                    bookArchived = @status
                 WHERE 
                   bookCallNumber = '" & deleteArray(i).ToString & "'
                "
                    dbCommand = New MySqlCommand(dbQuery, dbConn)
                    dbCommand.Parameters.AddWithValue("@status", True)
                    dbCommand.ExecuteNonQuery()
                Next
                dbConn.Close()
                inventoryTable.bookNumbers()
                inventoryTable.accessionQuery()
                customMessageBoxThree.pagePanel(deleteTwo)
                deleteTwo.deletedText.Visible = False
                BunifuTransition1.ShowSync(deleteTwo.deletedText, True)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        If e.Index = 0 Then
            Dim newCheckedState As CheckState = e.NewValue
            For idx As Integer = 1 To CheckedListBox1.Items.Count - 1
                Me.CheckedListBox1.SetItemCheckState(idx, newCheckedState)
            Next
        End If
    End Sub
End Class