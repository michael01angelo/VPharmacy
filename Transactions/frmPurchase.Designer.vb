<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
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
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.btnChooseSupplier = New System.Windows.Forms.Button()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 5
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.4286!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57133!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.4286!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28574!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28574!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.Controls.Add(Me.btnRemoveProduct, 4, 2)
        Me.tplContents.Controls.Add(Me.btnAddProduct, 3, 2)
        Me.tplContents.Controls.Add(Me.dgvProducts, 0, 3)
        Me.tplContents.Controls.Add(Me.txtCode, 1, 0)
        Me.tplContents.Controls.Add(Me.lblCode, 0, 0)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 4)
        Me.tplContents.Controls.Add(Me.lblDate, 2, 0)
        Me.tplContents.Controls.Add(Me.dtpDate, 3, 0)
        Me.tplContents.Controls.Add(Me.lblSupplier, 0, 1)
        Me.tplContents.Controls.Add(Me.txtSupplier, 1, 1)
        Me.tplContents.Controls.Add(Me.btnChooseSupplier, 3, 1)
        Me.tplContents.Controls.Add(Me.lblProducts, 0, 2)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 5
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.Size = New System.Drawing.Size(510, 315)
        Me.tplContents.TabIndex = 0
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.AutoSize = True
        Me.btnRemoveProduct.BackColor = System.Drawing.Color.Khaki
        Me.btnRemoveProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRemoveProduct.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnRemoveProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnRemoveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProduct.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProduct.Image = Global.pharmacy.My.Resources.Resources.minus26
        Me.btnRemoveProduct.Location = New System.Drawing.Point(435, 72)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(75, 32)
        Me.btnRemoveProduct.TabIndex = 28
        Me.btnRemoveProduct.UseVisualStyleBackColor = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.AutoSize = True
        Me.btnAddProduct.BackColor = System.Drawing.Color.Khaki
        Me.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Image = Global.pharmacy.My.Resources.Resources.plus26
        Me.btnAddProduct.Location = New System.Drawing.Point(363, 72)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(72, 32)
        Me.btnAddProduct.TabIndex = 28
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription, Me.productQuantity})
        Me.tplContents.SetColumnSpan(Me.dgvProducts, 5)
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.GridColor = System.Drawing.Color.Indigo
        Me.dgvProducts.Location = New System.Drawing.Point(0, 104)
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
        Me.dgvProducts.Size = New System.Drawing.Size(510, 151)
        Me.dgvProducts.TabIndex = 30
        '
        'productCode
        '
        Me.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productCode.FillWeight = 30.0!
        Me.productCode.HeaderText = "Code"
        Me.productCode.MinimumWidth = 30
        Me.productCode.Name = "productCode"
        Me.productCode.ReadOnly = True
        '
        'productDescription
        '
        Me.productDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productDescription.FillWeight = 75.0!
        Me.productDescription.HeaderText = "Description"
        Me.productDescription.MinimumWidth = 75
        Me.productDescription.Name = "productDescription"
        Me.productDescription.ReadOnly = True
        '
        'productQuantity
        '
        Me.productQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productQuantity.FillWeight = 20.0!
        Me.productQuantity.HeaderText = "Quantity"
        Me.productQuantity.MinimumWidth = 20
        Me.productQuantity.Name = "productQuantity"
        Me.productQuantity.ReadOnly = True
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(109, 0)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtCode.MaxLength = 255
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(135, 26)
        Me.txtCode.TabIndex = 22
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.Lime
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(0, 0)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(109, 26)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Text = "Order #"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 5)
        Me.pnlControls.Controls.Add(Me.btnCancel)
        Me.pnlControls.Controls.Add(Me.btnGenerate)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnNew)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 265)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(510, 50)
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
        Me.btnCancel.Location = New System.Drawing.Point(377, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 50)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.AutoSize = True
        Me.btnGenerate.BackColor = System.Drawing.Color.Khaki
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(52, 0)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(87, 50)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
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
        Me.btnClose.Location = New System.Drawing.Point(448, 0)
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
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Lime
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(254, 0)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(109, 26)
        Me.lblDate.TabIndex = 23
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpDate.CalendarMonthBackground = System.Drawing.Color.LightGreen
        Me.dtpDate.CalendarTitleBackColor = System.Drawing.Color.LightGreen
        Me.dtpDate.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpDate.CalendarTrailingForeColor = System.Drawing.Color.Indigo
        Me.tplContents.SetColumnSpan(Me.dtpDate, 2)
        Me.dtpDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpDate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(363, 0)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(147, 26)
        Me.dtpDate.TabIndex = 24
        '
        'lblSupplier
        '
        Me.lblSupplier.BackColor = System.Drawing.Color.Lime
        Me.lblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSupplier.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(0, 36)
        Me.lblSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(109, 26)
        Me.lblSupplier.TabIndex = 25
        Me.lblSupplier.Text = "Supplier"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightGreen
        Me.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSupplier, 2)
        Me.txtSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSupplier.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.Location = New System.Drawing.Point(109, 36)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSupplier.MaxLength = 255
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(254, 27)
        Me.txtSupplier.TabIndex = 26
        '
        'btnChooseSupplier
        '
        Me.btnChooseSupplier.AutoSize = True
        Me.btnChooseSupplier.BackColor = System.Drawing.Color.Khaki
        Me.tplContents.SetColumnSpan(Me.btnChooseSupplier, 2)
        Me.btnChooseSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnChooseSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnChooseSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnChooseSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnChooseSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseSupplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseSupplier.Location = New System.Drawing.Point(363, 36)
        Me.btnChooseSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnChooseSupplier.Name = "btnChooseSupplier"
        Me.btnChooseSupplier.Size = New System.Drawing.Size(147, 26)
        Me.btnChooseSupplier.TabIndex = 26
        Me.btnChooseSupplier.Text = "Choose Supplier"
        Me.btnChooseSupplier.UseVisualStyleBackColor = False
        '
        'lblProducts
        '
        Me.lblProducts.BackColor = System.Drawing.Color.Lime
        Me.lblProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblProducts, 3)
        Me.lblProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducts.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.Location = New System.Drawing.Point(0, 72)
        Me.lblProducts.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(363, 32)
        Me.lblProducts.TabIndex = 32
        Me.lblProducts.Text = "Products to Order"
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tplForm.Size = New System.Drawing.Size(540, 345)
        Me.tplForm.TabIndex = 36
        '
        'frmPurchase
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(550, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurchase"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Purchase Order"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents btnChooseSupplier As System.Windows.Forms.Button
    Friend WithEvents lblProducts As System.Windows.Forms.Label
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemoveProduct As System.Windows.Forms.Button
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
