<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeath5
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
        Me.lbl1 = New System.Windows.Forms.Label
        Me.btn1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Black
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(13, 13)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 18)
        Me.lbl1.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(476, 362)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Back"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'FrmDeath5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Operation_Overlord.My.Resources.Resources.casualties1
        Me.ClientSize = New System.Drawing.Size(564, 435)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "FrmDeath5"
        Me.Text = "FormDeath5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
End Class
