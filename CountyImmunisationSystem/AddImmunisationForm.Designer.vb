<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddImmunisationForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmbVaccine = New ComboBox()
        cmbWard = New ComboBox()
        dtpDateGiven = New DateTimePicker()
        btnAdd = New Button()
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' cmbVaccine
        ' 
        cmbVaccine.DropDownStyle = ComboBoxStyle.DropDownList
        cmbVaccine.Location = New Point(336, 48)
        cmbVaccine.Name = "cmbVaccine"
        cmbVaccine.Size = New Size(200, 33)
        cmbVaccine.TabIndex = 0
        ' 
        ' cmbWard
        ' 
        cmbWard.DropDownStyle = ComboBoxStyle.DropDownList
        cmbWard.Location = New Point(336, 111)
        cmbWard.Name = "cmbWard"
        cmbWard.Size = New Size(200, 33)
        cmbWard.TabIndex = 1
        ' 
        ' dtpDateGiven
        ' 
        dtpDateGiven.Location = New Point(336, 169)
        dtpDateGiven.Name = "dtpDateGiven"
        dtpDateGiven.Size = New Size(200, 31)
        dtpDateGiven.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(50, 200)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 30)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Immunisation"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(210, 200)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 30)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(160, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(170, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 25)
        Label2.TabIndex = 6
        Label2.Text = "Enter Ward Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(160, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 7
        Label3.Text = "Date Issued"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(170, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(167, 25)
        Label4.TabIndex = 8
        Label4.Text = "Enter Vaccine Name"
        ' 
        ' AddImmunisationForm
        ' 
        ClientSize = New Size(824, 621)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmbVaccine)
        Controls.Add(cmbWard)
        Controls.Add(dtpDateGiven)
        Controls.Add(btnAdd)
        Controls.Add(btnBack)
        Name = "AddImmunisationForm"
        Text = "Add Immunisation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbVaccine As ComboBox
    Friend WithEvents cmbWard As ComboBox
    Friend WithEvents dtpDateGiven As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
