Public Class Form9
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeResponsive(Me)
    End Sub
End Class