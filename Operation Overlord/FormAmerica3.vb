Public Class FrmAmerica3

    Private Sub FrmAmerica3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmAmerica2.Hide()
        Dim frmAmerica4 As New Form
        lblSpeech.Text = "Sergeant Calomeni:  If all goes well, this damned weather will be the worst part of our day.  We've got the 9th Air Force providing close air support and our paratroopers have already landed and are capturing stategic locations."
        lbl1Narrator.Text = frm1Title.sharedText & ":  " & "Three seconds, two, one."

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1Continue.Click

        My.Computer.Audio.Play(My.Resources.Form_3_Music_3_2_1, AudioPlayMode.WaitToComplete)
        FrmAmerica4.Show()


    End Sub

    Private Sub lblSpeech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSpeech.Click

    End Sub

    Private Sub btn2Ready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class