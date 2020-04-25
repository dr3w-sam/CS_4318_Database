Public Class LoginForm
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    'exits application entirely
    Me.Close()

  End Sub

  Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    'collects data from the text boxes and passes info to database for verification
    'if student id entered, call studentAction; else call profAction

    studentAction.Show()   'switches to student viewing frame
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
