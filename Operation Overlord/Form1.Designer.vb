<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1Title
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1Title))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lbl1EnterName = New System.Windows.Forms.Label
        Me.btn1Confirm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(352, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'lbl1EnterName
        '
        Me.lbl1EnterName.AutoSize = True
        Me.lbl1EnterName.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1EnterName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl1EnterName.Location = New System.Drawing.Point(272, 278)
        Me.lbl1EnterName.Name = "lbl1EnterName"
        Me.lbl1EnterName.Size = New System.Drawing.Size(79, 15)
        Me.lbl1EnterName.TabIndex = 1
        Me.lbl1EnterName.Text = "Enter Name"
        '
        'btn1Confirm
        '
        Me.btn1Confirm.Location = New System.Drawing.Point(497, 471)
        Me.btn1Confirm.Name = "btn1Confirm"
        Me.btn1Confirm.Size = New System.Drawing.Size(75, 23)
        Me.btn1Confirm.TabIndex = 2
        Me.btn1Confirm.Text = "Confirm"
        Me.btn1Confirm.UseVisualStyleBackColor = True
        '
        'frm1Title
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(602, 522)
        Me.Controls.Add(Me.btn1Confirm)
        Me.Controls.Add(Me.lbl1EnterName)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frm1Title"
        Me.Text = "Concept Art Title"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1EnterName As System.Windows.Forms.Label
    Friend WithEvents btn1Confirm As System.Windows.Forms.Button

End Class
