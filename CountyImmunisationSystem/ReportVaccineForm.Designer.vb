<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportVaccineForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.dgvVaccines = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvVaccines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVaccines
        '
        Me.dgvVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVaccines.Location = New System.Drawing.Point(30, 30)
        Me.dgvVaccines.Name = "dgvVaccines"
        Me.dgvVaccines.RowHeadersWidth = 62
        Me.dgvVaccines.RowTemplate.Height = 33
        Me.dgvVaccines.Size = New System.Drawing.Size(700, 300)
        Me.dgvVaccines.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(30, 350)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 34)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(640, 350)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 34)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ReportVaccineForm
        '
        Me.ClientSize = New System.Drawing.Size(760, 420)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvVaccines)
        Me.Name = "ReportVaccineForm"
        Me.Text = "Vaccine Report"
        CType(Me.dgvVaccines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents dgvVaccines As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
End Class
