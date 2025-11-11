Public Class Form2

    Private Sub PredictedTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PredictedTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PredictedTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PredictedResultDatabase1DataSet1)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Chart1.Visible = False


        'TODO: This line of code loads data into the 'PredictedResultDatabase1DataSet1.PredictedTable' table. You can move, or remove it, as needed.
        Me.PredictedTableTableAdapter.Fill(Me.PredictedResultDatabase1DataSet1.PredictedTable)

    End Sub

    Private Sub statisticbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statisticbtn.Click

        Dim r1 As Integer = (From Rows In PredictedTableDataGridView.Rows.Cast(Of DataGridViewRow)() Where Not Rows.IsNewRow AndAlso Rows.Cells(11).Value.ToString = "You have stroke, Please Consult a Doctor Immediately").Count
        Me.Chart1.Series("Stroke").Points.AddXY("STATISTICS", r1)

        Dim r44 As Integer = (From Rows In PredictedTableDataGridView.Rows.Cast(Of DataGridViewRow)() Where Not Rows.IsNewRow AndAlso Rows.Cells(11).Value.ToString = "You Don't have any stroke").Count
        Me.Chart1.Series("No_Stroke").Points.AddXY("No_Stroke", r44)

        Chart1.Visible = True
        statisticbtn.Visible = False

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class