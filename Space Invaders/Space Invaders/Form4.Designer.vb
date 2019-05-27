<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game_over_frm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.restart_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.score_over_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.level_over_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shots_fired_go_lbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hi_scr_name_1 = New System.Windows.Forms.Label()
        Me.hi_scr_name_4 = New System.Windows.Forms.Label()
        Me.hi_scr_name_3 = New System.Windows.Forms.Label()
        Me.hi_scr_name_2 = New System.Windows.Forms.Label()
        Me.hi_scr_name_5 = New System.Windows.Forms.Label()
        Me.hi_scr_name_6 = New System.Windows.Forms.Label()
        Me.hi_scr_4 = New System.Windows.Forms.Label()
        Me.hi_scr_3 = New System.Windows.Forms.Label()
        Me.hi_scr_2 = New System.Windows.Forms.Label()
        Me.hi_scr_1 = New System.Windows.Forms.Label()
        Me.hi_scr_7 = New System.Windows.Forms.Label()
        Me.hi_scr_6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 123.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(981, 171)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GAME OVER"
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.SystemColors.Control
        Me.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.exit_btn.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(716, 668)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(280, 50)
        Me.exit_btn.TabIndex = 2
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'restart_btn
        '
        Me.restart_btn.BackColor = System.Drawing.SystemColors.Control
        Me.restart_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.restart_btn.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restart_btn.Location = New System.Drawing.Point(716, 612)
        Me.restart_btn.Name = "restart_btn"
        Me.restart_btn.Size = New System.Drawing.Size(280, 50)
        Me.restart_btn.TabIndex = 3
        Me.restart_btn.Text = "RESTART"
        Me.restart_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 35)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "YOUR SCORE:"
        '
        'score_over_lbl
        '
        Me.score_over_lbl.AutoSize = True
        Me.score_over_lbl.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_over_lbl.ForeColor = System.Drawing.Color.White
        Me.score_over_lbl.Location = New System.Drawing.Point(311, 191)
        Me.score_over_lbl.Name = "score_over_lbl"
        Me.score_over_lbl.Size = New System.Drawing.Size(35, 35)
        Me.score_over_lbl.TabIndex = 78
        Me.score_over_lbl.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(89, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 35)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "LEVEL REACHED:"
        '
        'level_over_lbl
        '
        Me.level_over_lbl.AutoSize = True
        Me.level_over_lbl.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level_over_lbl.ForeColor = System.Drawing.Color.White
        Me.level_over_lbl.Location = New System.Drawing.Point(373, 238)
        Me.level_over_lbl.Name = "level_over_lbl"
        Me.level_over_lbl.Size = New System.Drawing.Size(35, 35)
        Me.level_over_lbl.TabIndex = 80
        Me.level_over_lbl.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(89, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 35)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "SHOTS FIRED:"
        '
        'shots_fired_go_lbl
        '
        Me.shots_fired_go_lbl.AutoSize = True
        Me.shots_fired_go_lbl.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shots_fired_go_lbl.ForeColor = System.Drawing.Color.White
        Me.shots_fired_go_lbl.Location = New System.Drawing.Point(332, 284)
        Me.shots_fired_go_lbl.Name = "shots_fired_go_lbl"
        Me.shots_fired_go_lbl.Size = New System.Drawing.Size(35, 35)
        Me.shots_fired_go_lbl.TabIndex = 82
        Me.shots_fired_go_lbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(710, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 35)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "HIGH SCORES:"
        '
        'hi_scr_name_1
        '
        Me.hi_scr_name_1.AutoSize = True
        Me.hi_scr_name_1.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_name_1.ForeColor = System.Drawing.Color.White
        Me.hi_scr_name_1.Location = New System.Drawing.Point(667, 238)
        Me.hi_scr_name_1.Name = "hi_scr_name_1"
        Me.hi_scr_name_1.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_name_1.TabIndex = 99
        Me.hi_scr_name_1.Text = "EMPTY"
        '
        'hi_scr_name_4
        '
        Me.hi_scr_name_4.AutoSize = True
        Me.hi_scr_name_4.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_name_4.ForeColor = System.Drawing.Color.White
        Me.hi_scr_name_4.Location = New System.Drawing.Point(667, 343)
        Me.hi_scr_name_4.Name = "hi_scr_name_4"
        Me.hi_scr_name_4.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_name_4.TabIndex = 100
        Me.hi_scr_name_4.Text = "EMPTY"
        '
        'hi_scr_name_3
        '
        Me.hi_scr_name_3.AutoSize = True
        Me.hi_scr_name_3.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_name_3.ForeColor = System.Drawing.Color.White
        Me.hi_scr_name_3.Location = New System.Drawing.Point(667, 308)
        Me.hi_scr_name_3.Name = "hi_scr_name_3"
        Me.hi_scr_name_3.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_name_3.TabIndex = 101
        Me.hi_scr_name_3.Text = "EMPTY"
        '
        'hi_scr_name_2
        '
        Me.hi_scr_name_2.AutoSize = True
        Me.hi_scr_name_2.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_name_2.ForeColor = System.Drawing.Color.White
        Me.hi_scr_name_2.Location = New System.Drawing.Point(667, 273)
        Me.hi_scr_name_2.Name = "hi_scr_name_2"
        Me.hi_scr_name_2.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_name_2.TabIndex = 102
        Me.hi_scr_name_2.Text = "EMPTY"
        '
        'hi_scr_name_5
        '
        Me.hi_scr_name_5.AutoSize = True
        Me.hi_scr_name_5.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_name_5.ForeColor = System.Drawing.Color.White
        Me.hi_scr_name_5.Location = New System.Drawing.Point(667, 378)
        Me.hi_scr_name_5.Name = "hi_scr_name_5"
        Me.hi_scr_name_5.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_name_5.TabIndex = 103
        Me.hi_scr_name_5.Text = "EMPTY"
        '
        'hi_scr_name_6
        '
        Me.hi_scr_name_6.AutoSize = True
        Me.hi_scr_name_6.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_name_6.ForeColor = System.Drawing.Color.White
        Me.hi_scr_name_6.Location = New System.Drawing.Point(667, 413)
        Me.hi_scr_name_6.Name = "hi_scr_name_6"
        Me.hi_scr_name_6.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_name_6.TabIndex = 104
        Me.hi_scr_name_6.Text = "EMPTY"
        '
        'hi_scr_4
        '
        Me.hi_scr_4.AutoSize = True
        Me.hi_scr_4.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_4.ForeColor = System.Drawing.Color.White
        Me.hi_scr_4.Location = New System.Drawing.Point(878, 343)
        Me.hi_scr_4.Name = "hi_scr_4"
        Me.hi_scr_4.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_4.TabIndex = 105
        Me.hi_scr_4.Text = "EMPTY"
        '
        'hi_scr_3
        '
        Me.hi_scr_3.AutoSize = True
        Me.hi_scr_3.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_3.ForeColor = System.Drawing.Color.White
        Me.hi_scr_3.Location = New System.Drawing.Point(878, 308)
        Me.hi_scr_3.Name = "hi_scr_3"
        Me.hi_scr_3.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_3.TabIndex = 106
        Me.hi_scr_3.Text = "EMPTY"
        '
        'hi_scr_2
        '
        Me.hi_scr_2.AutoSize = True
        Me.hi_scr_2.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_2.ForeColor = System.Drawing.Color.White
        Me.hi_scr_2.Location = New System.Drawing.Point(878, 273)
        Me.hi_scr_2.Name = "hi_scr_2"
        Me.hi_scr_2.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_2.TabIndex = 107
        Me.hi_scr_2.Text = "EMPTY"
        '
        'hi_scr_1
        '
        Me.hi_scr_1.AutoSize = True
        Me.hi_scr_1.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_1.ForeColor = System.Drawing.Color.White
        Me.hi_scr_1.Location = New System.Drawing.Point(878, 238)
        Me.hi_scr_1.Name = "hi_scr_1"
        Me.hi_scr_1.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_1.TabIndex = 108
        Me.hi_scr_1.Text = "EMPTY"
        '
        'hi_scr_7
        '
        Me.hi_scr_7.AutoSize = True
        Me.hi_scr_7.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_7.ForeColor = System.Drawing.Color.White
        Me.hi_scr_7.Location = New System.Drawing.Point(878, 413)
        Me.hi_scr_7.Name = "hi_scr_7"
        Me.hi_scr_7.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_7.TabIndex = 109
        Me.hi_scr_7.Text = "EMPTY"
        '
        'hi_scr_6
        '
        Me.hi_scr_6.AutoSize = True
        Me.hi_scr_6.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hi_scr_6.ForeColor = System.Drawing.Color.White
        Me.hi_scr_6.Location = New System.Drawing.Point(878, 378)
        Me.hi_scr_6.Name = "hi_scr_6"
        Me.hi_scr_6.Size = New System.Drawing.Size(115, 35)
        Me.hi_scr_6.TabIndex = 110
        Me.hi_scr_6.Text = "EMPTY"
        '
        'game_over_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.hi_scr_6)
        Me.Controls.Add(Me.hi_scr_7)
        Me.Controls.Add(Me.hi_scr_1)
        Me.Controls.Add(Me.hi_scr_2)
        Me.Controls.Add(Me.hi_scr_3)
        Me.Controls.Add(Me.hi_scr_4)
        Me.Controls.Add(Me.hi_scr_name_6)
        Me.Controls.Add(Me.hi_scr_name_5)
        Me.Controls.Add(Me.hi_scr_name_2)
        Me.Controls.Add(Me.hi_scr_name_3)
        Me.Controls.Add(Me.hi_scr_name_4)
        Me.Controls.Add(Me.hi_scr_name_1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.shots_fired_go_lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.level_over_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.score_over_lbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.restart_btn)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "game_over_frm"
        Me.Text = "SPACE INVADERS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents restart_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents score_over_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents level_over_lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents shots_fired_go_lbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_name_1 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_name_4 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_name_3 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_name_2 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_name_5 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_name_6 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_4 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_3 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_2 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_1 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_7 As System.Windows.Forms.Label
    Friend WithEvents hi_scr_6 As System.Windows.Forms.Label
End Class
