<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentAction
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
        Me.components = New System.ComponentModel.Container()
        Me.btnNewData = New System.Windows.Forms.Button()
        Me.btnModifyData = New System.Windows.Forms.Button()
        Me.btnViewData = New System.Windows.Forms.Button()
        Me.btnQueryData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpNewData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpModData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpViewData = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpQuery = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnNewData
        '
        Me.btnNewData.AutoSize = True
        Me.btnNewData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewData.Location = New System.Drawing.Point(57, 66)
        Me.btnNewData.Name = "btnNewData"
        Me.btnNewData.Size = New System.Drawing.Size(120, 30)
        Me.btnNewData.TabIndex = 0
        Me.btnNewData.Text = "&New Lab Data"
        Me.ttpNewData.SetToolTip(Me.btnNewData, "Click to add a new instance of lab data")
        Me.btnNewData.UseVisualStyleBackColor = True
        '
        'btnModifyData
        '
        Me.btnModifyData.AutoSize = True
        Me.btnModifyData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyData.Location = New System.Drawing.Point(42, 128)
        Me.btnModifyData.Name = "btnModifyData"
        Me.btnModifyData.Size = New System.Drawing.Size(135, 30)
        Me.btnModifyData.TabIndex = 1
        Me.btnModifyData.Text = "&Modify Lab Data"
        Me.ttpModData.SetToolTip(Me.btnModifyData, "Click to modify data of previous lab entry")
        Me.btnModifyData.UseVisualStyleBackColor = True
        '
        'btnViewData
        '
        Me.btnViewData.AutoSize = True
        Me.btnViewData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewData.Location = New System.Drawing.Point(258, 66)
        Me.btnViewData.Name = "btnViewData"
        Me.btnViewData.Size = New System.Drawing.Size(123, 30)
        Me.btnViewData.TabIndex = 2
        Me.btnViewData.Text = "&View Lab Data"
        Me.ttpViewData.SetToolTip(Me.btnViewData, "Shows all lab data entries")
        Me.btnViewData.UseVisualStyleBackColor = True
        '
        'btnQueryData
        '
        Me.btnQueryData.AutoSize = True
        Me.btnQueryData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQueryData.Location = New System.Drawing.Point(258, 128)
        Me.btnQueryData.Name = "btnQueryData"
        Me.btnQueryData.Size = New System.Drawing.Size(103, 30)
        Me.btnQueryData.TabIndex = 3
        Me.btnQueryData.Text = "&Query Data"
        Me.ttpQuery.SetToolTip(Me.btnQueryData, "Search data for patterns")
        Me.btnQueryData.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please Select an Action"
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(178, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'studentAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(463, 249)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQueryData)
        Me.Controls.Add(Me.btnViewData)
        Me.Controls.Add(Me.btnModifyData)
        Me.Controls.Add(Me.btnNewData)
        Me.Name = "studentAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biolog Lab Data - Student View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewData As Button
    Friend WithEvents btnModifyData As Button
    Friend WithEvents btnViewData As Button
    Friend WithEvents btnQueryData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents ttpNewData As ToolTip
    Friend WithEvents ttpModData As ToolTip
    Friend WithEvents ttpViewData As ToolTip
    Friend WithEvents ttpQuery As ToolTip
End Class
