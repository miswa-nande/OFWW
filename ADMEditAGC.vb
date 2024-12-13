Imports MySql.Data.MySqlClient


Public Class ADMEditAGC

    Private selectedAGCId As Integer
    Private Sub ADMEditAGC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxEditAGCAccredStat.Items.Add("Acceredited")
        cbxEditAGCAccredStat.Items.Add("Not Accredited")
        cbxEditAGCAccredStat.Items.Add("Pending")
    End Sub

    Public Sub New(AgencyId As Integer)
        InitializeComponent()
        selectedAGCId = AgencyId
        ' Populate form fields with data from the selected OFW
        PopulateFormFields(AgencyId)
    End Sub

    Private Sub PopulateFormFields(ofwId As Integer)
        ' Construct the query with the given ID
        Dim query As String = $"SELECT * FROM agency WHERE AgencyId = {ofwId}"

        ' Call the readQuery method
        readQuery(query)

        ' Check if data is available
        If cmdRead IsNot Nothing AndAlso cmdRead.HasRows Then
            cmdRead.Read()

            ' Populate the form fields
            txtEditAGCFName.Text = cmdRead("AgencyName").ToString()
            txtEditAGCLicNum.Text = cmdRead("AgencyLicenseNumber").ToString()
            txtEditAGCSpec.Text = cmdRead("Specialization").ToString()
            txtEditAGCWebsite.Text = cmdRead("WebsiteUrl").ToString()
            cbxEditAGCAccredStat.SelectedItem = cmdRead("GovAccreditationStat")
            txtEditAGCStreet.Text = cmdRead("Street").ToString()
            txtEditAGCCity.Text = cmdRead("City").ToString()
            txtEditAGCState.Text = cmdRead("State").ToString()
            txtEditAGCCountry.Text = cmdRead("Country").ToString()
            txtEditAGCZip.Text = cmdRead("Zipcode").ToString()
            txtEditAGCContNum.Text = cmdRead("ContactNum").ToString()
            txtEditAGCEmail.Text = cmdRead("Email").ToString()
            txtEditAGCYrInOp.Text = cmdRead("YearsOfOperation").ToString()
        Else
            MessageBox.Show("No record found for the selected Agency ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Close the reader
        cmdRead?.Close()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Dim updatedAGCName As String = txtEditAGCFName.Text
        Dim AgencyLicenseNumber As String = txtEditAGCLicNum.Text
        Dim updatedSpecialization As String = txtEditAGCSpec.Text
        Dim updatedWebsite As String = txtEditAGCWebsite.Text
        Dim updatedAccredStat As String = cbxEditAGCAccredStat.SelectedItem.ToString()
        Dim updatedStreet As String = txtEditAGCStreet.Text
        Dim updatedCity As String = txtEditAGCCity.Text
        Dim updatedState As String = txtEditAGCState.Text
        Dim updatedCountry As String = txtEditAGCCountry.Text
        Dim updatedZipcode As String = txtEditAGCZip.Text
        Dim updatedContactNum As String = txtEditAGCContNum.Text
        Dim updatedEmail As String = txtEditAGCEmail.Text
        Dim updatedYrInOp As String = txtEditAGCYrInOp.Text

        ' Construct the update query
        Dim query As String = $"UPDATE AGENCY SET AgencyName = '{updatedAGCName}', AgencyLicenseNumber = '{AgencyLicenseNumber}', 
                           Specialization = '{updatedSpecialization}', WebsiteUrl = '{updatedWebsite}', 
                           GovAccreditationStat = '{updatedAccredStat}', Street = '{updatedStreet}', City = '{updatedCity}', 
                           State = '{updatedState}', Country = '{updatedCountry}', Zipcode = '{updatedZipcode}', 
                           ContactNum = '{updatedContactNum}', YearsOfOperation = '{updatedYrInOp}' 
                           WHERE AgencyId = {selectedAGCId}"

        Try
            ' Use readQuery for the update operation
            readQuery(query)
            MessageBox.Show("Agency record updated successfully!")

            ' Close the edit form and refresh the main form's DataGridView
            Me.Close()
            ' Assuming you have a reference to the main form:
            ADMDashboardAGCTab.refresh() ' Call the refresh method in the main form
        Catch ex As Exception
            MessageBox.Show($"An error occurred while updating the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure resources are released properly
            cmdRead?.Close()
        End Try
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class