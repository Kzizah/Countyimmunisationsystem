<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblUsername = New Label()
        lblEmail = New Label()
        lblPassword = New Label()
        lblConfirmPassword = New Label()
        txtUsername = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnSignUp = New Button()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.FlatStyle = FlatStyle.System
        Label1.ForeColor = SystemColors.Desktop
        Label1.Location = New Point(282, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 27)
        Label1.TabIndex = 0
        Label1.Text = "Sign Up "
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(174, 150)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(91, 25)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(183, 201)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(183, 258)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(87, 25)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.ForeColor = SystemColors.MenuHighlight
        lblConfirmPassword.Location = New Point(183, 312)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(156, 25)
        lblConfirmPassword.TabIndex = 4
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(375, 150)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(215, 31)
        txtUsername.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(375, 210)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(215, 31)
        txtEmail.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(375, 255)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(215, 31)
        txtPassword.TabIndex = 7
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(375, 306)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(215, 31)
        txtConfirmPassword.TabIndex = 8
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(336, 395)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(178, 34)
        btnSignUp.TabIndex = 9
        btnSignUp.Text = "Sign Up "
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(561, 399)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 10
        btnLogin.Text = "log In"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(btnSignUp)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(lblConfirmPassword)
        Controls.Add(lblPassword)
        Controls.Add(lblEmail)
        Controls.Add(lblUsername)
        Controls.Add(Label1)
        ForeColor = SystemColors.Highlight
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnLogin As Button

End Class
