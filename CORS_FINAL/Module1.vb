Module Module1

    Public Sub MakeResponsive(frm As Form)
        frm.FormBorderStyle = FormBorderStyle.Sizable
        frm.AutoScaleMode = AutoScaleMode.Dpi

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        Dim designWidth As Integer = 1920
        Dim designHeight As Integer = 1060

        Dim scaleX As Single = screenWidth / designWidth
        Dim scaleY As Single = screenHeight / designHeight

        frm.Scale(New SizeF(scaleX, scaleY))
    End Sub

    Public Sub ApplyPoppinsFont(frm As Form)
        For Each ctrl As Control In frm.Controls
            ctrl.Font = New Font("Poppins", ctrl.Font.Size, ctrl.Font.Style)
        Next
    End Sub
End Module
