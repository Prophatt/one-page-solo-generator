<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class journal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(journal))
        Me.journal_txtbx = New System.Windows.Forms.TextBox()
        Me.journal_open_btn = New System.Windows.Forms.Button()
        Me.journal_save_btn = New System.Windows.Forms.Button()
        Me.journal_clear_btn = New System.Windows.Forms.Button()
        Me.journal_close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'journal_txtbx
        '
        Me.journal_txtbx.Location = New System.Drawing.Point(12, 64)
        Me.journal_txtbx.Multiline = True
        Me.journal_txtbx.Name = "journal_txtbx"
        Me.journal_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.journal_txtbx.Size = New System.Drawing.Size(595, 571)
        Me.journal_txtbx.TabIndex = 5
        '
        'journal_open_btn
        '
        Me.journal_open_btn.Location = New System.Drawing.Point(12, 12)
        Me.journal_open_btn.Name = "journal_open_btn"
        Me.journal_open_btn.Size = New System.Drawing.Size(110, 37)
        Me.journal_open_btn.TabIndex = 1
        Me.journal_open_btn.Text = "Open Saved Journal"
        Me.journal_open_btn.UseVisualStyleBackColor = True
        '
        'journal_save_btn
        '
        Me.journal_save_btn.Location = New System.Drawing.Point(128, 12)
        Me.journal_save_btn.Name = "journal_save_btn"
        Me.journal_save_btn.Size = New System.Drawing.Size(110, 37)
        Me.journal_save_btn.TabIndex = 2
        Me.journal_save_btn.Text = "Save Journal"
        Me.journal_save_btn.UseVisualStyleBackColor = True
        '
        'journal_clear_btn
        '
        Me.journal_clear_btn.Location = New System.Drawing.Point(372, 12)
        Me.journal_clear_btn.Name = "journal_clear_btn"
        Me.journal_clear_btn.Size = New System.Drawing.Size(110, 37)
        Me.journal_clear_btn.TabIndex = 3
        Me.journal_clear_btn.Text = "Clear Journal"
        Me.journal_clear_btn.UseVisualStyleBackColor = True
        '
        'journal_close_btn
        '
        Me.journal_close_btn.Location = New System.Drawing.Point(488, 12)
        Me.journal_close_btn.Name = "journal_close_btn"
        Me.journal_close_btn.Size = New System.Drawing.Size(110, 37)
        Me.journal_close_btn.TabIndex = 4
        Me.journal_close_btn.Text = "Close"
        Me.journal_close_btn.UseVisualStyleBackColor = True
        '
        'journal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 646)
        Me.Controls.Add(Me.journal_close_btn)
        Me.Controls.Add(Me.journal_clear_btn)
        Me.Controls.Add(Me.journal_save_btn)
        Me.Controls.Add(Me.journal_open_btn)
        Me.Controls.Add(Me.journal_txtbx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "journal"
        Me.Text = "Journal - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents journal_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents journal_open_btn As System.Windows.Forms.Button
    Friend WithEvents journal_save_btn As System.Windows.Forms.Button
    Friend WithEvents journal_clear_btn As System.Windows.Forms.Button
    Friend WithEvents journal_close_btn As System.Windows.Forms.Button
End Class
