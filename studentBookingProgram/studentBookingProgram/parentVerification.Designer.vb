<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parentVerification
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
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.txtBoxStudentName = New System.Windows.Forms.TextBox()
        Me.txtBoxPostCode = New System.Windows.Forms.TextBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(13, 26)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(75, 13)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "Student Name"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(13, 65)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(64, 13)
        Me.lblPostCode.TabIndex = 1
        Me.lblPostCode.Text = "Postal Code"
        '
        'txtBoxStudentName
        '
        Me.txtBoxStudentName.Location = New System.Drawing.Point(94, 23)
        Me.txtBoxStudentName.Name = "txtBoxStudentName"
        Me.txtBoxStudentName.Size = New System.Drawing.Size(299, 20)
        Me.txtBoxStudentName.TabIndex = 2
        '
        'txtBoxPostCode
        '
        Me.txtBoxPostCode.Location = New System.Drawing.Point(94, 62)
        Me.txtBoxPostCode.Name = "txtBoxPostCode"
        Me.txtBoxPostCode.Size = New System.Drawing.Size(299, 20)
        Me.txtBoxPostCode.TabIndex = 3
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(94, 109)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 4
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(212, 109)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 23)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'parentVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 156)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.txtBoxPostCode)
        Me.Controls.Add(Me.txtBoxStudentName)
        Me.Controls.Add(Me.lblPostCode)
        Me.Controls.Add(Me.lblStudentName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(421, 194)
        Me.MinimumSize = New System.Drawing.Size(421, 194)
        Me.Name = "parentVerification"
        Me.Text = "Parent Verification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents lblPostCode As System.Windows.Forms.Label
    Friend WithEvents txtBoxStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxPostCode As System.Windows.Forms.TextBox
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
