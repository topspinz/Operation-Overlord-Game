Public Class FrmAmerica13

    Private Sub FrmAmerica13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica12.Hide()
        Dim FrmAmerica14, FrmDeath5 As New Form
        lblSpeech.Text = "Sergeant Calomeni:  Private " & frm1Title.sharedText & " plant some explosives on that bunker."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica14.Show()
        FrmDeath5.Hide()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        FrmDeath5.Show()
    End Sub
End Class