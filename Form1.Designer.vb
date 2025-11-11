<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EXITBTN = New System.Windows.Forms.Button()
        Me.mainmenubtn = New System.Windows.Forms.Button()
        Me.REPORTBTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Reportpanel = New System.Windows.Forms.Panel()
        Me.Statisticsbtn = New System.Windows.Forms.Button()
        Me.regist_Btn = New System.Windows.Forms.Button()
        Me.Predictbtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Registrationbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reportpanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.EXITBTN)
        Me.Panel1.Controls.Add(Me.mainmenubtn)
        Me.Panel1.Controls.Add(Me.REPORTBTN)
        Me.Panel1.Location = New System.Drawing.Point(-14, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2366, 121)
        Me.Panel1.TabIndex = 0
        '
        'EXITBTN
        '
        Me.EXITBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EXITBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.ForeColor = System.Drawing.SystemColors.Control
        Me.EXITBTN.Location = New System.Drawing.Point(1764, 43)
        Me.EXITBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(145, 64)
        Me.EXITBTN.TabIndex = 10
        Me.EXITBTN.Text = "EXIT"
        Me.EXITBTN.UseVisualStyleBackColor = False
        '
        'mainmenubtn
        '
        Me.mainmenubtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mainmenubtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainmenubtn.ForeColor = System.Drawing.SystemColors.Control
        Me.mainmenubtn.Location = New System.Drawing.Point(194, 43)
        Me.mainmenubtn.Margin = New System.Windows.Forms.Padding(4)
        Me.mainmenubtn.Name = "mainmenubtn"
        Me.mainmenubtn.Size = New System.Drawing.Size(282, 73)
        Me.mainmenubtn.TabIndex = 6
        Me.mainmenubtn.Text = "MAIN MENU"
        Me.mainmenubtn.UseVisualStyleBackColor = False
        '
        'REPORTBTN
        '
        Me.REPORTBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.REPORTBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTBTN.ForeColor = System.Drawing.SystemColors.Control
        Me.REPORTBTN.Location = New System.Drawing.Point(1445, 43)
        Me.REPORTBTN.Margin = New System.Windows.Forms.Padding(4)
        Me.REPORTBTN.Name = "REPORTBTN"
        Me.REPORTBTN.Size = New System.Drawing.Size(256, 73)
        Me.REPORTBTN.TabIndex = 9
        Me.REPORTBTN.Text = "REPORT"
        Me.REPORTBTN.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(491, 199)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(909, 696)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Reportpanel
        '
        Me.Reportpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reportpanel.Controls.Add(Me.Statisticsbtn)
        Me.Reportpanel.Controls.Add(Me.regist_Btn)
        Me.Reportpanel.Controls.Add(Me.Predictbtn)
        Me.Reportpanel.Location = New System.Drawing.Point(1431, 106)
        Me.Reportpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.Reportpanel.Name = "Reportpanel"
        Me.Reportpanel.Size = New System.Drawing.Size(256, 240)
        Me.Reportpanel.TabIndex = 8
        '
        'Statisticsbtn
        '
        Me.Statisticsbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Statisticsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statisticsbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Statisticsbtn.Location = New System.Drawing.Point(22, 158)
        Me.Statisticsbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Statisticsbtn.Name = "Statisticsbtn"
        Me.Statisticsbtn.Size = New System.Drawing.Size(204, 66)
        Me.Statisticsbtn.TabIndex = 3
        Me.Statisticsbtn.Text = "Statistics"
        Me.Statisticsbtn.UseVisualStyleBackColor = False
        '
        'regist_Btn
        '
        Me.regist_Btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.regist_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regist_Btn.ForeColor = System.Drawing.SystemColors.Control
        Me.regist_Btn.Location = New System.Drawing.Point(22, 13)
        Me.regist_Btn.Margin = New System.Windows.Forms.Padding(4)
        Me.regist_Btn.Name = "regist_Btn"
        Me.regist_Btn.Size = New System.Drawing.Size(204, 60)
        Me.regist_Btn.TabIndex = 1
        Me.regist_Btn.Text = "Registration"
        Me.regist_Btn.UseVisualStyleBackColor = False
        '
        'Predictbtn
        '
        Me.Predictbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Predictbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Predictbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Predictbtn.Location = New System.Drawing.Point(22, 82)
        Me.Predictbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Predictbtn.Name = "Predictbtn"
        Me.Predictbtn.Size = New System.Drawing.Size(204, 66)
        Me.Predictbtn.TabIndex = 2
        Me.Predictbtn.Text = "Prediction"
        Me.Predictbtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Registrationbtn)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(180, 106)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(282, 186)
        Me.Panel2.TabIndex = 7
        '
        'Registrationbtn
        '
        Me.Registrationbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Registrationbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrationbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Registrationbtn.Location = New System.Drawing.Point(16, 16)
        Me.Registrationbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.Registrationbtn.Name = "Registrationbtn"
        Me.Registrationbtn.Size = New System.Drawing.Size(253, 69)
        Me.Registrationbtn.TabIndex = 1
        Me.Registrationbtn.Text = "Register Patients"
        Me.Registrationbtn.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(16, 93)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(253, 69)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Stroke Prediction"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(1914, 1045)
        Me.Controls.Add(Me.Reportpanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reportpanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mainmenubtn As System.Windows.Forms.Button
    Friend WithEvents REPORTBTN As System.Windows.Forms.Button
    Friend WithEvents Reportpanel As System.Windows.Forms.Panel
    Friend WithEvents regist_Btn As System.Windows.Forms.Button
    Friend WithEvents Predictbtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Registrationbtn As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents EXITBTN As System.Windows.Forms.Button
    Friend WithEvents Statisticsbtn As System.Windows.Forms.Button

End Class
