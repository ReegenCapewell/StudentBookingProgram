<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoiceForUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxStudentNameInv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxSubjectInv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxLessonsInv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxHoursInv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBoxCostInv = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(801, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Below you will find all the details of your purchase. Just copy these or take a p" & _
    "icture of this screen as evidence of your purchase and your confirmation of less" & _
    "ons with us!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Name"
        '
        'txtBoxStudentNameInv
        '
        Me.txtBoxStudentNameInv.Location = New System.Drawing.Point(94, 46)
        Me.txtBoxStudentNameInv.Name = "txtBoxStudentNameInv"
        Me.txtBoxStudentNameInv.ReadOnly = True
        Me.txtBoxStudentNameInv.Size = New System.Drawing.Size(149, 20)
        Me.txtBoxStudentNameInv.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Subject(s)"
        '
        'txtBoxSubjectInv
        '
        Me.txtBoxSubjectInv.Location = New System.Drawing.Point(94, 77)
        Me.txtBoxSubjectInv.Name = "txtBoxSubjectInv"
        Me.txtBoxSubjectInv.ReadOnly = True
        Me.txtBoxSubjectInv.Size = New System.Drawing.Size(149, 20)
        Me.txtBoxSubjectInv.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Number of lessons"
        '
        'txtBoxLessonsInv
        '
        Me.txtBoxLessonsInv.Location = New System.Drawing.Point(360, 46)
        Me.txtBoxLessonsInv.Name = "txtBoxLessonsInv"
        Me.txtBoxLessonsInv.ReadOnly = True
        Me.txtBoxLessonsInv.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxLessonsInv.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Length of lessons"
        '
        'txtBoxHoursInv
        '
        Me.txtBoxHoursInv.Location = New System.Drawing.Point(360, 77)
        Me.txtBoxHoursInv.Name = "txtBoxHoursInv"
        Me.txtBoxHoursInv.ReadOnly = True
        Me.txtBoxHoursInv.Size = New System.Drawing.Size(124, 20)
        Me.txtBoxHoursInv.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(540, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Cost"
        '
        'txtBoxCostInv
        '
        Me.txtBoxCostInv.Location = New System.Drawing.Point(601, 59)
        Me.txtBoxCostInv.Name = "txtBoxCostInv"
        Me.txtBoxCostInv.ReadOnly = True
        Me.txtBoxCostInv.Size = New System.Drawing.Size(205, 20)
        Me.txtBoxCostInv.TabIndex = 10
        '
        'invoiceForUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 122)
        Me.Controls.Add(Me.txtBoxCostInv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBoxHoursInv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBoxLessonsInv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBoxSubjectInv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBoxStudentNameInv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "invoiceForUser"
        Me.Text = "invoiceForUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxStudentNameInv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBoxSubjectInv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBoxLessonsInv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBoxHoursInv As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCostInv As System.Windows.Forms.TextBox
End Class
