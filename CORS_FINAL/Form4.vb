Public Class Form4

    Private ILVisible As Boolean = False
    Private IKVisible As Boolean = False
    Private MenuVisible As Boolean = False

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeResponsive(Me)
        For Each ctrl In {IL5thFloor, IL6thFloor, IK5thFloor, IK6thFloor}
            ctrl.Visible = False
        Next

        For Each ctrl In {MenuPanel, bell, setting, record, history,
                          NotifButton, SettingButton, RecordButton, HistoryButton}
            ctrl.Visible = False
        Next
    End Sub


    Private Sub AcadGroup_Click(sender As Object, e As EventArgs) _
        Handles AcadButton.Click, Label2.Click, ILBuilding.Click
        ILVisible = Not ILVisible
        ToggleControls({IL5thFloor, IL6thFloor}, ILVisible)
    End Sub


    Private Sub BautistaGroup_Click(sender As Object, e As EventArgs) _
        Handles BautistaButton.Click, IKBuilding.Click, Label3.Click
        IKVisible = Not IKVisible
        ToggleControls({IK5thFloor, IK6thFloor}, IKVisible)
    End Sub


    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        MenuVisible = Not MenuVisible
        ToggleControls({MenuPanel, bell, setting, record, history,
                        NotifButton, SettingButton, RecordButton, HistoryButton}, MenuVisible)
    End Sub


    Private Sub ToggleControls(ctrls As Control(), visible As Boolean)
        For Each c In ctrls
            c.Visible = visible
        Next
    End Sub

    Private Sub IL5thFloor_Click(sender As Object, e As EventArgs) Handles IL5thFloor.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub IL6thFloor_Click(sender As Object, e As EventArgs) Handles IL6thFloor.Click
        Me.Hide()

    End Sub

    Private Sub IK5thFloor_Click(sender As Object, e As EventArgs) Handles IK5thFloor.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub IK6thFloor_Click(sender As Object, e As EventArgs) Handles IK6thFloor.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub RecordButton_Click(sender As Object, e As EventArgs) Handles RecordButton.Click
        Me.Hide()
        Form12.Show()
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        Me.Hide()
        Form13.Show()
    End Sub
End Class
