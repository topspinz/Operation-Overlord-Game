Public Class FrmDeath

    Private Sub FrmDeath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica6.Hide()
        lblMessage.Text = "You were one of 200 casualties on Utah beach."
    End Sub

    Private Sub btn1Restart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1Restart.Click
        FrmAmerica6.Show()

    End Sub

    Private Sub lblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMessage.Click

    End Sub
End Class