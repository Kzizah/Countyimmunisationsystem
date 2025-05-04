Imports MySql.Data.MySqlClient

Public Class ReportWardForm

    ' Form Load Event - to load wards into the DataGridView when the form is opened
    Private Sub ReportWardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWards()
    End Sub

    ' Load wards from the database and populate the DataGridView
    Private Sub LoadWards()
        Try
            Connect() ' Make sure your Connect function establishes a DB connection
            Dim query As String = "SELECT id, name, number, population_size FROM ward"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the data to the DataGridView
            dgvWards.DataSource = dt

        Catch ex As Exception
            ' Display error message if loading fails
            MessageBox.Show("Failed to load wards: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close() ' Close the connection when done
        End Try
    End Sub

    ' Button Click Event to Refresh the DataGridView
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadWards() ' Reload wards when the button is clicked
    End Sub

    ' Button Click Event to go back to the DashboardForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide() ' Hide the current form
        DashboardForm.Show() ' Show the Dashboard form
    End Sub

End Class
