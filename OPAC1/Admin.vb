Public Class Admin
    Public updateArray() As Integer = {1, 2, 3}
    Public updatePanelStatus As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocalPanel.Hide()
        TitlePanel.Hide()
        PubPanel.Hide()
        btnNext.Hide()
        btnPrev.Hide()


        btnPrev.Enabled = False

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        LocalPanel.Location = New Point(282, 92)
        LocalPanel.Visible = True
        TitlePanel.Visible = False
        PubPanel.Visible = False

        btnNext.Visible = True
        btnPrev.Visible = True
        btnNext.Enabled = True
        btnPrev.Enabled = False

    End Sub
    Private Sub btnUpdate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.MouseHover
        btnUpdate.Image = New Bitmap(My.Resources.update2)
    End Sub
    Private Sub btnClear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.Image = New Bitmap(My.Resources.update1)
    End Sub
    Private Sub btnInventory_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInventory.MouseHover
        btnInventory.Image = New Bitmap(My.Resources.inventory2)
    End Sub
    Private Sub btnInventory_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInventory.MouseLeave
        btnInventory.Image = New Bitmap(My.Resources.inventory1)
    End Sub

    Private Sub title_btn_r_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub pub_btn_l_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub pub_btn_r_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub local_btn_l_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LocalPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If LocalPanel.Visible = True Then
            LocalPanel.Visible = False
            TitlePanel.Location = New Point(282, 92)
            TitlePanel.Visible = True
            btnPrev.Enabled = True
            btnNext.Enabled = True
            PubPanel.Visible = False
        ElseIf TitlePanel.Visible = True Then
            LocalPanel.Visible = False
            TitlePanel.Visible = False
            PubPanel.Location = New Point(282, 92)
            PubPanel.Visible = True
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub PubPanel_Paint(sender As Object, e As PaintEventArgs) Handles PubPanel.Paint

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If PubPanel.Visible = True Then
            LocalPanel.Visible = False
            TitlePanel.Location = New Point(282, 92)
            TitlePanel.Visible = True
            btnPrev.Enabled = True
            btnNext.Enabled = True
            PubPanel.Visible = False
        ElseIf TitlePanel.Visible = True Then
            LocalPanel.Location = New Point(282, 92)
            LocalPanel.Visible = True
            TitlePanel.Visible = False
            PubPanel.Visible = False
            btnNext.Enabled = True
            btnPrev.Enabled = False
        End If
    End Sub
End Class