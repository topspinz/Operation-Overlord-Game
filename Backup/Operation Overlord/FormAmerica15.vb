Public Class FrmAmerica15

    Private Sub FrmAmerica15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FrmAmerica16 As New Form
        FrmAmerica14.Hide()
        lblSpeech.Text = "Soldeirs Celebrating:  *Cheering*"
        My.Computer.Audio.Play(My.Resources.AC130___105mm_sound_effect_, AudioPlayMode.Background)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica16.Show()
    End Sub
End Class