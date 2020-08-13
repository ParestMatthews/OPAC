Imports MySql.Data.MySqlClient
Public Class userTable
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub userTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(searchText, "Search User by Name or ID")
        userDataTable()
    End Sub
    Function userdatatable()
        dbConn = dbFunction()
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                  clientId, CONCAT(clientFirstName,' ',clientLastName), clientYearLevel, clientCourse
                 FROM
                   opac.client
                WHERE clientArchived = 0
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            searchDataTable.DataSource = bindSource
            With searchDataTable
                .Columns(0).HeaderCell.Value = "ID"
                .Columns(1).HeaderCell.Value = "Name"
                .Columns(2).HeaderCell.Value = "Year Level"
                .Columns(3).HeaderCell.Value = "Course"


                .Columns(0).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
                .Columns(1).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
                .Columns(2).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
                .Columns(3).HeaderCell.Style.Font = New Font(searchDataTable.Font, FontStyle.Bold)
            End With
            dbAdapter.Update(dbTable)
            dbConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        Try
            dbConn = dbFunction()
            dbConn.Open()
            dbQuery = "
                 SELECT 
                    clientId, CONCAT(clientFirstName,' ',clientLastName), clientYearLevel, clientCourse
                 FROM
                   opac.client
                 WHERE
                   CONCAT(clientFirstName,' ',clientLastName) LIKE @name or
                   clientId LIKE @id
                "
            Dim dbTable As New DataTable
            Dim dbAdapter As New MySqlDataAdapter
            Dim bindSource As New BindingSource
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbCommand.Parameters.AddWithValue("@name", "%" & searchText.Text & "%")
            dbCommand.Parameters.AddWithValue("@id", "%" & searchText.Text & "%")
            dbAdapter.SelectCommand = dbCommand
            dbAdapter.Fill(dbTable)
            bindSource.DataSource = dbTable
            searchDataTable.DataSource = bindSource

            dbAdapter.Update(dbTable)
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub searchDataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataTable.CellContentClick

    End Sub

    Private Sub searchDataTable_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles searchDataTable.CellDoubleClick
        Dim row As DataGridViewRow
        row = Me.searchDataTable.Rows(e.RowIndex)
        Dim userId As New Integer

        userId = row.Cells("clientId").Value.ToString
        userForm.showPanel(userEdit)
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                  *
                 FROM
                   opac.client
                 WHERE 
                   clientId = '" & userId & "'
                "
            dbCommand = New MySqlCommand(dbQuery, dbConn)
            dbReader = dbCommand.ExecuteReader()
            Dim columns As New List(Of String)({"clientId", "clientFirstName", "clientMiddleName", "clientLastName"})
            Dim columns2 As New List(Of String)({"clientDepartment", "clientYearLevel", "clientCourse"})
            Dim textboxes As New List(Of Object)({userEdit.idText, userEdit.firstNameText, userEdit.middleNameText, userEdit.lastNameText})
            Dim dropdowns As New List(Of Object)({userEdit.departmentText, userEdit.yearLevelText, userEdit.courseText})
            If dbReader.Read() Then
                For i As Integer = 0 To textboxes.Count - 1
                    textboxes(i).text = dbReader.GetString(columns(i))
                Next
                For j As Integer = 0 To dropdowns.Count - 1
                    ' userEdit.departmentText.selectedIndex = dbReader.GetString(columns2(j))
                Next
            End If
            dbConn.Close()
            userEdit.userId = userId 'changes the user ID at userEdit Form with userId clicked on this table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bunifuAdd_Click(sender As Object, e As EventArgs) Handles bunifuAdd.Click
        userForm.showPanel(userAdd)
    End Sub
End Class