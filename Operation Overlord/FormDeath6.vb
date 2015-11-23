Public Class FrmDeath6

    Private Sub FrmDeath6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica16.Hide()
        lbl1.Text = "You were one of 200 casualties on Utah beach."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica16.Show()
    End Sub
End Class