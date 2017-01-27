Friend Class frmSubCategories

    Dim lstCategories As New List(Of category)
    Dim category As New category
    Dim lstSubCategories As New List(Of subcategory)
    Dim subcategory As New subcategory

    Private Sub refreshDataGrid()
        lstSubCategories = getSubCategories(category)
        dgvSubCategories.Rows.Clear()
        For Each oneSubCategory As subcategory In lstSubCategories
            dgvSubCategories.Rows.Add(oneSubCategory.name, oneSubCategory.markup)
        Next
        dgvSubCategories.ClearSelection()
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
        txtName.Text = subcategory.name
        nudMarkUp.Value = subcategory.markup
    End Sub
    Private Sub clearDetails()
        txtName.Clear()
        nudMarkUp.Value = CDec(0)
    End Sub
    Private Sub yesEdit()
        txtName.ReadOnly = False
        nudMarkUp.ReadOnly = False
    End Sub
    Private Sub noEdit()
        txtName.ReadOnly = True
        nudMarkUp.ReadOnly = True
    End Sub

    Private Sub frmSubCategories_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cbxCategories.Items.Clear()
        lstCategories = getCategories()
        For Each oneCategory As category In lstCategories
            cbxCategories.Items.Add(oneCategory.name)
        Next
        refreshDataGrid()
        Me.ActiveControl = Nothing
    End Sub

    Dim titleForm As New lblTitle("Sub Categories Maintenance")
    Private Sub frmSubCategories_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvSubCategories.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        subcategoryName.DefaultCellStyle = dgvLeftStyle
        subcategoryMarkUp.DefaultCellStyle = dgvRightStyle
        refreshButtons()
        clearDetails()
        noEdit()
    End Sub

    Private Sub cbxCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategories.SelectedIndexChanged
        If cbxCategories.SelectedIndex = -1 Then
            category = New category
            refreshDataGrid()
        Else
            For Each oneCategory As category In lstCategories
                If oneCategory.name.Equals(cbxCategories.SelectedItem.ToString) Then
                    category = oneCategory
                End If
            Next
            refreshDataGrid()
        End If
    End Sub

    Private Sub dgvSubCategories_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSubCategories.SelectionChanged
        If dgvSubCategories.SelectedRows.Count > 0 Then
            For Each oneSubCategory As subcategory In lstSubCategories
                If oneSubCategory.name.Equals(dgvSubCategories.SelectedRows(0).Cells("subcategoryName").Value.ToString) Then
                    subcategory = oneSubCategory
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
        subcategory = New subcategory
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
            With subcategory
                .categoryID = category.id
                .name = txtName.Text
                .markup = nudMarkUp.Value
            End With
            If subcategory.id = 0 Then
                query_subcategory(subcategory, sqlType.insert)
            Else
                query_subcategory(subcategory, sqlType.update)
                query_setMarkUp(subcategory)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Sub Category has been saved.")
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
        dgvSubCategories.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class