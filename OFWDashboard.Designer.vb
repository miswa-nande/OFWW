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
        bg.BackColor = Color.DeepSkyBlue
        bg.Location = New Point(0, 0)
        bg.Margin = New Padding(3, 4, 3, 4)
        bg.Name = "bg"
        bg.Size = New Size(2194, 1440)
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' OFWpic
        ' 
        OFWpic.BackColor = SystemColors.Control
        OFWpic.Location = New Point(73, 83)
        OFWpic.Margin = New Padding(3, 4, 3, 4)
        OFWpic.Name = "OFWpic"
        OFWpic.Size = New Size(240, 280)
        OFWpic.TabIndex = 1
        OFWpic.TabStop = False
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.BackColor = Color.DeepSkyBlue
        lblFName.Font = New Font("Segoe UI", 16.2F)
        lblFName.Location = New Point(352, 83)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(211, 38)
        lblFName.TabIndex = 2
        lblFName.Text = "Full Name Here"
        ' 
        ' IDNum
        ' 
        IDNum.AutoSize = True
        IDNum.BackColor = Color.DeepSkyBlue
        IDNum.Font = New Font("Segoe UI", 16.2F)
        IDNum.Location = New Point(355, 141)
        IDNum.Name = "IDNum"
        IDNum.Size = New Size(119, 38)
        IDNum.TabIndex = 3
        IDNum.Text = "OFW ID:"
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.BackColor = Color.DeepSkyBlue
        Address.Font = New Font("Segoe UI", 16.2F)
        Address.Location = New Point(480, 179)
        Address.Name = "Address"
        Address.Size = New Size(228, 38)
        Address.TabIndex = 4
        Address.Text = "Full address here"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DeepSkyBlue
        Label2.Font = New Font("Segoe UI", 16.2F)
        Label2.Location = New Point(352, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 38)
        Label2.TabIndex = 5
        Label2.Text = "Email:"
        ' 
        ' EmploymentStat
        ' 
        EmploymentStat.AutoSize = True
        EmploymentStat.BackColor = Color.DeepSkyBlue
        EmploymentStat.Font = New Font("Segoe UI", 16.2F)
        EmploymentStat.Location = New Point(480, 255)
        EmploymentStat.Name = "EmploymentStat"
        EmploymentStat.Size = New Size(460, 38)
        EmploymentStat.TabIndex = 6
        EmploymentStat.Text = "Employed, Unemployed, or Pending"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DeepSkyBlue
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(352, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 38)
        Label1.TabIndex = 7
        Label1.Text = "Address:"
        ' 
        ' OFWEmail
        ' 
        OFWEmail.AutoSize = True
        OFWEmail.BackColor = Color.DeepSkyBlue
        OFWEmail.Font = New Font("Segoe UI", 16.2F)
        OFWEmail.Location = New Point(480, 217)
        OFWEmail.Name = "OFWEmail"
        OFWEmail.Size = New Size(250, 38)
        OFWEmail.TabIndex = 8
        OFWEmail.Text = "Email address here"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DeepSkyBlue
        Label3.Font = New Font("Segoe UI", 16.2F)
        Label3.Location = New Point(352, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 38)
        Label3.TabIndex = 9
        Label3.Text = "Status:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DeepSkyBlue
        Label4.Font = New Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(73, 407)
        Label4.Name = "Label4"
        Label4.Size = New Size(541, 106)
        Label4.TabIndex = 10
        Label4.Text = "JOB LISTINGS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(73, 525)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1634, 915)
        DataGridView1.TabIndex = 11
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.RoyalBlue
        btnApply.FlatStyle = FlatStyle.Popup
        btnApply.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnApply.ForeColor = Color.DarkBlue
        btnApply.Location = New Point(1872, 1317)
        btnApply.Margin = New Padding(3, 4, 3, 4)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(249, 72)
        btnApply.TabIndex = 12
        btnApply.Text = "APPLY JOB"
        btnApply.UseVisualStyleBackColor = False
        ' 
        ' logout
        ' 
        logout.BackColor = Color.Firebrick
        logout.FlatStyle = FlatStyle.Popup
        logout.Font = New Font("Segoe UI", 13.8F)
        logout.ForeColor = Color.White
        logout.Location = New Point(2070, 16)
        logout.Margin = New Padding(3, 4, 3, 4)
        logout.Name = "logout"
        logout.Size = New Size(111, 59)
        logout.TabIndex = 13
        logout.Text = "LOGOUT"
        logout.UseVisualStyleBackColor = False
        ' 
        ' OFWDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1942, 1102)
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
        Margin = New Padding(3, 4, 3, 4)
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
