<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPatientsRegistrationForm
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
        Dim MarriedLabel As System.Windows.Forms.Label
        Dim StateOfOriginLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim ContactAddressLabel As System.Windows.Forms.Label
        Dim PhoneNOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPatientsRegistrationForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EditRbtn1 = New System.Windows.Forms.Button()
        Me.SaveUpdatebtn1 = New System.Windows.Forms.Button()
        Me.AddNewbtn1 = New System.Windows.Forms.Button()
        Me.Lastbtn1 = New System.Windows.Forms.Button()
        Me.Nextbtn1 = New System.Windows.Forms.Button()
        Me.Prevbtn1 = New System.Windows.Forms.Button()
        Me.Firstbtn1 = New System.Windows.Forms.Button()
        Me.UploadPicturebtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PateintsRegisTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsRegistrationDatabase1DataSet1 = New STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PhoneNOTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactAddressTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.PateintsRegisTableTableAdapter = New STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1TableAdapters.PateintsRegisTableTableAdapter()
        Me.TableAdapterManager = New STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1TableAdapters.TableAdapterManager()
        Me.PateintsRegisTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PateintsRegisTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PIDTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EXITBTN = New System.Windows.Forms.Button()
        Me.PateintsRegisTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        PIDLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        MarriedLabel = New System.Windows.Forms.Label()
        StateOfOriginLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        ContactAddressLabel = New System.Windows.Forms.Label()
        PhoneNOLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PateintsRegisTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsRegistrationDatabase1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PateintsRegisTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PateintsRegisTableBindingNavigator.SuspendLayout()
        CType(Me.PateintsRegisTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        FullNameLabel.Location = New System.Drawing.Point(55, 104)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(140, 29)
        FullNameLabel.TabIndex = 4
        FullNameLabel.Text = "Full Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(55, 156)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(107, 29)
        GenderLabel.TabIndex = 6
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(482, 158)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(66, 29)
        AgeLabel.TabIndex = 8
        AgeLabel.Text = "Age:"
        '
        'MarriedLabel
        '
        MarriedLabel.AutoSize = True
        MarriedLabel.Location = New System.Drawing.Point(55, 224)
        MarriedLabel.Name = "MarriedLabel"
        MarriedLabel.Size = New System.Drawing.Size(110, 29)
        MarriedLabel.TabIndex = 10
        MarriedLabel.Text = "Married:"
        '
        'StateOfOriginLabel
        '
        StateOfOriginLabel.AutoSize = True
        StateOfOriginLabel.Location = New System.Drawing.Point(468, 224)
        StateOfOriginLabel.Name = "StateOfOriginLabel"
        StateOfOriginLabel.Size = New System.Drawing.Size(80, 29)
        StateOfOriginLabel.TabIndex = 12
        StateOfOriginLabel.Text = "State:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(56, 51)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(146, 29)
        CountryLabel.TabIndex = 14
        CountryLabel.Text = "Patients ID:"
        '
        'ContactAddressLabel
        '
        ContactAddressLabel.AutoSize = True
        ContactAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactAddressLabel.Location = New System.Drawing.Point(33, 355)
        ContactAddressLabel.Name = "ContactAddressLabel"
        ContactAddressLabel.Size = New System.Drawing.Size(211, 29)
        ContactAddressLabel.TabIndex = 16
        ContactAddressLabel.Text = "Contact Address:"
        '
        'PhoneNOLabel
        '
        PhoneNOLabel.AutoSize = True
        PhoneNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNOLabel.Location = New System.Drawing.Point(56, 298)
        PhoneNOLabel.Name = "PhoneNOLabel"
        PhoneNOLabel.Size = New System.Drawing.Size(77, 29)
        PhoneNOLabel.TabIndex = 18
        PhoneNOLabel.Text = "GSM:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.UploadPicturebtn)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(PIDLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNOTextBox)
        Me.GroupBox1.Controls.Add(FullNameLabel)
        Me.GroupBox1.Controls.Add(PhoneNOLabel)
        Me.GroupBox1.Controls.Add(Me.FullNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ContactAddressTextBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(ContactAddressLabel)
        Me.GroupBox1.Controls.Add(AgeLabel)
        Me.GroupBox1.Controls.Add(CountryLabel)
        Me.GroupBox1.Controls.Add(Me.AgeTextBox)
        Me.GroupBox1.Controls.Add(MarriedLabel)
        Me.GroupBox1.Controls.Add(StateOfOriginLabel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(570, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1040, 605)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register Patients"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.EditRbtn1)
        Me.Panel2.Controls.Add(Me.SaveUpdatebtn1)
        Me.Panel2.Controls.Add(Me.AddNewbtn1)
        Me.Panel2.Controls.Add(Me.Lastbtn1)
        Me.Panel2.Controls.Add(Me.Nextbtn1)
        Me.Panel2.Controls.Add(Me.Prevbtn1)
        Me.Panel2.Controls.Add(Me.Firstbtn1)
        Me.Panel2.Location = New System.Drawing.Point(259, 442)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(612, 134)
        Me.Panel2.TabIndex = 26
        '
        'EditRbtn1
        '
        Me.EditRbtn1.BackColor = System.Drawing.Color.Black
        Me.EditRbtn1.FlatAppearance.BorderSize = 0
        Me.EditRbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditRbtn1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRbtn1.ForeColor = System.Drawing.Color.Lime
        Me.EditRbtn1.Location = New System.Drawing.Point(391, 14)
        Me.EditRbtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.EditRbtn1.Name = "EditRbtn1"
        Me.EditRbtn1.Size = New System.Drawing.Size(185, 44)
        Me.EditRbtn1.TabIndex = 6
        Me.EditRbtn1.Text = "Edit Record"
        Me.EditRbtn1.UseVisualStyleBackColor = False
        '
        'SaveUpdatebtn1
        '
        Me.SaveUpdatebtn1.BackColor = System.Drawing.Color.Black
        Me.SaveUpdatebtn1.FlatAppearance.BorderSize = 0
        Me.SaveUpdatebtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveUpdatebtn1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveUpdatebtn1.ForeColor = System.Drawing.Color.Lime
        Me.SaveUpdatebtn1.Location = New System.Drawing.Point(195, 14)
        Me.SaveUpdatebtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveUpdatebtn1.Name = "SaveUpdatebtn1"
        Me.SaveUpdatebtn1.Size = New System.Drawing.Size(188, 44)
        Me.SaveUpdatebtn1.TabIndex = 5
        Me.SaveUpdatebtn1.Text = "Save/Update"
        Me.SaveUpdatebtn1.UseVisualStyleBackColor = False
        '
        'AddNewbtn1
        '
        Me.AddNewbtn1.BackColor = System.Drawing.Color.Black
        Me.AddNewbtn1.FlatAppearance.BorderSize = 0
        Me.AddNewbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewbtn1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewbtn1.ForeColor = System.Drawing.Color.Lime
        Me.AddNewbtn1.Location = New System.Drawing.Point(23, 14)
        Me.AddNewbtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.AddNewbtn1.Name = "AddNewbtn1"
        Me.AddNewbtn1.Size = New System.Drawing.Size(154, 44)
        Me.AddNewbtn1.TabIndex = 4
        Me.AddNewbtn1.Text = "Add New"
        Me.AddNewbtn1.UseVisualStyleBackColor = False
        '
        'Lastbtn1
        '
        Me.Lastbtn1.BackColor = System.Drawing.Color.Black
        Me.Lastbtn1.FlatAppearance.BorderSize = 0
        Me.Lastbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lastbtn1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lastbtn1.ForeColor = System.Drawing.Color.Lime
        Me.Lastbtn1.Location = New System.Drawing.Point(471, 71)
        Me.Lastbtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Lastbtn1.Name = "Lastbtn1"
        Me.Lastbtn1.Size = New System.Drawing.Size(105, 48)
        Me.Lastbtn1.TabIndex = 3
        Me.Lastbtn1.Text = ">>"
        Me.Lastbtn1.UseVisualStyleBackColor = False
        '
        'Nextbtn1
        '
        Me.Nextbtn1.BackColor = System.Drawing.Color.Black
        Me.Nextbtn1.FlatAppearance.BorderSize = 0
        Me.Nextbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nextbtn1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextbtn1.ForeColor = System.Drawing.Color.Lime
        Me.Nextbtn1.Location = New System.Drawing.Point(322, 71)
        Me.Nextbtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Nextbtn1.Name = "Nextbtn1"
        Me.Nextbtn1.Size = New System.Drawing.Size(105, 48)
        Me.Nextbtn1.TabIndex = 2
        Me.Nextbtn1.Text = ">"
        Me.Nextbtn1.UseVisualStyleBackColor = False
        '
        'Prevbtn1
        '
        Me.Prevbtn1.BackColor = System.Drawing.Color.Black
        Me.Prevbtn1.FlatAppearance.BorderSize = 0
        Me.Prevbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Prevbtn1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prevbtn1.ForeColor = System.Drawing.Color.Lime
        Me.Prevbtn1.Location = New System.Drawing.Point(168, 71)
        Me.Prevbtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Prevbtn1.Name = "Prevbtn1"
        Me.Prevbtn1.Size = New System.Drawing.Size(109, 48)
        Me.Prevbtn1.TabIndex = 1
        Me.Prevbtn1.Text = "<"
        Me.Prevbtn1.UseVisualStyleBackColor = False
        '
        'Firstbtn1
        '
        Me.Firstbtn1.BackColor = System.Drawing.Color.Black
        Me.Firstbtn1.FlatAppearance.BorderSize = 0
        Me.Firstbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Firstbtn1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstbtn1.ForeColor = System.Drawing.Color.Lime
        Me.Firstbtn1.Location = New System.Drawing.Point(24, 71)
        Me.Firstbtn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Firstbtn1.Name = "Firstbtn1"
        Me.Firstbtn1.Size = New System.Drawing.Size(112, 48)
        Me.Firstbtn1.TabIndex = 0
        Me.Firstbtn1.Text = "<<"
        Me.Firstbtn1.UseVisualStyleBackColor = False
        '
        'UploadPicturebtn
        '
        Me.UploadPicturebtn.BackColor = System.Drawing.SystemColors.InfoText
        Me.UploadPicturebtn.ForeColor = System.Drawing.SystemColors.Control
        Me.UploadPicturebtn.Location = New System.Drawing.Point(797, 33)
        Me.UploadPicturebtn.Name = "UploadPicturebtn"
        Me.UploadPicturebtn.Size = New System.Drawing.Size(222, 47)
        Me.UploadPicturebtn.TabIndex = 25
        Me.UploadPicturebtn.Text = "Upload Picture"
        Me.UploadPicturebtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PateintsRegisTableBindingSource, "PatientsImage", True))
        Me.PictureBox1.Location = New System.Drawing.Point(797, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 259)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'PateintsRegisTableBindingSource
        '
        Me.PateintsRegisTableBindingSource.DataMember = "PateintsRegisTable"
        Me.PateintsRegisTableBindingSource.DataSource = Me.PatientsRegistrationDatabase1DataSet1
        '
        'PatientsRegistrationDatabase1DataSet1
        '
        Me.PatientsRegistrationDatabase1DataSet1.DataSetName = "PatientsRegistrationDatabase1DataSet1"
        Me.PatientsRegistrationDatabase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "Country", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(275, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(489, 38)
        Me.TextBox1.TabIndex = 23
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "Gender", True))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHERS"})
        Me.ComboBox3.Location = New System.Drawing.Point(275, 155)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(154, 37)
        Me.ComboBox3.TabIndex = 22
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "StateOfOrigin", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"ABIA", "ADAMAWA", "AKWA IBOM", "ANAMBRA", "BAUCHI", "BAYELSA", "BENUE", "BORNO", "CROSS RIVER", "DELTA", "EBONYI", "EDO", "EKITI", "ENUGU", "GOMBE", "IMO", "JIGAWA", "KADUNA", "KANO", "KASTINA", "KEBBI", "KOGI", "KWARA", "LAGOS", "NASARAWA", "NIGER", "OGUN", "ONDO", "OSUN", "OYO", "PLATEAU", "RIVERS", "SOKOTO", "TARABAR", "YOBE", "ZAMFARA"})
        Me.ComboBox2.Location = New System.Drawing.Point(560, 221)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(219, 37)
        Me.ComboBox2.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "Married", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"YES", "NO"})
        Me.ComboBox1.Location = New System.Drawing.Point(275, 216)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 37)
        Me.ComboBox1.TabIndex = 20
        '
        'PhoneNOTextBox
        '
        Me.PhoneNOTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PhoneNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "PhoneNO", True))
        Me.PhoneNOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNOTextBox.Location = New System.Drawing.Point(275, 287)
        Me.PhoneNOTextBox.Name = "PhoneNOTextBox"
        Me.PhoneNOTextBox.Size = New System.Drawing.Size(504, 38)
        Me.PhoneNOTextBox.TabIndex = 19
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(275, 103)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(504, 34)
        Me.FullNameTextBox.TabIndex = 5
        '
        'ContactAddressTextBox
        '
        Me.ContactAddressTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ContactAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "ContactAddress", True))
        Me.ContactAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactAddressTextBox.Location = New System.Drawing.Point(275, 352)
        Me.ContactAddressTextBox.Multiline = True
        Me.ContactAddressTextBox.Name = "ContactAddressTextBox"
        Me.ContactAddressTextBox.Size = New System.Drawing.Size(744, 43)
        Me.ContactAddressTextBox.TabIndex = 17
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(560, 153)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(219, 34)
        Me.AgeTextBox.TabIndex = 9
        '
        'PateintsRegisTableTableAdapter
        '
        Me.PateintsRegisTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PateintsRegisTableTableAdapter = Me.PateintsRegisTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PateintsRegisTableBindingNavigator
        '
        Me.PateintsRegisTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PateintsRegisTableBindingNavigator.BindingSource = Me.PateintsRegisTableBindingSource
        Me.PateintsRegisTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PateintsRegisTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PateintsRegisTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PateintsRegisTableBindingNavigatorSaveItem})
        Me.PateintsRegisTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PateintsRegisTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PateintsRegisTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PateintsRegisTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PateintsRegisTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PateintsRegisTableBindingNavigator.Name = "PateintsRegisTableBindingNavigator"
        Me.PateintsRegisTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PateintsRegisTableBindingNavigator.Size = New System.Drawing.Size(2087, 27)
        Me.PateintsRegisTableBindingNavigator.TabIndex = 1
        Me.PateintsRegisTableBindingNavigator.Text = "BindingNavigator1"
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
        'PateintsRegisTableBindingNavigatorSaveItem
        '
        Me.PateintsRegisTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PateintsRegisTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("PateintsRegisTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PateintsRegisTableBindingNavigatorSaveItem.Name = "PateintsRegisTableBindingNavigatorSaveItem"
        Me.PateintsRegisTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.PateintsRegisTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PIDTextBox
        '
        Me.PIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PateintsRegisTableBindingSource, "PID", True))
        Me.PIDTextBox.Enabled = False
        Me.PIDTextBox.Location = New System.Drawing.Point(135, 42)
        Me.PIDTextBox.Name = "PIDTextBox"
        Me.PIDTextBox.Size = New System.Drawing.Size(111, 22)
        Me.PIDTextBox.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(-109, -38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2196, 111)
        Me.Panel1.TabIndex = 4
        '
        'EXITBTN
        '
        Me.EXITBTN.BackColor = System.Drawing.Color.Black
        Me.EXITBTN.FlatAppearance.BorderSize = 0
        Me.EXITBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EXITBTN.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.ForeColor = System.Drawing.Color.Lime
        Me.EXITBTN.Location = New System.Drawing.Point(1713, 80)
        Me.EXITBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(129, 90)
        Me.EXITBTN.TabIndex = 5
        Me.EXITBTN.Text = "EXIT"
        Me.EXITBTN.UseVisualStyleBackColor = False
        '
        'PateintsRegisTableDataGridView
        '
        Me.PateintsRegisTableDataGridView.AutoGenerateColumns = False
        Me.PateintsRegisTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PateintsRegisTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewImageColumn1})
        Me.PateintsRegisTableDataGridView.DataSource = Me.PateintsRegisTableBindingSource
        Me.PateintsRegisTableDataGridView.Location = New System.Drawing.Point(649, 407)
        Me.PateintsRegisTableDataGridView.Name = "PateintsRegisTableDataGridView"
        Me.PateintsRegisTableDataGridView.RowTemplate.Height = 24
        Me.PateintsRegisTableDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PateintsRegisTableDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FullName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FullName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Married"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Married"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "StateOfOrigin"
        Me.DataGridViewTextBoxColumn6.HeaderText = "StateOfOrigin"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ContactAddress"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ContactAddress"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PhoneNO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PhoneNO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "PatientsImage"
        Me.DataGridViewImageColumn1.HeaderText = "PatientsImage"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'RPatientsRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1914, 1024)
        Me.Controls.Add(Me.EXITBTN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PateintsRegisTableBindingNavigator)
        Me.Controls.Add(Me.PIDTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PateintsRegisTableDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RPatientsRegistrationForm"
        Me.Text = "RPatientsRegistrationForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PateintsRegisTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsRegistrationDatabase1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PateintsRegisTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PateintsRegisTableBindingNavigator.ResumeLayout(False)
        Me.PateintsRegisTableBindingNavigator.PerformLayout()
        CType(Me.PateintsRegisTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PatientsRegistrationDatabase1DataSet1 As STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1
    Friend WithEvents PateintsRegisTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PateintsRegisTableTableAdapter As STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1TableAdapters.PateintsRegisTableTableAdapter
    Friend WithEvents TableAdapterManager As STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PateintsRegisTableBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PateintsRegisTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PhoneNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents UploadPicturebtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EditRbtn1 As System.Windows.Forms.Button
    Friend WithEvents SaveUpdatebtn1 As System.Windows.Forms.Button
    Friend WithEvents AddNewbtn1 As System.Windows.Forms.Button
    Friend WithEvents Lastbtn1 As System.Windows.Forms.Button
    Friend WithEvents Nextbtn1 As System.Windows.Forms.Button
    Friend WithEvents Prevbtn1 As System.Windows.Forms.Button
    Friend WithEvents Firstbtn1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EXITBTN As System.Windows.Forms.Button
    Friend WithEvents PateintsRegisTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
End Class
