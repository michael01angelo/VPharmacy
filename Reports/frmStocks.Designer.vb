<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStocks
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearchSupplier = New System.Windows.Forms.TextBox()
        Me.lblSearchSupplier = New System.Windows.Forms.Label()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.supplierCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOrderProduct = New System.Windows.Forms.Button()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.itemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemROP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.lblSearchProduct = New System.Windows.Forms.Label()
        Me.chbLowCount = New System.Windows.Forms.CheckBox()
        Me.tplForm.SuspendLayout()
        Me.tplContents.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tplForm.Size = New System.Drawing.Size(640, 345)
        Me.tplForm.TabIndex = 36
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 4
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.Controls.Add(Me.btnClose, 0, 3)
        Me.tplContents.Controls.Add(Me.txtSearchSupplier, 0, 1)
        Me.tplContents.Controls.Add(Me.lblSearchSupplier, 0, 0)
        Me.tplContents.Controls.Add(Me.dgvSuppliers, 0, 2)
        Me.tplContents.Controls.Add(Me.btnOrderProduct, 3, 3)
        Me.tplContents.Controls.Add(Me.nudQuantity, 2, 4)
        Me.tplContents.Controls.Add(Me.lblQuantity, 2, 3)
        Me.tplContents.Controls.Add(Me.dgvItems, 2, 2)
        Me.tplContents.Controls.Add(Me.txtSearchProduct, 2, 1)
        Me.tplContents.Controls.Add(Me.lblSearchProduct, 2, 0)
        Me.tplContents.Controls.Add(Me.chbLowCount, 1, 3)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 5
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.Size = New System.Drawing.Size(610, 315)
        Me.tplContents.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Khaki
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(0, 263)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.tplContents.SetRowSpan(Me.btnClose, 2)
        Me.btnClose.Size = New System.Drawing.Size(62, 52)
        Me.btnClose.TabIndex = 75
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtSearchSupplier
        '
        Me.txtSearchSupplier.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearchSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSearchSupplier, 2)
        Me.txtSearchSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchSupplier.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSearchSupplier.Location = New System.Drawing.Point(0, 26)
        Me.txtSearchSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.txtSearchSupplier.Name = "txtSearchSupplier"
        Me.txtSearchSupplier.Size = New System.Drawing.Size(264, 27)
        Me.txtSearchSupplier.TabIndex = 74
        '
        'lblSearchSupplier
        '
        Me.lblSearchSupplier.BackColor = System.Drawing.Color.Lime
        Me.lblSearchSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblSearchSupplier, 2)
        Me.lblSearchSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearchSupplier.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchSupplier.Location = New System.Drawing.Point(0, 0)
        Me.lblSearchSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.lblSearchSupplier.Name = "lblSearchSupplier"
        Me.lblSearchSupplier.Size = New System.Drawing.Size(264, 26)
        Me.lblSearchSupplier.TabIndex = 73
        Me.lblSearchSupplier.Text = "Search Supplier"
        Me.lblSearchSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AllowUserToResizeColumns = False
        Me.dgvSuppliers.AllowUserToResizeRows = False
        Me.dgvSuppliers.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supplierCode, Me.supplierName})
        Me.tplContents.SetColumnSpan(Me.dgvSuppliers, 2)
        Me.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSuppliers.GridColor = System.Drawing.Color.Indigo
        Me.dgvSuppliers.Location = New System.Drawing.Point(0, 52)
        Me.dgvSuppliers.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.dgvSuppliers.MultiSelect = False
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSuppliers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppliers.ShowCellErrors = False
        Me.dgvSuppliers.ShowCellToolTips = False
        Me.dgvSuppliers.ShowEditingIcon = False
        Me.dgvSuppliers.ShowRowErrors = False
        Me.dgvSuppliers.Size = New System.Drawing.Size(264, 201)
        Me.dgvSuppliers.TabIndex = 72
        '
        'supplierCode
        '
        Me.supplierCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supplierCode.FillWeight = 30.0!
        Me.supplierCode.HeaderText = "Code"
        Me.supplierCode.MinimumWidth = 30
        Me.supplierCode.Name = "supplierCode"
        Me.supplierCode.ReadOnly = True
        Me.supplierCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'supplierName
        '
        Me.supplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supplierName.FillWeight = 70.0!
        Me.supplierName.HeaderText = "Supplier"
        Me.supplierName.MinimumWidth = 70
        Me.supplierName.Name = "supplierName"
        Me.supplierName.ReadOnly = True
        Me.supplierName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnOrderProduct
        '
        Me.btnOrderProduct.AutoSize = True
        Me.btnOrderProduct.BackColor = System.Drawing.Color.Khaki
        Me.btnOrderProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOrderProduct.Enabled = False
        Me.btnOrderProduct.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnOrderProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnOrderProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnOrderProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderProduct.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderProduct.Location = New System.Drawing.Point(487, 263)
        Me.btnOrderProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnOrderProduct.Name = "btnOrderProduct"
        Me.tplContents.SetRowSpan(Me.btnOrderProduct, 2)
        Me.btnOrderProduct.Size = New System.Drawing.Size(123, 52)
        Me.btnOrderProduct.TabIndex = 71
        Me.btnOrderProduct.Text = "&Order Product"
        Me.btnOrderProduct.UseVisualStyleBackColor = False
        '
        'nudQuantity
        '
        Me.nudQuantity.BackColor = System.Drawing.Color.LightGreen
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Dock = System.Windows.Forms.DockStyle.Right
        Me.nudQuantity.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantity.ForeColor = System.Drawing.Color.Black
        Me.nudQuantity.Location = New System.Drawing.Point(337, 289)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.ReadOnly = True
        Me.nudQuantity.Size = New System.Drawing.Size(150, 26)
        Me.nudQuantity.TabIndex = 70
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Lime
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblQuantity.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(337, 263)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(150, 26)
        Me.lblQuantity.TabIndex = 65
        Me.lblQuantity.Text = "Quantity to Order"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeColumns = False
        Me.dgvItems.AllowUserToResizeRows = False
        Me.dgvItems.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemCode, Me.itemDescription, Me.itemROP, Me.itemStock})
        Me.tplContents.SetColumnSpan(Me.dgvItems, 2)
        Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItems.GridColor = System.Drawing.Color.Indigo
        Me.dgvItems.Location = New System.Drawing.Point(274, 52)
        Me.dgvItems.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.ShowCellErrors = False
        Me.dgvItems.ShowCellToolTips = False
        Me.dgvItems.ShowEditingIcon = False
        Me.dgvItems.ShowRowErrors = False
        Me.dgvItems.Size = New System.Drawing.Size(336, 201)
        Me.dgvItems.TabIndex = 61
        '
        'itemCode
        '
        Me.itemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemCode.FillWeight = 30.0!
        Me.itemCode.HeaderText = "Code"
        Me.itemCode.MinimumWidth = 30
        Me.itemCode.Name = "itemCode"
        Me.itemCode.ReadOnly = True
        Me.itemCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'itemDescription
        '
        Me.itemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemDescription.FillWeight = 70.0!
        Me.itemDescription.HeaderText = "Description"
        Me.itemDescription.MinimumWidth = 70
        Me.itemDescription.Name = "itemDescription"
        Me.itemDescription.ReadOnly = True
        Me.itemDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'itemROP
        '
        Me.itemROP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemROP.FillWeight = 20.0!
        Me.itemROP.HeaderText = "ROP"
        Me.itemROP.MinimumWidth = 20
        Me.itemROP.Name = "itemROP"
        Me.itemROP.ReadOnly = True
        Me.itemROP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'itemStock
        '
        Me.itemStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemStock.FillWeight = 25.0!
        Me.itemStock.HeaderText = "Stock"
        Me.itemStock.MinimumWidth = 25
        Me.itemStock.Name = "itemStock"
        Me.itemStock.ReadOnly = True
        Me.itemStock.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSearchProduct, 2)
        Me.txtSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchProduct.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.ForeColor = System.Drawing.Color.Black
        Me.txtSearchProduct.Location = New System.Drawing.Point(274, 26)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(336, 27)
        Me.txtSearchProduct.TabIndex = 56
        '
        'lblSearchProduct
        '
        Me.lblSearchProduct.BackColor = System.Drawing.Color.Lime
        Me.lblSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblSearchProduct, 2)
        Me.lblSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearchProduct.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchProduct.Location = New System.Drawing.Point(274, 0)
        Me.lblSearchProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSearchProduct.Name = "lblSearchProduct"
        Me.lblSearchProduct.Size = New System.Drawing.Size(336, 26)
        Me.lblSearchProduct.TabIndex = 55
        Me.lblSearchProduct.Text = "Search Product"
        Me.lblSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chbLowCount
        '
        Me.chbLowCount.AutoSize = True
        Me.chbLowCount.BackColor = System.Drawing.Color.LightGreen
        Me.chbLowCount.Dock = System.Windows.Forms.DockStyle.Left
        Me.chbLowCount.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.chbLowCount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.chbLowCount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.chbLowCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbLowCount.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbLowCount.Location = New System.Drawing.Point(91, 263)
        Me.chbLowCount.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.chbLowCount.Name = "chbLowCount"
        Me.chbLowCount.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tplContents.SetRowSpan(Me.chbLowCount, 2)
        Me.chbLowCount.Size = New System.Drawing.Size(173, 52)
        Me.chbLowCount.TabIndex = 63
        Me.chbLowCount.Text = "Display Only Low Count"
        Me.chbLowCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbLowCount.UseVisualStyleBackColor = False
        '
        'frmStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(650, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStocks"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmLowStock"
        Me.tplForm.ResumeLayout(False)
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchProduct As System.Windows.Forms.Label
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents itemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemROP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chbLowCount As System.Windows.Forms.CheckBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnOrderProduct As System.Windows.Forms.Button
    Friend WithEvents txtSearchSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchSupplier As System.Windows.Forms.Label
    Friend WithEvents dgvSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents supplierCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
