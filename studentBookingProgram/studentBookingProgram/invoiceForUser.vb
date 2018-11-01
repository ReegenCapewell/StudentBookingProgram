Public Class invoiceForUser

    Private Sub invoiceForUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxStudentNameInv.Text = studentName
        txtBoxSubjectInv.Text = subjects
        txtBoxCostInv.Text = totalPrice
        txtBoxHoursInv.Text = noofhours
        txtBoxLessonsInv.Text = nooflessons
    End Sub
End Class