<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dungeon_crawler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dungeon_crawler))
        Me.dungeon_crawler_lbl = New System.Windows.Forms.Label()
        Me.get_dungeon_room_btn = New System.Windows.Forms.Button()
        Me.dungeon_Crawler_location_lbl = New System.Windows.Forms.Label()
        Me.dungeon_crawler_location_txtbx = New System.Windows.Forms.TextBox()
        Me.dungeon_crawler_encounter_lbl = New System.Windows.Forms.Label()
        Me.dungeon_crawler_encounter_txtbx = New System.Windows.Forms.TextBox()
        Me.dungeon_crawler_object_lbl = New System.Windows.Forms.Label()
        Me.dungeon_crawler_object_txtbx = New System.Windows.Forms.TextBox()
        Me.dungeon_crawler_special_lbl = New System.Windows.Forms.Label()
        Me.dungeon_crawler_special_txtbx = New System.Windows.Forms.TextBox()
        Me.dungeon_crawler_exits_lbl = New System.Windows.Forms.Label()
        Me.dungeon_crawler_exits_txtbx = New System.Windows.Forms.TextBox()
        Me.dungeon_crawler_to_journal_btn = New System.Windows.Forms.Button()
        Me.dungeon_crawler_close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dungeon_crawler_lbl
        '
        Me.dungeon_crawler_lbl.AutoSize = True
        Me.dungeon_crawler_lbl.Location = New System.Drawing.Point(64, 9)
        Me.dungeon_crawler_lbl.Name = "dungeon_crawler_lbl"
        Me.dungeon_crawler_lbl.Size = New System.Drawing.Size(230, 195)
        Me.dungeon_crawler_lbl.TabIndex = 0
        Me.dungeon_crawler_lbl.Text = resources.GetString("dungeon_crawler_lbl.Text")
        Me.dungeon_crawler_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'get_dungeon_room_btn
        '
        Me.get_dungeon_room_btn.Location = New System.Drawing.Point(117, 218)
        Me.get_dungeon_room_btn.Name = "get_dungeon_room_btn"
        Me.get_dungeon_room_btn.Size = New System.Drawing.Size(110, 37)
        Me.get_dungeon_room_btn.TabIndex = 1
        Me.get_dungeon_room_btn.Text = "Get Dungeon Room"
        Me.get_dungeon_room_btn.UseVisualStyleBackColor = True
        '
        'dungeon_Crawler_location_lbl
        '
        Me.dungeon_Crawler_location_lbl.AutoSize = True
        Me.dungeon_Crawler_location_lbl.Location = New System.Drawing.Point(12, 288)
        Me.dungeon_Crawler_location_lbl.Name = "dungeon_Crawler_location_lbl"
        Me.dungeon_Crawler_location_lbl.Size = New System.Drawing.Size(51, 13)
        Me.dungeon_Crawler_location_lbl.TabIndex = 2
        Me.dungeon_Crawler_location_lbl.Text = "Location:"
        '
        'dungeon_crawler_location_txtbx
        '
        Me.dungeon_crawler_location_txtbx.Location = New System.Drawing.Point(69, 272)
        Me.dungeon_crawler_location_txtbx.Multiline = True
        Me.dungeon_crawler_location_txtbx.Name = "dungeon_crawler_location_txtbx"
        Me.dungeon_crawler_location_txtbx.Size = New System.Drawing.Size(251, 38)
        Me.dungeon_crawler_location_txtbx.TabIndex = 2
        '
        'dungeon_crawler_encounter_lbl
        '
        Me.dungeon_crawler_encounter_lbl.AutoSize = True
        Me.dungeon_crawler_encounter_lbl.Location = New System.Drawing.Point(4, 329)
        Me.dungeon_crawler_encounter_lbl.Name = "dungeon_crawler_encounter_lbl"
        Me.dungeon_crawler_encounter_lbl.Size = New System.Drawing.Size(59, 13)
        Me.dungeon_crawler_encounter_lbl.TabIndex = 4
        Me.dungeon_crawler_encounter_lbl.Text = "Encounter:"
        '
        'dungeon_crawler_encounter_txtbx
        '
        Me.dungeon_crawler_encounter_txtbx.Location = New System.Drawing.Point(69, 316)
        Me.dungeon_crawler_encounter_txtbx.Multiline = True
        Me.dungeon_crawler_encounter_txtbx.Name = "dungeon_crawler_encounter_txtbx"
        Me.dungeon_crawler_encounter_txtbx.Size = New System.Drawing.Size(251, 38)
        Me.dungeon_crawler_encounter_txtbx.TabIndex = 3
        '
        'dungeon_crawler_object_lbl
        '
        Me.dungeon_crawler_object_lbl.AutoSize = True
        Me.dungeon_crawler_object_lbl.Location = New System.Drawing.Point(22, 374)
        Me.dungeon_crawler_object_lbl.Name = "dungeon_crawler_object_lbl"
        Me.dungeon_crawler_object_lbl.Size = New System.Drawing.Size(41, 13)
        Me.dungeon_crawler_object_lbl.TabIndex = 6
        Me.dungeon_crawler_object_lbl.Text = "Object:"
        '
        'dungeon_crawler_object_txtbx
        '
        Me.dungeon_crawler_object_txtbx.Location = New System.Drawing.Point(69, 360)
        Me.dungeon_crawler_object_txtbx.Multiline = True
        Me.dungeon_crawler_object_txtbx.Name = "dungeon_crawler_object_txtbx"
        Me.dungeon_crawler_object_txtbx.Size = New System.Drawing.Size(251, 38)
        Me.dungeon_crawler_object_txtbx.TabIndex = 4
        '
        'dungeon_crawler_special_lbl
        '
        Me.dungeon_crawler_special_lbl.AutoSize = True
        Me.dungeon_crawler_special_lbl.Location = New System.Drawing.Point(18, 408)
        Me.dungeon_crawler_special_lbl.Name = "dungeon_crawler_special_lbl"
        Me.dungeon_crawler_special_lbl.Size = New System.Drawing.Size(45, 13)
        Me.dungeon_crawler_special_lbl.TabIndex = 8
        Me.dungeon_crawler_special_lbl.Text = "Special:"
        '
        'dungeon_crawler_special_txtbx
        '
        Me.dungeon_crawler_special_txtbx.Location = New System.Drawing.Point(69, 405)
        Me.dungeon_crawler_special_txtbx.Name = "dungeon_crawler_special_txtbx"
        Me.dungeon_crawler_special_txtbx.Size = New System.Drawing.Size(251, 20)
        Me.dungeon_crawler_special_txtbx.TabIndex = 5
        '
        'dungeon_crawler_exits_lbl
        '
        Me.dungeon_crawler_exits_lbl.AutoSize = True
        Me.dungeon_crawler_exits_lbl.Location = New System.Drawing.Point(31, 435)
        Me.dungeon_crawler_exits_lbl.Name = "dungeon_crawler_exits_lbl"
        Me.dungeon_crawler_exits_lbl.Size = New System.Drawing.Size(32, 13)
        Me.dungeon_crawler_exits_lbl.TabIndex = 10
        Me.dungeon_crawler_exits_lbl.Text = "Exits:"
        '
        'dungeon_crawler_exits_txtbx
        '
        Me.dungeon_crawler_exits_txtbx.Location = New System.Drawing.Point(69, 432)
        Me.dungeon_crawler_exits_txtbx.Name = "dungeon_crawler_exits_txtbx"
        Me.dungeon_crawler_exits_txtbx.Size = New System.Drawing.Size(251, 20)
        Me.dungeon_crawler_exits_txtbx.TabIndex = 6
        '
        'dungeon_crawler_to_journal_btn
        '
        Me.dungeon_crawler_to_journal_btn.Location = New System.Drawing.Point(21, 472)
        Me.dungeon_crawler_to_journal_btn.Name = "dungeon_crawler_to_journal_btn"
        Me.dungeon_crawler_to_journal_btn.Size = New System.Drawing.Size(110, 37)
        Me.dungeon_crawler_to_journal_btn.TabIndex = 7
        Me.dungeon_crawler_to_journal_btn.Text = "Send to Journal"
        Me.dungeon_crawler_to_journal_btn.UseVisualStyleBackColor = True
        '
        'dungeon_crawler_close_btn
        '
        Me.dungeon_crawler_close_btn.Location = New System.Drawing.Point(222, 472)
        Me.dungeon_crawler_close_btn.Name = "dungeon_crawler_close_btn"
        Me.dungeon_crawler_close_btn.Size = New System.Drawing.Size(110, 37)
        Me.dungeon_crawler_close_btn.TabIndex = 8
        Me.dungeon_crawler_close_btn.Text = "Close"
        Me.dungeon_crawler_close_btn.UseVisualStyleBackColor = True
        '
        'dungeon_crawler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 533)
        Me.Controls.Add(Me.dungeon_crawler_close_btn)
        Me.Controls.Add(Me.dungeon_crawler_to_journal_btn)
        Me.Controls.Add(Me.dungeon_crawler_exits_txtbx)
        Me.Controls.Add(Me.dungeon_crawler_exits_lbl)
        Me.Controls.Add(Me.dungeon_crawler_special_txtbx)
        Me.Controls.Add(Me.dungeon_crawler_special_lbl)
        Me.Controls.Add(Me.dungeon_crawler_object_txtbx)
        Me.Controls.Add(Me.dungeon_crawler_object_lbl)
        Me.Controls.Add(Me.dungeon_crawler_encounter_txtbx)
        Me.Controls.Add(Me.dungeon_crawler_encounter_lbl)
        Me.Controls.Add(Me.dungeon_crawler_location_txtbx)
        Me.Controls.Add(Me.dungeon_Crawler_location_lbl)
        Me.Controls.Add(Me.get_dungeon_room_btn)
        Me.Controls.Add(Me.dungeon_crawler_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dungeon_crawler"
        Me.Text = "Dungeon Crawler - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dungeon_crawler_lbl As System.Windows.Forms.Label
    Friend WithEvents get_dungeon_room_btn As System.Windows.Forms.Button
    Friend WithEvents dungeon_Crawler_location_lbl As System.Windows.Forms.Label
    Friend WithEvents dungeon_crawler_location_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents dungeon_crawler_encounter_lbl As System.Windows.Forms.Label
    Friend WithEvents dungeon_crawler_encounter_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents dungeon_crawler_object_lbl As System.Windows.Forms.Label
    Friend WithEvents dungeon_crawler_object_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents dungeon_crawler_special_lbl As System.Windows.Forms.Label
    Friend WithEvents dungeon_crawler_special_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents dungeon_crawler_exits_lbl As System.Windows.Forms.Label
    Friend WithEvents dungeon_crawler_exits_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents dungeon_crawler_to_journal_btn As System.Windows.Forms.Button
    Friend WithEvents dungeon_crawler_close_btn As System.Windows.Forms.Button
End Class
