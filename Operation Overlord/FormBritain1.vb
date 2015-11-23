Public Class FrmBritain1

    Private Sub FrmBritain1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Choose_Army.Hide()
        Dim frmBritain2 As New Form
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        FrmBritain2.Show()
    End Sub
End Class