<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OFWloginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OFWloginPage))
        imgLogoLoginPg = New PictureBox()
        txtbxOFWIdLogin = New TextBox()
        btnOkOFWLoginPg = New Button()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        txtbxOFWPassLogin = New TextBox()
        btnExit = New Button()
        imgLoginPg = New PictureBox()
        btnEMPLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnOFWLoginPg = New Button()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Anchor = AnchorStyles.None
        imgLogoLoginPg.BackgroundImageLayout = ImageLayout.None
        imgLogoLoginPg.Image = My.Resources.Resources.logo__1_
        imgLogoLoginPg.Location = New Point(1227, 120)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(480, 502)
        imgLogoLoginPg.TabIndex = 1
        imgLogoLoginPg.TabStop = False
        ' 
        ' txtbxOFWIdLogin
        ' 
        txtbxOFWIdLogin.Anchor = AnchorStyles.None
        txtbxOFWIdLogin.Font = New Font("Segoe UI", 13.8F)
        txtbxOFWIdLogin.Location = New Point(1394, 642)
        txtbxOFWIdLogin.Name = "txtbxOFWIdLogin"
        txtbxOFWIdLogin.PlaceholderText = "ID number"
        txtbxOFWIdLogin.Size = New Size(150, 32)
        txtbxOFWIdLogin.TabIndex = 8
        ' 
        ' btnOkOFWLoginPg
        ' 
        btnOkOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOkOFWLoginPg.Font = New Font("Segoe UI", 13.8F)
        btnOkOFWLoginPg.Location = New Point(1426, 785)
        btnOkOFWLoginPg.Name = "btnOkOFWLoginPg"
        btnOkOFWLoginPg.Size = New Size(90, 44)
        btnOkOFWLoginPg.TabIndex = 9
        btnOkOFWLoginPg.Text = "Log In"
        btnOkOFWLoginPg.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1348, 755)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 21)
        Label2.TabIndex = 22
        Label2.Text = "Don't have an account yet?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(1540, 755)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(58, 21)
        LinkLabel1.TabIndex = 23
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign In"
        ' 
        ' txtbxOFWPassLogin
        ' 
        txtbxOFWPassLogin.Anchor = AnchorStyles.None
        txtbxOFWPassLogin.Font = New Font("Segoe UI", 13.8F)
        txtbxOFWPassLogin.Location = New Point(1394, 680)
        txtbxOFWPassLogin.Name = "txtbxOFWPassLogin"
        txtbxOFWPassLogin.PlaceholderText = "Password"
        txtbxOFWPassLogin.Size = New Size(150, 32)
        txtbxOFWPassLogin.TabIndex = 25
        txtbxOFWPassLogin.UseSystemPasswordChar = True
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.BackColor = Color.Crimson
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.DeepSkyBlue
        btnExit.Location = New Point(1857, 3)
        btnExit.Margin = New Padding(4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(60, 53)
        btnExit.TabIndex = 28
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Dock = DockStyle.Fill
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(0, 0)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(1920, 1080)
        imgLoginPg.SizeMode = PictureBoxSizeMode.StretchImage
        imgLoginPg.TabIndex = 0
        imgLoginPg.TabStop = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Segoe UI", 13.8F)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1536, 906)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(125, 46)
        btnEMPLoginPg.TabIndex = 31
        btnEMPLoginPg.Text = "EMPLOYER"
        btnEMPLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnAGCLoginPg
        ' 
        btnAGCLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnAGCLoginPg.Font = New Font("Segoe UI", 13.8F)
        btnAGCLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnAGCLoginPg.Location = New Point(1274, 906)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(125, 46)
        btnAGCLoginPg.TabIndex = 30
        btnAGCLoginPg.Text = "AGENCY"
        btnAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnOFWLoginPg
        ' 
        btnOFWLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOFWLoginPg.Font = New Font("Segoe UI", 13.8F)
        btnOFWLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnOFWLoginPg.Location = New Point(1405, 906)
        btnOFWLoginPg.Name = "btnOFWLoginPg"
        btnOFWLoginPg.Size = New Size(125, 46)
        btnOFWLoginPg.TabIndex = 29
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' OFWloginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(btnExit)
        Controls.Add(txtbxOFWPassLogin)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(btnOkOFWLoginPg)
        Controls.Add(txtbxOFWIdLogin)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Name = "OFWloginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginPage"
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents txtbxOFWIdLogin As TextBox
    Friend WithEvents btnOkOFWLoginPg As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtbxOFWPassLogin As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents imgLoginPg As PictureBox
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
End Class
