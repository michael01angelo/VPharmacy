<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubCategories
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
        Me.nudMarkUp = New System.Windows.Forms.NumericUpDown()
        Me.lblMarkUpPercent = New System.Windows.Forms.Label()
        Me.lblMarkUp = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvSubCategories = New System.Windows.Forms.DataGridView()
        Me.subcategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcategoryMarkUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbxCategories = New System.Windows.Forms.ComboBox()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvSubCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 3
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tplContents.Controls.Add(Me.nudMarkUp, 1, 3)
        Me.tplContents.Controls.Add(Me.lblMarkUpPercent, 2, 3)
        Me.tplContents.Controls.Add(Me.lblMarkUp, 0, 3)
        Me.tplContents.Controls.Add(Me.lblCategory, 0, 0)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 4)
        Me.tplContents.Controls.Add(Me.dgvSubCategories, 0, 1)
        Me.tplContents.Controls.Add(Me.lblName, 0, 2)
        Me.tplContents.Controls.Add(Me.txtName, 1, 2)
        Me.tplContents.Controls.Add(Me.cbxCategories, 1, 0)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 5
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.Size = New System.Drawing.Size(310, 315)
        Me.tplContents.TabIndex = 1
        '
        'nudMarkUp
        '
        Me.nudMarkUp.BackColor = System.Drawing.Color.LightGreen
        Me.nudMarkUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudMarkUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudMarkUp.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMarkUp.ForeColor = System.Drawing.Color.Black
        Me.nudMarkUp.Location = New System.Drawing.Point(103, 229)
        Me.nudMarkUp.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.nudMarkUp.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudMarkUp.Name = "nudMarkUp"
        Me.nudMarkUp.ReadOnly = True
        Me.nudMarkUp.Size = New System.Drawing.Size(103, 26)
        Me.nudMarkUp.TabIndex = 70
        Me.nudMarkUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMarkUpPercent
        '
        Me.lblMarkUpPercent.BackColor = System.Drawing.Color.LightGreen
        Me.lblMarkUpPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMarkUpPercent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMarkUpPercent.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkUpPercent.Location = New System.Drawing.Point(206, 229)
        Me.lblMarkUpPercent.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblMarkUpPercent.Name = "lblMarkUpPercent"
        Me.lblMarkUpPercent.Size = New System.Drawing.Size(104, 26)
        Me.lblMarkUpPercent.TabIndex = 19
        Me.lblMarkUpPercent.Text = "%"
        Me.lblMarkUpPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMarkUp
        '
        Me.lblMarkUp.BackColor = System.Drawing.Color.Lime
        Me.lblMarkUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMarkUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMarkUp.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarkUp.Location = New System.Drawing.Point(0, 229)
        Me.lblMarkUp.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblMarkUp.Name = "lblMarkUp"
        Me.lblMarkUp.Size = New System.Drawing.Size(103, 26)
        Me.lblMarkUp.TabIndex = 18
        Me.lblMarkUp.Text = "SubCategory"
        Me.lblMarkUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Lime
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCategory.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(0, 0)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(103, 26)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnlControls.Location = New System.Drawing.Point(0, 265)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(310, 50)
        Me.pnlControls.TabIndex = 17
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
        Me.btnCancel.Location = New System.Drawing.Point(177, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 50)
        Me.btnCancel.TabIndex = 4
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
        Me.btnSave.Location = New System.Drawing.Point(104, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(248, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 50)
        Me.btnClose.TabIndex = 5
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
        Me.btnEdit.Location = New System.Drawing.Point(52, 0)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(52, 50)
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
        Me.btnNew.Size = New System.Drawing.Size(52, 50)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'dgvSubCategories
        '
        Me.dgvSubCategories.AllowUserToAddRows = False
        Me.dgvSubCategories.AllowUserToDeleteRows = False
        Me.dgvSubCategories.AllowUserToResizeColumns = False
        Me.dgvSubCategories.AllowUserToResizeRows = False
        Me.dgvSubCategories.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvSubCategories.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvSubCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subcategoryName, Me.subcategoryMarkUp})
        Me.tplContents.SetColumnSpan(Me.dgvSubCategories, 3)
        Me.dgvSubCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSubCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSubCategories.GridColor = System.Drawing.Color.Indigo
        Me.dgvSubCategories.Location = New System.Drawing.Point(0, 36)
        Me.dgvSubCategories.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.dgvSubCategories.MultiSelect = False
        Me.dgvSubCategories.Name = "dgvSubCategories"
        Me.dgvSubCategories.ReadOnly = True
        Me.dgvSubCategories.RowHeadersVisible = False
        Me.dgvSubCategories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSubCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSubCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubCategories.ShowCellErrors = False
        Me.dgvSubCategories.ShowCellToolTips = False
        Me.dgvSubCategories.ShowEditingIcon = False
        Me.dgvSubCategories.ShowRowErrors = False
        Me.dgvSubCategories.Size = New System.Drawing.Size(310, 147)
        Me.dgvSubCategories.TabIndex = 2
        '
        'subcategoryName
        '
        Me.subcategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subcategoryName.FillWeight = 75.0!
        Me.subcategoryName.HeaderText = "SubCategory"
        Me.subcategoryName.MinimumWidth = 75
        Me.subcategoryName.Name = "subcategoryName"
        Me.subcategoryName.ReadOnly = True
        Me.subcategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'subcategoryMarkUp
        '
        Me.subcategoryMarkUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.subcategoryMarkUp.FillWeight = 25.0!
        Me.subcategoryMarkUp.HeaderText = "MarkUp"
        Me.subcategoryMarkUp.MinimumWidth = 25
        Me.subcategoryMarkUp.Name = "subcategoryMarkUp"
        Me.subcategoryMarkUp.ReadOnly = True
        Me.subcategoryMarkUp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Lime
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(0, 193)
        Me.lblName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(103, 26)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "SubCategory"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.Color.LightGreen
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtName, 2)
        Me.txtName.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(103, 193)
        Me.txtName.Margin = New System.Windows.Forms.Padding(0)
        Me.txtName.MaxLength = 255
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 26)
        Me.txtName.TabIndex = 4
        '
        'cbxCategories
        '
        Me.cbxCategories.BackColor = System.Drawing.Color.LightGreen
        Me.tplContents.SetColumnSpan(Me.cbxCategories, 2)
        Me.cbxCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategories.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategories.ForeColor = System.Drawing.Color.Black
        Me.cbxCategories.FormattingEnabled = True
        Me.cbxCategories.Location = New System.Drawing.Point(103, 0)
        Me.cbxCategories.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.cbxCategories.MaxDropDownItems = 5
        Me.cbxCategories.Name = "cbxCategories"
        Me.cbxCategories.Size = New System.Drawing.Size(207, 27)
        Me.cbxCategories.TabIndex = 1
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
        Me.tplForm.Size = New System.Drawing.Size(340, 345)
        Me.tplForm.TabIndex = 36
        '
        'frmSubCategories
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(350, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubCategories"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SubCategories Maintenance"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dgvSubCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents dgvSubCategories As System.Windows.Forms.DataGridView
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cbxCategories As System.Windows.Forms.ComboBox
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMarkUpPercent As System.Windows.Forms.Label
    Friend WithEvents lblMarkUp As System.Windows.Forms.Label
    Friend WithEvents subcategoryName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subcategoryMarkUp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nudMarkUp As System.Windows.Forms.NumericUpDown
End Class
