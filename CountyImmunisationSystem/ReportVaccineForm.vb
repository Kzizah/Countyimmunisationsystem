Imports MySql.Data.MySqlClient

Public Class ReportVaccineForm
    Private Sub ReportVaccineForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVaccines()
        LoadFilterOptions()
    End Sub

    ' Load vaccines from the database into the DataGridView
    Private Sub LoadVaccines(Optional filterName As String = Nothing, Optional filterTargetGroup As String = Nothing, Optional filterMode As String = Nothing)
        Try
            Connect() ' Make sure your Connect function establishes a DB connection
            Dim query As String = "SELECT id, name, targeted_group, type, mode_of_administration FROM vaccines WHERE 1=1"

            ' Add filters if provided
            If Not String.IsNullOrEmpty(filterName) Then
                query += " AND name = @name"
            End If
            If Not String.IsNullOrEmpty(filterTargetGroup) Then
                query += " AND targeted_group = @targetGroup"
            End If
            If Not String.IsNullOrEmpty(filterMode) Then
                query += " AND mode_of_administration = @mode"
            End If

            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters if filters are used
            If Not String.IsNullOrEmpty(filterName) Then
                cmd.Parameters.AddWithValue("@name", filterName)
            End If
            If Not String.IsNullOrEmpty(filterTargetGroup) Then
                cmd.Parameters.AddWithValue("@targetGroup", filterTargetGroup)
            End If
            If Not String.IsNullOrEmpty(filterMode) Then
                cmd.Parameters.AddWithValue("@mode", filterMode)
            End If

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

    ' Load distinct values for filter dropdowns
    Private Sub LoadFilterOptions()
        Try
            Connect()

            ' Load names
            Dim nameQuery As String = "SELECT DISTINCT name FROM vaccines ORDER BY name"
            Dim nameCmd As New MySqlCommand(nameQuery, conn)
            Dim nameAdapter As New MySqlDataAdapter(nameCmd)
            Dim nameDt As New DataTable()
            nameAdapter.Fill(nameDt)
            cmbName.DataSource = nameDt
            cmbName.DisplayMember = "name"
            cmbName.SelectedIndex = -1

            ' Load target groups
            Dim groupQuery As String = "SELECT DISTINCT targeted_group FROM vaccines ORDER BY targeted_group"
            Dim groupCmd As New MySqlCommand(groupQuery, conn)
            Dim groupAdapter As New MySqlDataAdapter(groupCmd)
            Dim groupDt As New DataTable()
            groupAdapter.Fill(groupDt)
            cmbTargetGroup.DataSource = groupDt
            cmbTargetGroup.DisplayMember = "targeted_group"
            cmbTargetGroup.SelectedIndex = -1

            ' Load modes
            Dim modeQuery As String = "SELECT DISTINCT mode_of_administration FROM vaccines ORDER BY mode_of_administration"
            Dim modeCmd As New MySqlCommand(modeQuery, conn)
            Dim modeAdapter As New MySqlDataAdapter(modeCmd)
            Dim modeDt As New DataTable()
            modeAdapter.Fill(modeDt)
            cmbMode.DataSource = modeDt
            cmbMode.DisplayMember = "mode_of_administration"
            cmbMode.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Failed to load filter options: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    ' Button to apply filters
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim nameFilter As String = If(cmbName.SelectedIndex >= 0, cmbName.Text, Nothing)
        Dim targetFilter As String = If(cmbTargetGroup.SelectedIndex >= 0, cmbTargetGroup.Text, Nothing)
        Dim modeFilter As String = If(cmbMode.SelectedIndex >= 0, cmbMode.Text, Nothing)

        LoadVaccines(nameFilter, targetFilter, modeFilter)
    End Sub

    ' Button to clear filters
    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        cmbName.SelectedIndex = -1
        cmbTargetGroup.SelectedIndex = -1
        cmbMode.SelectedIndex = -1
        LoadVaccines()
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