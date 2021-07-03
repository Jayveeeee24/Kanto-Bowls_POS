Public Class LoginAdmin
    Dim cn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Clear()
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.Clear()
    End Sub

    Private Sub LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please Fill out the Required Fields!", vbCritical, "Warning!")
            Exit Sub
        End If

        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Accounts WHERE User = '" & Me.txtUsername.Text & "'AND Pass = '" & Me.txtPassword.Text & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        If DT.Rows.Count = 0 Then
            MsgBox("Access Denied!", vbExclamation, "Warning!")
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Text = "Username"
            txtPassword.Text = "Password"
        Else
            MsgBox("Login Successfully", vbInformation, "Notification!")
            AdminChoices.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btnForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnForgot.LinkClicked
        Forgot_Pass.Show()
        Me.Close()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.PasswordChar = "*"
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

  
End Class