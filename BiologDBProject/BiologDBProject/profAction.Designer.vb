<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profAction
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
        Me.pnlButton = New System.Windows.Forms.Panel()
        Me.btnLabData = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnUniv = New System.Windows.Forms.Button()
        Me.pnlDisp = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButton
        '
        Me.pnlButton.Controls.Add(Me.btnUniv)
        Me.pnlButton.Controls.Add(Me.btnStudent)
        Me.pnlButton.Controls.Add(Me.btnLabData)
        Me.pnlButton.Location = New System.Drawing.Point(12, 12)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(200, 290)
        Me.pnlButton.TabIndex = 0
        '
        'btnLabData
        '
        Me.btnLabData.AutoSize = True
        Me.btnLabData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabData.Location = New System.Drawing.Point(4, 4)
        Me.btnLabData.Name = "btnLabData"
        Me.btnLabData.Size = New System.Drawing.Size(85, 30)
        Me.btnLabData.TabIndex = 0
        Me.btnLabData.Text = "&Lab Data"
        Me.btnLabData.UseVisualStyleBackColor = True
        '
        'btnStudent
        '
        Me.btnStudent.AutoSize = True
        Me.btnStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.Location = New System.Drawing.Point(4, 40)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(115, 30)
        Me.btnStudent.TabIndex = 1
        Me.btnStudent.Text = "&Student Data"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnUniv
        '
        Me.btnUniv.AutoSize = True
        Me.btnUniv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUniv.Location = New System.Drawing.Point(4, 76)
        Me.btnUniv.Name = "btnUniv"
        Me.btnUniv.Size = New System.Drawing.Size(126, 30)
        Me.btnUniv.TabIndex = 2
        Me.btnUniv.Text = "&University Data"
        Me.btnUniv.UseVisualStyleBackColor = True
        '
        'pnlDisp
        '
        Me.pnlDisp.AutoScroll = True
        Me.pnlDisp.Location = New System.Drawing.Point(247, 12)
        Me.pnlDisp.Name = "pnlDisp"
        Me.pnlDisp.Size = New System.Drawing.Size(567, 290)
        Me.pnlDisp.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(12, 308)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(103, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Return to Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'profAction
        '
        Me.AccessibleDescription = "The purpose of this form is to allow a professor to add, modify, and view data."
        Me.AccessibleName = "Professor View"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(826, 341)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlDisp)
        Me.Controls.Add(Me.pnlButton)
        Me.Name = "profAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biolog Lab Data - Professor"
        Me.pnlButton.ResumeLayout(False)
        Me.pnlButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlButton As Panel
    Friend WithEvents btnUniv As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnLabData As Button
    Friend WithEvents pnlDisp As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
End Class
