Public Class Home
    Private Sub btn_srchTitle_Click(sender As Object, e As EventArgs) Handles btn_srchTitle.Click






        combotype.Hide()
        comboauthor.Hide()
        combobook.Show()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Show()
        combobook.Hide()
        combotype.Hide()
        comboauthor.Hide()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ams_Click(sender As Object, e As EventArgs) Handles ams.Click

    End Sub

    Private Sub lsb_Click(sender As Object, e As EventArgs) Handles lsb.Click

    End Sub

    Private Sub piclsb_Click(sender As Object, e As EventArgs) Handles piclsb.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
    Private Sub btnDelete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.MouseHover
        btnDelete.Image = New Bitmap(My.Resources.delete2)
    End Sub
    Private Sub btnDelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.MouseLeave
        btnDelete.Image = New Bitmap(My.Resources.delete1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

    End Sub
    Private Sub btnVerify_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerify.MouseHover
        btnVerify.Image = New Bitmap(My.Resources.verify2)
    End Sub
    Private Sub btnVerify_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVerify.MouseLeave
        btnVerify.Image = New Bitmap(My.Resources.verify1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
    Private Sub btnSave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseHover
        btnSave.Image = New Bitmap(My.Resources.save2)
    End Sub
    Private Sub btnSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.MouseLeave
        btnSave.Image = New Bitmap(My.Resources.save1)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub
    Private Sub btnClose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseHover
        btnClose.Image = New Bitmap(My.Resources.close2)
    End Sub
    Private Sub btnClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        btnClose.Image = New Bitmap(My.Resources.close1)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
    Private Sub btnPrint_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.MouseHover
        btnPrint.Image = New Bitmap(My.Resources.print2)
    End Sub
    Private Sub btnPrint_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.MouseLeave
        btnPrint.Image = New Bitmap(My.Resources.print1)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
    Private Sub btnClear_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.MouseHover
        btnClear.Image = New Bitmap(My.Resources.clear2)
    End Sub
    Private Sub btnClear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.MouseLeave
        btnClear.Image = New Bitmap(My.Resources.clear1)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btn_srchType_Click(sender As Object, e As EventArgs) Handles btn_srchType.Click
        combobook.Hide()
        comboauthor.Hide()
        combotype.Show()

    End Sub

    Private Sub btn_srchAuthor_Click(sender As Object, e As EventArgs) Handles btn_srchAuthor.Click
        combobook.Hide()
        combotype.Hide()
        comboauthor.Show()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
