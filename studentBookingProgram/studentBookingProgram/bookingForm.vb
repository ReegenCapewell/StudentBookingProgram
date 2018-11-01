Public Class bookingForm

    Private Sub bookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        parentVerification.Hide()
    End Sub

 
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        comBoxSubjects.Text = subjects
        If nooflessons >= 10 Then
            txtBoxNoVAT.Text = ((nooflessons * noofhours) * 30) * 0.9
            txtBoxVAT.Text = (((nooflessons * noofhours) * 30) / 100) * 110
            txtBoxVAT.Text = totalPrice
        Else
            txtBoxNoVAT.Text = (nooflessons * noofhours) * 30
            txtBoxVAT.Text = (((nooflessons * noofhours) * 30) / 100) * 120
            txtBoxVAT.Text = totalPrice
        End If
    End Sub

    Private Sub txtBoxLessons_TextChanged(sender As Object, e As EventArgs) Handles txtBoxLessons.TextChanged
        nooflessons = txtBoxLessons.Text
    End Sub

    Private Sub txtBoxHours_TextChanged(sender As Object, e As EventArgs) Handles txtBoxHours.TextChanged
        noofhours = txtBoxHours.Text
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        Try
            System.Diagnostics.Process.Start("https://www.paypal.com/signin?country.x=GB&locale.x=en_GB")
        Catch
        End Try
    End Sub

    Private Sub btnPayLater_Click(sender As Object, e As EventArgs) Handles btnPayLater.Click

    End Sub
End Class