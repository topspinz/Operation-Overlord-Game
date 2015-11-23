Public Class FrmAmerica18

    Private Sub FrmAmerica18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FrmAmerica19 As New Form
        FrmAmerica17.Hide()
        lblSpeech.Text = "Sergeant Calomeni:  That's the last of them.  WE WON!  The beach is ours! Now we march to St. Mère-Eglise."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica19.Show()
    End Sub
End Class