Public Class AdminChoices
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        StaffDashBoard.UserType = "A"
        StaffDashBoard.Show()
        Me.Close()
    End Sub
    Private Sub btnManageSpecials_Click(sender As Object, e As EventArgs) Handles btnManageSpecials.Click
        ManageProducts.Show()
        Me.Close()
    End Sub

    Private Sub btnViewSales_Click(sender As Object, e As EventArgs) Handles btnViewSales.Click
        ViewSaless.Show()
        Me.Close()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Login.Show()
        Me.Close()
    End Sub
End Class