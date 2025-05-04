<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWardForm
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
        txtWardName = New TextBox()
        txtPopulationSize = New TextBox()
        txtWardNumber = New TextBox()
        btnAddWard = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(238, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 25)
        Label1.TabIndex = 0
        Label1.Text = "Add Ward"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 1
        Label2.Text = "Ward Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(97, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 25)
        Label3.TabIndex = 2
        Label3.Text = "Ward Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 25)
        Label4.TabIndex = 3
        Label4.Text = "Population Size"
        ' 
        ' txtWardName
        ' 
        txtWardName.Location = New Point(295, 132)
        txtWardName.Name = "txtWardName"
        txtWardName.Size = New Size(150, 31)
        txtWardName.TabIndex = 4
        ' 
        ' txtPopulationSize
        ' 
        txtPopulationSize.Location = New Point(295, 225)
        txtPopulationSize.Name = "txtPopulationSize"
        txtPopulationSize.Size = New Size(150, 31)
        txtPopulationSize.TabIndex = 5
        ' 
        ' txtWardNumber
        ' 
        txtWardNumber.Location = New Point(295, 180)
        txtWardNumber.Name = "txtWardNumber"
        txtWardNumber.Size = New Size(150, 31)
        txtWardNumber.TabIndex = 6
        ' 
        ' btnAddWard
        ' 
        btnAddWard.Location = New Point(158, 309)
        btnAddWard.Name = "btnAddWard"
        btnAddWard.Size = New Size(112, 34)
        btnAddWard.TabIndex = 7
        btnAddWard.Text = "Add Ward"
        btnAddWard.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(315, 309)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 8
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' AddWardForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnAddWard)
        Controls.Add(txtWardNumber)
        Controls.Add(txtPopulationSize)
        Controls.Add(txtWardName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddWardForm"
        Text = "AddWardForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWardName As TextBox
    Friend WithEvents txtPopulationSize As TextBox
    Friend WithEvents txtWardNumber As TextBox
    Friend WithEvents btnAddWard As Button
    Friend WithEvents btnBack As Button
End Class
