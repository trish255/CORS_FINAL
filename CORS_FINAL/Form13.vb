Public Class Form13
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeResponsive(Me)
    End Sub
End Class