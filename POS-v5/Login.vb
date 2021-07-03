Public Class Login
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        LoginAdmin.Show()
        Me.Close()
    End Sub
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        StaffDashBoard.UserType = "B"
        StaffDashBoard.Show()
        Me.Close()
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnAdmin.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
