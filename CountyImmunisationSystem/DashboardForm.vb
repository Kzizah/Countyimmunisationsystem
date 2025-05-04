Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlAddMenu.Visible = False
        pnlReportMenu.Visible = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pnlAddMenu.Visible = Not pnlAddMenu.Visible
        pnlReportMenu.Visible = False
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        pnlReportMenu.Visible = Not pnlReportMenu.Visible
        pnlAddMenu.Visible = False
    End Sub

    Private Sub btnAddWard_Click(sender As Object, e As EventArgs) Handles btnAddWard.Click
        AddWardForm.Show()
    End Sub

    Private Sub btnAddVaccine_Click(sender As Object, e As EventArgs) Handles btnAddVaccine.Click
        AddVaccineForm.Show()
    End Sub

    Private Sub btnAddImmunisation_Click(sender As Object, e As EventArgs) Handles btnAddImmunisation.Click
        AddImmunisationForm.Show()
    End Sub

    Private Sub btnViewWard_Click(sender As Object, e As EventArgs) Handles btnViewWard.Click
        ReportWardForm.Show()
    End Sub

    Private Sub btnViewVaccine_Click(sender As Object, e As EventArgs) Handles btnViewVaccine.Click
        ReportVaccineForm.Show()
    End Sub

    Private Sub btnViewImmunisation_Click(sender As Object, e As EventArgs) Handles btnViewImmunisation.Click
        ReportImmunisationForm.Show()
    End Sub
End Class
