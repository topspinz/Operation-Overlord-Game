Public Class FrmCowardice

    Private Sub FrmCowardice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica7.Hide()
        lbl1.Text = "Cowardice will not be tolerated."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica7.Show()
    End Sub
End Class