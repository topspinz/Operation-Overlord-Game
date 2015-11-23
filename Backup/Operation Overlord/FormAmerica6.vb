Public Class FrmAmerica6

    Private Sub FrmAmerica6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica5.Hide()
        Dim FrmAmerica7 As New Form
        Dim FrmDeath As New Form
        lblSpeech.Text = "Sergeant Calomeni:  We've got to get to cover before the Krauts in the bunkers tear us to shreds!"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica7.Show()
        FrmDeath.Hide()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        FrmDeath.Show()
    End Sub
End Class