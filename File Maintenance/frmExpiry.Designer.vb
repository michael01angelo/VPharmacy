<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpiry
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
        Me.btnChooseProduct = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBatch = New System.Windows.Forms.TextBox()
        Me.lblExpiration = New System.Windows.Forms.Label()
        Me.lblBatch = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productBatch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productExpiration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 3
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tplContents.Controls.Add(Me.btnChooseProduct, 2, 1)
        Me.tplContents.Controls.Add(Me.txtDescription, 1, 2)
        Me.tplContents.Controls.Add(Me.txtCode, 0, 2)
        Me.tplContents.Controls.Add(Me.lblDescription, 1, 1)
        Me.tplContents.Controls.Add(Me.lblCode, 0, 1)
        Me.tplContents.Controls.Add(Me.dtpDate, 2, 4)
        Me.tplContents.Controls.Add(Me.txtBatch, 0, 4)
        Me.tplContents.Controls.Add(Me.lblExpiration, 2, 3)
        Me.tplContents.Controls.Add(Me.lblBatch, 0, 3)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 5)
        Me.tplContents.Controls.Add(Me.dgvProducts, 0, 0)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 6
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.Size = New System.Drawing.Size(560, 365)
        Me.tplContents.TabIndex = 0
        '
        'btnChooseProduct
        '
        Me.btnChooseProduct.AutoSize = True
        Me.btnChooseProduct.BackColor = System.Drawing.Color.Khaki
        Me.btnChooseProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnChooseProduct.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnChooseProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnChooseProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnChooseProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseProduct.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseProduct.Location = New System.Drawing.Point(420, 181)
        Me.btnChooseProduct.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.btnChooseProduct.Name = "btnChooseProduct"
        Me.tplContents.SetRowSpan(Me.btnChooseProduct, 2)
        Me.btnChooseProduct.Size = New System.Drawing.Size(140, 52)
        Me.btnChooseProduct.TabIndex = 33
        Me.btnChooseProduct.Text = "Choose Product"
        Me.btnChooseProduct.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDescription.BackColor = System.Drawing.Color.LightGreen
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(168, 207)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(252, 26)
        Me.txtDescription.TabIndex = 32
        '
        'txtCode
        '
        Me.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(0, 207)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(168, 26)
        Me.txtCode.TabIndex = 31
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Lime
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescription.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(168, 181)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(252, 26)
        Me.lblDescription.TabIndex = 30
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.Lime
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(0, 181)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(168, 26)
        Me.lblCode.TabIndex = 29
        Me.lblCode.Text = "Code"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dtpDate.Location = New System.Drawing.Point(420, 279)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(140, 26)
        Me.dtpDate.TabIndex = 28
        '
        'txtBatch
        '
        Me.txtBatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBatch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBatch.BackColor = System.Drawing.Color.LightGreen
        Me.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBatch.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatch.ForeColor = System.Drawing.Color.Black
        Me.txtBatch.Location = New System.Drawing.Point(0, 279)
        Me.txtBatch.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.ReadOnly = True
        Me.txtBatch.Size = New System.Drawing.Size(168, 26)
        Me.txtBatch.TabIndex = 27
        '
        'lblExpiration
        '
        Me.lblExpiration.BackColor = System.Drawing.Color.Lime
        Me.lblExpiration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExpiration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExpiration.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiration.Location = New System.Drawing.Point(420, 253)
        Me.lblExpiration.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblExpiration.Name = "lblExpiration"
        Me.lblExpiration.Size = New System.Drawing.Size(140, 26)
        Me.lblExpiration.TabIndex = 26
        Me.lblExpiration.Text = "Expiration Date"
        Me.lblExpiration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBatch
        '
        Me.lblBatch.BackColor = System.Drawing.Color.Lime
        Me.lblBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBatch.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatch.Location = New System.Drawing.Point(0, 253)
        Me.lblBatch.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblBatch.Name = "lblBatch"
        Me.lblBatch.Size = New System.Drawing.Size(168, 26)
        Me.lblBatch.TabIndex = 25
        Me.lblBatch.Text = "Lot/Batch #"
        Me.lblBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnlControls.Location = New System.Drawing.Point(0, 315)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(560, 50)
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
        Me.btnSave.Location = New System.Drawing.Point(99, 0)
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
        Me.btnEdit.Location = New System.Drawing.Point(51, 0)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(48, 50)
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
        Me.btnNew.Size = New System.Drawing.Size(51, 50)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "New"
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
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription, Me.productBatch, Me.productExpiration})
        Me.tplContents.SetColumnSpan(Me.dgvProducts, 3)
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.GridColor = System.Drawing.Color.Indigo
        Me.dgvProducts.Location = New System.Drawing.Point(0, 0)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(0)
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
        Me.dgvProducts.Size = New System.Drawing.Size(560, 171)
        Me.dgvProducts.TabIndex = 4
        '
        'productCode
        '
        Me.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productCode.FillWeight = 25.0!
        Me.productCode.HeaderText = "Code"
        Me.productCode.MinimumWidth = 25
        Me.productCode.Name = "productCode"
        Me.productCode.ReadOnly = True
        Me.productCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'productDescription
        '
        Me.productDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productDescription.FillWeight = 50.0!
        Me.productDescription.HeaderText = "Description"
        Me.productDescription.MinimumWidth = 50
        Me.productDescription.Name = "productDescription"
        Me.productDescription.ReadOnly = True
        Me.productDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'productBatch
        '
        Me.productBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productBatch.FillWeight = 20.0!
        Me.productBatch.HeaderText = "Lot/Batch"
        Me.productBatch.MinimumWidth = 20
        Me.productBatch.Name = "productBatch"
        Me.productBatch.ReadOnly = True
        Me.productBatch.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'productExpiration
        '
        Me.productExpiration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productExpiration.FillWeight = 30.0!
        Me.productExpiration.HeaderText = "Expiration Date"
        Me.productExpiration.MinimumWidth = 30
        Me.productExpiration.Name = "productExpiration"
        Me.productExpiration.ReadOnly = True
        Me.productExpiration.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'tplForm
        '
        Me.tplForm.BackColor = System.Drawing.Color.Aqua
        Me.tplForm.ColumnCount = 1
        Me.tplForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Controls.Add(Me.tplContents, 0, 1)
        Me.tplForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplForm.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplForm.Location = New System.Drawing.Point(5, 0)
        Me.tplForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(590, 395)
        Me.tplForm.TabIndex = 36
        '
        'frmExpiry
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExpiry"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmExpiry"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBatch As System.Windows.Forms.TextBox
    Friend WithEvents lblExpiration As System.Windows.Forms.Label
    Friend WithEvents lblBatch As System.Windows.Forms.Label
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnChooseProduct As System.Windows.Forms.Button
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productBatch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productExpiration As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
