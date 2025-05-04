Imports MySql.Data.MySqlClient

Public Class ReportImmunisationForm
    Private Sub ReportImmunisationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub

    Private Sub LoadReport()
        Try
            Connect()
            Dim query As String = "
                SELECT ii.id, v.name AS vaccine, w.name AS ward, ii.date_given
                FROM immunisation_issued ii
                JOIN vaccines v ON ii.vaccine_id = v.id
                JOIN ward w ON ii.ward_id = w.id
                ORDER BY ii.date_given DESC"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvImmunisations.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub
End Class
