Public Class ReportformForm2

    Private Sub ReportformForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PredictedResultDatabase1DataSet1.PredictedTable' table. You can move, or remove it, as needed.
        Me.PredictedTableTableAdapter.Fill(Me.PredictedResultDatabase1DataSet1.PredictedTable)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class