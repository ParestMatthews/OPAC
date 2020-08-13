Public Class returnOne
    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        returnForm.statusUpdate(returnForm.callNumberShare, returnForm.userIdShare, "Returned", returnForm.costShare)
        customMessageBoxTwo.pagePanel(returnTwo)
        returnTwo.successText.Visible = False
        BunifuTransition1.ShowSync(returnTwo.successText, True)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        customMessageBoxTwo.Close()
    End Sub

    Private Sub overCostText_Click(sender As Object, e As EventArgs) Handles overCostText.Click

    End Sub
End Class