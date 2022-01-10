Public Class complex_oracle

    Private Sub ask_complex_question_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ask_complex_question.Click
        die_roll = vbNull
        die_roll = GetRandom(1, 14)
        Select Case die_roll
            Case 1
                oracle_complex_answer_txtbx.Text = "Seeking"
            Case 2
                oracle_complex_answer_txtbx.Text = "Opposing"
            Case 3
                oracle_complex_answer_txtbx.Text = "Communicating"
            Case 4
                oracle_complex_answer_txtbx.Text = "Moving"
            Case 5
                oracle_complex_answer_txtbx.Text = "Harming"
            Case 6
                oracle_complex_answer_txtbx.Text = "Creating"
            Case 7
                oracle_complex_answer_txtbx.Text = "Planning"
            Case 8
                oracle_complex_answer_txtbx.Text = "Failing"
            Case 9
                oracle_complex_answer_txtbx.Text = "Taking"
            Case 10
                oracle_complex_answer_txtbx.Text = "Abandoning"
            Case 11
                oracle_complex_answer_txtbx.Text = "Assisting"
            Case 12
                oracle_complex_answer_txtbx.Text = "Changing"
            Case 13
                oracle_complex_answer_txtbx.Text = "Deceiving"
        End Select

        die_roll = vbNull
        die_roll = GetRandom(1, 5)
        Select Case die_roll
            Case 1
                Me.oracle_complex_answer_txtbx.AppendText(", physical, strong, constructed")
            Case 2
                Me.oracle_complex_answer_txtbx.AppendText(", mental, plotting, technical")
            Case 3
                Me.oracle_complex_answer_txtbx.AppendText(", magical, intuitive, strange")
            Case 4
                Me.oracle_complex_answer_txtbx.AppendText(", personal, social, emotional")
        End Select
    End Sub

    Private Sub complex_to_journal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles complex_to_journal.Click
        If journal.Visible = False Then
            journal.Visible = True
        End If
        journal.journal_txtbx.AppendText("I asked the oracle this complex question--  " + my_complex_question_txtbx.Text + vbCrLf)
        journal.journal_txtbx.AppendText("The oracle answered with these words of guidance--  " + oracle_complex_answer_txtbx.Text + vbCrLf)
    End Sub

    Private Sub complexe_question_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles complexe_question_close_btn.Click
        my_complex_question_txtbx.Text = ""
        oracle_complex_answer_txtbx.Text = ""
        die_roll = vbNull
        Me.Hide()
    End Sub
End Class