<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMloginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADMloginPage))
        btnCloseLoginPg = New Button()
        btnEMPLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnOFWLoginPg = New Button()
        imgLogoLoginPg = New PictureBox()
        imgLoginPg = New PictureBox()
        Label1 = New Label()
        txtbxADMUserLoginPg = New TextBox()
        Label2 = New Label()
        txtbxADMPassLoginPg = New TextBox()
        btnLoginADMLoginPg = New Button()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCloseLoginPg
        ' 
        btnCloseLoginPg.BackColor = Color.Crimson
        btnCloseLoginPg.FlatStyle = FlatStyle.Popup
        btnCloseLoginPg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseLoginPg.ForeColor = Color.DeepSkyBlue
        btnCloseLoginPg.Location = New Point(1818, 13)
        btnCloseLoginPg.Margin = New Padding(3, 4, 3, 4)
        btnCloseLoginPg.Name = "btnCloseLoginPg"
        btnCloseLoginPg.Size = New Size(90, 56)
        btnCloseLoginPg.TabIndex = 15
        btnCloseLoginPg.Text = "CLOSE"
        btnCloseLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1324, 728)
        btnEMPLoginPg.Margin = New Padding(3, 4, 3, 4)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(210, 79)
        btnEMPLoginPg.TabIndex = 14
        btnEMPLoginPg.Text = "EMPLOYER"
        btnEMPLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnAGCLoginPg
        ' 
        btnAGCLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnAGCLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnAGCLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnAGCLoginPg.Location = New Point(1053, 728)
        btnAGCLoginPg.Margin = New Padding(3, 4, 3, 4)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(210, 79)
        btnAGCLoginPg.TabIndex = 13
        btnAGCLoginPg.Text = "AGENCY"
        btnAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnOFWLoginPg
        ' 
        btnOFWLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOFWLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOFWLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnOFWLoginPg.Location = New Point(782, 728)
        btnOFWLoginPg.Margin = New Padding(3, 4, 3, 4)
        btnOFWLoginPg.Name = "btnOFWLoginPg"
        btnOFWLoginPg.Size = New Size(210, 79)
        btnOFWLoginPg.TabIndex = 12
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Image = My.Resources.Resources.Untitled_design__7_
        imgLogoLoginPg.Location = New Point(899, 228)
        imgLogoLoginPg.Margin = New Padding(3, 4, 3, 4)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(487, 520)
        imgLogoLoginPg.TabIndex = 11
        imgLogoLoginPg.TabStop = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(-1, -3)
        imgLoginPg.Margin = New Padding(3, 4, 3, 4)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(858, 1076)
        imgLoginPg.TabIndex = 10
        imgLoginPg.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(975, 332)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 29)
        Label1.TabIndex = 17
        Label1.Text = "Username:"
        ' 
        ' txtbxADMUserLoginPg
        ' 
        txtbxADMUserLoginPg.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxADMUserLoginPg.Location = New Point(975, 370)
        txtbxADMUserLoginPg.Margin = New Padding(3, 4, 3, 4)
        txtbxADMUserLoginPg.Name = "txtbxADMUserLoginPg"
        txtbxADMUserLoginPg.Size = New Size(335, 35)
        txtbxADMUserLoginPg.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(975, 427)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 29)
        Label2.TabIndex = 19
        Label2.Text = "Password:"
        ' 
        ' txtbxADMPassLoginPg
        ' 
        txtbxADMPassLoginPg.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxADMPassLoginPg.Location = New Point(975, 465)
        txtbxADMPassLoginPg.Margin = New Padding(3, 4, 3, 4)
        txtbxADMPassLoginPg.Name = "txtbxADMPassLoginPg"
        txtbxADMPassLoginPg.Size = New Size(335, 35)
        txtbxADMPassLoginPg.TabIndex = 20
        txtbxADMPassLoginPg.UseSystemPasswordChar = True
        ' 
        ' btnLoginADMLoginPg
        ' 
        btnLoginADMLoginPg.FlatStyle = FlatStyle.Popup
        btnLoginADMLoginPg.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLoginADMLoginPg.Location = New Point(1222, 543)
        btnLoginADMLoginPg.Margin = New Padding(3, 4, 3, 4)
        btnLoginADMLoginPg.Name = "btnLoginADMLoginPg"
        btnLoginADMLoginPg.Size = New Size(90, 39)
        btnLoginADMLoginPg.TabIndex = 21
        btnLoginADMLoginPg.Text = "Login"
        btnLoginADMLoginPg.UseVisualStyleBackColor = True
        ' 
        ' ADMloginPage
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnLoginADMLoginPg)
        Controls.Add(txtbxADMPassLoginPg)
        Controls.Add(Label2)
        Controls.Add(txtbxADMUserLoginPg)
        Controls.Add(Label1)
        Controls.Add(btnCloseLoginPg)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "ADMloginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMloginPage"
        WindowState = FormWindowState.Maximized
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnCloseLoginPg As Button
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents imgLoginPg As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxADMUserLoginPg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxADMPassLoginPg As TextBox
    Friend WithEvents btnLoginADMLoginPg As Button
End Class
