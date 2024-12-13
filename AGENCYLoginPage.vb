Imports System.IO

Public Class AGENCYLoginPage

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Ensure the form captures key events
        AddHandler Me.KeyDown, AddressOf AGENCYLoginPage_KeyDown
    End Sub

    ' Event handler for Shift + F and Shift + Q key press
    Private Sub AGENCYLoginPage_KeyDown(sender As Object, e As KeyEventArgs)
        ' Check if Shift + F is pressed
        If e.Shift AndAlso e.KeyCode = Keys.F Then
            UpdateConfigFile()
        End If

        ' Check if Shift + Q is pressed
        If e.Shift AndAlso e.KeyCode = Keys.Q Then
            OpenAdminLoginPage()
        End If
    End Sub

    ' Method to update the config.txt file
    Private Sub UpdateConfigFile()
        Dim filePath As String = "config.txt"
        Dim dbServer As String = "localhost"
        Dim dbUid As String = "root"
        Dim dbPwd As String = ""
        Dim dbName As String = "ofw_mis"

        ' Read current values from the file
        Try
            If File.Exists(filePath) Then
                Dim lines As String() = File.ReadAllLines(filePath)
                For Each line As String In lines
                    If line.StartsWith("db_server=") Then
                        dbServer = line.Substring("db_server=".Length)
                    ElseIf line.StartsWith("db_uid=") Then
                        dbUid = line.Substring("db_uid=".Length)
                    ElseIf line.StartsWith("db_pwd=") Then
                        dbPwd = line.Substring("db_pwd=".Length)
                    ElseIf line.StartsWith("db_name=") Then
                        dbName = line.Substring("db_name=".Length)
                    End If
                Next
            End If

            ' Prompt the user for updated values
            dbServer = InputBox("Enter the Database Server", "Database Configuration", dbServer)
            dbUid = InputBox("Enter the Database Username", "Database Configuration", dbUid)
            dbPwd = InputBox("Enter the Database Password", "Database Configuration", dbPwd)
            dbName = InputBox("Enter the Database Name", "Database Configuration", dbName)

            ' Update the config file with the new values
            Dim updatedLines As New List(Of String) From {
            "db_server=" & dbServer,
            "db_uid=" & dbUid,
            "db_pwd=" & dbPwd,
            "db_name=" & dbName
        }
            File.WriteAllLines(filePath, updatedLines)

            MessageBox.Show("config.txt updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ReloadPage()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ReloadPage()
        Try
            ' Reinitialize database connection or any necessary components
            UpdateConnectionString()
            openConn(db_name)

            ' Optional: Reset form components or reload data as needed
            Me.Controls.Clear()
            InitializeComponent()
            MessageBox.Show("Page reloaded successfully!", "Reload", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred while reloading the page: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Method to open the admin login page
    Private Sub OpenAdminLoginPage()
        Dim ADMLoginPage As New ADMloginPage()
        Me.Hide()
        ADMLoginPage.Show()
    End Sub

    ' Event handlers for buttons
    Private Sub btnCloseLoginPg_Click(sender As Object, e As EventArgs) Handles btnCloseLoginPg.Click
        Application.Exit()
    End Sub

    Private Sub btnOFWLoginPg_Click(sender As Object, e As EventArgs) Handles btnOFWLoginPg.Click
        Dim OFWLoginPage As New OFWloginPage()
        Me.Hide()
        OFWLoginPage.Show()
    End Sub

    Private Sub btnADMLoginPg_Click(sender As Object, e As EventArgs)
        Dim ADMLoginPage As New ADMloginPage
        Hide()
        ADMLoginPage.Show()
    End Sub

    Private Sub btnEMPLoginPg_Click(sender As Object, e As EventArgs) Handles btnEMPLoginPg.Click
        Dim EMPLoginPage As New EMPLoginPage()
        Me.Hide()
        EMPLoginPage.Show()
    End Sub

    Private Sub btnAGCLoginPg_Click(sender As Object, e As EventArgs) Handles btnAGCLoginPg.Click
        Dim AGCLoginPage As New AGENCYLoginPage()
        Me.Hide()
        AGCLoginPage.Show()
    End Sub

    ' Placeholder for other page load logic
    Private Sub OFWloginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub imgLogoLoginPg_Click(sender As Object, e As EventArgs) Handles imgLogoLoginPg.Click

    End Sub

    Private Sub btnOkAGCLoginPg_Click(sender As Object, e As EventArgs) Handles btnOkAGCLoginPg.Click
        ' Retrieve values from the login form
        Dim agencyId As String = txtbxAGCIdLogin.Text.Trim()
        Dim password As String = txtAGCPassLogin.Text.Trim()

        ' Check if the password matches the AgencyId
        If agencyId = password Then
            ' Call the method to validate the login from the database
            If ValidateLogin(agencyId) Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Proceed to the next page or main dashboard
                AGCDashboard.Show()
                Me.Hide() ' Hide the login form
            Else
                MessageBox.Show("Invalid login credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Password must match the Agency ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Function ValidateLogin(agencyId As String) As Boolean
        ' Define the SQL query to validate the AgencyId
        Dim query As String = "SELECT COUNT(*) FROM agency WHERE AgencyId = @AgencyId"

        Try
            ' Execute the SQL query
            readQuery(query)

            ' Clear and add parameters
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@AgencyId", agencyId)

            ' Check query results
            If cmdRead IsNot Nothing AndAlso cmdRead.Read() Then
                Dim count As Integer = Convert.ToInt32(cmdRead(0))
                If count > 0 Then
                    Return True
                End If
            End If
        Catch ex As Exception
            ' Handle errors
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the reader if it's open
            If cmdRead IsNot Nothing AndAlso Not cmdRead.IsClosed Then cmdRead.Close()
        End Try

        ' Return False if no match
        Return False
    End Function



End Class
