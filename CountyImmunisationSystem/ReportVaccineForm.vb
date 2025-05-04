Imports MySql.Data.MySqlClient

Public Class ReportVaccineForm

    Private Sub ReportVaccineForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVaccines()
    End Sub

    ' Load vaccines from the database into the DataGridView
    Private Sub LoadVaccines()
        Try
            Connect() ' Make sure your Connect function establishes a DB connection
            Dim query As String = "SELECT id, name, targeted_group, type, mode_of_administration FROM vaccines"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvVaccines.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Failed to load vaccines: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    ' Button to refresh the DataGridView
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadVaccines()
    End Sub

    ' Button to go back to the Dashboard form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub
End Class
