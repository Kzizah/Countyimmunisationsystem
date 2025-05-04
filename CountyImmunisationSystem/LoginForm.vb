Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Connect()

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MsgBox("Please enter both username and password.")
            Exit Sub
        End If

        Dim hashedPassword As String = HashPassword(password)

        Try
            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE username=@u AND password=@p", conn)
            cmd.Parameters.AddWithValue("@u", username)
            cmd.Parameters.AddWithValue("@p", hashedPassword)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Login successful!")
                Me.Hide()
                DashboardForm.Show()
            Else
                MsgBox("Invalid username or password.")
            End If
        Catch ex As Exception
            MsgBox("Login error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Redirect to SignupForm
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Me.Hide()
        Form1.Show()
    End Sub

    ' Hash password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
