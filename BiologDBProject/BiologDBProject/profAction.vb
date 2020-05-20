'this code was written by Jacquelyn Johnson
'05202020
Imports MySql.Data.MySqlClient
Public Class profAction
  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()  'close current form
    LoginForm.Close() 'close entire application

  End Sub
  'click sub for return to login form
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Me.Close()
    LoginForm.Show()

  End Sub
  'button click that will display the contents of the lab data that is currently in the database
  'it will be displayed in the panel pnlDisp on the current form
  Private Sub btnLabData_Click(sender As Object, e As EventArgs) Handles btnLabData.Click
    ' dgvUniversity.Visible = False
    dgvStudentView.Visible = False
    dgvData.Visible = True
  End Sub
  'button click will display all students currently in the database
  Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
    dgvData.Visible = False
    ' dgvUniversity.Visible = False
    dgvStudentView.Visible = True

  End Sub

  Private Sub profAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'BiologDataSet.data' table. You can move, or remove it, as needed.
    Me.DataTableAdapter.Fill(Me.BiologDataSet.data)
    'TODO: This line of code loads data into the 'BiologDataSet.university' table. You can move, or remove it, as needed.
    ' Me.UniversityTableAdapter.Fill(Me.BiologDataSet.university)
    'TODO: This line of code loads data into the 'BiologDataSet.student' table. You can move, or remove it, as needed.
    Me.StudentTableAdapter.Fill(Me.BiologDataSet.student)

    popCbb()

  End Sub

  Private Sub btnUniv_Click(sender As Object, e As EventArgs) Handles btnUniv.Click
    dgvStudentView.Visible = False
    dgvData.Visible = False
    ' dgvUniversity.Visible = True
  End Sub

  Private Sub btnNewProfessor_Click(sender As Object, e As EventArgs) Handles btnNewProfessor.Click
    dgvData.Visible = False
    dgvStudentView.Visible = False
    newProfessor.Visible = True
  End Sub
  'this button click will collect the input data from the text fields and insert them in the database

  Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
    Using mysqlConn As New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
      Using query As New MySqlCommand("insert into `professor`(`professorID`,`classID`,`firstName`,`lastName`,`officeNo`,`phoneNo`,`email`,`profPassword`) values 
@profID, @class, @fName, @lName, @office, @phone, @email, @profPass")


      End Using
    End Using
  End Sub
  Private Sub popCbb()

    Dim dr As MySqlDataReader 'needed to read the data from the database into a local variable

    Try
      Using mysqlConn As New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
        Using query As New MySqlCommand("select classID, className from class", mysqlConn) 'selects only the classID and the className from the db
          mysqlConn.Open()        'open db connection
          dr = query.ExecuteReader

          While dr.Read = True  'will loop until no more tuples are found in the db
            Dim clId As String
            Dim name As String
            Dim both As String  'variable to hold string concat
            clId = CType(dr("classID"), String)
            name = CType(dr("className"), String)
            both = clId + " " + name
            cbbClass.Items.Add(both)  'adds as concatenated string to the combobox for user selection
          End While

        End Using

      End Using
    Catch ex As Exception
      MessageBox.Show(ex.Message)

    End Try
  End Sub

  'this function will return the classID number to pass to the database in order to assign the student to the correct class
  Private Function getClassID() As String
    Dim id As String
    Dim actual As String
    id = CType(cbbClass.SelectedItem(), String)
    actual = id.Substring(0, 4)

    Return actual
  End Function

End Class