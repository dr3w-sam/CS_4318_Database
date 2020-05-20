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
        Me.components = New System.ComponentModel.Container()
        Me.pnlButton = New System.Windows.Forms.Panel()
        Me.btnUniv = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnLabData = New System.Windows.Forms.Button()
        Me.pnlDisp = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvStudentView = New System.Windows.Forms.DataGridView()
        Me.BiologDataSet = New BiologDBProject.biologDataSet()
        Me.BiologDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New BiologDBProject.biologDataSetTableAdapters.studentTableAdapter()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UniversityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UniversityTableAdapter = New BiologDBProject.biologDataSetTableAdapters.universityTableAdapter()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableAdapter = New BiologDBProject.biologDataSetTableAdapters.dataTableAdapter()
        Me.DataIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubstrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReactionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ElectricalOutputDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlButton.SuspendLayout()
        Me.pnlDisp.SuspendLayout()
        CType(Me.dgvStudentView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiologDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiologDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnlDisp
        '
        Me.pnlDisp.AutoScroll = True
        Me.pnlDisp.Controls.Add(Me.dgvStudentView)
        Me.pnlDisp.Controls.Add(Me.dgvData)
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
        'dgvStudentView
        '
        Me.dgvStudentView.AllowUserToAddRows = False
        Me.dgvStudentView.AllowUserToDeleteRows = False
        Me.dgvStudentView.AutoGenerateColumns = False
        Me.dgvStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.ClassIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GradeLevelDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.StudentPasswordDataGridViewTextBoxColumn})
        Me.dgvStudentView.DataSource = Me.StudentBindingSource
        Me.dgvStudentView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudentView.Location = New System.Drawing.Point(0, 0)
        Me.dgvStudentView.Name = "dgvStudentView"
        Me.dgvStudentView.ReadOnly = True
        Me.dgvStudentView.Size = New System.Drawing.Size(567, 290)
        Me.dgvStudentView.TabIndex = 0
        Me.dgvStudentView.Visible = False
        '
        'BiologDataSet
        '
        Me.BiologDataSet.DataSetName = "biologDataSet"
        Me.BiologDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BiologDataSetBindingSource
        '
        Me.BiologDataSetBindingSource.DataSource = Me.BiologDataSet
        Me.BiologDataSetBindingSource.Position = 0
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.BiologDataSetBindingSource
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'ClassIDDataGridViewTextBoxColumn
        '
        Me.ClassIDDataGridViewTextBoxColumn.DataPropertyName = "classID"
        Me.ClassIDDataGridViewTextBoxColumn.HeaderText = "classID"
        Me.ClassIDDataGridViewTextBoxColumn.Name = "ClassIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'GradeLevelDataGridViewTextBoxColumn
        '
        Me.GradeLevelDataGridViewTextBoxColumn.DataPropertyName = "gradeLevel"
        Me.GradeLevelDataGridViewTextBoxColumn.HeaderText = "gradeLevel"
        Me.GradeLevelDataGridViewTextBoxColumn.Name = "GradeLevelDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'StudentPasswordDataGridViewTextBoxColumn
        '
        Me.StudentPasswordDataGridViewTextBoxColumn.DataPropertyName = "studentPassword"
        Me.StudentPasswordDataGridViewTextBoxColumn.HeaderText = "studentPassword"
        Me.StudentPasswordDataGridViewTextBoxColumn.Name = "StudentPasswordDataGridViewTextBoxColumn"
        '
        'UniversityBindingSource
        '
        Me.UniversityBindingSource.DataMember = "university"
        Me.UniversityBindingSource.DataSource = Me.BiologDataSetBindingSource
        '
        'UniversityTableAdapter
        '
        Me.UniversityTableAdapter.ClearBeforeFill = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataIDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn1, Me.LocationIDDataGridViewTextBoxColumn, Me.SubstrateDataGridViewTextBoxColumn, Me.ReactionDataGridViewTextBoxColumn, Me.ElectricalOutputDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.DataBindingSource
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(567, 290)
        Me.dgvData.TabIndex = 2
        Me.dgvData.Visible = False
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "data"
        Me.DataBindingSource.DataSource = Me.BiologDataSetBindingSource
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'DataIDDataGridViewTextBoxColumn
        '
        Me.DataIDDataGridViewTextBoxColumn.DataPropertyName = "dataID"
        Me.DataIDDataGridViewTextBoxColumn.HeaderText = "dataID"
        Me.DataIDDataGridViewTextBoxColumn.Name = "DataIDDataGridViewTextBoxColumn"
        Me.DataIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn1
        '
        Me.StudentIDDataGridViewTextBoxColumn1.DataPropertyName = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn1.HeaderText = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn1.Name = "StudentIDDataGridViewTextBoxColumn1"
        Me.StudentIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LocationIDDataGridViewTextBoxColumn
        '
        Me.LocationIDDataGridViewTextBoxColumn.DataPropertyName = "locationID"
        Me.LocationIDDataGridViewTextBoxColumn.HeaderText = "locationID"
        Me.LocationIDDataGridViewTextBoxColumn.Name = "LocationIDDataGridViewTextBoxColumn"
        Me.LocationIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubstrateDataGridViewTextBoxColumn
        '
        Me.SubstrateDataGridViewTextBoxColumn.DataPropertyName = "substrate"
        Me.SubstrateDataGridViewTextBoxColumn.HeaderText = "substrate"
        Me.SubstrateDataGridViewTextBoxColumn.Name = "SubstrateDataGridViewTextBoxColumn"
        Me.SubstrateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReactionDataGridViewTextBoxColumn
        '
        Me.ReactionDataGridViewTextBoxColumn.DataPropertyName = "reaction"
        Me.ReactionDataGridViewTextBoxColumn.HeaderText = "reaction"
        Me.ReactionDataGridViewTextBoxColumn.Name = "ReactionDataGridViewTextBoxColumn"
        Me.ReactionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ElectricalOutputDataGridViewTextBoxColumn
        '
        Me.ElectricalOutputDataGridViewTextBoxColumn.DataPropertyName = "electricalOutput"
        Me.ElectricalOutputDataGridViewTextBoxColumn.HeaderText = "electricalOutput"
        Me.ElectricalOutputDataGridViewTextBoxColumn.Name = "ElectricalOutputDataGridViewTextBoxColumn"
        Me.ElectricalOutputDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.pnlDisp.ResumeLayout(False)
        CType(Me.dgvStudentView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiologDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiologDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UniversityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvStudentView As DataGridView
    Friend WithEvents BiologDataSetBindingSource As BindingSource
    Friend WithEvents BiologDataSet As biologDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As biologDataSetTableAdapters.studentTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UniversityBindingSource As BindingSource
    Friend WithEvents UniversityTableAdapter As biologDataSetTableAdapters.universityTableAdapter
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents DataBindingSource As BindingSource
    Friend WithEvents DataTableAdapter As biologDataSetTableAdapters.dataTableAdapter
    Friend WithEvents DataIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubstrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReactionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ElectricalOutputDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
