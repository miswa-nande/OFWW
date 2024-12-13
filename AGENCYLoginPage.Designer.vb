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
        Label1 = New Label()
        btnCloseLoginPg = New Button()
        btnEMPLoginPg = New Button()
        btnAGCLoginPg = New Button()
        btnOFWLoginPg = New Button()
        imgLogoLoginPg = New PictureBox()
        imgLoginPg = New PictureBox()
        Label2 = New Label()
        txtAGCPassLogin = New TextBox()
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOkAGCLoginPg
        ' 
        btnOkAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnOkAGCLoginPg.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOkAGCLoginPg.Location = New Point(1250, 546)
        btnOkAGCLoginPg.Margin = New Padding(4, 4, 4, 4)
        btnOkAGCLoginPg.Name = "btnOkAGCLoginPg"
        btnOkAGCLoginPg.Size = New Size(60, 52)
        btnOkAGCLoginPg.TabIndex = 31
        btnOkAGCLoginPg.Text = "OK"
        btnOkAGCLoginPg.UseVisualStyleBackColor = True
        ' 
        ' txtbxAGCIdLogin
        ' 
        txtbxAGCIdLogin.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbxAGCIdLogin.Location = New Point(1115, 414)
        txtbxAGCIdLogin.Margin = New Padding(4, 4, 4, 4)
        txtbxAGCIdLogin.Name = "txtbxAGCIdLogin"
        txtbxAGCIdLogin.PlaceholderText = "AGC-#####"
        txtbxAGCIdLogin.Size = New Size(187, 35)
        txtbxAGCIdLogin.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1115, 377)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 29)
        Label1.TabIndex = 29
        Label1.Text = "Agency ID"
        ' 
        ' btnCloseLoginPg
        ' 
        btnCloseLoginPg.BackColor = Color.Crimson
        btnCloseLoginPg.FlatStyle = FlatStyle.Popup
        btnCloseLoginPg.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCloseLoginPg.ForeColor = Color.DeepSkyBlue
        btnCloseLoginPg.Location = New Point(1804, 15)
        btnCloseLoginPg.Margin = New Padding(4, 6, 4, 6)
        btnCloseLoginPg.Name = "btnCloseLoginPg"
        btnCloseLoginPg.Size = New Size(103, 74)
        btnCloseLoginPg.TabIndex = 27
        btnCloseLoginPg.Text = "CLOSE"
        btnCloseLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnEMPLoginPg
        ' 
        btnEMPLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnEMPLoginPg.FlatStyle = FlatStyle.Popup
        btnEMPLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnEMPLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnEMPLoginPg.Location = New Point(1571, 1018)
        btnEMPLoginPg.Margin = New Padding(4, 6, 4, 6)
        btnEMPLoginPg.Name = "btnEMPLoginPg"
        btnEMPLoginPg.Size = New Size(240, 105)
        btnEMPLoginPg.TabIndex = 26
        btnEMPLoginPg.Text = "EMPLOYER"
        btnEMPLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnAGCLoginPg
        ' 
        btnAGCLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnAGCLoginPg.FlatStyle = FlatStyle.Popup
        btnAGCLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold)
        btnAGCLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnAGCLoginPg.Location = New Point(1261, 1018)
        btnAGCLoginPg.Margin = New Padding(4, 6, 4, 6)
        btnAGCLoginPg.Name = "btnAGCLoginPg"
        btnAGCLoginPg.Size = New Size(240, 105)
        btnAGCLoginPg.TabIndex = 25
        btnAGCLoginPg.Text = "AGENCY"
        btnAGCLoginPg.UseVisualStyleBackColor = False
        ' 
        ' btnOFWLoginPg
        ' 
        btnOFWLoginPg.BackColor = Color.FromArgb(CByte(7), CByte(30), CByte(34))
        btnOFWLoginPg.FlatStyle = FlatStyle.Popup
        btnOFWLoginPg.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOFWLoginPg.ForeColor = Color.FromArgb(CByte(29), CByte(120), CByte(116))
        btnOFWLoginPg.Location = New Point(950, 1018)
        btnOFWLoginPg.Margin = New Padding(4, 6, 4, 6)
        btnOFWLoginPg.Name = "btnOFWLoginPg"
        btnOFWLoginPg.Size = New Size(240, 105)
        btnOFWLoginPg.TabIndex = 24
        btnOFWLoginPg.Text = "OFW"
        btnOFWLoginPg.UseVisualStyleBackColor = False
        ' 
        ' imgLogoLoginPg
        ' 
        imgLogoLoginPg.Image = My.Resources.Resources.Untitled_design__7_
        imgLogoLoginPg.Location = New Point(1084, 351)
        imgLogoLoginPg.Margin = New Padding(4, 6, 4, 6)
        imgLogoLoginPg.Name = "imgLogoLoginPg"
        imgLogoLoginPg.Size = New Size(557, 693)
        imgLogoLoginPg.TabIndex = 23
        imgLogoLoginPg.TabStop = False
        ' 
        ' imgLoginPg
        ' 
        imgLoginPg.Image = CType(resources.GetObject("imgLoginPg.Image"), Image)
        imgLoginPg.Location = New Point(0, -1)
        imgLoginPg.Margin = New Padding(4, 6, 4, 6)
        imgLoginPg.Name = "imgLoginPg"
        imgLoginPg.Size = New Size(984, 1439)
        imgLoginPg.TabIndex = 22
        imgLoginPg.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1115, 459)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 29)
        Label2.TabIndex = 32
        Label2.Text = "Password"
        ' 
        ' txtAGCPassLogin
        ' 
        txtAGCPassLogin.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAGCPassLogin.Location = New Point(1115, 497)
        txtAGCPassLogin.Margin = New Padding(4, 4, 4, 4)
        txtAGCPassLogin.Name = "txtAGCPassLogin"
        txtAGCPassLogin.PlaceholderText = "Password"
        txtAGCPassLogin.Size = New Size(187, 35)
        txtAGCPassLogin.TabIndex = 33
        txtAGCPassLogin.UseSystemPasswordChar = True
        ' 
        ' AGENCYLoginPage
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(txtAGCPassLogin)
        Controls.Add(Label2)
        Controls.Add(btnOkAGCLoginPg)
        Controls.Add(txtbxAGCIdLogin)
        Controls.Add(Label1)
        Controls.Add(btnCloseLoginPg)
        Controls.Add(btnEMPLoginPg)
        Controls.Add(btnAGCLoginPg)
        Controls.Add(btnOFWLoginPg)
        Controls.Add(imgLogoLoginPg)
        Controls.Add(imgLoginPg)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 6, 4, 6)
        Name = "AGENCYLoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AGENYLoginPage"
        WindowState = FormWindowState.Maximized
        CType(imgLogoLoginPg, ComponentModel.ISupportInitialize).EndInit()
        CType(imgLoginPg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnOkAGCLoginPg As Button
    Friend WithEvents txtbxAGCIdLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCloseLoginPg As Button
    Friend WithEvents btnEMPLoginPg As Button
    Friend WithEvents btnAGCLoginPg As Button
    Friend WithEvents btnOFWLoginPg As Button
    Friend WithEvents imgLogoLoginPg As PictureBox
    Friend WithEvents imgLoginPg As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAGCPassLogin As TextBox
End Class




