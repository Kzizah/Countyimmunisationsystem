Imports MySql.Data.MySqlClient

Public Class AddImmunisationForm
    Private Sub AddImmunisationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVaccines()
        LoadWards()
    End Sub

    Private Sub LoadVaccines()
        Try
            Connect()
            Dim cmd As New MySqlCommand("SELECT id, name FROM vaccines", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cmbVaccine.DataSource = dt
            cmbVaccine.DisplayMember = "name"
            cmbVaccine.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Failed to load vaccines: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadWards()
        Try
            Connect()
            Dim cmd As New MySqlCommand("SELECT id, name FROM ward", conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            cmbWard.DataSource = dt
            cmbWard.DisplayMember = "name"
            cmbWard.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Failed to load wards: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbVaccine.SelectedValue Is Nothing Or cmbWard.SelectedValue Is Nothing Then
            MessageBox.Show("Select both vaccine and ward.", "Validation Error")
            Return
        End If

        Try
            Connect()
            Dim query As String = "INSERT INTO immunisation_issued (vaccine_id, ward_id, date_given) VALUES (@vaccine_id, @ward_id, @date_given)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@vaccine_id", cmbVaccine.SelectedValue)
            cmd.Parameters.AddWithValue("@ward_id", cmbWard.SelectedValue)
            cmd.Parameters.AddWithValue("@date_given", dtpDateGiven.Value.Date)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Immunisation record added successfully.")
        Catch ex As Exception
            MessageBox.Show("Failed to add: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub
End Class
