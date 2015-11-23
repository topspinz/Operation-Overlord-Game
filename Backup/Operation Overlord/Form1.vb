Public Class frm1Title
    'Programmed by: Matthew Levstek, Paul Capparelli, Jakub Janek
    'Programmed for: Mr. Calomeni 
    'Date: December 10th,2010
    'description: The program is an educational game were the user is reliving the invasion of Normandy by choosing different options 



    Dim name2 As String 'Declares your name as a string
    Public sharedText As String



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1Confirm.Click
        name2 = (TextBox1.Text) 'When one types their name and clicks confirm the name is accepted
        Dim form2 As New Choose_Army
        Choose_Army.Show()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        sharedText = TextBox1.Text

    End Sub

    Private Sub frm1Title_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmDeath.Hide()
    End Sub
End Class
