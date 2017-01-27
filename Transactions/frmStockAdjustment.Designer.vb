<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockAdjustment
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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbxTypes = New System.Windows.Forms.ComboBox()
        Me.lblProductCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvAdjustments = New System.Windows.Forms.DataGridView()
        Me.adjustmentCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjustmentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjustmentProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjustmentVariance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjustmentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnChooseItem = New System.Windows.Forms.Button()
        Me.lblProductDescription = New System.Windows.Forms.Label()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.lblItemStock = New System.Windows.Forms.Label()
        Me.txtItemStock = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblVariance = New System.Windows.Forms.Label()
        Me.nudVariance = New System.Windows.Forms.NumericUpDown()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvAdjustments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVariance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 5
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tplContents.Controls.Add(Me.lblSearch, 0, 0)
        Me.tplContents.Controls.Add(Me.txtSearch, 2, 0)
        Me.tplContents.Controls.Add(Me.cbxTypes, 0, 6)
        Me.tplContents.Controls.Add(Me.lblProductCode, 0, 3)
        Me.tplContents.Controls.Add(Me.txtCode, 1, 2)
        Me.tplContents.Controls.Add(Me.lblCode, 0, 2)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 7)
        Me.tplContents.Controls.Add(Me.dgvAdjustments, 0, 1)
        Me.tplContents.Controls.Add(Me.btnChooseItem, 4, 3)
        Me.tplContents.Controls.Add(Me.lblProductDescription, 1, 3)
        Me.tplContents.Controls.Add(Me.txtProductDescription, 1, 4)
        Me.tplContents.Controls.Add(Me.lblItemStock, 3, 3)
        Me.tplContents.Controls.Add(Me.txtItemStock, 3, 4)
        Me.tplContents.Controls.Add(Me.dtpDate, 4, 2)
        Me.tplContents.Controls.Add(Me.lblDate, 3, 2)
        Me.tplContents.Controls.Add(Me.lblRemarks, 2, 5)
        Me.tplContents.Controls.Add(Me.lblVariance, 1, 5)
        Me.tplContents.Controls.Add(Me.nudVariance, 1, 6)
        Me.tplContents.Controls.Add(Me.lblType, 0, 5)
        Me.tplContents.Controls.Add(Me.txtProductCode, 0, 4)
        Me.tplContents.Controls.Add(Me.txtRemarks, 3, 5)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 8
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.Size = New System.Drawing.Size(560, 365)
        Me.tplContents.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.Lime
        Me.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblSearch, 2)
        Me.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearch.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(0, 0)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(224, 26)
        Me.lblSearch.TabIndex = 43
        Me.lblSearch.Text = "Search"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSearch, 3)
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(224, 0)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(336, 26)
        Me.txtSearch.TabIndex = 42
        '
        'cbxTypes
        '
        Me.cbxTypes.BackColor = System.Drawing.Color.LightGreen
        Me.cbxTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTypes.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTypes.ForeColor = System.Drawing.Color.Black
        Me.cbxTypes.FormattingEnabled = True
        Me.cbxTypes.Items.AddRange(New Object() {"Add", "Deduct"})
        Me.cbxTypes.Location = New System.Drawing.Point(0, 279)
        Me.cbxTypes.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.cbxTypes.MaxDropDownItems = 5
        Me.cbxTypes.Name = "cbxTypes"
        Me.cbxTypes.Size = New System.Drawing.Size(112, 27)
        Me.cbxTypes.TabIndex = 41
        '
        'lblProductCode
        '
        Me.lblProductCode.BackColor = System.Drawing.Color.Lime
        Me.lblProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProductCode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCode.Location = New System.Drawing.Point(0, 191)
        Me.lblProductCode.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProductCode.Name = "lblProductCode"
        Me.lblProductCode.Size = New System.Drawing.Size(112, 26)
        Me.lblProductCode.TabIndex = 36
        Me.lblProductCode.Text = "Product Code"
        Me.lblProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(112, 155)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtCode.MaxLength = 255
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(112, 26)
        Me.txtCode.TabIndex = 22
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.Lime
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(0, 155)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(112, 26)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Text = "Adjustment #"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 5)
        Me.pnlControls.Controls.Add(Me.btnCancel)
        Me.pnlControls.Controls.Add(Me.btnSave)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnNew)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 315)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(560, 50)
        Me.pnlControls.TabIndex = 19
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
        Me.btnCancel.Location = New System.Drawing.Point(427, 0)
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
        Me.btnSave.Location = New System.Drawing.Point(52, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(498, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 50)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
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
        'dgvAdjustments
        '
        Me.dgvAdjustments.AllowUserToAddRows = False
        Me.dgvAdjustments.AllowUserToDeleteRows = False
        Me.dgvAdjustments.AllowUserToResizeColumns = False
        Me.dgvAdjustments.AllowUserToResizeRows = False
        Me.dgvAdjustments.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvAdjustments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdjustments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.adjustmentCode, Me.adjustmentType, Me.adjustmentProductName, Me.adjustmentVariance, Me.adjustmentDate})
        Me.tplContents.SetColumnSpan(Me.dgvAdjustments, 5)
        Me.dgvAdjustments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAdjustments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAdjustments.GridColor = System.Drawing.Color.Indigo
        Me.dgvAdjustments.Location = New System.Drawing.Point(0, 36)
        Me.dgvAdjustments.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dgvAdjustments.MultiSelect = False
        Me.dgvAdjustments.Name = "dgvAdjustments"
        Me.dgvAdjustments.ReadOnly = True
        Me.dgvAdjustments.RowHeadersVisible = False
        Me.dgvAdjustments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAdjustments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAdjustments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdjustments.ShowCellErrors = False
        Me.dgvAdjustments.ShowCellToolTips = False
        Me.dgvAdjustments.ShowEditingIcon = False
        Me.dgvAdjustments.ShowRowErrors = False
        Me.dgvAdjustments.Size = New System.Drawing.Size(560, 109)
        Me.dgvAdjustments.TabIndex = 20
        '
        'adjustmentCode
        '
        Me.adjustmentCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.adjustmentCode.FillWeight = 15.0!
        Me.adjustmentCode.HeaderText = "Code"
        Me.adjustmentCode.MinimumWidth = 15
        Me.adjustmentCode.Name = "adjustmentCode"
        Me.adjustmentCode.ReadOnly = True
        Me.adjustmentCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'adjustmentType
        '
        Me.adjustmentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.adjustmentType.FillWeight = 15.0!
        Me.adjustmentType.HeaderText = "Type"
        Me.adjustmentType.MinimumWidth = 15
        Me.adjustmentType.Name = "adjustmentType"
        Me.adjustmentType.ReadOnly = True
        Me.adjustmentType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'adjustmentProductName
        '
        Me.adjustmentProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.adjustmentProductName.FillWeight = 40.0!
        Me.adjustmentProductName.HeaderText = "Product Description"
        Me.adjustmentProductName.MinimumWidth = 40
        Me.adjustmentProductName.Name = "adjustmentProductName"
        Me.adjustmentProductName.ReadOnly = True
        Me.adjustmentProductName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'adjustmentVariance
        '
        Me.adjustmentVariance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.adjustmentVariance.FillWeight = 15.0!
        Me.adjustmentVariance.HeaderText = "Quantity"
        Me.adjustmentVariance.MinimumWidth = 15
        Me.adjustmentVariance.Name = "adjustmentVariance"
        Me.adjustmentVariance.ReadOnly = True
        Me.adjustmentVariance.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'adjustmentDate
        '
        Me.adjustmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.adjustmentDate.FillWeight = 20.0!
        Me.adjustmentDate.HeaderText = "Date"
        Me.adjustmentDate.MinimumWidth = 20
        Me.adjustmentDate.Name = "adjustmentDate"
        Me.adjustmentDate.ReadOnly = True
        Me.adjustmentDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnChooseItem
        '
        Me.btnChooseItem.AutoSize = True
        Me.btnChooseItem.BackColor = System.Drawing.Color.Khaki
        Me.btnChooseItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnChooseItem.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnChooseItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnChooseItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnChooseItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseItem.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseItem.Location = New System.Drawing.Point(420, 191)
        Me.btnChooseItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnChooseItem.Name = "btnChooseItem"
        Me.tplContents.SetRowSpan(Me.btnChooseItem, 2)
        Me.btnChooseItem.Size = New System.Drawing.Size(140, 52)
        Me.btnChooseItem.TabIndex = 26
        Me.btnChooseItem.Text = "Choose Product"
        Me.btnChooseItem.UseVisualStyleBackColor = False
        '
        'lblProductDescription
        '
        Me.lblProductDescription.BackColor = System.Drawing.Color.Lime
        Me.lblProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblProductDescription, 2)
        Me.lblProductDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProductDescription.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductDescription.Location = New System.Drawing.Point(112, 191)
        Me.lblProductDescription.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProductDescription.Name = "lblProductDescription"
        Me.lblProductDescription.Size = New System.Drawing.Size(196, 26)
        Me.lblProductDescription.TabIndex = 30
        Me.lblProductDescription.Text = "Product Description"
        Me.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProductDescription
        '
        Me.txtProductDescription.BackColor = System.Drawing.Color.LightGreen
        Me.txtProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtProductDescription, 2)
        Me.txtProductDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductDescription.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.ForeColor = System.Drawing.Color.Black
        Me.txtProductDescription.Location = New System.Drawing.Point(112, 217)
        Me.txtProductDescription.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtProductDescription.MaxLength = 255
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.ReadOnly = True
        Me.txtProductDescription.Size = New System.Drawing.Size(196, 26)
        Me.txtProductDescription.TabIndex = 31
        '
        'lblItemStock
        '
        Me.lblItemStock.BackColor = System.Drawing.Color.Lime
        Me.lblItemStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblItemStock.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemStock.Location = New System.Drawing.Point(308, 191)
        Me.lblItemStock.Margin = New System.Windows.Forms.Padding(0)
        Me.lblItemStock.Name = "lblItemStock"
        Me.lblItemStock.Size = New System.Drawing.Size(112, 26)
        Me.lblItemStock.TabIndex = 32
        Me.lblItemStock.Text = "Product Stock"
        Me.lblItemStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemStock
        '
        Me.txtItemStock.BackColor = System.Drawing.Color.LightGreen
        Me.txtItemStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtItemStock.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemStock.ForeColor = System.Drawing.Color.Black
        Me.txtItemStock.Location = New System.Drawing.Point(308, 217)
        Me.txtItemStock.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtItemStock.MaxLength = 255
        Me.txtItemStock.Name = "txtItemStock"
        Me.txtItemStock.ReadOnly = True
        Me.txtItemStock.Size = New System.Drawing.Size(112, 26)
        Me.txtItemStock.TabIndex = 33
        '
        'dtpDate
        '
        Me.dtpDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpDate.CalendarMonthBackground = System.Drawing.Color.LightGreen
        Me.dtpDate.CalendarTitleBackColor = System.Drawing.Color.LightGreen
        Me.dtpDate.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpDate.CalendarTrailingForeColor = System.Drawing.Color.Indigo
        Me.dtpDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(420, 155)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(140, 26)
        Me.dtpDate.TabIndex = 24
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Lime
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(308, 155)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(112, 26)
        Me.lblDate.TabIndex = 23
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemarks
        '
        Me.lblRemarks.BackColor = System.Drawing.Color.Lime
        Me.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemarks.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(234, 253)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.lblRemarks.Name = "lblRemarks"
        Me.tplContents.SetRowSpan(Me.lblRemarks, 2)
        Me.lblRemarks.Size = New System.Drawing.Size(74, 52)
        Me.lblRemarks.TabIndex = 38
        Me.lblRemarks.Text = "Remarks"
        Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVariance
        '
        Me.lblVariance.BackColor = System.Drawing.Color.Lime
        Me.lblVariance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVariance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVariance.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariance.Location = New System.Drawing.Point(122, 253)
        Me.lblVariance.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblVariance.Name = "lblVariance"
        Me.lblVariance.Size = New System.Drawing.Size(102, 26)
        Me.lblVariance.TabIndex = 34
        Me.lblVariance.Text = "Quantity"
        Me.lblVariance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudVariance
        '
        Me.nudVariance.BackColor = System.Drawing.Color.LightGreen
        Me.nudVariance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudVariance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudVariance.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudVariance.ForeColor = System.Drawing.Color.Black
        Me.nudVariance.Location = New System.Drawing.Point(122, 279)
        Me.nudVariance.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.nudVariance.Name = "nudVariance"
        Me.nudVariance.Size = New System.Drawing.Size(102, 26)
        Me.nudVariance.TabIndex = 35
        Me.nudVariance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Lime
        Me.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblType.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(0, 253)
        Me.lblType.Margin = New System.Windows.Forms.Padding(0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(112, 26)
        Me.lblType.TabIndex = 40
        Me.lblType.Text = "Type"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProductCode
        '
        Me.txtProductCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.ForeColor = System.Drawing.Color.Black
        Me.txtProductCode.Location = New System.Drawing.Point(0, 217)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtProductCode.MaxLength = 255
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.ReadOnly = True
        Me.txtProductCode.Size = New System.Drawing.Size(112, 26)
        Me.txtProductCode.TabIndex = 37
        '
        'txtRemarks
        '
        Me.txtRemarks.AcceptsReturn = True
        Me.txtRemarks.BackColor = System.Drawing.Color.LightGreen
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtRemarks, 2)
        Me.txtRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRemarks.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(308, 253)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.tplContents.SetRowSpan(Me.txtRemarks, 2)
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(252, 52)
        Me.txtRemarks.TabIndex = 44
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
        Me.tplForm.Size = New System.Drawing.Size(590, 395)
        Me.tplForm.TabIndex = 36
        '
        'frmStockAdjustment
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockAdjustment"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stock Adjustment"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dgvAdjustments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVariance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dgvAdjustments As System.Windows.Forms.DataGridView
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnChooseItem As System.Windows.Forms.Button
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblItemStock As System.Windows.Forms.Label
    Friend WithEvents txtItemStock As System.Windows.Forms.TextBox
    Friend WithEvents lblVariance As System.Windows.Forms.Label
    Friend WithEvents nudVariance As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents lblProductCode As System.Windows.Forms.Label
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cbxTypes As System.Windows.Forms.ComboBox
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents adjustmentCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adjustmentType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adjustmentProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adjustmentVariance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adjustmentDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
