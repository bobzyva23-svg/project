Public Class Predictionform

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Predictionform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel3.Visible = False
        BACK3BTN.Visible = False

        'TODO: This line of code loads data into the 'PredictedResultDatabase1DataSet1.PredictedTable' table. You can move, or remove it, as needed.
        Me.PredictedTableTableAdapter.Fill(Me.PredictedResultDatabase1DataSet1.PredictedTable)
        TextBox1.Text = SearchForm.TextBox2.Text
        FullNameTextBox.Text = SearchForm.TextBox3.Text
        TextBox2.Text = SearchForm.TextBox4.Text
        AgeTextBox.Text = SearchForm.TextBox5.Text
    End Sub

    Private Sub Predictbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Predictbtn1.Click


        If TextBox3.Text = "" Or ComboBox4.Text = "" Or ComboBox5.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Fill in all the Text Fields, We have blanck text fields")
        Else

            PredictedTableBindingSource.AddNew()

            PIDNOTXT.Text = TextBox1.Text
            PFULLNAMETXT.Text = FullNameTextBox.Text
            GENDERTEXT.Text = TextBox2.Text
            AgeTxt.Text = AgeTextBox.Text
            Glucoseleveltxt.Text = TextBox3.Text
            Worktypetxt.Text = ComboBox4.Text
            SmokedStatustxt.Text = ComboBox5.Text
            BMItxt.Text = ComboBox1.Text
            HypertensionTxt.Text = ComboBox2.Text
            HeartDiseseTxt.Text = ComboBox3.Text


            PID2TextBox.Text = TextBox1.Text
            FULLNAME2TextBox.Text = FullNameTextBox.Text
            GENDER2TextBox.Text = GENDERTEXT.Text
            AGE2TextBox.Text = AgeTxt.Text
            GLUCOSE2TextBox.Text = Glucoseleveltxt.Text
            WORKEDTYPE2TextBox.Text = Worktypetxt.Text
            SMOKED2TextBox.Text = SmokedStatustxt.Text
            BODYMI2TextBox.Text = BMItxt.Text
            HYPERTENSION2TextBox.Text = HypertensionTxt.Text
            HEARTDISEASETextBox.Text = HeartDiseseTxt.Text
            RESULTTextBox.Text = resulttext.Text

            If Val(AgeTextBox.Text) < 6 And Val(Glucoseleveltxt.Text) < 30 Then
                resulttext.Text = "You Don't have any stroke"

            ElseIf Val(AgeTextBox.Text) >= 7 And Val(AgeTextBox.Text) <= 17 And Val(Glucoseleveltxt.Text) < 600 Then
                resulttext.Text = "You Don't have any stroke"

            ElseIf Val(AgeTextBox.Text) >= 18 And Val(Glucoseleveltxt.Text) <= 30 Then
                resulttext.Text = "You Don't have any stroke"
            Else
                resulttext.Text = "You have stroke, Please Consult a Doctor Immediately"

            End If
            Panel3.Visible = True
            Panel1.Visible = False
            BACK3BTN.Visible = False
            SaveUpdatebtn1.Visible = True
        End If


        

    End Sub

    Private Sub PredictedTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PredictedTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PredictedTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PredictedResultDatabase1DataSet1)

    End Sub

    Private Sub SaveUpdatebtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveUpdatebtn1.Click
        RESULTTextBox.Text = resulttext.Text
        Panel3.Visible = True
        Panel1.Visible = False
        BACK3BTN.Visible = True

        SaveUpdatebtn1.Visible = False


        On Error GoTo SaveErr
        PredictedTableBindingSource.EndEdit()
        PredictedTableTableAdapter.Update(PredictedResultDatabase1DataSet1.PredictedTable)
SaveErr:
        Exit Sub
    End Sub

    Private Sub BACK3BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK3BTN.Click
        Panel3.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub EXITBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
End Class