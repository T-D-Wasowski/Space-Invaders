Public Class menu_frm

#Region "Buttons"

    Private Sub start_btn_Click(sender As System.Object, e As System.EventArgs) Handles start_btn.Click
        start_btn.Hide()
        options_btn.Hide()
        exit_btn.Hide()
        hard_mode_btn.Show()
        norm_mode_btn.Show()
        easy_mode_btn.Show()
        back_btn.Show()
        choose_diff_lbl.Show()
    End Sub 'Start button, starts the game.

    Private Sub options_btn_Click(sender As System.Object, e As System.EventArgs) Handles options_btn.Click
        Me.Hide()
        instructions_frm.Show()
    End Sub 'Instructions button, opens instructions page.

    Private Sub exit_btn_Click(sender As System.Object, e As System.EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub 'Exit button, closes the program.

    Private Sub hard_mode_btn_Click(sender As System.Object, e As System.EventArgs) Handles hard_mode_btn.Click
        Me.Hide()
        stage_1_frm.Show()
        stage_1_frm.dif_al_las = 1000
        stage_1_frm.dif_al_speed = 0.2
    End Sub

    Private Sub norm_mode_btn_Click(sender As System.Object, e As System.EventArgs) Handles norm_mode_btn.Click
        Me.Hide()
        stage_1_frm.Show()
        stage_1_frm.dif_al_las = 3000
        stage_1_frm.dif_al_speed = 0.1
    End Sub

    Private Sub easy_mode_btn_Click(sender As System.Object, e As System.EventArgs) Handles easy_mode_btn.Click
        Me.Hide()
        stage_1_frm.Show()
        stage_1_frm.dif_al_las = 5000
        stage_1_frm.dif_al_speed = 0.05
    End Sub

    Private Sub back_btn_Click(sender As System.Object, e As System.EventArgs) Handles back_btn.Click
        start_btn.Show()
        options_btn.Show()
        exit_btn.Show()
        hard_mode_btn.Hide()
        norm_mode_btn.Hide()
        easy_mode_btn.Hide()
        back_btn.Hide()
        choose_diff_lbl.Hide()
    End Sub



#End Region


End Class
