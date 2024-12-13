Imports MySql.Data.MySqlClient

Imports System.Net

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ADMAddOFW
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Dim uploadedImageUrl As String = ""

    Private Sub ADMAddOFW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxAddOFWCivStat.Items.Add("Single")
        cbxAddOFWCivStat.Items.Add("Married")
        cbxAddOFWCivStat.Items.Add("Legally Separated")
        cbxAddOFWCivStat.Items.Add("Widowed")

        cbxAddOFWGender.Items.Add("Male")
        cbxAddOFWGender.Items.Add("Female")
    End Sub

    Private Function UploadImageToServer(filePath As String) As String
        Try
            ' Replace with your server's upload endpoint and IP address
            Dim serverUrl As String = "http://192.168.1.100/upload"
            Dim webClient As New WebClient()

            ' Upload the file and get the response
            Dim response As Byte() = webClient.UploadFile(serverUrl, filePath)
            Return System.Text.Encoding.UTF8.GetString(response)
        Catch ex As Exception
            MessageBox.Show("Error uploading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim firstName As String = txtbxAddOFWFName.Text
        Dim middleName As String = txtbxAddOFWMName.Text
        Dim lastName As String = txtbxAddOFWLName.Text
        Dim dateOfBirth As Date = dateAddOFWDOB.Value
        Dim gender As String = cbxAddOFWGender.SelectedItem.ToString()
        Dim civilStatus As String = cbxAddOFWCivStat.SelectedItem.ToString()
        Dim street As String = txtbxAddOFWStreet.Text
        Dim barangay As String = txtbxAddOFWBrgy.Text
        Dim city As String = txtbxAddOFWCity.Text
        Dim province As String = txtbxAddOFWProv.Text
        Dim zipcode As String = txtbxAddOFWZip.Text
        Dim contactNumber As String = txtbxAddOFWContNum.Text
        Dim emrgContactNum As String = txtbxAddOFWEmrContNum.Text
        Dim passportNum As String = txtbxAddOFWPassportNum.Text
        Dim visaNum As String = txtbxAddOFWVisaNum.Text
        Dim OECNum As String = txtbxAddOFWOECNum.Text


        Dim query As String = $"INSERT INTO OFW (FirstName, MiddleName, LastName, DOB, Sex, CivilStatus, Street, Barangay, City, Province, Zipcode, 
                                        ContactNum, EmergencyContactNum, PassportNum, VISANum, OECNum) 
                        VALUES ('{firstName}', '{middleName}', '{lastName}', '{dateOfBirth:yyyy-MM-dd}', '{gender}', '{civilStatus}', 
                                '{street}', '{barangay}', '{city}', '{province}', '{zipcode}', '{contactNumber}', 
                                '{emrgContactNum}', '{passportNum}', '{visaNum}', '{OECNum}')"



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

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnADDPic_Click(sender As Object, e As EventArgs) Handles btnADDPic.Click
        ' Open file dialog for selecting an image
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            ' Load the image into a PictureBox
            Try
                Dim selectedImage As Image = Image.FromFile(filePath)
                DisplayPIC.Image = selectedImage

                ' Upload the image to the server via IP and get the URL
                uploadedImageUrl = UploadImageToServer(filePath)
                MessageBox.Show("Image uploaded successfully!")
            Catch ex As Exception
                MessageBox.Show("Error loading or uploading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class