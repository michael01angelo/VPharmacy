Friend Class slcReceiveProducts

    Friend code As String = String.Empty

    Dim lstPurchasedProducts As New List(Of purchasedproduct)
    Dim lstReceivedProducts As New List(Of receivedproduct)

    Friend output As New stuOutput

    Friend Structure stuOutput
        Friend product As product
        Friend quantity As Integer
        Friend price As Decimal
    End Structure

    Friend Sub refreshProducts()
        dgvProducts.Rows.Clear()
        lstPurchasedProducts = getPurchasedProducts(code)
        lstReceivedProducts = getReceivedProducts(code)
        For Each onePurchasedProduct As purchasedproduct In lstPurchasedProducts
            Dim same As Boolean = False
            For Each oneReceivedProduct As receivedproduct In lstReceivedProducts
                If onePurchasedProduct.productID = oneReceivedProduct.productID Then
                    same = True
                    Exit For
                End If
            Next
            If Not same Then
                dgvProducts.Rows.Add(getProduct(onePurchasedProduct.productID, , ).code, getProduct(onePurchasedProduct.productID, , ).name, onePurchasedProduct.quantity)
            End If
        Next
        dgvProducts.ClearSelection()
    End Sub

    Private Sub slcSuppliers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If code <> String.Empty Then
            refreshProducts()
        End If
    End Sub

    Dim titleForm As New lblTitle("Supplier's Products")
    Private Sub slcSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
        productQuantity.DefaultCellStyle = dgvRightStyle
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            With output
                .product = getProduct(, dgvProducts.SelectedRows(0).Cells("productCode").Value.ToString, )
                .quantity = CInt(nudQuantity.Value)
                .price = nudPrice.Value
            End With
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
        If code <> String.Empty Then
            refreshProducts()
            For Each oneRow As DataGridViewRow In dgvProducts.Rows
                If Not oneRow.Cells("productDescription").Value.ToString.Contains(txtSearch.Text) Then
                    dgvProducts.Rows.Remove(oneRow)
                End If
            Next
        End If
    End Sub

End Class