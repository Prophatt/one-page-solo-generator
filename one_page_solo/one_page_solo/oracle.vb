Public Class oracle

    Private Sub oracle_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oracle_close_btn.Click
        'clear oracle box on exit
        oracle_question_txtbx.Text = ""
        oracle_answer_txtbx.Text = ""
        oracle_likely_radio.Checked = False
        oracle_normal_radio.Checked = False
        oracle_unlikely_radio.Checked = False
        oracle_radio_selection = ""
        Me.Hide()
    End Sub

    Private Sub oracle_to_journal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oracle_to_journal.Click
        'send to journal
        If journal.Visible = False Then
            journal.Visible = True
        End If
        journal.journal_txtbx.AppendText("I asked the oracle--  " + oracle_question_txtbx.Text + vbCrLf)
        journal.journal_txtbx.AppendText("The oracle answered--  " + oracle_answer_txtbx.Text + vbCrLf)
    End Sub

    Private Sub oracle_likely_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oracle_likely_radio.CheckedChanged
        oracle_radio_selection = "likely"
    End Sub

    Private Sub oracle_normal_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oracle_normal_radio.CheckedChanged
        oracle_radio_selection = "normal"
    End Sub

    Private Sub oracle_unlikely_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oracle_unlikely_radio.CheckedChanged
        oracle_radio_selection = "unlikely"
    End Sub

    Private Sub ask_the_oracle_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ask_the_oracle_btn.Click
        If oracle_radio_selection = "" Then
            MsgBox("You did not select a likelyhood.", MsgBoxStyle.Information, "Oracle - One Page Solo Engine")
            Exit Sub
        End If
        die_roll = vbNull
        Select Case oracle_radio_selection
            'generate oracle answers based on how likely an answer is
            Case "likely"
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 3
                        oracle_answer_txtbx.Text = "Yes"
                    Case 4
                        oracle_answer_txtbx.Text = "Yes"
                    Case 5
                        oracle_answer_txtbx.Text = "Yes"
                    Case 6
                        oracle_answer_txtbx.Text = "Yes"
                    Case Else
                        oracle_answer_txtbx.Text = "No"
                End Select
            Case "normal"
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 4
                        oracle_answer_txtbx.Text = "Yes"
                    Case 5
                        oracle_answer_txtbx.Text = "Yes"
                    Case 6
                        oracle_answer_txtbx.Text = "Yes"
                    Case Else
                        oracle_answer_txtbx.Text = "No"
                End Select
            Case "unlikely"
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 5
                        oracle_answer_txtbx.Text = "Yes"
                    Case 6
                        oracle_answer_txtbx.Text = "Yes"
                    Case Else
                        oracle_answer_txtbx.Text = "No"
                End Select
        End Select

        'qualifier roll
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1
                Me.oracle_answer_txtbx.AppendText("...but...")
            Case 6
                Me.oracle_answer_txtbx.AppendText("...and...")
            Case Else
                Exit Sub
        End Select
    End Sub
End Class