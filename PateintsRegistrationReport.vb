Public Class PateintsRegistrationReport

    Private Sub PateintsRegistrationReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatientsRegistrationDatabase1DataSet1.PateintsRegisTable' table. You can move, or remove it, as needed.
        Me.PateintsRegisTableTableAdapter.Fill(Me.PatientsRegistrationDatabase1DataSet1.PateintsRegisTable)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class