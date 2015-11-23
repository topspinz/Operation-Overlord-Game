Public Class frmAmerica2

    Private Sub frmAmerica2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica1.Hide()
        Dim frmAmerica3 As New Form
        lblHowToPlay.Text = ""
    End Sub

    Private Sub btnStartGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGame.Click
        FrmAmerica3.Show()
    End Sub

    Private Sub lblHowToPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHowToPlay.Click

    End Sub
End Class
