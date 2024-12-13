Public Class ADMDashboardJOBTab
    Private JobDataTable As New DataTable()
    'Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
    '    Dim ADMDashOFW As New ADMDashboardOFWTab()

    '    Me.Close()
    '    ADMDashOFW.Show()
    'End Sub



    'Public Sub refresh()
    '    Dim query As String = "SELECT * FROM employer"
    '    JobDataTable.Clear() ' Clear any existing data
    '    dgvJOB.DataSource = JobDataTable ' Bind the DataTable to the DataGridView
    '    LoadToDGV(query, dgvJOB)
    'End Sub

    Public Sub RefreshDataGrid()
        Dim query As String = "SELECT * FROM agency"
        JobDataTable.Clear() ' Clear any existing data
        dgvJOB.DataSource = JobDataTable ' Bind the DataTable to the DataGridView
        LoadToDGV(query, dgvJOB)
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        If MessageBox.Show("Are you sure you want to close the system?", "Confirm Closing",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                            DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to Log out?", "Confirm Log out",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                            DialogResult.Yes Then
            Dim loginPage As New ADMloginPage()

            Me.Close()
            loginPage.Show()
        End If
    End Sub

    'Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
    '    Dim ADMDashEMP As New ADMDashboardEMPTab()
    '    Close()
    '    ADMDashEMP.Show()
    'End Sub

    'Private Sub BtnADMDashSTAT_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
    '    Dim ADMDashStat As New ADMDashboardStatTab()
    '    Me.Close()
    '    ADMDashStat.Show()
    'End Sub
    'Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
    '    Dim ADMDashAGC As New ADMDashboardAGCTab
    '    Close()
    '    ADMDashAGC.Show()
    'End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim AddEMP As New ADMAddEMP()
        AddEMP.ShowDialog()
    End Sub
    Private Sub dgvJOB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJOB.CellContentClick

    End Sub


    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        If dgvJOB.SelectedRows.Count > 0 Then  ' Check if a row is selected
            Dim selectedRow As DataGridViewRow = dgvJOB.SelectedRows(0)
            Dim selectedEMPId As Integer = CInt(selectedRow.Cells("EmployerId").Value)  ' Assuming "OFWId" is the column name for the ID

            Dim EditEMP As New ADMEditEMP(selectedEMPId)  ' Pass the selected ID to the constructor
            EditEMP.ShowDialog()
        Else
            MessageBox.Show("Please select an OFW record to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDLT_Click(sender As Object, e As EventArgs) Handles btnDLT.Click
        If dgvJOB.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvJOB.SelectedRows(0)
            Dim selectedEMPId As Integer = CInt(selectedRow.Cells("EmployerId").Value)  ' Assuming "OFWId" is the column name for the ID

            If MessageBox.Show("Are you sure you want to delete this OFW record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = $"DELETE FROM EMPLOYER WHERE EmployerId = {selectedEMPId}"
                readQuery(query)

                MessageBox.Show("Employer record deleted successfully!")
                refresh()  ' Refresh the DataGridView
            End If
        Else
            MessageBox.Show("Please select an Employer record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub ADMDashboardJOBTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM jobplacement"
        JobDataTable.Clear() ' Clear any existing data
        dgvJOB.DataSource = JobDataTable ' Bind the DataTable to the DataGridView
        LoadToDGV(query, dgvJOB)
    End Sub

    Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
        Dim ADMDashAGC As New ADMDashboardAGCTab
        Close()
        ADMDashAGC.Show()
    End Sub

    Private Sub btnADMDashDEP_Click(sender As Object, e As EventArgs) Handles btnADMDashDEP.Click
        Dim ADMDashDEP As New ADMDashboardDEPTab
        Close()
        ADMDashDEP.Show()
    End Sub

    Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
        Dim ADMDashEMP As New ADMDashboardEMPTab
        Close()
        ADMDashEMP.Show()
    End Sub

    Private Sub btnADMDashJOB_Click(sender As Object, e As EventArgs) Handles btnADMDashJOB.Click
        Dim ADMDashJOB As New ADMDashboardJOBTab
        Close()
        ADMDashJOB.Show()
    End Sub

    Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
        Dim ADMDashOFW As New ADMDashboardOFWTab
        Close()
        ADMDashOFW.Show()
    End Sub

    Private Sub btnADMDashStat_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
        Dim ADMDashStat As New ADMDashboardStatTab
        Close()
        ADMDashStat.Show()
    End Sub

End Class