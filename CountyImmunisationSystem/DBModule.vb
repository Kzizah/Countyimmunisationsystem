Imports MySql.Data.MySqlClient

Module DBModule
    Public conn As MySqlConnection
    Public Sub Connect()
        Try
            Dim connectionString As String = "server=localhost;port=3306;user id=root;password=;database=countyimmunisationsystem"
            conn = New MySqlConnection(connectionString)
            conn.Open()
        Catch ex As Exception
            MsgBox("Database connection failed: " & ex.Message)
        End Try
    End Sub
End Module
