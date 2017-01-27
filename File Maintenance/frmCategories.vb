Friend Class frmCategories

    Dim lstCategories As New List(Of category)
    Dim category As New category

    Private Sub refreshDataGrid()
        dgvCategories.Rows.Clear()
        lstCategories = getCategories()
        For Each oneCategory As category In lstCategories
            dgvCategories.Rows.Add(oneCategory.name)
        Next
        dgvCategories.ClearSelection()
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
        txtName.Text = category.name
    End Sub
    Private Sub clearDetails()
        txtName.Clear()
    End Sub
    Private Sub yesEdit()
        txtName.ReadOnly = False
    End Sub
    Private Sub noEdit()
        txtName.ReadOnly = True
    End Sub

    Private Sub frmCategories_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshDataGrid()
    End Sub

    Dim titleForm As New lblTitle("Categories Maintenance")
    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvCategories.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        categoryName.DefaultCellStyle = dgvLeftStyle
        refreshButtons()
        clearDetails()
        noEdit()
        Me.ActiveControl = Nothing
    End Sub

    Private Sub dgvCategories_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCategories.SelectionChanged
        If dgvCategories.SelectedRows.Count > 0 Then
            For Each oneCategory As category In lstCategories
                If oneCategory.name.Equals(dgvCategories.SelectedRows(0).Cells("categoryName").Value.ToString) Then
                    category = oneCategory
                End If
            Next
            showDetails()
            btnEdit.Enabled = True
        Else
            btnEdit.Enabled = False
            clearDetails()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        category = New category
        yesEdit()
        clearDetails()
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        Me.CancelButton = btnCancel
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        yesEdit()
        showDetails()
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
            category.name = txtName.Text
            If category.id = 0 Then
                query_category(category, sqlType.insert)
            Else
                query_category(category, sqlType.update)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Category has been saved.")
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
        dgvCategories.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class