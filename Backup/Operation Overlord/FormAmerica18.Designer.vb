<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmerica18
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
        Me.lblSpeech = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(502, 435)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Continue"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lblSpeech
        '
        Me.lblSpeech.AutoSize = True
        Me.lblSpeech.BackColor = System.Drawing.Color.Black
        Me.lblSpeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpeech.Location = New System.Drawing.Point(12, 9)
        Me.lblSpeech.Name = "lblSpeech"
        Me.lblSpeech.Size = New System.Drawing.Size(0, 18)
        Me.lblSpeech.TabIndex = 1
        '
        'FrmAmerica18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Operation_Overlord.My.Resources.Resources.relic00182
        Me.ClientSize = New System.Drawing.Size(589, 470)
        Me.Controls.Add(Me.lblSpeech)
        Me.Controls.Add(Me.btn1)
        Me.Name = "FrmAmerica18"
        Me.Text = "FormAmerica18"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lblSpeech As System.Windows.Forms.Label
End Class
