Public Class StaffDashBoard
    'Database
    Dim cn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand

    'Global Variables
    Public UserType As String
    Dim category As String
    Dim pName, ItemID As String
    Dim pTotal, qTotal As Integer
    Dim pPrice, pQuantity, tPrice, pSales, qSales As Double

    Private Sub StaffDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabFood.SendToBack()
        rbChicken.Checked = True
   
        ClearTemp()
        If UserType = "B" Then
            txtUsertype.text = "Signed in as: Staff Member"
        ElseIf UserType = "A" Then
            txtUsertype.Text = "Signed in as: Administrator"
        End If


        'Active Panel
        ActiveBeverages.Hide()
        ActiveBoodle.Hide()

        'Board Panel
        btnMainDishes.BackColor = Color.DarkOrange
        tabFood.SelectedIndex = 0

    End Sub

    'SIDE BUTTONS
    Private Sub btnMainDishes_Click(sender As Object, e As EventArgs) Handles btnMainDishes.Click
        Refresh()
        'Active Panel
        ActiveMain.Show()
        ActiveBeverages.Hide()
        ActiveBoodle.Hide()
        ActiveMyCart.Hide()
        ActiveSearch.Hide()

        'Board Panel
        tabFood.SelectedIndex = 0
        btnMainDishes.BackColor = Color.DarkOrange
        btnSharing.BackColor = Color.Chocolate
        btnBeverages.BackColor = Color.Chocolate
        btnMyCart.BackColor = Color.Chocolate
        btnSearch.BackColor = Color.Chocolate
    End Sub
    Private Sub btnBeverages_Click(sender As Object, e As EventArgs) Handles btnBeverages.Click
        Refresh()
        'Active Panel
        ActiveMain.Hide()
        ActiveBeverages.Show()
        ActiveBoodle.Hide()
        ActiveMyCart.Hide()
        ActiveSearch.Hide()

        'Board Panel
        tabFood.SelectedIndex = 1
        btnMainDishes.BackColor = Color.Chocolate
        btnBeverages.BackColor = Color.DarkOrange
        btnSharing.BackColor = Color.Chocolate
        btnMyCart.BackColor = Color.Chocolate
        btnSearch.BackColor = Color.Chocolate

        rbJuice.Checked = True
    End Sub
    Private Sub btnSharing_Click(sender As Object, e As EventArgs) Handles btnSharing.Click
        Refresh()
        'Active Panel
        ActiveMain.Hide()
        ActiveBeverages.Hide()
        ActiveBoodle.Show()
        ActiveMyCart.Hide()
        ActiveSearch.Hide()

        'Board Panel
        tabFood.SelectedIndex = 2
        btnMainDishes.BackColor = Color.Chocolate
        btnBeverages.BackColor = Color.Chocolate
        btnSharing.BackColor = Color.DarkOrange
        btnMyCart.BackColor = Color.Chocolate
        btnSearch.BackColor = Color.Chocolate
        rbChickPork.Checked = True

    End Sub
    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        Refresh()
        'Active Panel
        ActiveMain.Hide()
        ActiveBeverages.Hide()
        ActiveBoodle.Hide()
        ActiveMyCart.Show()
        ActiveSearch.Hide()

        'Board Panel
        tabFood.SelectedIndex = 3
        btnMainDishes.BackColor = Color.Chocolate
        btnBeverages.BackColor = Color.Chocolate
        btnSharing.BackColor = Color.Chocolate
        btnSearch.BackColor = Color.Chocolate
        btnMyCart.BackColor = Color.DarkOrange

        Cart()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Refresh()
        'Active Panel
        ActiveMain.Hide()
        ActiveBeverages.Hide()
        ActiveBoodle.Hide()
        ActiveMyCart.Hide()
        ActiveSearch.Show()
        'Board Panel
        tabFood.SelectedIndex = 4
        btnMainDishes.BackColor = Color.Chocolate
        btnBeverages.BackColor = Color.Chocolate
        btnSharing.BackColor = Color.Chocolate
        btnMyCart.BackColor = Color.Chocolate
        btnSearch.BackColor = Color.DarkOrange
        Search()

    End Sub

    Private Sub Cart()
        Refresh()
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Temp", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridMyCart.DataSource = DT
        Me.DataGridMyCart.ReadOnly = True
        Me.DataGridMyCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMyCart.AutoResizeColumns()
        Me.DataGridMyCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridMyCart.ClearSelection()
        Dim a As Integer
        Dim aa(100) As Integer
        Dim bb(100) As Integer
        While a < DT.Rows.Count
            aa(a) = RTrim(Me.DataGridMyCart.Rows(a).Cells(3).Value)
            bb(a) = RTrim(Me.DataGridMyCart.Rows(a).Cells(4).Value)
            a = a + 1
        End While
        Dim p As Integer
        For Each item As Integer In aa
            p += item
        Next
        lblTotal.Text = "₱" & p & ".00"
        pTotal = p
        Dim q As Integer
        For Each item As Integer In bb
            q += item
        Next
        lblQuantity.Text = q & " pc/s"
        qTotal = q
        txtAmount.Enabled = True
        btnPay.Enabled = True
    End Sub
    Private Sub Search()
        Refresh()
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridSearch.DataSource = DT
        Me.DataGridSearch.ReadOnly = True
        Me.DataGridSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSearch.AutoResizeColumns()
        Me.DataGridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridSearch.ClearSelection()

    End Sub
    Private Sub ClearTemp()
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE * from Temp"
        cmd.ExecuteNonQuery()
    End Sub

    'OPTIONS BUTTONS 
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ClearTemp()
        End
    End Sub
    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If txtUserType.Text = "Signed in as: Staff Member" Then
            Login.Show()
            Me.Close()
        ElseIf txtUserType.Text = "Signed in as: Administrator" Then
            AdminChoices.Show()
            Me.Close()
        End If
    End Sub

    'FUNCTIONS
    Private Sub txtAmount_Click(sender As Object, e As EventArgs) Handles txtAmount.Click
        txtAmount.Clear()
    End Sub
    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMainQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MainQuantity.KeyPress, BevQuantity.KeyPress, ShareQuantity.KeyPress, SearchQuantity.KeyPress, CartQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtMainQuantity_Click(sender As Object, e As EventArgs) Handles MainQuantity.Click, BevQuantity.Click, ShareQuantity.Click, SearchQuantity.Click, CartQuantity.Click
        MainQuantity.Clear()
        BevQuantity.Clear()
        ShareQuantity.Clear()
        SearchQuantity.Clear()
        CartQuantity.Clear()
    End Sub


    'MAIN DISHES
    Private Sub rbChicken_CheckedChanged(sender As Object, e As EventArgs) Handles rbChicken.CheckedChanged
        Refresh()
        category = "Chicken"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridMainMeal.DataSource = DT
        Me.DataGridMainMeal.ReadOnly = True
        Me.DataGridMainMeal.ClearSelection()
        Me.DataGridMainMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMainMeal.AutoResizeColumns()
        Me.DataGridMainMeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub rbPork_CheckedChanged(sender As Object, e As EventArgs) Handles rbPork.CheckedChanged
        Refresh()
        category = "Pork"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridMainMeal.DataSource = DT
        Me.DataGridMainMeal.ReadOnly = True
        Me.DataGridMainMeal.ClearSelection()
        Me.DataGridMainMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMainMeal.AutoResizeColumns()
        Me.DataGridMainMeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub rbGrilled_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrilled.CheckedChanged
        Refresh()
        category = "Grilled"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridMainMeal.DataSource = DT
        Me.DataGridMainMeal.ReadOnly = True
        Me.DataGridMainMeal.ClearSelection()
        Me.DataGridMainMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMainMeal.AutoResizeColumns()
        Me.DataGridMainMeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub rbStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rbStudent.CheckedChanged
        Refresh()
        category = "Student Meal"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridMainMeal.DataSource = DT
        Me.DataGridMainMeal.ReadOnly = True
        Me.DataGridMainMeal.ClearSelection()
        Me.DataGridMainMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMainMeal.AutoResizeColumns()
        Me.DataGridMainMeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub DataGridMainMeal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMainMeal.CellContentClick
        Refresh()
        MainQuantity.Enabled = True
        btnAddMain.Enabled = True
        Dim i As Integer = Me.DataGridMainMeal.CurrentRow.Index
        Me.ItemID = RTrim(Me.DataGridMainMeal.Rows(i).Cells(0).Value)
        Me.pName = RTrim(Me.DataGridMainMeal.Rows(i).Cells(1).Value)
        Me.pPrice = RTrim(Me.DataGridMainMeal.Rows(i).Cells(2).Value)
        lblpNameMain.Text = pName
        lblpriceMain.Text = pPrice
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddMain.Click
        Refresh()
        If MainQuantity.Text = "" Or MainQuantity.Text = "-Quantity-" Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        ElseIf Convert.ToInt64(MainQuantity.Text) < 1 Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        End If
        pQuantity = MainQuantity.Text
        tPrice = pPrice * pQuantity

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Temp WHERE ProductName='" & pName & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridView1.DataSource = DT
        Dim cQuantity As String = RTrim(Me.DataGridView1.Rows(0).Cells(4).Value)
        Dim cTotal As String = RTrim(Me.DataGridView1.Rows(0).Cells(3).Value)

        If DT.Rows.Count >= 1 Then
            tPrice = tPrice + Convert.ToInt64(cTotal)
            pQuantity = pQuantity + Convert.ToInt64(cQuantity)
            cmd.CommandText = "UPDATE Temp SET Quantity='" & Me.pQuantity & "', TotalPrice='" & Me.tPrice & " ' WHERE ProductName='" & Me.pName & "' "
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "INSERT INTO Temp (ItemID, ProductName, UnitPrice, TotalPrice, Quantity) " & "VALUES('" & Me.ItemID & "','" & Me.pName & "','" & Me.pPrice & "','" & Me.tPrice & "','" & Me.pQuantity & "')"
            cmd.ExecuteNonQuery()
        End If
        cn.Close()
        DataGridView1.Visible = False
        MsgBox("Order Added Successfully!", vbInformation, "Notification")
        DataGridMainMeal.ClearSelection()
        DataGridView1.ClearSelection()
        Me.ItemID = 0
        Me.pName = 0
        Me.pPrice = 0
        btnAddMain.Enabled = False
        MainQuantity.Text = "-Quantity-"
        MainQuantity.Enabled = False
        lblpNameMain.Text = "___________"
        lblpriceMain.Text = "________"
    End Sub

    'BEVERAGES
    Private Sub rbJuice_CheckedChanged(sender As Object, e As EventArgs) Handles rbJuice.CheckedChanged
        Refresh()
        category = "Juice"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridBev.DataSource = DT
        Me.DataGridBev.ReadOnly = True
        Me.DataGridBev.ClearSelection()
        Me.DataGridBev.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridBev.AutoResizeColumns()
        Me.DataGridBev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub rbMilkTea_CheckedChanged(sender As Object, e As EventArgs) Handles rbMilkTea.CheckedChanged
        Refresh()
        category = "MilkTea"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridBev.DataSource = DT
        Me.DataGridBev.ReadOnly = True
        Me.DataGridBev.ClearSelection()
        Me.DataGridBev.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridBev.AutoResizeColumns()
        Me.DataGridBev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub rbFrappe_CheckedChanged(sender As Object, e As EventArgs) Handles rbFrappe.CheckedChanged
        Refresh()
        category = "Frappe"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridBev.DataSource = DT
        Me.DataGridBev.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridBev.AutoResizeColumns()
        Me.DataGridBev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridBev.ClearSelection()
    End Sub
    Private Sub DataGridBev_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBev.CellContentClick
        Refresh()
        BevQuantity.Enabled = True
        btnAddBev.Enabled = True
        Dim i As Integer = Me.DataGridBev.CurrentRow.Index
        Me.ItemID = RTrim(Me.DataGridBev.Rows(i).Cells(0).Value)
        Me.pName = RTrim(Me.DataGridBev.Rows(i).Cells(1).Value)
        Me.pPrice = RTrim(Me.DataGridBev.Rows(i).Cells(2).Value)
        lblpNameBev.Text = pName
        lblpriceBev.Text = pPrice
    End Sub

    Private Sub btnAddBev_Click(sender As Object, e As EventArgs) Handles btnAddBev.Click
        Refresh()
        If BevQuantity.Text = "" Or BevQuantity.Text = "-Quantity-" Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        ElseIf Convert.ToInt64(BevQuantity.Text) < 1 Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        End If
        pQuantity = BevQuantity.Text
        tPrice = pPrice * pQuantity

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Temp WHERE ProductName='" & pName & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridView1.DataSource = DT
        Dim cQuantity As String = RTrim(Me.DataGridView1.Rows(0).Cells(4).Value)
        Dim cTotal As String = RTrim(Me.DataGridView1.Rows(0).Cells(3).Value)

        If DT.Rows.Count >= 1 Then
            tPrice = tPrice + Convert.ToInt64(cTotal)
            pQuantity = pQuantity + Convert.ToInt64(cQuantity)
            cmd.CommandText = "UPDATE Temp SET Quantity='" & Me.pQuantity & "', TotalPrice='" & Me.tPrice & " ' WHERE ProductName='" & Me.pName & "' "
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "INSERT INTO Temp (ItemID, ProductName, UnitPrice, TotalPrice, Quantity) " & "VALUES('" & Me.ItemID & "','" & Me.pName & "','" & Me.pPrice & "','" & Me.tPrice & "','" & Me.pQuantity & "')"
            cmd.ExecuteNonQuery()
        End If
        cn.Close()
        DataGridView1.Visible = False
        MsgBox("Order Added Successfully!", vbInformation, "Notification")
        DataGridBev.ClearSelection()
        DataGridView1.ClearSelection()
        Me.ItemID = 0
        Me.pName = 0
        Me.pPrice = 0
        btnAddBev.Enabled = False
        BevQuantity.Text = "-Quantity-"
        BevQuantity.Enabled = False
        lblpNameBev.Text = "___________"
        lblpriceBev.Text = "________"
    End Sub

    'SHARE MEALS
    Private Sub rbChickPork_CheckedChanged(sender As Object, e As EventArgs) Handles rbChickPork.CheckedChanged
        Refresh()
        category = "Chicken and Pork"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridShare.DataSource = DT
        Me.DataGridShare.ReadOnly = True
        Me.DataGridShare.ClearSelection()
        Me.DataGridShare.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridShare.AutoResizeColumns()
        Me.DataGridShare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub rbUlam_CheckedChanged(sender As Object, e As EventArgs) Handles rbUlam.CheckedChanged
        Refresh()
        category = "Ulam Meals"

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE Category='" & category & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridShare.DataSource = DT
        Me.DataGridShare.ReadOnly = True
        Me.DataGridShare.ClearSelection()
        Me.DataGridShare.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridShare.AutoResizeColumns()
        Me.DataGridShare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub
    Private Sub DataGridShare_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridShare.CellContentClick
        Refresh()
        ShareQuantity.Enabled = True
        btnAddShare.Enabled = True
        Dim i As Integer = Me.DataGridShare.CurrentRow.Index
        Me.ItemID = RTrim(Me.DataGridShare.Rows(i).Cells(0).Value)
        Me.pName = RTrim(Me.DataGridShare.Rows(i).Cells(1).Value)
        Me.pPrice = RTrim(Me.DataGridShare.Rows(i).Cells(2).Value)
        lblpNameShare.Text = pName
        lblpriceShare.Text = pPrice
    End Sub

    Private Sub btnAddShare_Click(sender As Object, e As EventArgs) Handles btnAddShare.Click
        Refresh()
        If ShareQuantity.Text = "" Or ShareQuantity.Text = "-Quantity-" Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        ElseIf Convert.ToInt64(ShareQuantity.Text) < 1 Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        End If
        pQuantity = ShareQuantity.Text
        tPrice = pPrice * pQuantity

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Temp WHERE ProductName='" & pName & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridView1.DataSource = DT
        Dim cQuantity As String = RTrim(Me.DataGridView1.Rows(0).Cells(4).Value)
        Dim cTotal As String = RTrim(Me.DataGridView1.Rows(0).Cells(3).Value)

        If DT.Rows.Count >= 1 Then
            tPrice = tPrice + Convert.ToInt64(cTotal)
            pQuantity = pQuantity + Convert.ToInt64(cQuantity)
            cmd.CommandText = "UPDATE Temp SET Quantity='" & Me.pQuantity & "', TotalPrice='" & Me.tPrice & " ' WHERE ProductName='" & Me.pName & "' "
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "INSERT INTO Temp (ItemID, ProductName, UnitPrice, TotalPrice, Quantity) " & "VALUES('" & Me.ItemID & "','" & Me.pName & "','" & Me.pPrice & "','" & Me.tPrice & "','" & Me.pQuantity & "')"
            cmd.ExecuteNonQuery()
        End If
        cn.Close()
        DataGridView1.Visible = False
        MsgBox("Order Added Successfully!", vbInformation, "Notification")
        DataGridShare.ClearSelection()
        DataGridView1.ClearSelection()
        Me.ItemID = 0
        Me.pName = 0
        Me.pPrice = 0
        btnAddShare.Enabled = False
        ShareQuantity.Text = "-Quantity-"
        ShareQuantity.Enabled = False
        lblpNameShare.Text = "___________"
        lblpriceShare.Text = "________"
    End Sub

    'SEARCH
    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        Refresh()

        If txtSearchID.Text = "" And txtSearchName.Text = "" Or txtSearchName.Text = "-Enter Keyword-" And txtSearchID.Text = "-Enter Keyword-" Then
            MsgBox("Please Choose Between Product ID or Name!", vbCritical, "Warning!")
            Exit Sub
        End If
        If txtSearchName.Text = "-Enter Keyword-" Then
            txtSearchName.Text = ""
        End If
        If txtSearchID.Text = "-Enter Keyword-" Then
            txtSearchID.Text = ""
        End If

        If txtSearchID.Text <> "" Then
            MsgBox("Here is the Search Result!", vbInformation, "Notification!")
            cn = New OleDb.OleDbConnection
            cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            cmd.Connection = cn
            Dim ADP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE ItemID='" & Me.txtSearchID.Text & "'", cn)
            Dim DT As New DataTable
            ADP.Fill(DT)
            Me.DataGridSearch.DataSource = DT
            Me.DataGridSearch.ReadOnly = True
            Me.DataGridSearch.ClearSelection()
            Me.DataGridSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.DataGridSearch.AutoResizeColumns()
            Me.DataGridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If

        If txtSearchName.Text <> "" Then
            MsgBox("Here is the Search Result!", vbInformation, "Notification!")
            cn = New OleDb.OleDbConnection
            cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            cmd.Connection = cn
            Dim name As String = txtSearchName.Text
            Dim ADPP As New OleDb.OleDbDataAdapter("Select ItemID, ProductName, Price from Products WHERE ProductName='" & name & "'", cn)
            Dim DTT As New DataTable
            ADPP.Fill(DTT)
            Me.DataGridSearch.DataSource = DTT
            Me.DataGridSearch.ReadOnly = True
            Me.DataGridSearch.ClearSelection()
            Me.DataGridSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.DataGridSearch.AutoResizeColumns()
            Me.DataGridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If


    End Sub
    Private Sub txtSearchID_Click(sender As Object, e As EventArgs) Handles txtSearchID.Click
        txtSearchID.Clear()
        txtSearchName.Text = "-Enter Keyword-"
    End Sub
    Private Sub txtSearchName_Click(sender As Object, e As EventArgs) Handles txtSearchName.Click
        txtSearchName.Clear()
        txtSearchID.Text = "-Enter Keyword-"
    End Sub
    Private Sub DataGridSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSearch.CellContentClick
        Refresh()
        SearchQuantity.Enabled = True
        btnAddSearch.Enabled = True
        Dim i As Integer = Me.DataGridSearch.CurrentRow.Index
        Me.ItemID = RTrim(Me.DataGridSearch.Rows(i).Cells(0).Value)
        Me.pName = RTrim(Me.DataGridSearch.Rows(i).Cells(1).Value)
        Me.pPrice = RTrim(Me.DataGridSearch.Rows(i).Cells(2).Value)
        lblpNameSearch.Text = pName
        lblpriceSearch.Text = pPrice
    End Sub

    Private Sub btnAddSearch_Click(sender As Object, e As EventArgs) Handles btnAddSearch.Click
        Refresh()
        If SearchQuantity.Text = "" Or SearchQuantity.Text = "-Quantity-" Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        ElseIf Convert.ToInt64(SearchQuantity.Text) < 1 Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        End If
        pQuantity = SearchQuantity.Text
        tPrice = pPrice * pQuantity

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Temp WHERE ProductName='" & pName & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridView1.DataSource = DT
        Dim cQuantity As String = RTrim(Me.DataGridView1.Rows(0).Cells(4).Value)
        Dim cTotal As String = RTrim(Me.DataGridView1.Rows(0).Cells(3).Value)

        If DT.Rows.Count >= 1 Then
            tPrice = tPrice + Convert.ToInt64(cTotal)
            pQuantity = pQuantity + Convert.ToInt64(cQuantity)
            cmd.CommandText = "UPDATE Temp SET Quantity='" & Me.pQuantity & "', TotalPrice='" & Me.tPrice & " ' WHERE ProductName='" & Me.pName & "' "
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = "INSERT INTO Temp (ItemID, ProductName, UnitPrice, TotalPrice, Quantity) " & "VALUES('" & Me.ItemID & "','" & Me.pName & "','" & Me.pPrice & "','" & Me.tPrice & "','" & Me.pQuantity & "')"
            cmd.ExecuteNonQuery()
        End If
        cn.Close()
        DataGridView1.Visible = False
        MsgBox("Order Added Successfully!", vbInformation, "Notification")
        DataGridSearch.ClearSelection()
        DataGridView1.ClearSelection()
        Me.ItemID = 0
        Me.pName = 0
        Me.pPrice = 0
        btnAddSearch.Enabled = False
        SearchQuantity.Text = "-Quantity-"
        SearchQuantity.Enabled = False
        lblpNameSearch.Text = "___________"
        lblpriceSearch.Text = "________"
    End Sub

    'CART
    Private Sub DataGridMyCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMyCart.CellContentClick
        Refresh()
        CartQuantity.Enabled = True
        btnRemoveCart.Enabled = True
        Dim i As Integer = Me.DataGridMyCart.CurrentRow.Index
        Me.ItemID = RTrim(Me.DataGridMyCart.Rows(i).Cells(0).Value)
        Me.pName = RTrim(Me.DataGridMyCart.Rows(i).Cells(1).Value)
        Me.pPrice = RTrim(Me.DataGridMyCart.Rows(i).Cells(2).Value)
        Me.tPrice = RTrim(Me.DataGridMyCart.Rows(i).Cells(3).Value)
        Me.pQuantity = RTrim(Me.DataGridMyCart.Rows(i).Cells(4).Value)
        lblpNameCart.Text = pName
        lblpriceCart.Text = pPrice
    End Sub
    Private Sub btnRemoveCart_Click(sender As Object, e As EventArgs) Handles btnRemoveCart.Click
        Refresh()
        If CartQuantity.Text = "" Or CartQuantity.Text = "-Quantity-" Then
            MsgBox("Please enter Quantity!", vbCritical, "Warning!")
            Exit Sub
        ElseIf Convert.ToInt64(CartQuantity.Text) < 1 Or Convert.ToInt64(CartQuantity.Text) > pQuantity Then
            MsgBox("Please Enter Valid Quantity!", vbCritical, "Warning!")
            Exit Sub
        End If

        Dim cQuantity As String = pQuantity - Convert.ToInt64(CartQuantity.Text)
        Dim semi As Integer = (pPrice * Convert.ToInt64(CartQuantity.Text))
        tPrice = tPrice - semi

        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn
        If cQuantity <= 0 Then
            cmd.CommandText = "DELETE * from Temp WHERE ProductName='" & Me.pName & "' "
            cmd.ExecuteNonQuery()
        ElseIf cQuantity > 0 Then
            cmd.CommandText = "UPDATE Temp SET Quantity='" & cQuantity & "', TotalPrice='" & Me.tPrice & " ' WHERE ProductName='" & Me.pName & "' "
            cmd.ExecuteNonQuery()
        End If
        Refresh()
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Temp", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        DataGridMyCart.DataSource = DT
        cn.Close()
        MsgBox("Quantity Removed!", vbInformation, "Notification!")
        CartQuantity.Text = ""
        CartQuantity.Enabled = False
        lblpriceCart.Text = "________"
        lblpNameCart.Text = "___________"

        Cart()

    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If txtAmount.Text = "" Or txtAmount.Text = "-Enter Amount-" Then
            MsgBox("Please Enter Valid Amount!", vbCritical, "Warning!")
            Exit Sub
        ElseIf Convert.ToInt64(txtAmount.Text) < 1 Then
            MsgBox("Please Enter Valid Amount!", vbCritical, "Warning!")
            Exit Sub
        End If
        Dim amount As Integer = Convert.ToInt64(txtAmount.Text)
        Dim change As Integer = amount - pTotal
        If amount < pTotal Then
            MsgBox("The Amount you Entered is Insufficient!", vbCritical, "Warning!")
            Exit Sub
        ElseIf amount = pTotal Then
            MsgBox("Thank you for Purchasing with Us!", vbInformation, "Notification!")
        ElseIf amount > pTotal Then
            MsgBox("Thank you for Purchasing with Us!", vbInformation, "Notification!")
            MsgBox("Here is your Change: ₱" & change)
        End If

      
        
        Dim currentDate As DateTime = DateTime.Now
        Dim month As String = currentDate.Month
        Dim Year As String = currentDate.Year
        Dim receta As Integer
        Dim pNames(100) As String
        Dim receipt As String = Year & month & receta
        Dim pSales(100), qSales(100), pPrices(100) As String

        Dim ADP As New OleDb.OleDbDataAdapter
        Dim DT As New DataTable
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source =" & Application.StartupPath & "\Database.mdb"
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        cmd.Connection = cn


        Dim a As Integer

        Dim b As String = "True"
        While b = "True"
            ADP = New OleDb.OleDbDataAdapter("Select * from Receipt WHERE ReceiptID='" & receipt & "'", cn)
            DT = New DataTable
            ADP.Fill(DT)
            If DT.Rows.Count >= 1 Then
                receta = receta + 1
                receipt = Year & month & receta
            Else
                b = "False"
            End If
        End While

        ADP = New OleDb.OleDbDataAdapter("Select * from Temp", cn)
        DT = New DataTable
        ADP.Fill(DT)
        Me.DataGridView1.DataSource = DT
        While a < DT.Rows.Count
            pNames(a) = RTrim(Me.DataGridView1.Rows(a).Cells(1).Value)
            pPrices(a) = RTrim(Me.DataGridView1.Rows(a).Cells(2).Value)
            pSales(a) = RTrim(Me.DataGridView1.Rows(a).Cells(3).Value)
            qSales(a) = RTrim(Me.DataGridView1.Rows(a).Cells(4).Value)

         
            cmd.CommandText = "INSERT INTO Receipt(ReceiptID, ProductName, UnitPrice, TotalSales, TotalQuantity, cMonth, cYear)" & "Values('" & receipt & "','" & pNames(a) & "','" & pPrices(a) & "','" & pSales(a) & "','" & qSales(a) & "','" & month & "','" & Year & "')"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "UPDATE Products SET PSales='" & pSales(a) & "', QSales='" & qSales(a) & "' WHERE ProductName='" & pNames(a) & "' "
            cmd.ExecuteNonQuery()
            a = a + 1
        End While
        cmd.CommandText = "INSERT INTO ReceiptDetails(ReceiptID, TotalDue, AmountPayment, Change, TotalQuantity, cMonth, cYear)" & "Values('" & receipt & "','" & pTotal & "','" & amount & "','" & change & "','" & qTotal & "','" & month & "','" & Year & "')"
        cmd.ExecuteNonQuery()
        change = 0
        pTotal = 0
        qTotal = 0
        amount = 0
        lblTotal.Text = ""
        lblQuantity.Text = ""
        ClearTemp()
        ADP = New OleDb.OleDbDataAdapter("Select * from Temp", cn)
        DT = New DataTable
        ADP.Fill(DT)
        Me.DataGridMyCart.DataSource = DT
        Me.DataGridMyCart.ReadOnly = True
        Me.DataGridMyCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMyCart.AutoResizeColumns()
        Me.DataGridMyCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridMyCart.ClearSelection()
        cn.Close()

        txtAmount.Text = "-Enter Amount-"
        While a < 100
            pNames(a) = ""
            pPrices(a) = ""
            pSales(a) = ""
            qSales(a) = ""
            receipt = ""
            receta = 0
            a = a + 1
        End While



    End Sub


    Private Sub txtSearchName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchName.KeyDown, txtSearchID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnSearch.PerformClick()
        End If

    End Sub
End Class
