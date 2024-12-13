<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMEditAGC
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
        txtEditAGCYrInOp = New TextBox()
        cbxEditAGCAccredStat = New ComboBox()
        btnSAVE = New Button()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label16 = New Label()
        txtEditAGCWebsite = New TextBox()
        Label15 = New Label()
        txtEditAGCEmail = New TextBox()
        Label14 = New Label()
        txtEditAGCContNum = New TextBox()
        Label13 = New Label()
        txtEditAGCZip = New TextBox()
        Label12 = New Label()
        txtEditAGCCountry = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtEditAGCState = New TextBox()
        txtEditAGCCity = New TextBox()
        txtEditAGCStreet = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtEditAGCSpec = New TextBox()
        txtEditAGCLicNum = New TextBox()
        txtEditAGCFName = New TextBox()
        btnCANCEL = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtEditAGCYrInOp
        ' 
        txtEditAGCYrInOp.Location = New Point(629, 123)
        txtEditAGCYrInOp.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCYrInOp.Name = "txtEditAGCYrInOp"
        txtEditAGCYrInOp.PlaceholderText = "###"
        txtEditAGCYrInOp.Size = New Size(137, 29)
        txtEditAGCYrInOp.TabIndex = 52
        ' 
        ' cbxEditAGCAccredStat
        ' 
        cbxEditAGCAccredStat.FormattingEnabled = True
        cbxEditAGCAccredStat.Location = New Point(330, 123)
        cbxEditAGCAccredStat.Margin = New Padding(4, 4, 4, 4)
        cbxEditAGCAccredStat.Name = "cbxEditAGCAccredStat"
        cbxEditAGCAccredStat.Size = New Size(280, 29)
        cbxEditAGCAccredStat.TabIndex = 51
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
        btnSAVE.TabIndex = 25
        btnSAVE.Text = "SAVE"
        btnSAVE.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtEditAGCYrInOp)
        Panel1.Controls.Add(cbxEditAGCAccredStat)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(txtEditAGCWebsite)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtEditAGCEmail)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtEditAGCContNum)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtEditAGCZip)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtEditAGCCountry)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtEditAGCState)
        Panel1.Controls.Add(txtEditAGCCity)
        Panel1.Controls.Add(txtEditAGCStreet)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtEditAGCSpec)
        Panel1.Controls.Add(txtEditAGCLicNum)
        Panel1.Controls.Add(txtEditAGCFName)
        Panel1.Location = New Point(0, 122)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1065, 580)
        Panel1.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(629, 98)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 20)
        Label7.TabIndex = 53
        Label7.Text = "Years in Operation"
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
        ' txtEditAGCWebsite
        ' 
        txtEditAGCWebsite.Location = New Point(15, 123)
        txtEditAGCWebsite.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCWebsite.Name = "txtEditAGCWebsite"
        txtEditAGCWebsite.PlaceholderText = "URL"
        txtEditAGCWebsite.Size = New Size(280, 29)
        txtEditAGCWebsite.TabIndex = 43
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(330, 172)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 20)
        Label15.TabIndex = 42
        Label15.Text = "E-mail"
        ' 
        ' txtEditAGCEmail
        ' 
        txtEditAGCEmail.Location = New Point(330, 197)
        txtEditAGCEmail.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCEmail.Name = "txtEditAGCEmail"
        txtEditAGCEmail.PlaceholderText = "E-mail"
        txtEditAGCEmail.Size = New Size(280, 29)
        txtEditAGCEmail.TabIndex = 41
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(18, 172)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(125, 20)
        Label14.TabIndex = 40
        Label14.Text = "Contact Number"
        ' 
        ' txtEditAGCContNum
        ' 
        txtEditAGCContNum.Location = New Point(15, 197)
        txtEditAGCContNum.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCContNum.Name = "txtEditAGCContNum"
        txtEditAGCContNum.PlaceholderText = "Contact Number"
        txtEditAGCContNum.Size = New Size(280, 29)
        txtEditAGCContNum.TabIndex = 39
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(330, 331)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 20)
        Label13.TabIndex = 38
        Label13.Text = "Zipcode"
        ' 
        ' txtEditAGCZip
        ' 
        txtEditAGCZip.Location = New Point(330, 356)
        txtEditAGCZip.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCZip.Name = "txtEditAGCZip"
        txtEditAGCZip.PlaceholderText = "Zipcode"
        txtEditAGCZip.Size = New Size(91, 29)
        txtEditAGCZip.TabIndex = 37
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(18, 331)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(66, 20)
        Label12.TabIndex = 36
        Label12.Text = "Country"
        ' 
        ' txtEditAGCCountry
        ' 
        txtEditAGCCountry.Location = New Point(15, 356)
        txtEditAGCCountry.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCCountry.Name = "txtEditAGCCountry"
        txtEditAGCCountry.PlaceholderText = "Country"
        txtEditAGCCountry.Size = New Size(280, 29)
        txtEditAGCCountry.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(629, 254)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(45, 20)
        Label9.TabIndex = 34
        Label9.Text = "State"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(15, 254)
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
        Label11.Location = New Point(330, 255)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 20)
        Label11.TabIndex = 32
        Label11.Text = "City"
        ' 
        ' txtEditAGCState
        ' 
        txtEditAGCState.Location = New Point(629, 279)
        txtEditAGCState.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCState.Name = "txtEditAGCState"
        txtEditAGCState.PlaceholderText = "State"
        txtEditAGCState.Size = New Size(280, 29)
        txtEditAGCState.TabIndex = 31
        ' 
        ' txtEditAGCCity
        ' 
        txtEditAGCCity.Location = New Point(330, 279)
        txtEditAGCCity.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCCity.Name = "txtEditAGCCity"
        txtEditAGCCity.PlaceholderText = "City"
        txtEditAGCCity.Size = New Size(280, 29)
        txtEditAGCCity.TabIndex = 30
        ' 
        ' txtEditAGCStreet
        ' 
        txtEditAGCStreet.Location = New Point(15, 279)
        txtEditAGCStreet.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCStreet.Name = "txtEditAGCStreet"
        txtEditAGCStreet.PlaceholderText = "Street"
        txtEditAGCStreet.Size = New Size(280, 29)
        txtEditAGCStreet.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(629, 20)
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
        Label3.Location = New Point(330, 20)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 20
        Label3.Text = "License Number"
        ' 
        ' txtEditAGCSpec
        ' 
        txtEditAGCSpec.Location = New Point(629, 45)
        txtEditAGCSpec.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCSpec.Name = "txtEditAGCSpec"
        txtEditAGCSpec.PlaceholderText = "Specialization"
        txtEditAGCSpec.Size = New Size(280, 29)
        txtEditAGCSpec.TabIndex = 2
        ' 
        ' txtEditAGCLicNum
        ' 
        txtEditAGCLicNum.Location = New Point(330, 45)
        txtEditAGCLicNum.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCLicNum.Name = "txtEditAGCLicNum"
        txtEditAGCLicNum.PlaceholderText = "########"
        txtEditAGCLicNum.Size = New Size(280, 29)
        txtEditAGCLicNum.TabIndex = 1
        ' 
        ' txtEditAGCFName
        ' 
        txtEditAGCFName.Location = New Point(15, 45)
        txtEditAGCFName.Margin = New Padding(4, 4, 4, 4)
        txtEditAGCFName.Name = "txtEditAGCFName"
        txtEditAGCFName.PlaceholderText = "Agency Name"
        txtEditAGCFName.Size = New Size(280, 29)
        txtEditAGCFName.TabIndex = 0
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
        btnCANCEL.TabIndex = 26
        btnCANCEL.Text = "CANCEL"
        btnCANCEL.UseVisualStyleBackColor = False
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
        Label1.Size = New Size(168, 56)
        Label1.TabIndex = 23
        Label1.Text = ">EDIT"
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
        Label2.TabIndex = 24
        Label2.Text = "Agency"
        ' 
        ' ADMEditAGC
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1065, 800)
        Controls.Add(btnSAVE)
        Controls.Add(Panel1)
        Controls.Add(btnCANCEL)
        Controls.Add(Label1)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ADMEditAGC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMEditAGC"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEditAGCYrInOp As TextBox
    Friend WithEvents cbxEditAGCAccredStat As ComboBox
    Friend WithEvents btnSAVE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Private WithEvents txtEditAGCWebsite As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEditAGCEmail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEditAGCContNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEditAGCZip As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEditAGCCountry As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEditAGCState As TextBox
    Friend WithEvents txtEditAGCCity As TextBox
    Friend WithEvents txtEditAGCStreet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents txtEditAGCSpec As TextBox
    Private WithEvents txtEditAGCLicNum As TextBox
    Friend WithEvents txtEditAGCFName As TextBox
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
