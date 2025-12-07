Module Module1

    Public Sub MakeResponsive(frm As Form)
        frm.FormBorderStyle = FormBorderStyle.Sizable
        For Each ctrl As Control In frm.Controls
            ctrl.Dock = DockStyle.Fill
        Next
    End Sub
End Module
