<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmerica2
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
        Me.lblHowToPlay = New System.Windows.Forms.Label
        Me.btnStartGAme = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblHowToPlay
        '
        Me.lblHowToPlay.Location = New System.Drawing.Point(13, 13)
        Me.lblHowToPlay.Name = "lblHowToPlay"
        Me.lblHowToPlay.Size = New System.Drawing.Size(100, 23)
        Me.lblHowToPlay.TabIndex = 0
        '
        'btnStartGAme
        '
        Me.btnStartGAme.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGAme.Location = New System.Drawing.Point(16, 166)
        Me.btnStartGAme.Name = "btnStartGAme"
        Me.btnStartGAme.Size = New System.Drawing.Size(381, 71)
        Me.btnStartGAme.TabIndex = 1
        Me.btnStartGAme.Text = "Commence Invasion"
        Me.btnStartGAme.UseVisualStyleBackColor = True
        '
        'frmAmerica2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 249)
        Me.Controls.Add(Me.btnStartGAme)
        Me.Controls.Add(Me.lblHowToPlay)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmAmerica2"
        Me.Text = "FormAmerica2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHowToPlay As System.Windows.Forms.Label
    Friend WithEvents btnStartGAme As System.Windows.Forms.Button
End Class
