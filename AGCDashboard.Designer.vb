<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGCDashboard
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
        bg = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        dgvOFW = New DataGridView()
        dgvDEP = New DataGridView()
        dgvEMP = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnOFWDetails = New Button()
        btnADD = New Button()
        btnEDIT = New Button()
        btnDLT = New Button()
        AGCName = New Label()
        accreNum = New Label()
        btnLogout = New Button()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOFW, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDEP, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEMP, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bg
        ' 
        bg.BackColor = Color.Transparent
        bg.Image = My.Resources.Resources.Untitled_design__7_1
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1920, 1080)
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(134, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(789, 355)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(1057, 138)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(789, 355)
        Panel2.TabIndex = 2
        ' 
        ' dgvOFW
        ' 
        dgvOFW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOFW.Location = New Point(134, 571)
        dgvOFW.Name = "dgvOFW"
        dgvOFW.Size = New Size(513, 390)
        dgvOFW.TabIndex = 0
        ' 
        ' dgvDEP
        ' 
        dgvDEP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDEP.Location = New Point(739, 571)
        dgvDEP.Name = "dgvDEP"
        dgvDEP.Size = New Size(513, 390)
        dgvDEP.TabIndex = 3
        ' 
        ' dgvEMP
        ' 
        dgvEMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEMP.Location = New Point(1333, 571)
        dgvEMP.Name = "dgvEMP"
        dgvEMP.Size = New Size(513, 390)
        dgvEMP.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DeepSkyBlue
        Label1.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(134, 528)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 40)
        Label1.TabIndex = 5
        Label1.Text = "OFWs"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DeepSkyBlue
        Label2.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(739, 528)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 40)
        Label2.TabIndex = 6
        Label2.Text = "Deployed"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DeepSkyBlue
        Label3.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1333, 528)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 40)
        Label3.TabIndex = 7
        Label3.Text = "Employers"
        ' 
        ' btnOFWDetails
        ' 
        btnOFWDetails.BackColor = SystemColors.Highlight
        btnOFWDetails.FlatStyle = FlatStyle.Popup
        btnOFWDetails.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOFWDetails.Location = New Point(481, 967)
        btnOFWDetails.Name = "btnOFWDetails"
        btnOFWDetails.Size = New Size(166, 48)
        btnOFWDetails.TabIndex = 8
        btnOFWDetails.Text = "View Details"
        btnOFWDetails.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = SystemColors.Highlight
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADD.Location = New Point(1680, 967)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(166, 48)
        btnADD.TabIndex = 9
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = SystemColors.Highlight
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEDIT.Location = New Point(1508, 967)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(166, 48)
        btnEDIT.TabIndex = 10
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = SystemColors.Highlight
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDLT.Location = New Point(1333, 967)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(166, 48)
        btnDLT.TabIndex = 11
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' AGCName
        ' 
        AGCName.AutoSize = True
        AGCName.BackColor = Color.DeepSkyBlue
        AGCName.Font = New Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AGCName.Location = New Point(653, 9)
        AGCName.Name = "AGCName"
        AGCName.Size = New Size(712, 75)
        AGCName.TabIndex = 12
        AGCName.Text = "AGENCY NAME HERE"
        ' 
        ' accreNum
        ' 
        accreNum.AutoSize = True
        accreNum.BackColor = Color.DeepSkyBlue
        accreNum.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        accreNum.Location = New Point(806, 84)
        accreNum.Name = "accreNum"
        accreNum.Size = New Size(395, 32)
        accreNum.TabIndex = 13
        accreNum.Text = "ACCREDITATION NUM HERE"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Red
        btnLogout.FlatStyle = FlatStyle.Popup
        btnLogout.ForeColor = SystemColors.ButtonHighlight
        btnLogout.Location = New Point(1833, 9)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 14
        btnLogout.Text = "LOG OUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' AGCDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnLogout)
        Controls.Add(accreNum)
        Controls.Add(AGCName)
        Controls.Add(btnDLT)
        Controls.Add(btnEDIT)
        Controls.Add(btnADD)
        Controls.Add(btnOFWDetails)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvEMP)
        Controls.Add(dgvDEP)
        Controls.Add(dgvOFW)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(bg)
        FormBorderStyle = FormBorderStyle.None
        Name = "AGCDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AGCDashboard"
        WindowState = FormWindowState.Maximized
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOFW, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDEP, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEMP, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bg As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvOFW As DataGridView
    Friend WithEvents dgvDEP As DataGridView
    Friend WithEvents dgvEMP As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOFWDetails As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnDLT As Button
    Friend WithEvents AGCName As Label
    Friend WithEvents accreNum As Label
    Friend WithEvents btnLogout As Button
End Class
