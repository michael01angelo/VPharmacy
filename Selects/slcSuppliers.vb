Public Class slcSuppliers

    Dim lstSuppliers As New List(Of supplier)
    Friend Shared supplier As New supplier

    Friend Sub refreshSuppliers()
        dgvSuppliers.Rows.Clear()
        lstSuppliers = getSuppliers()
        For Each oneSupplier As supplier In lstSuppliers
            dgvSuppliers.Rows.Add(oneSupplier.code, oneSupplier.name)
        Next
        dgvSuppliers.ClearSelection()
    End Sub

    Private Sub slcSuppliers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshSuppliers()
    End Sub

    Dim titleForm As New lblTitle("Select Supplier")
    Private Sub slcSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvSuppliers.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        supplierCode.DefaultCellStyle = dgvRightStyle
        supplierName.DefaultCellStyle = dgvLeftStyle
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If dgvSuppliers.SelectedRows.Count > 0 Then
            For Each oneSupplier As supplier In lstSuppliers
                If oneSupplier.code.Equals(dgvSuppliers.SelectedRows(0).Cells("supplierCode").Value.ToString) Then
                    supplier = oneSupplier
                    Exit For
                End If
            Next
        Else
            supplier = New supplier
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        supplier = New supplier
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        refreshSuppliers()
        For Each oneRow As DataGridViewRow In dgvSuppliers.Rows
            If Not oneRow.Cells("supplierName").Value.ToString.Contains(txtSearch.Text) Then
                dgvSuppliers.Rows.Remove(oneRow)
            End If
        Next
    End Sub

End Class