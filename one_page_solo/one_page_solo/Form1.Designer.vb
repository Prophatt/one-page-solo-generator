<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.title_lbl = New System.Windows.Forms.Label()
        Me.how_to_play_btn = New System.Windows.Forms.Button()
        Me.set_the_scene_btn = New System.Windows.Forms.Button()
        Me.oracle_btn = New System.Windows.Forms.Button()
        Me.complex_quest_btn = New System.Windows.Forms.Button()
        Me.npc_reaction_btn = New System.Windows.Forms.Button()
        Me.enemy_tactics_btn = New System.Windows.Forms.Button()
        Me.dungeon_crawler_btn = New System.Windows.Forms.Button()
        Me.journal_btn = New System.Windows.Forms.Button()
        Me.dice_roller_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'title_lbl
        '
        Me.title_lbl.AutoSize = True
        Me.title_lbl.Location = New System.Drawing.Point(41, 9)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(211, 104)
        Me.title_lbl.TabIndex = 0
        Me.title_lbl.Text = resources.GetString("title_lbl.Text")
        Me.title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'how_to_play_btn
        '
        Me.how_to_play_btn.Location = New System.Drawing.Point(90, 132)
        Me.how_to_play_btn.Name = "how_to_play_btn"
        Me.how_to_play_btn.Size = New System.Drawing.Size(110, 37)
        Me.how_to_play_btn.TabIndex = 1
        Me.how_to_play_btn.Text = "How To Play"
        Me.how_to_play_btn.UseVisualStyleBackColor = True
        '
        'set_the_scene_btn
        '
        Me.set_the_scene_btn.Location = New System.Drawing.Point(90, 175)
        Me.set_the_scene_btn.Name = "set_the_scene_btn"
        Me.set_the_scene_btn.Size = New System.Drawing.Size(110, 37)
        Me.set_the_scene_btn.TabIndex = 2
        Me.set_the_scene_btn.Text = "Set The Scene"
        Me.set_the_scene_btn.UseVisualStyleBackColor = True
        '
        'oracle_btn
        '
        Me.oracle_btn.Location = New System.Drawing.Point(90, 218)
        Me.oracle_btn.Name = "oracle_btn"
        Me.oracle_btn.Size = New System.Drawing.Size(110, 37)
        Me.oracle_btn.TabIndex = 3
        Me.oracle_btn.Text = "Oracle"
        Me.oracle_btn.UseVisualStyleBackColor = True
        '
        'complex_quest_btn
        '
        Me.complex_quest_btn.Location = New System.Drawing.Point(90, 261)
        Me.complex_quest_btn.Name = "complex_quest_btn"
        Me.complex_quest_btn.Size = New System.Drawing.Size(110, 37)
        Me.complex_quest_btn.TabIndex = 4
        Me.complex_quest_btn.Text = "Complex Question"
        Me.complex_quest_btn.UseVisualStyleBackColor = True
        '
        'npc_reaction_btn
        '
        Me.npc_reaction_btn.Location = New System.Drawing.Point(90, 304)
        Me.npc_reaction_btn.Name = "npc_reaction_btn"
        Me.npc_reaction_btn.Size = New System.Drawing.Size(110, 37)
        Me.npc_reaction_btn.TabIndex = 5
        Me.npc_reaction_btn.Text = "NPC Reaction"
        Me.npc_reaction_btn.UseVisualStyleBackColor = True
        '
        'enemy_tactics_btn
        '
        Me.enemy_tactics_btn.Location = New System.Drawing.Point(90, 347)
        Me.enemy_tactics_btn.Name = "enemy_tactics_btn"
        Me.enemy_tactics_btn.Size = New System.Drawing.Size(110, 37)
        Me.enemy_tactics_btn.TabIndex = 6
        Me.enemy_tactics_btn.Text = "Enemy Tactics"
        Me.enemy_tactics_btn.UseVisualStyleBackColor = True
        '
        'dungeon_crawler_btn
        '
        Me.dungeon_crawler_btn.Location = New System.Drawing.Point(90, 390)
        Me.dungeon_crawler_btn.Name = "dungeon_crawler_btn"
        Me.dungeon_crawler_btn.Size = New System.Drawing.Size(110, 37)
        Me.dungeon_crawler_btn.TabIndex = 7
        Me.dungeon_crawler_btn.Text = "Dungeon Crawler"
        Me.dungeon_crawler_btn.UseVisualStyleBackColor = True
        '
        'journal_btn
        '
        Me.journal_btn.Location = New System.Drawing.Point(90, 433)
        Me.journal_btn.Name = "journal_btn"
        Me.journal_btn.Size = New System.Drawing.Size(110, 37)
        Me.journal_btn.TabIndex = 8
        Me.journal_btn.Text = "Journal"
        Me.journal_btn.UseVisualStyleBackColor = True
        '
        'dice_roller_btn
        '
        Me.dice_roller_btn.Location = New System.Drawing.Point(90, 476)
        Me.dice_roller_btn.Name = "dice_roller_btn"
        Me.dice_roller_btn.Size = New System.Drawing.Size(110, 37)
        Me.dice_roller_btn.TabIndex = 9
        Me.dice_roller_btn.Text = "Dice Roller"
        Me.dice_roller_btn.UseVisualStyleBackColor = True
        Me.dice_roller_btn.Visible = False
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(90, 519)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(110, 37)
        Me.exit_btn.TabIndex = 10
        Me.exit_btn.Text = "Exit Program"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 575)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.dice_roller_btn)
        Me.Controls.Add(Me.journal_btn)
        Me.Controls.Add(Me.dungeon_crawler_btn)
        Me.Controls.Add(Me.enemy_tactics_btn)
        Me.Controls.Add(Me.npc_reaction_btn)
        Me.Controls.Add(Me.complex_quest_btn)
        Me.Controls.Add(Me.oracle_btn)
        Me.Controls.Add(Me.set_the_scene_btn)
        Me.Controls.Add(Me.how_to_play_btn)
        Me.Controls.Add(Me.title_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home"
        Me.Text = "Home - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title_lbl As System.Windows.Forms.Label
    Friend WithEvents how_to_play_btn As System.Windows.Forms.Button
    Friend WithEvents set_the_scene_btn As System.Windows.Forms.Button
    Friend WithEvents oracle_btn As System.Windows.Forms.Button
    Friend WithEvents complex_quest_btn As System.Windows.Forms.Button
    Friend WithEvents npc_reaction_btn As System.Windows.Forms.Button
    Friend WithEvents enemy_tactics_btn As System.Windows.Forms.Button
    Friend WithEvents dungeon_crawler_btn As System.Windows.Forms.Button
    Friend WithEvents journal_btn As System.Windows.Forms.Button
    Friend WithEvents dice_roller_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button

End Class
