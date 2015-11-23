Public Class FrmAmerica16

    Private Sub FrmAmerica16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica15.Hide()
        Dim FrmAmerica17, FrmDeath6, FrmCelebrate As New Form
        My.Computer.Audio.Play(My.Resources.Firing_the_88mm_flak_gun_1, AudioPlayMode.Background)
        lblSpeech.Text = "Sergeant Calomeni:  If we destroy those 88mm Flak guns we'll have captured the beach.  Private " & frm1Title.sharedText & " radio B-26 Marauder medium bombers of the US 9th Air Force and have them take out those 88's."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica17.Show()
        FrmCelebrate.Hide()
        FrmDeath6.Hide()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        FrmDeath6.Show()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        FrmCelebrate.Show()
    End Sub
End Class