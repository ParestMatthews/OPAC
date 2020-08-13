Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class userInfo
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim md5 As New MD5CryptoServiceProvider

    Private Sub userInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userData()

        'textbox objects cant be global reminder
        Dim textboxes As New List(Of Object)({idText, firstNameText, middleNameText, lastNameText, departmentText, yearLevelText, courseText})
        For i As Integer = 0 To textboxes.Count - 1
            textboxes(i).BackColor = Color.WhiteSmoke
        Next

    End Sub
    Public Function userData()

        Dim columns As New List(Of String)({"clientId", "clientFirstName", "clientMiddleName", "clientLastName", "clientYearLevel", "clientDepartment", "clientCourse"})
        Dim textboxes As New List(Of Object)({idText, firstNameText, middleNameText, lastNameText, departmentText, yearLevelText, courseText})
        Dim userId As Integer = clientDashboard.userID
        dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
        dbConn.Open()
        dbQuery = "SELECT * FROM client WHERE clientId = @id"
        dbCommand = New MySqlCommand(dbQuery, dbConn)
        dbCommand.Parameters.AddWithValue("@id", userId)

        dbReader = dbCommand.ExecuteReader


        While dbReader.Read
            For i As Integer = 0 To textboxes.Count - 1
                textboxes(i).text = dbReader.GetString(columns(i))
            Next
        End While
        dbConn.Close()

    End Function

    Private Sub bunifuAddButton_Click(sender As Object, e As EventArgs) Handles bunifuAddButton.Click
        Dim countErrors As New List(Of Integer)
        Dim inputs As New List(Of Object)({bunifuOldPassword, bunifuNewPassword, bunifuConfirmPassword})
        Dim errorText As New List(Of Object)({bunifuError1, bunifuError2, bunifuError3})

        For j As Integer = 0 To errorText.Count - 1
            errorText(j).text = Nothing
            errorText(j).visible = False
            inputs(j).borderColorFocused = Color.DimGray
            inputs(j).borderColorIdle = Color.DimGray
            inputs(j).borderColorMouseHover = Color.DimGray
        Next

        If bunifuOldPassword.Text = Nothing Or bunifuNewPassword.Text = Nothing Or bunifuConfirmPassword.Text = Nothing Then
            For i As Integer = 0 To inputs.Count - 1
                If inputs(i).text = Nothing Then
                    inputs(i).borderColorFocused = Color.Crimson
                    inputs(i).borderColorIdle = Color.Crimson
                    inputs(i).borderColorMouseHover = Color.Crimson
                    Select Case i
                        Case 0
                            errorText(i).text = "Enter your Old Password"
                            errorText(i).visible = True
                        Case 1
                            errorText(i).text = "Enter your New Password"
                            errorText(i).visible = True
                        Case 2
                            errorText(i).text = "Enter your Confirmed Password"
                            errorText(i).visible = True
                    End Select
                    countErrors.Add(i)
                End If
            Next
        End If
        If countErrors.Count = 0 Then
            changePassword()
        End If
    End Sub

    Private Sub bunifuError2_Click(sender As Object, e As EventArgs) Handles bunifuError2.Click

    End Sub

    Private Sub bunifuOldPassword_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuOldPassword.OnValueChanged
        If bunifuOldPassword.Text <> Nothing Then
            bunifuOldPassword.BorderColorFocused = Color.DimGray
            bunifuOldPassword.BorderColorIdle = Color.DimGray
            bunifuOldPassword.BorderColorMouseHover = Color.DimGray
            bunifuError1.Text = Nothing
        End If
    End Sub

    Private Sub bunifuOldPassword_GotFocus(sender As Object, e As EventArgs) Handles bunifuOldPassword.GotFocus

    End Sub

    Private Sub bunifuNewPassword_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuNewPassword.OnValueChanged
        If bunifuNewPassword.Text <> Nothing Then
            bunifuNewPassword.BorderColorFocused = Color.DimGray
            bunifuNewPassword.BorderColorIdle = Color.DimGray
            bunifuNewPassword.BorderColorMouseHover = Color.DimGray
            bunifuError2.Text = Nothing
        End If
        If bunifuConfirmPassword.Text <> Nothing Then
            bunifuConfirmPassword.BorderColorFocused = Color.DimGray
            bunifuConfirmPassword.BorderColorIdle = Color.DimGray
            bunifuConfirmPassword.BorderColorMouseHover = Color.DimGray
            bunifuError3.Text = Nothing
        End If
    End Sub

    Private Sub bunifuConfirmPassword_OnValueChanged(sender As Object, e As EventArgs) Handles bunifuConfirmPassword.OnValueChanged
        If bunifuNewPassword.Text <> Nothing Then
            bunifuNewPassword.BorderColorFocused = Color.DimGray
            bunifuNewPassword.BorderColorIdle = Color.DimGray
            bunifuNewPassword.BorderColorMouseHover = Color.DimGray
            bunifuError2.Text = Nothing
        End If
        If bunifuConfirmPassword.Text <> Nothing Then
            bunifuConfirmPassword.BorderColorFocused = Color.DimGray
            bunifuConfirmPassword.BorderColorIdle = Color.DimGray
            bunifuConfirmPassword.BorderColorMouseHover = Color.DimGray
            bunifuError3.Text = Nothing
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
    Function changePassword()
        Dim countErrors As New List(Of Integer)
        Try
            dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
            dbQuery = "
                     SELECT * FROM opac.client 
                     WHERE clientID = @id AND clientPassword = @password
                      "
            dbConn.Open()
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@id", idText.Text)
            dbCommand.Parameters.AddWithValue("@password", encrypt(bunifuOldPassword.Text, idText.Text))
            dbReader = dbCommand.ExecuteReader

            If dbReader.HasRows <> True Then
                bunifuError1.Text = "Password is Incorrect"
                bunifuError1.Visible = True
                bunifuOldPassword.BorderColorFocused = Color.Crimson
                bunifuOldPassword.BorderColorIdle = Color.Crimson
                bunifuOldPassword.BorderColorMouseHover = Color.Crimson
                countErrors.Add(1)
            End If
            dbConn.Close()
            If bunifuNewPassword.Text <> bunifuConfirmPassword.Text Then
                bunifuError2.Text = "Passwords doesn't match"
                bunifuError2.Visible = True

                Dim inputs As New List(Of Object)({bunifuNewPassword, bunifuConfirmPassword})
                For i As Integer = 0 To inputs.Count - 1
                    inputs(i).BorderColorFocused = Color.Crimson
                    inputs(i).BorderColorIdle = Color.Crimson
                    inputs(i).BorderColorMouseHover = Color.Crimson
                Next
                countErrors.Add(2)
            End If

            If countErrors.Count = 0 Then 'do the change if no errors
                dbConn.Open()
                dbQuery = "
                 UPDATE
                    client
                 SET
                    clientPassword = @password
                 WHERE 
                   clientId = '" & idText.Text & "'
                "
                dbCommand = New MySqlCommand(dbQuery, dbConn)
                dbCommand.Parameters.AddWithValue("@password", encrypt(bunifuConfirmPassword.Text, idText.Text))
                dbCommand.ExecuteNonQuery()
                dbConn.Close()
                If My.Settings.checked = True Then 'VERY IMPORTANT DONT CHANGE
                    My.Settings.password = bunifuConfirmPassword.Text
                    My.Settings.Save()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function passwordResetTextBox()
        Dim inputs As New List(Of Object)({bunifuOldPassword, bunifuNewPassword, bunifuConfirmPassword})
        Dim errorText As New List(Of Object)({bunifuError1, bunifuError2, bunifuError3})

        For j As Integer = 0 To errorText.Count - 1
            errorText(j).text = Nothing
            errorText(j).visible = False
            inputs(j).borderColorFocused = Color.DimGray
            inputs(j).borderColorIdle = Color.DimGray
            inputs(j).borderColorMouseHover = Color.DimGray
            inputs(j).text = Nothing
        Next
    End Function
End Class