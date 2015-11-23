Public Class FrmDeath5

    Private Sub FrmDeath5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica13.Hide()
        lbl1.Text = "You were one of 200 casualties on Utah beach."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica13.Show()
    End Sub
End Class