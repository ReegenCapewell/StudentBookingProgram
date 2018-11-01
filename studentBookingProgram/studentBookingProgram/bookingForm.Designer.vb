<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSubjects = New System.Windows.Forms.Label()
        Me.lblLessonNumber = New System.Windows.Forms.Label()
        Me.txtBoxLessons = New System.Windows.Forms.TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtBoxHours = New System.Windows.Forms.TextBox()
        Me.lblNoVAT = New System.Windows.Forms.Label()
        Me.txtBoxNoVAT = New System.Windows.Forms.TextBox()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.txtBoxVAT = New System.Windows.Forms.TextBox()
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.btnPayLater = New System.Windows.Forms.Button()
        Me.comBoxSubjects = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'lblSubjects
        '
        Me.lblSubjects.AutoSize = True
        Me.lblSubjects.Location = New System.Drawing.Point(13, 13)
        Me.lblSubjects.Name = "lblSubjects"
        Me.lblSubjects.Size = New System.Drawing.Size(54, 13)
        Me.lblSubjects.TabIndex = 0
        Me.lblSubjects.Text = "Subject(s)"
        '
        'lblLessonNumber
        '
        Me.lblLessonNumber.AutoSize = True
        Me.lblLessonNumber.Location = New System.Drawing.Point(13, 54)
        Me.lblLessonNumber.Name = "lblLessonNumber"
        Me.lblLessonNumber.Size = New System.Drawing.Size(98, 13)
        Me.lblLessonNumber.TabIndex = 2
        Me.lblLessonNumber.Text = "Number of Lessons"
        '
        'txtBoxLessons
        '
        Me.txtBoxLessons.Location = New System.Drawing.Point(117, 51)
        Me.txtBoxLessons.Name = "txtBoxLessons"
        Me.txtBoxLessons.Size = New System.Drawing.Size(155, 20)
        Me.txtBoxLessons.TabIndex = 3
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(13, 95)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(127, 13)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "Length of session (Hours)"
        '
        'txtBoxHours
        '
        Me.txtBoxHours.Location = New System.Drawing.Point(146, 92)
        Me.txtBoxHours.Name = "txtBoxHours"
        Me.txtBoxHours.Size = New System.Drawing.Size(126, 20)
        Me.txtBoxHours.TabIndex = 5
        '
        'lblNoVAT
        '
        Me.lblNoVAT.AutoSize = True
        Me.lblNoVAT.Location = New System.Drawing.Point(13, 136)
        Me.lblNoVAT.Name = "lblNoVAT"
        Me.lblNoVAT.Size = New System.Drawing.Size(92, 13)
        Me.lblNoVAT.TabIndex = 6
        Me.lblNoVAT.Text = "Price without VAT"
        '
        'txtBoxNoVAT
        '
        Me.txtBoxNoVAT.Location = New System.Drawing.Point(111, 133)
        Me.txtBoxNoVAT.Name = "txtBoxNoVAT"
        Me.txtBoxNoVAT.ReadOnly = True
        Me.txtBoxNoVAT.Size = New System.Drawing.Size(161, 20)
        Me.txtBoxNoVAT.TabIndex = 7
        '
        'lblVAT
        '
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Location = New System.Drawing.Point(13, 166)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(77, 13)
        Me.lblVAT.TabIndex = 8
        Me.lblVAT.Text = "Price with VAT"
        '
        'txtBoxVAT
        '
        Me.txtBoxVAT.Location = New System.Drawing.Point(111, 163)
        Me.txtBoxVAT.Name = "txtBoxVAT"
        Me.txtBoxVAT.ReadOnly = True
        Me.txtBoxVAT.Size = New System.Drawing.Size(161, 20)
        Me.txtBoxVAT.TabIndex = 9
        '
        'btnPayNow
        '
        Me.btnPayNow.Location = New System.Drawing.Point(13, 227)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(75, 23)
        Me.btnPayNow.TabIndex = 10
        Me.btnPayNow.Text = "Pay Now"
        Me.btnPayNow.UseVisualStyleBackColor = True
        '
        'btnPayLater
        '
        Me.btnPayLater.Location = New System.Drawing.Point(197, 227)
        Me.btnPayLater.Name = "btnPayLater"
        Me.btnPayLater.Size = New System.Drawing.Size(75, 23)
        Me.btnPayLater.TabIndex = 11
        Me.btnPayLater.Text = "Pay Later"
        Me.btnPayLater.UseVisualStyleBackColor = True
        '
        'comBoxSubjects
        '
        Me.comBoxSubjects.FormattingEnabled = True
        Me.comBoxSubjects.Items.AddRange(New Object() {"Maths", "English", "Maths and English"})
        Me.comBoxSubjects.Location = New System.Drawing.Point(73, 10)
        Me.comBoxSubjects.Name = "comBoxSubjects"
        Me.comBoxSubjects.Size = New System.Drawing.Size(199, 21)
        Me.comBoxSubjects.TabIndex = 12
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(94, 227)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(97, 23)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'bookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.comBoxSubjects)
        Me.Controls.Add(Me.btnPayLater)
        Me.Controls.Add(Me.btnPayNow)
        Me.Controls.Add(Me.txtBoxVAT)
        Me.Controls.Add(Me.lblVAT)
        Me.Controls.Add(Me.txtBoxNoVAT)
        Me.Controls.Add(Me.lblNoVAT)
        Me.Controls.Add(Me.txtBoxHours)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.txtBoxLessons)
        Me.Controls.Add(Me.lblLessonNumber)
        Me.Controls.Add(Me.lblSubjects)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "bookingForm"
        Me.Text = "Booking Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubjects As System.Windows.Forms.Label
    Friend WithEvents lblLessonNumber As System.Windows.Forms.Label
    Friend WithEvents txtBoxLessons As System.Windows.Forms.TextBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents txtBoxHours As System.Windows.Forms.TextBox
    Friend WithEvents lblNoVAT As System.Windows.Forms.Label
    Friend WithEvents txtBoxNoVAT As System.Windows.Forms.TextBox
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents txtBoxVAT As System.Windows.Forms.TextBox
    Friend WithEvents btnPayNow As System.Windows.Forms.Button
    Friend WithEvents btnPayLater As System.Windows.Forms.Button
    Friend WithEvents comBoxSubjects As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
