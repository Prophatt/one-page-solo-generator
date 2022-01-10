Public Class journal
    'create a basic journal that can be saved as a text file
    Private Sub journal_txtbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles journal_txtbx.TextChanged

    End Sub

    Private Sub journal_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles journal_close_btn.Click
        Me.Hide()
    End Sub

    Private Sub journal_clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles journal_clear_btn.Click

        'check for clear journal decision
        Select Case MsgBox("This will clear this journal, this act can not be undone. Would you like to save?", MsgBoxStyle.YesNo, "Clear Journal - One Page Solo engine")
            Case MsgBoxResult.Yes
                savejournal()
            Case MsgBoxResult.No
                journal_txtbx.Text = ""
        End Select
    End Sub

    Private Sub journal_save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles journal_save_btn.Click
        savejournal()
    End Sub

    Private Sub journal_open_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles journal_open_btn.Click
        openjournal()
    End Sub
End Class