Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class userAdd
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Dim des As New TripleDESCryptoServiceProvider
    Dim md5 As New MD5CryptoServiceProvider
    Private Sub userAccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dept As New List(Of String)({"", "CEA", "CCS", "CBA", "CHM", "CCRIM", "Senior High School"})

        For i As Integer = 0 To dept.Count - 1
            departmentText.AddItem(dept(i))
        Next
    End Sub

    Private Sub BunifuCustomLabel7_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel7.Click

    End Sub

    Private Sub bunifuAddButton_Click(sender As Object, e As EventArgs) Handles bunifuAddButton.Click
        'verify textboxes
        Dim countErrors As New List(Of Integer)
        Dim inputs As New List(Of Object)({idText, firstNameText, passwordText, lastNameText})
        Dim errorText As New List(Of Object)({bunifuErrorOne, bunifuErrorTwo, bunifuErrorThree, bunifuErrorFive})

        For j As Integer = 0 To errorText.Count - 1
            errorText(j).text = Nothing
            errorText(j).visible = False
            inputs(j).borderColorFocused = Color.DimGray
            inputs(j).borderColorIdle = Color.DimGray
            inputs(j).borderColorMouseHover = Color.DimGray
        Next

        If idText.Text = Nothing Or firstNameText.Text = Nothing Or passwordText.Text = Nothing Or lastNameText.Text = Nothing Then
            For i As Integer = 0 To inputs.Count - 1
                If inputs(i).text = Nothing Then
                    inputs(i).borderColorFocused = Color.Crimson
                    inputs(i).borderColorIdle = Color.Crimson
                    inputs(i).borderColorMouseHover = Color.Crimson
                    Select Case i
                        Case 0
                            errorText(i).text = "Enter your ID"
                            errorText(i).visible = True
                        Case 1
                            errorText(i).text = "Enter your Password"
                            errorText(i).visible = True
                        Case 2
                            errorText(i).text = "Enter your First Name"
                            errorText(i).visible = True
                        Case 3
                            errorText(i).text = "Enter your Last Name"
                            errorText(i).visible = True
                    End Select
                    countErrors.Add(i)
                End If
            Next
        End If

        'verify dropdowns
        Dim inputsTwo As New List(Of Object)({departmentText, courseText, yearLevelText})
        Dim panelBorders As New List(Of Object)({Panel1, Panel2, Panel3})
        Dim errorTextTwo As New List(Of Object)({bunifuErrorSix, bunifuErrorSeven, bunifuErrorEight})

        For j As Integer = 0 To errorTextTwo.Count - 1
            errorTextTwo(j).text = Nothing
            errorTextTwo(j).visible = False
            panelBorders(j).backcolor = Color.DimGray
        Next

        'stupid vb logic 
        If Me.departmentText.selectedIndex = 0 Or Me.courseText.selectedIndex = 0 Or Me.yearLevelText.selectedIndex = 0 Or Me.departmentText.selectedIndex = -1 Or Me.courseText.selectedIndex = -1 Or Me.yearLevelText.selectedIndex = -1 Then
            For i As Integer = 0 To inputsTwo.Count - 1
                If inputsTwo(i).selectedindex = 0 Or inputsTwo(i).selectedindex = -1 Then
                    panelBorders(i).backcolor = Color.Crimson
                    Select Case i
                        Case 0
                            errorTextTwo(i).text = "Enter your Department"
                            errorTextTwo(i).visible = True
                        Case 1
                            errorTextTwo(i).text = "Enter your Course"
                            errorTextTwo(i).visible = True
                        Case 2
                            errorTextTwo(i).text = "Enter your Year Level"
                            errorTextTwo(i).visible = True
                    End Select
                    countErrors.Add(i)
                End If
            Next
        End If

        If countErrors.Count = 0 Then
            checkForId()

        End If



    End Sub
    Function checkForId()
        dbConn = dbFunction()
        dbConn.Open()
        dbQuery = "SELECT * FROM client where clientId = '" & idText.Text & "'"
        Dim command As New MySqlCommand(dbQuery, dbConn)
        Dim reader As MySqlDataReader = command.ExecuteReader()
        If reader.HasRows Then


            dbConn.Close()

            idText.BorderColorFocused = Color.Crimson
            idText.BorderColorIdle = Color.Crimson
            idText.BorderColorMouseHover = Color.Crimson

            bunifuErrorOne.Text = "ID already exist"
            bunifuErrorOne.Visible = True
        Else
            dbConn.Close()
            addUser()

        End If
    End Function
    Function addUser()
        Try

            dbConn = dbFunction()
            dbQuery = "
                Insert into opac.client (
	                clientId,
                    clientFirstName,
                    clientLastName,
                    clientYearLevel,
                    clientDepartment,
                    clientMiddleName,
                    clientCourse,
                    clientPassword
                    ) 
                        values(
                    @id,    
                    @firstName,
                    @lastName,
                    @yearLevel,
                    @department,
                    @middleName,
                    @course,
                    @password
                   )"
            dbConn.Open()
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@id", idText.Text)
            dbCommand.Parameters.AddWithValue("@firstName", firstNameText.Text)
            dbCommand.Parameters.AddWithValue("@lastName", lastNameText.Text)
            dbCommand.Parameters.AddWithValue("@yearLevel", yearLevelText.selectedValue)
            dbCommand.Parameters.AddWithValue("@department", departmentText.selectedValue)
            dbCommand.Parameters.AddWithValue("@middleName", middleNameText.Text)
            dbCommand.Parameters.AddWithValue("@course", courseText.selectedValue)
            dbCommand.Parameters.AddWithValue("@password", encrypt(passwordText.Text, idText.Text))

            dbCommand.ExecuteNonQuery()

            MsgBox("Added!", MsgBoxStyle.Information) 'try to modify

            idText.Text = Nothing
            firstNameText.ResetText()
            lastNameText.ResetText()
            yearLevelText.Clear()
            departmentText.selectedIndex = 0

            middleNameText.ResetText()
            courseText.Clear()
            passwordText.ResetText()
            userTable.userdatatable()
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Function md5Hash(ByVal input As String) As Byte()
        Return md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input))
    End Function
    Function encrypt(ByVal encryptString As String, ByVal key As String) As String
        des.Key = md5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(encryptString)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

    Private Sub bunifuReturn_Click(sender As Object, e As EventArgs) Handles bunifuReturn.Click
        userForm.showPanel(userTable)
    End Sub

    Private Sub departmentText_onItemSelected(sender As Object, e As EventArgs) Handles departmentText.onItemSelected
        Dim fiveYears As New List(Of String)({"", "1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year"})
        Dim fourYears As New List(Of String)({"", "1st Year", "2nd Year", "3rd Year", "4th Year"})
        Dim shsYears As New List(Of String)({"", "11th Grade", "12th Grade"})
        courseText.Clear()
        yearLevelText.Clear()
        If Me.departmentText.selectedValue = "CEA" Then

            Dim course As New List(Of String)({"", "BSCpE", "BSECE", "BSIE", "BSEE", "BS Architecture"})

            For i As Integer = 0 To course.Count - 1
                courseText.AddItem(course(i))
            Next
            For i As Integer = 0 To fiveYears.Count - 1
                yearLevelText.AddItem(fiveYears(i))
            Next
        ElseIf Me.departmentText.selectedValue = "CCS" Then
            Dim course As New List(Of String)({"", "BSIT"})

            For i As Integer = 0 To course.Count - 1
                courseText.AddItem(course(i))
            Next
            For i As Integer = 0 To fourYears.Count - 1
                yearLevelText.AddItem(fourYears(i))
            Next
        ElseIf Me.departmentText.selectedValue = "CBA" Then
            Dim course As New List(Of String)({"", "BSBA", "BSA"})

            For i As Integer = 0 To course.Count - 1
                courseText.AddItem(course(i))
            Next
            For i As Integer = 0 To fourYears.Count - 1
                yearLevelText.AddItem(fourYears(i))
            Next
        ElseIf Me.departmentText.selectedValue = "CHM" Then
            Dim course As New List(Of String)({"", "BSHRM", "BSTRM"})

            For i As Integer = 0 To course.Count - 1
                courseText.AddItem(course(i))
            Next
            For i As Integer = 0 To fourYears.Count - 1
                yearLevelText.AddItem(fourYears(i))
            Next
        ElseIf Me.departmentText.selectedValue = "CCRIM" Then
            Dim course As New List(Of String)({"", "BSCRIM", "BSPSY"})

            For i As Integer = 0 To course.Count - 1
                courseText.AddItem(course(i))
            Next
            For i As Integer = 0 To fourYears.Count - 1
                yearLevelText.AddItem(fourYears(i))
            Next
        ElseIf Me.departmentText.selectedValue = "Senior High School" Then
            Dim course As New List(Of String)({"", "GAS", "ABM", "STEM"})

            For i As Integer = 0 To course.Count - 1
                courseText.AddItem(course(i))
            Next
            For i As Integer = 0 To shsYears.Count - 1
                yearLevelText.AddItem(shsYears(i))
            Next
        End If

        If Me.departmentText.selectedIndex <> 0 Then
            Panel1.BackColor = Color.DimGray
            bunifuErrorSix.Text = Nothing
        End If
    End Sub

    Private Sub idText_OnValueChanged(sender As Object, e As EventArgs) Handles idText.OnValueChanged
        If Me.idText.Text <> Nothing Then
            Me.idText.BorderColorFocused = Color.DimGray
            Me.idText.BorderColorIdle = Color.DimGray
            Me.idText.BorderColorMouseHover = Color.DimGray
            bunifuErrorOne.Text = Nothing
        End If
    End Sub

    Private Sub passwordText_OnValueChanged(sender As Object, e As EventArgs) Handles passwordText.OnValueChanged
        If Me.passwordText.Text <> Nothing Then
            Me.passwordText.BorderColorFocused = Color.DimGray
            Me.passwordText.BorderColorIdle = Color.DimGray
            Me.passwordText.BorderColorMouseHover = Color.DimGray
            bunifuErrorTwo.Text = Nothing
        End If
    End Sub

    Private Sub firstNameText_OnValueChanged(sender As Object, e As EventArgs) Handles firstNameText.OnValueChanged
        If Me.firstNameText.Text <> Nothing Then
            Me.firstNameText.BorderColorFocused = Color.DimGray
            Me.firstNameText.BorderColorIdle = Color.DimGray
            Me.firstNameText.BorderColorMouseHover = Color.DimGray
            bunifuErrorThree.Text = Nothing
        End If
    End Sub

    Private Sub middleNameText_OnValueChanged(sender As Object, e As EventArgs) Handles middleNameText.OnValueChanged

    End Sub

    Private Sub lastNameText_OnValueChanged(sender As Object, e As EventArgs) Handles lastNameText.OnValueChanged
        If Me.lastNameText.Text <> Nothing Then
            Me.lastNameText.BorderColorFocused = Color.DimGray
            Me.lastNameText.BorderColorIdle = Color.DimGray
            Me.lastNameText.BorderColorMouseHover = Color.DimGray
            bunifuErrorFive.Text = Nothing
        End If
    End Sub

    Private Sub courseText_onItemSelected(sender As Object, e As EventArgs) Handles courseText.onItemSelected
        If Me.courseText.selectedIndex <> 0 Then
            Panel2.BackColor = Color.DimGray
            bunifuErrorSeven.Text = Nothing
        End If
    End Sub

    Private Sub yearLevelText_onItemSelected(sender As Object, e As EventArgs) Handles yearLevelText.onItemSelected
        If Me.yearLevelText.selectedIndex <> 0 Then
            Panel3.BackColor = Color.DimGray
            bunifuErrorEight.Text = Nothing
        End If
    End Sub
End Class