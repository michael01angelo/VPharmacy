<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.chbVatable = New System.Windows.Forms.CheckBox()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.chbDiscountable = New System.Windows.Forms.CheckBox()
        Me.nudROP = New System.Windows.Forms.NumericUpDown()
        Me.lblROP = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productGeneric = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cbxCategories = New System.Windows.Forms.ComboBox()
        Me.cbxSubCategories = New System.Windows.Forms.ComboBox()
        Me.lblSubCategory = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblGeneric = New System.Windows.Forms.Label()
        Me.txtGeneric = New System.Windows.Forms.TextBox()
        Me.lblMarkUp = New System.Windows.Forms.Label()
        Me.nudMarkUp = New System.Windows.Forms.NumericUpDown()
        Me.cbxUnits = New System.Windows.Forms.ComboBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudROP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 6
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0015!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33183!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0015!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33183!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0015!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33183!))
        Me.tplContents.Controls.Add(Me.chbVatable, 4, 4)
        Me.tplContents.Controls.Add(Me.nudPrice, 1, 4)
        Me.tplContents.Controls.Add(Me.lblSellingPrice, 4, 2)
        Me.tplContents.Controls.Add(Me.lblPrice, 0, 4)
        Me.tplContents.Controls.Add(Me.chbDiscountable, 0, 5)
        Me.tplContents.Controls.Add(Me.nudROP, 5, 5)
        Me.tplContents.Controls.Add(Me.lblROP, 4, 5)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 6)
        Me.tplContents.Controls.Add(Me.dgvProducts, 0, 1)
        Me.tplContents.Controls.Add(Me.lblSearch, 0, 0)
        Me.tplContents.Controls.Add(Me.txtSearch, 1, 0)
        Me.tplContents.Controls.Add(Me.lblCategory, 2, 0)
        Me.tplContents.Controls.Add(Me.cbxCategories, 3, 0)
        Me.tplContents.Controls.Add(Me.cbxSubCategories, 5, 0)
        Me.tplContents.Controls.Add(Me.lblSubCategory, 4, 0)
        Me.tplContents.Controls.Add(Me.lblCode, 0, 2)
        Me.tplContents.Controls.Add(Me.txtCode, 1, 2)
        Me.tplContents.Controls.Add(Me.lblName, 0, 3)
        Me.tplContents.Controls.Add(Me.txtName, 1, 3)
        Me.tplContents.Controls.Add(Me.lblGeneric, 3, 3)
        Me.tplContents.Controls.Add(Me.txtGeneric, 4, 3)
        Me.tplContents.Controls.Add(Me.lblMarkUp, 2, 4)
        Me.tplContents.Controls.Add(Me.nudMarkUp, 3, 4)
        Me.tplContents.Controls.Add(Me.cbxUnits, 3, 5)
        Me.tplContents.Controls.Add(Me.lblUnit, 2, 5)
        Me.tplContents.Controls.Add(Me.txtSellingPrice, 5, 2)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 7
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.Size = New System.Drawing.Size(710, 415)
        Me.tplContents.TabIndex = 0
        '
        'chbVatable
        '
        Me.chbVatable.AutoSize = True
        Me.chbVatable.BackColor = System.Drawing.Color.LightGreen
        Me.chbVatable.Checked = True
        Me.chbVatable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tplContents.SetColumnSpan(Me.chbVatable, 2)
        Me.chbVatable.Dock = System.Windows.Forms.DockStyle.Left
        Me.chbVatable.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.chbVatable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime
        Me.chbVatable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.chbVatable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.chbVatable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVatable.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVatable.Location = New System.Drawing.Point(472, 293)
        Me.chbVatable.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.chbVatable.Name = "chbVatable"
        Me.chbVatable.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbVatable.Size = New System.Drawing.Size(98, 26)
        Me.chbVatable.TabIndex = 70
        Me.chbVatable.Text = "Vatable"
        Me.chbVatable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbVatable.UseVisualStyleBackColor = False
        '
        'nudPrice
        '
        Me.nudPrice.BackColor = System.Drawing.Color.LightGreen
        Me.nudPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudPrice.DecimalPlaces = 2
        Me.nudPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudPrice.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPrice.ForeColor = System.Drawing.Color.Black
        Me.nudPrice.Location = New System.Drawing.Point(106, 293)
        Me.nudPrice.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.nudPrice.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(120, 26)
        Me.nudPrice.TabIndex = 68
        Me.nudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.BackColor = System.Drawing.Color.Lime
        Me.lblSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSellingPrice.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellingPrice.Location = New System.Drawing.Point(472, 221)
        Me.lblSellingPrice.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(106, 26)
        Me.lblSellingPrice.TabIndex = 67
        Me.lblSellingPrice.Text = "Selling Price"
        Me.lblSellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Lime
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrice.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(0, 293)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(106, 26)
        Me.lblPrice.TabIndex = 66
        Me.lblPrice.Text = "Price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chbDiscountable
        '
        Me.chbDiscountable.AutoSize = True
        Me.chbDiscountable.BackColor = System.Drawing.Color.LightGreen
        Me.chbDiscountable.Checked = True
        Me.chbDiscountable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tplContents.SetColumnSpan(Me.chbDiscountable, 2)
        Me.chbDiscountable.Dock = System.Windows.Forms.DockStyle.Left
        Me.chbDiscountable.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.chbDiscountable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime
        Me.chbDiscountable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.chbDiscountable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.chbDiscountable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbDiscountable.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbDiscountable.Location = New System.Drawing.Point(0, 329)
        Me.chbDiscountable.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.chbDiscountable.Name = "chbDiscountable"
        Me.chbDiscountable.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbDiscountable.Size = New System.Drawing.Size(143, 26)
        Me.chbDiscountable.TabIndex = 65
        Me.chbDiscountable.Text = "Discountable"
        Me.chbDiscountable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbDiscountable.UseVisualStyleBackColor = False
        '
        'nudROP
        '
        Me.nudROP.BackColor = System.Drawing.Color.LightGreen
        Me.nudROP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudROP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudROP.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudROP.ForeColor = System.Drawing.Color.Black
        Me.nudROP.Location = New System.Drawing.Point(578, 329)
        Me.nudROP.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.nudROP.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudROP.Name = "nudROP"
        Me.nudROP.Size = New System.Drawing.Size(132, 26)
        Me.nudROP.TabIndex = 27
        Me.nudROP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblROP
        '
        Me.lblROP.BackColor = System.Drawing.Color.Lime
        Me.lblROP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblROP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblROP.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblROP.Location = New System.Drawing.Point(472, 329)
        Me.lblROP.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblROP.Name = "lblROP"
        Me.lblROP.Size = New System.Drawing.Size(106, 26)
        Me.lblROP.TabIndex = 26
        Me.lblROP.Text = "ROP"
        Me.lblROP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 6)
        Me.pnlControls.Controls.Add(Me.btnCancel)
        Me.pnlControls.Controls.Add(Me.btnSave)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnEdit)
        Me.pnlControls.Controls.Add(Me.btnNew)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 365)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(710, 50)
        Me.pnlControls.TabIndex = 23
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
        Me.btnCancel.Location = New System.Drawing.Point(577, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 50)
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
        Me.btnSave.Size = New System.Drawing.Size(56, 50)
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
        Me.btnClose.Location = New System.Drawing.Point(648, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 50)
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
        Me.btnEdit.Size = New System.Drawing.Size(52, 50)
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
        Me.btnNew.Size = New System.Drawing.Size(52, 50)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription, Me.productGeneric})
        Me.tplContents.SetColumnSpan(Me.dgvProducts, 6)
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.GridColor = System.Drawing.Color.Indigo
        Me.dgvProducts.Location = New System.Drawing.Point(0, 36)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.ShowCellErrors = False
        Me.dgvProducts.ShowCellToolTips = False
        Me.dgvProducts.ShowEditingIcon = False
        Me.dgvProducts.ShowRowErrors = False
        Me.dgvProducts.Size = New System.Drawing.Size(710, 175)
        Me.dgvProducts.TabIndex = 0
        '
        'productCode
        '
        Me.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productCode.FillWeight = 50.0!
        Me.productCode.HeaderText = "Code"
        Me.productCode.MinimumWidth = 50
        Me.productCode.Name = "productCode"
        Me.productCode.ReadOnly = True
        Me.productCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'productDescription
        '
        Me.productDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productDescription.HeaderText = "Name"
        Me.productDescription.MinimumWidth = 100
        Me.productDescription.Name = "productDescription"
        Me.productDescription.ReadOnly = True
        Me.productDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'productGeneric
        '
        Me.productGeneric.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productGeneric.FillWeight = 80.0!
        Me.productGeneric.HeaderText = "Generic Name"
        Me.productGeneric.MinimumWidth = 80
        Me.productGeneric.Name = "productGeneric"
        Me.productGeneric.ReadOnly = True
        Me.productGeneric.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.Lime
        Me.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearch.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(0, 0)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(106, 26)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(106, 0)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(120, 26)
        Me.txtSearch.TabIndex = 2
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Lime
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCategory.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(236, 0)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(106, 26)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.Text = "Category"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxCategories
        '
        Me.cbxCategories.BackColor = System.Drawing.Color.LightGreen
        Me.cbxCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategories.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategories.ForeColor = System.Drawing.Color.Black
        Me.cbxCategories.FormattingEnabled = True
        Me.cbxCategories.Location = New System.Drawing.Point(342, 0)
        Me.cbxCategories.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cbxCategories.MaxDropDownItems = 5
        Me.cbxCategories.Name = "cbxCategories"
        Me.cbxCategories.Size = New System.Drawing.Size(120, 27)
        Me.cbxCategories.Sorted = True
        Me.cbxCategories.TabIndex = 4
        '
        'cbxSubCategories
        '
        Me.cbxSubCategories.BackColor = System.Drawing.Color.LightGreen
        Me.cbxSubCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxSubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSubCategories.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSubCategories.ForeColor = System.Drawing.Color.Black
        Me.cbxSubCategories.FormattingEnabled = True
        Me.cbxSubCategories.Location = New System.Drawing.Point(578, 0)
        Me.cbxSubCategories.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.cbxSubCategories.MaxDropDownItems = 5
        Me.cbxSubCategories.Name = "cbxSubCategories"
        Me.cbxSubCategories.Size = New System.Drawing.Size(132, 27)
        Me.cbxSubCategories.Sorted = True
        Me.cbxSubCategories.TabIndex = 6
        '
        'lblSubCategory
        '
        Me.lblSubCategory.BackColor = System.Drawing.Color.Lime
        Me.lblSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubCategory.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCategory.Location = New System.Drawing.Point(472, 0)
        Me.lblSubCategory.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblSubCategory.Name = "lblSubCategory"
        Me.lblSubCategory.Size = New System.Drawing.Size(106, 26)
        Me.lblSubCategory.TabIndex = 5
        Me.lblSubCategory.Text = "SubCategory"
        Me.lblSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.Lime
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(0, 221)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(106, 26)
        Me.lblCode.TabIndex = 7
        Me.lblCode.Text = "Code"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(106, 221)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(130, 26)
        Me.txtCode.TabIndex = 8
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Lime
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(0, 257)
        Me.lblName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 26)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Description"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LightGreen
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtName, 2)
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(106, 257)
        Me.txtName.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 26)
        Me.txtName.TabIndex = 10
        '
        'lblGeneric
        '
        Me.lblGeneric.BackColor = System.Drawing.Color.Lime
        Me.lblGeneric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGeneric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGeneric.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneric.Location = New System.Drawing.Point(342, 257)
        Me.lblGeneric.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblGeneric.Name = "lblGeneric"
        Me.lblGeneric.Size = New System.Drawing.Size(130, 26)
        Me.lblGeneric.TabIndex = 11
        Me.lblGeneric.Text = "Generic Name"
        Me.lblGeneric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGeneric
        '
        Me.txtGeneric.BackColor = System.Drawing.Color.LightGreen
        Me.txtGeneric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtGeneric, 2)
        Me.txtGeneric.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGeneric.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeneric.ForeColor = System.Drawing.Color.Black
        Me.txtGeneric.Location = New System.Drawing.Point(472, 257)
        Me.txtGeneric.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtGeneric.Name = "txtGeneric"
        Me.txtGeneric.Size = New System.Drawing.Size(238, 26)
        Me.txtGeneric.TabIndex = 12
        '
        'lblMarkUp
        '
        Me.lblMarkUp.BackColor = System.Drawing.Color.Lime
        Me.lblMarkUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMarkUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMarkUp.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkUp.Location = New System.Drawing.Point(236, 293)
        Me.lblMarkUp.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblMarkUp.Name = "lblMarkUp"
        Me.lblMarkUp.Size = New System.Drawing.Size(106, 26)
        Me.lblMarkUp.TabIndex = 15
        Me.lblMarkUp.Text = "MarkUp"
        Me.lblMarkUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudMarkUp
        '
        Me.nudMarkUp.BackColor = System.Drawing.Color.LightGreen
        Me.nudMarkUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudMarkUp.DecimalPlaces = 2
        Me.nudMarkUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudMarkUp.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMarkUp.ForeColor = System.Drawing.Color.Black
        Me.nudMarkUp.Location = New System.Drawing.Point(342, 293)
        Me.nudMarkUp.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.nudMarkUp.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMarkUp.Name = "nudMarkUp"
        Me.nudMarkUp.Size = New System.Drawing.Size(120, 26)
        Me.nudMarkUp.TabIndex = 16
        Me.nudMarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxUnits
        '
        Me.cbxUnits.BackColor = System.Drawing.Color.LightGreen
        Me.cbxUnits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnits.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUnits.ForeColor = System.Drawing.Color.Black
        Me.cbxUnits.FormattingEnabled = True
        Me.cbxUnits.Location = New System.Drawing.Point(342, 329)
        Me.cbxUnits.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.cbxUnits.MaxDropDownItems = 5
        Me.cbxUnits.Name = "cbxUnits"
        Me.cbxUnits.Size = New System.Drawing.Size(120, 27)
        Me.cbxUnits.Sorted = True
        Me.cbxUnits.TabIndex = 14
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Lime
        Me.lblUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUnit.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(236, 329)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(106, 26)
        Me.lblUnit.TabIndex = 13
        Me.lblUnit.Text = "Unit"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.BackColor = System.Drawing.Color.LightGreen
        Me.txtSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSellingPrice.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingPrice.ForeColor = System.Drawing.Color.Black
        Me.txtSellingPrice.Location = New System.Drawing.Point(578, 221)
        Me.txtSellingPrice.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.ReadOnly = True
        Me.txtSellingPrice.Size = New System.Drawing.Size(132, 26)
        Me.txtSellingPrice.TabIndex = 71
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
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(740, 445)
        Me.tplForm.TabIndex = 36
        '
        'frmProducts
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Indigo
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProducts"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Products Maintenance"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudROP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtGeneric As System.Windows.Forms.TextBox
    Friend WithEvents lblGeneric As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblMarkUp As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblSubCategory As System.Windows.Forms.Label
    Friend WithEvents cbxUnits As System.Windows.Forms.ComboBox
    Friend WithEvents nudMarkUp As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents cbxCategories As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSubCategories As System.Windows.Forms.ComboBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents nudROP As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblROP As System.Windows.Forms.Label
    Friend WithEvents chbDiscountable As System.Windows.Forms.CheckBox
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productGeneric As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chbVatable As System.Windows.Forms.CheckBox
    Friend WithEvents nudPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSellingPrice As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
End Class
