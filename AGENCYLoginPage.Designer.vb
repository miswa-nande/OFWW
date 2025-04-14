<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AGENCYLoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AGENCYLoginPage))
        btnOkAGCLoginPg = New Button()
        txtbxAGCIdLogin = New TextBox()
        btnExit = New Button()
        btnEMPLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnOFWLoginPg = New Button()
        imgLogoLoginPg = New PictureBox()
        imgLoginPg = New PictureBox()
        txtAGCPassLogin = New TextBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOkAGCLoginPg
        ' 
        btnOkAGCLoginPg.BackColor = Color.DeepSkyBlue
        btnOkAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnOkAGCLoginPg.Font = New Font("Segoe UI", 13.8F)
        btnOkAGCLoginPg.Location = New Point(1426, 785)
        btnOkAGCLoginPg.Name = "btnOkAGCLoginPg"
        btnOkAGCLoginPg.Size = New Size(90, 44)
        btnOkAGCLoginPg.TabIndex = 31
        btnOkAGCLoginPg.Text = "Log In"
        btnOkAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' txtbxAGCIdLogin
        ' 
        txtbxAGCIdLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxAGCIdLogin.Location = New Point(1394, 642)
        txtbxAGCIdLogin.Name = "txtbxAGCIdLogin"
        txtbxAGCIdLogin.PlaceholderText = "ID number"
        txtbxAGCIdLogin.Size = New Size(150, 32)
        txtbxAGCIdLogin.TabIndex = 30
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
        btnExit.TabIndex = 27
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Segoe UI", 13.8F)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1536, 906)
        btnEMPLoginPg.Margin = New Padding(3, 4, 3, 4)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(125, 46)
        btnEMPLoginPg.TabIndex = 26
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
        btnAGCLoginPg.Margin = New Padding(3, 4, 3, 4)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(125, 46)
        btnAGCLoginPg.TabIndex = 25
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
        btnOFWLoginPg.TabIndex = 24
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Image = My.Resources.Resources.logo__1_
        imgLogoLoginPg.Location = New Point(1227, 120)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(480, 502)
        imgLogoLoginPg.TabIndex = 23
        imgLogoLoginPg.TabStop = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(0, 0)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(1920, 1080)
        imgLoginPg.SizeMode = PictureBoxSizeMode.StretchImage
        imgLoginPg.TabIndex = 22
        imgLoginPg.TabStop = False
        ' 
        ' txtAGCPassLogin
        ' 
        txtAGCPassLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAGCPassLogin.Location = New Point(1394, 680)
        txtAGCPassLogin.Name = "txtAGCPassLogin"
        txtAGCPassLogin.PlaceholderText = "Password"
        txtAGCPassLogin.Size = New Size(150, 32)
        txtAGCPassLogin.TabIndex = 33
        txtAGCPassLogin.UseSystemPasswordChar = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F)
        LinkLabel1.Location = New Point(1540, 755)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(58, 21)
        LinkLabel1.TabIndex = 35
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
        Label2.TabIndex = 34
        Label2.Text = "Don't have an account yet?"
        ' 
        ' AGENCYLoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(txtAGCPassLogin)
        Controls.Add(btnOkAGCLoginPg)
        Controls.Add(txtbxAGCIdLogin)
        Controls.Add(btnExit)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "AGENCYLoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AGENYLoginPage"
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnOkAGCLoginPg As Button
    Friend WithEvents txtbxAGCIdLogin As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents imgLoginPg As PictureBox
    Friend WithEvents txtAGCPassLogin As TextBox
    Friend WithEvents Label2 As Label
End Class




