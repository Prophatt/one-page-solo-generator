Public Class dungeon_crawler

    Private Sub dungeon_crawler_close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dungeon_crawler_close_btn.Click
        Me.Hide()
    End Sub

    Private Sub get_dungeon_room_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_dungeon_room_btn.Click
        'randomly generated dungeon room
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1
                dungeon_crawler_location_txtbx.Text = "A living area or meeting place"
            Case 2
                dungeon_crawler_location_txtbx.Text = "A working or utility area"
            Case 3 To 4
                dungeon_crawler_location_txtbx.Text = "A typical, unremarkable area"
            Case 5
                dungeon_crawler_location_txtbx.Text = "An area with a special feature"
            Case 6
                dungeon_crawler_location_txtbx.Text = "A location for a specialized purpose"
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 4 To 6
                        Me.dungeon_crawler_location_txtbx.AppendText(", you find the specific goal/element you seek if there is one")
                End Select
        End Select
        'populate dungeon
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1
                dungeon_crawler_encounter_txtbx.Text = "Hostile enemies"
            Case 2
                dungeon_crawler_encounter_txtbx.Text = "Hostile enemies"
            Case 3 To 4
                dungeon_crawler_encounter_txtbx.Text = "None"
            Case 5
                dungeon_crawler_encounter_txtbx.Text = "A friendly or neutral NPC"
            Case 6
                dungeon_crawler_encounter_txtbx.Text = "A unique NPC or adversary"
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 4 To 6
                        Me.dungeon_crawler_encounter_txtbx.AppendText(", you find the specific goal/element you seek if there is one")
                End Select
        End Select
        'dungeon room oddities
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1
                dungeon_crawler_object_txtbx.Text = "An interesting item or clue"
            Case 2
                dungeon_crawler_object_txtbx.Text = "A useful tool, key, or device"
            Case 3 To 4
                dungeon_crawler_object_txtbx.Text = "Nothing, or mundane objects"
            Case 5
                dungeon_crawler_object_txtbx.Text = "A valuable treasure"
            Case 6
                dungeon_crawler_object_txtbx.Text = "A rare or special item"
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 4 To 6
                        Me.dungeon_crawler_object_txtbx.AppendText(", you find the specific goal/element you seek if there is one")
                End Select
        End Select
        'dungeon room surprise!
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        Select Case die_roll
            Case 1
                dungeon_crawler_special_txtbx.Text = "There’s a trap here"
            Case 2
                dungeon_crawler_special_txtbx.Text = "There’s a secret hidden here"
            Case 3 To 5
                dungeon_crawler_special_txtbx.Text = "Nothing special"
            Case 6
                dungeon_crawler_special_txtbx.Text = "A challenge or item is enhanced"
        End Select
        die_roll = vbNull
        die_roll = GetRandom(1, 7)
        'dungeon room doors
        Select Case die_roll
            Case 1
                dungeon_crawler_exits_txtbx.Text = "Dead end (1 exit)"
            Case 2 To 3
                dungeon_crawler_exits_txtbx.Text = "2 exits"
            Case 4
                dungeon_crawler_exits_txtbx.Text = "3 exits"
            Case 5
                dungeon_crawler_exits_txtbx.Text = "3 exits (connects to existing area)"
            Case 6
                dungeon_crawler_exits_txtbx.Text = "3 exits"
                die_roll = vbNull
                die_roll = GetRandom(1, 7)
                Select Case die_roll
                    Case 4 To 6
                        Me.dungeon_crawler_exits_txtbx.AppendText(", you find an exit to the dungeon")
                End Select
        End Select
    End Sub

    Private Sub dungeon_crawler_to_journal_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dungeon_crawler_to_journal_btn.Click
        If journal.Visible = False Then
            journal.Visible = True
        End If
        journal.journal_txtbx.AppendText("Generating a Dungeon" + vbCrLf)
        journal.journal_txtbx.AppendText(tspace + "A Dungeon Room" + vbCrLf)
        journal.journal_txtbx.AppendText(tspace + tspace + "Location:" + dungeon_crawler_location_txtbx.Text + vbCrLf)
        journal.journal_txtbx.AppendText(tspace + tspace + "Encounter:" + dungeon_crawler_encounter_txtbx.Text + vbCrLf)
        journal.journal_txtbx.AppendText(tspace + tspace + "Object:" + dungeon_crawler_object_txtbx.Text + vbCrLf)
        journal.journal_txtbx.AppendText(tspace + tspace + "Special:" + dungeon_crawler_special_txtbx.Text + vbCrLf)
        journal.journal_txtbx.AppendText(tspace + tspace + "Exits:" + dungeon_crawler_exits_txtbx.Text + vbCrLf)
    End Sub
End Class