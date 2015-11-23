<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmerica7
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
        Me.btn2 = New System.Windows.Forms.Button
        Me.Button3btn3 = New System.Windows.Forms.Button
        Me.lblSpeech = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(441, 275)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(121, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Continue to the Beach"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(441, 304)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(121, 23)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Shoot at Bunker"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Button3btn3
        '
        Me.Button3btn3.Location = New System.Drawing.Point(441, 333)
        Me.Button3btn3.Name = "Button3btn3"
        Me.Button3btn3.Size = New System.Drawing.Size(121, 23)
        Me.Button3btn3.TabIndex = 2
        Me.Button3btn3.Text = "Retreat"
        Me.Button3btn3.UseVisualStyleBackColor = True
        '
        'lblSpeech
        '
        Me.lblSpeech.AutoSize = True
        Me.lblSpeech.BackColor = System.Drawing.Color.Black
        Me.lblSpeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpeech.Location = New System.Drawing.Point(13, 13)
        Me.lblSpeech.Name = "lblSpeech"
        Me.lblSpeech.Size = New System.Drawing.Size(0, 18)
        Me.lblSpeech.TabIndex = 3
        '
        'FrmAmerica7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Operation_Overlord.My.Resources.Resources.relic00015
        Me.ClientSize = New System.Drawing.Size(684, 518)
        Me.Controls.Add(Me.lblSpeech)
        Me.Controls.Add(Me.Button3btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "FrmAmerica7"
        Me.Text = "FormAmerica7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents Button3btn3 As System.Windows.Forms.Button
    Friend WithEvents lblSpeech As System.Windows.Forms.Label
End Class
