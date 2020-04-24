'Jacquelyn Johnson wrote this code...
Imports MySql.Data.MySqlClient

Public Class newUser
  'create local variables to collect information from the form
  Private fName As String
  Private lName As String
  Private gLevel As String
  Private studPassword As String
  Private email As String

  'create connection varibles for database stuff
  Dim mysqlConn As MySqlConnection
  Dim sql As MySqlCommand

  Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
    'collect information from the fields and send to the Student Table in the connected biolog database
    fName = txtStudFName.Text
    lName = txtStudLName.Text
    gLevel = CType(cbbGradeLevel.SelectedItem, String)
    studPassword = txtStudNewPass.Text
    email = txtStudEmail.Text

    MessageBox.Show(fName)

    mysqlConn = New MySqlConnection
    mysqlConn.ConnectionString =
      "server=localhost;userid=root;password=Quantum_2020;database=biolog"
    Dim reader As MySqlDataReader

    'try block to insert values in Student table of biolog database
    Try
      'open sql db connection
      mysqlConn.Open()
      Dim query As String
      'define the sql statement that will be executed
      query = "insert into biolog.student ('firstName', 'lastName', 'gradeLevel', 'email', 'studentPassword') values (fName, lName, gLevel, email, studPassword)"
      sql = New MySqlCommand(query, mysqlConn)
      reader = sql.ExecuteReader

      'show successful addition to table for user benefit
      MessageBox.Show("Data Saved in Student Table")
      mysqlConn.Close()

    Catch ex As Exception
      'show exception that is thrown
      MessageBox.Show(ex.Message)
    Finally
      'close connection even if exception is thrown
      mysqlConn.Close()

    End Try

  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    'discards form instance and returns to login form
    Me.Close()
    LoginForm.Show()
  End Sub
End Class