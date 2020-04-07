Public Class studentAction

  Private Sub btnNewData_Click(sender As Object, e As EventArgs) Handles btnNewData.Click

  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    'exits the program
    Me.Close()
    LoginForm.Close()    'this will close out the main login form. can simply switch back to login with LoginForm.Show()'

  End Sub


End Class