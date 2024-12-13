<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMDashboardJOBTab
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
        txtJOBAgencyFilt = New TextBox()
        Label8 = New Label()
        txtJOBSalaryFilt = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        btnClearFilter = New Button()
        lblJOBTally = New Label()
        Label12 = New Label()
        btnDLT = New Button()
        btnGEN = New Button()
        btnEDIT = New Button()
        btnADD = New Button()
        btnFilter = New Button()
        Label9 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtJOBNameFilt = New TextBox()
        Label3 = New Label()
        txtJOBIdFilt = New TextBox()
        Label2 = New Label()
        btnLogout = New Button()
        dgvJOB = New DataGridView()
        txtJOBCountryFilt = New TextBox()
        Label1 = New Label()
        Panel4 = New Panel()
        btnCLose = New Button()
        Panel1 = New Panel()
        btnADMDashSTAT = New Button()
        btnADMDashDEP = New Button()
        btnADMDashJOB = New Button()
        btnADMDashAGC = New Button()
        btnADMDashEMP = New Button()
        btnADMDashOFW = New Button()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        cbxJOBStatFilt = New ComboBox()
        CType(dgvJOB, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtJOBAgencyFilt
        ' 
        txtJOBAgencyFilt.Location = New Point(2382, 459)
        txtJOBAgencyFilt.Margin = New Padding(4)
        txtJOBAgencyFilt.Name = "txtJOBAgencyFilt"
        txtJOBAgencyFilt.PlaceholderText = "#####"
        txtJOBAgencyFilt.Size = New Size(58, 29)
        txtJOBAgencyFilt.TabIndex = 145
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(2150, 497)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 21)
        Label8.TabIndex = 144
        Label8.Text = "Salary Offered"
        ' 
        ' txtJOBSalaryFilt
        ' 
        txtJOBSalaryFilt.Location = New Point(2150, 459)
        txtJOBSalaryFilt.Margin = New Padding(4)
        txtJOBSalaryFilt.Name = "txtJOBSalaryFilt"
        txtJOBSalaryFilt.PlaceholderText = "Salary"
        txtJOBSalaryFilt.Size = New Size(175, 29)
        txtJOBSalaryFilt.TabIndex = 143
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(2335, 497)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 21)
        Label14.TabIndex = 146
        Label14.Text = "Agency"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(2154, 277)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 21)
        Label13.TabIndex = 142
        Label13.Text = "JOB-"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.FlatStyle = FlatStyle.Popup
        btnClearFilter.Location = New Point(2241, 591)
        btnClearFilter.Margin = New Padding(4)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(98, 38)
        btnClearFilter.TabIndex = 141
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' lblJOBTally
        ' 
        lblJOBTally.AutoSize = True
        lblJOBTally.Location = New Point(2367, 647)
        lblJOBTally.Margin = New Padding(4, 0, 4, 0)
        lblJOBTally.Name = "lblJOBTally"
        lblJOBTally.Size = New Size(19, 21)
        lblJOBTally.TabIndex = 140
        lblJOBTally.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(2152, 647)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(207, 21)
        Label12.TabIndex = 139
        Label12.Text = "Total number of Jobs shown:"
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = Color.MistyRose
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.ForeColor = Color.DarkRed
        btnDLT.Location = New Point(2352, 1403)
        btnDLT.Margin = New Padding(4)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(94, 92)
        btnDLT.TabIndex = 138
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' btnGEN
        ' 
        btnGEN.BackColor = Color.LightCyan
        btnGEN.FlatStyle = FlatStyle.Popup
        btnGEN.ForeColor = Color.DarkBlue
        btnGEN.Location = New Point(2352, 1302)
        btnGEN.Margin = New Padding(4)
        btnGEN.Name = "btnGEN"
        btnGEN.Size = New Size(94, 92)
        btnGEN.TabIndex = 137
        btnGEN.Text = "GENERATE"
        btnGEN.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = Color.LightCyan
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.ForeColor = Color.DarkBlue
        btnEDIT.Location = New Point(2250, 1302)
        btnEDIT.Margin = New Padding(4)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(94, 92)
        btnEDIT.TabIndex = 136
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.LightCyan
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.ForeColor = Color.DarkBlue
        btnADD.Location = New Point(2150, 1302)
        btnADD.Margin = New Padding(4)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(94, 92)
        btnADD.TabIndex = 135
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Popup
        btnFilter.Location = New Point(2346, 591)
        btnFilter.Margin = New Padding(4)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(98, 38)
        btnFilter.TabIndex = 134
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(2150, 563)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 21)
        Label9.TabIndex = 129
        Label9.Text = "Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1445, 570)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 21)
        Label7.TabIndex = 127
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(2150, 434)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 21)
        Label5.TabIndex = 126
        Label5.Text = "Country of Employment"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(2150, 370)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 21)
        Label4.TabIndex = 124
        Label4.Text = "Job Title"
        ' 
        ' txtJOBNameFilt
        ' 
        txtJOBNameFilt.Location = New Point(2150, 332)
        txtJOBNameFilt.Margin = New Padding(4)
        txtJOBNameFilt.Name = "txtJOBNameFilt"
        txtJOBNameFilt.PlaceholderText = "Job"
        txtJOBNameFilt.Size = New Size(291, 29)
        txtJOBNameFilt.TabIndex = 123
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(2150, 305)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 21)
        Label3.TabIndex = 122
        Label3.Text = "Agency ID Number"
        ' 
        ' txtJOBIdFilt
        ' 
        txtJOBIdFilt.Location = New Point(2204, 270)
        txtJOBIdFilt.Margin = New Padding(4)
        txtJOBIdFilt.Name = "txtJOBIdFilt"
        txtJOBIdFilt.PlaceholderText = "#####"
        txtJOBIdFilt.Size = New Size(72, 29)
        txtJOBIdFilt.TabIndex = 121
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(2150, 217)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 43)
        Label2.TabIndex = 120
        Label2.Text = "Filter Search"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightSlateGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(2298, 17)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(81, 29)
        btnLogout.TabIndex = 119
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' dgvJOB
        ' 
        dgvJOB.BackgroundColor = SystemColors.ActiveCaption
        dgvJOB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJOB.Location = New Point(445, 210)
        dgvJOB.Margin = New Padding(4)
        dgvJOB.Name = "dgvJOB"
        dgvJOB.RowHeadersWidth = 51
        dgvJOB.Size = New Size(1080, 870)
        dgvJOB.TabIndex = 118
        ' 
        ' txtJOBCountryFilt
        ' 
        txtJOBCountryFilt.Location = New Point(2150, 396)
        txtJOBCountryFilt.Margin = New Padding(4)
        txtJOBCountryFilt.Name = "txtJOBCountryFilt"
        txtJOBCountryFilt.PlaceholderText = "Country"
        txtJOBCountryFilt.Size = New Size(291, 29)
        txtJOBCountryFilt.TabIndex = 125
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
        Label1.Size = New Size(586, 96)
        Label1.TabIndex = 117
        Label1.Text = "Job Placements"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MidnightBlue
        Panel4.Location = New Point(428, 160)
        Panel4.Margin = New Padding(4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1493, 35)
        Panel4.TabIndex = 116
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
        btnCLose.TabIndex = 115
        btnCLose.Text = "CLOSE"
        btnCLose.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(btnADMDashSTAT)
        Panel1.Controls.Add(btnADMDashDEP)
        Panel1.Controls.Add(btnADMDashJOB)
        Panel1.Controls.Add(btnADMDashAGC)
        Panel1.Controls.Add(btnADMDashEMP)
        Panel1.Controls.Add(btnADMDashOFW)
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(-3, -1)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(433, 1520)
        Panel1.TabIndex = 114
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
        btnADMDashSTAT.TabIndex = 13
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
        btnADMDashDEP.TabIndex = 12
        btnADMDashDEP.Text = "Deployments"
        btnADMDashDEP.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashJOB
        ' 
        btnADMDashJOB.BackColor = Color.DeepSkyBlue
        btnADMDashJOB.FlatAppearance.BorderSize = 0
        btnADMDashJOB.FlatStyle = FlatStyle.Flat
        btnADMDashJOB.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashJOB.ForeColor = Color.MidnightBlue
        btnADMDashJOB.Location = New Point(65, 790)
        btnADMDashJOB.Margin = New Padding(4)
        btnADMDashJOB.Name = "btnADMDashJOB"
        btnADMDashJOB.Size = New Size(382, 65)
        btnADMDashJOB.TabIndex = 11
        btnADMDashJOB.Text = "Job Placements"
        btnADMDashJOB.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashAGC
        ' 
        btnADMDashAGC.BackColor = Color.RoyalBlue
        btnADMDashAGC.FlatAppearance.BorderSize = 0
        btnADMDashAGC.FlatStyle = FlatStyle.Flat
        btnADMDashAGC.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashAGC.ForeColor = Color.MidnightBlue
        btnADMDashAGC.Location = New Point(65, 705)
        btnADMDashAGC.Margin = New Padding(4)
        btnADMDashAGC.Name = "btnADMDashAGC"
        btnADMDashAGC.Size = New Size(310, 65)
        btnADMDashAGC.TabIndex = 10
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
        btnADMDashEMP.TabIndex = 9
        btnADMDashEMP.Text = "Employers"
        btnADMDashEMP.UseVisualStyleBackColor = False
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
        btnADMDashOFW.TabIndex = 8
        btnADMDashOFW.Text = "OFWs"
        btnADMDashOFW.UseVisualStyleBackColor = False
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(2335, 463)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 21)
        Label6.TabIndex = 147
        Label6.Text = "AGC-"
        ' 
        ' cbxJOBStatFilt
        ' 
        cbxJOBStatFilt.FormattingEnabled = True
        cbxJOBStatFilt.Location = New Point(2150, 526)
        cbxJOBStatFilt.Margin = New Padding(4)
        cbxJOBStatFilt.Name = "cbxJOBStatFilt"
        cbxJOBStatFilt.Size = New Size(175, 29)
        cbxJOBStatFilt.TabIndex = 148
        ' 
        ' ADMDashboardJOBTab
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(cbxJOBStatFilt)
        Controls.Add(Label6)
        Controls.Add(txtJOBAgencyFilt)
        Controls.Add(Label8)
        Controls.Add(txtJOBSalaryFilt)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(btnClearFilter)
        Controls.Add(lblJOBTally)
        Controls.Add(Label12)
        Controls.Add(btnDLT)
        Controls.Add(btnGEN)
        Controls.Add(btnEDIT)
        Controls.Add(btnADD)
        Controls.Add(btnFilter)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtJOBNameFilt)
        Controls.Add(Label3)
        Controls.Add(txtJOBIdFilt)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Controls.Add(dgvJOB)
        Controls.Add(txtJOBCountryFilt)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(btnCLose)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ADMDashboardJOBTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMDashboardJOBTab"
        WindowState = FormWindowState.Maximized
        CType(dgvJOB, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAGCSpecFilt As TextBox
    Private txtJOBAgencyFilt As TextBox
    Friend WithEvents Label8 As Label
    Private txtJOBSalaryFilt As TextBox
    Private WithEvents txtAGCWebFilt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnClearFilter As Button
    Private WithEvents lblJOBTally As Label
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
    Private txtJOBNameFilt As TextBox
    Private WithEvents txtAGCNameFilt As TextBox
    Friend WithEvents Label3 As Label
    Private txtJOBIdFilt As TextBox
    Private WithEvents txtAGCIdFilt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvJOB As DataGridView
    Private WithEvents txtJOBCountryFilt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCLose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxJOBStatFilt As ComboBox
    Friend WithEvents btnADMDashSTAT As Button
    Friend WithEvents btnADMDashDEP As Button
    Friend WithEvents btnADMDashJOB As Button
    Friend WithEvents btnADMDashAGC As Button
    Friend WithEvents btnADMDashEMP As Button
    Friend WithEvents btnADMDashOFW As Button
End Class
