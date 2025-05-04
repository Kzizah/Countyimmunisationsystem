<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        pnlSidebar = New Panel()
        btnReport = New Button()
        btnAdd = New Button()
        pnlAddMenu = New Panel()
        btnAddImmunisation = New Button()
        btnAddWard = New Button()
        btnAddVaccine = New Button()
        pnlReportMenu = New Panel()
        btnViewWard = New Button()
        btnViewVaccine = New Button()
        btnViewImmunisation = New Button()
        pnlSidebar.SuspendLayout()
        pnlAddMenu.SuspendLayout()
        pnlReportMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.Controls.Add(btnReport)
        pnlSidebar.Controls.Add(btnAdd)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(300, 450)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnReport
        ' 
        btnReport.Location = New Point(12, 243)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(112, 34)
        btnReport.TabIndex = 3
        btnReport.Text = "Report"
        btnReport.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(12, 51)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' pnlAddMenu
        ' 
        pnlAddMenu.Controls.Add(btnAddImmunisation)
        pnlAddMenu.Controls.Add(btnAddWard)
        pnlAddMenu.Controls.Add(btnAddVaccine)
        pnlAddMenu.Location = New Point(0, 104)
        pnlAddMenu.Name = "pnlAddMenu"
        pnlAddMenu.Size = New Size(297, 121)
        pnlAddMenu.TabIndex = 1
        ' 
        ' btnAddImmunisation
        ' 
        btnAddImmunisation.Location = New Point(23, 83)
        btnAddImmunisation.Name = "btnAddImmunisation"
        btnAddImmunisation.Size = New Size(183, 34)
        btnAddImmunisation.TabIndex = 4
        btnAddImmunisation.Text = "Add Immunisation"
        btnAddImmunisation.UseVisualStyleBackColor = True
        ' 
        ' btnAddWard
        ' 
        btnAddWard.Location = New Point(23, 3)
        btnAddWard.Name = "btnAddWard"
        btnAddWard.Size = New Size(162, 34)
        btnAddWard.TabIndex = 1
        btnAddWard.Text = "Add Ward"
        btnAddWard.UseVisualStyleBackColor = True
        ' 
        ' btnAddVaccine
        ' 
        btnAddVaccine.Location = New Point(23, 43)
        btnAddVaccine.Name = "btnAddVaccine"
        btnAddVaccine.Size = New Size(162, 34)
        btnAddVaccine.TabIndex = 3
        btnAddVaccine.Text = "Add Vaccine"
        btnAddVaccine.UseVisualStyleBackColor = True
        ' 
        ' pnlReportMenu
        ' 
        pnlReportMenu.Controls.Add(btnViewWard)
        pnlReportMenu.Controls.Add(btnViewVaccine)
        pnlReportMenu.Controls.Add(btnViewImmunisation)
        pnlReportMenu.Location = New Point(3, 293)
        pnlReportMenu.Name = "pnlReportMenu"
        pnlReportMenu.Size = New Size(294, 122)
        pnlReportMenu.TabIndex = 2
        ' 
        ' btnViewWard
        ' 
        btnViewWard.Location = New Point(61, 18)
        btnViewWard.Name = "btnViewWard"
        btnViewWard.Size = New Size(112, 34)
        btnViewWard.TabIndex = 3
        btnViewWard.Text = "View Wards"
        btnViewWard.UseVisualStyleBackColor = True
        ' 
        ' btnViewVaccine
        ' 
        btnViewVaccine.Location = New Point(61, 58)
        btnViewVaccine.Name = "btnViewVaccine"
        btnViewVaccine.Size = New Size(154, 34)
        btnViewVaccine.TabIndex = 4
        btnViewVaccine.Text = "View Vaccine"
        btnViewVaccine.UseVisualStyleBackColor = True
        ' 
        ' btnViewImmunisation
        ' 
        btnViewImmunisation.Location = New Point(61, 88)
        btnViewImmunisation.Name = "btnViewImmunisation"
        btnViewImmunisation.Size = New Size(194, 34)
        btnViewImmunisation.TabIndex = 5
        btnViewImmunisation.Text = "View Immunisation"
        btnViewImmunisation.UseVisualStyleBackColor = True
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlReportMenu)
        Controls.Add(pnlAddMenu)
        Controls.Add(pnlSidebar)
        Name = "DashboardForm"
        Text = "DashboardForm"
        pnlSidebar.ResumeLayout(False)
        pnlAddMenu.ResumeLayout(False)
        pnlReportMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnlAddMenu As Panel
    Friend WithEvents pnlReportMenu As Panel
    Friend WithEvents btnAddImmunisation As Button
    Friend WithEvents btnAddWard As Button
    Friend WithEvents btnAddVaccine As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnViewWard As Button
    Friend WithEvents btnViewVaccine As Button
    Friend WithEvents btnViewImmunisation As Button
End Class
