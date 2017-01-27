Friend Class frmReturnToSupplier

    Dim lstReturnedProducts As New List(Of returnedproduct)
    Dim returnedproduct As New returnedproduct
    Dim supplier As New supplier
    Dim product As New product
    Dim quantity As New Integer
    Dim remarks As String = ""

    Private Sub loadProducts()
        dgvProducts.Rows.Clear()
        lstReturnedProducts = getReturnedProducts(supplier, dtpDate.Value)
        For Each oneReturnedProduct As returnedproduct In lstReturnedProducts
            dgvProducts.Rows.Add(getProduct(oneReturnedProduct.productID).code, getProduct(oneReturnedProduct.productID).name, oneReturnedProduct.quantity, oneReturnedProduct.remarks)
        Next
        dgvProducts.ClearSelection()
        If dgvProducts.Rows.Count > 0 Then
            btnOrder.Enabled = True
        Else
            btnOrder.Enabled = False
        End If
    End Sub

    Private Sub showDetails()
        txtSupplier.Text = getSupplier(supplier.id, , ).name
        loadProducts()
    End Sub

    Dim titleForm As New lblTitle("Return Products to Supplier")
    Private Sub frmReturnToSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
        productQuantity.DefaultCellStyle = dgvRightStyle
        productRemarks.DefaultCellStyle = dgvLeftStyle
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Dim WithEvents frmReturnProductsSLC As Form = slcReturnProducts
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        MASK.now(slcReturnProducts, Me)
        slcReturnProducts.supplier = supplier
        slcReturnProducts.ShowDialog()
    End Sub
    Private Sub frmReturnProductsSLC_FormClosed() Handles frmReturnProductsSLC.FormClosed
        product = slcReturnProducts.output.product
        quantity = slcReturnProducts.output.quantity
        remarks = slcReturnProducts.output.remarks
        If product.id <> 0 Then
            transBegin()
            With returnedproduct
                .eventdate = dtpDate.Value
                .supplierID = supplier.id
                .productID = product.id
                .quantity = quantity
                .remarks = remarks
            End With
            query_returnedproduct(returnedproduct, sqlType.insert)
            inventory_update(product, quantity, "Deduct")
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Product Returned has been saved.")
                loadProducts()
            End If
        End If
    End Sub

    Dim WithEvents frmSupplierSLC As Form = slcSuppliers
    Private Sub btnChooseSupplier_Click(sender As Object, e As EventArgs) Handles btnChooseSupplier.Click
        MASK.now(slcSuppliers, Me)
        slcSuppliers.ShowDialog()
    End Sub
    Private Sub frmSupplierSLC_FormClosed() Handles frmSupplierSLC.FormClosed
        supplier = slcSuppliers.supplier
        If supplier.id <> 0 Then
            showDetails()
        End If
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        If Not frmPurchase.IsHandleCreated Then
            With frmPurchase
                .MdiParent = frmMain
                .Show()
                .btnNew_Click(sender, e)
                .supplier = supplier
                .txtSupplier.Text = supplier.name
            End With
        End If
        With frmPurchase
            For Each oneRow As DataGridViewRow In dgvProducts.Rows
                .dgvProducts.Rows.Add(oneRow.Cells("productCode").Value.ToString, oneRow.Cells("productDescription").Value.ToString, oneRow.Cells("productQuantity").Value.ToString)
            Next

        End With
    End Sub

End Class