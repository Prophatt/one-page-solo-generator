Public Class enemy_tactics

    Private Sub enemy_tactic_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy_tactic_close.Click
        the_enemy_will_txtbx.Text = ""
        Me.Hide()
    End Sub

    Private Sub enemy_tactic_journal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy_tactic_journal_btn.Click
        If journal.Visible = False Then
            journal.Visible = True
        End If
        journal.journal_txtbx.AppendText("The Enemy Tactic is--  " + the_enemy_will_txtbx.Text + vbCrLf)
    End Sub

    Private Sub get_enemy_tactic_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_enemy_tactic_btn.Click
        'generate what the enemy is going to do based off of random number
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1 To 4
                If the_enemy_will_txtbx.Text = "" Then
                    die_roll = vbNull
                    die_roll = GetRandom(1, 7)
                    Select Case die_roll
                        Case 1
                            the_enemy_will_txtbx.Text = "Attack recklessly for max damage"
                        Case 2
                            the_enemy_will_txtbx.Text = "Aid an ally or heal"
                        Case 3
                            the_enemy_will_txtbx.Text = "Act according to this unit’s role"
                        Case 4
                            the_enemy_will_txtbx.Text = "Take a defensive posture"
                        Case 5
                            the_enemy_will_txtbx.Text = "Seek an advantage"
                        Case 6 To 7
                            the_enemy_will_txtbx.Text = "Focus on a weak target"
                    End Select
                Else
                    enemy_same_tactic_lbl.Visible = True
                End If
            Case 5 To 7
                enemy_same_tactic_lbl.Visible = False
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 1
                        the_enemy_will_txtbx.Text = "Attack recklessly for max damage"
                    Case 2
                        the_enemy_will_txtbx.Text = "Aid an ally or heal"
                    Case 3
                        the_enemy_will_txtbx.Text = "Act according to this unit’s role"
                    Case 4
                        the_enemy_will_txtbx.Text = "Take a defensive posture"
                    Case 5
                        the_enemy_will_txtbx.Text = "Seek an advantage"
                    Case 6 To 7
                        the_enemy_will_txtbx.Text = "Focus on a weak target"
                End Select
        End Select

    End Sub

    Private Sub enemy_tactic_force_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy_tactic_force_btn.Click
        ' force a new enemy tactic
        enemy_same_tactic_lbl.Visible = False
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1
                the_enemy_will_txtbx.Text = "Attack recklessly for max damage"
            Case 2
                the_enemy_will_txtbx.Text = "Aid an ally or heal"
            Case 3
                the_enemy_will_txtbx.Text = "Act according to this unit’s role"
            Case 4
                the_enemy_will_txtbx.Text = "Take a defensive posture"
            Case 5
                the_enemy_will_txtbx.Text = "Seek an advantage"
            Case 6 To 7
                the_enemy_will_txtbx.Text = "Focus on a weak target"
        End Select
    End Sub
End Class