Public Class customMessageBox
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
        listAccession.accessionError.Visible = False
    End Sub

    Private Sub customMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagePanel(listAccession)
    End Sub
    Sub pagePanel(ByVal panel As Form)
        customPanel.Controls.Clear()
        panel.TopLevel = False
        customPanel.Controls.Add(panel)
        panel.Show()
    End Sub
End Class