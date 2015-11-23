Public Class FrmAmerica5

    Private Sub FrmAmerica5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica4.Hide()
        Dim frmAmerica6 As New Form
        lblSpeech.Text = "Sergeant Calomeni:  This it!  Everybody off the landing craft!  Lets go!  We've got to fight our way to St. Mère-Eglise where we'll meet up with the 82nd Airborne Division."

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        My.Computer.Audio.Play(My.Resources.Form_5_Off_the_boat, AudioPlayMode.WaitToComplete)
        FrmAmerica6.Show()
    End Sub
End Class