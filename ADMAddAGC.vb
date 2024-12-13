Imports System.Net.NetworkInformation
Imports MySql.Data.MySqlClient


Public Class ADMAddAGC


    Private Sub ADMAddAGC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxAGCAccredStat.Items.Add("Accredited")
        cbxAGCAccredStat.Items.Add("Not Accredited")
        cbxAGCAccredStat.Items.Add("Pending")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim agencyName As String = txtAGCFName.Text
        Dim AgencylicenseNumber As String = txtAGCLicNum.Text
        Dim website As String = txtAGCWebsite.Text
        Dim govAccreditation As String = cbxAGCAccredStat.SelectedItem.ToString()
        Dim licenseExpDate As Date = dateAGCExp.Value
        Dim street As String = txtAGCStreet.Text
        Dim city As String = txtAGCCity.Text
        Dim state As String = txtAGCState.Text
        Dim country As String = txtAGCCountry.Text
        Dim zipcode As Integer = Integer.Parse(txtAGCZip.Text)
        Dim contactNumber As String = txtAGCContNum.Text
        Dim email As String = txtAGCEmail.Text
        Dim yearsOfOperation As Integer = Integer.Parse(txtAGCYrInOp.Text)

        Dim query As String = $"INSERT INTO Agency (AgencyName, AgencyLicenseNumber, WebsiteUrl, GovAccreditationStat, LicenseExpDate, Street, City, State, Country, Zipcode, ContactNum, Email, YearsOfOperation) 
                VALUES ('{agencyName}', '{AgencylicenseNumber}', '{website}', '{govAccreditation}', '{licenseExpDate:yyyy-MM-dd}', '{street}', '{city}', '{state}', '{country}', '{zipcode}', '{contactNumber}', '{email}', '{yearsOfOperation}')"



        Try
            ' Call readQuery to execute the SQL statement
            readQuery(query)

            ' Notify the user of success
            MessageBox.Show("Record successfully inserted!")
        Catch ex As Exception
            ' Handle any errors
            MsgBox($"An error occurred: {ex.Message}", MsgBoxStyle.Critical)
        End Try

        Me.Close()
        ADMDashboardOFWTab.Refresh()
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
