<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OFWDashboardOFWTab
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
        Panel1 = New Panel()
        btnOFWDashSTAT = New Button()
        PictureBox1 = New PictureBox()
        btnOFWDashDEP = New Button()
        btnOFWashJOB = New Button()
        btnOFWDashOFW = New Button()
        btnOFWDashAGC = New Button()
        btnOFWDashEMP = New Button()
        btnExit = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(btnOFWDashSTAT)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnOFWDashDEP)
        Panel1.Controls.Add(btnOFWashJOB)
        Panel1.Controls.Add(btnOFWDashOFW)
        Panel1.Controls.Add(btnOFWDashAGC)
        Panel1.Controls.Add(btnOFWDashEMP)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(342, 1080)
        Panel1.TabIndex = 4
        ' 
        ' btnOFWDashSTAT
        ' 
        btnOFWDashSTAT.BackColor = Color.RoyalBlue
        btnOFWDashSTAT.FlatAppearance.BorderSize = 0
        btnOFWDashSTAT.FlatStyle = FlatStyle.Flat
        btnOFWDashSTAT.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        btnOFWDashSTAT.ForeColor = Color.MidnightBlue
        btnOFWDashSTAT.Location = New Point(52, 690)
        btnOFWDashSTAT.Name = "btnOFWDashSTAT"
        btnOFWDashSTAT.Size = New Size(240, 50)
        btnOFWDashSTAT.TabIndex = 45
        btnOFWDashSTAT.Text = "STATISTICS"
        btnOFWDashSTAT.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Untitled_design__8_
        PictureBox1.Location = New Point(15, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 335)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnOFWDashDEP
        ' 
        btnOFWDashDEP.BackColor = Color.RoyalBlue
        btnOFWDashDEP.FlatAppearance.BorderSize = 0
        btnOFWDashDEP.FlatStyle = FlatStyle.Flat
        btnOFWDashDEP.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        btnOFWDashDEP.ForeColor = Color.MidnightBlue
        btnOFWDashDEP.Location = New Point(52, 626)
        btnOFWDashDEP.Name = "btnOFWDashDEP"
        btnOFWDashDEP.Size = New Size(240, 50)
        btnOFWDashDEP.TabIndex = 44
        btnOFWDashDEP.Text = "DEPLOYMENT"
        btnOFWDashDEP.UseVisualStyleBackColor = False
        ' 
        ' btnOFWashJOB
        ' 
        btnOFWashJOB.BackColor = Color.RoyalBlue
        btnOFWashJOB.FlatAppearance.BorderSize = 0
        btnOFWashJOB.FlatStyle = FlatStyle.Flat
        btnOFWashJOB.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        btnOFWashJOB.ForeColor = Color.MidnightBlue
        btnOFWashJOB.Location = New Point(52, 561)
        btnOFWashJOB.Name = "btnOFWashJOB"
        btnOFWashJOB.Size = New Size(240, 50)
        btnOFWashJOB.TabIndex = 43
        btnOFWashJOB.Text = "JOB PLACEMENT"
        btnOFWashJOB.UseVisualStyleBackColor = False
        ' 
        ' btnOFWDashOFW
        ' 
        btnOFWDashOFW.BackColor = Color.DeepSkyBlue
        btnOFWDashOFW.FlatAppearance.BorderSize = 0
        btnOFWDashOFW.FlatStyle = FlatStyle.Flat
        btnOFWDashOFW.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        btnOFWDashOFW.ForeColor = Color.MidnightBlue
        btnOFWDashOFW.Location = New Point(52, 371)
        btnOFWDashOFW.Name = "btnOFWDashOFW"
        btnOFWDashOFW.Size = New Size(290, 50)
        btnOFWDashOFW.TabIndex = 40
        btnOFWDashOFW.Text = "OFW"
        btnOFWDashOFW.UseVisualStyleBackColor = False
        ' 
        ' btnOFWDashAGC
        ' 
        btnOFWDashAGC.BackColor = Color.RoyalBlue
        btnOFWDashAGC.FlatAppearance.BorderSize = 0
        btnOFWDashAGC.FlatStyle = FlatStyle.Flat
        btnOFWDashAGC.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        btnOFWDashAGC.ForeColor = Color.MidnightBlue
        btnOFWDashAGC.Location = New Point(52, 494)
        btnOFWDashAGC.Name = "btnOFWDashAGC"
        btnOFWDashAGC.Size = New Size(240, 50)
        btnOFWDashAGC.TabIndex = 42
        btnOFWDashAGC.Text = "AGENCY"
        btnOFWDashAGC.UseVisualStyleBackColor = False
        ' 
        ' btnOFWDashEMP
        ' 
        btnOFWDashEMP.BackColor = Color.RoyalBlue
        btnOFWDashEMP.FlatAppearance.BorderSize = 0
        btnOFWDashEMP.FlatStyle = FlatStyle.Flat
        btnOFWDashEMP.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        btnOFWDashEMP.ForeColor = Color.MidnightBlue
        btnOFWDashEMP.Location = New Point(52, 433)
        btnOFWDashEMP.Name = "btnOFWDashEMP"
        btnOFWDashEMP.Size = New Size(240, 50)
        btnOFWDashEMP.TabIndex = 41
        btnOFWDashEMP.Text = "EMPLOYER"
        btnOFWDashEMP.UseVisualStyleBackColor = False
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
        btnExit.TabIndex = 30
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' OFWDashboardOFWTab
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnExit)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "OFWDashboardOFWTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OFWDashboardOFWTab"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOFWDashSTAT As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOFWDashDEP As Button
    Friend WithEvents btnOFWashJOB As Button
    Friend WithEvents btnOFWDashOFW As Button
    Friend WithEvents btnOFWDashAGC As Button
    Friend WithEvents btnOFWDashEMP As Button
    Friend WithEvents btnExit As Button
End Class
