Friend Class frmExpiration

    Dim lstProducts As New List(Of product)
    Dim lstExpiries As New List(Of expiry)
    Dim lstCategories As New List(Of category)
    Dim category As New category
    Dim lstSubCategories As New List(Of subcategory)
    Dim subcategory As New subcategory

    Private Sub refreshItems()
        dgvItems.Rows.Clear()
        lstProducts = getProductsByCategory(category, subcategory)
        lstExpiries = getExpiries()
        For Each oneProduct As product In lstProducts
            For Each oneExpiry As expiry In lstExpiries
                If oneExpiry.productID = oneProduct.id Then
                    If chbNearlyExpired.Checked Then
                        If oneExpiry.expdate.AddMonths(-1) <= Date.Today Then
                            dgvItems.Rows.Add(oneProduct.code, oneProduct.name, oneExpiry.batch, oneExpiry.expdate.ToString("yyyy-MM-dd"))
                        End If
                    Else
                        dgvItems.Rows.Add(oneProduct.code, oneProduct.name, oneExpiry.batch, oneExpiry.expdate.ToString("yyyy-MM-dd"))
                    End If
                End If
            Next
        Next
        dgvItems.ClearSelection()
    End Sub

    Private Sub refreshCategories()
        cbxCategories.Items.Clear()
        lstCategories = getCategories()
        cbxCategories.Items.Add("All")
        For Each oneCategory As category In lstCategories
            cbxCategories.Items.Add(oneCategory.name)
        Next
        cbxCategories.SelectedIndex = 0
        category = New category
        refreshSubCategories()
    End Sub
    Private Sub refreshSubCategories()
        cbxSubCategories.Items.Clear()
        lstSubCategories = getSubCategories(category)
        cbxSubCategories.Items.Add("All")
        For Each onesubCategory As subcategory In lstSubCategories
            cbxSubCategories.Items.Add(onesubCategory.name)
        Next
        cbxSubCategories.SelectedIndex = 0
        subcategory = New subcategory
    End Sub

    Private Sub frmStocks_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshCategories()
    End Sub

    Dim titleForm As New lblTitle("Expiration Report")
    Private Sub frmStocks_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvItems.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        itemCode.DefaultCellStyle = dgvRightStyle
        itemDescription.DefaultCellStyle = dgvLeftStyle
        itemBatch.DefaultCellStyle = dgvRightStyle
        itemExpiry.DefaultCellStyle = dgvRightStyle
        lblDateTime.Text = Date.Today.ToString("yyyy-MM-dd")
    End Sub

    Private Sub cbxCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategories.SelectedIndexChanged
        For Each oneCategory As category In lstCategories
            If oneCategory.name.Equals(cbxCategories.SelectedItem.ToString) Then
                category = oneCategory
                Exit For
            Else
                category = New category
            End If
        Next
        refreshSubCategories()
    End Sub

    Private Sub cbxSubCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSubCategories.SelectedIndexChanged
        For Each oneSubCategory As subcategory In lstSubCategories
            If oneSubCategory.name.Equals(cbxSubCategories.SelectedItem.ToString) Then
                subcategory = oneSubCategory
                Exit For
            Else
                subcategory = New subcategory
            End If
        Next
        refreshItems()
    End Sub

    Private Sub chbLowCount_CheckedChanged(sender As Object, e As EventArgs) Handles chbNearlyExpired.CheckedChanged
        refreshItems()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class