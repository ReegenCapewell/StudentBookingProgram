Public Class loginScreen

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtBoxUsername.Text = "Username" And txtBoxPassword.Text = "Password" Then
            parentVerification.Show()
        Else
            LoginError.Show()
        End If
    End Sub
End Class
