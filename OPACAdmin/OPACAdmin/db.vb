Imports MySql.Data.MySqlClient
Module db
    Dim dbConn As MySqlConnection
    Public Function dbFunction()
        dbConn = New MySqlConnection("Data source=localhost;user id=root;database=opac")
        Return dbConn
    End Function
End Module
