<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmerica3
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
        Me.components = New System.ComponentModel.Container
        Me.lblSpeech = New System.Windows.Forms.Label
        Me.btn1Continue = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl1Narrator = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblSpeech
        '
        Me.lblSpeech.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSpeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeech.ForeColor = System.Drawing.Color.Red
        Me.lblSpeech.Location = New System.Drawing.Point(17, 16)
        Me.lblSpeech.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpeech.Name = "lblSpeech"
        Me.lblSpeech.Size = New System.Drawing.Size(1230, 57)
        Me.lblSpeech.TabIndex = 0
        '
        'btn1Continue
        '
        Me.btn1Continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1Continue.Location = New System.Drawing.Point(1147, 549)
        Me.btn1Continue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn1Continue.Name = "btn1Continue"
        Me.btn1Continue.Size = New System.Drawing.Size(100, 28)
        Me.btn1Continue.TabIndex = 1
        Me.btn1Continue.Text = "Continue"
        Me.btn1Continue.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbl1Narrator
        '
        Me.lbl1Narrator.AutoSize = True
        Me.lbl1Narrator.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1Narrator.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1Narrator.ForeColor = System.Drawing.Color.Red
        Me.lbl1Narrator.Location = New System.Drawing.Point(523, 464)
        Me.lbl1Narrator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1Narrator.Name = "lbl1Narrator"
        Me.lbl1Narrator.Size = New System.Drawing.Size(0, 24)
        Me.lbl1Narrator.TabIndex = 2
        '
        'FrmAmerica3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Operation_Overlord.My.Resources.Resources.relic000001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1261, 597)
        Me.Controls.Add(Me.lbl1Narrator)
        Me.Controls.Add(Me.btn1Continue)
        Me.Controls.Add(Me.lblSpeech)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAmerica3"
        Me.Text = "FormAmerica3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpeech As System.Windows.Forms.Label
    Friend WithEvents btn1Continue As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl1Narrator As System.Windows.Forms.Label
End Class
