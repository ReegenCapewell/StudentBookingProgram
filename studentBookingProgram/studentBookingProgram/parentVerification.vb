Public Class parentVerification

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtBoxStudentName.Text = "Reegen Capewell" And txtBoxPostCode.Text = "ST14 7EN" Then
            bookingForm.Show()
            txtBoxStudentName.Text = studentName
        Else
            verifyError.Show()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        helpPage.Show()
    End Sub

    Private Sub parentVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginScreen.Hide()
    End Sub
End Class