<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class how_to_play_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(how_to_play_form))
        Me.how_to_play_info_lbl = New System.Windows.Forms.Label()
        Me.exit_how_to_play_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'how_to_play_info_lbl
        '
        Me.how_to_play_info_lbl.AutoSize = True
        Me.how_to_play_info_lbl.Location = New System.Drawing.Point(12, 9)
        Me.how_to_play_info_lbl.Name = "how_to_play_info_lbl"
        Me.how_to_play_info_lbl.Size = New System.Drawing.Size(223, 208)
        Me.how_to_play_info_lbl.TabIndex = 0
        Me.how_to_play_info_lbl.Text = resources.GetString("how_to_play_info_lbl.Text")
        '
        'exit_how_to_play_btn
        '
        Me.exit_how_to_play_btn.Location = New System.Drawing.Point(76, 231)
        Me.exit_how_to_play_btn.Name = "exit_how_to_play_btn"
        Me.exit_how_to_play_btn.Size = New System.Drawing.Size(110, 37)
        Me.exit_how_to_play_btn.TabIndex = 1
        Me.exit_how_to_play_btn.Text = "Close"
        Me.exit_how_to_play_btn.UseVisualStyleBackColor = True
        '
        'how_to_play_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 280)
        Me.Controls.Add(Me.exit_how_to_play_btn)
        Me.Controls.Add(Me.how_to_play_info_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "how_to_play_form"
        Me.Text = "How To Play - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents how_to_play_info_lbl As System.Windows.Forms.Label
    Friend WithEvents exit_how_to_play_btn As System.Windows.Forms.Button
End Class
