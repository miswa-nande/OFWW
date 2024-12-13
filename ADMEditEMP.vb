Imports MySql.Data.MySqlClient



Public Class ADMEditEMP

    Private selectedEMPId As Integer

    Private Sub ADMEditEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(empId As Integer)
        InitializeComponent()
        selectedEMPId = empId
        ' Populate form fields with data from the selected OFW
        PopulateFormFields(empId)
    End Sub

    Private Sub PopulateFormFields(employerId As Integer)
        ' Define the query to retrieve employer data based on EmployerId
        Dim query As String = $"SELECT * FROM EMPLOYER WHERE EmployerId = {employerId}"

        ' Use readQuery to execute the query
        readQuery(query)

        ' Check if the reader has been initialized and has rows
        If cmdRead IsNot Nothing AndAlso cmdRead.Read() Then
            ' Populate the form fields with data from the query result
            txtEMPFName.Text = cmdRead("EmployerFirstName").ToString()
            txtEMPMName.Text = cmdRead("EmployerMiddleName").ToString()
            txtEMPLName.Text = cmdRead("EmployerLastName").ToString()
            txtEMPCompanyName.Text = cmdRead("CompanyName").ToString()
            txtEMPStreet.Text = cmdRead("CompanyStreet").ToString()
            txtEMPCity.Text = cmdRead("CompanyCity").ToString()
            txtEMPState.Text = cmdRead("CompanyState").ToString()
            txtEMPCountry.Text = cmdRead("CompanyCountry").ToString()
            txtEMPZip.Text = cmdRead("CompanyZipcode").ToString()
            txtEMPContNum.Text = cmdRead("EmployerContactNum").ToString()
            txtEMPEmail.Text = cmdRead("EmployerEmail").ToString()
            txtEMPIndustry.Text = cmdRead("Industry").ToString()
        Else
            ' Notify the user if no record was found
            MessageBox.Show("No record found for the specified Employer ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Ensure the reader is properly closed after use
        If cmdRead IsNot Nothing AndAlso Not cmdRead.IsClosed Then cmdRead.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Dim updatedEmployerFirstName As String = txtEMPFName.Text
        Dim updatedEmployerMiddleName As String = txtEMPMName.Text
        Dim updatedEmployerLastName As String = txtEMPLName.Text
        Dim updatedCompanyName As String = txtEMPCompanyName.Text
        Dim updatedCompanyStreet As String = txtEMPStreet.Text
        Dim updatedCompanyCity As String = txtEMPCity.Text
        Dim updatedCompanyState As String = txtEMPState.Text
        Dim updatedCompanyCountry As String = txtEMPCountry.Text
        Dim updatedCompanyZipcode As String = txtEMPZip.Text
        Dim updatedEmployerContactNum As String = txtEMPContNum.Text
        Dim updatedEmployerEmail As String = txtEMPEmail.Text
        Dim updatedIndustry As String = txtEMPIndustry.Text

        ' Construct the query
        Dim query As String = $"UPDATE EMPLOYER SET 
                           EmployerFirstName = '{updatedEmployerFirstName}', 
                           EmployerMiddleName = '{updatedEmployerMiddleName}', 
                           EmployerLastName = '{updatedEmployerLastName}', 
                           CompanyName = '{updatedCompanyName}', 
                           CompanyStreet = '{updatedCompanyStreet}', 
                           CompanyCity = '{updatedCompanyCity}', 
                           CompanyState = '{updatedCompanyState}', 
                           CompanyCountry = '{updatedCompanyCountry}', 
                           CompanyZipcode = '{updatedCompanyZipcode}', 
                           EmployerContactNum = '{updatedEmployerContactNum}', 
                           EmployerEmail = '{updatedEmployerEmail}', 
                           Industry = '{updatedIndustry}' 
                           WHERE EmployerId = {selectedEMPId}"

        Try
            ' Execute the query using readQuery
            readQuery(query)
            MessageBox.Show("Employer record updated successfully!")

            ' Close the edit form and refresh the main form's DataGridView
            Me.Close()

            ' Assuming you have a reference to the main form:
            ADMDashboardEMPTab.refresh() ' Call the refresh method in the main form
        Catch ex As Exception
            ' Handle any errors during the update
            MessageBox.Show($"An error occurred while updating the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure resources are properly released
            If cmdRead IsNot Nothing AndAlso Not cmdRead.IsClosed Then cmdRead.Close()
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class