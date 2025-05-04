Imports MySql.Data.MySqlClient

Public Class AddVaccineForm
    Private Sub btnAddVaccine_Click(sender As Object, e As EventArgs) Handles btnAddVaccine.Click
        ' Input validation
        If txtVaccineName.Text = "" Or txtTargetedGroup.Text = "" Or txtType.Text = "" Or txtModeOfAdmin.Text = "" Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Connect to database using shared module
            Connect()

            ' SQL insert statement
            Dim cmd As New MySqlCommand("INSERT INTO vaccines (name, targeted_group, type, mode_of_administration) VALUES (@name, @targetedGroup, @type, @mode)", conn)
            cmd.Parameters.AddWithValue("@name", txtVaccineName.Text.Trim())
            cmd.Parameters.AddWithValue("@targetedGroup", txtTargetedGroup.Text.Trim())
            cmd.Parameters.AddWithValue("@type", txtType.Text.Trim())
            cmd.Parameters.AddWithValue("@mode", txtModeOfAdmin.Text.Trim())

            ' Execute query
            cmd.ExecuteNonQuery()
            MessageBox.Show("Vaccine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear inputs
            txtVaccineName.Clear()
            txtTargetedGroup.Clear()
            txtType.Clear()
            txtModeOfAdmin.Clear()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close shared connection
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub
End Class
