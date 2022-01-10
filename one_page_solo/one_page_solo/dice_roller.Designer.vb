<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dice_roller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dice_roller))
        Me.dice_roller_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dice_roller_lbl
        '
        Me.dice_roller_lbl.AutoSize = True
        Me.dice_roller_lbl.Location = New System.Drawing.Point(32, 9)
        Me.dice_roller_lbl.Name = "dice_roller_lbl"
        Me.dice_roller_lbl.Size = New System.Drawing.Size(286, 78)
        Me.dice_roller_lbl.TabIndex = 0
        Me.dice_roller_lbl.Text = resources.GetString("dice_roller_lbl.Text")
        Me.dice_roller_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dice_roller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 368)
        Me.Controls.Add(Me.dice_roller_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dice_roller"
        Me.Text = "Dice Roller - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dice_roller_lbl As System.Windows.Forms.Label
End Class
