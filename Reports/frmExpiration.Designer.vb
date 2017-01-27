<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpiration
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
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.itemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemBatch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemExpiry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxSubCategories = New System.Windows.Forms.ComboBox()
        Me.cbxCategories = New System.Windows.Forms.ComboBox()
        Me.lblSubCategory = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.lblSearchProduct = New System.Windows.Forms.Label()
        Me.chbNearlyExpired = New System.Windows.Forms.CheckBox()
        Me.tplForm.SuspendLayout()
        Me.tplContents.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.tplForm.Size = New System.Drawing.Size(590, 395)
        Me.tplForm.TabIndex = 36
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 2
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tplContents.Controls.Add(Me.lblDateTime, 0, 0)
        Me.tplContents.Controls.Add(Me.Panel1, 0, 6)
        Me.tplContents.Controls.Add(Me.dgvItems, 0, 5)
        Me.tplContents.Controls.Add(Me.cbxSubCategories, 1, 4)
        Me.tplContents.Controls.Add(Me.cbxCategories, 0, 4)
        Me.tplContents.Controls.Add(Me.lblSubCategory, 1, 3)
        Me.tplContents.Controls.Add(Me.lblCategory, 0, 3)
        Me.tplContents.Controls.Add(Me.txtSearchProduct, 0, 2)
        Me.tplContents.Controls.Add(Me.lblSearchProduct, 0, 1)
        Me.tplContents.Controls.Add(Me.chbNearlyExpired, 1, 0)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 7
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.Size = New System.Drawing.Size(560, 365)
        Me.tplContents.TabIndex = 0
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Lime
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateTime.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(0, 0)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(242, 26)
        Me.lblDateTime.TabIndex = 65
        Me.lblDateTime.Text = "DateTime"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.tplContents.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 315)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 50)
        Me.Panel1.TabIndex = 64
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
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeColumns = False
        Me.dgvItems.AllowUserToResizeRows = False
        Me.dgvItems.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemCode, Me.itemDescription, Me.itemBatch, Me.itemExpiry})
        Me.tplContents.SetColumnSpan(Me.dgvItems, 2)
        Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItems.GridColor = System.Drawing.Color.Indigo
        Me.dgvItems.Location = New System.Drawing.Point(0, 160)
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
        Me.dgvItems.Size = New System.Drawing.Size(560, 145)
        Me.dgvItems.TabIndex = 61
        '
        'itemCode
        '
        Me.itemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemCode.FillWeight = 20.0!
        Me.itemCode.HeaderText = "Code"
        Me.itemCode.MinimumWidth = 20
        Me.itemCode.Name = "itemCode"
        Me.itemCode.ReadOnly = True
        Me.itemCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'itemDescription
        '
        Me.itemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemDescription.FillWeight = 50.0!
        Me.itemDescription.HeaderText = "Description"
        Me.itemDescription.MinimumWidth = 50
        Me.itemDescription.Name = "itemDescription"
        Me.itemDescription.ReadOnly = True
        Me.itemDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'itemBatch
        '
        Me.itemBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemBatch.FillWeight = 30.0!
        Me.itemBatch.HeaderText = "Lot/Batch #"
        Me.itemBatch.MinimumWidth = 30
        Me.itemBatch.Name = "itemBatch"
        Me.itemBatch.ReadOnly = True
        Me.itemBatch.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'itemExpiry
        '
        Me.itemExpiry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemExpiry.FillWeight = 35.0!
        Me.itemExpiry.HeaderText = "Expiry"
        Me.itemExpiry.MinimumWidth = 35
        Me.itemExpiry.Name = "itemExpiry"
        Me.itemExpiry.ReadOnly = True
        Me.itemExpiry.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cbxSubCategories
        '
        Me.cbxSubCategories.BackColor = System.Drawing.Color.LightGreen
        Me.cbxSubCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxSubCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSubCategories.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSubCategories.ForeColor = System.Drawing.Color.Black
        Me.cbxSubCategories.FormattingEnabled = True
        Me.cbxSubCategories.Location = New System.Drawing.Point(262, 124)
        Me.cbxSubCategories.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.cbxSubCategories.MaxDropDownItems = 5
        Me.cbxSubCategories.Name = "cbxSubCategories"
        Me.cbxSubCategories.Size = New System.Drawing.Size(298, 27)
        Me.cbxSubCategories.TabIndex = 60
        '
        'cbxCategories
        '
        Me.cbxCategories.BackColor = System.Drawing.Color.LightGreen
        Me.cbxCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategories.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategories.ForeColor = System.Drawing.Color.Black
        Me.cbxCategories.FormattingEnabled = True
        Me.cbxCategories.Location = New System.Drawing.Point(0, 124)
        Me.cbxCategories.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.cbxCategories.MaxDropDownItems = 5
        Me.cbxCategories.Name = "cbxCategories"
        Me.cbxCategories.Size = New System.Drawing.Size(252, 27)
        Me.cbxCategories.TabIndex = 59
        '
        'lblSubCategory
        '
        Me.lblSubCategory.BackColor = System.Drawing.Color.Lime
        Me.lblSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubCategory.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubCategory.Location = New System.Drawing.Point(262, 98)
        Me.lblSubCategory.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblSubCategory.Name = "lblSubCategory"
        Me.lblSubCategory.Size = New System.Drawing.Size(298, 26)
        Me.lblSubCategory.TabIndex = 58
        Me.lblSubCategory.Text = "Sub Category"
        Me.lblSubCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Lime
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCategory.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(0, 98)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(252, 26)
        Me.lblCategory.TabIndex = 57
        Me.lblCategory.Text = "Category"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSearchProduct, 2)
        Me.txtSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchProduct.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.ForeColor = System.Drawing.Color.Black
        Me.txtSearchProduct.Location = New System.Drawing.Point(0, 62)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.ReadOnly = True
        Me.txtSearchProduct.Size = New System.Drawing.Size(560, 27)
        Me.txtSearchProduct.TabIndex = 56
        '
        'lblSearchProduct
        '
        Me.lblSearchProduct.BackColor = System.Drawing.Color.Lime
        Me.lblSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblSearchProduct, 2)
        Me.lblSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearchProduct.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchProduct.Location = New System.Drawing.Point(0, 36)
        Me.lblSearchProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSearchProduct.Name = "lblSearchProduct"
        Me.lblSearchProduct.Size = New System.Drawing.Size(560, 26)
        Me.lblSearchProduct.TabIndex = 55
        Me.lblSearchProduct.Text = "Search Product"
        Me.lblSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chbNearlyExpired
        '
        Me.chbNearlyExpired.AutoSize = True
        Me.chbNearlyExpired.BackColor = System.Drawing.Color.LightGreen
        Me.chbNearlyExpired.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbNearlyExpired.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.chbNearlyExpired.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.chbNearlyExpired.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.chbNearlyExpired.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNearlyExpired.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNearlyExpired.Location = New System.Drawing.Point(252, 0)
        Me.chbNearlyExpired.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.chbNearlyExpired.Name = "chbNearlyExpired"
        Me.chbNearlyExpired.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbNearlyExpired.Size = New System.Drawing.Size(308, 26)
        Me.chbNearlyExpired.TabIndex = 63
        Me.chbNearlyExpired.Text = "Display Only (Almost) Expired"
        Me.chbNearlyExpired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbNearlyExpired.UseVisualStyleBackColor = False
        '
        'frmExpiration
        '
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
        Me.Name = "frmExpiration"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmLowStock"
        Me.tplForm.ResumeLayout(False)
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtSearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchProduct As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblSubCategory As System.Windows.Forms.Label
    Friend WithEvents cbxCategories As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSubCategories As System.Windows.Forms.ComboBox
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents chbNearlyExpired As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents itemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemBatch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemExpiry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
End Class
