<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OFWDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OFWDashboard))
        bg = New PictureBox()
        OFWpic = New PictureBox()
        lblFName = New Label()
        IDNum = New Label()
        Address = New Label()
        Label2 = New Label()
        EmploymentStat = New Label()
        Label1 = New Label()
        OFWEmail = New Label()
        Label3 = New Label()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        btnApply = New Button()
        logout = New Button()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(OFWpic, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bg
        ' 
        bg.BackgroundImage = CType(resources.GetObject("bg.BackgroundImage"), Image)
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1920, 1080)
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' OFWpic
        ' 
        OFWpic.Location = New Point(64, 45)
        OFWpic.Name = "OFWpic"
        OFWpic.Size = New Size(210, 210)
        OFWpic.TabIndex = 1
        OFWpic.TabStop = False
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.BackColor = Color.DeepSkyBlue
        lblFName.Font = New Font("Segoe UI", 16.2F)
        lblFName.Location = New Point(308, 62)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(164, 30)
        lblFName.TabIndex = 2
        lblFName.Text = "Full Name Here"
        ' 
        ' IDNum
        ' 
        IDNum.AutoSize = True
        IDNum.BackColor = Color.DeepSkyBlue
        IDNum.Font = New Font("Segoe UI", 16.2F)
        IDNum.Location = New Point(308, 95)
        IDNum.Name = "IDNum"
        IDNum.Size = New Size(136, 30)
        IDNum.TabIndex = 3
        IDNum.Text = "OFW-#####"
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.BackColor = Color.DeepSkyBlue
        Address.Font = New Font("Segoe UI", 16.2F)
        Address.Location = New Point(405, 134)
        Address.Name = "Address"
        Address.Size = New Size(177, 30)
        Address.TabIndex = 4
        Address.Text = "Full address here"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DeepSkyBlue
        Label2.Font = New Font("Segoe UI", 16.2F)
        Label2.Location = New Point(308, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 30)
        Label2.TabIndex = 5
        Label2.Text = "Email:"
        ' 
        ' EmploymentStat
        ' 
        EmploymentStat.AutoSize = True
        EmploymentStat.BackColor = Color.DeepSkyBlue
        EmploymentStat.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmploymentStat.Location = New Point(388, 220)
        EmploymentStat.Name = "EmploymentStat"
        EmploymentStat.Size = New Size(374, 24)
        EmploymentStat.TabIndex = 6
        EmploymentStat.Text = "Employed, Unemployed, or Pending"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DeepSkyBlue
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(308, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 30)
        Label1.TabIndex = 7
        Label1.Text = "Address:"
        ' 
        ' OFWEmail
        ' 
        OFWEmail.AutoSize = True
        OFWEmail.BackColor = Color.DeepSkyBlue
        OFWEmail.Font = New Font("Segoe UI", 16.2F)
        OFWEmail.Location = New Point(405, 161)
        OFWEmail.Name = "OFWEmail"
        OFWEmail.Size = New Size(195, 30)
        OFWEmail.TabIndex = 8
        OFWEmail.Text = "Email address here"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DeepSkyBlue
        Label3.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(308, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 24)
        Label3.TabIndex = 9
        Label3.Text = "Status:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DeepSkyBlue
        Label4.Font = New Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(66, 316)
        Label4.Name = "Label4"
        Label4.Size = New Size(421, 86)
        Label4.TabIndex = 10
        Label4.Text = "JOB LISTINGS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(64, 394)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1430, 377)
        DataGridView1.TabIndex = 11
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.RoyalBlue
        btnApply.FlatStyle = FlatStyle.Popup
        btnApply.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnApply.ForeColor = Color.DarkBlue
        btnApply.Location = New Point(1673, 993)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(218, 54)
        btnApply.TabIndex = 12
        btnApply.Text = "APPLY JOB"
        btnApply.UseVisualStyleBackColor = False
        ' 
        ' logout
        ' 
        logout.BackColor = Color.Firebrick
        logout.FlatStyle = FlatStyle.Popup
        logout.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logout.ForeColor = SystemColors.ActiveCaptionText
        logout.Location = New Point(1831, 12)
        logout.Name = "logout"
        logout.Size = New Size(77, 32)
        logout.TabIndex = 13
        logout.Text = "LOGOUT"
        logout.UseVisualStyleBackColor = False
        ' 
        ' OFWDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1080)
        Controls.Add(logout)
        Controls.Add(btnApply)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(OFWEmail)
        Controls.Add(Label1)
        Controls.Add(EmploymentStat)
        Controls.Add(Label2)
        Controls.Add(Address)
        Controls.Add(IDNum)
        Controls.Add(lblFName)
        Controls.Add(OFWpic)
        Controls.Add(bg)
        FormBorderStyle = FormBorderStyle.None
        Name = "OFWDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OFWDashboard"
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        CType(OFWpic, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bg As PictureBox
    Friend WithEvents OFWpic As PictureBox
    Friend WithEvents lblFName As Label
    Friend WithEvents IDNum As Label
    Friend WithEvents Address As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmploymentStat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OFWEmail As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnApply As Button
    Friend WithEvents logout As Button
End Class
