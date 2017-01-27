<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mainFileMaintenance = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.prodDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.prodExpiration = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmSuppliers = New System.Windows.Forms.ToolStripMenuItem()
        Me.suppDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.suppProductSupplied = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.cateMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.cateSub = New System.Windows.Forms.ToolStripMenuItem()
        Me.fmMiscellaneous = New System.Windows.Forms.ToolStripMenuItem()
        Me.miscDiscounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.miscUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.miscReceiptNumber = New System.Windows.Forms.ToolStripMenuItem()
        Me.miscVAT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.tnPointOfSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.tnPurchase = New System.Windows.Forms.ToolStripMenuItem()
        Me.tnReceive = New System.Windows.Forms.ToolStripMenuItem()
        Me.tnReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.tnStockAdjustments = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpStocks = New System.Windows.Forms.ToolStripMenuItem()
        Me.rpExpirations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainSecurity = New System.Windows.Forms.ToolStripMenuItem()
        Me.scUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.scUserTypes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.pnlBottomOuter = New System.Windows.Forms.Panel()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblQueryStatus = New System.Windows.Forms.Label()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.mnuUser = New System.Windows.Forms.MenuStrip()
        Me.userMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.userOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.uoChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.tmrQuery = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMain.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.tplForm.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlUser.SuspendLayout()
        Me.mnuUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateTime
        '
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDateTime.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.Location = New System.Drawing.Point(492, 0)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(394, 75)
        Me.lblDateTime.TabIndex = 7
        Me.lblDateTime.Text = "DateTime"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrDateTime
        '
        Me.tmrDateTime.Enabled = True
        Me.tmrDateTime.Interval = 1
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.Color.Aqua
        Me.mnuMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuMain.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMain.GripMargin = New System.Windows.Forms.Padding(0)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainFileMaintenance, Me.mainTransactions, Me.mainReports, Me.mainSecurity, Me.mainAbout})
        Me.mnuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(0)
        Me.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuMain.Size = New System.Drawing.Size(492, 75)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "Main Menu"
        '
        'mainFileMaintenance
        '
        Me.mainFileMaintenance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mainFileMaintenance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fmProducts, Me.fmSuppliers, Me.fmCategories, Me.fmMiscellaneous})
        Me.mainFileMaintenance.ForeColor = System.Drawing.Color.Black
        Me.mainFileMaintenance.Name = "mainFileMaintenance"
        Me.mainFileMaintenance.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mainFileMaintenance.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mainFileMaintenance.Size = New System.Drawing.Size(146, 75)
        Me.mainFileMaintenance.Text = "File Maintenance"
        '
        'fmProducts
        '
        Me.fmProducts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prodDetails, Me.prodExpiration})
        Me.fmProducts.Name = "fmProducts"
        Me.fmProducts.Padding = New System.Windows.Forms.Padding(0)
        Me.fmProducts.Size = New System.Drawing.Size(185, 24)
        Me.fmProducts.Text = "Products"
        '
        'prodDetails
        '
        Me.prodDetails.Name = "prodDetails"
        Me.prodDetails.Padding = New System.Windows.Forms.Padding(0)
        Me.prodDetails.Size = New System.Drawing.Size(151, 24)
        Me.prodDetails.Text = "Details"
        '
        'prodExpiration
        '
        Me.prodExpiration.Name = "prodExpiration"
        Me.prodExpiration.Padding = New System.Windows.Forms.Padding(0)
        Me.prodExpiration.Size = New System.Drawing.Size(151, 24)
        Me.prodExpiration.Text = "Expiration"
        '
        'fmSuppliers
        '
        Me.fmSuppliers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.suppDetails, Me.suppProductSupplied})
        Me.fmSuppliers.Name = "fmSuppliers"
        Me.fmSuppliers.Padding = New System.Windows.Forms.Padding(0)
        Me.fmSuppliers.Size = New System.Drawing.Size(185, 24)
        Me.fmSuppliers.Text = "Suppliers"
        '
        'suppDetails
        '
        Me.suppDetails.Name = "suppDetails"
        Me.suppDetails.Padding = New System.Windows.Forms.Padding(0)
        Me.suppDetails.Size = New System.Drawing.Size(210, 24)
        Me.suppDetails.Text = "Details"
        '
        'suppProductSupplied
        '
        Me.suppProductSupplied.Name = "suppProductSupplied"
        Me.suppProductSupplied.Padding = New System.Windows.Forms.Padding(0)
        Me.suppProductSupplied.Size = New System.Drawing.Size(210, 24)
        Me.suppProductSupplied.Text = "Products Supplied"
        '
        'fmCategories
        '
        Me.fmCategories.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cateMain, Me.cateSub})
        Me.fmCategories.Name = "fmCategories"
        Me.fmCategories.Padding = New System.Windows.Forms.Padding(0)
        Me.fmCategories.Size = New System.Drawing.Size(185, 24)
        Me.fmCategories.Text = "Categories"
        '
        'cateMain
        '
        Me.cateMain.Name = "cateMain"
        Me.cateMain.Padding = New System.Windows.Forms.Padding(0)
        Me.cateMain.Size = New System.Drawing.Size(196, 24)
        Me.cateMain.Text = "Main Categories"
        '
        'cateSub
        '
        Me.cateSub.Name = "cateSub"
        Me.cateSub.Padding = New System.Windows.Forms.Padding(0)
        Me.cateSub.Size = New System.Drawing.Size(196, 24)
        Me.cateSub.Text = "Sub Categories"
        '
        'fmMiscellaneous
        '
        Me.fmMiscellaneous.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miscDiscounts, Me.miscUnits, Me.miscReceiptNumber, Me.miscVAT})
        Me.fmMiscellaneous.Name = "fmMiscellaneous"
        Me.fmMiscellaneous.Padding = New System.Windows.Forms.Padding(0)
        Me.fmMiscellaneous.Size = New System.Drawing.Size(185, 24)
        Me.fmMiscellaneous.Text = "Miscellaneous"
        '
        'miscDiscounts
        '
        Me.miscDiscounts.Name = "miscDiscounts"
        Me.miscDiscounts.Padding = New System.Windows.Forms.Padding(0)
        Me.miscDiscounts.Size = New System.Drawing.Size(192, 24)
        Me.miscDiscounts.Text = "Discounts"
        '
        'miscUnits
        '
        Me.miscUnits.Name = "miscUnits"
        Me.miscUnits.Padding = New System.Windows.Forms.Padding(0)
        Me.miscUnits.Size = New System.Drawing.Size(192, 24)
        Me.miscUnits.Text = "Units"
        '
        'miscReceiptNumber
        '
        Me.miscReceiptNumber.Name = "miscReceiptNumber"
        Me.miscReceiptNumber.Padding = New System.Windows.Forms.Padding(0)
        Me.miscReceiptNumber.Size = New System.Drawing.Size(192, 24)
        Me.miscReceiptNumber.Text = "Receipt Number"
        '
        'miscVAT
        '
        Me.miscVAT.Name = "miscVAT"
        Me.miscVAT.Padding = New System.Windows.Forms.Padding(0)
        Me.miscVAT.Size = New System.Drawing.Size(192, 24)
        Me.miscVAT.Text = "VAT"
        '
        'mainTransactions
        '
        Me.mainTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tnPointOfSale, Me.tnPurchase, Me.tnReceive, Me.tnReturn, Me.tnStockAdjustments})
        Me.mainTransactions.ForeColor = System.Drawing.Color.Black
        Me.mainTransactions.Name = "mainTransactions"
        Me.mainTransactions.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mainTransactions.Size = New System.Drawing.Size(117, 75)
        Me.mainTransactions.Text = "Transactions"
        '
        'tnPointOfSale
        '
        Me.tnPointOfSale.Name = "tnPointOfSale"
        Me.tnPointOfSale.Padding = New System.Windows.Forms.Padding(0)
        Me.tnPointOfSale.Size = New System.Drawing.Size(211, 24)
        Me.tnPointOfSale.Text = "Point of Sale"
        '
        'tnPurchase
        '
        Me.tnPurchase.BackColor = System.Drawing.Color.Transparent
        Me.tnPurchase.ForeColor = System.Drawing.Color.Black
        Me.tnPurchase.Name = "tnPurchase"
        Me.tnPurchase.Padding = New System.Windows.Forms.Padding(0)
        Me.tnPurchase.Size = New System.Drawing.Size(211, 24)
        Me.tnPurchase.Text = "Purchase Orders"
        '
        'tnReceive
        '
        Me.tnReceive.Name = "tnReceive"
        Me.tnReceive.Padding = New System.Windows.Forms.Padding(0)
        Me.tnReceive.Size = New System.Drawing.Size(211, 24)
        Me.tnReceive.Text = "Receive Orders"
        '
        'tnReturn
        '
        Me.tnReturn.Name = "tnReturn"
        Me.tnReturn.Size = New System.Drawing.Size(211, 26)
        Me.tnReturn.Text = "Return Products"
        '
        'tnStockAdjustments
        '
        Me.tnStockAdjustments.Name = "tnStockAdjustments"
        Me.tnStockAdjustments.Padding = New System.Windows.Forms.Padding(0)
        Me.tnStockAdjustments.Size = New System.Drawing.Size(211, 24)
        Me.tnStockAdjustments.Text = "Stock Adjustments"
        '
        'mainReports
        '
        Me.mainReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rpSales, Me.rpStocks, Me.rpExpirations})
        Me.mainReports.Name = "mainReports"
        Me.mainReports.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mainReports.Size = New System.Drawing.Size(79, 75)
        Me.mainReports.Text = "Reports"
        '
        'rpSales
        '
        Me.rpSales.Name = "rpSales"
        Me.rpSales.Padding = New System.Windows.Forms.Padding(0)
        Me.rpSales.Size = New System.Drawing.Size(159, 24)
        Me.rpSales.Text = "Sales"
        '
        'rpStocks
        '
        Me.rpStocks.Name = "rpStocks"
        Me.rpStocks.Padding = New System.Windows.Forms.Padding(0)
        Me.rpStocks.Size = New System.Drawing.Size(159, 24)
        Me.rpStocks.Text = "Stocks"
        '
        'rpExpirations
        '
        Me.rpExpirations.Name = "rpExpirations"
        Me.rpExpirations.Size = New System.Drawing.Size(159, 26)
        Me.rpExpirations.Text = "Expirations"
        '
        'mainSecurity
        '
        Me.mainSecurity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.scUsers, Me.scUserTypes})
        Me.mainSecurity.Name = "mainSecurity"
        Me.mainSecurity.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mainSecurity.Size = New System.Drawing.Size(83, 75)
        Me.mainSecurity.Text = "Security"
        '
        'scUsers
        '
        Me.scUsers.Name = "scUsers"
        Me.scUsers.Padding = New System.Windows.Forms.Padding(0)
        Me.scUsers.Size = New System.Drawing.Size(157, 24)
        Me.scUsers.Text = "Users"
        '
        'scUserTypes
        '
        Me.scUserTypes.Name = "scUserTypes"
        Me.scUserTypes.Padding = New System.Windows.Forms.Padding(0)
        Me.scUserTypes.Size = New System.Drawing.Size(157, 24)
        Me.scUserTypes.Text = "User Types"
        '
        'mainAbout
        '
        Me.mainAbout.Name = "mainAbout"
        Me.mainAbout.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.mainAbout.Size = New System.Drawing.Size(65, 75)
        Me.mainAbout.Text = "About"
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoSize = True
        Me.pnlMenu.BackColor = System.Drawing.Color.Aqua
        Me.pnlMenu.Controls.Add(Me.lblDateTime)
        Me.pnlMenu.Controls.Add(Me.mnuMain)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(886, 75)
        Me.pnlMenu.TabIndex = 11
        '
        'pnlLeft
        '
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(5, 574)
        Me.pnlLeft.TabIndex = 13
        '
        'pnlRight
        '
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(891, 0)
        Me.pnlRight.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(5, 574)
        Me.pnlRight.TabIndex = 14
        '
        'pnlBottomOuter
        '
        Me.pnlBottomOuter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomOuter.Location = New System.Drawing.Point(5, 569)
        Me.pnlBottomOuter.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBottomOuter.Name = "pnlBottomOuter"
        Me.pnlBottomOuter.Size = New System.Drawing.Size(886, 5)
        Me.pnlBottomOuter.TabIndex = 15
        '
        'tplForm
        '
        Me.tplForm.BackColor = System.Drawing.Color.Aqua
        Me.tplForm.ColumnCount = 1
        Me.tplForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Controls.Add(Me.pnlMenu, 0, 1)
        Me.tplForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.tplForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplForm.Location = New System.Drawing.Point(5, 0)
        Me.tplForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.Size = New System.Drawing.Size(886, 75)
        Me.tplForm.TabIndex = 36
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.Aqua
        Me.pnlStatus.Controls.Add(Me.lblQueryStatus)
        Me.pnlStatus.Controls.Add(Me.pnlUser)
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(5, 534)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(886, 35)
        Me.pnlStatus.TabIndex = 38
        '
        'lblQueryStatus
        '
        Me.lblQueryStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQueryStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQueryStatus.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueryStatus.Location = New System.Drawing.Point(150, 0)
        Me.lblQueryStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.lblQueryStatus.Name = "lblQueryStatus"
        Me.lblQueryStatus.Size = New System.Drawing.Size(407, 35)
        Me.lblQueryStatus.TabIndex = 44
        Me.lblQueryStatus.Text = "Query Status"
        Me.lblQueryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlUser
        '
        Me.pnlUser.AutoSize = True
        Me.pnlUser.BackColor = System.Drawing.Color.SkyBlue
        Me.pnlUser.Controls.Add(Me.lblUser)
        Me.pnlUser.Controls.Add(Me.mnuUser)
        Me.pnlUser.Controls.Add(Me.btnLogOut)
        Me.pnlUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlUser.ForeColor = System.Drawing.Color.Black
        Me.pnlUser.Location = New System.Drawing.Point(557, 0)
        Me.pnlUser.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(329, 35)
        Me.pnlUser.TabIndex = 45
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUser.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(0, 0)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(65, 35)
        Me.lblUser.TabIndex = 70
        Me.lblUser.Text = "User:"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuUser
        '
        Me.mnuUser.BackColor = System.Drawing.Color.Transparent
        Me.mnuUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.mnuUser.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUser.GripMargin = New System.Windows.Forms.Padding(0)
        Me.mnuUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userMain, Me.userOptions})
        Me.mnuUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnuUser.Location = New System.Drawing.Point(65, 0)
        Me.mnuUser.Name = "mnuUser"
        Me.mnuUser.Padding = New System.Windows.Forms.Padding(0)
        Me.mnuUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuUser.Size = New System.Drawing.Size(166, 35)
        Me.mnuUser.TabIndex = 71
        Me.mnuUser.Text = "User Action"
        '
        'userMain
        '
        Me.userMain.Name = "userMain"
        Me.userMain.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.userMain.Size = New System.Drawing.Size(91, 35)
        Me.userMain.Text = "UserName"
        '
        'userOptions
        '
        Me.userOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uoChangePassword})
        Me.userOptions.Name = "userOptions"
        Me.userOptions.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.userOptions.Size = New System.Drawing.Size(73, 35)
        Me.userOptions.Text = "Options"
        '
        'uoChangePassword
        '
        Me.uoChangePassword.Name = "uoChangePassword"
        Me.uoChangePassword.Size = New System.Drawing.Size(194, 24)
        Me.uoChangePassword.Text = "Change Password"
        '
        'btnLogOut
        '
        Me.btnLogOut.AutoSize = True
        Me.btnLogOut.BackColor = System.Drawing.Color.Khaki
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = Global.pharmacy.My.Resources.Resources.exit26
        Me.btnLogOut.Location = New System.Drawing.Point(231, 0)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(98, 35)
        Me.btnLogOut.TabIndex = 69
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Crimson
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStatus.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(150, 35)
        Me.lblStatus.TabIndex = 43
        Me.lblStatus.Text = "Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBottom
        '
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(5, 529)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(886, 5)
        Me.pnlBottom.TabIndex = 40
        '
        'pnlTop
        '
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(5, 75)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(886, 5)
        Me.pnlTop.TabIndex = 41
        '
        'tmrQuery
        '
        Me.tmrQuery.Interval = 5000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(896, 574)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.tplForm)
        Me.Controls.Add(Me.pnlBottomOuter)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHARMACY"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.tplForm.ResumeLayout(False)
        Me.tplForm.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlUser.ResumeLayout(False)
        Me.pnlUser.PerformLayout()
        Me.mnuUser.ResumeLayout(False)
        Me.mnuUser.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mainFileMaintenance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmSuppliers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmCategories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cateMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cateSub As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fmMiscellaneous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miscDiscounts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miscUnits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainTransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tnPurchase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tnReceive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tnStockAdjustments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tnPointOfSale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents pnlBottomOuter As System.Windows.Forms.Panel
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents mainSecurity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents prodDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prodExpiration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpStocks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scUserTypes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblQueryStatus As System.Windows.Forms.Label
    Friend WithEvents suppDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents suppProductSupplied As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlUser As System.Windows.Forms.Panel
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents mnuUser As System.Windows.Forms.MenuStrip
    Friend WithEvents userMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents userOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uoChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrQuery As System.Windows.Forms.Timer
    Friend WithEvents miscReceiptNumber As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miscVAT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tnReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rpExpirations As System.Windows.Forms.ToolStripMenuItem

End Class