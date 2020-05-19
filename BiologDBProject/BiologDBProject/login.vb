'Jacquelyn Johnson wrote this. this form will collect login information, connect to the 
'database, and choose which form to show next after validating login credentials.
'05192020
Imports MySql.Data.MySqlClient
Public Class LoginForm
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    'exits application entirely
    Me.Close()

  End Sub

  Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    'collects data from the text boxes and passes info to database for verification
    'if student id entered, call studentAction; else call profAction

    Try
      Using mysqlConn As New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
        Using query As New MySqlCommand("select studentID from student where studentID = @test", mysqlConn)
          query.Parameters.Add("@test", MySqlDbType.String).Value = txtUserID.Text

          mysqlConn.Open()
          Dim testID As String = query.ExecuteScalar.ToString
          If testID = txtUserID.Text Then
            studentAction.Show()
          End If

        End Using
      End Using



    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
    'studentAction.Show()   'switches to student viewing frame
    'profAction.Show()      'switches to professor frame

    Me.Hide()

  End Sub

  Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
    'brings up a message box window that will collect the required information and send that information 
    'the proper database table
    newUser.Show()
    Me.Hide()
  End Sub
End Class
