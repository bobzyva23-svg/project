Public Class SplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        TextBox1.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Enabled = False
            ProcedForm2.ShowDialog() 'Me.Hide()
            Me.Close()
        End If

    End Sub

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class