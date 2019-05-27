Public Class game_over_frm

#Region "Buttons"

    Private Sub restart_btn_Click(sender As System.Object, e As System.EventArgs) Handles restart_btn.Click
        complete_frm.lives_complete_lbl.Text = 3
        stage_1_frm.Dispose()
        Me.Hide()
        stage_1_frm.shots_fired = 0
        stage_1_frm.Show()
    End Sub 'This button, disposes of the old game form and shows a fresh one, restarting the game.

    Private Sub exit_btn_Click(sender As System.Object, e As System.EventArgs) Handles exit_btn.Click
        Me.Close()
        menu_frm.Close()
        instructions_frm.Close()
        stage_1_frm.Close()
    End Sub 'This button closes the program.

#End Region

#Region "Subs"

    Private Sub game_over_frm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub space_block(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.Space And exit_btn.Focused
                e.Handled = True
            Case Keys.Space And restart_btn.Focused
                e.Handled = True
        End Select
    End Sub

#End Region

End Class
