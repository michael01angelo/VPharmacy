<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliersProducts
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.lblProductsSupplied = New System.Windows.Forms.Label()
        Me.btnSelectSupplier = New System.Windows.Forms.Button()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tplForm.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tplForm
        '
        Me.tplForm.BackColor = System.Drawing.Color.Aqua
        Me.tplForm.ColumnCount = 1
        Me.tplForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tplForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplForm.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplForm.Location = New System.Drawing.Point(5, 0)
        Me.tplForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(440, 295)
        Me.tplForm.TabIndex = 36
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRemoveProduct, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAddProduct, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProductsSupplied, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelectSupplier, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSupplier, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSupplier, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvProducts, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 15)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 265)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 4)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 215)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 50)
        Me.Panel1.TabIndex = 59
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
        Me.btnClose.Location = New System.Drawing.Point(348, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 50)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
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
        Me.btnRemoveProduct.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProduct.Image = Global.pharmacy.My.Resources.Resources.minus26
        Me.btnRemoveProduct.Location = New System.Drawing.Point(337, 36)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(73, 32)
        Me.btnRemoveProduct.TabIndex = 57
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
        Me.btnAddProduct.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.Image = Global.pharmacy.My.Resources.Resources.plus26
        Me.btnAddProduct.Location = New System.Drawing.Point(266, 36)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(71, 32)
        Me.btnAddProduct.TabIndex = 56
        Me.btnAddProduct.UseVisualStyleBackColor = False
        '
        'lblProductsSupplied
        '
        Me.lblProductsSupplied.BackColor = System.Drawing.Color.Lime
        Me.lblProductsSupplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblProductsSupplied, 2)
        Me.lblProductsSupplied.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProductsSupplied.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductsSupplied.Location = New System.Drawing.Point(0, 36)
        Me.lblProductsSupplied.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProductsSupplied.Name = "lblProductsSupplied"
        Me.lblProductsSupplied.Size = New System.Drawing.Size(266, 32)
        Me.lblProductsSupplied.TabIndex = 55
        Me.lblProductsSupplied.Text = "Products Supplied"
        Me.lblProductsSupplied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelectSupplier
        '
        Me.btnSelectSupplier.AutoSize = True
        Me.btnSelectSupplier.BackColor = System.Drawing.Color.Khaki
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnSelectSupplier, 2)
        Me.btnSelectSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnSelectSupplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnSelectSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnSelectSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectSupplier.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSupplier.Location = New System.Drawing.Point(266, 0)
        Me.btnSelectSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnSelectSupplier.Name = "btnSelectSupplier"
        Me.btnSelectSupplier.Size = New System.Drawing.Size(144, 26)
        Me.btnSelectSupplier.TabIndex = 54
        Me.btnSelectSupplier.Text = "Choose Supplier"
        Me.btnSelectSupplier.UseVisualStyleBackColor = False
        '
        'txtSupplier
        '
        Me.txtSupplier.BackColor = System.Drawing.Color.LightGreen
        Me.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSupplier.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.ForeColor = System.Drawing.Color.Black
        Me.txtSupplier.Location = New System.Drawing.Point(82, 0)
        Me.txtSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.ReadOnly = True
        Me.txtSupplier.Size = New System.Drawing.Size(184, 26)
        Me.txtSupplier.TabIndex = 53
        '
        'lblSupplier
        '
        Me.lblSupplier.BackColor = System.Drawing.Color.Lime
        Me.lblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSupplier.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.Location = New System.Drawing.Point(0, 0)
        Me.lblSupplier.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(82, 26)
        Me.lblSupplier.TabIndex = 52
        Me.lblSupplier.Text = "Supplier"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription})
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgvProducts, 4)
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.GridColor = System.Drawing.Color.Indigo
        Me.dgvProducts.Location = New System.Drawing.Point(0, 68)
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
        Me.dgvProducts.Size = New System.Drawing.Size(410, 137)
        Me.dgvProducts.TabIndex = 58
        '
        'productCode
        '
        Me.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productCode.FillWeight = 30.0!
        Me.productCode.HeaderText = "Code"
        Me.productCode.MinimumWidth = 30
        Me.productCode.Name = "productCode"
        Me.productCode.ReadOnly = True
        Me.productCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'productDescription
        '
        Me.productDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productDescription.FillWeight = 70.0!
        Me.productDescription.HeaderText = "Description"
        Me.productDescription.MinimumWidth = 70
        Me.productDescription.Name = "productDescription"
        Me.productDescription.ReadOnly = True
        Me.productDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmSuppliersProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(450, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuppliersProducts"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSuppliersProducts"
        Me.tplForm.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectSupplier As System.Windows.Forms.Button
    Friend WithEvents lblProductsSupplied As System.Windows.Forms.Label
    Friend WithEvents btnRemoveProduct As System.Windows.Forms.Button
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
