Module variables
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Public die_roll As Integer
    Public oracle_radio_selection As String
    Public oracle_answer As String
    Public oracle_qualifier_answer As String
    Public tspace As String = "     "
    Public savePathdialogue As String = (System.AppDomain.CurrentDomain.BaseDirectory() + "saved_journals")

    Public Function savejournal()
        'journal save function
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.InitialDirectory = (savePathdialogue)
        saveFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        saveFileDialog1.Title = "Save a Journal File"
        saveFileDialog1.FileName = "journal_" + Format(Now, "yyyyMMdd_HHmm")
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, journal.journal_txtbx.Text, False)
        End If
        Return ""
    End Function
    Public Function openjournal()
        'journal  open function
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.InitialDirectory = (savePathdialogue)
        fd.Filter = "Text File|*.txt|All Files|*.*"
        fd.Title = "Open a Journal File"
        If fd.ShowDialog() <> "" Then
            journal.journal_txtbx.Text = My.Computer.FileSystem.ReadAllText(fd.FileName)
        End If
        Return ""
    End Function
End Module
