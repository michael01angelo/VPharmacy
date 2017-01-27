Public Class frmProducts

    Dim lstCategories As New List(Of category)
    Dim category As New category
    Dim lstSubCategories As New List(Of subcategory)
    Dim subcategory As New subcategory
    Dim lstProducts As New List(Of product)
    Dim product As New product
    Dim lstUnits As List(Of unit) = getUnits()
    Dim unit As New unit

    Dim editable As Boolean = False

    Private Sub refreshCategories()
        With cbxCategories.Items
            .Clear()
            .Add("All")
        End With
        lstCategories = getCategories()
        For Each oneCategory As category In lstCategories
            cbxCategories.Items.Add(oneCategory.name)
        Next
        cbxCategories.SelectedIndex = 0
    End Sub

    Private Sub refreshSubCategories()
        lstSubCategories = getSubCategories(category)
        With cbxSubCategories.Items
            .Clear()
            .Add("All")
        End With
        For Each oneSubCategory As subcategory In lstSubCategories
            cbxSubCategories.Items.Add(oneSubCategory.name)
        Next
        cbxSubCategories.SelectedIndex = 0
    End Sub

    Private Sub refreshProducts()
        dgvProducts.Rows.Clear()
        lstProducts = getProductsByCategory(category, subcategory)
        For Each oneProduct As product In lstProducts
            dgvProducts.Rows.Add(oneProduct.code, oneProduct.name, oneProduct.generic)
        Next
        dgvProducts.ClearSelection()
    End Sub

    Private Sub refreshUnits()
        lstUnits = getUnits()
        cbxUnits.Items.Clear()
        For Each oneUnit As unit In lstUnits
            cbxUnits.Items.Add(oneUnit.name)
        Next
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
        For Each oneUnit As unit In lstUnits
            If oneUnit.id = product.unitID Then
                unit = oneUnit
            End If
        Next
        txtCode.Text = product.code
        txtName.Text = product.name
        txtGeneric.Text = product.generic
        If unit.id = 0 Then
            cbxUnits.SelectedIndex = -1
        Else
            cbxUnits.SelectedIndex = cbxUnits.FindStringExact(unit.name)
        End If
        nudPrice.Value = product.price
        nudMarkUp.Value = product.markup
        nudROP.Value = product.rop
        If product.discountable Then
            chbDiscountable.Checked = True
        Else
            chbDiscountable.Checked = False
        End If
        If product.vatable Then
            chbVatable.Checked = True
        Else
            chbVatable.Checked = False
        End If
        updateSellingPrice()
    End Sub

    Private Sub clearDetails()
        txtCode.Clear()
        txtName.Clear()
        txtGeneric.Clear()
        nudPrice.Value = CDec(0)
        nudMarkUp.Value = CDec(0)
        nudROP.Value = CDec(0)
        chbDiscountable.Checked = False
        chbVatable.Checked = False
        updateSellingPrice()
    End Sub

    Private Sub yesEdit()
        txtCode.ReadOnly = False
        txtName.ReadOnly = False
        txtGeneric.ReadOnly = False
        nudPrice.ReadOnly = False
        nudMarkUp.ReadOnly = False
        nudROP.ReadOnly = False
        editable = True
    End Sub
    Private Sub noEdit()
        txtCode.ReadOnly = True
        txtName.ReadOnly = True
        txtGeneric.ReadOnly = True
        nudPrice.ReadOnly = True
        nudMarkUp.ReadOnly = True
        nudROP.ReadOnly = True
        editable = False
    End Sub

    Private Sub updateSellingPrice()
        Dim vatPercent As Decimal = getVAT() / 100
        Dim sellingprice As New Decimal
        sellingprice = nudPrice.Value + (nudPrice.Value * (nudMarkUp.Value / 100))
        If chbVatable.Checked Then
            sellingprice = sellingprice + (sellingprice * vatPercent)
        End If
        txtSellingPrice.Text = FormatNumber(sellingprice, 2)
    End Sub

    Private Sub frmProducts_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshCategories()
        refreshUnits()
        Me.ActiveControl = Nothing
        clearDetails()
    End Sub

    Dim titleForm As New lblTitle("Products Details Maintenance")
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvProducts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        productCode.DefaultCellStyle = dgvRightStyle
        productDescription.DefaultCellStyle = dgvLeftStyle
        productGeneric.DefaultCellStyle = dgvLeftStyle
        refreshButtons()
        noEdit()
        clearDetails()
    End Sub

    Private Sub cbxCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategories.SelectedIndexChanged
        For Each oneCategory As category In lstCategories
            If oneCategory.name.Equals(cbxCategories.SelectedItem) Then
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
            If oneSubCategory.name.Equals(cbxSubCategories.SelectedItem) Then
                subcategory = oneSubCategory
                Exit For
            Else
                subcategory = New subcategory
            End If
        Next
        If Not editable Then
            refreshProducts()
        Else
            nudMarkUp.Value = subcategory.markup
        End If
    End Sub

    Private Sub dgvProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducts.SelectionChanged
        If dgvProducts.SelectedRows.Count > 0 Then
            If Not editable Then
                For Each oneProduct As product In lstProducts
                    If oneProduct.code.Equals(dgvProducts.SelectedRows(0).Cells("productCode").Value.ToString) Then
                        product = oneProduct
                        Exit For
                    End If
                Next
                showDetails()
            End If
            btnEdit.Enabled = True
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub cbxUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUnits.SelectedIndexChanged
        If editable Then
            For Each oneUnit As unit In lstUnits
                If oneUnit.name.Equals(cbxUnits.SelectedItem) Then
                    unit = oneUnit
                End If
            Next
        Else
            cbxUnits.SelectedIndex = cbxUnits.FindStringExact(unit.name)
        End If
    End Sub

    Private Sub chbDiscountable_CheckedChanged(sender As Object, e As EventArgs) Handles chbDiscountable.CheckedChanged
        If Not editable Then
            chbDiscountable.Checked = product.discountable
        End If
    End Sub

    Private Sub nudMarkUp_ValueChanged(sender As Object, e As EventArgs) Handles nudMarkUp.ValueChanged
        updateSellingPrice()
    End Sub
    Private Sub nudPrice_ValueChanged(sender As Object, e As EventArgs) Handles nudPrice.ValueChanged
        updateSellingPrice()
    End Sub

    Private Sub chbVatable_CheckedChanged(sender As Object, e As EventArgs) Handles chbVatable.CheckedChanged
        If Not editable Then
            chbVatable.Checked = product.vatable
        Else
            updateSellingPrice()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        product = New product
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
        If txtName.Text <> String.Empty Then
            transBegin()
            With product
                .code = txtCode.Text
                .name = txtName.Text
                .subcategory = subcategory.id
                .generic = txtGeneric.Text
                .unitID = unit.id
                .discountable = chbDiscountable.Checked
                .vatable = chbVatable.Checked
                .price = nudPrice.Value
                .markup = nudMarkUp.Value
                .rop = nudROP.Value
            End With
            If product.id = 0 Then
                product.stock = 0
                query_product(product, sqlType.insert)
            Else
                product.stock = product.stock
                query_product(product, sqlType.update)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                If product.id = 0 Then
                    product = getProduct(, txtCode.Text, )
                End If
                frmMain.showQueryResult("Product Details has been saved.")
                refreshProducts()
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not editable Then
            refreshProducts()
            For Each oneRow As DataGridViewRow In dgvProducts.Rows
                If Not (oneRow.Cells("productCode").Value.ToString.Contains(txtSearch.Text) Or oneRow.Cells("productDescription").Value.ToString.Contains(txtSearch.Text) Or oneRow.Cells("productGeneric").Value.ToString.Contains(txtSearch.Text)) Then
                    dgvProducts.Rows.Remove(oneRow)
                End If
            Next
        End If
    End Sub

End Class