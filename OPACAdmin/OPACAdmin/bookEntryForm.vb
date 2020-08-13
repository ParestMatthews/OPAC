
Public Class bookEntryForm


    Private Sub bookEntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bunifuButtonOne.selected = True
        threePagePanel(localInformation)
    End Sub

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Sub threePagePanel(ByVal panel As Form)
        threePage.Controls.Clear()
        panel.TopLevel = False
        threePage.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub bunifuButtonOne_Click(sender As Object, e As EventArgs) Handles bunifuButtonOne.Click
        threePagePanel(localInformation)
    End Sub

    Private Sub bunifuButtonTwo_Click(sender As Object, e As EventArgs) Handles bunifuButtonTwo.Click
        threePagePanel(titleStatementForm)
    End Sub

    Private Sub bunifuButtonThree_Click(sender As Object, e As EventArgs) Handles bunifuButtonThree.Click
        threePagePanel(pdiForm)

    End Sub

    Private Sub BunifuSeparator1_Load(sender As Object, e As EventArgs) Handles BunifuSeparator1.Load

    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles bunifuAddButton.Click
        entryOne.addStyleStatus = "newBook"
        customMessageBox.Show()

    End Sub

    Private Sub threePage_Paint(sender As Object, e As PaintEventArgs) Handles threePage.Paint

    End Sub
End Class