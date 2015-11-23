Public Class Choose_Army

    Private Sub Choose_Army_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frm1Title.Hide()
        lblPrompt.Text = "Hello " & frm1Title.sharedText & ", please choose an army"

    End Sub

    Private Sub radUSA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUSA.CheckedChanged

    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Dim America1 As New Form
        Dim Britain1 As New Form

        If radUSA.Checked Then FrmAmerica1.Show()
        If RadBritain.Checked Then FrmBritain1.Show()


    End Sub
End Class