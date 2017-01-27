Friend Class frmReceive

    Dim lstReceivedProducts As New List(Of receivedproduct)
    Dim receivedproduct As New receivedproduct
    Dim supplier As New supplier
    Dim product As New product
    Dim quantity As New Integer
    Dim price As New Decimal

    Private Sub loadProducts()
        dgvProducts.Rows.Clear()
        lstReceivedProducts = getReceivedProducts(txtCode.Text)
        For Each oneReceivedProduct As receivedproduct In lstReceivedProducts
            dgvProducts.Rows.Add(getProduct(oneReceivedProduct.productID).code, getProduct(oneReceivedProduct.productID).name, oneReceivedProduct.quantity, oneReceivedProduct.price)
        Next
        dgvProducts.ClearSelection()
    End Sub

    Private Sub showDetails()
        txtSupplier.Text = getSupplier(supplier.id, , ).name
        loadProducts()
    End Sub

    Dim titleForm As New lblTitle("Receive Orders")
    Private Sub frmReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
        productQuantity.DefaultCellStyle = dgvRightStyle
        productPrice.DefaultCellStyle = dgvRightStyle
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Dim WithEvents frmReceiveProductsSLC As Form = slcReceiveProducts
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        MASK.now(slcReceiveProducts, Me)
        slcReceiveProducts.code = txtCode.Text
        slcReceiveProducts.ShowDialog()
    End Sub
    Private Sub frmReceiveProductsSLC_FormClosed() Handles frmReceiveProductsSLC.FormClosed
        product = slcReceiveProducts.output.product
        quantity = slcReceiveProducts.output.quantity
        price = slcReceiveProducts.output.price
        If product.id <> 0 Then
            transBegin()
            With receivedproduct
                .code = txtCode.Text
                .eventdate = dtpDate.Value
                .supplierID = supplier.id
                .productID = product.id
                .quantity = quantity
                .price = price
            End With
            query_receivedproduct(receivedproduct, sqlType.insert)
            inventory_update(product, quantity, "Add")
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Product Received has been saved.")
                loadProducts()
            End If
        End If
    End Sub

    Dim WithEvents frmOrderSLC As Form = slcPurchasedOrders
    Private Sub btnOrderBrowse_Click(sender As Object, e As EventArgs) Handles btnOrderBrowse.Click
        MASK.now(slcPurchasedOrders, Me)
        slcPurchasedOrders.ShowDialog()
    End Sub
    Private Sub frmOrderSLC_FormClosed() Handles frmOrderSLC.FormClosed
        If slcPurchasedOrders.purchasedproduct.id <> 0 Then
            txtCode.Text = slcPurchasedOrders.purchasedproduct.code
            While txtCode.TextLength < 5
                txtCode.Text = "0" + txtCode.Text
            End While
            supplier = getSupplier(slcPurchasedOrders.purchasedproduct.supplierID, , )
            txtSupplier.Text = supplier.name
            loadProducts()
        End If
    End Sub

End Class