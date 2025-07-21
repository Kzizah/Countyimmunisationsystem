<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportVaccineForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.dgvVaccines = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.cmbTargetGroup = New System.Windows.Forms.ComboBox()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvVaccines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVaccines
        '
        Me.dgvVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVaccines.Location = New System.Drawing.Point(30, 120)
        Me.dgvVaccines.Name = "dgvVaccines"
        Me.dgvVaccines.RowHeadersWidth = 62
        Me.dgvVaccines.RowTemplate.Height = 33
        Me.dgvVaccines.Size = New System.Drawing.Size(700, 250)
        Me.dgvVaccines.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(30, 390)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(94, 34)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(640, 390)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 34)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cmbName
        '
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(30, 40)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(200, 33)
        Me.cmbName.TabIndex = 3
        '
        'cmbTargetGroup
        '
        Me.cmbTargetGroup.FormattingEnabled = True
        Me.cmbTargetGroup.Location = New System.Drawing.Point(260, 40)
        Me.cmbTargetGroup.Name = "cmbTargetGroup"
        Me.cmbTargetGroup.Size = New System.Drawing.Size(200, 33)
        Me.cmbTargetGroup.TabIndex = 4
        '
        'cmbMode
        '
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Location = New System.Drawing.Point(490, 40)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(200, 33)
        Me.cmbMode.TabIndex = 5
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(260, 80)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(100, 34)
        Me.btnFilter.TabIndex = 6
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Location = New System.Drawing.Point(380, 80)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(150, 34)
        Me.btnClearFilters.TabIndex = 7
        Me.btnClearFilters.Text = "Clear Filters"
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Target Group:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(490, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mode of Administration:"
        '
        'ReportVaccineForm
        '
        Me.ClientSize = New System.Drawing.Size(760, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClearFilters)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.cmbTargetGroup)
        Me.Controls.Add(Me.cmbName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvVaccines)
        Me.Name = "ReportVaccineForm"
        Me.Text = "Vaccine Report"
        CType(Me.dgvVaccines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents dgvVaccines As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents cmbTargetGroup As ComboBox
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class