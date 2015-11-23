Public Class FrmAmerica12

    Private Sub FrmAmerica12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica11.Hide()
        Dim FrmAmerica13 As New Form
        lblSpeech.Text = "Sergeant Calomeni:  Good job boys, but we still have five miles to go before we meet up with the 82nd Airborne at St. Mère-Eglise.  It'll be a tough fight."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica13.Show()
    End Sub
End Class