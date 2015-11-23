<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmerica8
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
        Me.lblSpeech = New System.Windows.Forms.Label
        Me.btn1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btn3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblSpeech
        '
        Me.lblSpeech.AutoSize = True
        Me.lblSpeech.BackColor = System.Drawing.Color.Black
        Me.lblSpeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpeech.Location = New System.Drawing.Point(13, 45)
        Me.lblSpeech.Name = "lblSpeech"
        Me.lblSpeech.Size = New System.Drawing.Size(0, 18)
        Me.lblSpeech.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(457, 259)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(174, 23)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Call in Naval Bombardment"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(457, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Throw a Grenade at the Bunker"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(457, 317)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(174, 23)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "Shoot at the Bunker"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'FrmAmerica8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Operation_Overlord.My.Resources.Resources.relic00124
        Me.ClientSize = New System.Drawing.Size(1028, 752)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblSpeech)
        Me.Name = "FrmAmerica8"
        Me.Text = "FormAmerica8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpeech As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
End Class
