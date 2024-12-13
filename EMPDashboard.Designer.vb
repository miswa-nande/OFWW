<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPDashboard
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
        EmployerName = New Label()
        AgencyName = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        dgvEmployees = New DataGridView()
        dgvOFWApply = New DataGridView()
        dgvJobs = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDlt = New Button()
        btnViewApply = New Button()
        btnViewEmployees = New Button()
        btnLogout = New Button()
        CType(bg, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvOFWApply, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvJobs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bg
        ' 
        bg.Image = My.Resources.Resources.Untitled_design__7_1
        bg.Location = New Point(0, 0)
        bg.Name = "bg"
        bg.Size = New Size(1920, 1080)
        bg.TabIndex = 0
        bg.TabStop = False
        ' 
        ' EmployerName
        ' 
        EmployerName.AutoSize = True
        EmployerName.BackColor = Color.DeepSkyBlue
        EmployerName.Font = New Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmployerName.Location = New Point(662, 9)
        EmployerName.Name = "EmployerName"
        EmployerName.Size = New Size(696, 75)
        EmployerName.TabIndex = 1
        EmployerName.Text = "Employer Name Here"
        ' 
        ' AgencyName
        ' 
        AgencyName.AutoSize = True
        AgencyName.BackColor = Color.DeepSkyBlue
        AgencyName.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AgencyName.Location = New Point(847, 84)
        AgencyName.Name = "AgencyName"
        AgencyName.Size = New Size(264, 32)
        AgencyName.TabIndex = 2
        AgencyName.Text = "Agency name Here"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(134, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(789, 355)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(1052, 138)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(789, 355)
        Panel2.TabIndex = 4
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(134, 571)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.Size = New Size(513, 390)
        dgvEmployees.TabIndex = 0
        ' 
        ' dgvOFWApply
        ' 
        dgvOFWApply.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOFWApply.Location = New Point(739, 571)
        dgvOFWApply.Name = "dgvOFWApply"
        dgvOFWApply.Size = New Size(513, 390)
        dgvOFWApply.TabIndex = 5
        ' 
        ' dgvJobs
        ' 
        dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJobs.Location = New Point(1333, 571)
        dgvJobs.Name = "dgvJobs"
        dgvJobs.Size = New Size(513, 390)
        dgvJobs.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DeepSkyBlue
        Label1.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(134, 528)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 40)
        Label1.TabIndex = 7
        Label1.Text = "Employees"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DeepSkyBlue
        Label2.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(739, 528)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 40)
        Label2.TabIndex = 8
        Label2.Text = "Applications"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DeepSkyBlue
        Label3.Font = New Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1333, 528)
        Label3.Name = "Label3"
        Label3.Size = New Size(212, 40)
        Label3.TabIndex = 9
        Label3.Text = "Jobs Listed"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.Highlight
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(1680, 967)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(166, 48)
        btnAdd.TabIndex = 10
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.Highlight
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(1508, 967)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(166, 48)
        btnEdit.TabIndex = 11
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDlt
        ' 
        btnDlt.BackColor = SystemColors.Highlight
        btnDlt.FlatStyle = FlatStyle.Popup
        btnDlt.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDlt.Location = New Point(1333, 967)
        btnDlt.Name = "btnDlt"
        btnDlt.Size = New Size(166, 48)
        btnDlt.TabIndex = 12
        btnDlt.Text = "DELETE"
        btnDlt.UseVisualStyleBackColor = False
        ' 
        ' btnViewApply
        ' 
        btnViewApply.BackColor = SystemColors.Highlight
        btnViewApply.FlatStyle = FlatStyle.Popup
        btnViewApply.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewApply.Location = New Point(1086, 967)
        btnViewApply.Name = "btnViewApply"
        btnViewApply.Size = New Size(166, 48)
        btnViewApply.TabIndex = 13
        btnViewApply.Text = "View Details"
        btnViewApply.UseVisualStyleBackColor = False
        ' 
        ' btnViewEmployees
        ' 
        btnViewEmployees.BackColor = SystemColors.Highlight
        btnViewEmployees.FlatStyle = FlatStyle.Popup
        btnViewEmployees.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewEmployees.Location = New Point(481, 967)
        btnViewEmployees.Name = "btnViewEmployees"
        btnViewEmployees.Size = New Size(166, 48)
        btnViewEmployees.TabIndex = 14
        btnViewEmployees.Text = "View Details"
        btnViewEmployees.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Red
        btnLogout.FlatStyle = FlatStyle.Popup
        btnLogout.ForeColor = SystemColors.ButtonHighlight
        btnLogout.Location = New Point(1833, 9)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 15
        btnLogout.Text = "LOG OUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' EMPDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1920, 1080)
        Controls.Add(btnLogout)
        Controls.Add(btnViewEmployees)
        Controls.Add(btnViewApply)
        Controls.Add(btnDlt)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvJobs)
        Controls.Add(dgvOFWApply)
        Controls.Add(dgvEmployees)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(AgencyName)
        Controls.Add(EmployerName)
        Controls.Add(bg)
        FormBorderStyle = FormBorderStyle.None
        Name = "EMPDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EMPDashboard"
        WindowState = FormWindowState.Maximized
        CType(bg, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvOFWApply, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvJobs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bg As PictureBox
    Friend WithEvents EmployerName As Label
    Friend WithEvents AgencyName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents dgvOFWApply As DataGridView
    Friend WithEvents dgvJobs As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDlt As Button
    Friend WithEvents btnViewApply As Button
    Friend WithEvents btnViewEmployees As Button
    Friend WithEvents btnLogout As Button
End Class
