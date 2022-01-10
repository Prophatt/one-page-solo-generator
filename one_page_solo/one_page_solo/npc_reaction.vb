Public Class npc_reaction

    Private Sub get_npc_reaction_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_npc_reaction_btn.Click
        'get how non player characters react to your character from die roll to determine reaction and then extra actions
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1 To 2
                npc_reaction_txtbx.Text = "The NPC is Friendly "
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 1
                        Me.npc_reaction_txtbx.AppendText("and Talkative or gossipy")
                    Case 2
                        Me.npc_reaction_txtbx.AppendText("and Wants to trade")
                    Case 3
                        Me.npc_reaction_txtbx.AppendText("and Offers help or advice")
                    Case 4
                        Me.npc_reaction_txtbx.AppendText("and Needs a favor or has a job")
                    Case 5
                        Me.npc_reaction_txtbx.AppendText("and Has a lead or a clue")
                    Case 6 To 7
                        Me.npc_reaction_txtbx.AppendText("and Offers direct assistance")
                End Select
            Case 3 To 4
                npc_reaction_txtbx.Text = "The NPC is Neutral "
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 1
                        Me.npc_reaction_txtbx.AppendText("and Not interested in talking")
                    Case 2
                        Me.npc_reaction_txtbx.AppendText("and Wants to trade")
                    Case 3
                        Me.npc_reaction_txtbx.AppendText("and Requests tribute or payment")
                    Case 4
                        Me.npc_reaction_txtbx.AppendText("and Needs a favor or has a job")
                    Case 5
                        Me.npc_reaction_txtbx.AppendText("and Tries to trick or deceive")
                    Case 6 To 7
                        Me.npc_reaction_txtbx.AppendText("and Pursuing unrelated objective")
                End Select
            Case 5 To 7
                npc_reaction_txtbx.Text = "The NPC is Hostile "
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 1
                        Me.npc_reaction_txtbx.AppendText("and Attacks without warning")
                    Case 2
                        Me.npc_reaction_txtbx.AppendText("and Threatens or harasses")
                    Case 3
                        Me.npc_reaction_txtbx.AppendText("and Demands tribute or payment")
                    Case 4
                        Me.npc_reaction_txtbx.AppendText("and Denies access")
                    Case 5
                        Me.npc_reaction_txtbx.AppendText("and Tries to trick or deceive")
                    Case 6 To 7
                        Me.npc_reaction_txtbx.AppendText("and Pursuing counter objective")
                End Select
        End Select
    End Sub

    Private Sub reaction_to_journal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reaction_to_journal_btn.Click
        If journal.Visible = False Then
            journal.Visible = True
        End If
        journal.journal_txtbx.AppendText("I Met a NPC--  " + npc_reaction_txtbx.Text + vbCrLf)

    End Sub

    Private Sub npc_reaction_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles npc_reaction_close.Click
        npc_reaction_txtbx.Text = ""
        die_roll = vbNull
        Me.Hide()
    End Sub
End Class