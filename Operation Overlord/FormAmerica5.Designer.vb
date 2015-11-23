<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmerica5
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
        Me.btn1 = New System.Windows.Forms.Button
        Me.lbl1Narrator = New System.Windows.Forms.Label
        Me.lblSpeech = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(1135, 551)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 28)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Continue"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lbl1Narrator
        '
        Me.lbl1Narrator.AutoSize = True
        Me.lbl1Narrator.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1Narrator.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Narrator.ForeColor = System.Drawing.Color.Red
        Me.lbl1Narrator.Location = New System.Drawing.Point(471, 495)
        Me.lbl1Narrator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1Narrator.Name = "lbl1Narrator"
        Me.lbl1Narrator.Size = New System.Drawing.Size(0, 24)
        Me.lbl1Narrator.TabIndex = 4
        '
        'lblSpeech
        '
        Me.lblSpeech.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSpeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeech.ForeColor = System.Drawing.Color.Red
        Me.lblSpeech.Location = New System.Drawing.Point(16, 11)
        Me.lblSpeech.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpeech.Name = "lblSpeech"
        Me.lblSpeech.Size = New System.Drawing.Size(1164, 57)
        Me.lblSpeech.TabIndex = 5
        '
        'FrmAmerica5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Operation_Overlord.My.Resources.Resources.relic00004
        Me.ClientSize = New System.Drawing.Size(1271, 613)
        Me.Controls.Add(Me.lblSpeech)
        Me.Controls.Add(Me.lbl1Narrator)
        Me.Controls.Add(Me.btn1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAmerica5"
        Me.Text = "FormAmerica5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lbl1Narrator As System.Windows.Forms.Label
    Friend WithEvents lblSpeech As System.Windows.Forms.Label
End Class
