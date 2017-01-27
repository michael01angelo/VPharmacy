Friend Class frmUnits

    Dim lstUnits As New List(Of unit)
    Dim unit As New unit

    Private Sub refreshDataGrid()
        dgvUnits.Rows.Clear()
        lstUnits = getUnits()
        For Each oneUnit As unit In lstUnits
            dgvUnits.Rows.Add(oneUnit.name)
        Next
        dgvUnits.ClearSelection()
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
        txtName.Text = unit.name
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

    Private Sub frmUnits_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshDataGrid()
    End Sub

    Dim titleForm As New lblTitle("Units Maintenance")
    Private Sub frmUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvUnits.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        value.DefaultCellStyle = dgvLeftStyle
        refreshButtons()
        clearDetails()
        Me.ActiveControl = Nothing
    End Sub

    Private Sub dgvUnits_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUnits.SelectionChanged
        If dgvUnits.SelectedRows.Count > 0 Then
            For Each oneUnit As unit In lstUnits
                If oneUnit.name.Equals(dgvUnits.SelectedRows(0).Cells("value").Value.ToString) Then
                    unit = oneUnit
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
        unit = New unit
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
            unit.name = txtName.Text
            If unit.id = 0 Then
                query_unit(unit, sqlType.insert)
            Else
                query_unit(unit, sqlType.update)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Unit has been saved.")
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
        dgvUnits.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class