Public Class set_the_scene
    'scene prompts generated randomly to start characters or for setting story elements
    Private Sub set_the_scene_1d6_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_the_scene_1d6_btn.Click
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1
                set_the_scene_outcome_txtbx.Text = "Conflict – a fight or action scene"
            Case 2
                set_the_scene_outcome_txtbx.Text = "Exploration – explore a dangerous location (DUNGEON CRAWLER)"
            Case 3
                set_the_scene_outcome_txtbx.Text = "Challenge – a test of skill or ability"
            Case 4
                set_the_scene_outcome_txtbx.Text = "Social – convince or trick an NPC"
            Case 5
                set_the_scene_outcome_txtbx.Text = "Travel – move through dangerous territory (random encounters)"
            Case 6
                set_the_scene_outcome_txtbx.Text = "Rest – recuperate and heal."
        End Select
    End Sub

    Private Sub set_the_scene_altered_roll_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_the_scene_altered_roll_btn.Click
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 6
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 1
                        altered_scene_outcome_txtbx.Text = "An unexpected event interrupts you."
                    Case 2
                        altered_scene_outcome_txtbx.Text = "The location is different or changed."
                    Case 3
                        altered_scene_outcome_txtbx.Text = "The NPCs are new or unexpected."
                    Case 4
                        altered_scene_outcome_txtbx.Text = "Roll a different SCENE OBJECTIVE."
                    Case 5
                        altered_scene_outcome_txtbx.Text = "An important event is already happening here."
                    Case 6
                        altered_scene_outcome_txtbx.Text = "The situation is easier or harder."
                End Select
            Case Else
                altered_scene_outcome_txtbx.Text = "The scene is not altered!"
        End Select
    End Sub


    Private Sub scene_obj_btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scene_obj_btn1.Click
        set_the_scene_outcome_txtbx.Text = "Conflict – a fight or action scene"
    End Sub

    Private Sub scene_obj_btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scene_obj_btn2.Click
        set_the_scene_outcome_txtbx.Text = "Exploration – explore a dangerous location (DUNGEON CRAWLER)"
    End Sub

    Private Sub scene_obj_btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scene_obj_btn3.Click
        set_the_scene_outcome_txtbx.Text = "Challenge – a test of skill or ability"
    End Sub

    Private Sub scene_obj_btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scene_obj_btn4.Click
        set_the_scene_outcome_txtbx.Text = "Social – convince or trick an NPC"
    End Sub

    Private Sub scene_obj_btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scene_obj_btn5.Click
        set_the_scene_outcome_txtbx.Text = "Travel – move through dangerous territory (random encounters)"
    End Sub

    Private Sub scene_obj_btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scene_obj_btn6.Click
        set_the_scene_outcome_txtbx.Text = "Rest – recuperate and heal."
    End Sub

    Private Sub altered_obj_btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altered_obj_btn1.Click
        altered_scene_outcome_txtbx.Text = "An unexpected event interrupts you."
    End Sub

    Private Sub altered_obj_btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altered_obj_btn2.Click
        altered_scene_outcome_txtbx.Text = "The location is different or changed."
    End Sub

    Private Sub altered_obj_btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altered_obj_btn3.Click
        altered_scene_outcome_txtbx.Text = "The NPCs are new or unexpected."
    End Sub

    Private Sub altered_obj_btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altered_obj_btn4.Click
        altered_scene_outcome_txtbx.Text = "Roll a different SCENE OBJECTIVE."
    End Sub

    Private Sub altered_obj_btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altered_obj_btn5.Click
        altered_scene_outcome_txtbx.Text = "An important event is already happening here."
    End Sub

    Private Sub altered_obj_btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altered_obj_btn6.Click
        altered_scene_outcome_txtbx.Text = "The situation is easier or harder."
    End Sub

    Private Sub scene_to_journal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scene_to_journal_btn.Click
        If journal.Visible = False Then
            journal.Visible = True
        End If

        journal.journal_txtbx.AppendText("Scene Objective:  " + set_the_scene_outcome_txtbx.Text + vbCrLf)

        If altered_scene_outcome_txtbx.Text = "The scene is not altered!" Or altered_scene_outcome_txtbx.Text = "Altered Scene Appears Here" Then

        Else
            journal.journal_txtbx.AppendText("The scene was altered:  " + altered_scene_outcome_txtbx.Text + vbCrLf)
        End If

    End Sub

    Private Sub set_the_scene_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_the_scene_clear_btn.Click
        set_the_scene_outcome_txtbx.Text = "Scene Appears Here"
        altered_scene_outcome_txtbx.Text = "Altered Scene Appears Here"
    End Sub

    Private Sub set_the_scene_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_the_scene_close_btn.Click
        set_the_scene_outcome_txtbx.Text = "Scene Appears Here"
        altered_scene_outcome_txtbx.Text = "Altered Scene Appears Here"
        Me.Hide()
    End Sub
End Class