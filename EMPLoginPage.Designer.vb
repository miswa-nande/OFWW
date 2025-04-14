<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLoginPage))
        btnOkEMPLoginPg = New Button()
        txtbxEMPIdLogin = New TextBox()
        btnEMPLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnOFWLoginPg = New Button()
        imgLogoLoginPg = New PictureBox()
        imgLoginPg = New PictureBox()
        txtEMPPassLogin = New TextBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        btnExit = New Button()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOkEMPLoginPg
        ' 
        btnOkEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnOkEMPLoginPg.Font = New Font("Segoe UI", 13.8F)
        btnOkEMPLoginPg.Location = New Point(1426, 785)
        btnOkEMPLoginPg.Name = "btnOkEMPLoginPg"
        btnOkEMPLoginPg.Size = New Size(90, 44)
        btnOkEMPLoginPg.TabIndex = 33
        btnOkEMPLoginPg.Text = "Log In"
        btnOkEMPLoginPg.UseVisualStyleBackColor = True
        ' 
        ' txtbxEMPIdLogin
        ' 
        txtbxEMPIdLogin.Font = New Font("Segoe UI", 13.8F)
        txtbxEMPIdLogin.Location = New Point(1394, 642)
        txtbxEMPIdLogin.Name = "txtbxEMPIdLogin"
        txtbxEMPIdLogin.PlaceholderText = "ID number"
        txtbxEMPIdLogin.Size = New Size(150, 32)
        txtbxEMPIdLogin.TabIndex = 32
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
        btnEMPLoginPg.TabIndex = 28
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
        btnAGCLoginPg.TabIndex = 27
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
        btnOFWLoginPg.TabIndex = 26
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.BackgroundImageLayout = ImageLayout.Center
        imgLogoLoginPg.Image = My.Resources.Resources.logo__1_
        imgLogoLoginPg.Location = New Point(1227, 120)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(480, 502)
        imgLogoLoginPg.TabIndex = 25
        imgLogoLoginPg.TabStop = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.BackgroundImageLayout = ImageLayout.Stretch
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(0, 0)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(1920, 1080)
        imgLoginPg.SizeMode = PictureBoxSizeMode.StretchImage
        imgLoginPg.TabIndex = 24
        imgLoginPg.TabStop = False
        ' 
        ' txtEMPPassLogin
        ' 
        txtEMPPassLogin.Font = New Font("Segoe UI", 13.8F)
        txtEMPPassLogin.Location = New Point(1394, 680)
        txtEMPPassLogin.Name = "txtEMPPassLogin"
        txtEMPPassLogin.PlaceholderText = "Password"
        txtEMPPassLogin.Size = New Size(150, 32)
        txtEMPPassLogin.TabIndex = 37
        txtEMPPassLogin.UseSystemPasswordChar = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F)
        LinkLabel1.Location = New Point(1540, 755)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(58, 21)
        LinkLabel1.TabIndex = 39
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign In"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(1348, 755)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 21)
        Label2.TabIndex = 38
        Label2.Text = "Don't have an account yet?"
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.BackColor = Color.Crimson
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        btnExit.ForeColor = Color.DeepSkyBlue
        btnExit.Location = New Point(1857, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(60, 53)
        btnExit.TabIndex = 40
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' EMPLoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnExit)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(txtEMPPassLogin)
        Controls.Add(btnOkEMPLoginPg)
        Controls.Add(txtbxEMPIdLogin)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Name = "EMPLoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EMPLoginPage"
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnOkEMPLoginPg As Button
    Friend WithEvents txtbxEMPIdLogin As TextBox
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents imgLoginPg As PictureBox
    Friend WithEvents txtEMPPassLogin As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
End Class
