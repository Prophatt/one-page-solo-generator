<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enemy_tactics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(enemy_tactics))
        Me.enemy_tactics_lbl = New System.Windows.Forms.Label()
        Me.get_enemy_tactic_btn = New System.Windows.Forms.Button()
        Me.the_enemy_will_lbl = New System.Windows.Forms.Label()
        Me.the_enemy_will_txtbx = New System.Windows.Forms.TextBox()
        Me.enemy_tactic_journal_btn = New System.Windows.Forms.Button()
        Me.enemy_tactic_close = New System.Windows.Forms.Button()
        Me.enemy_same_tactic_lbl = New System.Windows.Forms.Label()
        Me.enemy_tactic_force_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'enemy_tactics_lbl
        '
        Me.enemy_tactics_lbl.AutoSize = True
        Me.enemy_tactics_lbl.Location = New System.Drawing.Point(72, 9)
        Me.enemy_tactics_lbl.Name = "enemy_tactics_lbl"
        Me.enemy_tactics_lbl.Size = New System.Drawing.Size(193, 52)
        Me.enemy_tactics_lbl.TabIndex = 0
        Me.enemy_tactics_lbl.Text = "Enemy Tactics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "_______________________________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In combat, enemies should do what" & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "makes the most tactical sense"
        Me.enemy_tactics_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'get_enemy_tactic_btn
        '
        Me.get_enemy_tactic_btn.Location = New System.Drawing.Point(36, 73)
        Me.get_enemy_tactic_btn.Name = "get_enemy_tactic_btn"
        Me.get_enemy_tactic_btn.Size = New System.Drawing.Size(110, 37)
        Me.get_enemy_tactic_btn.TabIndex = 1
        Me.get_enemy_tactic_btn.Text = "Get Enemy Tactic"
        Me.get_enemy_tactic_btn.UseVisualStyleBackColor = True
        '
        'the_enemy_will_lbl
        '
        Me.the_enemy_will_lbl.AutoSize = True
        Me.the_enemy_will_lbl.Location = New System.Drawing.Point(33, 129)
        Me.the_enemy_will_lbl.Name = "the_enemy_will_lbl"
        Me.the_enemy_will_lbl.Size = New System.Drawing.Size(90, 13)
        Me.the_enemy_will_lbl.TabIndex = 2
        Me.the_enemy_will_lbl.Text = "The Enemy Will..."
        '
        'the_enemy_will_txtbx
        '
        Me.the_enemy_will_txtbx.Location = New System.Drawing.Point(36, 145)
        Me.the_enemy_will_txtbx.Name = "the_enemy_will_txtbx"
        Me.the_enemy_will_txtbx.Size = New System.Drawing.Size(270, 20)
        Me.the_enemy_will_txtbx.TabIndex = 3
        '
        'enemy_tactic_journal_btn
        '
        Me.enemy_tactic_journal_btn.Location = New System.Drawing.Point(36, 180)
        Me.enemy_tactic_journal_btn.Name = "enemy_tactic_journal_btn"
        Me.enemy_tactic_journal_btn.Size = New System.Drawing.Size(110, 37)
        Me.enemy_tactic_journal_btn.TabIndex = 4
        Me.enemy_tactic_journal_btn.Text = "Send to Journal"
        Me.enemy_tactic_journal_btn.UseVisualStyleBackColor = True
        '
        'enemy_tactic_close
        '
        Me.enemy_tactic_close.Location = New System.Drawing.Point(196, 180)
        Me.enemy_tactic_close.Name = "enemy_tactic_close"
        Me.enemy_tactic_close.Size = New System.Drawing.Size(110, 37)
        Me.enemy_tactic_close.TabIndex = 5
        Me.enemy_tactic_close.Text = "Close"
        Me.enemy_tactic_close.UseVisualStyleBackColor = True
        '
        'enemy_same_tactic_lbl
        '
        Me.enemy_same_tactic_lbl.AutoSize = True
        Me.enemy_same_tactic_lbl.Location = New System.Drawing.Point(120, 129)
        Me.enemy_same_tactic_lbl.Name = "enemy_same_tactic_lbl"
        Me.enemy_same_tactic_lbl.Size = New System.Drawing.Size(160, 13)
        Me.enemy_same_tactic_lbl.TabIndex = 5
        Me.enemy_same_tactic_lbl.Text = "Use same TACTIC as last action"
        Me.enemy_same_tactic_lbl.Visible = False
        '
        'enemy_tactic_force_btn
        '
        Me.enemy_tactic_force_btn.Location = New System.Drawing.Point(196, 73)
        Me.enemy_tactic_force_btn.Name = "enemy_tactic_force_btn"
        Me.enemy_tactic_force_btn.Size = New System.Drawing.Size(110, 37)
        Me.enemy_tactic_force_btn.TabIndex = 2
        Me.enemy_tactic_force_btn.Text = "Force New Tactic"
        Me.enemy_tactic_force_btn.UseVisualStyleBackColor = True
        '
        'enemy_tactics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 240)
        Me.Controls.Add(Me.enemy_tactic_force_btn)
        Me.Controls.Add(Me.enemy_same_tactic_lbl)
        Me.Controls.Add(Me.enemy_tactic_close)
        Me.Controls.Add(Me.enemy_tactic_journal_btn)
        Me.Controls.Add(Me.the_enemy_will_txtbx)
        Me.Controls.Add(Me.the_enemy_will_lbl)
        Me.Controls.Add(Me.get_enemy_tactic_btn)
        Me.Controls.Add(Me.enemy_tactics_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "enemy_tactics"
        Me.Text = "Enemy Tactics - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents enemy_tactics_lbl As System.Windows.Forms.Label
    Friend WithEvents get_enemy_tactic_btn As System.Windows.Forms.Button
    Friend WithEvents the_enemy_will_lbl As System.Windows.Forms.Label
    Friend WithEvents the_enemy_will_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents enemy_tactic_journal_btn As System.Windows.Forms.Button
    Friend WithEvents enemy_tactic_close As System.Windows.Forms.Button
    Friend WithEvents enemy_same_tactic_lbl As System.Windows.Forms.Label
    Friend WithEvents enemy_tactic_force_btn As System.Windows.Forms.Button
End Class
