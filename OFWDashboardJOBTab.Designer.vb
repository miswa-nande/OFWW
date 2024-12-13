<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OFWDashboardJOBTab
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
        btnOFWDashJOB = New Button()
        btnOFWDashOFW = New Button()
        btnOFWDashAGC = New Button()
        btnOFWDashEMP = New Button()
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
        Panel1.Controls.Add(btnOFWDashJOB)
        Panel1.Controls.Add(btnOFWDashOFW)
        Panel1.Controls.Add(btnOFWDashAGC)
        Panel1.Controls.Add(btnOFWDashEMP)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(342, 768)
        Panel1.TabIndex = 7
        ' 
        ' btnOFWDashSTAT
        ' 
        btnOFWDashSTAT.BackColor = Color.RoyalBlue
        btnOFWDashSTAT.FlatAppearance.BorderSize = 0
        btnOFWDashSTAT.FlatStyle = FlatStyle.Flat
        btnOFWDashSTAT.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOFWDashSTAT.ForeColor = Color.MidnightBlue
        btnOFWDashSTAT.Location = New Point(52, 690)
        btnOFWDashSTAT.Name = "btnOFWDashSTAT"
        btnOFWDashSTAT.Size = New Size(237, 45)
        btnOFWDashSTAT.TabIndex = 45
        btnOFWDashSTAT.Text = "Statistics"
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
        btnOFWDashDEP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOFWDashDEP.ForeColor = Color.MidnightBlue
        btnOFWDashDEP.Location = New Point(52, 626)
        btnOFWDashDEP.Name = "btnOFWDashDEP"
        btnOFWDashDEP.Size = New Size(237, 45)
        btnOFWDashDEP.TabIndex = 44
        btnOFWDashDEP.Text = "Deployments"
        btnOFWDashDEP.UseVisualStyleBackColor = False
        ' 
        ' btnOFWDashJOB
        ' 
        btnOFWDashJOB.BackColor = Color.DeepSkyBlue
        btnOFWDashJOB.FlatAppearance.BorderSize = 0
        btnOFWDashJOB.FlatStyle = FlatStyle.Flat
        btnOFWDashJOB.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOFWDashJOB.ForeColor = Color.MidnightBlue
        btnOFWDashJOB.Location = New Point(52, 561)
        btnOFWDashJOB.Name = "btnOFWDashJOB"
        btnOFWDashJOB.Size = New Size(290, 45)
        btnOFWDashJOB.TabIndex = 43
        btnOFWDashJOB.Text = "Job Placements"
        btnOFWDashJOB.UseVisualStyleBackColor = False
        ' 
        ' btnOFWDashOFW
        ' 
        btnOFWDashOFW.BackColor = Color.RoyalBlue
        btnOFWDashOFW.FlatAppearance.BorderSize = 0
        btnOFWDashOFW.FlatStyle = FlatStyle.Flat
        btnOFWDashOFW.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOFWDashOFW.ForeColor = Color.MidnightBlue
        btnOFWDashOFW.Location = New Point(52, 371)
        btnOFWDashOFW.Name = "btnOFWDashOFW"
        btnOFWDashOFW.Size = New Size(237, 45)
        btnOFWDashOFW.TabIndex = 40
        btnOFWDashOFW.Text = "OFWs"
        btnOFWDashOFW.UseVisualStyleBackColor = False
        ' 
        ' btnOFWDashAGC
        ' 
        btnOFWDashAGC.BackColor = Color.RoyalBlue
        btnOFWDashAGC.FlatAppearance.BorderSize = 0
        btnOFWDashAGC.FlatStyle = FlatStyle.Flat
        btnOFWDashAGC.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOFWDashAGC.ForeColor = Color.MidnightBlue
        btnOFWDashAGC.Location = New Point(52, 494)
        btnOFWDashAGC.Name = "btnOFWDashAGC"
        btnOFWDashAGC.Size = New Size(237, 45)
        btnOFWDashAGC.TabIndex = 42
        btnOFWDashAGC.Text = "Agencies"
        btnOFWDashAGC.UseVisualStyleBackColor = False
        ' 
        ' btnOFWDashEMP
        ' 
        btnOFWDashEMP.BackColor = Color.RoyalBlue
        btnOFWDashEMP.FlatAppearance.BorderSize = 0
        btnOFWDashEMP.FlatStyle = FlatStyle.Flat
        btnOFWDashEMP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOFWDashEMP.ForeColor = Color.MidnightBlue
        btnOFWDashEMP.Location = New Point(52, 433)
        btnOFWDashEMP.Name = "btnOFWDashEMP"
        btnOFWDashEMP.Size = New Size(237, 45)
        btnOFWDashEMP.TabIndex = 41
        btnOFWDashEMP.Text = "Employers"
        btnOFWDashEMP.UseVisualStyleBackColor = False
        ' 
        ' OFWDashboardJOBTab
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1366, 768)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "OFWDashboardJOBTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OFWDashboardJOBTab"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOFWDashSTAT As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOFWDashDEP As Button
    Friend WithEvents btnOFWDashJOB As Button
    Friend WithEvents btnOFWDashOFW As Button
    Friend WithEvents btnOFWDashAGC As Button
    Friend WithEvents btnOFWDashEMP As Button
End Class
