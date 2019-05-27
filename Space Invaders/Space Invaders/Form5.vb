Public Class complete_frm

#Region "Variable"

    Public Shared level As Integer = 1
    Dim score As Integer
    Dim lives As Integer

#End Region

#Region "Buttons"

    Private Sub next_stage_btn_Click(sender As System.Object, e As System.EventArgs) Handles next_stage_btn.Click
        Me.Hide()
        level = level + 1
        score = stage_1_frm.score_count_lbl.Text
        lives = stage_1_frm.lives_count_lbl.Text
        stage_1_frm.Dispose()
        stage_1_frm.Show()
        stage_1_frm.level_count_lbl.Text = level
        stage_1_frm.score_count_lbl.Text = score
        stage_1_frm.lives_count_lbl.Text = lives
    End Sub 'A button that disposes of the old form, and starts a new one inserting the previous values into it.


    Private Sub exit_btn_Click(sender As System.Object, e As System.EventArgs) Handles exit_btn.Click
        Me.Close()
        menu_frm.Close()
        stage_1_frm.Close()
        instructions_frm.Close()
        game_over_frm.Close()
    End Sub 'A button that closes the from including all the other forms to completely close the program.

#End Region

#Region "Subs"
    Private Sub complete_frm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub space_block(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.Space And exit_btn.Focused
                e.Handled = True
            Case Keys.Space And next_stage_btn.Focused
                e.Handled = True
        End Select
    End Sub
#End Region

End Class
