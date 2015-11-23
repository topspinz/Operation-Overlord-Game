Public Class FrmAmerica8

    Private Sub FrmAmerica8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmAmerica7.Hide()
        Dim FrmAmerice9, FrmDeath3, FrmDeath4 As New Form
        lblSpeech.Text = "Sergeant Calomeni:  Private " & frm1Title.sharedText & " , destroy that bunker by radioing the USS Nevada and telling them to use their BL 14 inch Mk VII naval gun on that bunker."
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        FrmAmerica9.Show()
        FrmDeath3.Hide()
        FrmDeath4.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmDeath3.Show()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        FrmDeath4.Show()
    End Sub
End Class