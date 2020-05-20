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
        Me.newProfessor = New System.Windows.Forms.GroupBox()
        Me.lblProfID = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblOffice = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblProfPass = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtProfID = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtOffice = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cbbClass = New System.Windows.Forms.ComboBox()
        Me.btnNewProfessor = New System.Windows.Forms.Button()
        Me.pnlButton.SuspendLayout()
        Me.pnlDisp.SuspendLayout()
        CType(Me.dgvStudentView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiologDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiologDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UniversityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.newProfessor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButton
        '
        Me.pnlButton.Controls.Add(Me.btnNewProfessor)
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
        Me.pnlDisp.Controls.Add(Me.newProfessor)
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
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassIDDataGridViewTextBoxColumn
        '
        Me.ClassIDDataGridViewTextBoxColumn.DataPropertyName = "classID"
        Me.ClassIDDataGridViewTextBoxColumn.HeaderText = "classID"
        Me.ClassIDDataGridViewTextBoxColumn.Name = "ClassIDDataGridViewTextBoxColumn"
        Me.ClassIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradeLevelDataGridViewTextBoxColumn
        '
        Me.GradeLevelDataGridViewTextBoxColumn.DataPropertyName = "gradeLevel"
        Me.GradeLevelDataGridViewTextBoxColumn.HeaderText = "gradeLevel"
        Me.GradeLevelDataGridViewTextBoxColumn.Name = "GradeLevelDataGridViewTextBoxColumn"
        Me.GradeLevelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentPasswordDataGridViewTextBoxColumn
        '
        Me.StudentPasswordDataGridViewTextBoxColumn.DataPropertyName = "studentPassword"
        Me.StudentPasswordDataGridViewTextBoxColumn.HeaderText = "studentPassword"
        Me.StudentPasswordDataGridViewTextBoxColumn.Name = "StudentPasswordDataGridViewTextBoxColumn"
        Me.StudentPasswordDataGridViewTextBoxColumn.ReadOnly = True
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
        'newProfessor
        '
        Me.newProfessor.Controls.Add(Me.cbbClass)
        Me.newProfessor.Controls.Add(Me.txtPassword)
        Me.newProfessor.Controls.Add(Me.txtEmail)
        Me.newProfessor.Controls.Add(Me.txtPhone)
        Me.newProfessor.Controls.Add(Me.txtOffice)
        Me.newProfessor.Controls.Add(Me.txtFName)
        Me.newProfessor.Controls.Add(Me.txtLName)
        Me.newProfessor.Controls.Add(Me.txtProfID)
        Me.newProfessor.Controls.Add(Me.btnSubmit)
        Me.newProfessor.Controls.Add(Me.lblProfPass)
        Me.newProfessor.Controls.Add(Me.lblEmail)
        Me.newProfessor.Controls.Add(Me.lblPhone)
        Me.newProfessor.Controls.Add(Me.lblOffice)
        Me.newProfessor.Controls.Add(Me.lblLName)
        Me.newProfessor.Controls.Add(Me.lblFName)
        Me.newProfessor.Controls.Add(Me.lblClass)
        Me.newProfessor.Controls.Add(Me.lblProfID)
        Me.newProfessor.Location = New System.Drawing.Point(3, 3)
        Me.newProfessor.Name = "newProfessor"
        Me.newProfessor.Size = New System.Drawing.Size(561, 262)
        Me.newProfessor.TabIndex = 3
        Me.newProfessor.TabStop = False
        Me.newProfessor.Text = "Add New Professor"
        Me.newProfessor.Visible = False
        '
        'lblProfID
        '
        Me.lblProfID.AutoSize = True
        Me.lblProfID.Location = New System.Drawing.Point(18, 24)
        Me.lblProfID.Name = "lblProfID"
        Me.lblProfID.Size = New System.Drawing.Size(68, 13)
        Me.lblProfID.TabIndex = 0
        Me.lblProfID.Text = "Professor ID:"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(18, 54)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(35, 13)
        Me.lblClass.TabIndex = 1
        Me.lblClass.Text = "Class:"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(18, 86)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(60, 13)
        Me.lblFName.TabIndex = 2
        Me.lblFName.Text = "First Name:"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(18, 112)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(61, 13)
        Me.lblLName.TabIndex = 3
        Me.lblLName.Text = "Last Name:"
        '
        'lblOffice
        '
        Me.lblOffice.AutoSize = True
        Me.lblOffice.Location = New System.Drawing.Point(17, 140)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(78, 13)
        Me.lblOffice.TabIndex = 4
        Me.lblOffice.Text = "Office Number:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(17, 173)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(72, 13)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Office Phone:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(18, 199)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email:"
        '
        'lblProfPass
        '
        Me.lblProfPass.AutoSize = True
        Me.lblProfPass.Location = New System.Drawing.Point(18, 228)
        Me.lblProfPass.Name = "lblProfPass"
        Me.lblProfPass.Size = New System.Drawing.Size(56, 13)
        Me.lblProfPass.TabIndex = 7
        Me.lblProfPass.Text = "Password:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(480, 233)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtProfID
        '
        Me.txtProfID.Location = New System.Drawing.Point(106, 21)
        Me.txtProfID.Name = "txtProfID"
        Me.txtProfID.Size = New System.Drawing.Size(150, 20)
        Me.txtProfID.TabIndex = 9
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(106, 109)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(150, 20)
        Me.txtLName.TabIndex = 10
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(106, 83)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(150, 20)
        Me.txtFName.TabIndex = 11
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(106, 137)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(150, 20)
        Me.txtOffice.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(106, 170)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(150, 20)
        Me.txtPhone.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(106, 196)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 14
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(106, 221)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 15
        '
        'cbbClass
        '
        Me.cbbClass.FormattingEnabled = True
        Me.cbbClass.Location = New System.Drawing.Point(106, 51)
        Me.cbbClass.Name = "cbbClass"
        Me.cbbClass.Size = New System.Drawing.Size(121, 21)
        Me.cbbClass.TabIndex = 16
        '
        'btnNewProfessor
        '
        Me.btnNewProfessor.AutoSize = True
        Me.btnNewProfessor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewProfessor.Location = New System.Drawing.Point(4, 115)
        Me.btnNewProfessor.Name = "btnNewProfessor"
        Me.btnNewProfessor.Size = New System.Drawing.Size(126, 30)
        Me.btnNewProfessor.TabIndex = 3
        Me.btnNewProfessor.Text = "New &Professor"
        Me.btnNewProfessor.UseVisualStyleBackColor = True
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
        Me.newProfessor.ResumeLayout(False)
        Me.newProfessor.PerformLayout()
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
    Friend WithEvents newProfessor As GroupBox
    Friend WithEvents lblProfPass As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblOffice As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents lblProfID As Label
    Friend WithEvents cbbClass As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtOffice As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtProfID As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnNewProfessor As Button
End Class
