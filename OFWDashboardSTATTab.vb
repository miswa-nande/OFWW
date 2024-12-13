Public Class OFWDashboardSTATTab
    Private Sub btnOFWDashEMP_Click(sender As Object, e As EventArgs) Handles btnOFWDashEMP.Click
        Dim btnOFWDashEMP As New OFWDashboardEMPTab
        Close()
        btnOFWDashEMP.Show()
    End Sub

    Private Sub btnOFWDashAGC_Click(sender As Object, e As EventArgs) Handles btnOFWDashAGC.Click
        Dim btnOFWDashAGC As New OFWDashboardAGCTab
        Close()
        btnOFWDashAGC.Show()
    End Sub

    Private Sub btnOFWashJOB_Click(sender As Object, e As EventArgs) Handles btnOFWDashJOB.Click
        Dim btnOFWDashJOB As New OFWDashboardJOBTab
        Close()
        btnOFWDashJOB.Show()
    End Sub

    Private Sub btnOFWDashDEP_Click(sender As Object, e As EventArgs) Handles btnOFWDashDEP.Click
        Dim btnOFWDashDEP As New OFWDashboardDEPTab
        Close()
        btnOFWDashDEP.Show()
    End Sub

    Private Sub btnOFWDashOFW_Click(sender As Object, e As EventArgs) Handles btnOFWDashOFW.Click
        Dim btnOFWDashOFW As New OFWDashboardOFWTab
        Close()
        btnOFWDashOFW.Show()
    End Sub

End Class