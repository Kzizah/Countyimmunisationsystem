<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddVaccineForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtVaccineName = New TextBox()
        txtTargetedGroup = New TextBox()
        txtType = New TextBox()
        txtModeOfAdmin = New TextBox()
        btnAddVaccine = New Button()
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtVaccineName
        ' 
        txtVaccineName.Location = New Point(218, 50)
        txtVaccineName.Name = "txtVaccineName"
        txtVaccineName.Size = New Size(200, 31)
        txtVaccineName.TabIndex = 0
        ' 
        ' txtTargetedGroup
        ' 
        txtTargetedGroup.Location = New Point(218, 100)
        txtTargetedGroup.Name = "txtTargetedGroup"
        txtTargetedGroup.Size = New Size(200, 31)
        txtTargetedGroup.TabIndex = 1
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(218, 150)
        txtType.Name = "txtType"
        txtType.Size = New Size(200, 31)
        txtType.TabIndex = 2
        ' 
        ' txtModeOfAdmin
        ' 
        txtModeOfAdmin.Location = New Point(218, 200)
        txtModeOfAdmin.Name = "txtModeOfAdmin"
        txtModeOfAdmin.Size = New Size(200, 31)
        txtModeOfAdmin.TabIndex = 3
        ' 
        ' btnAddVaccine
        ' 
        btnAddVaccine.Location = New Point(150, 250)
        btnAddVaccine.Name = "btnAddVaccine"
        btnAddVaccine.Size = New Size(100, 40)
        btnAddVaccine.TabIndex = 4
        btnAddVaccine.Text = "Add Vaccine"
        btnAddVaccine.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(260, 250)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(90, 40)
        btnBack.TabIndex = 5
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 25)
        Label1.TabIndex = 6
        Label1.Text = "Vaccine Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 25)
        Label2.TabIndex = 7
        Label2.Text = "Targeted Group:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 25)
        Label3.TabIndex = 8
        Label3.Text = "Type:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 25)
        Label4.TabIndex = 9
        Label4.Text = "Mode of Admin:"
        ' 
        ' AddVaccineForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(689, 320)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Controls.Add(btnAddVaccine)
        Controls.Add(txtModeOfAdmin)
        Controls.Add(txtType)
        Controls.Add(txtTargetedGroup)
        Controls.Add(txtVaccineName)
        Name = "AddVaccineForm"
        Text = "Add Vaccine"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtVaccineName As TextBox
    Friend WithEvents txtTargetedGroup As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtModeOfAdmin As TextBox
    Friend WithEvents btnAddVaccine As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
