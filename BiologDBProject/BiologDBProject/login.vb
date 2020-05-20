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
    If CInt(txtUserID.Text.Substring(0, 1)) > 2 Then
      Try
        Using mysqlConn As New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
          Using query As New MySqlCommand("select studentID from student where studentID = @test", mysqlConn)
            query.Parameters.Add("@test", MySqlDbType.String).Value = txtUserID.Text

            mysqlConn.Open()

            Dim testID As String = query.ExecuteScalar.ToString
            If testID = txtUserID.Text Then
              Using q2 As New MySqlCommand("select studentPassword from student where studentID = @test", mysqlConn)
                q2.Parameters.Add("@test", MySqlDbType.String).Value = txtUserID.Text
                Dim testPass As String = q2.ExecuteScalar.ToString
                If testPass = txtPassword.Text Then
                  studentAction.Show()
                  Me.Hide()
                Else
                  lblError.Text = "Student password incorrect"

                End If
              End Using
            End If

          End Using
        End Using

      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try

    ElseIf (CInt(txtUserID.Text.Substring(0, 1)) > 0 And CInt(txtUserID.Text.Substring(0, 1)) < 2) Then
      Try
        Using mysqlConn As New MySqlConnection("server=localhost;userid=root;password=Quantum_2020;database=biolog")
          Using query As New MySqlCommand("select professorID from professor where professorID = @test", mysqlConn)
            query.Parameters.Add("@test", MySqlDbType.String).Value = txtUserID.Text

            mysqlConn.Open()
            Dim testID As String = query.ExecuteScalar.ToString
            If testID = txtUserID.Text Then
              Using q2 As New MySqlCommand("select profPassword from professor where professorID = @test", mysqlConn)
                q2.Parameters.Add("@test", MySqlDbType.String).Value = txtUserID.Text
                Dim testPass As String = q2.ExecuteScalar.ToString
                If testPass = txtPassword.Text Then
                  profAction.Show()
                  Me.Hide()
                Else
                  lblError.Text = "Professor password incorrect"

                End If
              End Using
            End If

          End Using
        End Using

      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try
    Else
      lblError.Text = "User not found in connected database"

    End If


  End Sub

  Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
    'brings up a message box window that will collect the required information and send that information 
    'the proper database table
    newUser.Show()
    Me.Hide()
  End Sub

  Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    txtPassword.Text = String.Empty
    txtUserID.Text = String.Empty
    lblError.Text = String.Empty
    txtUserID.Focus()
  End Sub
End Class
