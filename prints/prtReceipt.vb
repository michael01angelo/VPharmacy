Friend Class prtReceipt

    Private Function addDescription(row As DataGridViewRow) As Label
        Dim label As New Label
        With label
            .Dock = DockStyle.Top
            .TextAlign = ContentAlignment.MiddleLeft
            .Text = row.Cells("itemCode").Value.ToString + "   " + row.Cells("itemDescription").Value.ToString
        End With
        Return label
    End Function

    Private Function addTransaction(row As DataGridViewRow) As Label
        Dim label As New Label
        With label
            .Dock = DockStyle.Top
            .TextAlign = ContentAlignment.MiddleRight
            .Text = row.Cells("itemQuantity").Value.ToString + "          " + row.Cells("itemUnitPrice").Value.ToString + "          " + row.Cells("itemTotal").Value.ToString
        End With
        Return label
    End Function

    Private Sub loadData()
        For Each oneRow As DataGridViewRow In frmPointOfSale.dgvItems.Rows
            With pnlItems.Controls
                .Add(addTransaction(oneRow))
                .Add(addDescription(oneRow))
            End With
        Next
        lblTitle.Text = My.Settings.CompanyName
        lblAddress.Text = My.Settings.CompanyAddress
        lblNumbers.Text = My.Settings.CompanyNumbers
        lblDate.Text = frmPointOfSale.txtDateTime.Text
        lblCashier.Text = "Cashier: " + frmPointOfSale.txtCashier.Text
        lblReceipt.Text = "OR: " + frmPointOfSale.txtReceiptNumber.Text
        lblTotalItems.Text = frmPointOfSale.txtTotalItems.Text
        lblSubTotal.Text = frmPointOfSale.txtSubTotal.Text
        lblVAT.Text = frmPointOfSale.txtVAT.Text
        lblDiscount.Text = frmPointOfSale.txtDiscountValue.Text
        lblTotalDue.Text = frmPointOfSale.txtDueTotal.Text
        lblCash.Text = frmPointOfSale.txtCash.Text
        lblChange.Text = frmPointOfSale.txtChange.Text
    End Sub

    Private Sub prtReceipt_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
    End Sub

    Dim WithEvents formPrint As Form = Print
    Private Sub PRINT_CLOSE() Handles formPrint.FormClosed
        Me.Close()
    End Sub

End Class