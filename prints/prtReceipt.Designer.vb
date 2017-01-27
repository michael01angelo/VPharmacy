<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prtReceipt
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
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.lblTextTotalItems = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDividerTop = New System.Windows.Forms.Label()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDividerBottom = New System.Windows.Forms.Label()
        Me.lblTextSubTotal = New System.Windows.Forms.Label()
        Me.lblTextVAT = New System.Windows.Forms.Label()
        Me.lblTextDiscount = New System.Windows.Forms.Label()
        Me.lblTextTotalDue = New System.Windows.Forms.Label()
        Me.lblTextCash = New System.Windows.Forms.Label()
        Me.lblTextChange = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.tplContents.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.AutoSize = True
        Me.tplContents.ColumnCount = 2
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplContents.Controls.Add(Me.lblTotalItems, 1, 9)
        Me.tplContents.Controls.Add(Me.lblTextTotalItems, 0, 9)
        Me.tplContents.Controls.Add(Me.lblCashier, 0, 4)
        Me.tplContents.Controls.Add(Me.lblDate, 0, 3)
        Me.tplContents.Controls.Add(Me.lblDividerTop, 0, 6)
        Me.tplContents.Controls.Add(Me.lblReceipt, 0, 5)
        Me.tplContents.Controls.Add(Me.lblNumbers, 0, 2)
        Me.tplContents.Controls.Add(Me.lblAddress, 0, 1)
        Me.tplContents.Controls.Add(Me.lblTitle, 0, 0)
        Me.tplContents.Controls.Add(Me.lblDividerBottom, 0, 8)
        Me.tplContents.Controls.Add(Me.lblTextSubTotal, 0, 10)
        Me.tplContents.Controls.Add(Me.lblTextVAT, 0, 11)
        Me.tplContents.Controls.Add(Me.lblTextDiscount, 0, 12)
        Me.tplContents.Controls.Add(Me.lblTextTotalDue, 0, 13)
        Me.tplContents.Controls.Add(Me.lblTextCash, 0, 14)
        Me.tplContents.Controls.Add(Me.lblTextChange, 0, 15)
        Me.tplContents.Controls.Add(Me.lblMsg, 0, 16)
        Me.tplContents.Controls.Add(Me.lblSubTotal, 1, 10)
        Me.tplContents.Controls.Add(Me.lblVAT, 1, 11)
        Me.tplContents.Controls.Add(Me.lblDiscount, 1, 12)
        Me.tplContents.Controls.Add(Me.lblTotalDue, 1, 13)
        Me.tplContents.Controls.Add(Me.lblCash, 1, 14)
        Me.tplContents.Controls.Add(Me.lblChange, 1, 15)
        Me.tplContents.Controls.Add(Me.pnlItems, 0, 7)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(0)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 17
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tplContents.Size = New System.Drawing.Size(220, 270)
        Me.tplContents.TabIndex = 0
        '
        'lblTotalItems
        '
        Me.lblTotalItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Location = New System.Drawing.Point(110, 145)
        Me.lblTotalItems.Margin = New System.Windows.Forms.Padding(0, 5, 25, 0)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(85, 15)
        Me.lblTotalItems.TabIndex = 23
        Me.lblTotalItems.Text = "TotalItems"
        Me.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextTotalItems
        '
        Me.lblTextTotalItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextTotalItems.AutoSize = True
        Me.lblTextTotalItems.Location = New System.Drawing.Point(0, 145)
        Me.lblTextTotalItems.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblTextTotalItems.Name = "lblTextTotalItems"
        Me.lblTextTotalItems.Size = New System.Drawing.Size(110, 15)
        Me.lblTextTotalItems.TabIndex = 22
        Me.lblTextTotalItems.Text = "Total Items:"
        Me.lblTextTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCashier
        '
        Me.lblCashier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCashier.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblCashier, 2)
        Me.lblCashier.Location = New System.Drawing.Point(0, 65)
        Me.lblCashier.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(220, 15)
        Me.lblCashier.TabIndex = 21
        Me.lblCashier.Text = "Cashier"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblDate, 2)
        Me.lblDate.Location = New System.Drawing.Point(0, 50)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(220, 15)
        Me.lblDate.TabIndex = 20
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDividerTop
        '
        Me.lblDividerTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDividerTop.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblDividerTop, 2)
        Me.lblDividerTop.Location = New System.Drawing.Point(0, 100)
        Me.lblDividerTop.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDividerTop.Name = "lblDividerTop"
        Me.lblDividerTop.Size = New System.Drawing.Size(220, 20)
        Me.lblDividerTop.TabIndex = 4
        Me.lblDividerTop.Text = "-------------------------------------"
        Me.lblDividerTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReceipt
        '
        Me.lblReceipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReceipt.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblReceipt, 2)
        Me.lblReceipt.Location = New System.Drawing.Point(0, 85)
        Me.lblReceipt.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(220, 15)
        Me.lblReceipt.TabIndex = 3
        Me.lblReceipt.Text = "Receipt"
        Me.lblReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumbers
        '
        Me.lblNumbers.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumbers.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblNumbers, 2)
        Me.lblNumbers.Location = New System.Drawing.Point(0, 30)
        Me.lblNumbers.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(220, 15)
        Me.lblNumbers.TabIndex = 2
        Me.lblNumbers.Text = "Numbers"
        Me.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblAddress, 2)
        Me.lblAddress.Location = New System.Drawing.Point(0, 15)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(220, 15)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblTitle, 2)
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDividerBottom
        '
        Me.lblDividerBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDividerBottom.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblDividerBottom, 2)
        Me.lblDividerBottom.Location = New System.Drawing.Point(0, 120)
        Me.lblDividerBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDividerBottom.Name = "lblDividerBottom"
        Me.lblDividerBottom.Size = New System.Drawing.Size(220, 20)
        Me.lblDividerBottom.TabIndex = 5
        Me.lblDividerBottom.Text = "-------------------------------------"
        Me.lblDividerBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTextSubTotal
        '
        Me.lblTextSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextSubTotal.AutoSize = True
        Me.lblTextSubTotal.Location = New System.Drawing.Point(0, 160)
        Me.lblTextSubTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTextSubTotal.Name = "lblTextSubTotal"
        Me.lblTextSubTotal.Size = New System.Drawing.Size(110, 15)
        Me.lblTextSubTotal.TabIndex = 6
        Me.lblTextSubTotal.Text = "Sub Total:"
        Me.lblTextSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextVAT
        '
        Me.lblTextVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextVAT.AutoSize = True
        Me.lblTextVAT.Location = New System.Drawing.Point(0, 175)
        Me.lblTextVAT.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTextVAT.Name = "lblTextVAT"
        Me.lblTextVAT.Size = New System.Drawing.Size(110, 15)
        Me.lblTextVAT.TabIndex = 8
        Me.lblTextVAT.Text = "12% VAT:"
        Me.lblTextVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextDiscount
        '
        Me.lblTextDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextDiscount.AutoSize = True
        Me.lblTextDiscount.Location = New System.Drawing.Point(0, 190)
        Me.lblTextDiscount.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTextDiscount.Name = "lblTextDiscount"
        Me.lblTextDiscount.Size = New System.Drawing.Size(110, 15)
        Me.lblTextDiscount.TabIndex = 10
        Me.lblTextDiscount.Text = "Discount:"
        Me.lblTextDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextTotalDue
        '
        Me.lblTextTotalDue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextTotalDue.AutoSize = True
        Me.lblTextTotalDue.Location = New System.Drawing.Point(0, 205)
        Me.lblTextTotalDue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTextTotalDue.Name = "lblTextTotalDue"
        Me.lblTextTotalDue.Size = New System.Drawing.Size(110, 15)
        Me.lblTextTotalDue.TabIndex = 12
        Me.lblTextTotalDue.Text = "Total Due:"
        Me.lblTextTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextCash
        '
        Me.lblTextCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextCash.AutoSize = True
        Me.lblTextCash.Location = New System.Drawing.Point(0, 225)
        Me.lblTextCash.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblTextCash.Name = "lblTextCash"
        Me.lblTextCash.Size = New System.Drawing.Size(110, 15)
        Me.lblTextCash.TabIndex = 14
        Me.lblTextCash.Text = "Cash:"
        Me.lblTextCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTextChange
        '
        Me.lblTextChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTextChange.AutoSize = True
        Me.lblTextChange.Location = New System.Drawing.Point(0, 242)
        Me.lblTextChange.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTextChange.Name = "lblTextChange"
        Me.lblTextChange.Size = New System.Drawing.Size(110, 15)
        Me.lblTextChange.TabIndex = 16
        Me.lblTextChange.Text = "Change:"
        Me.lblTextChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMsg
        '
        Me.lblMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMsg.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.lblMsg, 2)
        Me.lblMsg.Location = New System.Drawing.Point(0, 265)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(220, 15)
        Me.lblMsg.TabIndex = 18
        Me.lblMsg.Text = "This serves as official receipt."
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(110, 160)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(85, 15)
        Me.lblSubTotal.TabIndex = 7
        Me.lblSubTotal.Text = "SubTotal"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVAT
        '
        Me.lblVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Location = New System.Drawing.Point(110, 175)
        Me.lblVAT.Margin = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(85, 15)
        Me.lblVAT.TabIndex = 9
        Me.lblVAT.Text = "VAT"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(110, 190)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(85, 15)
        Me.lblDiscount.TabIndex = 11
        Me.lblDiscount.Text = "Discount"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDue
        '
        Me.lblTotalDue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(110, 205)
        Me.lblTotalDue.Margin = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(85, 15)
        Me.lblTotalDue.TabIndex = 13
        Me.lblTotalDue.Text = "TotalDue"
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCash
        '
        Me.lblCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCash.AutoSize = True
        Me.lblCash.Location = New System.Drawing.Point(110, 225)
        Me.lblCash.Margin = New System.Windows.Forms.Padding(0, 5, 25, 0)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(85, 15)
        Me.lblCash.TabIndex = 15
        Me.lblCash.Text = "Cash"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(110, 242)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(0, 0, 25, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(85, 15)
        Me.lblChange.TabIndex = 17
        Me.lblChange.Text = "Change"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlItems
        '
        Me.pnlItems.AutoSize = True
        Me.tplContents.SetColumnSpan(Me.pnlItems, 2)
        Me.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItems.Location = New System.Drawing.Point(0, 120)
        Me.pnlItems.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(220, 1)
        Me.pnlItems.TabIndex = 19
        '
        'prtReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(250, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplContents)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "prtReceipt"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "prtReceipt"
        Me.TopMost = True
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDividerTop As System.Windows.Forms.Label
    Friend WithEvents lblReceipt As System.Windows.Forms.Label
    Friend WithEvents lblDividerBottom As System.Windows.Forms.Label
    Friend WithEvents lblTextSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTextVAT As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents lblTextDiscount As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTextTotalDue As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents lblTextCash As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblTextChange As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents pnlItems As System.Windows.Forms.Panel
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTotalItems As System.Windows.Forms.Label
    Friend WithEvents lblTextTotalItems As System.Windows.Forms.Label
End Class
