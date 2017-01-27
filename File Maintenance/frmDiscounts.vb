Friend Class frmDiscounts

    Dim lstDiscounts As New List(Of discount)
    Dim discount As New discount

    Private Sub refreshDataGrid()
        dgvDiscounts.Rows.Clear()
        lstDiscounts = getDiscounts()
        For Each oneDiscount As discount In lstDiscounts
            dgvDiscounts.Rows.Add(oneDiscount.description, oneDiscount.value)
        Next
        dgvDiscounts.ClearSelection()
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
        txtDescription.Text = discount.description
        nudDiscount.Value = discount.value
    End Sub
    Private Sub clearDetails()
        txtDescription.Clear()
        nudDiscount.Value = CDec(0)
    End Sub
    Private Sub yesEdit()
        txtDescription.ReadOnly = False
        nudDiscount.ReadOnly = False
    End Sub
    Private Sub noEdit()
        txtDescription.ReadOnly = True
        nudDiscount.ReadOnly = True
    End Sub

    Private Sub frmSubCategories_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshDataGrid()
    End Sub

    Dim titleForm As New lblTitle("Discounts Maintenance")
    Private Sub frmSubCategories_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvDiscounts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        discountName.DefaultCellStyle = dgvLeftStyle
        discountValue.DefaultCellStyle = dgvRightStyle
        refreshButtons()
        clearDetails()
        noEdit()
        Me.ActiveControl = Nothing
    End Sub

    Private Sub dgvDiscounts_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDiscounts.SelectionChanged
        If dgvDiscounts.SelectedRows.Count > 0 Then
            For Each oneDiscount As discount In lstDiscounts
                If oneDiscount.description.Equals(dgvDiscounts.SelectedRows(0).Cells("discountName").Value.ToString) Then
                    discount = oneDiscount
                End If
            Next
            showDetails()
            btnEdit.Enabled = True
        Else
            clearDetails()
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        discount = New discount
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
        If txtDescription.Text <> String.Empty Then
            transBegin()
            With discount
                .description = txtDescription.Text
                .value = nudDiscount.Value
            End With
            If discount.id = 0 Then
                query_discount(discount, sqlType.insert)
            Else
                query_discount(discount, sqlType.update)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Discounts has been saved.")
                refreshDataGrid()
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
        dgvDiscounts.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class