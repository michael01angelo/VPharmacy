Public Class frmExpiry

    Dim lstProducts As New List(Of product)
    Dim product As New product
    Dim lstExpiries As New List(Of expiry)
    Dim expiry As New expiry

    Dim editable As Boolean = False

    Private Sub refreshData()
        lstProducts = getProducts()
        lstExpiries = getExpiries()
        dgvProducts.Rows.Clear()
        For Each oneProduct As product In lstProducts
            For Each oneExpiry As expiry In lstExpiries
                If oneExpiry.productID = oneProduct.id Then
                    dgvProducts.Rows.Add(oneProduct.code, oneProduct.name, oneExpiry.batch, oneExpiry.expdate.ToString("yyyy-MM-dd"))
                End If
            Next
        Next
        dgvProducts.ClearSelection()
    End Sub

    Private Sub setProduct()
        txtCode.Text = product.code
        txtDescription.Text = product.name
    End Sub

    Private Sub refreshButtons()
        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        Me.CancelButton = btnClose
    End Sub

    Private Sub showDetails()
        txtCode.Text = product.code
        txtDescription.Text = product.name
        txtBatch.Text = expiry.batch
        dtpDate.Value = expiry.expdate
    End Sub
    Private Sub clearDetails()
        txtCode.Clear()
        txtDescription.Clear()
        txtBatch.Clear()
        dtpDate.Value = Date.Today
    End Sub
    Private Sub yesEdit()
        txtBatch.ReadOnly = False
        editable = True
    End Sub
    Private Sub noEdit()
        txtBatch.ReadOnly = True
        editable = False
    End Sub

    Private Sub frmExpiry_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshData()
    End Sub

    Dim titleForm As New lblTitle("Products Expiration Maintenance")
    Private Sub frmExpiry_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
        productBatch.DefaultCellStyle = dgvRightStyle
        productExpiration.DefaultCellStyle = dgvRightStyle
        refreshButtons()
        noEdit()
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        If dgvProducts.SelectedRows.Count > 0 Then
            For Each oneProduct As product In lstProducts
                For Each oneExpiry As expiry In lstExpiries
                    If oneProduct.code.Equals(dgvProducts.SelectedRows(0).Cells("productCode").Value.ToString) And oneExpiry.productID = oneProduct.id Then
                        product = oneProduct
                        expiry = oneExpiry
                    End If
                Next
            Next
            showDetails()
            btnEdit.Enabled = True
        Else
            clearDetails()
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If Not editable Then
            If expiry.id <> 0 Then
                dtpDate.Value = expiry.expdate
            Else
                dtpDate.Value = Date.Today
            End If
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        expiry = New expiry
        clearDetails()
        yesEdit()
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        Me.CancelButton = btnCancel
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        showDetails()
        yesEdit()
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        Me.CancelButton = btnCancel
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If product.id <> 0 And txtBatch.Text <> String.Empty Then
            transBegin()
            With expiry
                .productID = product.id
                .batch = txtBatch.Text
                .expdate = dtpDate.Value
            End With
            If expiry.id = 0 Then
                query_expiry(expiry, sqlType.insert)
            Else
                query_expiry(expiry, sqlType.update)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Product Expiration has been saved.")
                refreshData()
                refreshButtons()
                clearDetails()
                noEdit()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        refreshButtons()
        clearDetails()
        noEdit()
        dgvProducts.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChooseProduct_Click(sender As Object, e As EventArgs) Handles btnChooseProduct.Click
        If editable Then
            MASK.now(slcProducts, Me)
            slcProducts.ShowDialog()
        End If
    End Sub
    Dim WithEvents frmProductsSLC As Form = slcProducts
    Private Sub frmProductsSLC_FormClosed() Handles frmProductsSLC.FormClosed
        product = slcProducts.product
        setProduct()
    End Sub

End Class