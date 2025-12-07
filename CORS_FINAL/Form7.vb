Public Class Form7
    Private Sub ButtonIK502_Click(sender As Object, e As EventArgs) Handles ButtonIK502.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeResponsive(Me)
    End Sub
End Class