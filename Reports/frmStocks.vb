Friend Class frmStocks

    Dim lstProducts As New List(Of product)
    Dim lstSuppliers As New List(Of supplier)
    Dim supplier As New supplier

    Private Sub refreshItems()
        dgvItems.Rows.Clear()
        If supplier.id <> 0 Then
            lstProducts = getSuppliersProducts(supplier)
        Else
            lstProducts = getProducts()
        End If
        For Each oneProduct As product In lstProducts
            If chbLowCount.Checked Then
                If oneProduct.rop > 0 AndAlso oneProduct.stock <= oneProduct.rop Then
                    dgvItems.Rows.Add(oneProduct.code, oneProduct.name, oneProduct.rop, oneProduct.stock)
                End If
            Else
                dgvItems.Rows.Add(oneProduct.code, oneProduct.name, oneProduct.rop, oneProduct.stock)
            End If
        Next
        dgvItems.ClearSelection()
    End Sub

    Private Sub refreshSuppliers()
        With dgvSuppliers.Rows
            .Clear()
            .Add("00000", "All Suppliers")
        End With
        lstSuppliers = getSuppliers()
        For Each oneSupplier As supplier In lstSuppliers
            dgvSuppliers.Rows.Add(oneSupplier.code, oneSupplier.name)
        Next
        dgvSuppliers.ClearSelection()
        refreshItems()
    End Sub

    Private Sub frmStocks_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshSuppliers()
    End Sub

    Dim titleForm As New lblTitle("Stock Report")
    Private Sub frmStocks_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvItems.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        itemCode.DefaultCellStyle = dgvRightStyle
        itemDescription.DefaultCellStyle = dgvLeftStyle
        itemROP.DefaultCellStyle = dgvRightStyle
        itemStock.DefaultCellStyle = dgvRightStyle
        dgvSuppliers.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        supplierCode.DefaultCellStyle = dgvRightStyle
        supplierName.DefaultCellStyle = dgvLeftStyle
    End Sub

    Private Sub dgvSuppliers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSuppliers.SelectionChanged
        supplier = New supplier
        If dgvSuppliers.SelectedRows.Count > 0 Then
            For Each oneSupplier As supplier In lstSuppliers
                If CInt(oneSupplier.code) = CInt(dgvSuppliers.SelectedRows(0).Cells("supplierCode").Value.ToString) Then
                    supplier = oneSupplier
                    Exit For
                End If
            Next
        End If
        refreshItems()
    End Sub

    Private Sub dgvItems_SelectionChanged(sender As Object, e As EventArgs) Handles dgvItems.SelectionChanged
        If dgvItems.SelectedRows.Count > 0 And supplier.id <> 0 Then
            nudQuantity.ReadOnly = False
            btnOrderProduct.Enabled = True
        Else
            nudQuantity.ReadOnly = True
            btnOrderProduct.Enabled = False
        End If
    End Sub

    Private Sub chbLowCount_CheckedChanged(sender As Object, e As EventArgs) Handles chbLowCount.CheckedChanged
        refreshItems()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearchSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupplier.TextChanged
        refreshSuppliers()
        For Each oneRow As DataGridViewRow In dgvSuppliers.Rows
            If Not oneRow.Cells("supplierName").Value.ToString.Contains(txtSearchSupplier.Text) Then
                dgvSuppliers.Rows.Remove(oneRow)
            End If
        Next
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        refreshItems()
        For Each oneRow As DataGridViewRow In dgvItems.Rows
            If Not oneRow.Cells("productDescription").Value.ToString.Contains(txtSearchProduct.Text) Then
                dgvSuppliers.Rows.Remove(oneRow)
            End If
        Next
    End Sub

    Private Sub btnOrderProduct_Click(sender As Object, e As EventArgs) Handles btnOrderProduct.Click
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
            .dgvProducts.Rows.Add(dgvItems.SelectedRows(0).Cells("itemCode").Value.ToString, dgvItems.SelectedRows(0).Cells("itemDescription").Value.ToString, nudQuantity.Value)
        End With
    End Sub

End Class