Public Class SearchForm

    Private Sub PateintsRegisTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PateintsRegisTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PateintsRegisTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PatientsRegistrationDatabase1DataSet1)

    End Sub

    Private Sub SearchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        'TODO: This line of code loads data into the 'PatientsRegistrationDatabase1DataSet1.PateintsRegisTable' table. You can move, or remove it, as needed.
        Me.PateintsRegisTableTableAdapter.Fill(Me.PatientsRegistrationDatabase1DataSet1.PateintsRegisTable)

    End Sub

    Private Sub Searchbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchbtn1.Click

        Me.PateintsRegisTableBindingSource.Filter = "Country = '" & Me.TextBox1.Text & "'"

        If TextBox1.Text = CountryTextBox.Text AndAlso TextBox1.Text <> "" Then
            MessageBox.Show("Patient ID " & CountryTextBox.Text & "  Found in Database, With Name " & FullNameTextBox.Text)
            Panel1.Visible = True
            TextBox2.Text = CountryTextBox.Text
            TextBox3.Text = FullNameTextBox.Text
            TextBox4.Text = GenderTextBox.Text
            TextBox5.Text = AgeTextBox.Text
            TextBox7.Text = MarriedTextBox.Text
            TextBox6.Text = StateOfOriginTextBox.Text
            TextBox8.Text = PhoneNOTextBox.Text
            TextBox9.Text = ContactAddressTextBox.Text
            PictureBox3.Image = PictureBox2.Image

        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("You Must Enter a Valid ID to Search", "Stroke Patients Error MessageBox")
            Panel1.Visible = False
        Else
            MessageBox.Show("Patient ID " & TextBox1.Text & " NOT Found in Database", "Stroke Patients Error MessageBox")
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Proceedbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceedbtn.Click
        Predictionform.Show()

    End Sub

    Private Sub EXITBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub EXITBTN22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITBTN22.Click
        Me.Close()

    End Sub
End Class