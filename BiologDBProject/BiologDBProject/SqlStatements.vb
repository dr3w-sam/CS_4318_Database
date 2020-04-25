'this class is for holding common methods of sql statements 
'that will be referenced throughout the program. 
'keeping them here will allow for cleaner coding and fewer repetitions of methods
'this class was created by jacquelyn johnson

Imports MySql.Data.MySqlClient

Public Class SqlStatements

  'this method will accept two values. a is the table name, b is the column to retrieve the data from
  'Public Sub getStudentValue(ByVal a As String, ByVal b As String)
  '  Dim mysqlconn As New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
  '  Dim sql As New MySqlCommand("(SELECT " + b + " FROM " + a + " WHERE studentID=(SELECT * FROM " + a + " ORDER BY studentID DESC LIMIT 1; )", mysqlconn)
  '  Dim id As Int16

  '  mysqlconn.Open()
  '  If sql.ExecuteNonQuery = 1 Then
  '    Dim idGrab As MySqlDataReader = sql.ExecuteReader()
  '    id = CShort(idGrab.Read())
  '    id += CShort(1)
  '  Else
  '    MessageBox.Show("ERROR in getStudentValue method")
  '  End If

  'End Sub

  Public Shared Function GetStudentValue(a As String, b As String) As Integer
    Dim mysqlconn As New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
    Dim sql As New MySqlCommand("(SELECT `" + b + "` FROM `" + a + "` WHERE studentID=(SELECT * FROM `" + a + "` ORDER BY studentID DESC LIMIT 1)", mysqlconn)
    Dim id As Int16

    mysqlconn.Open()
    If sql.ExecuteNonQuery() = 1 Then
      Dim idGrab As MySqlDataReader = sql.ExecuteReader()
      id = CShort(idGrab.Read())
      id += CShort(1)
    Else
      MessageBox.Show("ERROR in getStudentValue method")
    End If

    Return id
    mysqlconn.Close()

  End Function


End Class
