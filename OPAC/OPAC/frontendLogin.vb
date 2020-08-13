Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class frontendLogin
    Dim dbQuery As String

    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim md5 As New MD5CryptoServiceProvider
    Dim dbConn As MySqlConnection
    Dim archiveStatus As String
    Dim username As String
    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.Click
        If bunifuRemember.Checked = False Then
            bunifuRemember.Checked = True
        Else
            bunifuRemember.Checked = False
        End If
    End Sub

    Private Sub bunifuPassword_OnValueChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub

    Private Sub bunifuLoginBtn_Click(sender As Object, e As EventArgs) Handles bunifuLoginBtn.Click
        loginErrorText.Visible = False
        loginErrorText.Text = Nothing
        Dim countErrors As New List(Of Integer)
        If bunifuId.Text = Nothing Or bunifuPassword.Text = Nothing Then
            Dim inputs As New List(Of Object)({bunifuId, bunifuPassword})
            Dim errorText As New List(Of Object)({bunifuError1, bunifuError2})


            For i As Integer = 0 To inputs.Count - 1
                If inputs(i).text = Nothing Then
                    inputs(i).LineIdleColor = Color.Crimson
                    inputs(i).LinefocusedColor = Color.Crimson
                    inputs(i).LineMouseHoverColor = Color.Crimson
                    Select Case i
                        Case 0
                            errorText(i).text = "Enter your ID"
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

    Private Sub bunifuPassword_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub bunifuPassword_MouseDown(sender As Object, e As MouseEventArgs)

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
    Function login()
        Try
            dbConn = dbFunction()
            dbQuery = "
                     SELECT * FROM opac.client 
                     WHERE clientID = @id AND clientPassword = @password
                      "
            dbConn.Open()
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@id", bunifuId.Text)
            dbCommand.Parameters.AddWithValue("@password", encrypt(bunifuPassword.Text, bunifuId.Text))
            dbReader = dbCommand.ExecuteReader
            While dbReader.Read
                archiveStatus = dbReader.GetString("clientArchived")
                username = dbReader.GetString("clientFirstName")
            End While

            If archiveStatus = 1 Then
                loginErrorText.Visible = True
                loginErrorText.Text = "Your account has been deleted"

            ElseIf dbReader.HasRows Then
                If bunifuRemember.Checked = True Then
                    My.Settings.id = bunifuId.Text
                    My.Settings.password = bunifuPassword.Text
                    My.Settings.checked = True
                    My.Settings.Save()
                Else
                    My.Settings.id = ""
                    My.Settings.password = ""
                    My.Settings.checked = False
                    My.Settings.Save()
                End If
                Me.Hide()
                clientDashboard.userID = bunifuId.Text

                clientDashboard.userName = username

                clientDashboard.Show()

            Else
                loginErrorText.Visible = True
                loginErrorText.Text = "The ID or Password you entered is incorrect"
            End If


                dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub frontendLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.checked = True Then 'session of user
            bunifuId.Text = My.Settings.id
            bunifuPassword.Text = My.Settings.password
            bunifuRemember.Checked = True
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            login()
        Else
            bunifuId.Text = ""
            bunifuPassword.Text = ""
            bunifuRemember.Checked = False
        End If
    End Sub




    Private Sub bunifuId_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuId.OnValueChanged
        If bunifuId.Text <> Nothing Then
            bunifuId.LineIdleColor = Color.Black
            bunifuId.LineFocusedColor = Color.Black
            bunifuId.LineMouseHoverColor = Color.Black
            bunifuError1.Text = Nothing
        End If
    End Sub

    Private Sub bunifuPassword_OnValueChanged_1(sender As Object, e As EventArgs) Handles bunifuPassword.OnValueChanged
        If bunifuPassword.Text <> Nothing Then
            bunifuPassword.LineIdleColor = Color.Black
            bunifuPassword.LineFocusedColor = Color.Black
            bunifuPassword.LineMouseHoverColor = Color.Black
            bunifuError2.Text = Nothing
        End If
    End Sub

    Private Sub bunifuPassword_Enter(sender As Object, e As EventArgs) Handles bunifuPassword.Enter
        If (bunifuPassword.Text IsNot Nothing) Then
            bunifuPassword.isPassword = True
        End If
    End Sub
End Class