Public Class FrmAmerica19

    Private Sub FrmAmerica19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FrmAmerica20 As New Form
        FrmAmerica18.Hide()
        My.Computer.Audio.Play(My.Resources.Naval_Bombardment_of_Iwo_Jima, AudioPlayMode.Background)
        lbl1.Text = "Congratulations Private " & frm1Title.sharedText & " , you helped the 4th Infantry Division capture Utah Beach!"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        My.Computer.Audio.Stop()
    End Sub
End Class