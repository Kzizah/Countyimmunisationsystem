<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportWardForm
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
        dgvWards = New DataGridView()
        btnRefresh = New Button()
        Label1 = New Label()
        btnBack = New Button()
        CType(dgvWards, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvWards
        ' 
        dgvWards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvWards.Location = New Point(140, 116)
        dgvWards.Name = "dgvWards"
        dgvWards.RowHeadersWidth = 62
        dgvWards.Size = New Size(865, 271)
        dgvWards.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(270, 404)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(227, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 2
        Label1.Text = "View Ward"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(447, 404)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' ReportWardForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1060, 450)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Controls.Add(btnRefresh)
        Controls.Add(dgvWards)
        Name = "ReportWardForm"
        Text = "ReportWardForm"
        CType(dgvWards, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dgvWards As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
