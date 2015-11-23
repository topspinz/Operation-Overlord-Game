Public Class FrmAmerica4

    Private Sub FrmAmerica4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica3.Hide()
        Dim frmAmerica5 As New Form
        lblSpeech.Text = "Sergeant Calomeni:  Strong currents have pushed us 2000 yards away from our landing target.  We'll just have to make do."
        lbl1Narrator.Text = frm1Title.sharedText & ":  " & "GO,GO,GO!"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        My.Computer.Audio.Play(My.Resources.Form_4_Go_Go_Go, AudioPlayMode.WaitToComplete)


        FrmAmerica5.Show()

    End Sub
End Class