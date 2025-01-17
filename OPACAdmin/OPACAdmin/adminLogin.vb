﻿Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class adminLogin
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim md5 As New MD5CryptoServiceProvider
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.checked = True Then 'session of user
            bunifuUsername.Text = My.Settings.username
            bunifuPassword.Text = My.Settings.password
            bunifuPassword.isPassword = True
            bunifuRemember.Checked = True
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            login()
        Else
            bunifuUsername.Text = ""
            bunifuPassword.Text = ""
            bunifuRemember.Checked = False
        End If
    End Sub
    Function md5Hash(ByVal input As String) As Byte()
        Return md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input))
    End Function
    Function encrypt(ByVal encryptString As String, ByVal key As String) As String
        des.Key = md5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(encryptString)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

    Private Sub bunifuUser_OnValueChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuPassword.OnValueChanged
        If bunifuPassword.Text <> Nothing Then
            bunifuPassword.LineIdleColor = Color.Black
            bunifuPassword.LineFocusedColor = Color.Black
            bunifuPassword.LineMouseHoverColor = Color.Black
            bunifuErrorTwo.Text = Nothing
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_Enter(sender As Object, e As EventArgs) Handles bunifuPassword.Enter
        If (bunifuPassword.Text IsNot Nothing) Then
            bunifuPassword.isPassword = True
        End If
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTitlePage_Click(sender As Object, e As EventArgs) Handles BunifuTitlePage.Click

    End Sub

    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.Click
        If bunifuRemember.Checked = False Then
            bunifuRemember.Checked = True
        Else
            bunifuRemember.Checked = False
        End If

    End Sub

    Private Sub bunifuRemember_OnChange(sender As Object, e As EventArgs) Handles bunifuRemember.OnChange

    End Sub

    Private Sub bunifuLoginBtn_Click(sender As Object, e As EventArgs) Handles bunifuLoginBtn.Click
        loginErrorText.Visible = False
        loginErrorText.Text = Nothing
        Dim countErrors As New List(Of Integer)
        If bunifuUsername.Text = Nothing Or bunifuPassword.Text = Nothing Then
            Dim inputs As New List(Of Object)({bunifuUsername, bunifuPassword})
            Dim errorText As New List(Of Object)({bunifuErrorOne, bunifuErrorTwo})


            For i As Integer = 0 To inputs.Count - 1
                If inputs(i).text = Nothing Then
                    inputs(i).LineIdleColor = Color.Crimson
                    inputs(i).LinefocusedColor = Color.Crimson
                    inputs(i).LineMouseHoverColor = Color.Crimson
                    Select Case i
                        Case 0
                            errorText(i).text = "Enter your Username"
                            errorText(i).visible = True
                        Case 1
                            errorText(i).text = "Enter your Password"
                            errorText(i).visible = True
                    End Select
                    countErrors.Add(i)
                End If
            Next
        End If
        If countErrors.Count = 0 Then
            login()
        End If

    End Sub
    Function login()

        Try
            dbConn = dbFunction()
            dbQuery = "
                     SELECT * FROM opac.admintable 
                     WHERE adminName = @username AND adminPassword = @password
                      "
            dbConn.Open()
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@username", bunifuUsername.Text)
            dbCommand.Parameters.AddWithValue("@password", encrypt(bunifuPassword.Text, "randomtextlmao"))
            dbReader = dbCommand.ExecuteReader

            If dbReader.HasRows Then
                If bunifuRemember.Checked = True Then
                    My.Settings.username = bunifuUsername.Text
                    My.Settings.password = bunifuPassword.Text
                    My.Settings.checked = True
                    My.Settings.Save()
                Else
                    My.Settings.username = ""
                    My.Settings.password = ""
                    My.Settings.checked = False
                    My.Settings.Save()
                End If
                Me.Hide()

                adminDashboard.Show()

            Else
                loginErrorText.Visible = True
                loginErrorText.Text = "The Username or Password you entered is incorrect"
            End If
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub bunifuUsername_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuUsername.OnValueChanged
        If bunifuUsername.Text <> Nothing Then
            bunifuUsername.LineIdleColor = Color.Black
            bunifuUsername.LineFocusedColor = Color.Black
            bunifuUsername.LineMouseHoverColor = Color.Black
            bunifuErrorOne.Text = Nothing
        End If
    End Sub
End Class

