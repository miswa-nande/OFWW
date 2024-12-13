Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class ADMDashboardStatTab
    Private Sub ADMDashboardStatTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPieChartOFW()
    End Sub



    'Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
    '    Dim ADMDashOFW As New ADMDashboardOFWTab()

    '    Me.Close()
    '    ADMDashOFW.Show()
    'End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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
    '    Me.Close()
    '    ADMDashEMP.Show()
    'End Sub

    'Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
    '    Dim ADMDashAGC As New ADMDashboardAGCTab()
    '    Me.Close()
    '    ADMDashAGC.Show()
    'End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    'Private Sub btnADMDashSTAT_Click(sender As Object, e As EventArgs)
    '    ' Placeholder code
    'End Sub

    'Private Sub btnADMDashJOB_Click(sender As Object, e As EventArgs) Handles btnADMDashJOB.Click
    '    Dim ADMDashOFW As New ADMDashboardJOBTab()
    '    Me.Close()
    '    ADMDashOFW.Show()
    'End Sub

    'Private Sub btnADMDashDEP_Click(sender As Object, e As EventArgs) Handles btnADMDashDEP.Click

    'End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Chart2_Click_1(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub

    Private Sub LoadPieChartOFW()
        Try
            ' SQL query to count OFWs per province
            Dim query As String = "SELECT Province, COUNT(*) AS TotalOFWs FROM ofw GROUP BY Province"

            ' Execute the query using readQuery method
            readQuery(query)

            ' Check if cmdRead has data and process it
            If cmdRead IsNot Nothing AndAlso cmdRead.HasRows Then
                ' Clear existing data from Chart2
                Chart2.Series.Clear()

                ' Create a new series for the pie chart
                Dim series As New Series("OFWs per Province")
                series.ChartType = SeriesChartType.Pie

                ' Add data points to the series
                While cmdRead.Read()
                    series.Points.AddXY(cmdRead("Province").ToString(), Convert.ToInt32(cmdRead("TotalOFWs")))
                End While

                ' Add the series to Chart2
                Chart2.Series.Add(series)

                ' Customize the chart appearance
                Chart2.Titles.Clear()
                Chart2.Titles.Add("OFWs Distribution by Province")
                series.IsValueShownAsLabel = True ' Show values on the pie chart
            End If
        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error loading chart data: " & ex.Message)
        End Try
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