
Public Class customMessageBox

    Private Sub customMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagePanel(entryOne)
    End Sub
    Sub pagePanel(ByVal panel As Form)
        customPanel.Controls.Clear()
        panel.TopLevel = False
        customPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
        entryOne.counterText.ResetText()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub customPanel_Paint(sender As Object, e As PaintEventArgs) Handles customPanel.Paint

    End Sub
End Class