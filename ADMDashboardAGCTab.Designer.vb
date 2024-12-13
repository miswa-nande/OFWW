<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMDashboardAGCTab
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
        txtAGCSpecFilt = New TextBox()
        Label8 = New Label()
        txtAGCWebFilt = New TextBox()
        PictureBox1 = New PictureBox()
        Label14 = New Label()
        Label13 = New Label()
        btnClearFilter = New Button()
        lblAGCTally = New Label()
        Label12 = New Label()
        btnDLT = New Button()
        btnGEN = New Button()
        btnEDIT = New Button()
        btnADD = New Button()
        btnFilter = New Button()
        Label11 = New Label()
        txtAGCContNumFilt = New TextBox()
        Label10 = New Label()
        txtAGCEmailFilt = New TextBox()
        Label9 = New Label()
        txtAGCZipFilt = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtAGCNameFilt = New TextBox()
        Label3 = New Label()
        txtAGCIdFilt = New TextBox()
        Label2 = New Label()
        btnLogout = New Button()
        dgvAGC = New DataGridView()
        txtAGCLicNumFilt = New TextBox()
        Label1 = New Label()
        Panel4 = New Panel()
        btnCLose = New Button()
        Panel1 = New Panel()
        btnADMDashSTAT = New Button()
        btnADMDashDEP = New Button()
        btnADMDashJOB = New Button()
        btnADMDashOFW = New Button()
        btnADMDashAGC = New Button()
        btnADMDashEMP = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAGC, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtAGCSpecFilt
        ' 
        txtAGCSpecFilt.Location = New Point(2345, 459)
        txtAGCSpecFilt.Margin = New Padding(4)
        txtAGCSpecFilt.Name = "txtAGCSpecFilt"
        txtAGCSpecFilt.PlaceholderText = "Industry"
        txtAGCSpecFilt.Size = New Size(107, 29)
        txtAGCSpecFilt.TabIndex = 112
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(2161, 498)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 21)
        Label8.TabIndex = 111
        Label8.Text = "Website"
        ' 
        ' txtAGCWebFilt
        ' 
        txtAGCWebFilt.Location = New Point(2161, 461)
        txtAGCWebFilt.Margin = New Padding(4)
        txtAGCWebFilt.Name = "txtAGCWebFilt"
        txtAGCWebFilt.PlaceholderText = "Company Name"
        txtAGCWebFilt.Size = New Size(175, 29)
        txtAGCWebFilt.TabIndex = 110
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Untitled_design__8_
        PictureBox1.Location = New Point(15, 10)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(404, 469)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(2345, 500)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(105, 21)
        Label14.TabIndex = 113
        Label14.Text = "Specialization"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(2165, 279)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 21)
        Label13.TabIndex = 109
        Label13.Text = "AGC-"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.FlatStyle = FlatStyle.Popup
        btnClearFilter.Location = New Point(2205, 722)
        btnClearFilter.Margin = New Padding(4)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(98, 38)
        btnClearFilter.TabIndex = 108
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' lblAGCTally
        ' 
        lblAGCTally.AutoSize = True
        lblAGCTally.Location = New Point(2364, 783)
        lblAGCTally.Margin = New Padding(4, 0, 4, 0)
        lblAGCTally.Name = "lblAGCTally"
        lblAGCTally.Size = New Size(19, 21)
        lblAGCTally.TabIndex = 107
        lblAGCTally.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(2119, 783)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(238, 21)
        Label12.TabIndex = 106
        Label12.Text = "Total number of Agencies shown:"
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = Color.MistyRose
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.ForeColor = Color.DarkRed
        btnDLT.Location = New Point(2321, 1385)
        btnDLT.Margin = New Padding(4)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(94, 92)
        btnDLT.TabIndex = 105
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' btnGEN
        ' 
        btnGEN.BackColor = Color.LightCyan
        btnGEN.FlatStyle = FlatStyle.Popup
        btnGEN.ForeColor = Color.DarkBlue
        btnGEN.Location = New Point(2197, 1385)
        btnGEN.Margin = New Padding(4)
        btnGEN.Name = "btnGEN"
        btnGEN.Size = New Size(94, 92)
        btnGEN.TabIndex = 104
        btnGEN.Text = "GENERATE"
        btnGEN.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = Color.LightCyan
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.ForeColor = Color.DarkBlue
        btnEDIT.Location = New Point(2321, 1268)
        btnEDIT.Margin = New Padding(4)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(94, 92)
        btnEDIT.TabIndex = 103
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.LightCyan
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.ForeColor = Color.DarkBlue
        btnADD.Location = New Point(2197, 1268)
        btnADD.Margin = New Padding(4)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(94, 92)
        btnADD.TabIndex = 102
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Popup
        btnFilter.Location = New Point(2310, 722)
        btnFilter.Margin = New Padding(4)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(98, 38)
        btnFilter.TabIndex = 101
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(2161, 629)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(125, 21)
        Label11.TabIndex = 100
        Label11.Text = "Contact Number"
        ' 
        ' txtAGCContNumFilt
        ' 
        txtAGCContNumFilt.Location = New Point(2161, 591)
        txtAGCContNumFilt.Margin = New Padding(4)
        txtAGCContNumFilt.Name = "txtAGCContNumFilt"
        txtAGCContNumFilt.PlaceholderText = "####"
        txtAGCContNumFilt.Size = New Size(175, 29)
        txtAGCContNumFilt.TabIndex = 99
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(2161, 693)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 21)
        Label10.TabIndex = 98
        Label10.Text = "Email"
        ' 
        ' txtAGCEmailFilt
        ' 
        txtAGCEmailFilt.Location = New Point(2161, 655)
        txtAGCEmailFilt.Margin = New Padding(4)
        txtAGCEmailFilt.Name = "txtAGCEmailFilt"
        txtAGCEmailFilt.PlaceholderText = "####"
        txtAGCEmailFilt.Size = New Size(175, 29)
        txtAGCEmailFilt.TabIndex = 97
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(2161, 564)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(65, 21)
        Label9.TabIndex = 96
        Label9.Text = "Zipcode"
        ' 
        ' txtAGCZipFilt
        ' 
        txtAGCZipFilt.Location = New Point(2161, 526)
        txtAGCZipFilt.Margin = New Padding(4)
        txtAGCZipFilt.Name = "txtAGCZipFilt"
        txtAGCZipFilt.PlaceholderText = "####"
        txtAGCZipFilt.Size = New Size(175, 29)
        txtAGCZipFilt.TabIndex = 95
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(2161, 564)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 21)
        Label7.TabIndex = 94
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(2161, 435)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(178, 21)
        Label5.TabIndex = 91
        Label5.Text = "Agency License Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(2161, 371)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 21)
        Label4.TabIndex = 89
        Label4.Text = "Agency Name"
        ' 
        ' txtAGCNameFilt
        ' 
        txtAGCNameFilt.Location = New Point(2161, 333)
        txtAGCNameFilt.Margin = New Padding(4)
        txtAGCNameFilt.Name = "txtAGCNameFilt"
        txtAGCNameFilt.PlaceholderText = "First Name"
        txtAGCNameFilt.Size = New Size(291, 29)
        txtAGCNameFilt.TabIndex = 88
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(2161, 307)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 21)
        Label3.TabIndex = 87
        Label3.Text = "Agency ID Number"
        ' 
        ' txtAGCIdFilt
        ' 
        txtAGCIdFilt.Location = New Point(2215, 272)
        txtAGCIdFilt.Margin = New Padding(4)
        txtAGCIdFilt.Name = "txtAGCIdFilt"
        txtAGCIdFilt.PlaceholderText = "#####"
        txtAGCIdFilt.Size = New Size(72, 29)
        txtAGCIdFilt.TabIndex = 86
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(2161, 207)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 43)
        Label2.TabIndex = 85
        Label2.Text = "Filter Search"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightSlateGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(2296, 17)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(81, 29)
        btnLogout.TabIndex = 84
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' dgvAGC
        ' 
        dgvAGC.BackgroundColor = SystemColors.ActiveCaption
        dgvAGC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAGC.Location = New Point(445, 210)
        dgvAGC.Margin = New Padding(4)
        dgvAGC.Name = "dgvAGC"
        dgvAGC.RowHeadersWidth = 51
        dgvAGC.Size = New Size(1080, 870)
        dgvAGC.TabIndex = 83
        ' 
        ' txtAGCLicNumFilt
        ' 
        txtAGCLicNumFilt.Location = New Point(2161, 398)
        txtAGCLicNumFilt.Margin = New Padding(4)
        txtAGCLicNumFilt.Name = "txtAGCLicNumFilt"
        txtAGCLicNumFilt.PlaceholderText = "Middle Name"
        txtAGCLicNumFilt.Size = New Size(291, 29)
        txtAGCLicNumFilt.TabIndex = 90
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(445, 35)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(345, 96)
        Label1.TabIndex = 82
        Label1.Text = "Agencies"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MidnightBlue
        Panel4.Location = New Point(428, 160)
        Panel4.Margin = New Padding(4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1493, 35)
        Panel4.TabIndex = 81
        ' 
        ' btnCLose
        ' 
        btnCLose.BackColor = Color.Crimson
        btnCLose.FlatAppearance.BorderSize = 0
        btnCLose.FlatStyle = FlatStyle.Flat
        btnCLose.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCLose.ForeColor = Color.MistyRose
        btnCLose.Location = New Point(2386, 17)
        btnCLose.Margin = New Padding(4)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(67, 29)
        btnCLose.TabIndex = 80
        btnCLose.Text = "CLOSE"
        btnCLose.UseVisualStyleBackColor = False
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
        Panel1.Location = New Point(-3, -1)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(433, 1520)
        Panel1.TabIndex = 79
        ' 
        ' btnADMDashSTAT
        ' 
        btnADMDashSTAT.BackColor = Color.RoyalBlue
        btnADMDashSTAT.FlatAppearance.BorderSize = 0
        btnADMDashSTAT.FlatStyle = FlatStyle.Flat
        btnADMDashSTAT.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashSTAT.ForeColor = Color.MidnightBlue
        btnADMDashSTAT.Location = New Point(65, 965)
        btnADMDashSTAT.Margin = New Padding(4)
        btnADMDashSTAT.Name = "btnADMDashSTAT"
        btnADMDashSTAT.Size = New Size(310, 65)
        btnADMDashSTAT.TabIndex = 119
        btnADMDashSTAT.Text = "Statistics"
        btnADMDashSTAT.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashDEP
        ' 
        btnADMDashDEP.BackColor = Color.RoyalBlue
        btnADMDashDEP.FlatAppearance.BorderSize = 0
        btnADMDashDEP.FlatStyle = FlatStyle.Flat
        btnADMDashDEP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashDEP.ForeColor = Color.MidnightBlue
        btnADMDashDEP.Location = New Point(65, 875)
        btnADMDashDEP.Margin = New Padding(4)
        btnADMDashDEP.Name = "btnADMDashDEP"
        btnADMDashDEP.Size = New Size(310, 65)
        btnADMDashDEP.TabIndex = 118
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
        btnADMDashJOB.Location = New Point(65, 790)
        btnADMDashJOB.Margin = New Padding(4)
        btnADMDashJOB.Name = "btnADMDashJOB"
        btnADMDashJOB.Size = New Size(310, 65)
        btnADMDashJOB.TabIndex = 117
        btnADMDashJOB.Text = "Job Placements"
        btnADMDashJOB.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashOFW
        ' 
        btnADMDashOFW.BackColor = Color.RoyalBlue
        btnADMDashOFW.FlatAppearance.BorderSize = 0
        btnADMDashOFW.FlatStyle = FlatStyle.Flat
        btnADMDashOFW.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashOFW.ForeColor = Color.MidnightBlue
        btnADMDashOFW.Location = New Point(65, 535)
        btnADMDashOFW.Margin = New Padding(4)
        btnADMDashOFW.Name = "btnADMDashOFW"
        btnADMDashOFW.Size = New Size(310, 65)
        btnADMDashOFW.TabIndex = 114
        btnADMDashOFW.Text = "OFWs"
        btnADMDashOFW.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashAGC
        ' 
        btnADMDashAGC.BackColor = Color.DeepSkyBlue
        btnADMDashAGC.FlatAppearance.BorderSize = 0
        btnADMDashAGC.FlatStyle = FlatStyle.Flat
        btnADMDashAGC.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashAGC.ForeColor = Color.MidnightBlue
        btnADMDashAGC.Location = New Point(65, 705)
        btnADMDashAGC.Margin = New Padding(4)
        btnADMDashAGC.Name = "btnADMDashAGC"
        btnADMDashAGC.Size = New Size(368, 65)
        btnADMDashAGC.TabIndex = 116
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
        btnADMDashEMP.Location = New Point(65, 620)
        btnADMDashEMP.Margin = New Padding(4)
        btnADMDashEMP.Name = "btnADMDashEMP"
        btnADMDashEMP.Size = New Size(310, 65)
        btnADMDashEMP.TabIndex = 115
        btnADMDashEMP.Text = "Employers"
        btnADMDashEMP.UseVisualStyleBackColor = False
        ' 
        ' ADMDashboardAGCTab
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(txtAGCSpecFilt)
        Controls.Add(Label8)
        Controls.Add(txtAGCWebFilt)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(btnClearFilter)
        Controls.Add(lblAGCTally)
        Controls.Add(Label12)
        Controls.Add(btnDLT)
        Controls.Add(btnGEN)
        Controls.Add(btnEDIT)
        Controls.Add(btnADD)
        Controls.Add(btnFilter)
        Controls.Add(Label11)
        Controls.Add(txtAGCContNumFilt)
        Controls.Add(Label10)
        Controls.Add(txtAGCEmailFilt)
        Controls.Add(Label9)
        Controls.Add(txtAGCZipFilt)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtAGCNameFilt)
        Controls.Add(Label3)
        Controls.Add(txtAGCIdFilt)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Controls.Add(dgvAGC)
        Controls.Add(txtAGCLicNumFilt)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(btnCLose)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ADMDashboardAGCTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMDashboardAGCTab"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAGC, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAGCSpecFilt As TextBox
    Friend WithEvents Label8 As Label
    Private WithEvents txtAGCWebFilt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnClearFilter As Button
    Private WithEvents lblAGCTally As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnDLT As Button
    Friend WithEvents btnGEN As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label11 As Label
    Private WithEvents txtAGCContNumFilt As TextBox
    Friend WithEvents Label10 As Label
    Private WithEvents txtAGCEmailFilt As TextBox
    Friend WithEvents Label9 As Label
    Private WithEvents txtAGCZipFilt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents txtAGCNameFilt As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents txtAGCIdFilt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvAGC As DataGridView
    Private WithEvents txtAGCLicNumFilt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCLose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnADMDashSTAT As Button
    Friend WithEvents btnADMDashDEP As Button
    Friend WithEvents btnADMDashJOB As Button
    Friend WithEvents btnADMDashOFW As Button
    Friend WithEvents btnADMDashAGC As Button
    Friend WithEvents btnADMDashEMP As Button
End Class
