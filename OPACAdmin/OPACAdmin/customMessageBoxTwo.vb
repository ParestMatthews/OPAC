﻿Public Class customMessageBoxTwo
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    Sub pagePanel(ByVal panel As Form)
        customPanel.Controls.Clear()
        panel.TopLevel = False
        customPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub customMessageBoxTwo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagePanel(returnOne)
    End Sub
End Class