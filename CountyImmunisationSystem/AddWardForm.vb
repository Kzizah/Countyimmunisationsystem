Imports MySql.Data.MySqlClient

Public Class AddWardForm
    Private Sub btnAddWard_Click(sender As Object, e As EventArgs) Handles btnAddWard.Click
        If txtWardName.Text = "" Or txtWardNumber.Text = "" Or txtPopulationSize.Text = "" Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Connect() ' Use shared connection
            Dim cmd As New MySqlCommand("INSERT INTO ward (name, number, population_size) VALUES (@name, @number, @popSize)", conn)
            cmd.Parameters.AddWithValue("@name", txtWardName.Text.Trim())
            cmd.Parameters.AddWithValue("@number", Integer.Parse(txtWardNumber.Text))
            cmd.Parameters.AddWithValue("@popSize", Integer.Parse(txtPopulationSize.Text))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Ward added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtWardName.Clear()
            txtWardNumber.Clear()
            txtPopulationSize.Clear()
        Catch ex As MySqlException When ex.Number = 1062
            MessageBox.Show("Duplicate ward name or number not allowed.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub
End Class
