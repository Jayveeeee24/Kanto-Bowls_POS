Public Class ManageProducts
    'Database
    Dim cn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    Dim ItemID, pName As String
    Dim pprice As Integer
    Dim categ As Integer
    Private Sub ManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabManage.SendToBack()
        panelHeader.BringToFront()

        ActiveAdd.Show()
        ActiveEdit.Hide()
        ActiveDelete.Hide()

        tabManage.SelectedIndex = 0
        btnAdd.BackColor = Color.DarkOrange

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ActiveAdd.Show()
        ActiveEdit.Hide()
        ActiveDelete.Hide()

        tabManage.SelectedIndex = 0

        btnAdd.BackColor = Color.DarkOrange
        btnEdit.BackColor = Color.Chocolate
        btnDelete.BackColor = Color.Chocolate
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ActiveAdd.Hide()
        ActiveEdit.Show()
        ActiveDelete.Hide()

        tabManage.SelectedIndex = 1

        btnAdd.BackColor = Color.Chocolate
        btnEdit.BackColor = Color.DarkOrange
        btnDelete.BackColor = Color.Chocolate
        edit()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ActiveAdd.Hide()
        ActiveEdit.Hide()
        ActiveDelete.Show()

        tabManage.SelectedIndex = 2

        btnAdd.BackColor = Color.Chocolate
        btnEdit.BackColor = Color.Chocolate
        btnDelete.BackColor = Color.DarkOrange

        delete()
    End Sub

    Private Sub edit()
        Refresh()
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price, Type, Category from Products", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        Me.DataGridEdit.DataSource = DT
        Me.DataGridEdit.ReadOnly = True
        Me.DataGridEdit.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridEdit.AutoResizeColumns()
        Me.DataGridEdit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridEdit.ClearSelection()
        cn.Close()

    End Sub
    Private Sub delete()
        Refresh()
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price, Type, Category from Products", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        Me.DataGridDelete.DataSource = DT
        Me.DataGridDelete.ReadOnly = True
        Me.DataGridDelete.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDelete.AutoResizeColumns()
        Me.DataGridDelete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridDelete.ClearSelection()
        cn.Close()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        AdminChoices.Show()
        Me.Close()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub cbType_TextChanged(sender As Object, e As EventArgs) Handles cbType.TextChanged
        cbType.Text = "-Enter Type-"
    End Sub
    Private Sub cbCategory_TextChanged(sender As Object, e As EventArgs) Handles cbCategory.TextChanged
        cbCategory.Text = "-Enter a Category-"
    End Sub
   
    Private Sub cbType_Click(sender As Object, e As EventArgs) Handles cbType.Click
        If cbType.Items.Contains("Main Dish") Then
            Exit Sub
        Else
            cbType.Items.Add("Main Dish")
            cbType.Items.Add("Beverages")
            cbType.Items.Add("Share Meals")
        End If
        End Sub
    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged
        cbCategory.Items.Clear()
        If cbType.SelectedIndex = 0 Then
            cbCategory.Items.Add("Chicken")
            cbCategory.Items.Add("Pork")
            cbCategory.Items.Add("Grilled")
            cbCategory.Items.Add("Student Meal")
        ElseIf cbType.SelectedIndex = 1 Then
            cbCategory.Items.Add("Juice")
            cbCategory.Items.Add("MilkTea")
            cbCategory.Items.Add("Frappe")
        ElseIf cbType.SelectedIndex = 2 Then
            cbCategory.Items.Add("Chicken and Pork")
            cbCategory.Items.Add("Ulam Meals")
        End If
            cbCategory.Enabled = True

       End Sub
    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        AddpName.Enabled = True
        If cbType.SelectedIndex = 0 And cbCategory.SelectedIndex = 0 Then
            categ = 14300
        ElseIf cbType.SelectedIndex = 0 And cbCategory.SelectedIndex = 1 Then
            categ = 24300
        ElseIf cbType.SelectedIndex = 0 And cbCategory.SelectedIndex = 2 Then
            categ = 34300
        ElseIf cbType.SelectedIndex = 0 And cbCategory.SelectedIndex = 3 Then
            categ = 44300
        ElseIf cbType.SelectedIndex = 1 And cbCategory.SelectedIndex = 0 Then
            categ = 54300
        ElseIf cbType.SelectedIndex = 1 And cbCategory.SelectedIndex = 1 Then
            categ = 64300
        ElseIf cbType.SelectedIndex = 1 And cbCategory.SelectedIndex = 2 Then
            categ = 74300
        ElseIf cbType.SelectedIndex = 2 And cbCategory.SelectedIndex = 0 Then
            categ = 84300
        ElseIf cbType.SelectedIndex = 2 And cbCategory.SelectedIndex = 1 Then
            categ = 94300
        End If
    End Sub

    Private Sub AddpPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddpPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub AddpName_Click(sender As Object, e As EventArgs) Handles AddpName.Click
        AddpName.Clear()
        AddpPrice.Enabled = True
    End Sub
    Private Sub AddpPrice_Click(sender As Object, e As EventArgs) Handles AddpPrice.Click
        AddpPrice.Clear()
        btnAdds.Enabled = True
    End Sub

    Private Sub btnAdds_Click(sender As Object, e As EventArgs) Handles btnAdds.Click
        If AddpName.Text = "" Or AddpPrice.Text = "" Then
            MsgBox("Please Fill out the Required Fields!", vbInformation, "Warning!")
            Exit Sub
        End If
        DataGridView1.Visible = True
        Dim type As String = cbType.Text
        Dim incre As Integer = 1
        Dim ItemID As String = categ & incre
        Dim category As String = cbCategory.Text
        Dim pName As String = AddpName.Text
        Dim pPrice As Integer = AddpPrice.Text


        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        Dim aadp As New OleDb.OleDbDataAdapter("Select * from Products WHERE ProductName='" & pName & "'", cn)
        Dim ddt As New DataTable
        aadp.Fill(ddt)
        If ddt.Rows.Count >= 1 Then
            MsgBox("The Name you Specified is already in the menu! Please Try Again.", vbExclamation, "Warning!")
            DataGridView1.Visible = False
            AddpName.Clear()
            cn.Close()
            Exit Sub
        End If
check:
        ItemID = categ & incre
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Products WHERE ItemID='" & ItemID & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        If DT.Rows.Count >= 1 Then
            incre = incre + 1
            GoTo check
        End If


        Dim z As Integer = 0
        cmd.CommandText = "INSERT INTO Products(ItemID, ProductName, Price, PSales, QSales, Type, Category)" & "VALUES('" & ItemID & "','" & pName & "','" & pPrice & "','" & z & "','" & z & "','" & type & "','" & category & "')"
        cmd.ExecuteNonQuery()
        DataGridView1.Visible = False
        cn.Close()
        AddpName.Text = "-Enter Product Name-"
        AddpPrice.Text = "Enter Product Price-"
        AddpName.Enabled = False
        AddpPrice.Enabled = False
        btnAdds.Enabled = False
        cbCategory.Enabled = False

        MsgBox("Product Added Successfully", vbExclamation, "Notification!")
    End Sub

  

    Private Sub NewPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub NewName_Click(sender As Object, e As EventArgs) Handles NewName.Click
        NewName.Clear()
        btnSave.Enabled = True
    End Sub
    Private Sub NewPrice_Click(sender As Object, e As EventArgs) Handles NewPrice.Click
        NewPrice.Clear()
        btnSave.Enabled = True
    End Sub
    Private Sub NewPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles NewPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnSave.PerformClick()
        End If

    End Sub

    Private Sub DataGridEdit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridEdit.CellContentClick
        Dim i As Integer = Me.DataGridEdit.CurrentRow.Index
        ItemID = RTrim(Me.DataGridEdit.Rows(i).Cells(0).Value)
        pName = RTrim(Me.DataGridEdit.Rows(i).Cells(1).Value)
        pprice = RTrim(Me.DataGridEdit.Rows(i).Cells(2).Value)
        NewName.Enabled = True
        NewPrice.Enabled = True
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If NewName.Text = "" Or NewPrice.Text = "" And NewName.Text = "-Product Name-" Or NewPrice.Text = "-Enter Price-" Then
            MsgBox("Please Fill out the Required Fields!", vbExclamation, "Warning!")
            Exit Sub
        End If
        Dim price As Integer = Convert.ToInt64(NewPrice.Text)
        If price < 1 Then
            MsgBox("Please enter a Valid Price Value", vbInformation, "Notification1")
            Exit Sub
        End If

        DataGridView1.Visible = True
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Products WHERE ProductName='" & Me.NewName.Text & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        Me.DataGridView1.DataSource = DT

        If DT.Rows.Count >= 1 Then
            MsgBox("The Name you Specified is already in the menu! Please Try Again.", vbExclamation, "Warning!")
            DataGridView1.Visible = False
            NewName.Clear()
            cn.Close()
            Exit Sub
        End If
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn

        cmd.CommandText = "UPDATE Products SET ProductName='" & Me.NewName.Text & "', Price='" & Me.NewPrice.Text & "' WHERE ItemID='" & Me.ItemID & "' "
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Product Updated Successfully", vbInformation, "Notification!")
        NewName.Text = "-Product Name-"
        NewPrice.Text = "-Enter Price-"
        btnSave.Enabled = False
        DataGridEdit.ClearSelection()
        edit()
    End Sub



    Private Sub DataGridDelete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridDelete.CellContentClick
        Dim i As Integer = Me.DataGridDelete.CurrentRow.Index
        ItemID = RTrim(Me.DataGridDelete.Rows(i).Cells(0).Value)
        pName = RTrim(Me.DataGridDelete.Rows(i).Cells(1).Value)
        pprice = RTrim(Me.DataGridDelete.Rows(i).Cells(2).Value)
        lblItemID.Text = ItemID
        lblpName.Text = pName
        lblprice.Text = pprice
        btnDel.Enabled = True
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If lblItemID.Text = "___________" Or lblpName.Text = "___________" Or lblprice.Text = "__________" Then
            MsgBox("You Haven't Selected Anything Yet!", vbInformation, "Notification!")
            Exit Sub
        End If
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE * from Products WHERE ItemID='" & ItemID & "'"
        cmd.ExecuteNonQuery()
        cn.Close()

        MsgBox("Product Deleted Successfully!", vbInformation, "Notification!")
        lblItemID.Text = "___________"
        lblpName.Text = "___________"
        lblprice.Text = "__________"
        delete()


    End Sub
End Class