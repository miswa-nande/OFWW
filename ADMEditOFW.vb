Imports MySql.Data.MySqlClient




Public Class ADMEditOFW
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private selectedOFWId As Integer

    Private Sub ADMEditOFW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxEditOFWCivStat.Items.Add("Single")
        cbxEditOFWCivStat.Items.Add("Married")
        cbxEditOFWCivStat.Items.Add("Legally Separated")
        cbxEditOFWCivStat.Items.Add("Widowed")

        cbxEditOFWGender.Items.Add("Male")
        cbxEditOFWGender.Items.Add("Female")
    End Sub

    Public Sub New(ofwId As Integer)
        InitializeComponent()
        selectedOFWId = ofwId
        ' Populate form fields with data from the selected OFW
        PopulateFormFields(ofwId)
    End Sub



    Private Sub PopulateFormFields(ofwId As Integer)
        ' SQL query with a parameter placeholder
        Dim query As String = $"SELECT * FROM OFW WHERE OFWId = {ofwId}"

        ' Use readQuery to execute the query
        readQuery(query)

        ' Check if the reader has been initialized and has rows
        If cmdRead IsNot Nothing AndAlso cmdRead.Read() Then
            ' Populate the form fields
            txtbxEditOFWFName.Text = cmdRead("FirstName").ToString()
            txtbxEditOFWMName.Text = cmdRead("MiddleName").ToString()
            txtbxEditOFWLName.Text = cmdRead("LastName").ToString()

            dateEditOFWDOB.Value = Convert.ToDateTime(cmdRead("DOB"))
            cbxEditOFWGender.SelectedItem = cmdRead("Sex").ToString()
            cbxEditOFWCivStat.SelectedItem = cmdRead("CivilStatus").ToString()

            txtbxEditOFWStreet.Text = cmdRead("Street").ToString()
            txtbxEditOFWBrgy.Text = cmdRead("Barangay").ToString()
            txtbxEditOFWCity.Text = cmdRead("City").ToString()
            txtbxEditOFWProv.Text = cmdRead("Province").ToString()
            txtbxEditOFWZip.Text = cmdRead("Zipcode").ToString()
            txtbxEditOFWContNum.Text = cmdRead("ContactNum").ToString()
            txtbxEditOFWEmrContNum.Text = cmdRead("EmergencyContactNum").ToString()
            txtbxEditOFWPassportNum.Text = cmdRead("PassportNum").ToString()
            txtbxEditOFWVisaNum.Text = cmdRead("VISANum").ToString()
            txtbxEditOFWOECNum.Text = cmdRead("OECNum").ToString()
            ' ... populate other fields ...
        End If

        ' Close the reader and connection if necessary
        If cmdRead IsNot Nothing AndAlso Not cmdRead.IsClosed Then cmdRead.Close()

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Try
            ' Collect updated values from the form fields
            Dim updatedFirstName As String = txtbxEditOFWFName.Text
            Dim updatedMiddleName As String = txtbxEditOFWMName.Text
            Dim updatedLastName As String = txtbxEditOFWLName.Text
            Dim updatedDOB As Date = dateEditOFWDOB.Value
            Dim updatedGender As String = If(cbxEditOFWGender.SelectedItem IsNot Nothing, cbxEditOFWGender.SelectedItem.ToString(), String.Empty)
            Dim updatedCivilStatus As String = If(cbxEditOFWCivStat.SelectedItem IsNot Nothing, cbxEditOFWCivStat.SelectedItem.ToString(), String.Empty)
            Dim updatedStreet As String = txtbxEditOFWStreet.Text
            Dim updatedBarangay As String = txtbxEditOFWBrgy.Text
            Dim updatedCity As String = txtbxEditOFWCity.Text
            Dim updatedProvince As String = txtbxEditOFWProv.Text
            Dim updatedZipcode As String = txtbxEditOFWZip.Text
            Dim updatedContactNum As String = txtbxEditOFWContNum.Text
            Dim updatedEmrContactNum As String = txtbxEditOFWEmrContNum.Text
            Dim updatedPassportNum As String = txtbxEditOFWPassportNum.Text
            Dim updatedVisaNum As String = txtbxEditOFWVisaNum.Text
            Dim updatedOECNum As String = txtbxEditOFWOECNum.Text

            ' SQL query
            Dim query As String = $"UPDATE OFW SET FirstName = '{updatedFirstName}', MiddleName = '{updatedMiddleName}', 
                                LastName = '{updatedLastName}', DOB = '{updatedDOB:yyyy-MM-dd}', Sex = '{updatedGender}', 
                                CivilStatus = '{updatedCivilStatus}', Street = '{updatedStreet}', Barangay = '{updatedBarangay}', 
                                City = '{updatedCity}', Province = '{updatedProvince}', Zipcode = '{updatedZipcode}', 
                                ContactNum = '{updatedContactNum}', EmergencyContactNum = '{updatedEmrContactNum}', 
                                PassportNum = '{updatedPassportNum}', VisaNum = '{updatedVisaNum}', OECNum = '{updatedOECNum}' 
                                WHERE OFWId = {selectedOFWId}"

            ' Execute the query
            readQuery(query)

            ' Notify the user and close the form
            MessageBox.Show("OFW record updated successfully!")
            Me.Close()

            ' Refresh the main form's DataGridView
            ADMDashboardOFWTab.refresh()
        Catch ex As Exception
            MsgBox($"An error occurred: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
