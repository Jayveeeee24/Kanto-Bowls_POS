<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProducts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMenu = New System.Windows.Forms.TextBox()
        Me.txtUserType = New System.Windows.Forms.Label()
        Me.ActiveAdd = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ActiveDelete = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ActiveEdit = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.tabManage = New System.Windows.Forms.TabControl()
        Me.tabAdd = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdds = New System.Windows.Forms.Button()
        Me.AddpPrice = New System.Windows.Forms.TextBox()
        Me.AddpName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.DataGridEdit = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.NewPrice = New System.Windows.Forms.TextBox()
        Me.NewName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tabDelete = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblpName = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.DataGridDelete = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.tabManage.SuspendLayout()
        Me.tabAdd.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEdit.SuspendLayout()
        CType(Me.DataGridEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.tabDelete.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(199, 63)
        Me.Panel4.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bradley Hand ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Filipino Bowl Paborito!"
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.btnPrevious)
        Me.panelHeader.Controls.Add(Me.btnClose)
        Me.panelHeader.Controls.Add(Me.Panel1)
        Me.panelHeader.Controls.Add(Me.txtMenu)
        Me.panelHeader.Controls.Add(Me.txtUserType)
        Me.panelHeader.Location = New System.Drawing.Point(199, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(492, 71)
        Me.panelHeader.TabIndex = 31
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(452, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(472, 0)
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
        'txtMenu
        '
        Me.txtMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMenu.Font = New System.Drawing.Font("Britannic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenu.ForeColor = System.Drawing.Color.Black
        Me.txtMenu.Location = New System.Drawing.Point(0, 20)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(474, 33)
        Me.txtMenu.TabIndex = 61
        Me.txtMenu.Text = "MANAGE PRODUCTS"
        Me.txtMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserType
        '
        Me.txtUserType.Font = New System.Drawing.Font("Bradley Hand ITC", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserType.Location = New System.Drawing.Point(241, 50)
        Me.txtUserType.Name = "txtUserType"
        Me.txtUserType.Size = New System.Drawing.Size(251, 20)
        Me.txtUserType.TabIndex = 74
        Me.txtUserType.Text = " "
        '
        'ActiveAdd
        '
        Me.ActiveAdd.AccessibleDescription = ""
        Me.ActiveAdd.BackColor = System.Drawing.Color.Sienna
        Me.ActiveAdd.Location = New System.Drawing.Point(0, 32)
        Me.ActiveAdd.Name = "ActiveAdd"
        Me.ActiveAdd.Size = New System.Drawing.Size(7, 55)
        Me.ActiveAdd.TabIndex = 56
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Sienna
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(0, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(199, 55)
        Me.btnAdd.TabIndex = 55
        Me.btnAdd.Text = "Add Products"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel9.Controls.Add(Me.ActiveDelete)
        Me.Panel9.Controls.Add(Me.btnDelete)
        Me.Panel9.Controls.Add(Me.ActiveEdit)
        Me.Panel9.Controls.Add(Me.btnEdit)
        Me.Panel9.Controls.Add(Me.ActiveAdd)
        Me.Panel9.Controls.Add(Me.btnAdd)
        Me.Panel9.Location = New System.Drawing.Point(0, 69)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(199, 249)
        Me.Panel9.TabIndex = 73
        '
        'ActiveDelete
        '
        Me.ActiveDelete.AccessibleDescription = ""
        Me.ActiveDelete.BackColor = System.Drawing.Color.Sienna
        Me.ActiveDelete.Location = New System.Drawing.Point(0, 174)
        Me.ActiveDelete.Name = "ActiveDelete"
        Me.ActiveDelete.Size = New System.Drawing.Size(7, 55)
        Me.ActiveDelete.TabIndex = 60
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Sienna
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(0, 174)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(199, 55)
        Me.btnDelete.TabIndex = 59
        Me.btnDelete.Text = "Delete Products"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ActiveEdit
        '
        Me.ActiveEdit.AccessibleDescription = ""
        Me.ActiveEdit.BackColor = System.Drawing.Color.Sienna
        Me.ActiveEdit.Location = New System.Drawing.Point(0, 103)
        Me.ActiveEdit.Name = "ActiveEdit"
        Me.ActiveEdit.Size = New System.Drawing.Size(7, 55)
        Me.ActiveEdit.TabIndex = 58
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Sienna
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(0, 103)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(199, 55)
        Me.btnEdit.TabIndex = 57
        Me.btnEdit.Text = "Edit Products"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'tabManage
        '
        Me.tabManage.Controls.Add(Me.tabAdd)
        Me.tabManage.Controls.Add(Me.tabEdit)
        Me.tabManage.Controls.Add(Me.tabDelete)
        Me.tabManage.Location = New System.Drawing.Point(199, 43)
        Me.tabManage.Name = "tabManage"
        Me.tabManage.SelectedIndex = 0
        Me.tabManage.Size = New System.Drawing.Size(492, 275)
        Me.tabManage.TabIndex = 60
        '
        'tabAdd
        '
        Me.tabAdd.BackColor = System.Drawing.Color.DarkOrange
        Me.tabAdd.Controls.Add(Me.DataGridView1)
        Me.tabAdd.Controls.Add(Me.btnAdds)
        Me.tabAdd.Controls.Add(Me.AddpPrice)
        Me.tabAdd.Controls.Add(Me.AddpName)
        Me.tabAdd.Controls.Add(Me.Label6)
        Me.tabAdd.Controls.Add(Me.cbCategory)
        Me.tabAdd.Controls.Add(Me.cbType)
        Me.tabAdd.Controls.Add(Me.Panel6)
        Me.tabAdd.Location = New System.Drawing.Point(4, 22)
        Me.tabAdd.Name = "tabAdd"
        Me.tabAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdd.Size = New System.Drawing.Size(484, 249)
        Me.tabAdd.TabIndex = 0
        Me.tabAdd.Text = "Add"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(383, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(51, 19)
        Me.DataGridView1.TabIndex = 102
        Me.DataGridView1.Visible = False
        '
        'btnAdds
        '
        Me.btnAdds.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdds.Enabled = False
        Me.btnAdds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdds.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdds.ForeColor = System.Drawing.Color.White
        Me.btnAdds.Location = New System.Drawing.Point(169, 167)
        Me.btnAdds.Name = "btnAdds"
        Me.btnAdds.Size = New System.Drawing.Size(124, 50)
        Me.btnAdds.TabIndex = 101
        Me.btnAdds.Text = "Add"
        Me.btnAdds.UseVisualStyleBackColor = False
        '
        'AddpPrice
        '
        Me.AddpPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddpPrice.Enabled = False
        Me.AddpPrice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddpPrice.Location = New System.Drawing.Point(266, 119)
        Me.AddpPrice.Multiline = True
        Me.AddpPrice.Name = "AddpPrice"
        Me.AddpPrice.Size = New System.Drawing.Size(171, 24)
        Me.AddpPrice.TabIndex = 100
        Me.AddpPrice.Text = "-Enter Product Price-"
        Me.AddpPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddpName
        '
        Me.AddpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddpName.Enabled = False
        Me.AddpName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddpName.Location = New System.Drawing.Point(264, 80)
        Me.AddpName.Multiline = True
        Me.AddpName.Name = "AddpName"
        Me.AddpName.Size = New System.Drawing.Size(171, 24)
        Me.AddpName.TabIndex = 99
        Me.AddpName.Text = "-Enter Product Name-"
        Me.AddpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bradley Hand ITC", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(164, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 30)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Add Product"
        '
        'cbCategory
        '
        Me.cbCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbCategory.Enabled = False
        Me.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(30, 119)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(161, 24)
        Me.cbCategory.TabIndex = 75
        Me.cbCategory.Text = "-Choose a Category-"
        '
        'cbType
        '
        Me.cbType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.Location = New System.Drawing.Point(30, 79)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(161, 24)
        Me.cbType.TabIndex = 74
        Me.cbType.Text = "-Choose Type-"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(-1, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(485, 6)
        Me.Panel6.TabIndex = 73
        '
        'tabEdit
        '
        Me.tabEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.tabEdit.Controls.Add(Me.DataGridEdit)
        Me.tabEdit.Controls.Add(Me.GroupBox2)
        Me.tabEdit.Controls.Add(Me.Label2)
        Me.tabEdit.Controls.Add(Me.Panel5)
        Me.tabEdit.Location = New System.Drawing.Point(4, 22)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEdit.Size = New System.Drawing.Size(484, 249)
        Me.tabEdit.TabIndex = 1
        Me.tabEdit.Text = "Edit"
        '
        'DataGridEdit
        '
        Me.DataGridEdit.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridEdit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEdit.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridEdit.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridEdit.GridColor = System.Drawing.Color.DarkOrange
        Me.DataGridEdit.Location = New System.Drawing.Point(17, 42)
        Me.DataGridEdit.Name = "DataGridEdit"
        Me.DataGridEdit.Size = New System.Drawing.Size(277, 176)
        Me.DataGridEdit.TabIndex = 118
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.NewPrice)
        Me.GroupBox2.Controls.Add(Me.NewName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(313, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 181)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(36, 129)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 32)
        Me.btnSave.TabIndex = 115
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'NewPrice
        '
        Me.NewPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewPrice.Enabled = False
        Me.NewPrice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPrice.Location = New System.Drawing.Point(8, 94)
        Me.NewPrice.Multiline = True
        Me.NewPrice.Name = "NewPrice"
        Me.NewPrice.Size = New System.Drawing.Size(140, 23)
        Me.NewPrice.TabIndex = 112
        Me.NewPrice.Text = "-Enter Price-"
        Me.NewPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewName
        '
        Me.NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewName.Enabled = False
        Me.NewName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewName.Location = New System.Drawing.Point(8, 44)
        Me.NewName.Multiline = True
        Me.NewName.Name = "NewName"
        Me.NewName.Size = New System.Drawing.Size(140, 23)
        Me.NewName.TabIndex = 111
        Me.NewName.Text = "-Product Name-"
        Me.NewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DarkOrange
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "New Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DarkOrange
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "New Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bradley Hand ITC", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(155, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 30)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Edit Product"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(-1, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(489, 6)
        Me.Panel5.TabIndex = 74
        '
        'tabDelete
        '
        Me.tabDelete.BackColor = System.Drawing.Color.DarkOrange
        Me.tabDelete.Controls.Add(Me.GroupBox4)
        Me.tabDelete.Controls.Add(Me.btnDel)
        Me.tabDelete.Controls.Add(Me.DataGridDelete)
        Me.tabDelete.Controls.Add(Me.Label3)
        Me.tabDelete.Controls.Add(Me.Panel7)
        Me.tabDelete.Location = New System.Drawing.Point(4, 22)
        Me.tabDelete.Name = "tabDelete"
        Me.tabDelete.Size = New System.Drawing.Size(484, 249)
        Me.tabDelete.TabIndex = 2
        Me.tabDelete.Text = "Delete"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lblItemID)
        Me.GroupBox4.Controls.Add(Me.lblprice)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lblpName)
        Me.GroupBox4.Location = New System.Drawing.Point(319, 46)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 150)
        Me.GroupBox4.TabIndex = 122
        Me.GroupBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Item ID"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.BackColor = System.Drawing.Color.DarkOrange
        Me.lblItemID.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.ForeColor = System.Drawing.Color.White
        Me.lblItemID.Location = New System.Drawing.Point(18, 36)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(118, 18)
        Me.lblItemID.TabIndex = 92
        Me.lblItemID.Text = "___________"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.BackColor = System.Drawing.Color.DarkOrange
        Me.lblprice.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.ForeColor = System.Drawing.Color.White
        Me.lblprice.Location = New System.Drawing.Point(22, 122)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(108, 18)
        Me.lblprice.TabIndex = 90
        Me.lblprice.Text = "__________"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DarkOrange
        Me.Label18.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(18, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 18)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Product Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DarkOrange
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(22, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 18)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Unit Price"
        '
        'lblpName
        '
        Me.lblpName.AutoSize = True
        Me.lblpName.BackColor = System.Drawing.Color.DarkOrange
        Me.lblpName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpName.ForeColor = System.Drawing.Color.White
        Me.lblpName.Location = New System.Drawing.Point(20, 80)
        Me.lblpName.Name = "lblpName"
        Me.lblpName.Size = New System.Drawing.Size(118, 18)
        Me.lblpName.TabIndex = 88
        Me.lblpName.Text = "___________"
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Enabled = False
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Location = New System.Drawing.Point(203, 208)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(92, 32)
        Me.btnDel.TabIndex = 121
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'DataGridDelete
        '
        Me.DataGridDelete.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.DataGridDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDelete.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDelete.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OrangeRed
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridDelete.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridDelete.GridColor = System.Drawing.Color.DarkOrange
        Me.DataGridDelete.Location = New System.Drawing.Point(14, 46)
        Me.DataGridDelete.Name = "DataGridDelete"
        Me.DataGridDelete.Size = New System.Drawing.Size(299, 152)
        Me.DataGridDelete.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bradley Hand ITC", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(161, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 30)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Delete Product"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(-2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(490, 6)
        Me.Panel7.TabIndex = 74
        '
        'ManageProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 317)
        Me.Controls.Add(Me.tabManage)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ManageProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageProducts"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.tabManage.ResumeLayout(False)
        Me.tabAdd.ResumeLayout(False)
        Me.tabAdd.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEdit.ResumeLayout(False)
        Me.tabEdit.PerformLayout()
        CType(Me.DataGridEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabDelete.ResumeLayout(False)
        Me.tabDelete.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ActiveAdd As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ActiveDelete As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ActiveEdit As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents tabManage As System.Windows.Forms.TabControl
    Friend WithEvents tabAdd As System.Windows.Forms.TabPage
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents tabDelete As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtMenu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents cbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AddpPrice As System.Windows.Forms.TextBox
    Friend WithEvents AddpName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdds As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NewName As System.Windows.Forms.TextBox
    Friend WithEvents NewPrice As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridEdit As System.Windows.Forms.DataGridView
    Friend WithEvents txtUserType As System.Windows.Forms.Label
    Friend WithEvents DataGridDelete As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblpName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblItemID As System.Windows.Forms.Label
End Class
