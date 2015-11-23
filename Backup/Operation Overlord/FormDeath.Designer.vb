<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeath
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
        Me.btn1Restart = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn1Restart
        '
        Me.btn1Restart.Location = New System.Drawing.Point(369, 345)
        Me.btn1Restart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn1Restart.Name = "btn1Restart"
        Me.btn1Restart.Size = New System.Drawing.Size(100, 28)
        Me.btn1Restart.TabIndex = 0
        Me.btn1Restart.Text = "Back"
        Me.btn1Restart.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Black
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(13, 13)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(207, 47)
        Me.lblMessage.TabIndex = 1
        '
        'FrmDeath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Operation_Overlord.My.Resources.Resources._58673378wi4
        Me.ClientSize = New System.Drawing.Size(482, 386)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btn1Restart)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmDeath"
        Me.Text = "FormDeath"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn1Restart As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
