<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PateintsRegistrationReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PateintsRegisTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsRegistrationDatabase1DataSet1 = New STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PateintsRegisTableTableAdapter = New STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1TableAdapters.PateintsRegisTableTableAdapter()
        CType(Me.PateintsRegisTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsRegistrationDatabase1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PateintsRegisTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "STROKEDISEASE_DETECTION.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1914, 1045)
        Me.ReportViewer1.TabIndex = 0
        '
        'PateintsRegisTableTableAdapter
        '
        Me.PateintsRegisTableTableAdapter.ClearBeforeFill = True
        '
        'PateintsRegistrationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1914, 1045)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PateintsRegistrationReport"
        Me.Text = "PateintsRegistrationReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PateintsRegisTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsRegistrationDatabase1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PateintsRegisTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientsRegistrationDatabase1DataSet1 As STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1
    Friend WithEvents PateintsRegisTableTableAdapter As STROKEDISEASE_DETECTION.PatientsRegistrationDatabase1DataSet1TableAdapters.PateintsRegisTableTableAdapter
End Class
