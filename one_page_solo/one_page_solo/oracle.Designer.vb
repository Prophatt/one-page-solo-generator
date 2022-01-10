<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class oracle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(oracle))
        Me.oracle_how_to_lbl = New System.Windows.Forms.Label()
        Me.oracle_question_txtbx = New System.Windows.Forms.TextBox()
        Me.oracle_your_question_lbl = New System.Windows.Forms.Label()
        Me.oracle_likely_radio = New System.Windows.Forms.RadioButton()
        Me.oracle_normal_radio = New System.Windows.Forms.RadioButton()
        Me.oracle_unlikely_radio = New System.Windows.Forms.RadioButton()
        Me.oracle_answer_lbl = New System.Windows.Forms.Label()
        Me.oracle_answer_txtbx = New System.Windows.Forms.TextBox()
        Me.ask_the_oracle_btn = New System.Windows.Forms.Button()
        Me.oracle_to_journal = New System.Windows.Forms.Button()
        Me.oracle_close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'oracle_how_to_lbl
        '
        Me.oracle_how_to_lbl.AutoSize = True
        Me.oracle_how_to_lbl.Location = New System.Drawing.Point(49, 9)
        Me.oracle_how_to_lbl.Name = "oracle_how_to_lbl"
        Me.oracle_how_to_lbl.Size = New System.Drawing.Size(207, 91)
        Me.oracle_how_to_lbl.TabIndex = 0
        Me.oracle_how_to_lbl.Text = resources.GetString("oracle_how_to_lbl.Text")
        Me.oracle_how_to_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'oracle_question_txtbx
        '
        Me.oracle_question_txtbx.Location = New System.Drawing.Point(12, 128)
        Me.oracle_question_txtbx.Multiline = True
        Me.oracle_question_txtbx.Name = "oracle_question_txtbx"
        Me.oracle_question_txtbx.Size = New System.Drawing.Size(279, 85)
        Me.oracle_question_txtbx.TabIndex = 1
        '
        'oracle_your_question_lbl
        '
        Me.oracle_your_question_lbl.AutoSize = True
        Me.oracle_your_question_lbl.Location = New System.Drawing.Point(9, 112)
        Me.oracle_your_question_lbl.Name = "oracle_your_question_lbl"
        Me.oracle_your_question_lbl.Size = New System.Drawing.Size(140, 13)
        Me.oracle_your_question_lbl.TabIndex = 2
        Me.oracle_your_question_lbl.Text = "Your question for the oracle,"
        '
        'oracle_likely_radio
        '
        Me.oracle_likely_radio.AutoSize = True
        Me.oracle_likely_radio.Location = New System.Drawing.Point(63, 219)
        Me.oracle_likely_radio.Name = "oracle_likely_radio"
        Me.oracle_likely_radio.Size = New System.Drawing.Size(52, 17)
        Me.oracle_likely_radio.TabIndex = 2
        Me.oracle_likely_radio.TabStop = True
        Me.oracle_likely_radio.Text = "Likely"
        Me.oracle_likely_radio.UseVisualStyleBackColor = True
        '
        'oracle_normal_radio
        '
        Me.oracle_normal_radio.AutoSize = True
        Me.oracle_normal_radio.Location = New System.Drawing.Point(121, 219)
        Me.oracle_normal_radio.Name = "oracle_normal_radio"
        Me.oracle_normal_radio.Size = New System.Drawing.Size(58, 17)
        Me.oracle_normal_radio.TabIndex = 3
        Me.oracle_normal_radio.TabStop = True
        Me.oracle_normal_radio.Text = "Normal"
        Me.oracle_normal_radio.UseVisualStyleBackColor = True
        '
        'oracle_unlikely_radio
        '
        Me.oracle_unlikely_radio.AutoSize = True
        Me.oracle_unlikely_radio.Location = New System.Drawing.Point(185, 219)
        Me.oracle_unlikely_radio.Name = "oracle_unlikely_radio"
        Me.oracle_unlikely_radio.Size = New System.Drawing.Size(62, 17)
        Me.oracle_unlikely_radio.TabIndex = 4
        Me.oracle_unlikely_radio.TabStop = True
        Me.oracle_unlikely_radio.Text = "Unlikely"
        Me.oracle_unlikely_radio.UseVisualStyleBackColor = True
        '
        'oracle_answer_lbl
        '
        Me.oracle_answer_lbl.AutoSize = True
        Me.oracle_answer_lbl.Location = New System.Drawing.Point(12, 288)
        Me.oracle_answer_lbl.Name = "oracle_answer_lbl"
        Me.oracle_answer_lbl.Size = New System.Drawing.Size(113, 13)
        Me.oracle_answer_lbl.TabIndex = 6
        Me.oracle_answer_lbl.Text = "The Oracles Answer is"
        '
        'oracle_answer_txtbx
        '
        Me.oracle_answer_txtbx.Location = New System.Drawing.Point(15, 304)
        Me.oracle_answer_txtbx.Name = "oracle_answer_txtbx"
        Me.oracle_answer_txtbx.Size = New System.Drawing.Size(186, 20)
        Me.oracle_answer_txtbx.TabIndex = 6
        '
        'ask_the_oracle_btn
        '
        Me.ask_the_oracle_btn.Location = New System.Drawing.Point(91, 242)
        Me.ask_the_oracle_btn.Name = "ask_the_oracle_btn"
        Me.ask_the_oracle_btn.Size = New System.Drawing.Size(110, 37)
        Me.ask_the_oracle_btn.TabIndex = 5
        Me.ask_the_oracle_btn.Text = "Ask The Oracle"
        Me.ask_the_oracle_btn.UseVisualStyleBackColor = True
        '
        'oracle_to_journal
        '
        Me.oracle_to_journal.Location = New System.Drawing.Point(30, 342)
        Me.oracle_to_journal.Name = "oracle_to_journal"
        Me.oracle_to_journal.Size = New System.Drawing.Size(110, 37)
        Me.oracle_to_journal.TabIndex = 7
        Me.oracle_to_journal.Text = "Send To Journal"
        Me.oracle_to_journal.UseVisualStyleBackColor = True
        '
        'oracle_close_btn
        '
        Me.oracle_close_btn.Location = New System.Drawing.Point(161, 342)
        Me.oracle_close_btn.Name = "oracle_close_btn"
        Me.oracle_close_btn.Size = New System.Drawing.Size(110, 37)
        Me.oracle_close_btn.TabIndex = 8
        Me.oracle_close_btn.Text = "Close"
        Me.oracle_close_btn.UseVisualStyleBackColor = True
        '
        'oracle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 398)
        Me.Controls.Add(Me.oracle_close_btn)
        Me.Controls.Add(Me.oracle_to_journal)
        Me.Controls.Add(Me.ask_the_oracle_btn)
        Me.Controls.Add(Me.oracle_answer_txtbx)
        Me.Controls.Add(Me.oracle_answer_lbl)
        Me.Controls.Add(Me.oracle_unlikely_radio)
        Me.Controls.Add(Me.oracle_normal_radio)
        Me.Controls.Add(Me.oracle_likely_radio)
        Me.Controls.Add(Me.oracle_your_question_lbl)
        Me.Controls.Add(Me.oracle_question_txtbx)
        Me.Controls.Add(Me.oracle_how_to_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "oracle"
        Me.Text = "Oracle -  One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents oracle_how_to_lbl As System.Windows.Forms.Label
    Friend WithEvents oracle_question_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents oracle_your_question_lbl As System.Windows.Forms.Label
    Friend WithEvents oracle_likely_radio As System.Windows.Forms.RadioButton
    Friend WithEvents oracle_normal_radio As System.Windows.Forms.RadioButton
    Friend WithEvents oracle_unlikely_radio As System.Windows.Forms.RadioButton
    Friend WithEvents oracle_answer_lbl As System.Windows.Forms.Label
    Friend WithEvents oracle_answer_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents ask_the_oracle_btn As System.Windows.Forms.Button
    Friend WithEvents oracle_to_journal As System.Windows.Forms.Button
    Friend WithEvents oracle_close_btn As System.Windows.Forms.Button
End Class
