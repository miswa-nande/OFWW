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
        bg.Margin = New Padding(4)
        bg.Name = "bg"
        bg.Size = New Size(1920, 1080)
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' OFWpic
        ' 
        OFWpic.Location = New Point(82, 63)
        OFWpic.Margin = New Padding(4)
        OFWpic.Name = "OFWpic"
        OFWpic.Size = New Size(270, 294)
        OFWpic.TabIndex = 1
        OFWpic.TabStop = False
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.BackColor = Color.DeepSkyBlue
        lblFName.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFName.Location = New Point(396, 87)
        lblFName.Margin = New Padding(4, 0, 4, 0)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(294, 43)
        lblFName.TabIndex = 2
        lblFName.Text = "Full Name Here"
        ' 
        ' IDNum
        ' 
        IDNum.AutoSize = True
        IDNum.BackColor = Color.DeepSkyBlue
        IDNum.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IDNum.Location = New Point(396, 133)
        IDNum.Margin = New Padding(4, 0, 4, 0)
        IDNum.Name = "IDNum"
        IDNum.Size = New Size(160, 32)
        IDNum.TabIndex = 3
        IDNum.Text = "OFW-#####"
        ' 
        ' Address
        ' 
        Address.AutoSize = True
        Address.BackColor = Color.DeepSkyBlue
        Address.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Address.Location = New Point(534, 192)
        Address.Margin = New Padding(4, 0, 4, 0)
        Address.Name = "Address"
        Address.Size = New Size(242, 32)
        Address.TabIndex = 4
        Address.Text = "Full address here"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DeepSkyBlue
        Label2.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(396, 225)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 32)
        Label2.TabIndex = 5
        Label2.Text = "Email:"
        ' 
        ' EmploymentStat
        ' 
        EmploymentStat.AutoSize = True
        EmploymentStat.BackColor = Color.DeepSkyBlue
        EmploymentStat.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmploymentStat.Location = New Point(499, 308)
        EmploymentStat.Margin = New Padding(4, 0, 4, 0)
        EmploymentStat.Name = "EmploymentStat"
        EmploymentStat.Size = New Size(481, 32)
        EmploymentStat.TabIndex = 6
        EmploymentStat.Text = "Employed, Unemployed, or Pending"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DeepSkyBlue
        Label1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(396, 192)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 32)
        Label1.TabIndex = 7
        Label1.Text = "Address:"
        ' 
        ' OFWEmail
        ' 
        OFWEmail.AutoSize = True
        OFWEmail.BackColor = Color.DeepSkyBlue
        OFWEmail.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        OFWEmail.Location = New Point(499, 225)
        OFWEmail.Margin = New Padding(4, 0, 4, 0)
        OFWEmail.Name = "OFWEmail"
        OFWEmail.Size = New Size(268, 32)
        OFWEmail.TabIndex = 8
        OFWEmail.Text = "Email address here"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DeepSkyBlue
        Label3.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(396, 308)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 32)
        Label3.TabIndex = 9
        Label3.Text = "Status:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DeepSkyBlue
        Label4.Font = New Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(82, 455)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(605, 93)
        Label4.TabIndex = 10
        Label4.Text = "JOB LISTINGS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(82, 552)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1838, 528)
        DataGridView1.TabIndex = 11
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.RoyalBlue
        btnApply.FlatStyle = FlatStyle.Popup
        btnApply.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnApply.ForeColor = Color.DarkBlue
        btnApply.Location = New Point(2151, 1390)
        btnApply.Margin = New Padding(4)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(280, 76)
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
        logout.Location = New Point(2354, 17)
        logout.Margin = New Padding(4)
        logout.Name = "logout"
        logout.Size = New Size(99, 45)
        logout.TabIndex = 13
        logout.Text = "LOGOUT"
        logout.UseVisualStyleBackColor = False
        ' 
        ' OFWDashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
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
        Margin = New Padding(4)
        Name = "OFWDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OFWDashboard"
        WindowState = FormWindowState.Maximized
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
