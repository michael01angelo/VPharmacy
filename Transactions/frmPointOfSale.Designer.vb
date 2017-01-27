<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPointOfSale
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPointOfSale))
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.tplPointOfSale = New System.Windows.Forms.TableLayoutPanel()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.txtDueTotal = New System.Windows.Forms.TextBox()
        Me.lblDueTotal = New System.Windows.Forms.Label()
        Me.txtTotalItems = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.txtDiscountValue = New System.Windows.Forms.TextBox()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblDiscountValue = New System.Windows.Forms.Label()
        Me.lblDiscountPercent = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.txtReceiptNumber = New System.Windows.Forms.TextBox()
        Me.lblReceiptNumber = New System.Windows.Forms.Label()
        Me.txtCashier = New System.Windows.Forms.TextBox()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.txtDateTime = New System.Windows.Forms.TextBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.itemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBorderRight = New System.Windows.Forms.Panel()
        Me.pnlBorderLeft = New System.Windows.Forms.Panel()
        Me.pnlBorderBottom = New System.Windows.Forms.Panel()
        Me.pnlBorderTop = New System.Windows.Forms.Panel()
        Me.tplRight = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCashR = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.MaskedTextBox()
        Me.btnProductDown = New System.Windows.Forms.Button()
        Me.btnProductUp = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.lblCashR = New System.Windows.Forms.Label()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.cbxDiscounts = New System.Windows.Forms.ComboBox()
        Me.lblDiscountR = New System.Windows.Forms.Label()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.productCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnQuantity = New System.Windows.Forms.Button()
        Me.txtProductInput = New System.Windows.Forms.TextBox()
        Me.lblProductInput = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.tplControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnProductInput = New System.Windows.Forms.Button()
        Me.tplItemControls = New System.Windows.Forms.TableLayoutPanel()
        Me.btnItemUp = New System.Windows.Forms.Button()
        Me.btnItemDown = New System.Windows.Forms.Button()
        Me.btnItemPlus = New System.Windows.Forms.Button()
        Me.btnItemMinus = New System.Windows.Forms.Button()
        Me.btnItemRemove = New System.Windows.Forms.Button()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFive = New System.Windows.Forms.Timer(Me.components)
        Me.tplForm.SuspendLayout()
        Me.tplContents.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.tplPointOfSale.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplRight.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplControls.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tplItemControls.SuspendLayout()
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
        Me.tplForm.Size = New System.Drawing.Size(1014, 715)
        Me.tplForm.TabIndex = 0
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 2
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tplContents.Controls.Add(Me.pnlLeft, 0, 0)
        Me.tplContents.Controls.Add(Me.tplRight, 1, 0)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 1
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 685.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 685.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 685.0!))
        Me.tplContents.Size = New System.Drawing.Size(984, 685)
        Me.tplContents.TabIndex = 0
        '
        'pnlLeft
        '
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.tplPointOfSale)
        Me.pnlLeft.Controls.Add(Me.pnlBorderRight)
        Me.pnlLeft.Controls.Add(Me.pnlBorderLeft)
        Me.pnlLeft.Controls.Add(Me.pnlBorderBottom)
        Me.pnlLeft.Controls.Add(Me.pnlBorderTop)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(590, 685)
        Me.pnlLeft.TabIndex = 45
        '
        'tplPointOfSale
        '
        Me.tplPointOfSale.BackColor = System.Drawing.Color.Aqua
        Me.tplPointOfSale.ColumnCount = 4
        Me.tplPointOfSale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplPointOfSale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplPointOfSale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplPointOfSale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplPointOfSale.Controls.Add(Me.txtChange, 2, 5)
        Me.tplPointOfSale.Controls.Add(Me.txtCash, 0, 5)
        Me.tplPointOfSale.Controls.Add(Me.lblChange, 2, 4)
        Me.tplPointOfSale.Controls.Add(Me.lblCash, 0, 4)
        Me.tplPointOfSale.Controls.Add(Me.txtDueTotal, 2, 3)
        Me.tplPointOfSale.Controls.Add(Me.lblDueTotal, 0, 3)
        Me.tplPointOfSale.Controls.Add(Me.txtTotalItems, 0, 10)
        Me.tplPointOfSale.Controls.Add(Me.txtSubTotal, 2, 10)
        Me.tplPointOfSale.Controls.Add(Me.lblVAT, 3, 9)
        Me.tplPointOfSale.Controls.Add(Me.lblSubTotal, 2, 9)
        Me.tplPointOfSale.Controls.Add(Me.txtDiscountValue, 2, 8)
        Me.tplPointOfSale.Controls.Add(Me.txtDiscountPercent, 1, 8)
        Me.tplPointOfSale.Controls.Add(Me.txtDiscount, 0, 8)
        Me.tplPointOfSale.Controls.Add(Me.lblDiscountValue, 2, 7)
        Me.tplPointOfSale.Controls.Add(Me.lblDiscountPercent, 1, 7)
        Me.tplPointOfSale.Controls.Add(Me.lblDiscount, 0, 7)
        Me.tplPointOfSale.Controls.Add(Me.txtVAT, 3, 10)
        Me.tplPointOfSale.Controls.Add(Me.lblTotalItems, 0, 9)
        Me.tplPointOfSale.Controls.Add(Me.txtReceiptNumber, 3, 2)
        Me.tplPointOfSale.Controls.Add(Me.lblReceiptNumber, 3, 1)
        Me.tplPointOfSale.Controls.Add(Me.txtCashier, 0, 2)
        Me.tplPointOfSale.Controls.Add(Me.lblCashier, 0, 1)
        Me.tplPointOfSale.Controls.Add(Me.lblDateTime, 0, 0)
        Me.tplPointOfSale.Controls.Add(Me.txtDateTime, 2, 0)
        Me.tplPointOfSale.Controls.Add(Me.dgvItems, 0, 6)
        Me.tplPointOfSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplPointOfSale.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplPointOfSale.Location = New System.Drawing.Point(5, 5)
        Me.tplPointOfSale.Margin = New System.Windows.Forms.Padding(0)
        Me.tplPointOfSale.Name = "tplPointOfSale"
        Me.tplPointOfSale.RowCount = 11
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tplPointOfSale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tplPointOfSale.Size = New System.Drawing.Size(578, 673)
        Me.tplPointOfSale.TabIndex = 2
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.LightGreen
        Me.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.txtChange, 2)
        Me.txtChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChange.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.Location = New System.Drawing.Point(240, 230)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(328, 64)
        Me.txtChange.TabIndex = 38
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.LightGreen
        Me.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.txtCash, 2)
        Me.txtCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCash.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.Black
        Me.txtCash.Location = New System.Drawing.Point(10, 230)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.ReadOnly = True
        Me.txtCash.Size = New System.Drawing.Size(220, 64)
        Me.txtCash.TabIndex = 37
        Me.txtCash.Text = "0.00"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.Lime
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.lblChange, 2)
        Me.lblChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblChange.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(240, 203)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(328, 27)
        Me.lblChange.TabIndex = 36
        Me.lblChange.Text = "Change"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCash
        '
        Me.lblCash.BackColor = System.Drawing.Color.Lime
        Me.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.lblCash, 2)
        Me.lblCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCash.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(10, 203)
        Me.lblCash.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(220, 27)
        Me.lblCash.TabIndex = 35
        Me.lblCash.Text = "Cash"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDueTotal
        '
        Me.txtDueTotal.BackColor = System.Drawing.Color.LightGreen
        Me.txtDueTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.txtDueTotal, 2)
        Me.txtDueTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDueTotal.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueTotal.ForeColor = System.Drawing.Color.Black
        Me.txtDueTotal.Location = New System.Drawing.Point(230, 111)
        Me.txtDueTotal.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.txtDueTotal.Name = "txtDueTotal"
        Me.txtDueTotal.ReadOnly = True
        Me.txtDueTotal.Size = New System.Drawing.Size(338, 82)
        Me.txtDueTotal.TabIndex = 0
        Me.txtDueTotal.Text = "0.00"
        Me.txtDueTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDueTotal
        '
        Me.lblDueTotal.BackColor = System.Drawing.Color.Lime
        Me.lblDueTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.lblDueTotal, 2)
        Me.lblDueTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDueTotal.Font = New System.Drawing.Font("Corbel", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueTotal.Location = New System.Drawing.Point(10, 111)
        Me.lblDueTotal.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblDueTotal.Name = "lblDueTotal"
        Me.lblDueTotal.Size = New System.Drawing.Size(220, 82)
        Me.lblDueTotal.TabIndex = 33
        Me.lblDueTotal.Text = "Total Due"
        Me.lblDueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalItems
        '
        Me.txtTotalItems.BackColor = System.Drawing.Color.LightGreen
        Me.txtTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalItems.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItems.ForeColor = System.Drawing.Color.Black
        Me.txtTotalItems.Location = New System.Drawing.Point(10, 636)
        Me.txtTotalItems.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.ReadOnly = True
        Me.txtTotalItems.Size = New System.Drawing.Size(105, 27)
        Me.txtTotalItems.TabIndex = 25
        Me.txtTotalItems.Text = "0"
        Me.txtTotalItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.LightGreen
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSubTotal.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.Black
        Me.txtSubTotal.Location = New System.Drawing.Point(230, 636)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(173, 27)
        Me.txtSubTotal.TabIndex = 24
        Me.txtSubTotal.Text = "0.00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVAT
        '
        Me.lblVAT.BackColor = System.Drawing.Color.Lime
        Me.lblVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVAT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVAT.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(413, 609)
        Me.lblVAT.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(155, 27)
        Me.lblVAT.TabIndex = 23
        Me.lblVAT.Text = "VAT"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Lime
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubTotal.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(230, 609)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(173, 27)
        Me.lblSubTotal.TabIndex = 22
        Me.lblSubTotal.Text = "Sub Total"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDiscountValue
        '
        Me.txtDiscountValue.BackColor = System.Drawing.Color.LightGreen
        Me.txtDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscountValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDiscountValue.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountValue.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountValue.Location = New System.Drawing.Point(230, 572)
        Me.txtDiscountValue.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtDiscountValue.Name = "txtDiscountValue"
        Me.txtDiscountValue.ReadOnly = True
        Me.txtDiscountValue.Size = New System.Drawing.Size(173, 27)
        Me.txtDiscountValue.TabIndex = 21
        Me.txtDiscountValue.Text = "0.00"
        Me.txtDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.BackColor = System.Drawing.Color.LightGreen
        Me.txtDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscountPercent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDiscountPercent.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountPercent.ForeColor = System.Drawing.Color.Black
        Me.txtDiscountPercent.Location = New System.Drawing.Point(115, 572)
        Me.txtDiscountPercent.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.ReadOnly = True
        Me.txtDiscountPercent.Size = New System.Drawing.Size(115, 27)
        Me.txtDiscountPercent.TabIndex = 20
        Me.txtDiscountPercent.Text = "0"
        Me.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.LightGreen
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDiscount.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(10, 572)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(105, 27)
        Me.txtDiscount.TabIndex = 19
        Me.txtDiscount.Text = "None"
        '
        'lblDiscountValue
        '
        Me.lblDiscountValue.BackColor = System.Drawing.Color.Lime
        Me.lblDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiscountValue.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountValue.Location = New System.Drawing.Point(230, 545)
        Me.lblDiscountValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDiscountValue.Name = "lblDiscountValue"
        Me.lblDiscountValue.Size = New System.Drawing.Size(173, 27)
        Me.lblDiscountValue.TabIndex = 18
        Me.lblDiscountValue.Text = "Value"
        Me.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiscountPercent
        '
        Me.lblDiscountPercent.BackColor = System.Drawing.Color.Lime
        Me.lblDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountPercent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiscountPercent.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountPercent.Location = New System.Drawing.Point(115, 545)
        Me.lblDiscountPercent.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDiscountPercent.Name = "lblDiscountPercent"
        Me.lblDiscountPercent.Size = New System.Drawing.Size(115, 27)
        Me.lblDiscountPercent.TabIndex = 17
        Me.lblDiscountPercent.Text = "Percentage"
        Me.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.Lime
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiscount.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(10, 545)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(105, 27)
        Me.lblDiscount.TabIndex = 16
        Me.lblDiscount.Text = "Discount"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVAT
        '
        Me.txtVAT.BackColor = System.Drawing.Color.LightGreen
        Me.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVAT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtVAT.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.ForeColor = System.Drawing.Color.Black
        Me.txtVAT.Location = New System.Drawing.Point(413, 636)
        Me.txtVAT.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.ReadOnly = True
        Me.txtVAT.Size = New System.Drawing.Size(155, 27)
        Me.txtVAT.TabIndex = 14
        Me.txtVAT.Text = "0.00"
        Me.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalItems
        '
        Me.lblTotalItems.BackColor = System.Drawing.Color.Lime
        Me.lblTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalItems.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.Location = New System.Drawing.Point(10, 609)
        Me.lblTotalItems.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(105, 27)
        Me.lblTotalItems.TabIndex = 13
        Me.lblTotalItems.Text = "Total Items"
        Me.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReceiptNumber
        '
        Me.txtReceiptNumber.BackColor = System.Drawing.Color.LightGreen
        Me.txtReceiptNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceiptNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReceiptNumber.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNumber.ForeColor = System.Drawing.Color.Black
        Me.txtReceiptNumber.Location = New System.Drawing.Point(403, 74)
        Me.txtReceiptNumber.Margin = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtReceiptNumber.MaxLength = 255
        Me.txtReceiptNumber.Name = "txtReceiptNumber"
        Me.txtReceiptNumber.Size = New System.Drawing.Size(165, 27)
        Me.txtReceiptNumber.TabIndex = 12
        Me.txtReceiptNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblReceiptNumber
        '
        Me.lblReceiptNumber.BackColor = System.Drawing.Color.Lime
        Me.lblReceiptNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceiptNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReceiptNumber.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptNumber.Location = New System.Drawing.Point(403, 47)
        Me.lblReceiptNumber.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.lblReceiptNumber.Name = "lblReceiptNumber"
        Me.lblReceiptNumber.Size = New System.Drawing.Size(165, 27)
        Me.lblReceiptNumber.TabIndex = 11
        Me.lblReceiptNumber.Text = "Official Receipt #"
        Me.lblReceiptNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCashier
        '
        Me.txtCashier.BackColor = System.Drawing.Color.LightGreen
        Me.txtCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.txtCashier, 2)
        Me.txtCashier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCashier.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashier.ForeColor = System.Drawing.Color.Black
        Me.txtCashier.Location = New System.Drawing.Point(10, 74)
        Me.txtCashier.Margin = New System.Windows.Forms.Padding(10, 0, 0, 10)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.ReadOnly = True
        Me.txtCashier.Size = New System.Drawing.Size(220, 27)
        Me.txtCashier.TabIndex = 5
        '
        'lblCashier
        '
        Me.lblCashier.BackColor = System.Drawing.Color.Lime
        Me.lblCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.lblCashier, 2)
        Me.lblCashier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCashier.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(10, 47)
        Me.lblCashier.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(220, 27)
        Me.lblCashier.TabIndex = 3
        Me.lblCashier.Text = "Cashier"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Lime
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.lblDateTime, 2)
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateTime.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(10, 10)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(220, 27)
        Me.lblDateTime.TabIndex = 2
        Me.lblDateTime.Text = "DateTime"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDateTime
        '
        Me.txtDateTime.BackColor = System.Drawing.Color.LightGreen
        Me.txtDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tplPointOfSale.SetColumnSpan(Me.txtDateTime, 2)
        Me.txtDateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDateTime.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTime.ForeColor = System.Drawing.Color.Black
        Me.txtDateTime.Location = New System.Drawing.Point(230, 10)
        Me.txtDateTime.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.ReadOnly = True
        Me.txtDateTime.Size = New System.Drawing.Size(338, 27)
        Me.txtDateTime.TabIndex = 2
        Me.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AllowUserToResizeColumns = False
        Me.dgvItems.AllowUserToResizeRows = False
        Me.dgvItems.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvItems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemCode, Me.itemDescription, Me.itemUnitPrice, Me.itemQuantity, Me.itemTotal})
        Me.tplPointOfSale.SetColumnSpan(Me.dgvItems, 4)
        Me.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvItems.GridColor = System.Drawing.Color.Indigo
        Me.dgvItems.Location = New System.Drawing.Point(10, 304)
        Me.dgvItems.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
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
        Me.dgvItems.Size = New System.Drawing.Size(558, 231)
        Me.dgvItems.TabIndex = 8
        '
        'itemCode
        '
        Me.itemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemCode.FillWeight = 15.0!
        Me.itemCode.HeaderText = "Code"
        Me.itemCode.MinimumWidth = 15
        Me.itemCode.Name = "itemCode"
        Me.itemCode.ReadOnly = True
        '
        'itemDescription
        '
        Me.itemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemDescription.FillWeight = 40.0!
        Me.itemDescription.HeaderText = "Description"
        Me.itemDescription.MinimumWidth = 40
        Me.itemDescription.Name = "itemDescription"
        Me.itemDescription.ReadOnly = True
        '
        'itemUnitPrice
        '
        Me.itemUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemUnitPrice.FillWeight = 10.0!
        Me.itemUnitPrice.HeaderText = "UnitPrice"
        Me.itemUnitPrice.MinimumWidth = 10
        Me.itemUnitPrice.Name = "itemUnitPrice"
        Me.itemUnitPrice.ReadOnly = True
        '
        'itemQuantity
        '
        Me.itemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemQuantity.FillWeight = 10.0!
        Me.itemQuantity.HeaderText = "Quantity"
        Me.itemQuantity.MinimumWidth = 10
        Me.itemQuantity.Name = "itemQuantity"
        Me.itemQuantity.ReadOnly = True
        '
        'itemTotal
        '
        Me.itemTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemTotal.FillWeight = 20.0!
        Me.itemTotal.HeaderText = "Total"
        Me.itemTotal.MinimumWidth = 20
        Me.itemTotal.Name = "itemTotal"
        Me.itemTotal.ReadOnly = True
        '
        'pnlBorderRight
        '
        Me.pnlBorderRight.BackColor = System.Drawing.Color.Indigo
        Me.pnlBorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBorderRight.Location = New System.Drawing.Point(583, 5)
        Me.pnlBorderRight.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBorderRight.Name = "pnlBorderRight"
        Me.pnlBorderRight.Size = New System.Drawing.Size(5, 673)
        Me.pnlBorderRight.TabIndex = 45
        '
        'pnlBorderLeft
        '
        Me.pnlBorderLeft.BackColor = System.Drawing.Color.Indigo
        Me.pnlBorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBorderLeft.Location = New System.Drawing.Point(0, 5)
        Me.pnlBorderLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBorderLeft.Name = "pnlBorderLeft"
        Me.pnlBorderLeft.Size = New System.Drawing.Size(5, 673)
        Me.pnlBorderLeft.TabIndex = 44
        '
        'pnlBorderBottom
        '
        Me.pnlBorderBottom.BackColor = System.Drawing.Color.Indigo
        Me.pnlBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBorderBottom.Location = New System.Drawing.Point(0, 678)
        Me.pnlBorderBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBorderBottom.Name = "pnlBorderBottom"
        Me.pnlBorderBottom.Size = New System.Drawing.Size(588, 5)
        Me.pnlBorderBottom.TabIndex = 43
        '
        'pnlBorderTop
        '
        Me.pnlBorderTop.BackColor = System.Drawing.Color.Indigo
        Me.pnlBorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBorderTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlBorderTop.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBorderTop.Name = "pnlBorderTop"
        Me.pnlBorderTop.Size = New System.Drawing.Size(588, 5)
        Me.pnlBorderTop.TabIndex = 1
        '
        'tplRight
        '
        Me.tplRight.ColumnCount = 3
        Me.tplRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tplRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplRight.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.tplRight.Controls.Add(Me.txtCashR, 1, 9)
        Me.tplRight.Controls.Add(Me.txtQuantity, 1, 7)
        Me.tplRight.Controls.Add(Me.btnProductDown, 2, 6)
        Me.tplRight.Controls.Add(Me.btnProductUp, 2, 5)
        Me.tplRight.Controls.Add(Me.btnCash, 2, 9)
        Me.tplRight.Controls.Add(Me.lblCashR, 0, 9)
        Me.tplRight.Controls.Add(Me.btnDiscount, 2, 8)
        Me.tplRight.Controls.Add(Me.cbxDiscounts, 1, 8)
        Me.tplRight.Controls.Add(Me.lblDiscountR, 0, 8)
        Me.tplRight.Controls.Add(Me.dgvProducts, 0, 5)
        Me.tplRight.Controls.Add(Me.lblQuantity, 0, 7)
        Me.tplRight.Controls.Add(Me.btnQuantity, 2, 7)
        Me.tplRight.Controls.Add(Me.txtProductInput, 1, 4)
        Me.tplRight.Controls.Add(Me.lblProductInput, 0, 4)
        Me.tplRight.Controls.Add(Me.lblVersion, 0, 3)
        Me.tplRight.Controls.Add(Me.tplControls, 0, 11)
        Me.tplRight.Controls.Add(Me.lblNumbers, 1, 2)
        Me.tplRight.Controls.Add(Me.lblTitle, 1, 0)
        Me.tplRight.Controls.Add(Me.pbxLogo, 0, 0)
        Me.tplRight.Controls.Add(Me.lblAddress, 1, 1)
        Me.tplRight.Controls.Add(Me.btnProductInput, 2, 4)
        Me.tplRight.Controls.Add(Me.tplItemControls, 0, 10)
        Me.tplRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplRight.Location = New System.Drawing.Point(605, 0)
        Me.tplRight.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.tplRight.Name = "tplRight"
        Me.tplRight.RowCount = 12
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplRight.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplRight.Size = New System.Drawing.Size(379, 685)
        Me.tplRight.TabIndex = 0
        '
        'txtCashR
        '
        Me.txtCashR.BackColor = System.Drawing.Color.LightGreen
        Me.txtCashR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCashR.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashR.ForeColor = System.Drawing.Color.Black
        Me.txtCashR.Location = New System.Drawing.Point(120, 444)
        Me.txtCashR.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.txtCashR.MaxLength = 10
        Me.txtCashR.Name = "txtCashR"
        Me.txtCashR.Size = New System.Drawing.Size(184, 31)
        Me.txtCashR.TabIndex = 72
        Me.txtCashR.Text = "0.00"
        Me.txtCashR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.LightGreen
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.HidePromptOnLeave = True
        Me.txtQuantity.Location = New System.Drawing.Point(120, 362)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.txtQuantity.Mask = "000"
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ResetOnSpace = False
        Me.txtQuantity.Size = New System.Drawing.Size(184, 31)
        Me.txtQuantity.TabIndex = 71
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQuantity.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnProductDown
        '
        Me.btnProductDown.BackColor = System.Drawing.Color.Khaki
        Me.btnProductDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProductDown.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnProductDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnProductDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnProductDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductDown.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductDown.Image = CType(resources.GetObject("btnProductDown.Image"), System.Drawing.Image)
        Me.btnProductDown.Location = New System.Drawing.Point(314, 300)
        Me.btnProductDown.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnProductDown.Name = "btnProductDown"
        Me.btnProductDown.Size = New System.Drawing.Size(55, 52)
        Me.btnProductDown.TabIndex = 69
        Me.btnProductDown.Text = "(PgDn)"
        Me.btnProductDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProductDown.UseVisualStyleBackColor = False
        '
        'btnProductUp
        '
        Me.btnProductUp.BackColor = System.Drawing.Color.Khaki
        Me.btnProductUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProductUp.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnProductUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnProductUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnProductUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductUp.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductUp.Image = CType(resources.GetObject("btnProductUp.Image"), System.Drawing.Image)
        Me.btnProductUp.Location = New System.Drawing.Point(314, 238)
        Me.btnProductUp.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.btnProductUp.Name = "btnProductUp"
        Me.btnProductUp.Size = New System.Drawing.Size(55, 52)
        Me.btnProductUp.TabIndex = 68
        Me.btnProductUp.Text = "(PgUp)"
        Me.btnProductUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProductUp.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.Khaki
        Me.btnCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCash.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnCash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(304, 444)
        Me.btnCash.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(65, 31)
        Me.btnCash.TabIndex = 67
        Me.btnCash.Text = "(F12)"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'lblCashR
        '
        Me.lblCashR.BackColor = System.Drawing.Color.Lime
        Me.lblCashR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCashR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCashR.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashR.Location = New System.Drawing.Point(10, 444)
        Me.lblCashR.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblCashR.Name = "lblCashR"
        Me.lblCashR.Size = New System.Drawing.Size(110, 31)
        Me.lblCashR.TabIndex = 65
        Me.lblCashR.Text = "Cash"
        Me.lblCashR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDiscount
        '
        Me.btnDiscount.BackColor = System.Drawing.Color.Khaki
        Me.btnDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDiscount.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscount.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.Location = New System.Drawing.Point(304, 403)
        Me.btnDiscount.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(65, 31)
        Me.btnDiscount.TabIndex = 64
        Me.btnDiscount.Text = "(F11)"
        Me.btnDiscount.UseVisualStyleBackColor = False
        '
        'cbxDiscounts
        '
        Me.cbxDiscounts.BackColor = System.Drawing.Color.LightGreen
        Me.cbxDiscounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxDiscounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDiscounts.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDiscounts.ForeColor = System.Drawing.Color.Black
        Me.cbxDiscounts.FormattingEnabled = True
        Me.cbxDiscounts.Location = New System.Drawing.Point(120, 403)
        Me.cbxDiscounts.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.cbxDiscounts.MaxDropDownItems = 5
        Me.cbxDiscounts.Name = "cbxDiscounts"
        Me.cbxDiscounts.Size = New System.Drawing.Size(184, 31)
        Me.cbxDiscounts.TabIndex = 63
        '
        'lblDiscountR
        '
        Me.lblDiscountR.BackColor = System.Drawing.Color.Lime
        Me.lblDiscountR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiscountR.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountR.Location = New System.Drawing.Point(10, 403)
        Me.lblDiscountR.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblDiscountR.Name = "lblDiscountR"
        Me.lblDiscountR.Size = New System.Drawing.Size(110, 31)
        Me.lblDiscountR.TabIndex = 62
        Me.lblDiscountR.Text = "Discount"
        Me.lblDiscountR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productCode, Me.productDescription, Me.productUnitPrice, Me.productStock})
        Me.tplRight.SetColumnSpan(Me.dgvProducts, 2)
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProducts.GridColor = System.Drawing.Color.Indigo
        Me.dgvProducts.Location = New System.Drawing.Point(10, 238)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tplRight.SetRowSpan(Me.dgvProducts, 2)
        Me.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.ShowCellErrors = False
        Me.dgvProducts.ShowCellToolTips = False
        Me.dgvProducts.ShowEditingIcon = False
        Me.dgvProducts.ShowRowErrors = False
        Me.dgvProducts.Size = New System.Drawing.Size(294, 114)
        Me.dgvProducts.TabIndex = 10
        '
        'productCode
        '
        Me.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productCode.FillWeight = 20.0!
        Me.productCode.HeaderText = "Code"
        Me.productCode.MinimumWidth = 20
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
        'productUnitPrice
        '
        Me.productUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productUnitPrice.FillWeight = 20.0!
        Me.productUnitPrice.HeaderText = "UnitPrice"
        Me.productUnitPrice.MinimumWidth = 20
        Me.productUnitPrice.Name = "productUnitPrice"
        Me.productUnitPrice.ReadOnly = True
        '
        'productStock
        '
        Me.productStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productStock.FillWeight = 20.0!
        Me.productStock.HeaderText = "Stock"
        Me.productStock.MinimumWidth = 20
        Me.productStock.Name = "productStock"
        Me.productStock.ReadOnly = True
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Lime
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuantity.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(10, 362)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(110, 31)
        Me.lblQuantity.TabIndex = 58
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuantity
        '
        Me.btnQuantity.BackColor = System.Drawing.Color.Khaki
        Me.btnQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuantity.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuantity.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuantity.Location = New System.Drawing.Point(304, 362)
        Me.btnQuantity.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.btnQuantity.Name = "btnQuantity"
        Me.btnQuantity.Size = New System.Drawing.Size(65, 31)
        Me.btnQuantity.TabIndex = 60
        Me.btnQuantity.Text = "(F10)"
        Me.btnQuantity.UseVisualStyleBackColor = False
        '
        'txtProductInput
        '
        Me.txtProductInput.BackColor = System.Drawing.Color.LightGreen
        Me.txtProductInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProductInput.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductInput.ForeColor = System.Drawing.Color.Black
        Me.txtProductInput.Location = New System.Drawing.Point(120, 197)
        Me.txtProductInput.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.txtProductInput.MaxLength = 255
        Me.txtProductInput.Name = "txtProductInput"
        Me.txtProductInput.Size = New System.Drawing.Size(184, 31)
        Me.txtProductInput.TabIndex = 9
        '
        'lblProductInput
        '
        Me.lblProductInput.BackColor = System.Drawing.Color.Lime
        Me.lblProductInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProductInput.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductInput.Location = New System.Drawing.Point(10, 197)
        Me.lblProductInput.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.lblProductInput.Name = "lblProductInput"
        Me.lblProductInput.Size = New System.Drawing.Size(110, 31)
        Me.lblProductInput.TabIndex = 55
        Me.lblProductInput.Text = "Product Input"
        Me.lblProductInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.tplRight.SetColumnSpan(Me.lblVersion, 3)
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(10, 130)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(10)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(359, 47)
        Me.lblVersion.TabIndex = 16
        Me.lblVersion.Text = "POS Version "
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tplControls
        '
        Me.tplControls.BackColor = System.Drawing.Color.Transparent
        Me.tplControls.ColumnCount = 3
        Me.tplRight.SetColumnSpan(Me.tplControls, 3)
        Me.tplControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tplControls.Controls.Add(Me.btnLogOut, 2, 0)
        Me.tplControls.Controls.Add(Me.btnGenerate, 0, 0)
        Me.tplControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplControls.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplControls.ForeColor = System.Drawing.Color.Black
        Me.tplControls.Location = New System.Drawing.Point(0, 635)
        Me.tplControls.Margin = New System.Windows.Forms.Padding(0)
        Me.tplControls.Name = "tplControls"
        Me.tplControls.RowCount = 1
        Me.tplControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tplControls.Size = New System.Drawing.Size(379, 50)
        Me.tplControls.TabIndex = 52
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
        Me.btnLogOut.Size = New System.Drawing.Size(127, 50)
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
        Me.btnGenerate.Size = New System.Drawing.Size(126, 50)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'lblNumbers
        '
        Me.lblNumbers.BackColor = System.Drawing.Color.Aqua
        Me.tplRight.SetColumnSpan(Me.lblNumbers, 2)
        Me.lblNumbers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumbers.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumbers.Location = New System.Drawing.Point(120, 80)
        Me.lblNumbers.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(259, 40)
        Me.lblNumbers.TabIndex = 15
        Me.lblNumbers.Text = "Numbers"
        Me.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Aqua
        Me.tplRight.SetColumnSpan(Me.lblTitle, 2)
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Maiandra GD", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(120, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(259, 40)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "V-PHARMA"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Aqua
        Me.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(10, 10)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(10)
        Me.pbxLogo.Name = "pbxLogo"
        Me.tplRight.SetRowSpan(Me.pbxLogo, 3)
        Me.pbxLogo.Size = New System.Drawing.Size(100, 100)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 48
        Me.pbxLogo.TabStop = False
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Aqua
        Me.tplRight.SetColumnSpan(Me.lblAddress, 2)
        Me.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(120, 40)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(259, 40)
        Me.lblAddress.TabIndex = 17
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnProductInput
        '
        Me.btnProductInput.BackColor = System.Drawing.Color.Khaki
        Me.btnProductInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProductInput.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnProductInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnProductInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnProductInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductInput.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductInput.Location = New System.Drawing.Point(304, 197)
        Me.btnProductInput.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.btnProductInput.Name = "btnProductInput"
        Me.btnProductInput.Size = New System.Drawing.Size(65, 31)
        Me.btnProductInput.TabIndex = 7
        Me.btnProductInput.Text = "(F9)"
        Me.btnProductInput.UseVisualStyleBackColor = False
        '
        'tplItemControls
        '
        Me.tplItemControls.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tplItemControls.ColumnCount = 3
        Me.tplRight.SetColumnSpan(Me.tplItemControls, 3)
        Me.tplItemControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tplItemControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tplItemControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tplItemControls.Controls.Add(Me.btnItemUp, 0, 0)
        Me.tplItemControls.Controls.Add(Me.btnItemDown, 0, 1)
        Me.tplItemControls.Controls.Add(Me.btnItemPlus, 1, 0)
        Me.tplItemControls.Controls.Add(Me.btnItemMinus, 1, 1)
        Me.tplItemControls.Controls.Add(Me.btnItemRemove, 2, 0)
        Me.tplItemControls.Location = New System.Drawing.Point(10, 485)
        Me.tplItemControls.Margin = New System.Windows.Forms.Padding(10)
        Me.tplItemControls.Name = "tplItemControls"
        Me.tplItemControls.RowCount = 2
        Me.tplItemControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplItemControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplItemControls.Size = New System.Drawing.Size(359, 140)
        Me.tplItemControls.TabIndex = 70
        '
        'btnItemUp
        '
        Me.btnItemUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemUp.AutoSize = True
        Me.btnItemUp.BackColor = System.Drawing.Color.Khaki
        Me.btnItemUp.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnItemUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnItemUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnItemUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemUp.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemUp.Image = Global.pharmacy.My.Resources.Resources.up32
        Me.btnItemUp.Location = New System.Drawing.Point(10, 10)
        Me.btnItemUp.Margin = New System.Windows.Forms.Padding(10)
        Me.btnItemUp.Name = "btnItemUp"
        Me.btnItemUp.Size = New System.Drawing.Size(100, 50)
        Me.btnItemUp.TabIndex = 71
        Me.btnItemUp.Text = "(Up)"
        Me.btnItemUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemUp.UseVisualStyleBackColor = False
        '
        'btnItemDown
        '
        Me.btnItemDown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemDown.AutoSize = True
        Me.btnItemDown.BackColor = System.Drawing.Color.Khaki
        Me.btnItemDown.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnItemDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnItemDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnItemDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemDown.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemDown.Image = Global.pharmacy.My.Resources.Resources.down32
        Me.btnItemDown.Location = New System.Drawing.Point(10, 80)
        Me.btnItemDown.Margin = New System.Windows.Forms.Padding(10)
        Me.btnItemDown.Name = "btnItemDown"
        Me.btnItemDown.Size = New System.Drawing.Size(100, 50)
        Me.btnItemDown.TabIndex = 70
        Me.btnItemDown.Text = "(Down)"
        Me.btnItemDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemDown.UseVisualStyleBackColor = False
        '
        'btnItemPlus
        '
        Me.btnItemPlus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemPlus.AutoSize = True
        Me.btnItemPlus.BackColor = System.Drawing.Color.Khaki
        Me.btnItemPlus.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnItemPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnItemPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnItemPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemPlus.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemPlus.Image = Global.pharmacy.My.Resources.Resources.plus232
        Me.btnItemPlus.Location = New System.Drawing.Point(130, 10)
        Me.btnItemPlus.Margin = New System.Windows.Forms.Padding(10)
        Me.btnItemPlus.Name = "btnItemPlus"
        Me.btnItemPlus.Size = New System.Drawing.Size(100, 50)
        Me.btnItemPlus.TabIndex = 73
        Me.btnItemPlus.Text = "Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Right)"
        Me.btnItemPlus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemPlus.UseVisualStyleBackColor = False
        '
        'btnItemMinus
        '
        Me.btnItemMinus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnItemMinus.AutoSize = True
        Me.btnItemMinus.BackColor = System.Drawing.Color.Khaki
        Me.btnItemMinus.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnItemMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnItemMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnItemMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemMinus.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemMinus.Image = Global.pharmacy.My.Resources.Resources.minus232
        Me.btnItemMinus.Location = New System.Drawing.Point(130, 80)
        Me.btnItemMinus.Margin = New System.Windows.Forms.Padding(10)
        Me.btnItemMinus.Name = "btnItemMinus"
        Me.btnItemMinus.Size = New System.Drawing.Size(100, 50)
        Me.btnItemMinus.TabIndex = 72
        Me.btnItemMinus.Text = "Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Left)"
        Me.btnItemMinus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItemMinus.UseVisualStyleBackColor = False
        '
        'btnItemRemove
        '
        Me.btnItemRemove.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnItemRemove.AutoSize = True
        Me.btnItemRemove.BackColor = System.Drawing.Color.Khaki
        Me.btnItemRemove.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnItemRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnItemRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnItemRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemRemove.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemRemove.Image = CType(resources.GetObject("btnItemRemove.Image"), System.Drawing.Image)
        Me.btnItemRemove.Location = New System.Drawing.Point(250, 20)
        Me.btnItemRemove.Margin = New System.Windows.Forms.Padding(10)
        Me.btnItemRemove.Name = "btnItemRemove"
        Me.tplItemControls.SetRowSpan(Me.btnItemRemove, 2)
        Me.btnItemRemove.Size = New System.Drawing.Size(100, 100)
        Me.btnItemRemove.TabIndex = 74
        Me.btnItemRemove.Text = "Remove Item" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Del)"
        Me.btnItemRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnItemRemove.UseVisualStyleBackColor = False
        '
        'tmrDateTime
        '
        Me.tmrDateTime.Enabled = True
        Me.tmrDateTime.Interval = 1
        '
        'tmrFive
        '
        Me.tmrFive.Interval = 5000
        '
        'frmPointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPointOfSale"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tplForm.ResumeLayout(False)
        Me.tplContents.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.tplPointOfSale.ResumeLayout(False)
        Me.tplPointOfSale.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplRight.ResumeLayout(False)
        Me.tplRight.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplControls.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tplItemControls.ResumeLayout(False)
        Me.tplItemControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlBorderTop As System.Windows.Forms.Panel
    Friend WithEvents pnlBorderBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlBorderRight As System.Windows.Forms.Panel
    Friend WithEvents pnlBorderLeft As System.Windows.Forms.Panel
    Friend WithEvents tplPointOfSale As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtCashier As System.Windows.Forms.TextBox
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents txtDateTime As System.Windows.Forms.TextBox
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents txtReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblReceiptNumber As System.Windows.Forms.Label
    Friend WithEvents itemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemUnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtVAT As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalItems As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents txtDiscountValue As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountValue As System.Windows.Forms.Label
    Friend WithEvents lblDiscountPercent As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents txtTotalItems As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents tplRight As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents tplControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblProductInput As System.Windows.Forms.Label
    Friend WithEvents txtProductInput As System.Windows.Forms.TextBox
    Friend WithEvents btnProductInput As System.Windows.Forms.Button
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents btnQuantity As System.Windows.Forms.Button
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents lblDiscountR As System.Windows.Forms.Label
    Friend WithEvents btnDiscount As System.Windows.Forms.Button
    Friend WithEvents cbxDiscounts As System.Windows.Forms.ComboBox
    Friend WithEvents lblCashR As System.Windows.Forms.Label
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents lblDueTotal As System.Windows.Forms.Label
    Friend WithEvents txtDueTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents btnProductUp As System.Windows.Forms.Button
    Friend WithEvents btnProductDown As System.Windows.Forms.Button
    Friend WithEvents tplItemControls As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnItemDown As System.Windows.Forms.Button
    Friend WithEvents btnItemPlus As System.Windows.Forms.Button
    Friend WithEvents btnItemMinus As System.Windows.Forms.Button
    Friend WithEvents btnItemUp As System.Windows.Forms.Button
    Friend WithEvents btnItemRemove As System.Windows.Forms.Button
    Friend WithEvents productCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productUnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents productStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtQuantity As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tmrFive As System.Windows.Forms.Timer
    Friend WithEvents txtCashR As System.Windows.Forms.TextBox
End Class
