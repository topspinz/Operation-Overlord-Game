Public Class FrmAmerica17

    Private Sub FrmAmerica17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica16.Hide()
        Dim FrmAmerica18 As New Form
        My.Computer.Audio.Play(My.Resources.Martin_Marauder_in_Action1, AudioPlayMode.Background)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica18.Show()
    End Sub
End Class