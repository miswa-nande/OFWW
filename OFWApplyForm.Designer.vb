<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OFWApplyForm
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
        lblJobName = New Label()
        lblJobAgency = New Label()
        Label1 = New Label()
        OFWPic = New PictureBox()
        names = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        dateDOB = New DateTimePicker()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        Label7 = New Label()
        TextBox10 = New TextBox()
        Label8 = New Label()
        TextBox11 = New TextBox()
        Label9 = New Label()
        Button1 = New Button()
        Label10 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Label11 = New Label()
        Button4 = New Button()
        Label12 = New Label()
        Button5 = New Button()
        Label13 = New Label()
        Button6 = New Button()
        Label14 = New Label()
        Button7 = New Button()
        Label15 = New Label()
        Button8 = New Button()
        Label16 = New Label()
        Button9 = New Button()
        Label17 = New Label()
        Button10 = New Button()
        Label18 = New Label()
        Button11 = New Button()
        Label19 = New Label()
        Button12 = New Button()
        Label20 = New Label()
        Button23 = New Button()
        Label31 = New Label()
        Button24 = New Button()
        Label32 = New Label()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        CType(OFWPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJobName
        ' 
        lblJobName.AutoSize = True
        lblJobName.Font = New Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJobName.Location = New Point(27, 28)
        lblJobName.Margin = New Padding(4, 0, 4, 0)
        lblJobName.Name = "lblJobName"
        lblJobName.Size = New Size(584, 54)
        lblJobName.TabIndex = 0
        lblJobName.Text = "Selected Job Name here"
        ' 
        ' lblJobAgency
        ' 
        lblJobAgency.AutoSize = True
        lblJobAgency.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJobAgency.Location = New Point(27, 88)
        lblJobAgency.Margin = New Padding(4, 0, 4, 0)
        lblJobAgency.Name = "lblJobAgency"
        lblJobAgency.Size = New Size(450, 39)
        lblJobAgency.TabIndex = 1
        lblJobAgency.Text = "Selected Job Agency here"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(27, 133)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(384, 32)
        Label1.TabIndex = 2
        Label1.Text = "Selected Job Employer here"
        ' 
        ' OFWPic
        ' 
        OFWPic.Location = New Point(31, 190)
        OFWPic.Margin = New Padding(4, 4, 4, 4)
        OFWPic.Name = "OFWPic"
        OFWPic.Size = New Size(271, 295)
        OFWPic.TabIndex = 3
        OFWPic.TabStop = False
        ' 
        ' names
        ' 
        names.AutoSize = True
        names.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        names.Location = New Point(316, 190)
        names.Margin = New Padding(4, 0, 4, 0)
        names.Name = "names"
        names.Size = New Size(106, 23)
        names.TabIndex = 4
        names.Text = "Full Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(316, 220)
        TextBox1.Margin = New Padding(4, 4, 4, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Last Name"
        TextBox1.Size = New Size(248, 29)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(573, 220)
        TextBox2.Margin = New Padding(4, 4, 4, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "First Name"
        TextBox2.Size = New Size(248, 29)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(831, 220)
        TextBox3.Margin = New Padding(4, 4, 4, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Middle Name"
        TextBox3.Size = New Size(248, 29)
        TextBox3.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(316, 256)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 23)
        Label2.TabIndex = 8
        Label2.Text = "Birthdate"
        ' 
        ' dateDOB
        ' 
        dateDOB.Format = DateTimePickerFormat.Short
        dateDOB.Location = New Point(316, 286)
        dateDOB.Margin = New Padding(4, 4, 4, 4)
        dateDOB.Name = "dateDOB"
        dateDOB.Size = New Size(157, 29)
        dateDOB.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(482, 256)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 23)
        Label3.TabIndex = 10
        Label3.Text = "Sex"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(482, 286)
        ComboBox1.Margin = New Padding(4, 4, 4, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(160, 29)
        ComboBox1.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(651, 256)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 23)
        Label4.TabIndex = 12
        Label4.Text = "Civil Status"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(651, 286)
        ComboBox2.Margin = New Padding(4, 4, 4, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(160, 29)
        ComboBox2.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(819, 256)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 23)
        Label5.TabIndex = 14
        Label5.Text = "Religion"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(819, 286)
        TextBox4.Margin = New Padding(4, 4, 4, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Religion"
        TextBox4.Size = New Size(260, 29)
        TextBox4.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(316, 322)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 23)
        Label6.TabIndex = 16
        Label6.Text = "Address"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(316, 351)
        TextBox5.Margin = New Padding(4, 4, 4, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Steet"
        TextBox5.Size = New Size(192, 29)
        TextBox5.TabIndex = 17
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(517, 351)
        TextBox6.Margin = New Padding(4, 4, 4, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "Barangay"
        TextBox6.Size = New Size(192, 29)
        TextBox6.TabIndex = 18
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(717, 351)
        TextBox7.Margin = New Padding(4, 4, 4, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "Municipality/City"
        TextBox7.Size = New Size(192, 29)
        TextBox7.TabIndex = 19
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(918, 351)
        TextBox8.Margin = New Padding(4, 4, 4, 4)
        TextBox8.Name = "TextBox8"
        TextBox8.PlaceholderText = "Province/State"
        TextBox8.Size = New Size(192, 29)
        TextBox8.TabIndex = 20
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(316, 388)
        TextBox9.Margin = New Padding(4, 4, 4, 4)
        TextBox9.Name = "TextBox9"
        TextBox9.PlaceholderText = "Zipcode"
        TextBox9.Size = New Size(125, 29)
        TextBox9.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(316, 424)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 23)
        Label7.TabIndex = 22
        Label7.Text = "E-mail Address"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(316, 454)
        TextBox10.Margin = New Padding(4, 4, 4, 4)
        TextBox10.Name = "TextBox10"
        TextBox10.PlaceholderText = "user@gmail.com"
        TextBox10.Size = New Size(310, 29)
        TextBox10.TabIndex = 23
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(634, 424)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 23)
        Label8.TabIndex = 24
        Label8.Text = "Contact Number"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(635, 454)
        TextBox11.Margin = New Padding(4, 4, 4, 4)
        TextBox11.Name = "TextBox11"
        TextBox11.PlaceholderText = "##########"
        TextBox11.Size = New Size(221, 29)
        TextBox11.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(31, 554)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(165, 23)
        Label9.TabIndex = 26
        Label9.Text = "Birth Certificate"
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.ForestGreen
        Button1.Location = New Point(132, 581)
        Button1.Margin = New Padding(4, 4, 4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 34)
        Button1.TabIndex = 27
        Button1.Text = "Attach Image"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(258, 578)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(175, 27)
        Label10.TabIndex = 28
        Label10.Text = "AttachedImage.jpg"
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.IndianRed
        Button2.Location = New Point(31, 581)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 34)
        Button2.TabIndex = 29
        Button2.Text = "Clear Field"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.ForeColor = Color.IndianRed
        Button3.Location = New Point(31, 647)
        Button3.Margin = New Padding(4, 4, 4, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 34)
        Button3.TabIndex = 33
        Button3.Text = "Clear Field"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(258, 645)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(175, 27)
        Label11.TabIndex = 32
        Label11.Text = "AttachedImage.jpg"
        ' 
        ' Button4
        ' 
        Button4.ForeColor = Color.ForestGreen
        Button4.Location = New Point(132, 647)
        Button4.Margin = New Padding(4, 4, 4, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(118, 34)
        Button4.TabIndex = 31
        Button4.Text = "Attach Image"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(31, 620)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(250, 23)
        Label12.TabIndex = 30
        Label12.Text = "Passport Num w/ Picture"
        ' 
        ' Button5
        ' 
        Button5.ForeColor = Color.IndianRed
        Button5.Location = New Point(31, 714)
        Button5.Margin = New Padding(4, 4, 4, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 34)
        Button5.TabIndex = 37
        Button5.Text = "Clear Field"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(258, 711)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(175, 27)
        Label13.TabIndex = 36
        Label13.Text = "AttachedImage.jpg"
        ' 
        ' Button6
        ' 
        Button6.ForeColor = Color.ForestGreen
        Button6.Location = New Point(132, 714)
        Button6.Margin = New Padding(4, 4, 4, 4)
        Button6.Name = "Button6"
        Button6.Size = New Size(118, 34)
        Button6.TabIndex = 35
        Button6.Text = "Attach Image"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(31, 687)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(151, 23)
        Label14.TabIndex = 34
        Label14.Text = "NBI Clearance"
        ' 
        ' Button7
        ' 
        Button7.ForeColor = Color.IndianRed
        Button7.Location = New Point(31, 914)
        Button7.Margin = New Padding(4, 4, 4, 4)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 34)
        Button7.TabIndex = 49
        Button7.Text = "Clear Field"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(258, 911)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(175, 27)
        Label15.TabIndex = 48
        Label15.Text = "AttachedImage.jpg"
        ' 
        ' Button8
        ' 
        Button8.ForeColor = Color.ForestGreen
        Button8.Location = New Point(132, 914)
        Button8.Margin = New Padding(4, 4, 4, 4)
        Button8.Name = "Button8"
        Button8.Size = New Size(118, 34)
        Button8.TabIndex = 47
        Button8.Text = "Attach Image"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(31, 888)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(192, 23)
        Label16.TabIndex = 46
        Label16.Text = "Yellow Card (BOQ)"
        ' 
        ' Button9
        ' 
        Button9.ForeColor = Color.IndianRed
        Button9.Location = New Point(31, 847)
        Button9.Margin = New Padding(4, 4, 4, 4)
        Button9.Name = "Button9"
        Button9.Size = New Size(94, 34)
        Button9.TabIndex = 45
        Button9.Text = "Clear Field"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(258, 844)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(175, 27)
        Label17.TabIndex = 44
        Label17.Text = "AttachedImage.jpg"
        ' 
        ' Button10
        ' 
        Button10.ForeColor = Color.ForestGreen
        Button10.Location = New Point(132, 847)
        Button10.Margin = New Padding(4, 4, 4, 4)
        Button10.Name = "Button10"
        Button10.Size = New Size(118, 34)
        Button10.TabIndex = 43
        Button10.Text = "Attach Image"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(31, 820)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(75, 23)
        Label18.TabIndex = 42
        Label18.Text = "SSS ID"
        ' 
        ' Button11
        ' 
        Button11.ForeColor = Color.IndianRed
        Button11.Location = New Point(31, 781)
        Button11.Margin = New Padding(4, 4, 4, 4)
        Button11.Name = "Button11"
        Button11.Size = New Size(94, 34)
        Button11.TabIndex = 41
        Button11.Text = "Clear Field"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(258, 778)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(175, 27)
        Label19.TabIndex = 40
        Label19.Text = "AttachedImage.jpg"
        ' 
        ' Button12
        ' 
        Button12.ForeColor = Color.ForestGreen
        Button12.Location = New Point(132, 781)
        Button12.Margin = New Padding(4, 4, 4, 4)
        Button12.Name = "Button12"
        Button12.Size = New Size(118, 34)
        Button12.TabIndex = 39
        Button12.Text = "Attach Image"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(31, 755)
        Label20.Margin = New Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(333, 23)
        Label20.TabIndex = 38
        Label20.Text = "Diploma  / Form-137 (Highschool)"
        ' 
        ' Button23
        ' 
        Button23.ForeColor = Color.IndianRed
        Button23.Location = New Point(31, 981)
        Button23.Margin = New Padding(4, 4, 4, 4)
        Button23.Name = "Button23"
        Button23.Size = New Size(94, 34)
        Button23.TabIndex = 53
        Button23.Text = "Clear Field"
        Button23.UseVisualStyleBackColor = True
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(258, 979)
        Label31.Margin = New Padding(4, 0, 4, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(175, 27)
        Label31.TabIndex = 52
        Label31.Text = "AttachedImage.jpg"
        ' 
        ' Button24
        ' 
        Button24.ForeColor = Color.ForestGreen
        Button24.Location = New Point(132, 981)
        Button24.Margin = New Padding(4, 4, 4, 4)
        Button24.Name = "Button24"
        Button24.Size = New Size(118, 34)
        Button24.TabIndex = 51
        Button24.Text = "Attach Image"
        Button24.UseVisualStyleBackColor = True
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(31, 955)
        Label32.Margin = New Padding(4, 0, 4, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(121, 23)
        Label32.TabIndex = 50
        Label32.Text = "PAGIBIG ID"
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.RoyalBlue
        Button13.FlatStyle = FlatStyle.Popup
        Button13.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button13.ForeColor = Color.PowderBlue
        Button13.Location = New Point(918, 1057)
        Button13.Margin = New Padding(4, 4, 4, 4)
        Button13.Name = "Button13"
        Button13.Size = New Size(224, 69)
        Button13.TabIndex = 54
        Button13.Text = "Send Application"
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.Red
        Button14.FlatStyle = FlatStyle.Popup
        Button14.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button14.ForeColor = Color.Snow
        Button14.Location = New Point(687, 1057)
        Button14.Margin = New Padding(4, 4, 4, 4)
        Button14.Name = "Button14"
        Button14.Size = New Size(224, 69)
        Button14.TabIndex = 55
        Button14.Text = "Cancel"
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.ForeColor = Color.ForestGreen
        Button15.Location = New Point(109, 494)
        Button15.Margin = New Padding(4, 4, 4, 4)
        Button15.Name = "Button15"
        Button15.Size = New Size(118, 34)
        Button15.TabIndex = 56
        Button15.Text = "Attach Image"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' OFWApplyForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(1157, 1102)
        Controls.Add(Button15)
        Controls.Add(Button14)
        Controls.Add(Button13)
        Controls.Add(Button23)
        Controls.Add(Label31)
        Controls.Add(Button24)
        Controls.Add(Label32)
        Controls.Add(Button7)
        Controls.Add(Label15)
        Controls.Add(Button8)
        Controls.Add(Label16)
        Controls.Add(Button9)
        Controls.Add(Label17)
        Controls.Add(Button10)
        Controls.Add(Label18)
        Controls.Add(Button11)
        Controls.Add(Label19)
        Controls.Add(Button12)
        Controls.Add(Label20)
        Controls.Add(Button5)
        Controls.Add(Label13)
        Controls.Add(Button6)
        Controls.Add(Label14)
        Controls.Add(Button3)
        Controls.Add(Label11)
        Controls.Add(Button4)
        Controls.Add(Label12)
        Controls.Add(Button2)
        Controls.Add(Label10)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(TextBox11)
        Controls.Add(Label8)
        Controls.Add(TextBox10)
        Controls.Add(Label7)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(ComboBox2)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(dateDOB)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(names)
        Controls.Add(OFWPic)
        Controls.Add(Label1)
        Controls.Add(lblJobAgency)
        Controls.Add(lblJobName)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "OFWApplyForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OFWApplyForm"
        CType(OFWPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJobName As Label
    Friend WithEvents lblJobAgency As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OFWPic As PictureBox
    Friend WithEvents names As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dateDOB As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Button23 As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Button24 As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
End Class
