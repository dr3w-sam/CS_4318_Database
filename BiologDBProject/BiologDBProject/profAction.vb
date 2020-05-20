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

  End Sub

  Private Sub btnUniv_Click(sender As Object, e As EventArgs) Handles btnUniv.Click
    dgvStudentView.Visible = False
    dgvData.Visible = False
    ' dgvUniversity.Visible = True
  End Sub
End Class