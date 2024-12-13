Public Class OFWDashboardOFWTab

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

    Private Sub btnOFWashJOB_Click(sender As Object, e As EventArgs) Handles btnOFWashJOB.Click
        Dim btnOFWDashJOB As New OFWDashboardJOBTab
        Close()
        btnOFWDashJOB.Show()
    End Sub

    Private Sub btnOFWDashDEP_Click(sender As Object, e As EventArgs) Handles btnOFWDashDEP.Click
        Dim btnOFWDashDEP As New OFWDashboardDEPTab
        Close()
        btnOFWDashDEP.Show()
    End Sub

    Private Sub btnOFWDashSTAT_Click(sender As Object, e As EventArgs) Handles btnOFWDashSTAT.Click
        Dim btnOFWDashSTAT As New OFWDashboardSTATTab
        Close()
        btnOFWDashSTAT.Show()
    End Sub

End Class