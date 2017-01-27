Public Class frmPurchase

    Dim purchasedproduct As New purchasedproduct
    Friend supplier As New supplier
    Dim product As New product
    Dim quantity As Integer = 0

    Dim editable As Boolean = False

    Private Sub updateCode()
        Dim maxCode As Integer = getMaxCode("purchasedproducts")
        txtCode.Text = maxCode + 1
        While txtCode.TextLength < 5
            txtCode.Text = "0" + txtCode.Text
        End While
    End Sub

    Private Sub refreshButtons()
        btnNew.Enabled = True
        btnGenerate.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        Me.CancelButton = btnClose
    End Sub

    Private Sub clearDetails()
        txtCode.Text = String.Empty
        dtpDate.Value = Date.Today
        txtSupplier.Text = String.Empty
        lblProducts.Text = "Products to Order"
        dgvProducts.Rows.Clear()
    End Sub

    Private Sub yesEdit()
        editable = True
    End Sub
    Private Sub noEdit()
        editable = False
    End Sub

    Dim titleForm As New lblTitle("Purchase Order")
    Private Sub frmPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
        productQuantity.DefaultCellStyle = dgvRightStyle
        refreshButtons()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If Not editable Then
            If purchasedproduct.id = 0 Then
                dtpDate.Value = Date.Today
            Else
                dtpDate.Value = purchasedproduct.eventdate
            End If
        End If
    End Sub

    Friend Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        purchasedproduct = New purchasedproduct
        clearDetails()
        yesEdit()
        updateCode()
        btnNew.Enabled = False
        btnGenerate.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        Me.CancelButton = btnCancel
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If supplier.id <> 0 Then
            transBegin()
            For Each oneRow As DataGridViewRow In dgvProducts.Rows
                With purchasedproduct
                    .code = txtCode.Text
                    .eventdate = dtpDate.Value
                    .supplierID = supplier.id
                    .productID = getProduct(, oneRow.Cells("productCode").Value.ToString, ).id
                    .quantity = CInt(oneRow.Cells("productQuantity").Value.ToString)
                End With
            Next
            query_purchase(purchasedproduct, sqlType.insert)
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Purchase Order has been saved.")
                refreshButtons()
                clearDetails()
                noEdit()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        refreshButtons()
        clearDetails()
        noEdit()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Dim WithEvents frmSupplierSLC As Form = slcSuppliers
    Private Sub btnChooseSupplier_Click(sender As Object, e As EventArgs) Handles btnChooseSupplier.Click
        If editable Then
            MASK.now(slcSuppliers, Me)
            slcSuppliers.ShowDialog()
        End If
    End Sub
    Private Sub frmSupplierSLC_FormClosed() Handles frmSupplierSLC.FormClosed
        supplier = slcSuppliers.supplier
        txtSupplier.Text = supplier.name
    End Sub

    Dim WithEvents frmProductSLC As Form = slcSuppliersProducts
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If editable Then
            MASK.now(slcSuppliersProducts, Me)
            slcSuppliersProducts.supplier = supplier
            slcSuppliersProducts.ShowDialog()
        End If
    End Sub
    Private Sub frmProductSLC_FormClosed() Handles frmProductSLC.FormClosed
        product = slcSuppliersProducts.output.product
        quantity = slcSuppliersProducts.output.quantity
        If product.id <> 0 Then
            dgvProducts.Rows.Add(product.code, product.name, quantity)
            dgvProducts.ClearSelection()
        End If
    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        If editable And dgvProducts.SelectedRows.Count > 0 Then
            dgvProducts.Rows.Remove(dgvProducts.SelectedRows(0))
        End If
    End Sub

End Class