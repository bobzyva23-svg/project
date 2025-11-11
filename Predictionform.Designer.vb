<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Predictionform
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
        Me.components = New System.ComponentModel.Container()
        Dim PIDLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Predictionform))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SaveUpdatebtn1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EXITBTN = New System.Windows.Forms.Button()
        Me.Predictbtn1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BACK3BTN = New System.Windows.Forms.Button()
        Me.resulttext = New System.Windows.Forms.TextBox()
        Me.HeartDiseseTxt = New System.Windows.Forms.TextBox()
        Me.HypertensionTxt = New System.Windows.Forms.TextBox()
        Me.BMItxt = New System.Windows.Forms.TextBox()
        Me.SmokedStatustxt = New System.Windows.Forms.TextBox()
        Me.Worktypetxt = New System.Windows.Forms.TextBox()
        Me.Glucoseleveltxt = New System.Windows.Forms.TextBox()
        Me.GENDERTEXT = New System.Windows.Forms.TextBox()
        Me.PIDNOTXT = New System.Windows.Forms.TextBox()
        Me.AgeTxt = New System.Windows.Forms.TextBox()
        Me.PFULLNAMETXT = New System.Windows.Forms.TextBox()
        Me.PredictedResultDatabase1DataSet1 = New STROKEDISEASE_DETECTION.PredictedResultDatabase1DataSet1()
        Me.PredictedTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PredictedTableTableAdapter = New STROKEDISEASE_DETECTION.PredictedResultDatabase1DataSet1TableAdapters.PredictedTableTableAdapter()
        Me.TableAdapterManager = New STROKEDISEASE_DETECTION.PredictedResultDatabase1DataSet1TableAdapters.TableAdapterManager()
        Me.PredictedTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PredictedTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PID1TextBox = New System.Windows.Forms.TextBox()
        Me.PID2TextBox = New System.Windows.Forms.TextBox()
        Me.FULLNAME2TextBox = New System.Windows.Forms.TextBox()
        Me.GENDER2TextBox = New System.Windows.Forms.TextBox()
        Me.AGE2TextBox = New System.Windows.Forms.TextBox()
        Me.GLUCOSE2TextBox = New System.Windows.Forms.TextBox()
        Me.WORKEDTYPE2TextBox = New System.Windows.Forms.TextBox()
        Me.SMOKED2TextBox = New System.Windows.Forms.TextBox()
        Me.BODYMI2TextBox = New System.Windows.Forms.TextBox()
        Me.HYPERTENSION2TextBox = New System.Windows.Forms.TextBox()
        Me.HEARTDISEASETextBox = New System.Windows.Forms.TextBox()
        Me.RESULTTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.TextBox()
        PIDLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PredictedResultDatabase1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PredictedTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PredictedTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PredictedTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIDLabel
        '
        PIDLabel.AutoSize = True
        PIDLabel.Location = New System.Drawing.Point(-253, 113)
        PIDLabel.Name = "PIDLabel"
        PIDLabel.Size = New System.Drawing.Size(62, 29)
        PIDLabel.TabIndex = 2
        PIDLabel.Text = "PID:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(18, 74)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(140, 29)
        FullNameLabel.TabIndex = 4
        FullNameLabel.Text = "Full Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(18, 130)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(107, 29)
        GenderLabel.TabIndex = 6
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(381, 130)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(66, 29)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(19, 16)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(146, 29)
        CountryLabel.TabIndex = 14
        CountryLabel.Text = "Patients ID:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Label1.Location = New System.Drawing.Point(18, 48)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(274, 29)
        Label1.TabIndex = 29
        Label1.Text = "Average Glucos Level:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Label2.Location = New System.Drawing.Point(18, 212)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(280, 29)
        Label2.TabIndex = 31
        Label2.Text = "Body Mass Index(BMI):"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Label3.Location = New System.Drawing.Point(18, 271)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(174, 29)
        Label3.TabIndex = 33
        Label3.Text = "Hypertension:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Label4.Location = New System.Drawing.Point(18, 330)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(185, 29)
        Label4.TabIndex = 34
        Label4.Text = "Heart Disease:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Label5.Location = New System.Drawing.Point(19, 101)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(146, 29)
        Label5.TabIndex = 38
        Label5.Text = "Work Type:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Label6.Location = New System.Drawing.Point(18, 155)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(195, 29)
        Label6.TabIndex = 40
        Label6.Text = "Smoked Status:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(19, 50)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(146, 29)
        Label14.TabIndex = 14
        Label14.Text = "Patients ID:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(19, 104)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(140, 29)
        Label15.TabIndex = 4
        Label15.Text = "Full Name:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(28, 200)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(66, 29)
        Label16.TabIndex = 8
        Label16.Text = "Age:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(18, 152)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(107, 29)
        Label17.TabIndex = 6
        Label17.Text = "Gender:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(19, 251)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(267, 29)
        Label7.TabIndex = 28
        Label7.Text = "Average Glucos Level"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(26, 297)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(139, 29)
        Label8.TabIndex = 29
        Label8.Text = "Work Type"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(26, 350)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(188, 29)
        Label9.TabIndex = 30
        Label9.Text = "Smoked Status"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(28, 399)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(210, 29)
        Label10.TabIndex = 31
        Label10.Text = "Body Mass Index"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(28, 446)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(167, 29)
        Label11.TabIndex = 32
        Label11.Text = "Hypertension"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(30, 494)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(178, 29)
        Label12.TabIndex = 33
        Label12.Text = "Heart Disease"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(215, 7)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(207, 29)
        Label13.TabIndex = 34
        Label13.Text = "Predicted Result"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox5)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(PIDLabel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Location = New System.Drawing.Point(19, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 399)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Input Form for Stroke Prediction"
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBox5.ForeColor = System.Drawing.SystemColors.Info
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"FORMERLY", "NEVER SMOKED", "SMOKES", "UNKNOWN"})
        Me.ComboBox5.Location = New System.Drawing.Point(304, 152)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(246, 37)
        Me.ComboBox5.TabIndex = 41
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBox4.ForeColor = System.Drawing.SystemColors.Info
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"PRIVATE", "SEL-EMPLOYED", "GOVT_JOB"})
        Me.ComboBox4.Location = New System.Drawing.Point(304, 98)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(246, 37)
        Me.ComboBox4.TabIndex = 39
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"YES", "NO"})
        Me.ComboBox3.Location = New System.Drawing.Point(304, 329)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(246, 37)
        Me.ComboBox3.TabIndex = 37
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"YES", "NO"})
        Me.ComboBox2.Location = New System.Drawing.Point(304, 271)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(246, 37)
        Me.ComboBox2.TabIndex = 36
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(304, 48)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(244, 34)
        Me.TextBox3.TabIndex = 28
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SaveUpdatebtn1
        '
        Me.SaveUpdatebtn1.BackColor = System.Drawing.Color.Black
        Me.SaveUpdatebtn1.FlatAppearance.BorderSize = 0
        Me.SaveUpdatebtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveUpdatebtn1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveUpdatebtn1.ForeColor = System.Drawing.Color.Lime
        Me.SaveUpdatebtn1.Location = New System.Drawing.Point(414, 645)
        Me.SaveUpdatebtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveUpdatebtn1.Name = "SaveUpdatebtn1"
        Me.SaveUpdatebtn1.Size = New System.Drawing.Size(189, 56)
        Me.SaveUpdatebtn1.TabIndex = 5
        Me.SaveUpdatebtn1.Text = "SAVE"
        Me.SaveUpdatebtn1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(163, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(439, 38)
        Me.TextBox1.TabIndex = 23
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FullNameTextBox.Enabled = False
        Me.FullNameTextBox.Location = New System.Drawing.Point(163, 75)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(439, 34)
        Me.FullNameTextBox.TabIndex = 5
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AgeTextBox.Enabled = False
        Me.AgeTextBox.Location = New System.Drawing.Point(468, 125)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(134, 34)
        Me.AgeTextBox.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(163, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(145, 34)
        Me.TextBox2.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.EXITBTN)
        Me.Panel1.Controls.Add(Me.Predictbtn1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(CountryLabel)
        Me.Panel1.Controls.Add(Me.AgeTextBox)
        Me.Panel1.Controls.Add(FullNameLabel)
        Me.Panel1.Controls.Add(AgeLabel)
        Me.Panel1.Controls.Add(Me.FullNameTextBox)
        Me.Panel1.Controls.Add(GenderLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(344, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 687)
        Me.Panel1.TabIndex = 27
        '
        'EXITBTN
        '
        Me.EXITBTN.BackColor = System.Drawing.Color.Black
        Me.EXITBTN.FlatAppearance.BorderSize = 0
        Me.EXITBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EXITBTN.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.ForeColor = System.Drawing.Color.Lime
        Me.EXITBTN.Location = New System.Drawing.Point(110, 605)
        Me.EXITBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(198, 56)
        Me.EXITBTN.TabIndex = 29
        Me.EXITBTN.Text = "EXIT"
        Me.EXITBTN.UseVisualStyleBackColor = False
        '
        'Predictbtn1
        '
        Me.Predictbtn1.BackColor = System.Drawing.Color.Black
        Me.Predictbtn1.FlatAppearance.BorderSize = 0
        Me.Predictbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Predictbtn1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Predictbtn1.ForeColor = System.Drawing.Color.Lime
        Me.Predictbtn1.Location = New System.Drawing.Point(371, 605)
        Me.Predictbtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Predictbtn1.Name = "Predictbtn1"
        Me.Predictbtn1.Size = New System.Drawing.Size(198, 56)
        Me.Predictbtn1.TabIndex = 28
        Me.Predictbtn1.Text = "Predict"
        Me.Predictbtn1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BACK3BTN)
        Me.Panel3.Controls.Add(Me.SaveUpdatebtn1)
        Me.Panel3.Controls.Add(Me.resulttext)
        Me.Panel3.Controls.Add(Me.HeartDiseseTxt)
        Me.Panel3.Controls.Add(Me.HypertensionTxt)
        Me.Panel3.Controls.Add(Me.BMItxt)
        Me.Panel3.Controls.Add(Me.SmokedStatustxt)
        Me.Panel3.Controls.Add(Me.Worktypetxt)
        Me.Panel3.Controls.Add(Me.Glucoseleveltxt)
        Me.Panel3.Controls.Add(Label13)
        Me.Panel3.Controls.Add(Label12)
        Me.Panel3.Controls.Add(Label11)
        Me.Panel3.Controls.Add(Label10)
        Me.Panel3.Controls.Add(Label9)
        Me.Panel3.Controls.Add(Label8)
        Me.Panel3.Controls.Add(Label7)
        Me.Panel3.Controls.Add(Me.GENDERTEXT)
        Me.Panel3.Controls.Add(Me.PIDNOTXT)
        Me.Panel3.Controls.Add(Label14)
        Me.Panel3.Controls.Add(Me.AgeTxt)
        Me.Panel3.Controls.Add(Label15)
        Me.Panel3.Controls.Add(Label16)
        Me.Panel3.Controls.Add(Me.PFULLNAMETXT)
        Me.Panel3.Controls.Add(Label17)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(1064, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(679, 706)
        Me.Panel3.TabIndex = 28
        '
        'BACK3BTN
        '
        Me.BACK3BTN.BackColor = System.Drawing.Color.Black
        Me.BACK3BTN.FlatAppearance.BorderSize = 0
        Me.BACK3BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BACK3BTN.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BACK3BTN.ForeColor = System.Drawing.Color.Lime
        Me.BACK3BTN.Location = New System.Drawing.Point(217, 645)
        Me.BACK3BTN.Margin = New System.Windows.Forms.Padding(4)
        Me.BACK3BTN.Name = "BACK3BTN"
        Me.BACK3BTN.Size = New System.Drawing.Size(189, 56)
        Me.BACK3BTN.TabIndex = 43
        Me.BACK3BTN.Text = "Back"
        Me.BACK3BTN.UseVisualStyleBackColor = False
        '
        'resulttext
        '
        Me.resulttext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.resulttext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.resulttext.Enabled = False
        Me.resulttext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resulttext.Location = New System.Drawing.Point(45, 544)
        Me.resulttext.Multiline = True
        Me.resulttext.Name = "resulttext"
        Me.resulttext.Size = New System.Drawing.Size(567, 93)
        Me.resulttext.TabIndex = 42
        '
        'HeartDiseseTxt
        '
        Me.HeartDiseseTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HeartDiseseTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HeartDiseseTxt.Enabled = False
        Me.HeartDiseseTxt.Location = New System.Drawing.Point(293, 493)
        Me.HeartDiseseTxt.Name = "HeartDiseseTxt"
        Me.HeartDiseseTxt.Size = New System.Drawing.Size(319, 34)
        Me.HeartDiseseTxt.TabIndex = 41
        '
        'HypertensionTxt
        '
        Me.HypertensionTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HypertensionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HypertensionTxt.Enabled = False
        Me.HypertensionTxt.Location = New System.Drawing.Point(294, 446)
        Me.HypertensionTxt.Name = "HypertensionTxt"
        Me.HypertensionTxt.Size = New System.Drawing.Size(319, 34)
        Me.HypertensionTxt.TabIndex = 40
        '
        'BMItxt
        '
        Me.BMItxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BMItxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BMItxt.Enabled = False
        Me.BMItxt.Location = New System.Drawing.Point(294, 397)
        Me.BMItxt.Name = "BMItxt"
        Me.BMItxt.Size = New System.Drawing.Size(319, 34)
        Me.BMItxt.TabIndex = 39
        '
        'SmokedStatustxt
        '
        Me.SmokedStatustxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SmokedStatustxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SmokedStatustxt.Enabled = False
        Me.SmokedStatustxt.Location = New System.Drawing.Point(294, 347)
        Me.SmokedStatustxt.Name = "SmokedStatustxt"
        Me.SmokedStatustxt.Size = New System.Drawing.Size(319, 34)
        Me.SmokedStatustxt.TabIndex = 38
        '
        'Worktypetxt
        '
        Me.Worktypetxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Worktypetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Worktypetxt.Enabled = False
        Me.Worktypetxt.Location = New System.Drawing.Point(294, 297)
        Me.Worktypetxt.Name = "Worktypetxt"
        Me.Worktypetxt.Size = New System.Drawing.Size(319, 34)
        Me.Worktypetxt.TabIndex = 37
        '
        'Glucoseleveltxt
        '
        Me.Glucoseleveltxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Glucoseleveltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Glucoseleveltxt.Enabled = False
        Me.Glucoseleveltxt.Location = New System.Drawing.Point(294, 248)
        Me.Glucoseleveltxt.Name = "Glucoseleveltxt"
        Me.Glucoseleveltxt.Size = New System.Drawing.Size(319, 34)
        Me.Glucoseleveltxt.TabIndex = 36
        '
        'GENDERTEXT
        '
        Me.GENDERTEXT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GENDERTEXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GENDERTEXT.Enabled = False
        Me.GENDERTEXT.Location = New System.Drawing.Point(294, 148)
        Me.GENDERTEXT.Name = "GENDERTEXT"
        Me.GENDERTEXT.Size = New System.Drawing.Size(319, 34)
        Me.GENDERTEXT.TabIndex = 27
        '
        'PIDNOTXT
        '
        Me.PIDNOTXT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PIDNOTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PIDNOTXT.Enabled = False
        Me.PIDNOTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIDNOTXT.Location = New System.Drawing.Point(294, 53)
        Me.PIDNOTXT.Name = "PIDNOTXT"
        Me.PIDNOTXT.Size = New System.Drawing.Size(319, 38)
        Me.PIDNOTXT.TabIndex = 23
        '
        'AgeTxt
        '
        Me.AgeTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AgeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AgeTxt.Enabled = False
        Me.AgeTxt.Location = New System.Drawing.Point(294, 199)
        Me.AgeTxt.Name = "AgeTxt"
        Me.AgeTxt.Size = New System.Drawing.Size(319, 34)
        Me.AgeTxt.TabIndex = 9
        '
        'PFULLNAMETXT
        '
        Me.PFULLNAMETXT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PFULLNAMETXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PFULLNAMETXT.Enabled = False
        Me.PFULLNAMETXT.Location = New System.Drawing.Point(294, 102)
        Me.PFULLNAMETXT.Name = "PFULLNAMETXT"
        Me.PFULLNAMETXT.Size = New System.Drawing.Size(319, 34)
        Me.PFULLNAMETXT.TabIndex = 5
        '
        'PredictedResultDatabase1DataSet1
        '
        Me.PredictedResultDatabase1DataSet1.DataSetName = "PredictedResultDatabase1DataSet1"
        Me.PredictedResultDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PredictedTableBindingSource
        '
        Me.PredictedTableBindingSource.DataMember = "PredictedTable"
        Me.PredictedTableBindingSource.DataSource = Me.PredictedResultDatabase1DataSet1
        '
        'PredictedTableTableAdapter
        '
        Me.PredictedTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PredictedTableTableAdapter = Me.PredictedTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = STROKEDISEASE_DETECTION.PredictedResultDatabase1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PredictedTableBindingNavigator
        '
        Me.PredictedTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PredictedTableBindingNavigator.BindingSource = Me.PredictedTableBindingSource
        Me.PredictedTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PredictedTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PredictedTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PredictedTableBindingNavigatorSaveItem})
        Me.PredictedTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PredictedTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PredictedTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PredictedTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PredictedTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PredictedTableBindingNavigator.Name = "PredictedTableBindingNavigator"
        Me.PredictedTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PredictedTableBindingNavigator.Size = New System.Drawing.Size(2351, 27)
        Me.PredictedTableBindingNavigator.TabIndex = 29
        Me.PredictedTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PredictedTableBindingNavigatorSaveItem
        '
        Me.PredictedTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PredictedTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("PredictedTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PredictedTableBindingNavigatorSaveItem.Name = "PredictedTableBindingNavigatorSaveItem"
        Me.PredictedTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.PredictedTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PID1TextBox
        '
        Me.PID1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "PID1", True))
        Me.PID1TextBox.Location = New System.Drawing.Point(26, 434)
        Me.PID1TextBox.Name = "PID1TextBox"
        Me.PID1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.PID1TextBox.TabIndex = 30
        '
        'PID2TextBox
        '
        Me.PID2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "PID2", True))
        Me.PID2TextBox.Enabled = False
        Me.PID2TextBox.Location = New System.Drawing.Point(26, 462)
        Me.PID2TextBox.Name = "PID2TextBox"
        Me.PID2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.PID2TextBox.TabIndex = 32
        '
        'FULLNAME2TextBox
        '
        Me.FULLNAME2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "FULLNAME2", True))
        Me.FULLNAME2TextBox.Enabled = False
        Me.FULLNAME2TextBox.Location = New System.Drawing.Point(26, 490)
        Me.FULLNAME2TextBox.Name = "FULLNAME2TextBox"
        Me.FULLNAME2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.FULLNAME2TextBox.TabIndex = 34
        '
        'GENDER2TextBox
        '
        Me.GENDER2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "GENDER2", True))
        Me.GENDER2TextBox.Enabled = False
        Me.GENDER2TextBox.Location = New System.Drawing.Point(26, 518)
        Me.GENDER2TextBox.Name = "GENDER2TextBox"
        Me.GENDER2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.GENDER2TextBox.TabIndex = 36
        '
        'AGE2TextBox
        '
        Me.AGE2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "AGE2", True))
        Me.AGE2TextBox.Enabled = False
        Me.AGE2TextBox.Location = New System.Drawing.Point(26, 546)
        Me.AGE2TextBox.Name = "AGE2TextBox"
        Me.AGE2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.AGE2TextBox.TabIndex = 38
        '
        'GLUCOSE2TextBox
        '
        Me.GLUCOSE2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "GLUCOSE2", True))
        Me.GLUCOSE2TextBox.Enabled = False
        Me.GLUCOSE2TextBox.Location = New System.Drawing.Point(26, 574)
        Me.GLUCOSE2TextBox.Name = "GLUCOSE2TextBox"
        Me.GLUCOSE2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.GLUCOSE2TextBox.TabIndex = 40
        '
        'WORKEDTYPE2TextBox
        '
        Me.WORKEDTYPE2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "WORKEDTYPE2", True))
        Me.WORKEDTYPE2TextBox.Enabled = False
        Me.WORKEDTYPE2TextBox.Location = New System.Drawing.Point(26, 602)
        Me.WORKEDTYPE2TextBox.Name = "WORKEDTYPE2TextBox"
        Me.WORKEDTYPE2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.WORKEDTYPE2TextBox.TabIndex = 42
        '
        'SMOKED2TextBox
        '
        Me.SMOKED2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "SMOKED2", True))
        Me.SMOKED2TextBox.Enabled = False
        Me.SMOKED2TextBox.Location = New System.Drawing.Point(26, 630)
        Me.SMOKED2TextBox.Name = "SMOKED2TextBox"
        Me.SMOKED2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.SMOKED2TextBox.TabIndex = 44
        '
        'BODYMI2TextBox
        '
        Me.BODYMI2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "BODYMI2", True))
        Me.BODYMI2TextBox.Enabled = False
        Me.BODYMI2TextBox.Location = New System.Drawing.Point(26, 658)
        Me.BODYMI2TextBox.Name = "BODYMI2TextBox"
        Me.BODYMI2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.BODYMI2TextBox.TabIndex = 46
        '
        'HYPERTENSION2TextBox
        '
        Me.HYPERTENSION2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "HYPERTENSION2", True))
        Me.HYPERTENSION2TextBox.Enabled = False
        Me.HYPERTENSION2TextBox.Location = New System.Drawing.Point(26, 686)
        Me.HYPERTENSION2TextBox.Name = "HYPERTENSION2TextBox"
        Me.HYPERTENSION2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.HYPERTENSION2TextBox.TabIndex = 48
        '
        'HEARTDISEASETextBox
        '
        Me.HEARTDISEASETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "HEARTDISEASE", True))
        Me.HEARTDISEASETextBox.Enabled = False
        Me.HEARTDISEASETextBox.Location = New System.Drawing.Point(26, 714)
        Me.HEARTDISEASETextBox.Name = "HEARTDISEASETextBox"
        Me.HEARTDISEASETextBox.Size = New System.Drawing.Size(100, 22)
        Me.HEARTDISEASETextBox.TabIndex = 50
        '
        'RESULTTextBox
        '
        Me.RESULTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PredictedTableBindingSource, "RESULT", True))
        Me.RESULTTextBox.Enabled = False
        Me.RESULTTextBox.Location = New System.Drawing.Point(26, 742)
        Me.RESULTTextBox.Name = "RESULTTextBox"
        Me.RESULTTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RESULTTextBox.TabIndex = 52
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(12, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 416)
        Me.Panel2.TabIndex = 53
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(-73, -14)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(2424, 107)
        Me.Panel4.TabIndex = 54
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.ComboBox1.Location = New System.Drawing.Point(306, 212)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(244, 34)
        Me.ComboBox1.TabIndex = 42
        Me.ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Predictionform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1914, 1045)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PID1TextBox)
        Me.Controls.Add(Me.PID2TextBox)
        Me.Controls.Add(Me.FULLNAME2TextBox)
        Me.Controls.Add(Me.GENDER2TextBox)
        Me.Controls.Add(Me.AGE2TextBox)
        Me.Controls.Add(Me.GLUCOSE2TextBox)
        Me.Controls.Add(Me.WORKEDTYPE2TextBox)
        Me.Controls.Add(Me.SMOKED2TextBox)
        Me.Controls.Add(Me.BODYMI2TextBox)
        Me.Controls.Add(Me.HYPERTENSION2TextBox)
        Me.Controls.Add(Me.HEARTDISEASETextBox)
        Me.Controls.Add(Me.RESULTTextBox)
        Me.Controls.Add(Me.PredictedTableBindingNavigator)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Predictionform"
        Me.Text = "Predictionform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PredictedResultDatabase1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PredictedTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PredictedTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PredictedTableBindingNavigator.ResumeLayout(False)
        Me.PredictedTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveUpdatebtn1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SmokedStatustxt As System.Windows.Forms.TextBox
    Friend WithEvents Worktypetxt As System.Windows.Forms.TextBox
    Friend WithEvents Glucoseleveltxt As System.Windows.Forms.TextBox
    Friend WithEvents GENDERTEXT As System.Windows.Forms.TextBox
    Friend WithEvents PIDNOTXT As System.Windows.Forms.TextBox
    Friend WithEvents AgeTxt As System.Windows.Forms.TextBox
    Friend WithEvents PFULLNAMETXT As System.Windows.Forms.TextBox
    Friend WithEvents HeartDiseseTxt As System.Windows.Forms.TextBox
    Friend WithEvents HypertensionTxt As System.Windows.Forms.TextBox
    Friend WithEvents BMItxt As System.Windows.Forms.TextBox
    Friend WithEvents resulttext As System.Windows.Forms.TextBox
    Friend WithEvents Predictbtn1 As System.Windows.Forms.Button
    Friend WithEvents PredictedResultDatabase1DataSet1 As STROKEDISEASE_DETECTION.PredictedResultDatabase1DataSet1
    Friend WithEvents PredictedTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PredictedTableTableAdapter As STROKEDISEASE_DETECTION.PredictedResultDatabase1DataSet1TableAdapters.PredictedTableTableAdapter
    Friend WithEvents TableAdapterManager As STROKEDISEASE_DETECTION.PredictedResultDatabase1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PredictedTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PredictedTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PID1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PID2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents FULLNAME2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GENDER2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AGE2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GLUCOSE2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents WORKEDTYPE2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SMOKED2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents BODYMI2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents HYPERTENSION2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents HEARTDISEASETextBox As System.Windows.Forms.TextBox
    Friend WithEvents RESULTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BACK3BTN As System.Windows.Forms.Button
    Friend WithEvents EXITBTN As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.TextBox
End Class
