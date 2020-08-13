Public Class customMessageBoxThree
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        deleteOne.deleteError.Text = Nothing
        Me.Close()
    End Sub
    Sub pagePanel(ByVal panel As Form)
        customPanel.Controls.Clear()
        panel.TopLevel = False
        customPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub customMessageBoxThree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagePanel(deleteOne)
    End Sub
End Class