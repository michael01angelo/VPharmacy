Friend Class slcPurchasedOrders

    Dim lstPurchasedProducts As New List(Of purchasedproduct)
    Friend purchasedproduct As New purchasedproduct

    Friend Sub refreshOrders()
        dgvOrders.Rows.Clear()
        lstPurchasedProducts = getPurchaseOrders()
        For Each onePurchasedProducts As purchasedproduct In lstPurchasedProducts
            While onePurchasedProducts.code.Length < 5
                onePurchasedProducts.code = "0" + onePurchasedProducts.code
            End While
            dgvOrders.Rows.Add(onePurchasedProducts.code, onePurchasedProducts.eventdate, getSupplier(onePurchasedProducts.supplierID, , ).name)
        Next
        dgvOrders.ClearSelection()
    End Sub

    Private Sub slcSuppliers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshOrders()
    End Sub

    Dim titleForm As New lblTitle("Select Order")
    Private Sub slcSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvOrders.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        orderCode.DefaultCellStyle = dgvRightStyle
        orderDate.DefaultCellStyle = dgvLeftStyle
        orderSupplier.DefaultCellStyle = dgvLeftStyle
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If dgvOrders.SelectedRows.Count > 0 Then
            For Each onePurchasedProducts As purchasedproduct In lstPurchasedProducts
                If CInt(onePurchasedProducts.code) = CInt(dgvOrders.SelectedRows(0).Cells("orderCode").Value.ToString) Then
                    purchasedproduct = onePurchasedProducts
                End If
            Next
        Else
            purchasedproduct = New purchasedproduct
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        purchasedproduct = New purchasedproduct
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        refreshOrders()
        For Each oneRow As DataGridViewRow In dgvOrders.Rows
            If Not oneRow.Cells("orderSupplier").Value.ToString.Contains(txtSearch.Text) Then
                dgvOrders.Rows.Remove(oneRow)
            End If
        Next
    End Sub

End Class