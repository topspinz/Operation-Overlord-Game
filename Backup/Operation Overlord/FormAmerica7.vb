Public Class FrmAmerica7

    Private Sub FrmAmerica7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica6.Hide()
        Dim FrmAmerica8, FrmDeath2, FrmCowardice As New Form
        lblSpeech.Text = "Sergeant Calomeni:  We've got to get to the beach, now!"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica8.Show()
        FrmCowardice.Hide()
        FrmDeath2.Hide()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        FrmDeath2.Show()
    End Sub

    Private Sub Button3btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3btn3.Click
        FrmCowardice.Show()
    End Sub
End Class