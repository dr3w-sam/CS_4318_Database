Public Class profAction
  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()  'close current form
    LoginForm.Close() 'close entire application

  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Me.Close()
    LoginForm.Show()

  End Sub
End Class