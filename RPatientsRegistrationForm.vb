Public Class RPatientsRegistrationForm

    Private Sub PateintsRegisTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PateintsRegisTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PateintsRegisTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientsRegistrationDatabase1DataSet1)

    End Sub

    Private Sub RPatientsRegistrationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FullNameTextBox.Enabled = False
        ComboBox3.Enabled = False
        AgeTextBox.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        PhoneNOTextBox.Enabled = False
        ContactAddressTextBox.Enabled = False
        UploadPicturebtn.Enabled = False


        'TODO: This line of code loads data into the 'PatientsRegistrationDatabase1DataSet1.PateintsRegisTable' table. You can move, or remove it, as needed.
        Me.PateintsRegisTableTableAdapter.Fill(Me.PatientsRegistrationDatabase1DataSet1.PateintsRegisTable)

    End Sub

    
    Private Sub UploadPicturebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadPicturebtn.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub AddNewbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewbtn1.Click
        Dim SN As Integer
        FullNameTextBox.Enabled = True
        ComboBox3.Enabled = True
        AgeTextBox.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        PhoneNOTextBox.Enabled = True
        ContactAddressTextBox.Enabled = True
        UploadPicturebtn.Enabled = True



        PateintsRegisTableBindingSource.AddNew()
        SN = PateintsRegisTableDataGridView.RowCount
        TextBox1.Text = "PID/ST/MD/" & SN - 1

    End Sub

    Private Sub SaveUpdatebtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveUpdatebtn1.Click
        FullNameTextBox.Text = UCase(FullNameTextBox.Text)
        ContactAddressTextBox.Text = UCase(ContactAddressTextBox.Text)
        FullNameTextBox.Enabled = False
        ComboBox3.Enabled = False
        AgeTextBox.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        PhoneNOTextBox.Enabled = False
        ContactAddressTextBox.Enabled = False
        UploadPicturebtn.Enabled = False



        On Error GoTo SaveErr
        PateintsRegisTableBindingSource.EndEdit()
        PateintsRegisTableTableAdapter.Update(PatientsRegistrationDatabase1DataSet1.PateintsRegisTable)
        MsgBox("Patients Record Save/Updated to Database Table")
SaveErr:
        Exit Sub

    End Sub

    Private Sub Firstbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Firstbtn1.Click
        PateintsRegisTableBindingSource.MoveFirst()
        FullNameTextBox.Enabled = False
        ComboBox3.Enabled = False
        AgeTextBox.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        PhoneNOTextBox.Enabled = False
        ContactAddressTextBox.Enabled = False
        UploadPicturebtn.Enabled = False

    End Sub

    Private Sub Prevbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prevbtn1.Click
        FullNameTextBox.Enabled = False
        ComboBox3.Enabled = False
        AgeTextBox.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        PhoneNOTextBox.Enabled = False
        ContactAddressTextBox.Enabled = False
        UploadPicturebtn.Enabled = False


        PateintsRegisTableBindingSource.MovePrevious()
    End Sub

    Private Sub Nextbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nextbtn1.Click
        FullNameTextBox.Enabled = False
        ComboBox3.Enabled = False
        AgeTextBox.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        PhoneNOTextBox.Enabled = False
        ContactAddressTextBox.Enabled = False
        UploadPicturebtn.Enabled = False


        TextBox1.Text = "PID/ST/MD/" & PIDTextBox.Text
        PateintsRegisTableBindingSource.MoveNext()
    End Sub

    Private Sub Lastbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lastbtn1.Click
        FullNameTextBox.Enabled = False
        ComboBox3.Enabled = False
        AgeTextBox.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        PhoneNOTextBox.Enabled = False
        ContactAddressTextBox.Enabled = False
        UploadPicturebtn.Enabled = False


        PateintsRegisTableBindingSource.MoveLast()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub EXITBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub EditRbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRbtn1.Click
        FullNameTextBox.Enabled = True
        ComboBox3.Enabled = True
        AgeTextBox.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        PhoneNOTextBox.Enabled = True
        ContactAddressTextBox.Enabled = True
        UploadPicturebtn.Enabled = True

    End Sub
End Class