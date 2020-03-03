Imports MySql.Data.MySqlClient
Public Class Loan
    Dim dbQuery As String
    Dim dbConn As MySqlConnection
    Dim dbCommand As MySqlCommand
    Dim dbReader As MySqlDataReader
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
        Try
            dbConn.Open()
            dbQuery = "
                 SELECT 
                "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class