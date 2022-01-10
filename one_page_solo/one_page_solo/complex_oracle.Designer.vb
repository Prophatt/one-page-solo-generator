<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class complex_oracle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(complex_oracle))
        Me.complex_question_lbl = New System.Windows.Forms.Label()
        Me.my_complex_question_lbl = New System.Windows.Forms.Label()
        Me.my_complex_question_txtbx = New System.Windows.Forms.TextBox()
        Me.ask_complex_question = New System.Windows.Forms.Button()
        Me.oracle_complex_answer = New System.Windows.Forms.Label()
        Me.oracle_complex_answer_txtbx = New System.Windows.Forms.TextBox()
        Me.complex_to_journal = New System.Windows.Forms.Button()
        Me.complexe_question_close_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'complex_question_lbl
        '
        Me.complex_question_lbl.AutoSize = True
        Me.complex_question_lbl.Location = New System.Drawing.Point(77, 9)
        Me.complex_question_lbl.Name = "complex_question_lbl"
        Me.complex_question_lbl.Size = New System.Drawing.Size(229, 91)
        Me.complex_question_lbl.TabIndex = 0
        Me.complex_question_lbl.Text = resources.GetString("complex_question_lbl.Text")
        Me.complex_question_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'my_complex_question_lbl
        '
        Me.my_complex_question_lbl.AutoSize = True
        Me.my_complex_question_lbl.Location = New System.Drawing.Point(12, 128)
        Me.my_complex_question_lbl.Name = "my_complex_question_lbl"
        Me.my_complex_question_lbl.Size = New System.Drawing.Size(185, 13)
        Me.my_complex_question_lbl.TabIndex = 1
        Me.my_complex_question_lbl.Text = "My Complex Question for the Oracle..."
        '
        'my_complex_question_txtbx
        '
        Me.my_complex_question_txtbx.Location = New System.Drawing.Point(12, 144)
        Me.my_complex_question_txtbx.Multiline = True
        Me.my_complex_question_txtbx.Name = "my_complex_question_txtbx"
        Me.my_complex_question_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.my_complex_question_txtbx.Size = New System.Drawing.Size(375, 85)
        Me.my_complex_question_txtbx.TabIndex = 1
        '
        'ask_complex_question
        '
        Me.ask_complex_question.Location = New System.Drawing.Point(142, 235)
        Me.ask_complex_question.Name = "ask_complex_question"
        Me.ask_complex_question.Size = New System.Drawing.Size(110, 37)
        Me.ask_complex_question.TabIndex = 2
        Me.ask_complex_question.Text = "Ask The Oracle"
        Me.ask_complex_question.UseVisualStyleBackColor = True
        '
        'oracle_complex_answer
        '
        Me.oracle_complex_answer.AutoSize = True
        Me.oracle_complex_answer.Location = New System.Drawing.Point(12, 289)
        Me.oracle_complex_answer.Name = "oracle_complex_answer"
        Me.oracle_complex_answer.Size = New System.Drawing.Size(316, 13)
        Me.oracle_complex_answer.TabIndex = 4
        Me.oracle_complex_answer.Text = "The Oracle Feels that these Words will Guide you to the answer..."
        '
        'oracle_complex_answer_txtbx
        '
        Me.oracle_complex_answer_txtbx.Location = New System.Drawing.Point(12, 305)
        Me.oracle_complex_answer_txtbx.Name = "oracle_complex_answer_txtbx"
        Me.oracle_complex_answer_txtbx.Size = New System.Drawing.Size(316, 20)
        Me.oracle_complex_answer_txtbx.TabIndex = 3
        '
        'complex_to_journal
        '
        Me.complex_to_journal.Location = New System.Drawing.Point(15, 344)
        Me.complex_to_journal.Name = "complex_to_journal"
        Me.complex_to_journal.Size = New System.Drawing.Size(110, 37)
        Me.complex_to_journal.TabIndex = 4
        Me.complex_to_journal.Text = "Send to Journal"
        Me.complex_to_journal.UseVisualStyleBackColor = True
        '
        'complexe_question_close_btn
        '
        Me.complexe_question_close_btn.Location = New System.Drawing.Point(277, 344)
        Me.complexe_question_close_btn.Name = "complexe_question_close_btn"
        Me.complexe_question_close_btn.Size = New System.Drawing.Size(110, 37)
        Me.complexe_question_close_btn.TabIndex = 5
        Me.complexe_question_close_btn.Text = "Close"
        Me.complexe_question_close_btn.UseVisualStyleBackColor = True
        '
        'complex_oracle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 406)
        Me.Controls.Add(Me.complexe_question_close_btn)
        Me.Controls.Add(Me.complex_to_journal)
        Me.Controls.Add(Me.oracle_complex_answer_txtbx)
        Me.Controls.Add(Me.oracle_complex_answer)
        Me.Controls.Add(Me.ask_complex_question)
        Me.Controls.Add(Me.my_complex_question_txtbx)
        Me.Controls.Add(Me.my_complex_question_lbl)
        Me.Controls.Add(Me.complex_question_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "complex_oracle"
        Me.Text = "Complex Question Oracle - One Page Solo Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents complex_question_lbl As System.Windows.Forms.Label
    Friend WithEvents my_complex_question_lbl As System.Windows.Forms.Label
    Friend WithEvents my_complex_question_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents ask_complex_question As System.Windows.Forms.Button
    Friend WithEvents oracle_complex_answer As System.Windows.Forms.Label
    Friend WithEvents oracle_complex_answer_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents complex_to_journal As System.Windows.Forms.Button
    Friend WithEvents complexe_question_close_btn As System.Windows.Forms.Button
End Class
