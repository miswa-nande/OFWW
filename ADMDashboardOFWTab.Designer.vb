<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMDashboardOFWTab
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
        Panel1 = New Panel()
        btnADMDashSTAT = New Button()
        PictureBox1 = New PictureBox()
        btnADMDashDEP = New Button()
        btnADMDashJOB = New Button()
        btnADMDashOFW = New Button()
        btnADMDashAGC = New Button()
        btnADMDashEMP = New Button()
        btnCLose = New Button()
        Label1 = New Label()
        Panel4 = New Panel()
        dgvOFW = New DataGridView()
        btnLogout = New Button()
        Label2 = New Label()
        txtbxOFWIdFilt = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtbxOFWFNameFilt = New TextBox()
        Label5 = New Label()
        txtbxOFWMNameFilt = New TextBox()
        Label6 = New Label()
        txtbxOFWLNameFilt = New TextBox()
        cbxOFWGenderFilt = New ComboBox()
        cbxOFWCivStatFilt = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtbxOFWZipFilt = New TextBox()
        Label10 = New Label()
        txtbxOFWOECFilt = New TextBox()
        Label11 = New Label()
        txtbxOFWVisaFilt = New TextBox()
        chkOFWEmpStatFilt = New CheckBox()
        btnFilter = New Button()
        btnADD = New Button()
        btnEDIT = New Button()
        btnGEN = New Button()
        btnDLT = New Button()
        Label12 = New Label()
        lblOFWTally = New Label()
        btnClearFilter = New Button()
        Label13 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOFW, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(btnADMDashSTAT)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnADMDashDEP)
        Panel1.Controls.Add(btnADMDashJOB)
        Panel1.Controls.Add(btnADMDashOFW)
        Panel1.Controls.Add(btnADMDashAGC)
        Panel1.Controls.Add(btnADMDashEMP)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(0, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(337, 1084)
        Panel1.TabIndex = 3
        ' 
        ' btnADMDashSTAT
        ' 
        btnADMDashSTAT.BackColor = Color.RoyalBlue
        btnADMDashSTAT.FlatAppearance.BorderSize = 0
        btnADMDashSTAT.FlatStyle = FlatStyle.Flat
        btnADMDashSTAT.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashSTAT.ForeColor = Color.MidnightBlue
        btnADMDashSTAT.Location = New Point(52, 690)
        btnADMDashSTAT.Name = "btnADMDashSTAT"
        btnADMDashSTAT.Size = New Size(237, 45)
        btnADMDashSTAT.TabIndex = 45
        btnADMDashSTAT.Text = "Statistics"
        btnADMDashSTAT.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Untitled_design__8_
        PictureBox1.Location = New Point(12, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 335)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnADMDashDEP
        ' 
        btnADMDashDEP.BackColor = Color.RoyalBlue
        btnADMDashDEP.FlatAppearance.BorderSize = 0
        btnADMDashDEP.FlatStyle = FlatStyle.Flat
        btnADMDashDEP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashDEP.ForeColor = Color.MidnightBlue
        btnADMDashDEP.Location = New Point(52, 626)
        btnADMDashDEP.Name = "btnADMDashDEP"
        btnADMDashDEP.Size = New Size(237, 45)
        btnADMDashDEP.TabIndex = 44
        btnADMDashDEP.Text = "Deployments"
        btnADMDashDEP.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashJOB
        ' 
        btnADMDashJOB.BackColor = Color.RoyalBlue
        btnADMDashJOB.FlatAppearance.BorderSize = 0
        btnADMDashJOB.FlatStyle = FlatStyle.Flat
        btnADMDashJOB.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashJOB.ForeColor = Color.MidnightBlue
        btnADMDashJOB.Location = New Point(52, 561)
        btnADMDashJOB.Name = "btnADMDashJOB"
        btnADMDashJOB.Size = New Size(237, 45)
        btnADMDashJOB.TabIndex = 43
        btnADMDashJOB.Text = "Job Placements"
        btnADMDashJOB.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashOFW
        ' 
        btnADMDashOFW.BackColor = Color.DeepSkyBlue
        btnADMDashOFW.FlatAppearance.BorderSize = 0
        btnADMDashOFW.FlatStyle = FlatStyle.Flat
        btnADMDashOFW.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashOFW.ForeColor = Color.MidnightBlue
        btnADMDashOFW.Location = New Point(52, 371)
        btnADMDashOFW.Name = "btnADMDashOFW"
        btnADMDashOFW.Size = New Size(285, 45)
        btnADMDashOFW.TabIndex = 40
        btnADMDashOFW.Text = "OFWs"
        btnADMDashOFW.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashAGC
        ' 
        btnADMDashAGC.BackColor = Color.RoyalBlue
        btnADMDashAGC.FlatAppearance.BorderSize = 0
        btnADMDashAGC.FlatStyle = FlatStyle.Flat
        btnADMDashAGC.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashAGC.ForeColor = Color.MidnightBlue
        btnADMDashAGC.Location = New Point(52, 494)
        btnADMDashAGC.Name = "btnADMDashAGC"
        btnADMDashAGC.Size = New Size(237, 45)
        btnADMDashAGC.TabIndex = 42
        btnADMDashAGC.Text = "Agencies"
        btnADMDashAGC.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashEMP
        ' 
        btnADMDashEMP.BackColor = Color.RoyalBlue
        btnADMDashEMP.FlatAppearance.BorderSize = 0
        btnADMDashEMP.FlatStyle = FlatStyle.Flat
        btnADMDashEMP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashEMP.ForeColor = Color.MidnightBlue
        btnADMDashEMP.Location = New Point(52, 433)
        btnADMDashEMP.Name = "btnADMDashEMP"
        btnADMDashEMP.Size = New Size(237, 45)
        btnADMDashEMP.TabIndex = 41
        btnADMDashEMP.Text = "Employers"
        btnADMDashEMP.UseVisualStyleBackColor = False
        ' 
        ' btnCLose
        ' 
        btnCLose.BackColor = Color.Crimson
        btnCLose.FlatAppearance.BorderSize = 0
        btnCLose.FlatStyle = FlatStyle.Flat
        btnCLose.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCLose.ForeColor = Color.MistyRose
        btnCLose.Location = New Point(1836, 12)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(72, 21)
        btnCLose.TabIndex = 5
        btnCLose.Text = "CLOSE"
        btnCLose.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(345, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 96)
        Label1.TabIndex = 7
        Label1.Text = "OFWs"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MidnightBlue
        Panel4.Location = New Point(335, 118)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1587, 22)
        Panel4.TabIndex = 6
        ' 
        ' dgvOFW
        ' 
        dgvOFW.BackgroundColor = SystemColors.ActiveCaption
        dgvOFW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOFW.Location = New Point(348, 155)
        dgvOFW.Name = "dgvOFW"
        dgvOFW.RowHeadersWidth = 51
        dgvOFW.Size = New Size(1306, 888)
        dgvOFW.TabIndex = 8
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightSlateGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(1767, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(63, 21)
        btnLogout.TabIndex = 9
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1660, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 43)
        Label2.TabIndex = 10
        Label2.Text = "Filter Search"
        ' 
        ' txtbxOFWIdFilt
        ' 
        txtbxOFWIdFilt.Location = New Point(1767, 253)
        txtbxOFWIdFilt.Name = "txtbxOFWIdFilt"
        txtbxOFWIdFilt.PlaceholderText = "#####"
        txtbxOFWIdFilt.Size = New Size(57, 27)
        txtbxOFWIdFilt.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1669, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 20)
        Label3.TabIndex = 12
        Label3.Text = "OFW ID Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1669, 336)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 14
        Label4.Text = "First Name"
        ' 
        ' txtbxOFWFNameFilt
        ' 
        txtbxOFWFNameFilt.Location = New Point(1669, 306)
        txtbxOFWFNameFilt.Name = "txtbxOFWFNameFilt"
        txtbxOFWFNameFilt.PlaceholderText = "First Name"
        txtbxOFWFNameFilt.Size = New Size(227, 27)
        txtbxOFWFNameFilt.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1669, 395)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 16
        Label5.Text = "Middle Name"
        ' 
        ' txtbxOFWMNameFilt
        ' 
        txtbxOFWMNameFilt.Location = New Point(1669, 359)
        txtbxOFWMNameFilt.Name = "txtbxOFWMNameFilt"
        txtbxOFWMNameFilt.PlaceholderText = "Middle Name"
        txtbxOFWMNameFilt.Size = New Size(227, 27)
        txtbxOFWMNameFilt.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1669, 449)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 20)
        Label6.TabIndex = 18
        Label6.Text = "Last Name"
        ' 
        ' txtbxOFWLNameFilt
        ' 
        txtbxOFWLNameFilt.Location = New Point(1669, 419)
        txtbxOFWLNameFilt.Name = "txtbxOFWLNameFilt"
        txtbxOFWLNameFilt.PlaceholderText = "Last Name"
        txtbxOFWLNameFilt.Size = New Size(227, 27)
        txtbxOFWLNameFilt.TabIndex = 17
        ' 
        ' cbxOFWGenderFilt
        ' 
        cbxOFWGenderFilt.FormattingEnabled = True
        cbxOFWGenderFilt.Location = New Point(1669, 472)
        cbxOFWGenderFilt.Name = "cbxOFWGenderFilt"
        cbxOFWGenderFilt.Size = New Size(114, 28)
        cbxOFWGenderFilt.TabIndex = 19
        ' 
        ' cbxOFWCivStatFilt
        ' 
        cbxOFWCivStatFilt.FormattingEnabled = True
        cbxOFWCivStatFilt.Location = New Point(1802, 472)
        cbxOFWCivStatFilt.Name = "cbxOFWCivStatFilt"
        cbxOFWCivStatFilt.Size = New Size(94, 28)
        cbxOFWCivStatFilt.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1669, 503)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 21
        Label7.Text = "Gender"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1812, 503)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 20)
        Label8.TabIndex = 22
        Label8.Text = "Civil Status"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(1669, 556)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 20)
        Label9.TabIndex = 24
        Label9.Text = "Zipcode"
        ' 
        ' txtbxOFWZipFilt
        ' 
        txtbxOFWZipFilt.Location = New Point(1669, 526)
        txtbxOFWZipFilt.Name = "txtbxOFWZipFilt"
        txtbxOFWZipFilt.PlaceholderText = "####"
        txtbxOFWZipFilt.Size = New Size(137, 27)
        txtbxOFWZipFilt.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(1669, 666)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 20)
        Label10.TabIndex = 26
        Label10.Text = "OEC Number"
        ' 
        ' txtbxOFWOECFilt
        ' 
        txtbxOFWOECFilt.Location = New Point(1669, 636)
        txtbxOFWOECFilt.Name = "txtbxOFWOECFilt"
        txtbxOFWOECFilt.PlaceholderText = "####"
        txtbxOFWOECFilt.Size = New Size(137, 27)
        txtbxOFWOECFilt.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(1669, 613)
        Label11.Name = "Label11"
        Label11.Size = New Size(105, 20)
        Label11.TabIndex = 28
        Label11.Text = "VISA Number"
        ' 
        ' txtbxOFWVisaFilt
        ' 
        txtbxOFWVisaFilt.Location = New Point(1669, 583)
        txtbxOFWVisaFilt.Name = "txtbxOFWVisaFilt"
        txtbxOFWVisaFilt.PlaceholderText = "####"
        txtbxOFWVisaFilt.Size = New Size(137, 27)
        txtbxOFWVisaFilt.TabIndex = 27
        ' 
        ' chkOFWEmpStatFilt
        ' 
        chkOFWEmpStatFilt.AutoSize = True
        chkOFWEmpStatFilt.Location = New Point(1812, 583)
        chkOFWEmpStatFilt.Name = "chkOFWEmpStatFilt"
        chkOFWEmpStatFilt.Size = New Size(100, 24)
        chkOFWEmpStatFilt.TabIndex = 30
        chkOFWEmpStatFilt.Text = "Employed"
        chkOFWEmpStatFilt.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Popup
        btnFilter.Location = New Point(1791, 832)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(76, 27)
        btnFilter.TabIndex = 31
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.LightCyan
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.ForeColor = Color.DarkBlue
        btnADD.Location = New Point(1709, 911)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(74, 54)
        btnADD.TabIndex = 32
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = Color.LightCyan
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.ForeColor = Color.DarkBlue
        btnEDIT.Location = New Point(1793, 911)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(74, 54)
        btnEDIT.TabIndex = 33
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnGEN
        ' 
        btnGEN.BackColor = Color.LightCyan
        btnGEN.FlatStyle = FlatStyle.Popup
        btnGEN.ForeColor = Color.DarkBlue
        btnGEN.Location = New Point(1793, 971)
        btnGEN.Name = "btnGEN"
        btnGEN.Size = New Size(74, 54)
        btnGEN.TabIndex = 34
        btnGEN.Text = "GENERATE"
        btnGEN.UseVisualStyleBackColor = False
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = Color.MistyRose
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.ForeColor = Color.DarkRed
        btnDLT.Location = New Point(1711, 971)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(74, 54)
        btnDLT.TabIndex = 35
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(1669, 875)
        Label12.Name = "Label12"
        Label12.Size = New Size(221, 20)
        Label12.TabIndex = 36
        Label12.Text = "Total number of OFWs shown:"
        ' 
        ' lblOFWTally
        ' 
        lblOFWTally.AutoSize = True
        lblOFWTally.Location = New Point(1890, 875)
        lblOFWTally.Name = "lblOFWTally"
        lblOFWTally.Size = New Size(18, 20)
        lblOFWTally.TabIndex = 37
        lblOFWTally.Text = "0"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.FlatStyle = FlatStyle.Popup
        btnClearFilter.Location = New Point(1709, 832)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(76, 27)
        btnClearFilter.TabIndex = 38
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(1712, 256)
        Label13.Name = "Label13"
        Label13.Size = New Size(49, 20)
        Label13.TabIndex = 39
        Label13.Text = "OFW-"
        ' 
        ' ADMDashboardOFWTab
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1055)
        Controls.Add(Label13)
        Controls.Add(btnClearFilter)
        Controls.Add(lblOFWTally)
        Controls.Add(Label12)
        Controls.Add(btnDLT)
        Controls.Add(btnGEN)
        Controls.Add(btnEDIT)
        Controls.Add(btnADD)
        Controls.Add(btnFilter)
        Controls.Add(chkOFWEmpStatFilt)
        Controls.Add(Label11)
        Controls.Add(txtbxOFWVisaFilt)
        Controls.Add(Label10)
        Controls.Add(txtbxOFWOECFilt)
        Controls.Add(Label9)
        Controls.Add(txtbxOFWZipFilt)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(cbxOFWCivStatFilt)
        Controls.Add(cbxOFWGenderFilt)
        Controls.Add(Label6)
        Controls.Add(txtbxOFWLNameFilt)
        Controls.Add(Label5)
        Controls.Add(txtbxOFWMNameFilt)
        Controls.Add(Label4)
        Controls.Add(txtbxOFWFNameFilt)
        Controls.Add(Label3)
        Controls.Add(txtbxOFWIdFilt)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Controls.Add(dgvOFW)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(btnCLose)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "ADMDashboardOFWTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "obs"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOFW, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCLose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvOFW As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxOFWIdFilt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbxOFWFNameFilt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxOFWMNameFilt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxOFWLNameFilt As TextBox
    Friend WithEvents cbxOFWGenderFilt As ComboBox
    Friend WithEvents cbxOFWCivStatFilt As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbxOFWZipFilt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtbxOFWOECFilt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtbxOFWVisaFilt As TextBox
    Friend WithEvents chkOFWEmpStatFilt As CheckBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnGEN As Button
    Friend WithEvents btnDLT As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblOFWTally As Label
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents btnADMDashSTAT As Button
    Friend WithEvents btnADMDashDEP As Button
    Friend WithEvents btnADMDashJOB As Button
    Friend WithEvents btnADMDashOFW As Button
    Friend WithEvents btnADMDashAGC As Button
    Friend WithEvents btnADMDashEMP As Button
End Class
