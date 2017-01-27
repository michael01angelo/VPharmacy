Public Class slcProducts

    Dim lstProducts As New List(Of product)
    Friend Shared product As New product

    Friend Sub refreshProducts()
        dgvProducts.Rows.Clear()
        lstProducts = getProducts()
        For Each oneProduct As product In lstProducts
            dgvProducts.Rows.Add(oneProduct.code, oneProduct.name)
        Next
        dgvProducts.ClearSelection()
    End Sub

    Private Sub slcSuppliers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshProducts()
    End Sub

    Dim titleForm As New lblTitle("Products")
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
                    product = oneProduct
                    Exit For
                End If
            Next
        Else
            product = New product
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        product = New product
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        refreshProducts()
    End Sub

End Class