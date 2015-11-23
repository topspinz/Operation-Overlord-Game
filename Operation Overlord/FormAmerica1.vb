Public Class FrmAmerica1

    Private Sub FrmAmerica1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Choose_Army.Hide()
        Dim frmAmerica2 As New Form
        lblInfo.Text = "Welcome private " & frm1Title.sharedText & " to the US 4th Infantry Division.  " & "Private " & frm1Title.sharedText & " you will be part of the largest amphibious operation in history.  " & "At 6:30 am on June 6th, 1944 the Normandy amphibious landings, known as Operation Overlord, will commence.  " & "There are five invasion beaches:  Sword, Juno, Gold, Omaha and Utah (from East to West).  " & "Your division will land on Utah Beach.  " & "The 82nd and 101st Airborne Divisions will parachuete in during the night and create chaos, making your landing easier.  " & "Good luck soldier!"

    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        frmAmerica2.Show()
    End Sub

    Private Sub lblInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInfo.Click

    End Sub
End Class
