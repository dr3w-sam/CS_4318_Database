<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUser
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
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.cbbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblStudPass = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtStudFName = New System.Windows.Forms.TextBox()
        Me.txtStudLName = New System.Windows.Forms.TextBox()
        Me.txtStudEmail = New System.Windows.Forms.TextBox()
        Me.txtStudNewPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(12, 9)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(79, 16)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "First Name: "
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(12, 51)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(79, 16)
        Me.lblLName.TabIndex = 1
        Me.lblLName.Text = "Last Name: "
        '
        'cbbGradeLevel
        '
        Me.cbbGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbGradeLevel.FormattingEnabled = True
        Me.cbbGradeLevel.Items.AddRange(New Object() {"Freshman", "Sophomore", "Junior", "Senior"})
        Me.cbbGradeLevel.Location = New System.Drawing.Point(209, 82)
        Me.cbbGradeLevel.Name = "cbbGradeLevel"
        Me.cbbGradeLevel.Size = New System.Drawing.Size(121, 24)
        Me.cbbGradeLevel.TabIndex = 2
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.Location = New System.Drawing.Point(12, 90)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(88, 16)
        Me.lblGradeLevel.TabIndex = 3
        Me.lblGradeLevel.Text = "Grade Level: "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(12, 205)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 16)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email: "
        '
        'lblStudPass
        '
        Me.lblStudPass.AutoSize = True
        Me.lblStudPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudPass.Location = New System.Drawing.Point(12, 155)
        Me.lblStudPass.Name = "lblStudPass"
        Me.lblStudPass.Size = New System.Drawing.Size(74, 16)
        Me.lblStudPass.TabIndex = 5
        Me.lblStudPass.Text = "Password: "
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(117, 275)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(209, 275)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtStudFName
        '
        Me.txtStudFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudFName.Location = New System.Drawing.Point(209, 9)
        Me.txtStudFName.Name = "txtStudFName"
        Me.txtStudFName.Size = New System.Drawing.Size(100, 22)
        Me.txtStudFName.TabIndex = 8
        '
        'txtStudLName
        '
        Me.txtStudLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudLName.Location = New System.Drawing.Point(209, 45)
        Me.txtStudLName.Name = "txtStudLName"
        Me.txtStudLName.Size = New System.Drawing.Size(100, 22)
        Me.txtStudLName.TabIndex = 9
        '
        'txtStudEmail
        '
        Me.txtStudEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudEmail.Location = New System.Drawing.Point(209, 199)
        Me.txtStudEmail.Name = "txtStudEmail"
        Me.txtStudEmail.Size = New System.Drawing.Size(165, 22)
        Me.txtStudEmail.TabIndex = 10
        '
        'txtStudNewPass
        '
        Me.txtStudNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudNewPass.Location = New System.Drawing.Point(209, 149)
        Me.txtStudNewPass.Name = "txtStudNewPass"
        Me.txtStudNewPass.Size = New System.Drawing.Size(100, 22)
        Me.txtStudNewPass.TabIndex = 11
        '
        'newUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(402, 320)
        Me.Controls.Add(Me.txtStudNewPass)
        Me.Controls.Add(Me.txtStudEmail)
        Me.Controls.Add(Me.txtStudLName)
        Me.Controls.Add(Me.txtStudFName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStudPass)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblGradeLevel)
        Me.Controls.Add(Me.cbbGradeLevel)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Name = "newUser"
        Me.Text = "Create New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents cbbGradeLevel As ComboBox
    Friend WithEvents lblGradeLevel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblStudPass As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtStudFName As TextBox
    Friend WithEvents txtStudLName As TextBox
    Friend WithEvents txtStudEmail As TextBox
    Friend WithEvents txtStudNewPass As TextBox
End Class
