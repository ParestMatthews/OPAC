Public Class clientDashboard
    Public userID As String
    Public userName As String

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        If mainPanel.Width = 639 Then
            booksForm.Width = 829
            booksTable.Width = 805
            cardTabDisplayForm.Width = 805
            logForm.Width = 829
            userInfo.Width = 829
        Else
            booksForm.Width = 639
            booksTable.Width = 615
            cardTabDisplayForm.Width = 615
            logForm.Width = 639
            userInfo.Width = 639
        End If

        If (sidebarPanel.Width = 235) Then
            sidebarPanel.Visible = False
            sidebarPanel.Width = 45
            iconBox.Visible = False
            bunifuHi.Visible = False
            bunifuName.Visible = False

            sidebarTransition.Show(sidebarPanel)
        Else
            sidebarPanel.Visible = False
            sidebarPanel.Width = 235
            sidebarTransition.Show(sidebarPanel)
            fadeTransition.Show(iconBox)
            fadeTransition.Show(bunifuHi)
            fadeTransition.Show(bunifuName)
        End If
    End Sub

    Private Sub clientDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bunifuName.Text = userName
        bunifuInventory.selected = True
        showPanel(booksForm)
    End Sub

    Private Sub bunifuInventory_Click(sender As Object, e As EventArgs) Handles bunifuInventory.Click
        showPanel(booksForm)
        booksForm.showPanel(booksTable)
        resetAll()

        If mainPanel.Width = 639 Then
            booksForm.Width = 639
        Else
            booksForm.Width = 829
        End If
    End Sub
    Sub showPanel(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        mainPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub bunifuLogout_Click(sender As Object, e As EventArgs) Handles bunifuLogout.Click
        My.Settings.id = ""
        My.Settings.password = ""
        My.Settings.checked = False
        System.Windows.Forms.Application.Restart()
    End Sub

    Private Sub bunifuBooks_Click(sender As Object, e As EventArgs) Handles bunifuBooks.Click
        showPanel(logForm)
        booksForm.showPanel(booksTable)
        resetAll()

        If mainPanel.Width = 639 Then
            logForm.Width = 639
        Else
            logForm.Width = 829
        End If
    End Sub

    Private Sub bunifuUser_Click(sender As Object, e As EventArgs) Handles bunifuUser.Click
        showPanel(userInfo)
        booksForm.showPanel(booksTable)

        resetAll()

        If mainPanel.Width = 639 Then
            userInfo.Width = 639
        Else
            userInfo.Width = 829
        End If
    End Sub
    Function resetAll()
        cardTabDisplayForm.cardTabReset()
        userInfo.userData()
        userInfo.passwordResetTextBox()
        logForm.resetTable()
        booksForm.bookLimit()
        booksTable.bookTableLoad()
    End Function

    Private Sub bunifuName_Click(sender As Object, e As EventArgs) Handles bunifuName.Click

    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub

    Private Sub sidebarPanel_Paint(sender As Object, e As PaintEventArgs) Handles sidebarPanel.Paint

    End Sub
End Class
