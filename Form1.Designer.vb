<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.tplControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.txtDateTime = New System.Windows.Forms.TextBox()
        Me.cbxCategories = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.chbLowCount = New System.Windows.Forms.CheckBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.mnuUser = New System.Windows.Forms.MenuStrip()
        Me.userMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.userViewDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.userEditDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.tplControls.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuUser.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(708, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 31
        '
        'tplForm
        '
        Me.tplForm.BackColor = System.Drawing.Color.Aqua
        Me.tplForm.ColumnCount = 1
        Me.tplForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplForm.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplForm.Location = New System.Drawing.Point(12, 89)
        Me.tplForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(244, 128)
        Me.tplForm.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.BackColor = System.Drawing.Color.LightGreen
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(447, 23)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 66)
        Me.TextBox2.TabIndex = 36
        Me.TextBox2.WordWrap = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Wheat
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Maiandra GD", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(523, 292)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(424, 30)
        Me.lblTitle.TabIndex = 48
        Me.lblTitle.Text = "V-PHARMA"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.Color.Transparent
        Me.pnlControls.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlControls.ForeColor = System.Drawing.Color.Black
        Me.pnlControls.Location = New System.Drawing.Point(428, 163)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(292, 60)
        Me.pnlControls.TabIndex = 49
        '
        'tplControls
        '
        Me.tplControls.BackColor = System.Drawing.Color.Transparent
        Me.tplControls.ColumnCount = 3
        Me.tplControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplControls.Controls.Add(Me.btnVoid, 1, 0)
        Me.tplControls.Controls.Add(Me.btnLogOut, 2, 0)
        Me.tplControls.Controls.Add(Me.btnGenerate, 0, 0)
        Me.tplControls.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplControls.ForeColor = System.Drawing.Color.Black
        Me.tplControls.Location = New System.Drawing.Point(122, 254)
        Me.tplControls.Margin = New System.Windows.Forms.Padding(0)
        Me.tplControls.Name = "tplControls"
        Me.tplControls.RowCount = 1
        Me.tplControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tplControls.Size = New System.Drawing.Size(379, 100)
        Me.tplControls.TabIndex = 50
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.Khaki
        Me.btnVoid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVoid.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnVoid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnVoid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoid.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.Location = New System.Drawing.Point(141, 0)
        Me.btnVoid.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(96, 100)
        Me.btnVoid.TabIndex = 4
        Me.btnVoid.Text = "Void OR"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Khaki
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(252, 0)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(127, 100)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Khaki
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(0, 0)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(126, 100)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Lime
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(8, 8)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(220, 27)
        Me.lblDateTime.TabIndex = 51
        Me.lblDateTime.Text = "DateTime"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDateTime
        '
        Me.txtDateTime.BackColor = System.Drawing.Color.LightGreen
        Me.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateTime.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTime.ForeColor = System.Drawing.Color.Black
        Me.txtDateTime.Location = New System.Drawing.Point(242, 8)
        Me.txtDateTime.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.ReadOnly = True
        Me.txtDateTime.Size = New System.Drawing.Size(338, 26)
        Me.txtDateTime.TabIndex = 52
        Me.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxCategories
        '
        Me.cbxCategories.BackColor = System.Drawing.Color.LightGreen
        Me.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategories.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategories.ForeColor = System.Drawing.Color.Black
        Me.cbxCategories.FormattingEnabled = True
        Me.cbxCategories.Location = New System.Drawing.Point(353, 113)
        Me.cbxCategories.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.cbxCategories.MaxDropDownItems = 5
        Me.cbxCategories.Name = "cbxCategories"
        Me.cbxCategories.Size = New System.Drawing.Size(254, 27)
        Me.cbxCategories.TabIndex = 53
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.LightGreen
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.ForeColor = System.Drawing.Color.Black
        Me.MaskedTextBox1.HidePromptOnLeave = True
        Me.MaskedTextBox1.Location = New System.Drawing.Point(828, 147)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaskedTextBox1.Mask = "000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ResetOnSpace = False
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 27)
        Me.MaskedTextBox1.TabIndex = 54
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Location = New System.Drawing.Point(878, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 50)
        Me.Panel1.TabIndex = 55
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
        'chbLowCount
        '
        Me.chbLowCount.AutoSize = True
        Me.chbLowCount.BackColor = System.Drawing.Color.LightGreen
        Me.chbLowCount.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.chbLowCount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.chbLowCount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.chbLowCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbLowCount.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbLowCount.Location = New System.Drawing.Point(955, 113)
        Me.chbLowCount.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.chbLowCount.Name = "chbLowCount"
        Me.chbLowCount.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.chbLowCount.Size = New System.Drawing.Size(233, 23)
        Me.chbLowCount.TabIndex = 64
        Me.chbLowCount.Text = "Display Only Low Count"
        Me.chbLowCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbLowCount.UseVisualStyleBackColor = False
        '
        'dtp
        '
        Me.dtp.CalendarFont = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.CalendarForeColor = System.Drawing.Color.Black
        Me.dtp.CalendarMonthBackground = System.Drawing.Color.LightGreen
        Me.dtp.CalendarTitleBackColor = System.Drawing.Color.LightGreen
        Me.dtp.CalendarTitleForeColor = System.Drawing.Color.Black
        Me.dtp.CalendarTrailingForeColor = System.Drawing.Color.Indigo
        Me.dtp.CustomFormat = "yyyy-MM-dd"
        Me.dtp.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(304, 72)
        Me.dtp.Margin = New System.Windows.Forms.Padding(0)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(143, 26)
        Me.dtp.TabIndex = 65
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveProduct.AutoSize = True
        Me.btnRemoveProduct.Image = Global.pharmacy.My.Resources.Resources.minus26
        Me.btnRemoveProduct.Location = New System.Drawing.Point(754, 201)
        Me.btnRemoveProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(480, 32)
        Me.btnRemoveProduct.TabIndex = 29
        Me.btnRemoveProduct.UseVisualStyleBackColor = True
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.Image = Global.pharmacy.My.Resources.Resources.clinic128
        Me.pbxLogo.Location = New System.Drawing.Point(19, 298)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(77, 88)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 47
        Me.pbxLogo.TabStop = False
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddProduct.AutoSize = True
        Me.btnAddProduct.Image = Global.pharmacy.My.Resources.Resources.plus26
        Me.btnAddProduct.Location = New System.Drawing.Point(523, 381)
        Me.btnAddProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(730, 32)
        Me.btnAddProduct.TabIndex = 30
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(1014, 287)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(50, 35)
        Me.lblUser.TabIndex = 66
        Me.lblUser.Text = "User:"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuUser
        '
        Me.mnuUser.BackColor = System.Drawing.Color.Aqua
        Me.mnuUser.Dock = System.Windows.Forms.DockStyle.None
        Me.mnuUser.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUser.GripMargin = New System.Windows.Forms.Padding(0)
        Me.mnuUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userMain})
        Me.mnuUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuUser.Location = New System.Drawing.Point(982, 322)
        Me.mnuUser.Name = "mnuUser"
        Me.mnuUser.Padding = New System.Windows.Forms.Padding(0)
        Me.mnuUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuUser.Size = New System.Drawing.Size(93, 24)
        Me.mnuUser.TabIndex = 67
        Me.mnuUser.Text = "User Action"
        '
        'userMain
        '
        Me.userMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userViewDetails, Me.userEditDetails})
        Me.userMain.Name = "userMain"
        Me.userMain.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.userMain.Size = New System.Drawing.Size(91, 24)
        Me.userMain.Text = "UserName"
        '
        'userViewDetails
        '
        Me.userViewDetails.Name = "userViewDetails"
        Me.userViewDetails.Size = New System.Drawing.Size(209, 24)
        Me.userViewDetails.Text = "View Details"
        '
        'userEditDetails
        '
        Me.userEditDetails.Name = "userEditDetails"
        Me.userEditDetails.Size = New System.Drawing.Size(209, 24)
        Me.userEditDetails.Text = "ToolStripMenuItem2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.pharmacy.My.Resources.Resources.exit26
        Me.Button1.Location = New System.Drawing.Point(1101, 346)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 35)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Log Out"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.LightGreen
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown1.Location = New System.Drawing.Point(644, 113)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(0)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDown1.TabIndex = 69
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AcceptButton = Me.btnRemoveProduct
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1250, 422)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mnuUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.chbLowCount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.cbxCategories)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.tplControls)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tplForm)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnRemoveProduct)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tplControls.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuUser.ResumeLayout(False)
        Me.mnuUser.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRemoveProduct As System.Windows.Forms.Button
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents tplControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents txtDateTime As System.Windows.Forms.TextBox
    Friend WithEvents cbxCategories As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents chbLowCount As System.Windows.Forms.CheckBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents mnuUser As System.Windows.Forms.MenuStrip
    Friend WithEvents userMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents userViewDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents userEditDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
