Public Class Form8
    Private Sub ButtonIK602_Click(sender As Object, e As EventArgs) Handles ButtonIK602.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeResponsive(Me)
    End Sub
End Class