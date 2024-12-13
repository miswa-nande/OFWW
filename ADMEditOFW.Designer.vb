<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMEditOFW
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
        Label1 = New Label()
        Label18 = New Label()
        txtbxEditOFWOECNum = New TextBox()
        Label17 = New Label()
        txtbxEditOFWVisaNum = New TextBox()
        Label16 = New Label()
        txtbxEditOFWPassportNum = New TextBox()
        Label15 = New Label()
        txtbxEditOFWEmrContNum = New TextBox()
        Label14 = New Label()
        txtbxEditOFWContNum = New TextBox()
        Label13 = New Label()
        txtbxEditOFWZip = New TextBox()
        Label12 = New Label()
        txtbxEditOFWProv = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        btnCANCEL = New Button()
        Label2 = New Label()
        txtbxEditOFWCity = New TextBox()
        txtbxEditOFWBrgy = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        cbxEditOFWCivStat = New ComboBox()
        cbxEditOFWGender = New ComboBox()
        dateEditOFWDOB = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtbxEditOFWLName = New TextBox()
        txtbxEditOFWMName = New TextBox()
        txtbxEditOFWFName = New TextBox()
        btnSAVE = New Button()
        txtbxEditOFWStreet = New TextBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(216, 50)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 56)
        Label1.TabIndex = 13
        Label1.Text = ">EDIT"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(18, 489)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(99, 20)
        Label18.TabIndex = 48
        Label18.Text = "OEC Number"
        ' 
        ' txtbxEditOFWOECNum
        ' 
        txtbxEditOFWOECNum.Location = New Point(18, 514)
        txtbxEditOFWOECNum.Margin = New Padding(4)
        txtbxEditOFWOECNum.Name = "txtbxEditOFWOECNum"
        txtbxEditOFWOECNum.PlaceholderText = "OEC Number"
        txtbxEditOFWOECNum.Size = New Size(277, 29)
        txtbxEditOFWOECNum.TabIndex = 47
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(18, 419)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(105, 20)
        Label17.TabIndex = 46
        Label17.Text = "VISA Number"
        ' 
        ' txtbxEditOFWVisaNum
        ' 
        txtbxEditOFWVisaNum.Location = New Point(18, 444)
        txtbxEditOFWVisaNum.Margin = New Padding(4)
        txtbxEditOFWVisaNum.Name = "txtbxEditOFWVisaNum"
        txtbxEditOFWVisaNum.PlaceholderText = "VISA Number"
        txtbxEditOFWVisaNum.Size = New Size(277, 29)
        txtbxEditOFWVisaNum.TabIndex = 45
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(15, 349)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(132, 20)
        Label16.TabIndex = 44
        Label16.Text = "Passport Number"
        ' 
        ' txtbxEditOFWPassportNum
        ' 
        txtbxEditOFWPassportNum.Location = New Point(15, 374)
        txtbxEditOFWPassportNum.Margin = New Padding(4)
        txtbxEditOFWPassportNum.Name = "txtbxEditOFWPassportNum"
        txtbxEditOFWPassportNum.PlaceholderText = "Passport Number"
        txtbxEditOFWPassportNum.Size = New Size(280, 29)
        txtbxEditOFWPassportNum.TabIndex = 43
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(330, 419)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(144, 20)
        Label15.TabIndex = 42
        Label15.Text = "Emergency Contact"
        ' 
        ' txtbxEditOFWEmrContNum
        ' 
        txtbxEditOFWEmrContNum.Location = New Point(330, 444)
        txtbxEditOFWEmrContNum.Margin = New Padding(4)
        txtbxEditOFWEmrContNum.Name = "txtbxEditOFWEmrContNum"
        txtbxEditOFWEmrContNum.PlaceholderText = "Emergency Contact"
        txtbxEditOFWEmrContNum.Size = New Size(280, 29)
        txtbxEditOFWEmrContNum.TabIndex = 41
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(330, 349)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 20)
        Label14.TabIndex = 40
        Label14.Text = "Contact Number"
        ' 
        ' txtbxEditOFWContNum
        ' 
        txtbxEditOFWContNum.Location = New Point(330, 374)
        txtbxEditOFWContNum.Margin = New Padding(4)
        txtbxEditOFWContNum.Name = "txtbxEditOFWContNum"
        txtbxEditOFWContNum.PlaceholderText = "Contact Number"
        txtbxEditOFWContNum.Size = New Size(280, 29)
        txtbxEditOFWContNum.TabIndex = 39
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(330, 267)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 20)
        Label13.TabIndex = 38
        Label13.Text = "Zipcode"
        ' 
        ' txtbxEditOFWZip
        ' 
        txtbxEditOFWZip.Location = New Point(330, 292)
        txtbxEditOFWZip.Margin = New Padding(4)
        txtbxEditOFWZip.Name = "txtbxEditOFWZip"
        txtbxEditOFWZip.PlaceholderText = "Zipcode"
        txtbxEditOFWZip.Size = New Size(91, 29)
        txtbxEditOFWZip.TabIndex = 37
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(18, 258)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 20)
        Label12.TabIndex = 36
        Label12.Text = "Province"
        ' 
        ' txtbxEditOFWProv
        ' 
        txtbxEditOFWProv.Location = New Point(18, 283)
        txtbxEditOFWProv.Margin = New Padding(4)
        txtbxEditOFWProv.Name = "txtbxEditOFWProv"
        txtbxEditOFWProv.PlaceholderText = "Province"
        txtbxEditOFWProv.Size = New Size(277, 29)
        txtbxEditOFWProv.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(629, 179)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(129, 20)
        Label9.TabIndex = 34
        Label9.Text = "City/Municipality"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(18, 179)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(51, 20)
        Label10.TabIndex = 33
        Label10.Text = "Street"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(330, 179)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 20)
        Label11.TabIndex = 32
        Label11.Text = "Barangay"
        ' 
        ' btnCANCEL
        ' 
        btnCANCEL.BackColor = Color.MistyRose
        btnCANCEL.FlatStyle = FlatStyle.Flat
        btnCANCEL.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCANCEL.ForeColor = Color.Firebrick
        btnCANCEL.Location = New Point(739, 718)
        btnCANCEL.Margin = New Padding(4)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.Size = New Size(153, 56)
        btnCANCEL.TabIndex = 16
        btnCANCEL.Text = "CANCEL"
        btnCANCEL.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(1, 14)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 96)
        Label2.TabIndex = 14
        Label2.Text = "OFW"
        ' 
        ' txtbxEditOFWCity
        ' 
        txtbxEditOFWCity.Location = New Point(629, 204)
        txtbxEditOFWCity.Margin = New Padding(4)
        txtbxEditOFWCity.Name = "txtbxEditOFWCity"
        txtbxEditOFWCity.PlaceholderText = "City/Municipality"
        txtbxEditOFWCity.Size = New Size(280, 29)
        txtbxEditOFWCity.TabIndex = 31
        ' 
        ' txtbxEditOFWBrgy
        ' 
        txtbxEditOFWBrgy.Location = New Point(330, 204)
        txtbxEditOFWBrgy.Margin = New Padding(4)
        txtbxEditOFWBrgy.Name = "txtbxEditOFWBrgy"
        txtbxEditOFWBrgy.PlaceholderText = "Barangay"
        txtbxEditOFWBrgy.Size = New Size(280, 29)
        txtbxEditOFWBrgy.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(15, 102)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 20)
        Label8.TabIndex = 28
        Label8.Text = "Date of BIrth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(330, 102)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 27
        Label7.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(629, 102)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 26
        Label6.Text = "Civil Status"
        ' 
        ' cbxEditOFWCivStat
        ' 
        cbxEditOFWCivStat.FormattingEnabled = True
        cbxEditOFWCivStat.Location = New Point(629, 127)
        cbxEditOFWCivStat.Margin = New Padding(4)
        cbxEditOFWCivStat.Name = "cbxEditOFWCivStat"
        cbxEditOFWCivStat.Size = New Size(192, 29)
        cbxEditOFWCivStat.TabIndex = 25
        ' 
        ' cbxEditOFWGender
        ' 
        cbxEditOFWGender.FormattingEnabled = True
        cbxEditOFWGender.Location = New Point(330, 127)
        cbxEditOFWGender.Margin = New Padding(4)
        cbxEditOFWGender.Name = "cbxEditOFWGender"
        cbxEditOFWGender.Size = New Size(192, 29)
        cbxEditOFWGender.TabIndex = 24
        ' 
        ' dateEditOFWDOB
        ' 
        dateEditOFWDOB.Format = DateTimePickerFormat.Short
        dateEditOFWDOB.Location = New Point(15, 127)
        dateEditOFWDOB.Margin = New Padding(4)
        dateEditOFWDOB.Name = "dateEditOFWDOB"
        dateEditOFWDOB.Size = New Size(192, 29)
        dateEditOFWDOB.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(631, 21)
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
        Label3.Location = New Point(330, 21)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 20
        Label3.Text = "Middle Name"
        ' 
        ' txtbxEditOFWLName
        ' 
        txtbxEditOFWLName.Location = New Point(629, 45)
        txtbxEditOFWLName.Margin = New Padding(4)
        txtbxEditOFWLName.Name = "txtbxEditOFWLName"
        txtbxEditOFWLName.PlaceholderText = "Last Name"
        txtbxEditOFWLName.Size = New Size(280, 29)
        txtbxEditOFWLName.TabIndex = 2
        ' 
        ' txtbxEditOFWMName
        ' 
        txtbxEditOFWMName.Location = New Point(330, 45)
        txtbxEditOFWMName.Margin = New Padding(4)
        txtbxEditOFWMName.Name = "txtbxEditOFWMName"
        txtbxEditOFWMName.PlaceholderText = "Middle Name"
        txtbxEditOFWMName.Size = New Size(280, 29)
        txtbxEditOFWMName.TabIndex = 1
        ' 
        ' txtbxEditOFWFName
        ' 
        txtbxEditOFWFName.Location = New Point(15, 45)
        txtbxEditOFWFName.Margin = New Padding(4)
        txtbxEditOFWFName.Name = "txtbxEditOFWFName"
        txtbxEditOFWFName.PlaceholderText = "First Name"
        txtbxEditOFWFName.Size = New Size(280, 29)
        txtbxEditOFWFName.TabIndex = 0
        ' 
        ' btnSAVE
        ' 
        btnSAVE.BackColor = Color.PaleGreen
        btnSAVE.FlatStyle = FlatStyle.Flat
        btnSAVE.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSAVE.ForeColor = Color.DarkGreen
        btnSAVE.Location = New Point(900, 718)
        btnSAVE.Margin = New Padding(4)
        btnSAVE.Name = "btnSAVE"
        btnSAVE.Size = New Size(153, 56)
        btnSAVE.TabIndex = 15
        btnSAVE.Text = "SAVE"
        btnSAVE.UseVisualStyleBackColor = False
        ' 
        ' txtbxEditOFWStreet
        ' 
        txtbxEditOFWStreet.Location = New Point(18, 204)
        txtbxEditOFWStreet.Margin = New Padding(4)
        txtbxEditOFWStreet.Name = "txtbxEditOFWStreet"
        txtbxEditOFWStreet.PlaceholderText = "Street"
        txtbxEditOFWStreet.Size = New Size(277, 29)
        txtbxEditOFWStreet.TabIndex = 29
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(txtbxEditOFWOECNum)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(txtbxEditOFWVisaNum)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(txtbxEditOFWPassportNum)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtbxEditOFWEmrContNum)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtbxEditOFWContNum)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtbxEditOFWZip)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtbxEditOFWProv)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtbxEditOFWCity)
        Panel1.Controls.Add(txtbxEditOFWBrgy)
        Panel1.Controls.Add(txtbxEditOFWStreet)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(cbxEditOFWCivStat)
        Panel1.Controls.Add(cbxEditOFWGender)
        Panel1.Controls.Add(dateEditOFWDOB)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtbxEditOFWLName)
        Panel1.Controls.Add(txtbxEditOFWMName)
        Panel1.Controls.Add(txtbxEditOFWFName)
        Panel1.Location = New Point(0, 122)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1079, 581)
        Panel1.TabIndex = 12
        ' 
        ' ADMEditOFW
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1080, 800)
        Controls.Add(Label1)
        Controls.Add(btnCANCEL)
        Controls.Add(Label2)
        Controls.Add(btnSAVE)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ADMEditOFW"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMEditOFW"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtbxEditOFWOECNum As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtbxEditOFWVisaNum As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtbxEditOFWPassportNum As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtbxEditOFWEmrContNum As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbxEditOFWContNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbxEditOFWZip As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbxEditOFWProv As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxEditOFWCity As TextBox
    Friend WithEvents txtbxEditOFWBrgy As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxEditOFWCivStat As ComboBox
    Friend WithEvents cbxEditOFWGender As ComboBox
    Friend WithEvents dateEditOFWDOB As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxEditOFWLName As TextBox
    Friend WithEvents txtbxEditOFWMName As TextBox
    Friend WithEvents txtbxEditOFWFName As TextBox
    Friend WithEvents btnSAVE As Button
    Friend WithEvents txtbxEditOFWStreet As TextBox
    Friend WithEvents Panel1 As Panel
End Class
