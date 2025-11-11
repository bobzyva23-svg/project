Public Class ProcedForm2

    Private Sub Proceedbtn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceedbtn11.Click
        Form1.ShowDialog()
    End Sub

    Private Sub Closebtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Closebtn1.Click
        Me.Close()
    End Sub

    Private Sub ProcedForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplashScreen.Visible = False
    End Sub
End Class