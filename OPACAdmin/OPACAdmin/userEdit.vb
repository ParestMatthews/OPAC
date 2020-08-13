Imports MySql.Data.MySqlClient
Public Class userEdit
    Public userId As Integer 'from userTable form
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub editUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'departments
        Dim dept As New List(Of String)({"", "CEA", "CCS", "CBA", "CHM", "CCRIM", "Senior High School"})

        For i As Integer = 0 To dept.Count - 1
            departmentText.AddItem(dept(i))
        Next
    End Sub

    Private Sub bunifuReturn_Click(sender As Object, e As EventArgs) Handles bunifuReturn.Click
        userForm.showPanel(userTable)

    End Sub

    Private Sub bunifuEditButton_Click(sender As Object, e As EventArgs) Handles bunifuEditButton.Click
        userUpdate()
    End Sub
    Function userUpdate()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 UPDATE
                    client
                 SET
                    clientFirstName = @fname,
                    clientLastName = @lname,
                    clientYearLevel = @year,
                    clientDepartment = @department,
                    clientMiddleName = @mname,
                    clientCourse = @course
                 WHERE 
                   clientId = '" & userId & "'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@fname", firstNameText.Text)
            dbCommand.Parameters.AddWithValue("@lname", lastNameText.Text)
            dbCommand.Parameters.AddWithValue("@year", courseText.selectedValue)
            dbCommand.Parameters.AddWithValue("@department", departmentText.selectedValue)
            dbCommand.Parameters.AddWithValue("@mname", middleNameText.Text)
            dbCommand.Parameters.AddWithValue("@course", courseText.selectedValue)

            dbCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub bunifuEditButton_Click_1(sender As Object, e As EventArgs) Handles bunifuEditButton.Click
        userTable.userdatatable()
    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs) Handles departmentText.onItemSelected

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

    Private Sub deleteUser_Click(sender As Object, e As EventArgs) Handles deleteUser.Click
        Try
            dbConn = dbFunction()
            dbConn.Open()


            dbQuery = "
                 UPDATE
                    client
                 SET
                    clientArchived = 1
                 WHERE 
                   clientId = '" & userId & "'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.ExecuteNonQuery()

            dbConn.Close()
            userTable.userdatatable()
            userForm.showPanel(userTable)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class