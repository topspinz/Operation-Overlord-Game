<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAmerica6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAmerica6))
        Me.btn1 = New System.Windows.Forms.Button
        Me.lblSpeech = New System.Windows.Forms.Label
        Me.btn2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(833, 472)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(153, 28)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Rush to  Cover"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lblSpeech
        '
        Me.lblSpeech.AutoSize = True
        Me.lblSpeech.BackColor = System.Drawing.Color.Black
        Me.lblSpeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeech.ForeColor = System.Drawing.Color.Red
        Me.lblSpeech.Location = New System.Drawing.Point(17, 16)
        Me.lblSpeech.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpeech.Name = "lblSpeech"
        Me.lblSpeech.Size = New System.Drawing.Size(0, 24)
        Me.lblSpeech.TabIndex = 1
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(834, 424)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(152, 28)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "Stay Put"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'FrmAmerica6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(998, 525)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lblSpeech)
        Me.Controls.Add(Me.btn1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAmerica6"
        Me.Text = "FormAmerica6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lblSpeech As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button
End Class
