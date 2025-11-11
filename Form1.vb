Public Class Form1

    
    Private Sub mainmenubtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainmenubtn.Click
        Panel2.Visible = True
    End Sub

    Private Sub REPORTBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTBTN.Click
        Reportpanel.Visible = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        Reportpanel.Visible = False
        ProcedForm2.Visible = False
    End Sub

    Private Sub Form1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Panel2.Visible = False
        Reportpanel.Visible = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Panel2.Visible = False
        Reportpanel.Visible = False
    End Sub

    Private Sub Panel1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseHover
        Panel2.Visible = False
        Reportpanel.Visible = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub mainmenubtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles mainmenubtn.MouseHover
        Panel2.Visible = True
        Reportpanel.Visible = False
    End Sub

    Private Sub REPORTBTN_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles REPORTBTN.MouseHover
        Panel2.Visible = False
        Reportpanel.Visible = True
    End Sub

    
   
    Private Sub Registrationbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registrationbtn.Click
        RPatientsRegistrationForm.Show()
    End Sub

    Private Sub regist_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regist_Btn.Click
        PateintsRegistrationReport.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SearchForm.Show()
    End Sub

    Private Sub Predictbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Predictbtn.Click
        ReportformForm2.Show()

    End Sub

    Private Sub EXITBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITBTN.Click
        Me.Close()

    End Sub

    Private Sub Statisticsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Statisticsbtn.Click
        Form2.Show()
    End Sub
End Class
