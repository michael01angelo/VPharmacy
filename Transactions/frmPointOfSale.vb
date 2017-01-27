Friend Class frmPointOfSale

    Dim lstProducts As List(Of product) = getProducts()
    Dim product As New product
    Dim lstDiscounts As List(Of discount) = getDiscounts()
    Dim discount As New discount
    Dim vatPercent As Decimal = getVAT() / 100
    Dim receipt As New receipt
    Dim receiptCode As receiptnumber = getReceiptCode()
    Dim transaction As New transaction

    Dim paying As Boolean = False

    Private Sub resetAll()
        lstProducts = getProducts()
        lstDiscounts = getDiscounts()
        receiptCode = getReceiptCode()
        vatPercent = getVAT()
        txtReceiptNumber.Clear()
        txtDueTotal.Clear()
        txtCash.Clear()
        txtChange.Clear()
        dgvItems.Rows.Clear()
        txtDiscount.Clear()
        txtDiscountPercent.Clear()
        txtDiscountValue.Clear()
        txtTotalItems.Clear()
        txtSubTotal.Clear()
        txtVAT.Clear()
        txtCashR.Clear()
        paying = False
    End Sub

    Private Sub updateReceiptCode()
        lstProducts = getProducts()
        If dgvItems.Rows.Count > 0 Then
            Dim maxCode As Integer = getMaxCode("receipts")
            txtReceiptNumber.Text = CInt(receiptCode.startCode) + maxCode + 1
            While txtReceiptNumber.TextLength <= 16
                txtReceiptNumber.Text = "0" + txtReceiptNumber.Text
            End While
        Else
            txtReceiptNumber.Clear()
        End If
    End Sub

    Private Sub updateItems()
        If dgvProducts.Rows.Count > 0 Then
            For Each oneProduct As product In lstProducts
                If oneProduct.code.Equals(dgvProducts.SelectedRows(0).Cells("productCode").Value.ToString) Then
                    Dim same As Boolean = False
                    For Each oneRow As DataGridViewRow In dgvItems.Rows
                        If oneProduct.code.Equals(oneRow.Cells("itemCode").Value.ToString) Then
                            oneRow.Cells("itemQuantity").Value = CInt(oneRow.Cells("itemQuantity").Value) + CInt(txtQuantity.Text)
                            oneRow.Cells("itemTotal").Value = FormatNumber((oneProduct.price + (oneProduct.price * vatPercent)) * CInt(oneRow.Cells("itemQuantity").Value))
                            dgvItems.Rows(oneRow.Index).Selected = True
                            same = True
                        End If
                    Next
                    If Not same Then
                        If oneProduct.stock > 0 Then
                            dgvItems.Rows.Insert(0, oneProduct.code, oneProduct.name, FormatNumber(oneProduct.price + (oneProduct.price * vatPercent)), txtQuantity.Text, FormatNumber((oneProduct.price + (oneProduct.price * vatPercent)) * CInt(txtQuantity.Text)))
                            dgvItems.Rows(0).Selected = True
                        End If
                    End If
                End If
            Next
        End If
        updateNumbers()
        updateReceiptCode()
        txtProductInput.Clear()
        txtQuantity.Text = "1"
    End Sub

    Private Sub updateNumbers()
        Dim itemCount As New Integer
        Dim subTotal As New Decimal
        Dim vat As New Decimal
        Dim total As New Decimal
        Dim discountValue As New Decimal
        For Each oneProduct As product In lstProducts
                For Each oneRow As DataGridViewRow In dgvItems.Rows
                If oneRow.Cells("itemCode").Value.ToString.Equals(oneProduct.code) Then
                    itemCount += CInt(oneRow.Cells("itemQuantity").Value)
                    subTotal += oneProduct.price * CInt(oneRow.Cells("itemQuantity").Value)
                    vat += oneProduct.price * vatPercent * CInt(oneRow.Cells("itemQuantity").Value)
                    If oneProduct.discountable Then
                        discountValue += (oneProduct.price + (oneProduct.price * vatPercent)) * (discount.value / 100) * CInt(oneRow.Cells("itemQuantity").Value)
                    End If
                End If
            Next
        Next
        total = subTotal + vat - discountValue
        txtTotalItems.Text = itemCount
        txtSubTotal.Text = FormatNumber(subTotal, 2)
        txtVAT.Text = FormatNumber(vat, 2)
        txtDiscountValue.Text = FormatNumber(discountValue, 2)
        txtDueTotal.Text = FormatNumber(total, 2)
        txtCash.Text = "0.00"
        txtChange.Text = "0.00"
    End Sub

    Private Sub updatePayment()
        If IsNumeric(txtCashR.Text) Then
            txtCash.Text = FormatNumber(txtCashR.Text, 2)
            txtChange.Text = CDec(txtCash.Text) - CDec(txtDueTotal.Text)
            txtCashR.SelectAll()
        Else
            MessageBox.Show("Please input only numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCashR.SelectAll()
        End If
    End Sub

    Private Sub frmPointOfSale_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblVAT.Text = "VAT" + " (" + (vatPercent * 100).ToString + ")"
        If currentUser.givenname <> String.Empty Then
            txtCashier.Text = currentUser.givenname
        Else
            txtCashier.Text = currentUser.name
        End If
        cbxDiscounts.Items.Clear()
        For Each oneDiscount As discount In lstDiscounts
            cbxDiscounts.Items.Add(oneDiscount.description)
        Next
        cbxDiscounts.SelectedIndex = 0
        txtProductInput.Select()
    End Sub

    Private Sub frmPointOfSale_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Not paying Then
            Select Case e.KeyCode
                Case Keys.F9
                    btnProductInput_Click(sender, e)
                Case Keys.F10
                    btnQuantity_Click(sender, e)
                Case Keys.F11
                    btnDiscount_Click(sender, e)
                Case Keys.F12
                    btnCash_Click(sender, e)
                Case Keys.Up
                    btnItemUp_Click(sender, e)
                Case Keys.Down
                    btnItemDown_Click(sender, e)
                Case Keys.Left
                    btnItemMinus_Click(sender, e)
                Case Keys.Right
                    btnItemPlus_Click(sender, e)
                Case Keys.Delete
                    btnItemRemove_Click(sender, e)
                Case Keys.PageUp
                    btnProductUp_Click(sender, e)
                Case Keys.PageDown
                    btnProductDown_Click(sender, e)
                Case Keys.Enter
                    If txtProductInput.Focused Or txtQuantity.Focused Then
                        updateItems()
                    End If
            End Select
        Else
            If e.KeyCode = Keys.Enter Then
                updatePayment()
            End If
        End If
    End Sub

    Dim titleForm As New lblTitle(My.Settings.CompanyName + vbCrLf + "Point Of Sale")
    Private Sub frmPointOfSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        lblTitle.Text = My.Settings.CompanyName
        lblAddress.Text = My.Settings.CompanyAddress
        lblNumbers.Text = My.Settings.CompanyNumbers
        lblVersion.Text += Application.ProductVersion
        dgvItems.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        itemCode.DefaultCellStyle = dgvRightStyle
        itemDescription.DefaultCellStyle = dgvLeftStyle
        itemUnitPrice.DefaultCellStyle = dgvRightStyle
        itemQuantity.DefaultCellStyle = dgvRightStyle
        itemTotal.DefaultCellStyle = dgvRightStyle
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
        productUnitPrice.DefaultCellStyle = dgvRightStyle
        productStock.DefaultCellStyle = dgvRightStyle
    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        txtDateTime.Text = Date.Now.ToString("dddd, dd MMMM yyyy - hh:mm tt")
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            disconnect()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnProductInput_Click(sender As Object, e As EventArgs) Handles btnProductInput.Click
        txtProductInput.Select()
    End Sub
    Private Sub txtProductInput_TextChanged(sender As Object, e As EventArgs) Handles txtProductInput.TextChanged
        dgvProducts.Rows.Clear()
        If txtProductInput.Text <> String.Empty Then
            For Each oneProduct As product In lstProducts
                If oneProduct.code.ToLower.Contains(txtProductInput.Text.ToLower) Or oneProduct.name.ToLower.Contains(txtProductInput.Text.ToLower) Then
                    dgvProducts.Rows.Add(oneProduct.code, oneProduct.name, FormatNumber(oneProduct.price + (oneProduct.price * vatPercent)), oneProduct.stock)
                End If
            Next
        End If
        If dgvProducts.Rows.Count > 0 Then
            dgvProducts.Rows(0).Selected = True
        End If
    End Sub

    Private Sub btnQuantity_Click(sender As Object, e As EventArgs) Handles btnQuantity.Click
        txtQuantity.Select()
        txtQuantity.SelectAll()
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        If cbxDiscounts.Items.Count > 0 Then
            If cbxDiscounts.SelectedIndex = cbxDiscounts.Items.Count - 1 Then
                cbxDiscounts.SelectedIndex = 0
            Else
                cbxDiscounts.SelectedIndex += 1
            End If
        End If
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        txtCashR.Select()
        txtCashR.SelectAll()
    End Sub

    Private Sub btnItemUp_Click(sender As Object, e As EventArgs) Handles btnItemUp.Click
        If Not paying And dgvItems.Rows.Count > 0 AndAlso dgvItems.SelectedRows(0).Index > 0 Then
            dgvItems.Rows(dgvItems.SelectedRows(0).Index - 1).Selected = True
        End If
    End Sub

    Private Sub btnItemDown_Click(sender As Object, e As EventArgs) Handles btnItemDown.Click
        If Not paying And dgvItems.Rows.Count > 0 AndAlso dgvItems.SelectedRows(0).Index < dgvItems.Rows.Count - 1 Then
            dgvItems.Rows(dgvItems.SelectedRows(0).Index + 1).Selected = True
        End If
    End Sub

    Private Sub btnItemMinus_Click(sender As Object, e As EventArgs) Handles btnItemMinus.Click
        If Not paying And dgvItems.Rows.Count > 0 AndAlso CInt(dgvItems.SelectedRows(0).Cells("itemQuantity").Value) > 1 Then
            With dgvItems.SelectedRows(0)
                .Cells("itemQuantity").Value = CInt(dgvItems.SelectedRows(0).Cells("itemQuantity").Value) - 1
                .Cells("itemTotal").Value = CDec(dgvItems.SelectedRows(0).Cells("itemUnitPrice").Value) * CInt(dgvItems.SelectedRows(0).Cells("itemQuantity").Value)
            End With
            updateNumbers()
        End If
    End Sub

    Private Sub btnItemPlus_Click(sender As Object, e As EventArgs) Handles btnItemPlus.Click
        If Not paying And dgvItems.Rows.Count > 0 Then
            With dgvItems.SelectedRows(0)
                .Cells("itemQuantity").Value = CInt(dgvItems.SelectedRows(0).Cells("itemQuantity").Value) + 1
                .Cells("itemTotal").Value = CDec(dgvItems.SelectedRows(0).Cells("itemUnitPrice").Value) * CInt(dgvItems.SelectedRows(0).Cells("itemQuantity").Value)
            End With
            updateNumbers()
        End If
    End Sub

    Private Sub btnItemRemove_Click(sender As Object, e As EventArgs) Handles btnItemRemove.Click
        If Not paying And dgvItems.Rows.Count > 0 Then
            dgvItems.Rows.Remove(dgvItems.SelectedRows(0))
            updateNumbers()
            updateReceiptCode()
        End If
    End Sub

    Private Sub btnProductUp_Click(sender As Object, e As EventArgs) Handles btnProductUp.Click
        If dgvProducts.Rows.Count > 0 AndAlso dgvProducts.SelectedRows(0).Index <> 0 Then
            dgvProducts.Rows(dgvProducts.SelectedRows(0).Index - 1).Selected = True
        End If
    End Sub

    Private Sub btnProductDown_Click(sender As Object, e As EventArgs) Handles btnProductDown.Click
        If dgvProducts.Rows.Count > 0 AndAlso dgvProducts.SelectedRows(0).Index <> dgvProducts.Rows.Count - 1 Then
            dgvProducts.Rows(dgvProducts.SelectedRows(0).Index + 1).Selected = True
        End If
    End Sub

    Private Sub txtProductInput_GotFocus(sender As Object, e As EventArgs) Handles txtProductInput.GotFocus
        txtProductInput.BackColor = Color.GreenYellow
        lblProductInput.BackColor = Color.Gold
    End Sub
    Private Sub txtProductInput_LostFocus(sender As Object, e As EventArgs) Handles txtProductInput.LostFocus
        txtProductInput.BackColor = Color.LightGreen
        lblProductInput.BackColor = Color.Lime
    End Sub

    Private Sub txtQuantity_GotFocus(sender As Object, e As EventArgs) Handles txtQuantity.GotFocus
        txtQuantity.BackColor = Color.GreenYellow
        lblQuantity.BackColor = Color.Gold
    End Sub
    Private Sub txtQuantity_LostFocus(sender As Object, e As EventArgs) Handles txtQuantity.LostFocus
        txtQuantity.BackColor = Color.LightGreen
        lblQuantity.BackColor = Color.Lime
    End Sub

    Private Sub txtCashR_GotFocus(sender As Object, e As EventArgs) Handles txtCashR.GotFocus
        txtCashR.BackColor = Color.GreenYellow
        lblCashR.BackColor = Color.Gold
        txtDueTotal.BackColor = Color.GreenYellow
        lblDueTotal.BackColor = Color.Gold
        txtCash.BackColor = Color.GreenYellow
        lblCash.BackColor = Color.Gold
        txtChange.BackColor = Color.GreenYellow
        lblChange.BackColor = Color.Gold
        dgvItems.ClearSelection()
        paying = True
    End Sub
    Private Sub txtCashR_LostFocus(sender As Object, e As EventArgs) Handles txtCashR.LostFocus
        txtCashR.BackColor = Color.LightGreen
        lblCashR.BackColor = Color.Lime
        txtDueTotal.BackColor = Color.LightGreen
        lblDueTotal.BackColor = Color.Lime
        txtCash.BackColor = Color.LightGreen
        lblCash.BackColor = Color.Lime
        txtChange.BackColor = Color.LightGreen
        lblChange.BackColor = Color.Lime
        If dgvItems.Rows.Count > 0 Then
            dgvItems.Rows(0).Selected = True
        End If
    End Sub

    Private Sub cbxDiscounts_GotFocus(sender As Object, e As EventArgs) Handles btnDiscount.GotFocus, cbxDiscounts.GotFocus
        cbxDiscounts.BackColor = Color.GreenYellow
        lblDiscountR.BackColor = Color.Gold
        tmrFive.Enabled = True
    End Sub
    Private Sub cbxDiscounts_LostFocus(sender As Object, e As EventArgs) Handles btnDiscount.LostFocus, cbxDiscounts.LostFocus
        cbxDiscounts.BackColor = Color.LightGreen
        lblDiscountR.BackColor = Color.Lime
    End Sub
    Private Sub tmrFive_Tick(sender As Object, e As EventArgs) Handles tmrFive.Tick
        txtProductInput.Select()
        tmrFive.Enabled = False
    End Sub

    Private Sub cbxDiscounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDiscounts.SelectedIndexChanged
        For Each oneDiscount As discount In lstDiscounts
            If oneDiscount.description.Equals(cbxDiscounts.SelectedItem.ToString) Then
                discount = oneDiscount
                txtDiscount.Text = discount.description
                txtDiscountPercent.Text = discount.value
            End If
        Next
        updateNumbers()
    End Sub

    Private Sub controls_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus, txtDateTime.GotFocus, txtCashier.GotFocus, txtReceiptNumber.GotFocus, txtDueTotal.GotFocus, txtCash.GotFocus, txtChange.GotFocus, dgvItems.GotFocus, txtDiscount.GotFocus, txtDiscountPercent.GotFocus, txtDiscountValue.GotFocus, txtTotalItems.GotFocus, txtSubTotal.GotFocus, txtVAT.GotFocus, dgvProducts.GotFocus, btnProductUp.GotFocus, btnProductDown.GotFocus, btnItemUp.GotFocus, btnItemDown.GotFocus, btnItemPlus.GotFocus, btnItemMinus.GotFocus, btnItemRemove.GotFocus
        txtProductInput.Select()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If txtCash.Text <> String.Empty Then
            saveReceipt()
            saveTransaction()
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                query_receiptSave(receipt)
                prtReceipt.Show()
                Print.ShowDialog()
                MessageBox.Show("Transaction has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                resetAll()
            End If
        End If
    End Sub

    Private Sub saveReceipt()
        transBegin()
        With receipt
            .code = txtReceiptNumber.Text
            .datetime = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
            .cashierID = currentUser.id
            .discountID = discount.id
            .amountdue = CDec(txtDueTotal.Text)
            .cash = CDec(txtCash.Text)
            .void = True
        End With
        query_receipt(receipt, sqlType.insert)
        If query.err Then
            transRollback()
            MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            transCommit()
            receipt = getReceipt(, receipt.code)
        End If
    End Sub
    Private Sub saveTransaction()
        transBegin()
        For Each oneProduct As product In lstProducts
                For Each oneRow As DataGridViewRow In dgvItems.Rows
                If oneProduct.code.Equals(oneRow.Cells("itemCode").Value.ToString) Then
                    With transaction
                        .receiptID = receipt.id
                        .productID = oneProduct.id
                        .price = CDec(oneRow.Cells("itemUnitPrice").Value)
                        .quantity = CInt(oneRow.Cells("itemQuantity").Value)
                    End With
                    inventory_update(oneProduct, transaction.quantity, "Deduct")
                    query_transaction(transaction, sqlType.insert)
                End If
            Next
        Next
    End Sub

End Class