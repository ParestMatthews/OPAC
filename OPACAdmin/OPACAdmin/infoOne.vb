Imports MySql.Data.MySqlClient
Public Class infoOne
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub infoOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If titleText.Enabled = False Then
            titleText.BackColor = Color.WhiteSmoke
        Else
            titleText.BackColor = Color.White
        End If

    End Sub

    Private Sub titleText_OnValueChanged(sender As Object, e As EventArgs) Handles titleText.OnValueChanged

    End Sub

    Private Sub titleText_Load(sender As Object, e As EventArgs) Handles titleText.Load

    End Sub

    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs) Handles bookCountText.Click

    End Sub

    Private Sub BunifuCustomLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel1_Click_1(sender As Object, e As EventArgs) Handles bookInText.Click

    End Sub

    Private Sub BunifuCustomLabel10_Click_1(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.Click

    End Sub
End Class