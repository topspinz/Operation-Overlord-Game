Public Class FrmCelebrate

    Private Sub Frm2Celebrate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica16.Hide()
        lbl1.Text = "This is no time to party, there's a battle to be won."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica16.Show()
    End Sub
End Class