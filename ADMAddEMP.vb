Imports MySql.Data.MySqlClient


Public Class ADMAddEMP
    Private Sub ADMAddEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim EmployerFirstName As String = txtEMPFName.Text
        Dim EmployerMiddleName As String = txtEMPMName.Text
        Dim EmployerLastName As String = txtEMPLName.Text
        Dim CompanyName As String = txtEMPCompanyName.Text
        Dim CompanyStreet As String = txtEMPStreet.Text
        Dim CompanyCity As String = txtEMPCity.Text
        Dim CompanyState As String = txtEMPState.Text
        Dim CompanyCountry As String = txtEMPCountry.Text
        Dim CompanyZipcode As String = txtEMPZip.Text
        Dim EmployerContactNum As String = txtEMPContNum.Text
        Dim EmployerEmail As String = txtEMPEmail.Text
        Dim Industry As String = txtEMPIndustry.Text

        ' Construct the INSERT query
        Dim query As String = $"INSERT INTO EMPLOYER 
                           (EmployerFirstName, EmployerMiddleName, EmployerLastName, CompanyName, CompanyStreet, CompanyCity, CompanyState, CompanyCountry, CompanyZipcode, EmployerContactNum, EmployerEmail, Industry) 
                           VALUES 
                           ('{EmployerFirstName}', '{EmployerMiddleName}', '{EmployerLastName}', '{CompanyName}', '{CompanyStreet}', '{CompanyCity}', '{CompanyState}', '{CompanyCountry}', '{CompanyZipcode}', '{EmployerContactNum}', '{EmployerEmail}', '{Industry}')"

        Try
            ' Use readQuery for execution
            readQuery(query)
            MessageBox.Show("Employer record added successfully!")

            ' Close the current form
            Me.Close()

            ' Refresh the main dashboard
            ADMDashboardEMPTab.refresh()
        Catch ex As Exception
            ' Handle any errors during the operation
            MessageBox.Show($"An error occurred while adding the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure resources are properly released
            If cmdRead IsNot Nothing AndAlso Not cmdRead.IsClosed Then cmdRead.Close()
        End Try
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class