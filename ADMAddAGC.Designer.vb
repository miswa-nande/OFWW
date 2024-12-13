<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMAddAGC
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
        Label11 = New Label()
        txtAGCState = New TextBox()
        txtAGCCity = New TextBox()
        txtAGCStreet = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtAGCSpec = New TextBox()
        txtAGCLicNum = New TextBox()
        txtAGCFName = New TextBox()
        Label1 = New Label()
        txtAGCCountry = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        txtAGCWebsite = New TextBox()
        Label15 = New Label()
        txtAGCEmail = New TextBox()
        Label14 = New Label()
        txtAGCContNum = New TextBox()
        Label13 = New Label()
        txtAGCZip = New TextBox()
        Label12 = New Label()
        btnADD = New Button()
        Label16 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        dateAGCExp = New DateTimePicker()
        Label7 = New Label()
        txtAGCYrInOp = New TextBox()
        cbxAGCAccredStat = New ComboBox()
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
        Label6.Size = New Size(195, 20)
        Label6.TabIndex = 50
        Label6.Text = "Government Accreditation"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(330, 256)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 20)
        Label11.TabIndex = 32
        Label11.Text = "City"
        ' 
        ' txtAGCState
        ' 
        txtAGCState.Location = New Point(629, 281)
        txtAGCState.Margin = New Padding(4)
        txtAGCState.Name = "txtAGCState"
        txtAGCState.PlaceholderText = "State"
        txtAGCState.Size = New Size(280, 29)
        txtAGCState.TabIndex = 31
        ' 
        ' txtAGCCity
        ' 
        txtAGCCity.Location = New Point(330, 281)
        txtAGCCity.Margin = New Padding(4)
        txtAGCCity.Name = "txtAGCCity"
        txtAGCCity.PlaceholderText = "City"
        txtAGCCity.Size = New Size(280, 29)
        txtAGCCity.TabIndex = 30
        ' 
        ' txtAGCStreet
        ' 
        txtAGCStreet.Location = New Point(15, 281)
        txtAGCStreet.Margin = New Padding(4)
        txtAGCStreet.Name = "txtAGCStreet"
        txtAGCStreet.PlaceholderText = "Street"
        txtAGCStreet.Size = New Size(280, 29)
        txtAGCStreet.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(629, 21)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 20)
        Label5.TabIndex = 22
        Label5.Text = "Specialization"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(15, 20)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 20)
        Label4.TabIndex = 21
        Label4.Text = "Agency Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(331, 21)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 20
        Label3.Text = "License Number"
        ' 
        ' txtAGCSpec
        ' 
        txtAGCSpec.Location = New Point(629, 45)
        txtAGCSpec.Margin = New Padding(4)
        txtAGCSpec.Name = "txtAGCSpec"
        txtAGCSpec.PlaceholderText = "Specialization"
        txtAGCSpec.Size = New Size(280, 29)
        txtAGCSpec.TabIndex = 2
        ' 
        ' txtAGCLicNum
        ' 
        txtAGCLicNum.Location = New Point(330, 45)
        txtAGCLicNum.Margin = New Padding(4)
        txtAGCLicNum.Name = "txtAGCLicNum"
        txtAGCLicNum.PlaceholderText = "########"
        txtAGCLicNum.Size = New Size(280, 29)
        txtAGCLicNum.TabIndex = 1
        ' 
        ' txtAGCFName
        ' 
        txtAGCFName.Location = New Point(15, 45)
        txtAGCFName.Margin = New Padding(4)
        txtAGCFName.Name = "txtAGCFName"
        txtAGCFName.PlaceholderText = "Agency Name"
        txtAGCFName.Size = New Size(280, 29)
        txtAGCFName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(287, 57)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 56)
        Label1.TabIndex = 18
        Label1.Text = ">ADD"
        ' 
        ' txtAGCCountry
        ' 
        txtAGCCountry.Location = New Point(15, 355)
        txtAGCCountry.Margin = New Padding(4)
        txtAGCCountry.Name = "txtAGCCountry"
        txtAGCCountry.PlaceholderText = "Country"
        txtAGCCountry.Size = New Size(280, 29)
        txtAGCCountry.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(629, 256)
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
        Label2.Size = New Size(299, 96)
        Label2.TabIndex = 19
        Label2.Text = "Agency"
        ' 
        ' txtAGCWebsite
        ' 
        txtAGCWebsite.Location = New Point(15, 123)
        txtAGCWebsite.Margin = New Padding(4)
        txtAGCWebsite.Name = "txtAGCWebsite"
        txtAGCWebsite.PlaceholderText = "URL"
        txtAGCWebsite.Size = New Size(280, 29)
        txtAGCWebsite.TabIndex = 43
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(331, 177)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 20)
        Label15.TabIndex = 42
        Label15.Text = "E-mail"
        ' 
        ' txtAGCEmail
        ' 
        txtAGCEmail.Location = New Point(331, 202)
        txtAGCEmail.Margin = New Padding(4)
        txtAGCEmail.Name = "txtAGCEmail"
        txtAGCEmail.PlaceholderText = "E-mail"
        txtAGCEmail.Size = New Size(280, 29)
        txtAGCEmail.TabIndex = 41
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(15, 177)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 20)
        Label14.TabIndex = 40
        Label14.Text = "Contact Number"
        ' 
        ' txtAGCContNum
        ' 
        txtAGCContNum.Location = New Point(15, 202)
        txtAGCContNum.Margin = New Padding(4)
        txtAGCContNum.Name = "txtAGCContNum"
        txtAGCContNum.PlaceholderText = "Contact Number"
        txtAGCContNum.Size = New Size(280, 29)
        txtAGCContNum.TabIndex = 39
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(330, 330)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 20)
        Label13.TabIndex = 38
        Label13.Text = "Zipcode"
        ' 
        ' txtAGCZip
        ' 
        txtAGCZip.Location = New Point(330, 355)
        txtAGCZip.Margin = New Padding(4)
        txtAGCZip.Name = "txtAGCZip"
        txtAGCZip.PlaceholderText = "Zipcode"
        txtAGCZip.Size = New Size(91, 29)
        txtAGCZip.TabIndex = 37
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(15, 330)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(66, 20)
        Label12.TabIndex = 36
        Label12.Text = "Country"
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.PaleGreen
        btnADD.FlatStyle = FlatStyle.Flat
        btnADD.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnADD.ForeColor = Color.DarkGreen
        btnADD.Location = New Point(896, 510)
        btnADD.Margin = New Padding(4)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(153, 56)
        btnADD.TabIndex = 20
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(18, 98)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(66, 20)
        Label16.TabIndex = 44
        Label16.Text = "Website"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(dateAGCExp)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtAGCYrInOp)
        Panel1.Controls.Add(cbxAGCAccredStat)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(txtAGCWebsite)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtAGCEmail)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtAGCContNum)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtAGCZip)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtAGCCountry)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtAGCState)
        Panel1.Controls.Add(txtAGCCity)
        Panel1.Controls.Add(txtAGCStreet)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtAGCSpec)
        Panel1.Controls.Add(txtAGCLicNum)
        Panel1.Controls.Add(txtAGCFName)
        Panel1.Location = New Point(0, 122)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1065, 580)
        Panel1.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(629, 98)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 20)
        Label8.TabIndex = 55
        Label8.Text = "License Exp Date"
        ' 
        ' dateAGCExp
        ' 
        dateAGCExp.Format = DateTimePickerFormat.Short
        dateAGCExp.Location = New Point(629, 123)
        dateAGCExp.Margin = New Padding(4)
        dateAGCExp.Name = "dateAGCExp"
        dateAGCExp.Size = New Size(149, 29)
        dateAGCExp.TabIndex = 54
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(629, 177)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 20)
        Label7.TabIndex = 53
        Label7.Text = "Years in Operation"
        ' 
        ' txtAGCYrInOp
        ' 
        txtAGCYrInOp.Location = New Point(629, 202)
        txtAGCYrInOp.Margin = New Padding(4)
        txtAGCYrInOp.Name = "txtAGCYrInOp"
        txtAGCYrInOp.PlaceholderText = "###"
        txtAGCYrInOp.Size = New Size(149, 29)
        txtAGCYrInOp.TabIndex = 52
        ' 
        ' cbxAGCAccredStat
        ' 
        cbxAGCAccredStat.FormattingEnabled = True
        cbxAGCAccredStat.Location = New Point(330, 123)
        cbxAGCAccredStat.Margin = New Padding(4)
        cbxAGCAccredStat.Name = "cbxAGCAccredStat"
        cbxAGCAccredStat.Size = New Size(280, 29)
        cbxAGCAccredStat.TabIndex = 51
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(15, 256)
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
        btnCANCEL.Margin = New Padding(4)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.Size = New Size(153, 56)
        btnCANCEL.TabIndex = 21
        btnCANCEL.Text = "CANCEL"
        btnCANCEL.UseVisualStyleBackColor = False
        ' 
        ' ADMAddAGC
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1065, 800)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(btnADD)
        Controls.Add(Panel1)
        Controls.Add(btnCANCEL)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ADMAddAGC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMAddAGC"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtEMPIndustry As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAGCState As TextBox
    Friend WithEvents txtAGCCity As TextBox
    Friend WithEvents txtAGCStreet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Private txtAGCSpec As TextBox
    Private txtAGCLicNum As TextBox
    Private txtAGCFName As TextBox
    Private WithEvents txtEMPLName As TextBox
    Private WithEvents txtEMPMName As TextBox
    Friend WithEvents txtEMPFName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAGCCountry As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents txtAGCWebsite As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAGCEmail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAGCContNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAGCZip As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnADD As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAGCYrInOp As TextBox
    Friend WithEvents cbxAGCAccredStat As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dateAGCExp As DateTimePicker
End Class
