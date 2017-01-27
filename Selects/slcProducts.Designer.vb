<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class slcProducts
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 2
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tplContents.Controls.Add(Me.txtSearch, 1, 0)
        Me.tplContents.Controls.Add(Me.lblSearch, 0, 0)
        Me.tplContents.Controls.Add(Me.btnSelect, 1, 2)
        Me.tplContents.Controls.Add(Me.dgvProducts, 0, 1)
        Me.tplContents.Controls.Add(Me.btnCancel, 0, 2)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 3
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tplContents.Size = New System.Drawing.Size(360, 365)
        Me.tplContents.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(108, 0)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSearch.MaxLength = 255
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(252, 26)
        Me.txtSearch.TabIndex = 23
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
        Me.lblSearch.Size = New System.Drawing.Size(108, 26)
        Me.lblSearch.TabIndex = 22
        Me.lblSearch.Text = "Search"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSelect
        '
        Me.btnSelect.AutoSize = True
        Me.btnSelect.BackColor = System.Drawing.Color.Khaki
        Me.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(235, 335)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(125, 30)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select Product"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription})
        Me.tplContents.SetColumnSpan(Me.dgvProducts, 2)
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.GridColor = System.Drawing.Color.Indigo
        Me.dgvProducts.Location = New System.Drawing.Point(0, 36)
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
        Me.dgvProducts.Size = New System.Drawing.Size(360, 289)
        Me.dgvProducts.TabIndex = 0
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
        Me.productDescription.FillWeight = 70.0!
        Me.productDescription.HeaderText = "Description"
        Me.productDescription.MinimumWidth = 70
        Me.productDescription.Name = "productDescription"
        Me.productDescription.ReadOnly = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Khaki
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(0, 335)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
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
        Me.tplForm.Size = New System.Drawing.Size(390, 395)
        Me.tplForm.TabIndex = 36
        '
        'slcProducts
        '
        Me.AcceptButton = Me.btnSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "slcProducts"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Product"
        Me.TopMost = True
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
End Class
