<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBritain1
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
        Me.lblInfo = New System.Windows.Forms.Label
        Me.btnContinue = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(10, 11)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(317, 285)
        Me.lblInfo.TabIndex = 0
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(267, 298)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(60, 19)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'FrmBritain1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 328)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblInfo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmBritain1"
        Me.Text = "FormBritain1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
