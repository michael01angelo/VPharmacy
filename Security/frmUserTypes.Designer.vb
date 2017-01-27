<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserTypes
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
        Me.tplContents = New System.Windows.Forms.TableLayoutPanel()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbTransactions = New System.Windows.Forms.GroupBox()
        Me.chbReturn = New System.Windows.Forms.CheckBox()
        Me.chbStockAdjustments = New System.Windows.Forms.CheckBox()
        Me.chbPointOfSales = New System.Windows.Forms.CheckBox()
        Me.chbReceive = New System.Windows.Forms.CheckBox()
        Me.chbPurchase = New System.Windows.Forms.CheckBox()
        Me.grbReports = New System.Windows.Forms.GroupBox()
        Me.chbStocks = New System.Windows.Forms.CheckBox()
        Me.chbSales = New System.Windows.Forms.CheckBox()
        Me.grbSecurity = New System.Windows.Forms.GroupBox()
        Me.chbUsers = New System.Windows.Forms.CheckBox()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvUserTypes = New System.Windows.Forms.DataGridView()
        Me.typeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbFileMaintenance = New System.Windows.Forms.GroupBox()
        Me.chbProducts = New System.Windows.Forms.CheckBox()
        Me.chbMiscellaneous = New System.Windows.Forms.CheckBox()
        Me.chbCategories = New System.Windows.Forms.CheckBox()
        Me.chbSuppliers = New System.Windows.Forms.CheckBox()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.chbExpirations = New System.Windows.Forms.CheckBox()
        Me.tplContents.SuspendLayout()
        Me.grbTransactions.SuspendLayout()
        Me.grbReports.SuspendLayout()
        Me.grbSecurity.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvUserTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFileMaintenance.SuspendLayout()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 3
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.tplContents.Controls.Add(Me.txtName, 2, 0)
        Me.tplContents.Controls.Add(Me.Label1, 1, 0)
        Me.tplContents.Controls.Add(Me.grbTransactions, 2, 1)
        Me.tplContents.Controls.Add(Me.grbReports, 1, 2)
        Me.tplContents.Controls.Add(Me.grbSecurity, 2, 2)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 3)
        Me.tplContents.Controls.Add(Me.dgvUserTypes, 0, 0)
        Me.tplContents.Controls.Add(Me.grbFileMaintenance, 1, 1)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 4
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.Size = New System.Drawing.Size(660, 415)
        Me.tplContents.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LightGreen
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(412, 0)
        Me.txtName.Margin = New System.Windows.Forms.Padding(0)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(248, 27)
        Me.txtName.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 27)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "User Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbTransactions
        '
        Me.grbTransactions.Controls.Add(Me.chbReturn)
        Me.grbTransactions.Controls.Add(Me.chbStockAdjustments)
        Me.grbTransactions.Controls.Add(Me.chbPointOfSales)
        Me.grbTransactions.Controls.Add(Me.chbReceive)
        Me.grbTransactions.Controls.Add(Me.chbPurchase)
        Me.grbTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbTransactions.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbTransactions.Location = New System.Drawing.Point(422, 36)
        Me.grbTransactions.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.grbTransactions.Name = "grbTransactions"
        Me.grbTransactions.Padding = New System.Windows.Forms.Padding(4)
        Me.grbTransactions.Size = New System.Drawing.Size(238, 187)
        Me.grbTransactions.TabIndex = 33
        Me.grbTransactions.TabStop = False
        Me.grbTransactions.Text = "Transactions"
        '
        'chbReturn
        '
        Me.chbReturn.AutoSize = True
        Me.chbReturn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbReturn.Location = New System.Drawing.Point(13, 70)
        Me.chbReturn.Margin = New System.Windows.Forms.Padding(0)
        Me.chbReturn.Name = "chbReturn"
        Me.chbReturn.Size = New System.Drawing.Size(163, 23)
        Me.chbReturn.TabIndex = 6
        Me.chbReturn.Text = "Return Products"
        Me.chbReturn.UseVisualStyleBackColor = True
        '
        'chbStockAdjustments
        '
        Me.chbStockAdjustments.AutoSize = True
        Me.chbStockAdjustments.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbStockAdjustments.Location = New System.Drawing.Point(13, 93)
        Me.chbStockAdjustments.Margin = New System.Windows.Forms.Padding(0)
        Me.chbStockAdjustments.Name = "chbStockAdjustments"
        Me.chbStockAdjustments.Size = New System.Drawing.Size(181, 23)
        Me.chbStockAdjustments.TabIndex = 5
        Me.chbStockAdjustments.Text = "Stock Adjustments"
        Me.chbStockAdjustments.UseVisualStyleBackColor = True
        '
        'chbPointOfSales
        '
        Me.chbPointOfSales.AutoSize = True
        Me.chbPointOfSales.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPointOfSales.Location = New System.Drawing.Point(13, 116)
        Me.chbPointOfSales.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPointOfSales.Name = "chbPointOfSales"
        Me.chbPointOfSales.Size = New System.Drawing.Size(154, 23)
        Me.chbPointOfSales.TabIndex = 2
        Me.chbPointOfSales.Text = "Point of Sales"
        Me.chbPointOfSales.UseVisualStyleBackColor = True
        '
        'chbReceive
        '
        Me.chbReceive.AutoSize = True
        Me.chbReceive.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbReceive.Location = New System.Drawing.Point(13, 47)
        Me.chbReceive.Margin = New System.Windows.Forms.Padding(0)
        Me.chbReceive.Name = "chbReceive"
        Me.chbReceive.Size = New System.Drawing.Size(172, 23)
        Me.chbReceive.TabIndex = 4
        Me.chbReceive.Text = "Receive Products"
        Me.chbReceive.UseVisualStyleBackColor = True
        '
        'chbPurchase
        '
        Me.chbPurchase.AutoSize = True
        Me.chbPurchase.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPurchase.Location = New System.Drawing.Point(13, 24)
        Me.chbPurchase.Margin = New System.Windows.Forms.Padding(0)
        Me.chbPurchase.Name = "chbPurchase"
        Me.chbPurchase.Size = New System.Drawing.Size(163, 23)
        Me.chbPurchase.TabIndex = 3
        Me.chbPurchase.Text = "Purchase Orders"
        Me.chbPurchase.UseVisualStyleBackColor = True
        '
        'grbReports
        '
        Me.grbReports.Controls.Add(Me.chbExpirations)
        Me.grbReports.Controls.Add(Me.chbStocks)
        Me.grbReports.Controls.Add(Me.chbSales)
        Me.grbReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbReports.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbReports.Location = New System.Drawing.Point(165, 233)
        Me.grbReports.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.grbReports.Name = "grbReports"
        Me.grbReports.Padding = New System.Windows.Forms.Padding(4)
        Me.grbReports.Size = New System.Drawing.Size(247, 121)
        Me.grbReports.TabIndex = 32
        Me.grbReports.TabStop = False
        Me.grbReports.Text = "Reports"
        '
        'chbStocks
        '
        Me.chbStocks.AutoSize = True
        Me.chbStocks.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbStocks.Location = New System.Drawing.Point(13, 47)
        Me.chbStocks.Margin = New System.Windows.Forms.Padding(0)
        Me.chbStocks.Name = "chbStocks"
        Me.chbStocks.Size = New System.Drawing.Size(82, 23)
        Me.chbStocks.TabIndex = 8
        Me.chbStocks.Text = "Stocks"
        Me.chbStocks.UseVisualStyleBackColor = True
        '
        'chbSales
        '
        Me.chbSales.AutoSize = True
        Me.chbSales.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSales.Location = New System.Drawing.Point(13, 24)
        Me.chbSales.Margin = New System.Windows.Forms.Padding(0)
        Me.chbSales.Name = "chbSales"
        Me.chbSales.Size = New System.Drawing.Size(73, 23)
        Me.chbSales.TabIndex = 7
        Me.chbSales.Text = "Sales"
        Me.chbSales.UseVisualStyleBackColor = True
        '
        'grbSecurity
        '
        Me.grbSecurity.Controls.Add(Me.chbUsers)
        Me.grbSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbSecurity.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbSecurity.Location = New System.Drawing.Point(422, 233)
        Me.grbSecurity.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.grbSecurity.Name = "grbSecurity"
        Me.grbSecurity.Padding = New System.Windows.Forms.Padding(4)
        Me.grbSecurity.Size = New System.Drawing.Size(238, 121)
        Me.grbSecurity.TabIndex = 29
        Me.grbSecurity.TabStop = False
        Me.grbSecurity.Text = "Security"
        '
        'chbUsers
        '
        Me.chbUsers.AutoSize = True
        Me.chbUsers.Enabled = False
        Me.chbUsers.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbUsers.Location = New System.Drawing.Point(13, 24)
        Me.chbUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.chbUsers.Name = "chbUsers"
        Me.chbUsers.Size = New System.Drawing.Size(73, 23)
        Me.chbUsers.TabIndex = 6
        Me.chbUsers.Text = "Users"
        Me.chbUsers.UseVisualStyleBackColor = True
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 3)
        Me.pnlControls.Controls.Add(Me.btnCancel)
        Me.pnlControls.Controls.Add(Me.btnSave)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnEdit)
        Me.pnlControls.Controls.Add(Me.btnNew)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 364)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(660, 51)
        Me.pnlControls.TabIndex = 24
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Khaki
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(527, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 51)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.BackColor = System.Drawing.Color.Khaki
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(104, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 51)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Khaki
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(598, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 51)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.BackColor = System.Drawing.Color.Khaki
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(52, 0)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(52, 51)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.AutoSize = True
        Me.btnNew.BackColor = System.Drawing.Color.Khaki
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(0, 0)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(52, 51)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'dgvUserTypes
        '
        Me.dgvUserTypes.AllowUserToAddRows = False
        Me.dgvUserTypes.AllowUserToDeleteRows = False
        Me.dgvUserTypes.AllowUserToResizeColumns = False
        Me.dgvUserTypes.AllowUserToResizeRows = False
        Me.dgvUserTypes.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvUserTypes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvUserTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserTypes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.typeName})
        Me.dgvUserTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUserTypes.GridColor = System.Drawing.Color.Indigo
        Me.dgvUserTypes.Location = New System.Drawing.Point(0, 0)
        Me.dgvUserTypes.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.dgvUserTypes.MultiSelect = False
        Me.dgvUserTypes.Name = "dgvUserTypes"
        Me.dgvUserTypes.ReadOnly = True
        Me.dgvUserTypes.RowHeadersVisible = False
        Me.dgvUserTypes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tplContents.SetRowSpan(Me.dgvUserTypes, 3)
        Me.dgvUserTypes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvUserTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserTypes.ShowCellErrors = False
        Me.dgvUserTypes.ShowCellToolTips = False
        Me.dgvUserTypes.ShowEditingIcon = False
        Me.dgvUserTypes.ShowRowErrors = False
        Me.dgvUserTypes.Size = New System.Drawing.Size(155, 354)
        Me.dgvUserTypes.TabIndex = 21
        '
        'typeName
        '
        Me.typeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.typeName.FillWeight = 30.0!
        Me.typeName.HeaderText = "User Types"
        Me.typeName.MinimumWidth = 30
        Me.typeName.Name = "typeName"
        Me.typeName.ReadOnly = True
        Me.typeName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'grbFileMaintenance
        '
        Me.grbFileMaintenance.Controls.Add(Me.chbProducts)
        Me.grbFileMaintenance.Controls.Add(Me.chbMiscellaneous)
        Me.grbFileMaintenance.Controls.Add(Me.chbCategories)
        Me.grbFileMaintenance.Controls.Add(Me.chbSuppliers)
        Me.grbFileMaintenance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbFileMaintenance.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFileMaintenance.Location = New System.Drawing.Point(165, 36)
        Me.grbFileMaintenance.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.grbFileMaintenance.Name = "grbFileMaintenance"
        Me.grbFileMaintenance.Padding = New System.Windows.Forms.Padding(4)
        Me.grbFileMaintenance.Size = New System.Drawing.Size(247, 187)
        Me.grbFileMaintenance.TabIndex = 26
        Me.grbFileMaintenance.TabStop = False
        Me.grbFileMaintenance.Text = "Files Maintenance"
        '
        'chbProducts
        '
        Me.chbProducts.AutoSize = True
        Me.chbProducts.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbProducts.Location = New System.Drawing.Point(13, 24)
        Me.chbProducts.Margin = New System.Windows.Forms.Padding(0)
        Me.chbProducts.Name = "chbProducts"
        Me.chbProducts.Size = New System.Drawing.Size(100, 23)
        Me.chbProducts.TabIndex = 0
        Me.chbProducts.Text = "Products"
        Me.chbProducts.UseVisualStyleBackColor = True
        '
        'chbMiscellaneous
        '
        Me.chbMiscellaneous.AutoSize = True
        Me.chbMiscellaneous.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMiscellaneous.Location = New System.Drawing.Point(13, 93)
        Me.chbMiscellaneous.Margin = New System.Windows.Forms.Padding(0)
        Me.chbMiscellaneous.Name = "chbMiscellaneous"
        Me.chbMiscellaneous.Size = New System.Drawing.Size(145, 23)
        Me.chbMiscellaneous.TabIndex = 9
        Me.chbMiscellaneous.Text = "Miscellaneous"
        Me.chbMiscellaneous.UseVisualStyleBackColor = True
        '
        'chbCategories
        '
        Me.chbCategories.AutoSize = True
        Me.chbCategories.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCategories.Location = New System.Drawing.Point(13, 70)
        Me.chbCategories.Margin = New System.Windows.Forms.Padding(0)
        Me.chbCategories.Name = "chbCategories"
        Me.chbCategories.Size = New System.Drawing.Size(118, 23)
        Me.chbCategories.TabIndex = 2
        Me.chbCategories.Text = "Categories"
        Me.chbCategories.UseVisualStyleBackColor = True
        '
        'chbSuppliers
        '
        Me.chbSuppliers.AutoSize = True
        Me.chbSuppliers.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSuppliers.Location = New System.Drawing.Point(13, 47)
        Me.chbSuppliers.Margin = New System.Windows.Forms.Padding(0)
        Me.chbSuppliers.Name = "chbSuppliers"
        Me.chbSuppliers.Size = New System.Drawing.Size(109, 23)
        Me.chbSuppliers.TabIndex = 1
        Me.chbSuppliers.Text = "Suppliers"
        Me.chbSuppliers.UseVisualStyleBackColor = True
        '
        'tplForm
        '
        Me.tplForm.BackColor = System.Drawing.Color.Aqua
        Me.tplForm.ColumnCount = 1
        Me.tplForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Controls.Add(Me.tplContents, 0, 1)
        Me.tplForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplForm.Location = New System.Drawing.Point(5, 0)
        Me.tplForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(690, 445)
        Me.tplForm.TabIndex = 36
        '
        'chbExpirations
        '
        Me.chbExpirations.AutoSize = True
        Me.chbExpirations.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbExpirations.Location = New System.Drawing.Point(13, 70)
        Me.chbExpirations.Margin = New System.Windows.Forms.Padding(0)
        Me.chbExpirations.Name = "chbExpirations"
        Me.chbExpirations.Size = New System.Drawing.Size(127, 23)
        Me.chbExpirations.TabIndex = 9
        Me.chbExpirations.Text = "Expirations"
        Me.chbExpirations.UseVisualStyleBackColor = True
        '
        'frmUserTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserTypes"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "User Type Maintenance"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.grbTransactions.ResumeLayout(False)
        Me.grbTransactions.PerformLayout()
        Me.grbReports.ResumeLayout(False)
        Me.grbReports.PerformLayout()
        Me.grbSecurity.ResumeLayout(False)
        Me.grbSecurity.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dgvUserTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFileMaintenance.ResumeLayout(False)
        Me.grbFileMaintenance.PerformLayout()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dgvUserTypes As System.Windows.Forms.DataGridView
    Friend WithEvents grbFileMaintenance As System.Windows.Forms.GroupBox
    Friend WithEvents grbSecurity As System.Windows.Forms.GroupBox
    Friend WithEvents chbProducts As System.Windows.Forms.CheckBox
    Friend WithEvents chbSuppliers As System.Windows.Forms.CheckBox
    Friend WithEvents chbCategories As System.Windows.Forms.CheckBox
    Friend WithEvents chbUsers As System.Windows.Forms.CheckBox
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grbReports As System.Windows.Forms.GroupBox
    Friend WithEvents grbTransactions As System.Windows.Forms.GroupBox
    Friend WithEvents chbStockAdjustments As System.Windows.Forms.CheckBox
    Friend WithEvents chbPointOfSales As System.Windows.Forms.CheckBox
    Friend WithEvents chbReceive As System.Windows.Forms.CheckBox
    Friend WithEvents chbPurchase As System.Windows.Forms.CheckBox
    Friend WithEvents chbMiscellaneous As System.Windows.Forms.CheckBox
    Friend WithEvents chbStocks As System.Windows.Forms.CheckBox
    Friend WithEvents chbSales As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents typeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chbReturn As System.Windows.Forms.CheckBox
    Friend WithEvents chbExpirations As System.Windows.Forms.CheckBox
End Class
