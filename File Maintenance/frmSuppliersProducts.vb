Public Class frmSuppliersProducts

    Dim supplier As New supplier
    Dim lstProducts As List(Of product) = getProducts()
    Dim product As New product

    Private Sub loadProducts()
        If dgvProducts.ColumnCount > 0 Then
            dgvProducts.Rows.Clear()
            Dim lstSuppliersProducts = getSuppliersProducts(supplier)
            For Each oneProduct As product In lstSuppliersProducts
                dgvProducts.Rows.Add(oneProduct.code, oneProduct.name)
            Next
        End If
    End Sub

    Dim titleForm As New lblTitle("Suppliers' Products")
    Private Sub frmSuppliersProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
    End Sub

    Dim WithEvents frmSupplierSLC As Form = slcSuppliers
    Private Sub btnSelectSupplier_Click(sender As Object, e As EventArgs) Handles btnSelectSupplier.Click
        MASK.now(slcSuppliers, Me)
        slcSuppliers.ShowDialog()
    End Sub
    Private Sub frmSupplierSLC_FormClosed() Handles frmSupplierSLC.FormClosed
        supplier = slcSuppliers.supplier
        If supplier.id <> 0 Then
            txtSupplier.Text = supplier.name
            loadProducts()
        End If
    End Sub

    Dim WithEvents frmProductsSLC As Form = slcProducts
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If supplier.id <> 0 Then
            MASK.now(slcProducts, Me)
            slcProducts.ShowDialog()
        End If
    End Sub
    Private Sub frmProductsSLC_FormClosed() Handles frmProductsSLC.FormClosed
        product = slcProducts.product
        If product.id <> 0 And supplier.id <> 0 Then
            transBegin()
            query_supplierproduct(supplier, product, sqlType.insert)
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Supplier's Product has been saved.")
                loadProducts()
            End If
        End If
    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            transBegin()
            For Each oneProduct As product In lstProducts
                If oneProduct.code.Equals(dgvProducts.SelectedRows(0).Cells("productCode").Value.ToString) Then
                    product = oneProduct
                End If
            Next
            query_supplierproduct(supplier, product, sqlType.delete)
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Supplier's Product has been saved.")
                loadProducts()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class