<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class npc_reaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(npc_reaction))
        Me.npc_reaction_lbl = New System.Windows.Forms.Label()
        Me.get_npc_reaction_btn = New System.Windows.Forms.Button()
        Me.npc_reaction_outcome_lbl = New System.Windows.Forms.Label()
        Me.npc_reaction_txtbx = New System.Windows.Forms.TextBox()
        Me.reaction_to_journal_btn = New System.Windows.Forms.Button()
        Me.npc_reaction_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'npc_reaction_lbl
        '
        Me.npc_reaction_lbl.AutoSize = True
        Me.npc_reaction_lbl.Location = New System.Drawing.Point(50, 9)
        Me.npc_reaction_lbl.Name = "npc_reaction_lbl"
        Me.npc_reaction_lbl.Size = New System.Drawing.Size(235, 52)
        Me.npc_reaction_lbl.TabIndex = 0
        Me.npc_reaction_lbl.Text = "NPC Reaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "______________________________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "When you meet an NPC, roll " & _
            "its initial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "reaction below."
        Me.npc_reaction_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'get_npc_reaction_btn
        '
        Me.get_npc_reaction_btn.Location = New System.Drawing.Point(111, 77)
        Me.get_npc_reaction_btn.Name = "get_npc_reaction_btn"
        Me.get_npc_reaction_btn.Size = New System.Drawing.Size(110, 37)
        Me.get_npc_reaction_btn.TabIndex = 1
        Me.get_npc_reaction_btn.Text = "Get NPC Reaction"
        Me.get_npc_reaction_btn.UseVisualStyleBackColor = True
        '
        'npc_reaction_outcome_lbl
        '
        Me.npc_reaction_outcome_lbl.AutoSize = True
        Me.npc_reaction_outcome_lbl.Location = New System.Drawing.Point(67, 127)
        Me.npc_reaction_outcome_lbl.Name = "npc_reaction_outcome_lbl"
        Me.npc_reaction_outcome_lbl.Size = New System.Drawing.Size(207, 13)
        Me.npc_reaction_outcome_lbl.TabIndex = 2
        Me.npc_reaction_outcome_lbl.Text = "The NPCs Reaction to Your Character is..."
        '
        'npc_reaction_txtbx
        '
        Me.npc_reaction_txtbx.Location = New System.Drawing.Point(12, 153)
        Me.npc_reaction_txtbx.Name = "npc_reaction_txtbx"
        Me.npc_reaction_txtbx.Size = New System.Drawing.Size(320, 20)
        Me.npc_reaction_txtbx.TabIndex = 2
        '
        'reaction_to_journal_btn
        '
        Me.reaction_to_journal_btn.Location = New System.Drawing.Point(53, 196)
        Me.reaction_to_journal_btn.Name = "reaction_to_journal_btn"
        Me.reaction_to_journal_btn.Size = New System.Drawing.Size(110, 37)
        Me.reaction_to_journal_btn.TabIndex = 3
        Me.reaction_to_journal_btn.Text = "Send to Journal"
        Me.reaction_to_journal_btn.UseVisualStyleBackColor = True
        '
        'npc_reaction_close
        '
        Me.npc_reaction_close.Location = New System.Drawing.Point(175, 196)
        Me.npc_reaction_close.Name = "npc_reaction_close"
        Me.npc_reaction_close.Size = New System.Drawing.Size(110, 37)
        Me.npc_reaction_close.TabIndex = 4
        Me.npc_reaction_close.Text = "Close"
        Me.npc_reaction_close.UseVisualStyleBackColor = True
        '
        'npc_reaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 260)
        Me.Controls.Add(Me.npc_reaction_close)
        Me.Controls.Add(Me.reaction_to_journal_btn)
        Me.Controls.Add(Me.npc_reaction_txtbx)
        Me.Controls.Add(Me.npc_reaction_outcome_lbl)
        Me.Controls.Add(Me.get_npc_reaction_btn)
        Me.Controls.Add(Me.npc_reaction_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "npc_reaction"
        Me.Text = "NPC Reaction - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents npc_reaction_lbl As System.Windows.Forms.Label
    Friend WithEvents get_npc_reaction_btn As System.Windows.Forms.Button
    Friend WithEvents npc_reaction_outcome_lbl As System.Windows.Forms.Label
    Friend WithEvents npc_reaction_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents reaction_to_journal_btn As System.Windows.Forms.Button
    Friend WithEvents npc_reaction_close As System.Windows.Forms.Button
End Class
