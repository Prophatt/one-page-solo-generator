Public Class home
    'One Page Solo Engine Karl Hendricks v0.2 CC BY-SA 4.0
    'PC Programming done by Greg Gill 20200318

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        intial_directory()

    End Sub
    Private Sub intial_directory()
        'create journal directory if it doesn't exist
        If My.Computer.FileSystem.DirectoryExists(System.AppDomain.CurrentDomain.BaseDirectory() + "saved_journals") = False Then

            My.Computer.FileSystem.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory() + "saved_journals")

        End If
    End Sub


    Private Sub how_to_play_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles how_to_play_btn.Click
        how_to_play_form.Show()
    End Sub

    Private Sub set_the_scene_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_the_scene_btn.Click
        set_the_scene.Show()
    End Sub

    Private Sub oracle_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oracle_btn.Click
        oracle.Show()
    End Sub

    Private Sub complex_quest_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles complex_quest_btn.Click
        complex_oracle.Show()
    End Sub

    Private Sub npc_reaction_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles npc_reaction_btn.Click
        npc_reaction.Show()
    End Sub

    Private Sub enemy_tactics_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemy_tactics_btn.Click
        enemy_tactics.Show()
    End Sub

    Private Sub dungeon_crawler_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dungeon_crawler_btn.Click
        dungeon_crawler.Show()
    End Sub

    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        ' save check for journal entry
        If journal.journal_txtbx.Text <> "" Then
            Select Case MsgBox("There is still text in the journal. Would you like to save?", MsgBoxStyle.YesNo, "Save Journal - One Page Solo engine")
                Case MsgBoxResult.Yes
                    savejournal()
                Case MsgBoxResult.No
                    End
            End Select
        End If
        End
    End Sub

    Private Sub journal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles journal_btn.Click
        journal.Show()
    End Sub

    Private Sub dice_roller_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dice_roller_btn.Click
        dice_roller.Show()
    End Sub
End Class
