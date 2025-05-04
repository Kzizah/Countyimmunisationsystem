Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Connect()

        Dim username As String = txtUsername.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        If username = "" Or email = "" Or password = "" Or confirmPassword = "" Then
            MsgBox("All fields are required.")
            Exit Sub
        End If

        If password <> confirmPassword Then
            MsgBox("Passwords do not match.")
            Exit Sub
        End If

        Dim hashedPassword As String = HashPassword(password)

        Try
            Dim cmd As New MySqlCommand("INSERT INTO users (username, email, password) VALUES (@username, @email, @password)", conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", hashedPassword)

            cmd.ExecuteNonQuery()
            MsgBox("Signup successful!")
            Me.Hide()
            LoginForm.Show()
        Catch ex As Exception
            MsgBox("Signup failed: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Hash password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class
