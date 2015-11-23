Public Class FrmAmerica11

    Private Sub FrmAmerica11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica10.Hide()
        Dim FrmAmerica12 As New Form
        My.Computer.Audio.Play(My.Resources.AC130___105mm_sound_effect_, AudioPlayMode.Background)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica12.Show()
    End Sub
End Class