<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceive
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
        Me.btnOrderBrowse = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.tplForm.SuspendLayout()
        Me.tplContents.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
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
        Me.tplContents.ColumnCount = 6
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.Controls.Add(Me.btnOrderBrowse, 2, 0)
        Me.tplContents.Controls.Add(Me.txtCode, 1, 0)
        Me.tplContents.Controls.Add(Me.lblCode, 0, 0)
        Me.tplContents.Controls.Add(Me.dgvProducts, 0, 3)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 4)
        Me.tplContents.Controls.Add(Me.lblDate, 3, 0)
        Me.tplContents.Controls.Add(Me.dtpDate, 4, 0)
        Me.tplContents.Controls.Add(Me.lblSupplier, 0, 1)
        Me.tplContents.Controls.Add(Me.lblProducts, 0, 2)
        Me.tplContents.Controls.Add(Me.btnAddProduct, 5, 2)
        Me.tplContents.Controls.Add(Me.txtSupplier, 1, 1)
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
        Me.tplContents.TabIndex = 1
        '
        'btnOrderBrowse
        '
        Me.btnOrderBrowse.AutoSize = True
        Me.btnOrderBrowse.BackColor = System.Drawing.Color.Khaki
        Me.btnOrderBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOrderBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOrderBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnOrderBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnOrderBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnOrderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderBrowse.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderBrowse.Location = New System.Drawing.Point(178, 0)
        Me.btnOrderBrowse.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnOrderBrowse.Name = "btnOrderBrowse"
        Me.btnOrderBrowse.Size = New System.Drawing.Size(92, 26)
        Me.btnOrderBrowse.TabIndex = 36
        Me.btnOrderBrowse.Text = "Browse"
        Me.btnOrderBrowse.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(76, 0)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtCode.MaxLength = 255
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(102, 26)
        Me.txtCode.TabIndex = 35
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
        Me.lblCode.Size = New System.Drawing.Size(76, 26)
        Me.lblCode.TabIndex = 34
        Me.lblCode.Text = "Order #"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription, Me.productQuantity, Me.productPrice})
        Me.tplContents.SetColumnSpan(Me.dgvProducts, 6)
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
        Me.productQuantity.FillWeight = 25.0!
        Me.productQuantity.HeaderText = "Quantity"
        Me.productQuantity.MinimumWidth = 25
        Me.productQuantity.Name = "productQuantity"
        Me.productQuantity.ReadOnly = True
        '
        'productPrice
        '
        Me.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productPrice.FillWeight = 20.0!
        Me.productPrice.HeaderText = "Price"
        Me.productPrice.MinimumWidth = 20
        Me.productPrice.Name = "productPrice"
        Me.productPrice.ReadOnly = True
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 6)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 265)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(510, 50)
        Me.pnlControls.TabIndex = 19
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
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Lime
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(280, 0)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(76, 26)
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
        Me.dtpDate.Location = New System.Drawing.Point(356, 0)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(154, 26)
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
        Me.lblSupplier.Size = New System.Drawing.Size(76, 26)
        Me.lblSupplier.TabIndex = 25
        Me.lblSupplier.Text = "Supplier"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProducts
        '
        Me.lblProducts.BackColor = System.Drawing.Color.Lime
        Me.lblProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblProducts, 5)
        Me.lblProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducts.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.Location = New System.Drawing.Point(0, 72)
        Me.lblProducts.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(432, 32)
        Me.lblProducts.TabIndex = 28
        Me.lblProducts.Text = "Products Received"
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightGreen
        Me.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSupplier, 5)
        Me.txtSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSupplier.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.Location = New System.Drawing.Point(76, 36)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSupplier.MaxLength = 255
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(434, 26)
        Me.txtSupplier.TabIndex = 26
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
        Me.btnAddProduct.Location = New System.Drawing.Point(432, 72)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(78, 32)
        Me.btnAddProduct.TabIndex = 32
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'frmReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(550, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceive"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Order Received"
        Me.tplForm.ResumeLayout(False)
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblProducts As System.Windows.Forms.Label
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents btnOrderBrowse As System.Windows.Forms.Button
End Class
