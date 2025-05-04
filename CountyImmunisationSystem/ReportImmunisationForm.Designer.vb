<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportImmunisationForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvImmunisations = New DataGridView()
        Me.btnBack = New Button()
        CType(Me.dgvImmunisations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvImmunisations
        '
        Me.dgvImmunisations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImmunisations.Location = New Point(30, 30)
        Me.dgvImmunisations.Name = "dgvImmunisations"
        Me.dgvImmunisations.Size = New Size(600, 300)
        '
        'btnBack
        '
        Me.btnBack.Location = New Point(530, 350)
        Me.btnBack.Size = New Size(100, 30)
        Me.btnBack.Text = "Back"
        '
        'ReportImmunisationForm
        '
        Me.ClientSize = New Size(700, 400)
        Me.Controls.Add(Me.dgvImmunisations)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "ReportImmunisationForm"
        Me.Text = "Immunisation Report"
        CType(Me.dgvImmunisations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents dgvImmunisations As DataGridView
    Friend WithEvents btnBack As Button
End Class
