Public Class OFWDashboardJOBTab
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

    Private Sub btnOFWashSTAT_Click(sender As Object, e As EventArgs) Handles btnOFWDashSTAT.Click
        Dim btnOFWDashSTAT As New OFWDashboardSTATTab
        Close()
        btnOFWDashSTAT.Show()
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