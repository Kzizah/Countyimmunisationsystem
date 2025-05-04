<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnSignup = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(153, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 0
        Label1.Text = "Log In"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(269, 344)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 25)
        Label4.TabIndex = 3
        Label4.Text = ",click sign up"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(211, 148)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(150, 31)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(220, 236)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(169, 293)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnSignup
        ' 
        btnSignup.Location = New Point(258, 404)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(112, 34)
        btnSignup.TabIndex = 7
        btnSignup.Text = "Sign Up"
        btnSignup.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSignup)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignup As Button
End Class
