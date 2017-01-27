<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.supplierCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 4
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tplContents.Controls.Add(Me.txtAddress, 4, 5)
        Me.tplContents.Controls.Add(Me.lblSearch, 0, 0)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 8)
        Me.tplContents.Controls.Add(Me.dgvSuppliers, 0, 1)
        Me.tplContents.Controls.Add(Me.lblName, 2, 2)
        Me.tplContents.Controls.Add(Me.txtName, 2, 3)
        Me.tplContents.Controls.Add(Me.lblAddress, 3, 4)
        Me.tplContents.Controls.Add(Me.lblContact, 0, 6)
        Me.tplContents.Controls.Add(Me.txtPerson, 0, 7)
        Me.tplContents.Controls.Add(Me.lblContactNumber, 2, 6)
        Me.tplContents.Controls.Add(Me.txtNumber, 2, 7)
        Me.tplContents.Controls.Add(Me.txtCode, 0, 3)
        Me.tplContents.Controls.Add(Me.lblTelephone, 0, 4)
        Me.tplContents.Controls.Add(Me.txtTelephone, 0, 5)
        Me.tplContents.Controls.Add(Me.lblFax, 1, 4)
        Me.tplContents.Controls.Add(Me.txtFax, 1, 5)
        Me.tplContents.Controls.Add(Me.lblCode, 0, 2)
        Me.tplContents.Controls.Add(Me.txtSearch, 2, 0)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 9
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.Size = New System.Drawing.Size(590, 415)
        Me.tplContents.TabIndex = 0
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsReturn = True
        Me.txtAddress.BackColor = System.Drawing.Color.LightGreen
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAddress.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(364, 267)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.tplContents.SetRowSpan(Me.txtAddress, 3)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(226, 88)
        Me.txtAddress.TabIndex = 37
        Me.txtAddress.WordWrap = False
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.Lime
        Me.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblSearch, 2)
        Me.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSearch.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(0, 0)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(236, 26)
        Me.lblSearch.TabIndex = 24
        Me.lblSearch.Text = "Search"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 6)
        Me.pnlControls.Controls.Add(Me.btnCancel)
        Me.pnlControls.Controls.Add(Me.btnSave)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Controls.Add(Me.btnEdit)
        Me.pnlControls.Controls.Add(Me.btnNew)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(3, 368)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(584, 44)
        Me.pnlControls.TabIndex = 23
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
        Me.btnCancel.Location = New System.Drawing.Point(451, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 44)
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
        Me.btnSave.Location = New System.Drawing.Point(104, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(56, 44)
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
        Me.btnClose.Location = New System.Drawing.Point(522, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 44)
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
        Me.btnEdit.Location = New System.Drawing.Point(52, 0)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(52, 44)
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
        Me.btnNew.Size = New System.Drawing.Size(52, 44)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AllowUserToResizeColumns = False
        Me.dgvSuppliers.AllowUserToResizeRows = False
        Me.dgvSuppliers.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvSuppliers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supplierCode, Me.supplierName, Me.supplierPerson, Me.supplierNumber})
        Me.tplContents.SetColumnSpan(Me.dgvSuppliers, 4)
        Me.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSuppliers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSuppliers.GridColor = System.Drawing.Color.Indigo
        Me.dgvSuppliers.Location = New System.Drawing.Point(0, 36)
        Me.dgvSuppliers.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvSuppliers.MultiSelect = False
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.RowHeadersWidth = 26
        Me.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSuppliers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuppliers.ShowCellErrors = False
        Me.dgvSuppliers.ShowCellToolTips = False
        Me.dgvSuppliers.ShowEditingIcon = False
        Me.dgvSuppliers.ShowRowErrors = False
        Me.dgvSuppliers.Size = New System.Drawing.Size(590, 133)
        Me.dgvSuppliers.TabIndex = 0
        '
        'supplierCode
        '
        Me.supplierCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supplierCode.FillWeight = 30.0!
        Me.supplierCode.HeaderText = "Code"
        Me.supplierCode.MinimumWidth = 30
        Me.supplierCode.Name = "supplierCode"
        Me.supplierCode.ReadOnly = True
        '
        'supplierName
        '
        Me.supplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supplierName.HeaderText = "Name"
        Me.supplierName.MinimumWidth = 100
        Me.supplierName.Name = "supplierName"
        Me.supplierName.ReadOnly = True
        '
        'supplierPerson
        '
        Me.supplierPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supplierPerson.FillWeight = 50.0!
        Me.supplierPerson.HeaderText = "Contact Person"
        Me.supplierPerson.MinimumWidth = 50
        Me.supplierPerson.Name = "supplierPerson"
        Me.supplierPerson.ReadOnly = True
        '
        'supplierNumber
        '
        Me.supplierNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.supplierNumber.FillWeight = 40.0!
        Me.supplierNumber.HeaderText = "Contact #"
        Me.supplierNumber.MinimumWidth = 40
        Me.supplierNumber.Name = "supplierNumber"
        Me.supplierNumber.ReadOnly = True
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Lime
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblName, 2)
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(236, 179)
        Me.lblName.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(354, 26)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LightGreen
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtName, 2)
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(236, 205)
        Me.txtName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtName.MaxLength = 255
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(354, 26)
        Me.txtName.TabIndex = 4
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Lime
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddress.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(364, 241)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(226, 26)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.Lime
        Me.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.lblContact, 2)
        Me.lblContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContact.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(0, 303)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(236, 26)
        Me.lblContact.TabIndex = 13
        Me.lblContact.Text = "Contact Person"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPerson
        '
        Me.txtPerson.BackColor = System.Drawing.Color.LightGreen
        Me.txtPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtPerson, 2)
        Me.txtPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPerson.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson.ForeColor = System.Drawing.Color.Black
        Me.txtPerson.Location = New System.Drawing.Point(0, 329)
        Me.txtPerson.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(236, 26)
        Me.txtPerson.TabIndex = 14
        Me.txtPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblContactNumber
        '
        Me.lblContactNumber.BackColor = System.Drawing.Color.Lime
        Me.lblContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblContactNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContactNumber.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(246, 303)
        Me.lblContactNumber.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(108, 26)
        Me.lblContactNumber.TabIndex = 15
        Me.lblContactNumber.Text = "Contact #"
        Me.lblContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumber
        '
        Me.txtNumber.BackColor = System.Drawing.Color.LightGreen
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumber.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNumber.Location = New System.Drawing.Point(246, 329)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(108, 26)
        Me.txtNumber.TabIndex = 16
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.LightGreen
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.Location = New System.Drawing.Point(0, 205)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(118, 26)
        Me.txtCode.TabIndex = 2
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTelephone
        '
        Me.lblTelephone.BackColor = System.Drawing.Color.Lime
        Me.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelephone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTelephone.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(0, 241)
        Me.lblTelephone.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(118, 26)
        Me.lblTelephone.TabIndex = 7
        Me.lblTelephone.Text = "Telephone #"
        Me.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelephone
        '
        Me.txtTelephone.BackColor = System.Drawing.Color.LightGreen
        Me.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelephone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTelephone.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.ForeColor = System.Drawing.Color.Black
        Me.txtTelephone.Location = New System.Drawing.Point(0, 267)
        Me.txtTelephone.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(118, 26)
        Me.txtTelephone.TabIndex = 8
        Me.txtTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFax
        '
        Me.lblFax.BackColor = System.Drawing.Color.Lime
        Me.lblFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFax.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.Location = New System.Drawing.Point(128, 241)
        Me.lblFax.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(108, 26)
        Me.lblFax.TabIndex = 9
        Me.lblFax.Text = "Fax #"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.LightGreen
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFax.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.ForeColor = System.Drawing.Color.Black
        Me.txtFax.Location = New System.Drawing.Point(128, 267)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(108, 26)
        Me.txtFax.TabIndex = 10
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.Lime
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(0, 179)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(118, 26)
        Me.lblCode.TabIndex = 1
        Me.lblCode.Text = "Code"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.LightGreen
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplContents.SetColumnSpan(Me.txtSearch, 2)
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(236, 0)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(354, 26)
        Me.txtSearch.TabIndex = 25
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.tplForm.Size = New System.Drawing.Size(620, 445)
        Me.tplForm.TabIndex = 36
        '
        'frmSuppliers
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(630, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuppliers"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Suppliers"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents txtPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents supplierCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierPerson As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
End Class
