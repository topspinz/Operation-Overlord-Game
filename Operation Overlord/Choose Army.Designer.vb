<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose_Army
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choose_Army))
        Me.radUSA = New System.Windows.Forms.RadioButton
        Me.RadBritain = New System.Windows.Forms.RadioButton
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.lblPrompt = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'radUSA
        '
        Me.radUSA.AutoSize = True
        Me.radUSA.BackgroundImage = CType(resources.GetObject("radUSA.BackgroundImage"), System.Drawing.Image)
        Me.radUSA.Location = New System.Drawing.Point(153, 145)
        Me.radUSA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radUSA.Name = "radUSA"
        Me.radUSA.Size = New System.Drawing.Size(69, 17)
        Me.radUSA.TabIndex = 0
        Me.radUSA.TabStop = True
        Me.radUSA.Text = "American"
        Me.radUSA.UseVisualStyleBackColor = True
        '
        'RadBritain
        '
        Me.RadBritain.AutoSize = True
        Me.RadBritain.BackgroundImage = CType(resources.GetObject("RadBritain.BackgroundImage"), System.Drawing.Image)
        Me.RadBritain.Location = New System.Drawing.Point(152, 237)
        Me.RadBritain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadBritain.Name = "RadBritain"
        Me.RadBritain.Size = New System.Drawing.Size(53, 17)
        Me.RadBritain.TabIndex = 1
        Me.RadBritain.TabStop = True
        Me.RadBritain.Text = "British"
        Me.RadBritain.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(372, 296)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(56, 19)
        Me.btnConfirm.TabIndex = 3
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Agency FB", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(10, 11)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(0, 42)
        Me.lblPrompt.TabIndex = 4
        '
        'Choose_Army
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(498, 355)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.RadBritain)
        Me.Controls.Add(Me.radUSA)
        Me.Name = "Choose_Army"
        Me.Text = "Choose_Army"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radUSA As System.Windows.Forms.RadioButton
    Friend WithEvents RadBritain As System.Windows.Forms.RadioButton
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
End Class
