<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtTotalRevenue = New System.Windows.Forms.TextBox()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.dgvReceipts = New System.Windows.Forms.DataGridView()
        Me.receiptCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiptDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiptCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiptRevenue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxRange = New System.Windows.Forms.ComboBox()
        Me.tplForm.SuspendLayout()
        Me.tplContents.SuspendLayout()
        CType(Me.dgvReceipts, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tplForm.Location = New System.Drawing.Point(7, 0)
        Me.tplForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(686, 344)
        Me.tplForm.TabIndex = 36
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 3
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tplContents.Controls.Add(Me.dtpStartDate, 1, 1)
        Me.tplContents.Controls.Add(Me.dtpEndDate, 2, 1)
        Me.tplContents.Controls.Add(Me.btnClose, 2, 3)
        Me.tplContents.Controls.Add(Me.txtTotalRevenue, 1, 3)
        Me.tplContents.Controls.Add(Me.lblDateTime, 0, 3)
        Me.tplContents.Controls.Add(Me.lblEndDate, 2, 0)
        Me.tplContents.Controls.Add(Me.lblStartDate, 1, 0)
        Me.tplContents.Controls.Add(Me.lblRange, 0, 0)
        Me.tplContents.Controls.Add(Me.dgvReceipts, 0, 2)
        Me.tplContents.Controls.Add(Me.cbxRange, 0, 1)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 4
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.tplContents.Size = New System.Drawing.Size(656, 314)
        Me.tplContents.TabIndex = 0
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarFont = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.LightGreen
        Me.dtpStartDate.CalendarTitleBackColor = System.Drawing.Color.LightGreen
        Me.dtpStartDate.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.Indigo
        Me.dtpStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpStartDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpStartDate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(218, 26)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(218, 26)
        Me.dtpStartDate.TabIndex = 67
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CalendarFont = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.CalendarForeColor = System.Drawing.Color.Black
        Me.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.LightGreen
        Me.dtpEndDate.CalendarTitleBackColor = System.Drawing.Color.LightGreen
        Me.dtpEndDate.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtpEndDate.CalendarTrailingForeColor = System.Drawing.Color.Indigo
        Me.dtpEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpEndDate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(436, 26)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(220, 26)
        Me.dtpEndDate.TabIndex = 66
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Khaki
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(605, 275)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(51, 39)
        Me.btnClose.TabIndex = 58
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtTotalRevenue
        '
        Me.txtTotalRevenue.BackColor = System.Drawing.Color.LightGreen
        Me.txtTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalRevenue.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRevenue.ForeColor = System.Drawing.Color.Black
        Me.txtTotalRevenue.Location = New System.Drawing.Point(218, 275)
        Me.txtTotalRevenue.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTotalRevenue.Name = "txtTotalRevenue"
        Me.txtTotalRevenue.ReadOnly = True
        Me.txtTotalRevenue.Size = New System.Drawing.Size(218, 39)
        Me.txtTotalRevenue.TabIndex = 57
        Me.txtTotalRevenue.Text = "0.00"
        Me.txtTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Lime
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateTime.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(0, 275)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(218, 39)
        Me.lblDateTime.TabIndex = 56
        Me.lblDateTime.Text = "Total Revenue"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEndDate
        '
        Me.lblEndDate.BackColor = System.Drawing.Color.Lime
        Me.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEndDate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(436, 0)
        Me.lblEndDate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(220, 26)
        Me.lblEndDate.TabIndex = 54
        Me.lblEndDate.Text = "End Date"
        Me.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStartDate
        '
        Me.lblStartDate.BackColor = System.Drawing.Color.Lime
        Me.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStartDate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(218, 0)
        Me.lblStartDate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(218, 26)
        Me.lblStartDate.TabIndex = 53
        Me.lblStartDate.Text = "Start Date"
        Me.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRange
        '
        Me.lblRange.BackColor = System.Drawing.Color.Lime
        Me.lblRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRange.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRange.Location = New System.Drawing.Point(0, 0)
        Me.lblRange.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(218, 26)
        Me.lblRange.TabIndex = 52
        Me.lblRange.Text = "Range"
        Me.lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvReceipts
        '
        Me.dgvReceipts.AllowUserToAddRows = False
        Me.dgvReceipts.AllowUserToDeleteRows = False
        Me.dgvReceipts.AllowUserToResizeColumns = False
        Me.dgvReceipts.AllowUserToResizeRows = False
        Me.dgvReceipts.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReceipts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.receiptCode, Me.receiptDate, Me.receiptCashier, Me.receiptRevenue})
        Me.tplContents.SetColumnSpan(Me.dgvReceipts, 3)
        Me.dgvReceipts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReceipts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvReceipts.GridColor = System.Drawing.Color.Indigo
        Me.dgvReceipts.Location = New System.Drawing.Point(0, 62)
        Me.dgvReceipts.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.dgvReceipts.MultiSelect = False
        Me.dgvReceipts.Name = "dgvReceipts"
        Me.dgvReceipts.ReadOnly = True
        Me.dgvReceipts.RowHeadersVisible = False
        Me.dgvReceipts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvReceipts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReceipts.ShowCellErrors = False
        Me.dgvReceipts.ShowCellToolTips = False
        Me.dgvReceipts.ShowEditingIcon = False
        Me.dgvReceipts.ShowRowErrors = False
        Me.dgvReceipts.Size = New System.Drawing.Size(656, 203)
        Me.dgvReceipts.TabIndex = 55
        '
        'receiptCode
        '
        Me.receiptCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.receiptCode.FillWeight = 35.0!
        Me.receiptCode.HeaderText = "Receipt #"
        Me.receiptCode.MinimumWidth = 35
        Me.receiptCode.Name = "receiptCode"
        Me.receiptCode.ReadOnly = True
        Me.receiptCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'receiptDate
        '
        Me.receiptDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.receiptDate.FillWeight = 50.0!
        Me.receiptDate.HeaderText = "Date Time"
        Me.receiptDate.MinimumWidth = 50
        Me.receiptDate.Name = "receiptDate"
        Me.receiptDate.ReadOnly = True
        Me.receiptDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'receiptCashier
        '
        Me.receiptCashier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.receiptCashier.FillWeight = 30.0!
        Me.receiptCashier.HeaderText = "Cashier"
        Me.receiptCashier.MinimumWidth = 30
        Me.receiptCashier.Name = "receiptCashier"
        Me.receiptCashier.ReadOnly = True
        Me.receiptCashier.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'receiptRevenue
        '
        Me.receiptRevenue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.receiptRevenue.FillWeight = 15.0!
        Me.receiptRevenue.HeaderText = "Revenue"
        Me.receiptRevenue.MinimumWidth = 15
        Me.receiptRevenue.Name = "receiptRevenue"
        Me.receiptRevenue.ReadOnly = True
        Me.receiptRevenue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cbxRange
        '
        Me.cbxRange.BackColor = System.Drawing.Color.LightGreen
        Me.cbxRange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRange.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRange.ForeColor = System.Drawing.Color.Black
        Me.cbxRange.FormattingEnabled = True
        Me.cbxRange.Items.AddRange(New Object() {"<Custom>", "Daily", "Weekly", "Monthly", "Yearly"})
        Me.cbxRange.Location = New System.Drawing.Point(0, 26)
        Me.cbxRange.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxRange.MaxDropDownItems = 5
        Me.cbxRange.Name = "cbxRange"
        Me.cbxRange.Size = New System.Drawing.Size(218, 27)
        Me.cbxRange.TabIndex = 59
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(700, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSales"
        Me.Padding = New System.Windows.Forms.Padding(7, 0, 7, 6)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSalesReport"
        Me.tplForm.ResumeLayout(False)
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.dgvReceipts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents dgvReceipts As System.Windows.Forms.DataGridView
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents txtTotalRevenue As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cbxRange As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents receiptCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receiptDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receiptCashier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receiptRevenue As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
