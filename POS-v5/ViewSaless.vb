Public Class ViewSaless
    'Database
    Dim cn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim month As String
    

    Private Sub ViewSaless_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabView.SendToBack()
        ActiveMonthly.Hide()
        ActiveSearch.Hide()
        ActiveReceipts.Hide()

        btnOverAll.BackColor = Color.DarkOrange

    End Sub

    Private Sub btnOverAll_Click(sender As Object, e As EventArgs) Handles btnOverAll.Click
        ActiveOverall.Show()
        ActiveMonthly.Hide()
        ActiveSearch.Hide()
        ActiveReceipts.Hide()

        tabView.SelectedIndex = 0

        btnOverAll.BackColor = Color.DarkOrange
        btnMonthly.BackColor = Color.Chocolate
        btnSearchReceipt.BackColor = Color.Chocolate
        btnAllReceipt.BackColor = Color.Chocolate

    End Sub
    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        ActiveOverall.Hide()
        ActiveMonthly.Show()
        ActiveSearch.Hide()
        ActiveReceipts.Hide()

        tabView.SelectedIndex = 1

        btnOverAll.BackColor = Color.Chocolate
        btnMonthly.BackColor = Color.DarkOrange
        btnSearchReceipt.BackColor = Color.Chocolate
        btnAllReceipt.BackColor = Color.Chocolate

    End Sub
    Private Sub btnSearchReceipt_Click(sender As Object, e As EventArgs) Handles btnSearchReceipt.Click
        ActiveOverall.Hide()
        ActiveMonthly.Hide()
        ActiveSearch.Show()
        ActiveReceipts.Hide()

        tabView.SelectedIndex = 2

        btnOverAll.BackColor = Color.Chocolate
        btnMonthly.BackColor = Color.Chocolate
        btnSearchReceipt.BackColor = Color.DarkOrange
        btnAllReceipt.BackColor = Color.Chocolate

    End Sub
    Private Sub btnAllReceipt_Click(sender As Object, e As EventArgs) Handles btnAllReceipt.Click
        ActiveOverall.Hide()
        ActiveMonthly.Hide()
        ActiveSearch.Hide()
        ActiveReceipts.Show()

        tabView.SelectedIndex = 3

        btnOverAll.BackColor = Color.Chocolate
        btnMonthly.BackColor = Color.Chocolate
        btnSearchReceipt.BackColor = Color.Chocolate
        btnAllReceipt.BackColor = Color.DarkOrange
        AllReceipts()

    End Sub

    Private Sub AllReceipts()
        Dim cn As New OleDb.OleDbConnection
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "/Database.mdb"

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()

        Dim ADP As New OleDb.OleDbDataAdapter("Select * from ReceiptDetails", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        Me.DataGridTransactions.DataSource = DT
        Me.DataGridTransactions.ReadOnly = True
        Me.DataGridTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridTransactions.AutoResizeColumns()
    End Sub

    'OPTIONS BUTTONS
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Hide()
        AdminChoices.Show()
    End Sub

    Private Sub cmbMonth_Click(sender As Object, e As EventArgs) Handles cmbMonth.Click
        If cmbMonth.Items.Contains("January") Then
            Exit Sub
        Else
            cmbMonth.Items.Add("January")
            cmbMonth.Items.Add("February")
            cmbMonth.Items.Add("March")
            cmbMonth.Items.Add("April")
            cmbMonth.Items.Add("May")
            cmbMonth.Items.Add("June")
            cmbMonth.Items.Add("July")
            cmbMonth.Items.Add("August")
            cmbMonth.Items.Add("September")
            cmbMonth.Items.Add("October")
            cmbMonth.Items.Add("November")
            cmbMonth.Items.Add("December")
        End If
        End Sub
    Private Sub cmbYear_Click(sender As Object, e As EventArgs) Handles cmbYear.Click
        If cmbYear.Items.Contains("2019") Then
            Exit Sub
        Else
            cmbYear.Items.Add("2019")
            cmbYear.Items.Add("2020")
            cmbYear.Items.Add("2021")
            cmbYear.Items.Add("2022")
            cmbYear.Items.Add("2023")
            cmbYear.Items.Add("2024")
            cmbYear.Items.Add("2025")
            cmbYear.Items.Add("2026")
            cmbYear.Items.Add("2027")
            cmbYear.Items.Add("2028")
            cmbYear.Items.Add("2029")
            cmbYear.Items.Add("2030")
        End If
        End Sub
    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        btnView.Enabled = True
    End Sub

    Private Sub btnViewOverall_Click(sender As Object, e As EventArgs) Handles btnViewOverall.Click
        Dim cn As New OleDb.OleDbConnection
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "/Database.mdb"

        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Products ORDER BY Category", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        Me.DataGridViewSales.ReadOnly = True
        Me.DataGridViewSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewSales.AutoResizeColumns()
        Me.DataGridViewSales.DataSource = DT
        Dim pQSales(100) As Integer
        Dim pPSales(100) As Integer
        Dim a As Integer
        While a < DT.Rows.Count
            pPSales(a) = RTrim(Me.DataGridViewSales.Rows(a).Cells(3).Value)
            pQSales(a) = RTrim(Me.DataGridViewSales.Rows(a).Cells(4).Value)

            a = a + 1
        End While
        Dim sum As Integer
        For Each item In pPSales
            sum += item
        Next
        OverSales.Text = sum
        Dim q As Integer
        For Each item In pQSales
            q += item
        Next
        OverQuantity.Text = q

        cn.Close()


    End Sub


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        MsgBox("Here is the Result", vbInformation, "Notification!")

        If cmbMonth.SelectedIndex = 0 Then
            month = 1
        ElseIf cmbMonth.SelectedIndex = 1 Then
            month = 2
        ElseIf cmbMonth.SelectedIndex = 2 Then
            month = 3
        ElseIf cmbMonth.SelectedIndex = 3 Then
            month = 4
        ElseIf cmbMonth.SelectedIndex = 4 Then
            month = 5
        ElseIf cmbMonth.SelectedIndex = 5 Then
            month = 6
        ElseIf cmbMonth.SelectedIndex = 6 Then
            month = 7
        ElseIf cmbMonth.SelectedIndex = 7 Then
            month = 8
        ElseIf cmbMonth.SelectedIndex = 8 Then
            month = 9
        ElseIf cmbMonth.SelectedIndex = 9 Then
            month = 10
        ElseIf cmbMonth.SelectedIndex = 10 Then
            month = 11
        ElseIf cmbMonth.SelectedIndex = 11 Then
            month = 12
        Else
            MsgBox("You Haven't Selected Anything", vbExclamation, "Warning!")
            Exit Sub
        End If
        Dim year As String = cmbYear.Text

        Dim cn As New OleDb.OleDbConnection
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "/Database.mdb"

        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Dim ADP As New OleDb.OleDbDataAdapter("Select ReceiptID, ProductName, UnitPrice, TotalSales, TotalQuantity from Receipt WHERE cMonth='" & month & "' And cYear='" & year & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        Me.DataGridMonthly.DataSource = DT
        Me.DataGridMonthly.ReadOnly = True
        Me.DataGridMonthly.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMonthly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridMonthly.AutoResizeColumns()
        Me.DataGridMonthly.DataSource = DT
        Dim a As Integer
        Dim PSales(100), QSales(100) As Integer
        While a < DT.Rows.Count
            PSales(a) = RTrim(Me.DataGridMonthly.Rows(a).Cells(3).Value)
            QSales(a) = RTrim(Me.DataGridMonthly.Rows(a).Cells(4).Value)
            a = a + 1
        End While
        Dim sum As Integer
        For Each item In PSales
            sum += item
        Next
        MonthlySales.Text = sum
        Dim q As Integer
        For Each item In QSales
            q += item
        Next
        MonthlyQuantity.Text = q

    End Sub


    Private Sub txtReceiptID_Click(sender As Object, e As EventArgs) Handles txtReceiptID.Click
        txtReceiptID.Clear()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        MsgBox("Here is the Result", vbInformation, "Notification!")

        Dim receiptID As String = txtReceiptID.Text

        Dim cn As New OleDb.OleDbConnection
        cn = New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "/Database.mdb"

        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Dim ADP As New OleDb.OleDbDataAdapter("Select * from Receipt Where ReceiptID='" & receiptID & "'", cn)
        Dim DT As New DataTable
        ADP.Fill(DT)
        Me.DataGridReceipt.DataSource = DT
        Me.DataGridReceipt.ReadOnly = True
        Me.DataGridReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridReceipt.AutoResizeColumns()
        ADP = New OleDb.OleDbDataAdapter("Select * from ReceiptDetails WHERE ReceiptID='" & receiptID & "'", cn)
        DT = New DataTable
        ADP.Fill(DT)
        Me.DataGridReceiptDetails.DataSource = DT
        Me.DataGridReceiptDetails.ReadOnly = True
        Me.DataGridReceiptDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.DataGridReceiptDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridReceiptDetails.AutoResizeColumns()




    End Sub


End Class