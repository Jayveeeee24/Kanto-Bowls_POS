<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSaless
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSaless))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.txtUserType = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.DataGridViewSales = New System.Windows.Forms.DataGridView()
        Me.btnViewOverall = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabView = New System.Windows.Forms.TabControl()
        Me.tabOverAllSales = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OverQuantity = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OverSales = New System.Windows.Forms.Label()
        Me.tabMonthlySales = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthlyQuantity = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MonthlySales = New System.Windows.Forms.Label()
        Me.DataGridMonthly = New System.Windows.Forms.DataGridView()
        Me.tabSearchReceipt = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridReceiptDetails = New System.Windows.Forms.DataGridView()
        Me.DataGridReceipt = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtReceiptID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tabAllReceipt = New System.Windows.Forms.TabPage()
        Me.DataGridTransactions = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ActiveSearch = New System.Windows.Forms.Panel()
        Me.btnSearchReceipt = New System.Windows.Forms.Button()
        Me.ActiveMonthly = New System.Windows.Forms.Panel()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.ActiveOverall = New System.Windows.Forms.Panel()
        Me.btnOverAll = New System.Windows.Forms.Button()
        Me.ActiveReceipts = New System.Windows.Forms.Panel()
        Me.btnAllReceipt = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panelHeader.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabView.SuspendLayout()
        Me.tabOverAllSales.SuspendLayout()
        Me.tabMonthlySales.SuspendLayout()
        CType(Me.DataGridMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearchReceipt.SuspendLayout()
        CType(Me.DataGridReceiptDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tabAllReceipt.SuspendLayout()
        CType(Me.DataGridTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.Label11)
        Me.panelHeader.Controls.Add(Me.txtUserType)
        Me.panelHeader.Controls.Add(Me.btnPrevious)
        Me.panelHeader.Controls.Add(Me.btnClose)
        Me.panelHeader.Controls.Add(Me.Panel1)
        Me.panelHeader.Location = New System.Drawing.Point(198, -1)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(528, 63)
        Me.panelHeader.TabIndex = 67
        '
        'txtUserType
        '
        Me.txtUserType.Font = New System.Drawing.Font("Bradley Hand ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserType.Location = New System.Drawing.Point(279, 39)
        Me.txtUserType.Name = "txtUserType"
        Me.txtUserType.Size = New System.Drawing.Size(251, 20)
        Me.txtUserType.TabIndex = 76
        Me.txtUserType.Text = " "
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(485, 3)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(20, 20)
        Me.btnPrevious.TabIndex = 59
        Me.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(505, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 33
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(2, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 8)
        Me.Panel1.TabIndex = 58
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Location = New System.Drawing.Point(-1, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(199, 63)
        Me.Panel4.TabIndex = 66
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Bradley Hand ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(11, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 59
        Me.TextBox1.Text = "Filipino Bowl Paborito!"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.Enabled = False
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(36, 112)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(97, 34)
        Me.btnView.TabIndex = 73
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(47, 70)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(76, 22)
        Me.cmbYear.TabIndex = 72
        Me.cmbYear.Text = "-Year-"
        '
        'cmbMonth
        '
        Me.cmbMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMonth.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(47, 31)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(76, 22)
        Me.cmbMonth.TabIndex = 71
        Me.cmbMonth.Text = "-Month-"
        '
        'DataGridViewSales
        '
        Me.DataGridViewSales.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewSales.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewSales.GridColor = System.Drawing.Color.DarkOrange
        Me.DataGridViewSales.Location = New System.Drawing.Point(32, 15)
        Me.DataGridViewSales.Name = "DataGridViewSales"
        Me.DataGridViewSales.Size = New System.Drawing.Size(455, 221)
        Me.DataGridViewSales.TabIndex = 69
        '
        'btnViewOverall
        '
        Me.btnViewOverall.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnViewOverall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewOverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewOverall.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOverall.ForeColor = System.Drawing.Color.White
        Me.btnViewOverall.Location = New System.Drawing.Point(173, 304)
        Me.btnViewOverall.Name = "btnViewOverall"
        Me.btnViewOverall.Size = New System.Drawing.Size(173, 34)
        Me.btnViewOverall.TabIndex = 74
        Me.btnViewOverall.Text = "View Overall Sales"
        Me.btnViewOverall.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.cmbMonth)
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(337, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 167)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monthly Sales"
        '
        'tabView
        '
        Me.tabView.Controls.Add(Me.tabOverAllSales)
        Me.tabView.Controls.Add(Me.tabMonthlySales)
        Me.tabView.Controls.Add(Me.tabSearchReceipt)
        Me.tabView.Controls.Add(Me.tabAllReceipt)
        Me.tabView.Location = New System.Drawing.Point(198, 38)
        Me.tabView.Name = "tabView"
        Me.tabView.SelectedIndex = 0
        Me.tabView.Size = New System.Drawing.Size(528, 379)
        Me.tabView.TabIndex = 76
        '
        'tabOverAllSales
        '
        Me.tabOverAllSales.BackColor = System.Drawing.Color.DarkOrange
        Me.tabOverAllSales.Controls.Add(Me.Panel7)
        Me.tabOverAllSales.Controls.Add(Me.Label1)
        Me.tabOverAllSales.Controls.Add(Me.OverQuantity)
        Me.tabOverAllSales.Controls.Add(Me.Label4)
        Me.tabOverAllSales.Controls.Add(Me.OverSales)
        Me.tabOverAllSales.Controls.Add(Me.DataGridViewSales)
        Me.tabOverAllSales.Controls.Add(Me.btnViewOverall)
        Me.tabOverAllSales.Location = New System.Drawing.Point(4, 22)
        Me.tabOverAllSales.Name = "tabOverAllSales"
        Me.tabOverAllSales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOverAllSales.Size = New System.Drawing.Size(520, 353)
        Me.tabOverAllSales.TabIndex = 0
        Me.tabOverAllSales.Text = "OverAll Sales"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(524, 6)
        Me.Panel7.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(276, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Total Quantity"
        '
        'OverQuantity
        '
        Me.OverQuantity.AutoSize = True
        Me.OverQuantity.BackColor = System.Drawing.Color.DarkOrange
        Me.OverQuantity.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverQuantity.ForeColor = System.Drawing.Color.White
        Me.OverQuantity.Location = New System.Drawing.Point(279, 273)
        Me.OverQuantity.Name = "OverQuantity"
        Me.OverQuantity.Size = New System.Drawing.Size(118, 18)
        Me.OverQuantity.TabIndex = 95
        Me.OverQuantity.Text = "___________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(136, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Total Sales"
        '
        'OverSales
        '
        Me.OverSales.AutoSize = True
        Me.OverSales.BackColor = System.Drawing.Color.DarkOrange
        Me.OverSales.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverSales.ForeColor = System.Drawing.Color.White
        Me.OverSales.Location = New System.Drawing.Point(126, 273)
        Me.OverSales.Name = "OverSales"
        Me.OverSales.Size = New System.Drawing.Size(118, 18)
        Me.OverSales.TabIndex = 93
        Me.OverSales.Text = "___________"
        '
        'tabMonthlySales
        '
        Me.tabMonthlySales.BackColor = System.Drawing.Color.DarkOrange
        Me.tabMonthlySales.Controls.Add(Me.Panel2)
        Me.tabMonthlySales.Controls.Add(Me.Label2)
        Me.tabMonthlySales.Controls.Add(Me.MonthlyQuantity)
        Me.tabMonthlySales.Controls.Add(Me.Label5)
        Me.tabMonthlySales.Controls.Add(Me.MonthlySales)
        Me.tabMonthlySales.Controls.Add(Me.DataGridMonthly)
        Me.tabMonthlySales.Controls.Add(Me.GroupBox1)
        Me.tabMonthlySales.Location = New System.Drawing.Point(4, 22)
        Me.tabMonthlySales.Name = "tabMonthlySales"
        Me.tabMonthlySales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMonthlySales.Size = New System.Drawing.Size(520, 353)
        Me.tabMonthlySales.TabIndex = 1
        Me.tabMonthlySales.Text = "Monthly Sales"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 6)
        Me.Panel2.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(269, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Total Quantity"
        '
        'MonthlyQuantity
        '
        Me.MonthlyQuantity.AutoSize = True
        Me.MonthlyQuantity.BackColor = System.Drawing.Color.DarkOrange
        Me.MonthlyQuantity.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlyQuantity.ForeColor = System.Drawing.Color.White
        Me.MonthlyQuantity.Location = New System.Drawing.Point(272, 302)
        Me.MonthlyQuantity.Name = "MonthlyQuantity"
        Me.MonthlyQuantity.Size = New System.Drawing.Size(118, 18)
        Me.MonthlyQuantity.TabIndex = 99
        Me.MonthlyQuantity.Text = "___________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkOrange
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(129, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Total Sales"
        '
        'MonthlySales
        '
        Me.MonthlySales.AutoSize = True
        Me.MonthlySales.BackColor = System.Drawing.Color.DarkOrange
        Me.MonthlySales.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlySales.ForeColor = System.Drawing.Color.White
        Me.MonthlySales.Location = New System.Drawing.Point(119, 302)
        Me.MonthlySales.Name = "MonthlySales"
        Me.MonthlySales.Size = New System.Drawing.Size(118, 18)
        Me.MonthlySales.TabIndex = 97
        Me.MonthlySales.Text = "___________"
        '
        'DataGridMonthly
        '
        Me.DataGridMonthly.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridMonthly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridMonthly.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridMonthly.GridColor = System.Drawing.Color.DarkOrange
        Me.DataGridMonthly.Location = New System.Drawing.Point(10, 14)
        Me.DataGridMonthly.Name = "DataGridMonthly"
        Me.DataGridMonthly.Size = New System.Drawing.Size(317, 243)
        Me.DataGridMonthly.TabIndex = 76
        '
        'tabSearchReceipt
        '
        Me.tabSearchReceipt.BackColor = System.Drawing.Color.DarkOrange
        Me.tabSearchReceipt.Controls.Add(Me.Panel3)
        Me.tabSearchReceipt.Controls.Add(Me.DataGridReceiptDetails)
        Me.tabSearchReceipt.Controls.Add(Me.DataGridReceipt)
        Me.tabSearchReceipt.Controls.Add(Me.GroupBox2)
        Me.tabSearchReceipt.Location = New System.Drawing.Point(4, 22)
        Me.tabSearchReceipt.Name = "tabSearchReceipt"
        Me.tabSearchReceipt.Size = New System.Drawing.Size(520, 353)
        Me.tabSearchReceipt.TabIndex = 2
        Me.tabSearchReceipt.Text = "Search Receipt"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(524, 6)
        Me.Panel3.TabIndex = 98
        '
        'DataGridReceiptDetails
        '
        Me.DataGridReceiptDetails.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridReceiptDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridReceiptDetails.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridReceiptDetails.Location = New System.Drawing.Point(30, 161)
        Me.DataGridReceiptDetails.Name = "DataGridReceiptDetails"
        Me.DataGridReceiptDetails.Size = New System.Drawing.Size(288, 149)
        Me.DataGridReceiptDetails.TabIndex = 89
        '
        'DataGridReceipt
        '
        Me.DataGridReceipt.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridReceipt.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridReceipt.Location = New System.Drawing.Point(30, 12)
        Me.DataGridReceipt.Name = "DataGridReceipt"
        Me.DataGridReceipt.Size = New System.Drawing.Size(288, 143)
        Me.DataGridReceipt.TabIndex = 88
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtReceiptID)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(334, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(174, 147)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search by Receipt ID"
        '
        'txtReceiptID
        '
        Me.txtReceiptID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceiptID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptID.Location = New System.Drawing.Point(22, 40)
        Me.txtReceiptID.Multiline = True
        Me.txtReceiptID.Name = "txtReceiptID"
        Me.txtReceiptID.Size = New System.Drawing.Size(140, 23)
        Me.txtReceiptID.TabIndex = 86
        Me.txtReceiptID.Text = "-Enter Keyword-"
        Me.txtReceiptID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(48, 80)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 45)
        Me.btnSearch.TabIndex = 84
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'tabAllReceipt
        '
        Me.tabAllReceipt.BackColor = System.Drawing.Color.DarkOrange
        Me.tabAllReceipt.Controls.Add(Me.DataGridTransactions)
        Me.tabAllReceipt.Controls.Add(Me.Panel5)
        Me.tabAllReceipt.Location = New System.Drawing.Point(4, 22)
        Me.tabAllReceipt.Name = "tabAllReceipt"
        Me.tabAllReceipt.Size = New System.Drawing.Size(520, 353)
        Me.tabAllReceipt.TabIndex = 3
        Me.tabAllReceipt.Text = "All Receipt"
        '
        'DataGridTransactions
        '
        Me.DataGridTransactions.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridTransactions.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridTransactions.Location = New System.Drawing.Point(18, 21)
        Me.DataGridTransactions.Name = "DataGridTransactions"
        Me.DataGridTransactions.Size = New System.Drawing.Size(485, 312)
        Me.DataGridTransactions.TabIndex = 99
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(-1, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(524, 6)
        Me.Panel5.TabIndex = 98
        '
        'ActiveSearch
        '
        Me.ActiveSearch.AccessibleDescription = ""
        Me.ActiveSearch.BackColor = System.Drawing.Color.Sienna
        Me.ActiveSearch.Location = New System.Drawing.Point(-1, 249)
        Me.ActiveSearch.Name = "ActiveSearch"
        Me.ActiveSearch.Size = New System.Drawing.Size(7, 55)
        Me.ActiveSearch.TabIndex = 82
        '
        'btnSearchReceipt
        '
        Me.btnSearchReceipt.BackColor = System.Drawing.Color.Sienna
        Me.btnSearchReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearchReceipt.FlatAppearance.BorderSize = 0
        Me.btnSearchReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchReceipt.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchReceipt.ForeColor = System.Drawing.Color.White
        Me.btnSearchReceipt.Image = CType(resources.GetObject("btnSearchReceipt.Image"), System.Drawing.Image)
        Me.btnSearchReceipt.Location = New System.Drawing.Point(-1, 249)
        Me.btnSearchReceipt.Name = "btnSearchReceipt"
        Me.btnSearchReceipt.Size = New System.Drawing.Size(199, 55)
        Me.btnSearchReceipt.TabIndex = 81
        Me.btnSearchReceipt.Text = "Search Receipt"
        Me.btnSearchReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchReceipt.UseVisualStyleBackColor = False
        '
        'ActiveMonthly
        '
        Me.ActiveMonthly.AccessibleDescription = ""
        Me.ActiveMonthly.BackColor = System.Drawing.Color.Sienna
        Me.ActiveMonthly.Location = New System.Drawing.Point(-1, 169)
        Me.ActiveMonthly.Name = "ActiveMonthly"
        Me.ActiveMonthly.Size = New System.Drawing.Size(7, 55)
        Me.ActiveMonthly.TabIndex = 80
        '
        'btnMonthly
        '
        Me.btnMonthly.BackColor = System.Drawing.Color.Sienna
        Me.btnMonthly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonthly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMonthly.FlatAppearance.BorderSize = 0
        Me.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMonthly.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.ForeColor = System.Drawing.Color.White
        Me.btnMonthly.Image = CType(resources.GetObject("btnMonthly.Image"), System.Drawing.Image)
        Me.btnMonthly.Location = New System.Drawing.Point(-1, 169)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(199, 55)
        Me.btnMonthly.TabIndex = 79
        Me.btnMonthly.Text = "Monthly Sales"
        Me.btnMonthly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMonthly.UseVisualStyleBackColor = False
        '
        'ActiveOverall
        '
        Me.ActiveOverall.AccessibleDescription = ""
        Me.ActiveOverall.BackColor = System.Drawing.Color.Sienna
        Me.ActiveOverall.Location = New System.Drawing.Point(-1, 89)
        Me.ActiveOverall.Name = "ActiveOverall"
        Me.ActiveOverall.Size = New System.Drawing.Size(7, 55)
        Me.ActiveOverall.TabIndex = 78
        '
        'btnOverAll
        '
        Me.btnOverAll.BackColor = System.Drawing.Color.Sienna
        Me.btnOverAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOverAll.FlatAppearance.BorderSize = 0
        Me.btnOverAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOverAll.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverAll.ForeColor = System.Drawing.Color.White
        Me.btnOverAll.Image = CType(resources.GetObject("btnOverAll.Image"), System.Drawing.Image)
        Me.btnOverAll.Location = New System.Drawing.Point(-1, 89)
        Me.btnOverAll.Name = "btnOverAll"
        Me.btnOverAll.Size = New System.Drawing.Size(199, 55)
        Me.btnOverAll.TabIndex = 77
        Me.btnOverAll.Text = " OverAll Sales"
        Me.btnOverAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOverAll.UseVisualStyleBackColor = False
        '
        'ActiveReceipts
        '
        Me.ActiveReceipts.AccessibleDescription = ""
        Me.ActiveReceipts.BackColor = System.Drawing.Color.Sienna
        Me.ActiveReceipts.Location = New System.Drawing.Point(-1, 329)
        Me.ActiveReceipts.Name = "ActiveReceipts"
        Me.ActiveReceipts.Size = New System.Drawing.Size(7, 55)
        Me.ActiveReceipts.TabIndex = 84
        '
        'btnAllReceipt
        '
        Me.btnAllReceipt.BackColor = System.Drawing.Color.Sienna
        Me.btnAllReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAllReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAllReceipt.FlatAppearance.BorderSize = 0
        Me.btnAllReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAllReceipt.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllReceipt.ForeColor = System.Drawing.Color.White
        Me.btnAllReceipt.Image = CType(resources.GetObject("btnAllReceipt.Image"), System.Drawing.Image)
        Me.btnAllReceipt.Location = New System.Drawing.Point(-1, 329)
        Me.btnAllReceipt.Name = "btnAllReceipt"
        Me.btnAllReceipt.Size = New System.Drawing.Size(199, 55)
        Me.btnAllReceipt.TabIndex = 83
        Me.btnAllReceipt.Text = "All Transactions"
        Me.btnAllReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllReceipt.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 21.75!)
        Me.Label11.Location = New System.Drawing.Point(152, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(209, 33)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Sales Report"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ViewSaless
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(727, 417)
        Me.Controls.Add(Me.ActiveReceipts)
        Me.Controls.Add(Me.btnAllReceipt)
        Me.Controls.Add(Me.ActiveSearch)
        Me.Controls.Add(Me.btnSearchReceipt)
        Me.Controls.Add(Me.ActiveMonthly)
        Me.Controls.Add(Me.btnMonthly)
        Me.Controls.Add(Me.ActiveOverall)
        Me.Controls.Add(Me.btnOverAll)
        Me.Controls.Add(Me.tabView)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewSaless"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewSaless"
        Me.panelHeader.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.tabView.ResumeLayout(False)
        Me.tabOverAllSales.ResumeLayout(False)
        Me.tabOverAllSales.PerformLayout()
        Me.tabMonthlySales.ResumeLayout(False)
        Me.tabMonthlySales.PerformLayout()
        CType(Me.DataGridMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearchReceipt.ResumeLayout(False)
        CType(Me.DataGridReceiptDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabAllReceipt.ResumeLayout(False)
        CType(Me.DataGridTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewSales As System.Windows.Forms.DataGridView
    Friend WithEvents btnViewOverall As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabView As System.Windows.Forms.TabControl
    Friend WithEvents tabOverAllSales As System.Windows.Forms.TabPage
    Friend WithEvents tabMonthlySales As System.Windows.Forms.TabPage
    Friend WithEvents ActiveSearch As System.Windows.Forms.Panel
    Friend WithEvents btnSearchReceipt As System.Windows.Forms.Button
    Friend WithEvents ActiveMonthly As System.Windows.Forms.Panel
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents ActiveOverall As System.Windows.Forms.Panel
    Friend WithEvents btnOverAll As System.Windows.Forms.Button
    Friend WithEvents txtUserType As System.Windows.Forms.Label
    Friend WithEvents tabSearchReceipt As System.Windows.Forms.TabPage
    Friend WithEvents tabAllReceipt As System.Windows.Forms.TabPage
    Friend WithEvents OverSales As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OverQuantity As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MonthlyQuantity As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MonthlySales As System.Windows.Forms.Label
    Friend WithEvents DataGridMonthly As System.Windows.Forms.DataGridView
    Friend WithEvents txtReceiptID As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridReceiptDetails As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridReceipt As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DataGridTransactions As System.Windows.Forms.DataGridView
    Friend WithEvents ActiveReceipts As System.Windows.Forms.Panel
    Friend WithEvents btnAllReceipt As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
