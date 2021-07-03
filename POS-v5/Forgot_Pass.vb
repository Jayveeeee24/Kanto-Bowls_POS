Public Class Forgot_Pass
    Dim cn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Clear()
    End Sub
    Private Sub txtRecovery_Click(sender As Object, e As EventArgs) Handles txtRecovery.Click
        txtRecovery.Clear()
    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click
        txtPass.Clear()
    End Sub

    Private Sub Forgot_Pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginAdmin.Close()
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
    End Sub
    Private Sub btnChange_Click_1(sender As Object, e As EventArgs) Handles btnChange.Click
        If txtUsername.Text = "" Or txtRecovery.Text = "" Or txtPass.Text = "" Then
            MsgBox("Please Fill out the Required Fields!", vbCritical, "Warning!")
            Exit Sub
        End If
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        cmd.Connection = cn

        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Accounts WHERE User='" & Me.txtUsername.Text & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmd.CommandText = "UPDATE Accounts SET Pass='" & Me.txtPass.Text & "' WHERE User= '" & Me.txtUsername.Text & "' And Recovery='" & Me.txtRecovery.Text & "' "
            cmd.ExecuteNonQuery()
            MsgBox("You Successfully Changed Your Password", vbInformation, "Notification!")
            LoginAdmin.Show()
            Me.Close()
        Else
            MsgBox("The Information You Provided is Incorrect!", vbExclamation, "Warning!")
            LoginAdmin.Show()
            Me.Close()
        End If
        cn.Close()
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        LoginAdmin.Show()
        Me.Close()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.Click, txtRecovery.Click
        txtPass.PasswordChar = "*"
        txtRecovery.PasswordChar = "*"
    End Sub
    
    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnChange.PerformClick()
        End If
    End Sub
End Class