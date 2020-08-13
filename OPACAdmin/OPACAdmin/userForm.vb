Public Class userForm
    Private Sub userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showPanel(userTable)
    End Sub
    Sub showPanel(ByVal panel As Form)
        userPanel.Controls.Clear()
        panel.TopLevel = False
        userPanel.Controls.Add(panel)
        panel.Show()
    End Sub
End Class