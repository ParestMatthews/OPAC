Public Class localInformation
    Private Sub localInformationFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        callNumber.CreateGraphics.DrawRectangle(Pens.Blue, callNumber.Left - 1, callNumber.Top - 1, callNumber.Width + 1, callNumber.Height + 1)
        locationText.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs) Handles callNumber.onItemSelected
        locationText.Text = callNumber.selectedValue
    End Sub

    Private Sub BunifuDropdown1_MouseHover(sender As Object, e As EventArgs) Handles callNumber.MouseHover

    End Sub

    Private Sub locationText_OnValueChanged(sender As Object, e As EventArgs) Handles locationText.OnValueChanged

    End Sub
End Class