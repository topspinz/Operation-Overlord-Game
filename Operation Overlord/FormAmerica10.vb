Public Class FrmAmerica10

    Private Sub FrmAmerica10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FrmAmerica11 As New Form
        FrmAmerica9.Hide()
        My.Computer.Audio.Play(My.Resources.Artillery, AudioPlayMode.Background)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica11.Show()
    End Sub
End Class