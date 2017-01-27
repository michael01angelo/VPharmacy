Friend Class slcReturnProducts

    Friend Shared supplier As New supplier

    Dim lstProducts As New List(Of product)

    Friend Shared output As New stuOutput

    Friend Structure stuOutput
        Friend product As product
        Friend quantity As Integer
        Friend remarks As String
    End Structure

    Friend Sub refreshProducts()
        dgvProducts.Rows.Clear()
        lstProducts = getSuppliersProducts(supplier)
        For Each oneProduct As product In lstProducts
            dgvProducts.Rows.Add(oneProduct.code, oneProduct.name)
        Next
        dgvProducts.ClearSelection()
    End Sub

    Private Sub slcSuppliers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If supplier.id <> 0 Then
            refreshProducts()
        End If
    End Sub

    Dim titleForm As New lblTitle("Supplier's Products")
    Private Sub slcSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            For Each oneProduct As product In lstProducts
                If oneProduct.code.Equals(dgvProducts.SelectedRows(0).Cells("productCode").Value.ToString) Then
                    With output
                        .product = oneProduct
                        .quantity = CInt(nudQuantity.Value)
                        .remarks = txtRemarks.Text
                    End With
                    Exit For
                End If
            Next
        Else
            output = New stuOutput
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        output = New stuOutput
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If supplier.id <> 0 Then
            refreshProducts()
            For Each oneRow As DataGridViewRow In dgvProducts.Rows
                If Not oneRow.Cells("productDescription").Value.ToString.Contains(txtSearch.Text) Then
                    dgvProducts.Rows.Remove(oneRow)
                End If
            Next
        End If
    End Sub

End Class