Public Class stage_1_frm

#Region "Variables"

    Dim move_left As Boolean
    Dim move_right As Boolean

    Dim shoot As Boolean
    Dim fire_1 As Boolean
    Dim fire_2 As Boolean
    Dim fire_3 As Boolean
    Dim fire_4 As Boolean
    Dim fire_5 As Boolean

    Dim aliens_ary(64) As PictureBox
    Dim alien_lasers_ary(64) As Boolean
    Dim alien_lasers_lbl_ary(64) As Label

    Dim move_aliens_const As Decimal = 1.5
    Dim move_aliens_const_right As Decimal = 1.5
    Dim move_aliens_const_left As Decimal = -1.5
    Dim move_boss_constant As Integer = 3
    Dim move_boss_vertical_constant As Decimal = 1

    Dim which_alien As Integer
    Dim alien_type As Integer
    Dim rand_numb As Integer
    Dim rand_numb_2 As Integer
    Dim rand_alien As Boolean
    Dim boss_initiate As Boolean
    Dim boss_life As Integer = 0

    Dim stage_complete_count As Decimal
    Dim pause As Boolean = True
    Dim score As Integer = complete_frm.score_complete_lbl.Text
    Dim lives As Integer = complete_frm.lives_complete_lbl.Text

    Dim base_laser_sound As New Media.SoundPlayer
    Dim alien_laser_sound As New Media.SoundPlayer
    Dim ost As New Media.SoundPlayer
    Dim mute As Boolean

    Public Shared dif_al_las As Integer
    Public Shared dif_al_speed As Decimal
    Public Shared shots_fired As Integer

#End Region

#Region "Timers"

    Private Sub move_comp_tmr_Tick(sender As System.Object, e As System.EventArgs) Handles move_component.Tick
        If move_right = True Then
            player_base.Left = player_base.Left + 5
            restart_laser.Left = restart_laser.Left + 5
            If fire_1 = False Then
                laser_1.Left = laser_1.Left + 5 'If not fired, lasers follow the ship right.
            End If
            If fire_2 = False Then
                laser_2.Left = laser_2.Left + 5
            End If
            If fire_3 = False Then
                laser_3.Left = laser_3.Left + 5
            End If
            If fire_4 = False Then
                laser_4.Left = laser_4.Left + 5
            End If
            If fire_5 = False Then
                laser_5.Left = laser_5.Left + 5
            End If
            If player_base.Left > 954 Then 'If the player tries to leave the form to the right he will be pushed left 5 pixels.
                player_base.Left = player_base.Left - 5
                restart_laser.Left = restart_laser.Left - 5
                If fire_1 = False Then
                    laser_1.Left = laser_1.Left - 5
                End If
                If fire_2 = False Then
                    laser_2.Left = laser_2.Left - 5
                End If
                If fire_3 = False Then
                    laser_3.Left = laser_3.Left - 5
                End If
                If fire_4 = False Then
                    laser_4.Left = laser_4.Left - 5
                End If
                If fire_5 = False Then
                    laser_5.Left = laser_5.Left - 5
                End If
            End If
        End If
        If move_left = True Then
            player_base.Left = player_base.Left - 5
            restart_laser.Left = restart_laser.Left - 5
            If fire_1 = False Then
                laser_1.Left = laser_1.Left - 5 'If not fired, lasers follow the ship left.
            End If
            If fire_2 = False Then
                laser_2.Left = laser_2.Left - 5
            End If
            If fire_3 = False Then
                laser_3.Left = laser_3.Left - 5
            End If
            If fire_4 = False Then
                laser_4.Left = laser_4.Left - 5
            End If
            If fire_5 = False Then
                laser_5.Left = laser_5.Left - 5
            End If
            If player_base.Left < -7 Then 'If the ship tries to leave form to the left it will be pushed right five pixels.
                player_base.Left = player_base.Left + 5
                restart_laser.Left = restart_laser.Left + 5
                If fire_1 = False Then
                    laser_1.Left = laser_1.Left + 5
                End If
                If fire_2 = False Then
                    laser_2.Left = laser_2.Left + 5
                End If
                If fire_3 = False Then
                    laser_3.Left = laser_3.Left + 5
                End If
                If fire_4 = False Then
                    laser_4.Left = laser_4.Left + 5
                End If
                If fire_5 = False Then
                    laser_5.Left = laser_5.Left + 5
                End If
            End If
        End If
        move_aliens() 'Subs to initiate as the timer is running.
        If shoot = True Then
            check_shot()
        End If
        move_laser()
        move_alien_lasers()
        special_alien()
        If boss_initiate = True Then
            boss_move()
        End If
    End Sub 'Timer respinsible for movement.

#End Region

#Region "Key Press"

    Private Sub move_comp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then 'The controls of the ship.
            move_right = True
        End If
        If e.KeyValue = Keys.Left Then
            move_left = True
        End If
        If e.KeyValue = Keys.Space Then
            shoot = True
            If mute = False Then
                My.Computer.Audio.Play(My.Resources.base_laser, AudioPlayMode.Background)
            End If
        End If

        If e.KeyValue = Keys.P Then 'Pauses the game upon key press.
            If pause = True Then
                move_component.Stop()
                pause_lbl.Text = "RESUME"
                pause = False
            ElseIf pause = False Then
                move_component.Start()
                pause_lbl.Text = "PAUSE"
                pause = True
            End If
        End If

        If e.KeyValue = Keys.M Then
            If mute = False Then
                mute = True
                mute_lbl.Text = "UNMUTE SOUND"
            ElseIf mute = True Then
                mute = False
                mute_lbl.Text = "MUTE SOUND"
            End If
        End If

        Select Case e.KeyValue 'Special hotkeys to help with testing
            Case Keys.T
                player_death()
            Case Keys.Y
                stage_complete()
            Case Keys.R
                boss_initiate = True
                boss_fight()
        End Select

    End Sub 'When a key is pressed.

    Private Sub move_comp_stop(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then 'The ship does 
            move_right = False
        End If
        If e.KeyValue = Keys.Left Then
            move_left = False
        End If
        If e.KeyValue = Keys.Space Then
            shoot = False
        End If
    End Sub 'When a key is released.

#End Region

#Region "Subs"

    Public Sub New()
        InitializeComponent()
        create_alien_array()
        create_alien_laser_lbl_array()
        boss_fight()
    End Sub 'Initiates the following subs as the form is loaded.

    Private Sub create_alien_array()
        aliens_ary(0) = alien_1_1
        aliens_ary(1) = alien_1_2
        aliens_ary(2) = alien_1_3
        aliens_ary(3) = alien_1_4
        aliens_ary(4) = alien_1_5
        aliens_ary(5) = alien_1_6
        aliens_ary(6) = alien_1_7
        aliens_ary(7) = alien_1_8
        aliens_ary(8) = alien_1_9
        aliens_ary(9) = alien_1_10
        aliens_ary(10) = alien_1_11
        aliens_ary(11) = alien_1_12
        aliens_ary(12) = alien_1_13
        aliens_ary(13) = alien_1_14
        aliens_ary(14) = alien_1_15
        aliens_ary(15) = alien_1_16
        aliens_ary(16) = alien_1_17
        aliens_ary(17) = alien_1_18
        aliens_ary(18) = alien_1_19
        aliens_ary(19) = alien_1_20
        aliens_ary(20) = alien_1_21
        aliens_ary(21) = alien_1_22
        aliens_ary(22) = alien_1_23
        aliens_ary(23) = alien_1_24
        aliens_ary(24) = alien_1_25
        aliens_ary(25) = alien_1_26
        aliens_ary(26) = alien_2_1
        aliens_ary(27) = alien_2_2
        aliens_ary(28) = alien_2_3
        aliens_ary(29) = alien_2_4
        aliens_ary(30) = alien_2_5
        aliens_ary(31) = alien_2_6
        aliens_ary(32) = alien_2_7
        aliens_ary(33) = alien_2_8
        aliens_ary(34) = alien_2_9
        aliens_ary(35) = alien_2_10
        aliens_ary(36) = alien_2_11
        aliens_ary(37) = alien_2_12
        aliens_ary(38) = alien_2_13
        aliens_ary(39) = alien_2_14
        aliens_ary(40) = alien_2_15
        aliens_ary(41) = alien_2_16
        aliens_ary(42) = alien_2_17
        aliens_ary(43) = alien_2_18
        aliens_ary(44) = alien_2_19
        aliens_ary(45) = alien_2_20
        aliens_ary(46) = alien_2_21
        aliens_ary(47) = alien_2_22
        aliens_ary(48) = alien_2_23
        aliens_ary(49) = alien_2_24
        aliens_ary(50) = alien_2_25
        aliens_ary(51) = alien_2_26
        aliens_ary(52) = alien_3_1
        aliens_ary(53) = alien_3_2
        aliens_ary(54) = alien_3_3
        aliens_ary(55) = alien_3_4
        aliens_ary(56) = alien_3_5
        aliens_ary(57) = alien_3_6
        aliens_ary(58) = alien_3_7
        aliens_ary(59) = alien_3_8
        aliens_ary(60) = alien_3_9
        aliens_ary(61) = alien_3_10
        aliens_ary(62) = alien_3_11
        aliens_ary(63) = alien_3_12
        aliens_ary(64) = alien_3_13
    End Sub 'Inserting aliens into array.

    Private Sub create_alien_laser_lbl_array()
        alien_lasers_lbl_ary(0) = a_las_1
        alien_lasers_lbl_ary(1) = a_las_2
        alien_lasers_lbl_ary(2) = a_las_3
        alien_lasers_lbl_ary(3) = a_las_4
        alien_lasers_lbl_ary(4) = a_las_5
        alien_lasers_lbl_ary(5) = a_las_6
        alien_lasers_lbl_ary(6) = a_las_7
        alien_lasers_lbl_ary(7) = a_las_8
        alien_lasers_lbl_ary(8) = a_las_9
        alien_lasers_lbl_ary(9) = a_las_10
        alien_lasers_lbl_ary(10) = a_las_11
        alien_lasers_lbl_ary(11) = a_las_12
        alien_lasers_lbl_ary(12) = a_las_13
        alien_lasers_lbl_ary(13) = a_las_14
        alien_lasers_lbl_ary(14) = a_las_15
        alien_lasers_lbl_ary(15) = a_las_16
        alien_lasers_lbl_ary(16) = a_las_17
        alien_lasers_lbl_ary(17) = a_las_18
        alien_lasers_lbl_ary(18) = a_las_19
        alien_lasers_lbl_ary(19) = a_las_20
        alien_lasers_lbl_ary(20) = a_las_21
        alien_lasers_lbl_ary(21) = a_las_22
        alien_lasers_lbl_ary(22) = a_las_23
        alien_lasers_lbl_ary(23) = a_las_24
        alien_lasers_lbl_ary(24) = a_las_25
        alien_lasers_lbl_ary(25) = a_las_26
        alien_lasers_lbl_ary(26) = a_las_27
        alien_lasers_lbl_ary(27) = a_las_28
        alien_lasers_lbl_ary(28) = a_las_29
        alien_lasers_lbl_ary(29) = a_las_30
        alien_lasers_lbl_ary(30) = a_las_31
        alien_lasers_lbl_ary(31) = a_las_32
        alien_lasers_lbl_ary(32) = a_las_33
        alien_lasers_lbl_ary(33) = a_las_34
        alien_lasers_lbl_ary(34) = a_las_35
        alien_lasers_lbl_ary(35) = a_las_36
        alien_lasers_lbl_ary(36) = a_las_37
        alien_lasers_lbl_ary(37) = a_las_38
        alien_lasers_lbl_ary(38) = a_las_39
        alien_lasers_lbl_ary(39) = a_las_40
        alien_lasers_lbl_ary(40) = a_las_41
        alien_lasers_lbl_ary(41) = a_las_42
        alien_lasers_lbl_ary(42) = a_las_43
        alien_lasers_lbl_ary(43) = a_las_44
        alien_lasers_lbl_ary(44) = a_las_45
        alien_lasers_lbl_ary(45) = a_las_46
        alien_lasers_lbl_ary(46) = a_las_47
        alien_lasers_lbl_ary(47) = a_las_48
        alien_lasers_lbl_ary(48) = a_las_49
        alien_lasers_lbl_ary(49) = a_las_50
        alien_lasers_lbl_ary(50) = a_las_51
        alien_lasers_lbl_ary(51) = a_las_52
        alien_lasers_lbl_ary(52) = a_las_53
        alien_lasers_lbl_ary(53) = a_las_54
        alien_lasers_lbl_ary(54) = a_las_55
        alien_lasers_lbl_ary(55) = a_las_56
        alien_lasers_lbl_ary(56) = a_las_57
        alien_lasers_lbl_ary(57) = a_las_58
        alien_lasers_lbl_ary(58) = a_las_59
        alien_lasers_lbl_ary(59) = a_las_60
        alien_lasers_lbl_ary(60) = a_las_61
        alien_lasers_lbl_ary(61) = a_las_62
        alien_lasers_lbl_ary(62) = a_las_63
        alien_lasers_lbl_ary(63) = a_las_64
        alien_lasers_lbl_ary(64) = a_las_65
    End Sub 'Inserting the lasers fired by the aliens into array.

    Private Sub move_aliens()
        For i = 0 To 64
            aliens_ary(i).Left = aliens_ary(i).Left + move_aliens_const
            If alien_lasers_ary(i) = False Then
                alien_lasers_lbl_ary(i).Left = alien_lasers_lbl_ary(i).Left + move_aliens_const
            End If
        Next
        If alien_1_26.Left > Me.Width - alien_1_26.Width - 14 Then
            move_aliens_const = move_aliens_const_left
            For i = 0 To 64
                aliens_ary(i).Top = aliens_ary(i).Top + 20
                If alien_lasers_ary(i) = False Then
                    alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 20
                End If
            Next
        End If
        If alien_1_1.Left < 0 Then
            move_aliens_const = move_aliens_const_right
            For i = 0 To 64
                aliens_ary(i).Top = aliens_ary(i).Top + 20
                If alien_lasers_ary(i) = False Then
                    alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 20
                End If
            Next
        End If
        For p = 0 To 64
            If aliens_ary(p).Bounds.IntersectsWith(player_base.Bounds) Or aliens_ary(p).Bounds.IntersectsWith(death_stick.Bounds) Then
                player_death()
            End If
        Next
    End Sub 'Causing aliens to move sideways and down with each cycle.

    Private Sub special_alien()

        If rand_alien = False Then
            rand_numb_2 = CInt(Int((4000 * Rnd()) + 1))
            If rand_numb_2 = 4000 Then
                rand_alien = True
            End If
        End If
        If rand_alien = True Then
            special_alien_pb.Show()
            special_alien_pb.Left = special_alien_pb.Left + 6
            If special_alien_pb.Left = 1024 Then
                special_alien_pb.Hide()
                rand_alien = False
                special_alien_pb.Location = special_alien_reset.Location
            End If
            If special_alien_pb.Bounds.IntersectsWith(laser_1.Bounds) Then
                special_alien_pb.Hide()
                rand_alien = False
                special_alien_pb.Location = special_alien_reset.Location
                score = score + 100
                score_count_lbl.Text = score
            End If
            If special_alien_pb.Bounds.IntersectsWith(laser_2.Bounds) Then
                special_alien_pb.Hide()
                rand_alien = False
                special_alien_pb.Location = special_alien_reset.Location
                score = score + 100
                score_count_lbl.Text = score
            End If
            If special_alien_pb.Bounds.IntersectsWith(laser_3.Bounds) Then
                special_alien_pb.Hide()
                rand_alien = False
                special_alien_pb.Location = special_alien_reset.Location
                score = score + 100
                score_count_lbl.Text = score
            End If
            If special_alien_pb.Bounds.IntersectsWith(laser_4.Bounds) Then
                special_alien_pb.Hide()
                rand_alien = False
                special_alien_pb.Location = special_alien_reset.Location
                score = score + 100
                score_count_lbl.Text = score
            End If
            If special_alien_pb.Bounds.IntersectsWith(laser_5.Bounds) Then
                special_alien_pb.Hide()
                rand_alien = False
                special_alien_pb.Location = special_alien_reset.Location
                score = score + 100
                score_count_lbl.Text = score
            End If
        End If

    End Sub 'Code responsible for interactions and behaviour of the special 'Red' alien.

    Private Sub check_shot()
        shoot = False
        If fire_1 = False Then
            fire_1 = True
            laser_1.Show()
            Exit Sub
        End If
        If fire_2 = False Then
            fire_2 = True
            laser_2.Show()
            Exit Sub
        End If
        If fire_3 = False Then
            fire_3 = True
            laser_3.Show()
            Exit Sub
        End If
        If fire_4 = False Then
            fire_4 = True
            laser_4.Show()
            Exit Sub
        End If
        If fire_5 = False Then
            fire_5 = True
            laser_5.Show()
            Exit Sub
        End If
    End Sub 'Checks if the lasers are still present.

    Private Sub move_laser()
        If fire_1 = True Then
            laser_1.Top = laser_1.Top - 7
            For i = 0 To 64
                If laser_1.Bounds.IntersectsWith(aliens_ary(i).Bounds) Then
                    which_alien = i 'Identifies which alien in the array has been hit.
                    laser_1_hit()
                    shots_fired = shots_fired + 1
                End If
            Next
            If laser_1.Bounds.IntersectsWith(boss_alien.Bounds) Then
                boss_life = boss_life + 1
                shots_fired = shots_fired + 1
                laser_1_hit()
            End If
            If laser_1.Top < 0 Then
                laser_1.Hide()
                fire_1 = False
                laser_1.Location = restart_laser.Location
                shots_fired = shots_fired + 1
            End If
        End If
        If fire_2 = True Then
            laser_2.Top = laser_2.Top - 7
            For i = 0 To 64
                If laser_2.Bounds.IntersectsWith(aliens_ary(i).Bounds) Then
                    which_alien = i
                    laser_2_hit()
                    shots_fired = shots_fired + 1
                End If
            Next
            If laser_2.Bounds.IntersectsWith(boss_alien.Bounds) Then
                boss_life = boss_life + 1
                shots_fired = shots_fired + 1
                laser_2_hit()
            End If
            If laser_2.Top < 0 Then
                laser_2.Hide()
                fire_2 = False
                laser_2.Location = restart_laser.Location
                shots_fired = shots_fired + 1
            End If
        End If
        If fire_3 = True Then
            laser_3.Top = laser_3.Top - 7
            For i = 0 To 64
                If laser_3.Bounds.IntersectsWith(aliens_ary(i).Bounds) Then
                    which_alien = i
                    laser_3_hit()
                    shots_fired = shots_fired + 1
                End If
            Next
            If laser_3.Bounds.IntersectsWith(boss_alien.Bounds) Then
                boss_life = boss_life + 1
                shots_fired = shots_fired + 1
                laser_3_hit()
            End If
            If laser_3.Top < 0 Then
                laser_3.Hide()
                fire_3 = False
                laser_3.Location = restart_laser.Location
                shots_fired = shots_fired + 1
            End If
        End If
        If fire_4 = True Then
            laser_4.Top = laser_4.Top - 7
            For i = 0 To 64
                If laser_4.Bounds.IntersectsWith(aliens_ary(i).Bounds) Then
                    which_alien = i
                    laser_4_hit()
                    shots_fired = shots_fired + 1
                End If
            Next
            If laser_4.Bounds.IntersectsWith(boss_alien.Bounds) Then
                boss_life = boss_life + 1
                shots_fired = shots_fired + 1
                laser_4_hit()
            End If
            If laser_4.Top < 0 Then
                laser_4.Hide()
                fire_4 = False
                laser_4.Location = restart_laser.Location
                shots_fired = shots_fired + 1
            End If
        End If
        If fire_5 = True Then
            laser_5.Top = laser_5.Top - 7
            For i = 0 To 64
                If laser_5.Bounds.IntersectsWith(aliens_ary(i).Bounds) Then
                    which_alien = i
                    laser_5_hit()
                    shots_fired = shots_fired + 1
                End If
            Next
            If laser_5.Bounds.IntersectsWith(boss_alien.Bounds) Then
                boss_life = boss_life + 1
                shots_fired = shots_fired + 1
                laser_5_hit()
            End If
            If laser_5.Top < 0 Then
                laser_5.Hide()
                fire_5 = False
                laser_5.Location = restart_laser.Location
                shots_fired = shots_fired + 1
            End If
        End If
    End Sub 'Makes the laser move upon firing.

    Private Sub laser_1_hit()
        fire_1 = False
        laser_1.Hide()
        laser_1.Location = restart_laser.Location
        aliens_ary(which_alien).Top = aliens_ary(which_alien).Top + 10000
        stage_complete_count = stage_complete_count + 1
        move_aliens_const_left = move_aliens_const_left - dif_al_speed
        move_aliens_const_right = move_aliens_const_right + dif_al_speed
        If stage_complete_count = 65 Then
            stage_complete()
        End If
        If which_alien >= 0 And which_alien <= 25 Then
            score = score + 10
        ElseIf which_alien >= 26 And which_alien <= 51 Then
            score = score + 20
        ElseIf which_alien >= 52 And which_alien <= 64 Then
            score = score + 50
        End If
        score_count_lbl.Text = score

    End Sub 'Each of the lasers have their own sub to control their behavior.

    Private Sub laser_2_hit()
        fire_2 = False
        laser_2.Hide()
        laser_2.Location = restart_laser.Location
        aliens_ary(which_alien).Top = aliens_ary(which_alien).Top + 10000
        stage_complete_count = stage_complete_count + 1
        move_aliens_const_left = move_aliens_const_left - dif_al_speed
        move_aliens_const_right = move_aliens_const_right + dif_al_speed
        If stage_complete_count = 65 Then
            stage_complete()
        End If
        If which_alien >= 0 And which_alien <= 25 Then
            score = score + 10
        ElseIf which_alien >= 26 And which_alien <= 51 Then
            score = score + 20
        ElseIf which_alien >= 52 And which_alien <= 64 Then
            score = score + 50
        End If
        score_count_lbl.Text = score
    End Sub 'There are five of these because there can only be 5 bullets on the screen at one time.

    Private Sub laser_3_hit()
        fire_3 = False
        laser_3.Hide()
        laser_3.Location = restart_laser.Location
        aliens_ary(which_alien).Top = aliens_ary(which_alien).Top + 10000
        stage_complete_count = stage_complete_count + 1
        move_aliens_const_left = move_aliens_const_left - dif_al_speed
        move_aliens_const_right = move_aliens_const_right + dif_al_speed
        If stage_complete_count = 65 Then
            stage_complete()
        End If
        If which_alien >= 0 And which_alien <= 25 Then
            score = score + 10
        ElseIf which_alien >= 26 And which_alien <= 51 Then
            score = score + 20
        ElseIf which_alien >= 52 And which_alien <= 64 Then
            score = score + 50
        End If
        score_count_lbl.Text = score
    End Sub

    Private Sub laser_4_hit()
        fire_4 = False
        laser_4.Hide()
        laser_4.Location = restart_laser.Location
        aliens_ary(which_alien).Top = aliens_ary(which_alien).Top + 10000
        stage_complete_count = stage_complete_count + 1
        move_aliens_const_left = move_aliens_const_left - dif_al_speed
        move_aliens_const_right = move_aliens_const_right + dif_al_speed
        If stage_complete_count = 65 Then
            stage_complete()
        End If
        If which_alien >= 0 And which_alien <= 25 Then
            score = score + 10
        ElseIf which_alien >= 26 And which_alien <= 51 Then
            score = score + 20
        ElseIf which_alien >= 52 And which_alien <= 64 Then
            score = score + 50
        End If
        score_count_lbl.Text = score
    End Sub

    Private Sub laser_5_hit()
        fire_5 = False
        laser_5.Hide()
        laser_5.Location = restart_laser.Location
        aliens_ary(which_alien).Top = aliens_ary(which_alien).Top + 10000
        stage_complete_count = stage_complete_count + 1
        move_aliens_const_left = move_aliens_const_left - dif_al_speed
        move_aliens_const_right = move_aliens_const_right + dif_al_speed
        If stage_complete_count = 65 Then
            stage_complete()
        End If
        If which_alien >= 0 And which_alien <= 25 Then
            score = score + 10
        ElseIf which_alien >= 26 And which_alien <= 51 Then
            score = score + 20
        ElseIf which_alien >= 52 And which_alien <= 64 Then
            score = score + 50
        End If
        score_count_lbl.Text = score
    End Sub

    Private Sub move_alien_lasers()
        For i = 0 To 64
            If alien_lasers_ary(i) = False Then
                rand_numb = CInt(Int((dif_al_las * Rnd()) + 1))
                If rand_numb = dif_al_las Then
                    alien_lasers_ary(i) = True
                    If aliens_ary(i).Top > 2000 Then
                        alien_lasers_ary(i) = False
                        alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 10000
                    End If
                    If alien_lasers_ary(i) = True Then
                        If mute = False Then
                            My.Computer.Audio.Play(My.Resources.alien_laser, AudioPlayMode.Background) 'Sound effects for alien lasers.
                        End If
                    End If
                End If
            End If
        Next
        For i = 0 To 64
            If alien_lasers_ary(i) = True Then
                alien_lasers_lbl_ary(i).Show()
                alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 5
                If alien_lasers_lbl_ary(i).Bounds.IntersectsWith(player_base.Bounds) Then
                    If aliens_ary(i).Top > 2000 Then
                        alien_lasers_ary(i) = False
                        alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 10000
                    End If
                    alien_lasers_ary(i) = False
                    alien_lasers_lbl_ary(i).Hide()
                    alien_lasers_lbl_ary(i).Location = aliens_ary(i).Location
                    alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 21
                    alien_lasers_lbl_ary(i).Left = alien_lasers_lbl_ary(i).Left - 18
                    lives = lives - 1
                End If
                lives_count_lbl.Text = lives
                If lives = 0 Then
                    player_death()
                End If
                If alien_lasers_lbl_ary(i).Top > Me.Height Then
                    If aliens_ary(i).Top > 2000 Then
                        alien_lasers_ary(i) = False
                        alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 10000
                    End If
                    alien_lasers_ary(i) = False
                    alien_lasers_lbl_ary(i).Hide()
                    alien_lasers_lbl_ary(i).Location = aliens_ary(i).Location
                    alien_lasers_lbl_ary(i).Top = alien_lasers_lbl_ary(i).Top + 21
                    alien_lasers_lbl_ary(i).Left = alien_lasers_lbl_ary(i).Left - 18
                End If
            End If
        Next
    End Sub

    Private Sub boss_move()
        boss_alien.Left = boss_alien.Left + move_boss_constant
        boss_alien.Top = boss_alien.Top + move_boss_vertical_constant
        If boss_alien.Left > Me.Width - boss_alien.Width - 14 Then
            move_boss_constant = move_boss_constant * -1
        End If
        If boss_alien.Left < 0 Then
            move_boss_constant = move_boss_constant * -1
        End If
        If boss_life > 20 Then
            score = score + 3000
            stage_complete()
        End If
    End Sub

    Private Sub boss_fight()
        If complete_frm.level Mod 10 = 0 Then
            boss_initiate = True
        ElseIf boss_initiate = False Then
            boss_alien.Left = boss_alien.Left + 10000
        End If
        If boss_initiate = True Then
            boss_alien.Show()
            For i = 0 To 64
                aliens_ary(i).Top = aliens_ary(i).Top + 10000
            Next
        End If
    End Sub

    Private Sub player_death()

        move_component.Stop()
        Me.Hide()
        game_over_frm.Show()
        game_over_frm.score_over_lbl.Text = score
        game_over_frm.level_over_lbl.Text = level_count_lbl.Text
        game_over_frm.shots_fired_go_lbl.Text = shots_fired

    End Sub 'Process once the player dies.

    Private Sub stage_complete()
        move_component.Stop()
        Me.Hide()
        complete_frm.Show()
        complete_frm.score_complete_lbl.Text = score
        complete_frm.lives_complete_lbl.Text = lives
    End Sub 'Process once all the aliens are killed.

#End Region


End Class