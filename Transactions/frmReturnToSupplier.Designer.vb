<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnToSupplier
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
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnChooseSupplier = New System.Windows.Forms.Button()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tplForm.SuspendLayout()
        Me.tplContents.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.tplForm.Size = New System.Drawing.Size(540, 345)
        Me.tplForm.TabIndex = 36
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 5
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 4)
        Me.tplContents.Controls.Add(Me.dgvProducts, 0, 3)
        Me.tplContents.Controls.Add(Me.lblProducts, 0, 2)
        Me.tplContents.Controls.Add(Me.btnAddProduct, 4, 2)
        Me.tplContents.Controls.Add(Me.btnChooseSupplier, 3, 1)
        Me.tplContents.Controls.Add(Me.lblSupplier, 0, 1)
        Me.tplContents.Controls.Add(Me.txtSupplier, 1, 1)
        Me.tplContents.Controls.Add(Me.dtpDate, 3, 0)
        Me.tplContents.Controls.Add(Me.lblDate, 2, 0)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 5
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.Size = New System.Drawing.Size(510, 315)
        Me.tplContents.TabIndex = 0
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 5)
        Me.pnlControls.Controls.Add(Me.btnOrder)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 265)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(510, 50)
        Me.pnlControls.TabIndex = 56
        '
        'btnOrder
        '
        Me.btnOrder.AutoSize = True
        Me.btnOrder.BackColor = System.Drawing.Color.Khaki
        Me.btnOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOrder.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOrder.Enabled = False
        Me.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(0, 0)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(199, 50)
        Me.btnOrder.TabIndex = 5
        Me.btnOrder.Text = "&Generate Purchase Order"
        Me.btnOrder.UseVisualStyleBackColor = False
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
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription, Me.productQuantity, Me.productRemarks})
        Me.tplContents.SetColumnSpan(Me.dgvProducts, 5)
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.dgvProducts.TabIndex = 39
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
        Me.productDescription.FillWeight = 50.0!
        Me.productDescription.HeaderText = "Description"
        Me.productDescription.MinimumWidth = 50
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
        'productRemarks
        '
        Me.productRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productRemarks.FillWeight = 30.0!
        Me.productRemarks.HeaderText = "Remarks"
        Me.productRemarks.MinimumWidth = 30
        Me.productRemarks.Name = "productRemarks"
        Me.productRemarks.ReadOnly = True
        '
        'lblProducts
        '
        Me.lblProducts.BackColor = System.Drawing.Color.Lime
        Me.lblProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblProducts, 4)
        Me.lblProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducts.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.Location = New System.Drawing.Point(0, 72)
        Me.lblProducts.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(433, 32)
        Me.lblProducts.TabIndex = 37
        Me.lblProducts.Text = "Products to Return"
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddProduct
        '
        Me.btnAddProduct.AutoSize = True
        Me.btnAddProduct.BackColor = System.Drawing.Color.Khaki
        Me.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduct.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Image = Global.pharmacy.My.Resources.Resources.plus26
        Me.btnAddProduct.Location = New System.Drawing.Point(433, 72)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(77, 32)
        Me.btnAddProduct.TabIndex = 38
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'btnChooseSupplier
        '
        Me.btnChooseSupplier.AutoSize = True
        Me.btnChooseSupplier.BackColor = System.Drawing.Color.Khaki
        Me.tplContents.SetColumnSpan(Me.btnChooseSupplier, 2)
        Me.btnChooseSupplier.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChooseSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnChooseSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnChooseSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnChooseSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnChooseSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseSupplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseSupplier.Location = New System.Drawing.Point(357, 36)
        Me.btnChooseSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnChooseSupplier.Name = "btnChooseSupplier"
        Me.btnChooseSupplier.Size = New System.Drawing.Size(153, 26)
        Me.btnChooseSupplier.TabIndex = 36
        Me.btnChooseSupplier.Text = "Choose Supplier"
        Me.btnChooseSupplier.UseVisualStyleBackColor = False
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
        Me.lblSupplier.Size = New System.Drawing.Size(102, 26)
        Me.lblSupplier.TabIndex = 34
        Me.lblSupplier.Text = "Supplier"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightGreen
        Me.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSupplier, 2)
        Me.txtSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSupplier.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.Location = New System.Drawing.Point(102, 36)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSupplier.MaxLength = 255
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(255, 26)
        Me.txtSupplier.TabIndex = 35
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
        Me.dtpDate.Location = New System.Drawing.Point(357, 0)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(153, 26)
        Me.dtpDate.TabIndex = 25
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Lime
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(255, 0)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(102, 26)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReturnToSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(550, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReturnToSupplier"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmReturnToSupplier"
        Me.tplForm.ResumeLayout(False)
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnChooseSupplier As System.Windows.Forms.Button
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblProducts As System.Windows.Forms.Label
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productRemarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOrder As System.Windows.Forms.Button
End Class
