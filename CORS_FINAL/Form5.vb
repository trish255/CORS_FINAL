Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Buttons502to506_Click(sender As Object, e As EventArgs) _
        Handles Button502.Click, Button503.Click, Button504.Click, Button505.Click, Button506.Click

        Me.Hide()
        Form9.Show()
    End Sub

End Class
