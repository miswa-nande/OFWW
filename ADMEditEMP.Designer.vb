<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMEditEMP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label6 = New Label()
        txtEMPIndustry = New TextBox()
        Label11 = New Label()
        txtEMPState = New TextBox()
        txtEMPCity = New TextBox()
        txtEMPStreet = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtEMPLName = New TextBox()
        txtEMPMName = New TextBox()
        txtEMPFName = New TextBox()
        Label1 = New Label()
        txtEMPCountry = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        txtEMPCompanyName = New TextBox()
        Label15 = New Label()
        txtEMPEmail = New TextBox()
        Label14 = New Label()
        txtEMPContNum = New TextBox()
        Label13 = New Label()
        txtEMPZip = New TextBox()
        Label12 = New Label()
        btnSAVE = New Button()
        Label16 = New Label()
        Panel1 = New Panel()
        Label10 = New Label()
        btnCANCEL = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(330, 98)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 20)
        Label6.TabIndex = 50
        Label6.Text = "Industry"
        ' 
        ' txtEMPIndustry
        ' 
        txtEMPIndustry.Location = New Point(330, 123)
        txtEMPIndustry.Margin = New Padding(4, 4, 4, 4)
        txtEMPIndustry.Name = "txtEMPIndustry"
        txtEMPIndustry.PlaceholderText = "Industry"
        txtEMPIndustry.Size = New Size(280, 29)
        txtEMPIndustry.TabIndex = 49
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(330, 255)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 20)
        Label11.TabIndex = 32
        Label11.Text = "City"
        ' 
        ' txtEMPState
        ' 
        txtEMPState.Location = New Point(629, 280)
        txtEMPState.Margin = New Padding(4, 4, 4, 4)
        txtEMPState.Name = "txtEMPState"
        txtEMPState.PlaceholderText = "City/Municipality"
        txtEMPState.Size = New Size(280, 29)
        txtEMPState.TabIndex = 31
        ' 
        ' txtEMPCity
        ' 
        txtEMPCity.Location = New Point(330, 280)
        txtEMPCity.Margin = New Padding(4, 4, 4, 4)
        txtEMPCity.Name = "txtEMPCity"
        txtEMPCity.PlaceholderText = "Barangay"
        txtEMPCity.Size = New Size(280, 29)
        txtEMPCity.TabIndex = 30
        ' 
        ' txtEMPStreet
        ' 
        txtEMPStreet.Location = New Point(15, 280)
        txtEMPStreet.Margin = New Padding(4, 4, 4, 4)
        txtEMPStreet.Name = "txtEMPStreet"
        txtEMPStreet.PlaceholderText = "Street"
        txtEMPStreet.Size = New Size(280, 29)
        txtEMPStreet.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(631, 20)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 20)
        Label5.TabIndex = 22
        Label5.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(15, 20)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 21
        Label4.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(330, 20)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 20
        Label3.Text = "Middle Name"
        ' 
        ' txtEMPLName
        ' 
        txtEMPLName.Location = New Point(629, 45)
        txtEMPLName.Margin = New Padding(4, 4, 4, 4)
        txtEMPLName.Name = "txtEMPLName"
        txtEMPLName.PlaceholderText = "Last Name"
        txtEMPLName.Size = New Size(280, 29)
        txtEMPLName.TabIndex = 2
        ' 
        ' txtEMPMName
        ' 
        txtEMPMName.Location = New Point(330, 45)
        txtEMPMName.Margin = New Padding(4, 4, 4, 4)
        txtEMPMName.Name = "txtEMPMName"
        txtEMPMName.PlaceholderText = "Middle Name"
        txtEMPMName.Size = New Size(280, 29)
        txtEMPMName.TabIndex = 1
        ' 
        ' txtEMPFName
        ' 
        txtEMPFName.Location = New Point(15, 45)
        txtEMPFName.Margin = New Padding(4, 4, 4, 4)
        txtEMPFName.Name = "txtEMPFName"
        txtEMPFName.PlaceholderText = "First Name"
        txtEMPFName.Size = New Size(280, 29)
        txtEMPFName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(379, 57)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 56)
        Label1.TabIndex = 18
        Label1.Text = ">EDIT"
        ' 
        ' txtEMPCountry
        ' 
        txtEMPCountry.Location = New Point(15, 362)
        txtEMPCountry.Margin = New Padding(4, 4, 4, 4)
        txtEMPCountry.Name = "txtEMPCountry"
        txtEMPCountry.PlaceholderText = "Province"
        txtEMPCountry.Size = New Size(280, 29)
        txtEMPCountry.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(629, 255)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 20)
        Label9.TabIndex = 34
        Label9.Text = "State"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(1, 21)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(382, 96)
        Label2.TabIndex = 19
        Label2.Text = "Employer"
        ' 
        ' txtEMPCompanyName
        ' 
        txtEMPCompanyName.Location = New Point(15, 123)
        txtEMPCompanyName.Margin = New Padding(4, 4, 4, 4)
        txtEMPCompanyName.Name = "txtEMPCompanyName"
        txtEMPCompanyName.PlaceholderText = "Company Name"
        txtEMPCompanyName.Size = New Size(280, 29)
        txtEMPCompanyName.TabIndex = 43
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(330, 178)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 20)
        Label15.TabIndex = 42
        Label15.Text = "E-mail"
        ' 
        ' txtEMPEmail
        ' 
        txtEMPEmail.Location = New Point(330, 203)
        txtEMPEmail.Margin = New Padding(4, 4, 4, 4)
        txtEMPEmail.Name = "txtEMPEmail"
        txtEMPEmail.PlaceholderText = "E-mail"
        txtEMPEmail.Size = New Size(280, 29)
        txtEMPEmail.TabIndex = 41
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(15, 178)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 20)
        Label14.TabIndex = 40
        Label14.Text = "Contact Number"
        ' 
        ' txtEMPContNum
        ' 
        txtEMPContNum.Location = New Point(15, 203)
        txtEMPContNum.Margin = New Padding(4, 4, 4, 4)
        txtEMPContNum.Name = "txtEMPContNum"
        txtEMPContNum.PlaceholderText = "Contact Number"
        txtEMPContNum.Size = New Size(280, 29)
        txtEMPContNum.TabIndex = 39
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(330, 337)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 20)
        Label13.TabIndex = 38
        Label13.Text = "Zipcode"
        ' 
        ' txtEMPZip
        ' 
        txtEMPZip.Location = New Point(330, 362)
        txtEMPZip.Margin = New Padding(4, 4, 4, 4)
        txtEMPZip.Name = "txtEMPZip"
        txtEMPZip.PlaceholderText = "Zipcode"
        txtEMPZip.Size = New Size(91, 29)
        txtEMPZip.TabIndex = 37
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(18, 337)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(66, 20)
        Label12.TabIndex = 36
        Label12.Text = "Country"
        ' 
        ' btnSAVE
        ' 
        btnSAVE.BackColor = Color.PaleGreen
        btnSAVE.FlatStyle = FlatStyle.Flat
        btnSAVE.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSAVE.ForeColor = Color.DarkGreen
        btnSAVE.Location = New Point(899, 722)
        btnSAVE.Margin = New Padding(4, 4, 4, 4)
        btnSAVE.Name = "btnSAVE"
        btnSAVE.Size = New Size(153, 56)
        btnSAVE.TabIndex = 20
        btnSAVE.Text = "SAVE"
        btnSAVE.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(18, 98)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(121, 20)
        Label16.TabIndex = 44
        Label16.Text = "Company Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtEMPIndustry)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(txtEMPCompanyName)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtEMPEmail)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtEMPContNum)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtEMPZip)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtEMPCountry)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtEMPState)
        Panel1.Controls.Add(txtEMPCity)
        Panel1.Controls.Add(txtEMPStreet)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtEMPLName)
        Panel1.Controls.Add(txtEMPMName)
        Panel1.Controls.Add(txtEMPFName)
        Panel1.Location = New Point(0, 122)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1065, 580)
        Panel1.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(18, 255)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 20)
        Label10.TabIndex = 33
        Label10.Text = "Street"
        ' 
        ' btnCANCEL
        ' 
        btnCANCEL.BackColor = Color.MistyRose
        btnCANCEL.FlatStyle = FlatStyle.Flat
        btnCANCEL.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCANCEL.ForeColor = Color.Firebrick
        btnCANCEL.Location = New Point(735, 510)
        btnCANCEL.Margin = New Padding(4, 4, 4, 4)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.Size = New Size(153, 56)
        btnCANCEL.TabIndex = 21
        btnCANCEL.Text = "CANCEL"
        btnCANCEL.UseVisualStyleBackColor = False
        ' 
        ' ADMEditEMP
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1065, 800)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(btnSAVE)
        Controls.Add(Panel1)
        Controls.Add(btnCANCEL)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ADMEditEMP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMEditEMP"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtEMPIndustry As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEMPState As TextBox
    Friend WithEvents txtEMPCity As TextBox
    Friend WithEvents txtEMPStreet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEMPLName As TextBox
    Friend WithEvents txtEMPMName As TextBox
    Friend WithEvents txtEMPFName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEMPCountry As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEMPCompanyName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEMPEmail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEMPContNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEMPZip As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSAVE As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCANCEL As Button
End Class
