Public Class frmSuppliers

    Dim lstSuppliers As New List(Of supplier)
    Dim supplier As New supplier

    Private Sub updateCode()
        Dim maxCode As Integer = getMaxCode("suppliers")
        txtCode.Text = maxCode + 1
        While txtCode.TextLength < 5
            txtCode.Text = "0" + txtCode.Text
        End While
    End Sub

    Private Sub refreshSuppliers()
        dgvSuppliers.Rows.Clear()
        lstSuppliers = getSuppliers()
        For Each oneSupplier As supplier In lstSuppliers
            While oneSupplier.code.Length < 5
                oneSupplier.code = "0" + oneSupplier.code
            End While
            dgvSuppliers.Rows.Add(oneSupplier.code, oneSupplier.name, oneSupplier.person, oneSupplier.number)
        Next
        dgvSuppliers.ClearSelection()
    End Sub

    Private Sub showDetails()
        txtCode.Text = supplier.code
        While txtCode.TextLength < 5
            txtCode.Text = "0" + txtCode.Text
        End While
        txtName.Text = supplier.name
        txtAddress.Text = supplier.address
        txtTelephone.Text = supplier.telephone
        txtFax.Text = supplier.fax
        txtPerson.Text = supplier.person
        txtNumber.Text = supplier.number
    End Sub

    Private Sub clearDetails()
        txtCode.Text = String.Empty
        txtName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtTelephone.Text = String.Empty
        txtFax.Text = String.Empty
        txtPerson.Text = String.Empty
        txtNumber.Text = String.Empty
    End Sub

    Private Sub yesEdit()
        txtCode.ReadOnly = False
        txtName.ReadOnly = False
        txtAddress.ReadOnly = False
        txtTelephone.ReadOnly = False
        txtFax.ReadOnly = False
        txtPerson.ReadOnly = False
        txtNumber.ReadOnly = False
    End Sub

    Private Sub noEdit()
        txtCode.ReadOnly = True
        txtName.ReadOnly = True
        txtAddress.ReadOnly = True
        txtTelephone.ReadOnly = True
        txtFax.ReadOnly = True
        txtPerson.ReadOnly = True
        txtNumber.ReadOnly = True
    End Sub

    Private Sub refreshButtons()
        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        Me.CancelButton = btnClose
    End Sub

    Private Sub frmSuppliers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshSuppliers()
    End Sub

    Dim titleForm As New lblTitle("Suppliers Details Maintenance")
    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvSuppliers.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        supplierCode.DefaultCellStyle = dgvRightStyle
        supplierName.DefaultCellStyle = dgvLeftStyle
        supplierPerson.DefaultCellStyle = dgvLeftStyle
        supplierNumber.DefaultCellStyle = dgvRightStyle
        refreshButtons()
    End Sub

    Private Sub dgvSuppliers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSuppliers.SelectionChanged
        If dgvSuppliers.SelectedRows.Count > 0 Then
            For Each oneSupplier As supplier In lstSuppliers
                If CInt(oneSupplier.code) = CInt(dgvSuppliers.SelectedRows(0).Cells("supplierCode").Value) Then
                    supplier = oneSupplier
                    Exit For
                Else
                    supplier = New supplier
                End If
            Next
            btnEdit.Enabled = True
            showDetails()
        Else
            clearDetails()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        supplier = New supplier
        clearDetails()
        yesEdit()
        updateCode()
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
            With supplier
                .code = txtCode.Text
                .name = txtName.Text
                .address = txtAddress.Text
                .telephone = txtTelephone.Text
                .fax = txtFax.Text
                .person = txtPerson.Text
                .number = txtNumber.Text
            End With
            If supplier.id = 0 Then
                query_supplier(supplier, sqlType.insert)
            Else
                query_supplier(supplier, sqlType.update)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("Supplier Details has been saved.")
                refreshSuppliers()
                refreshButtons()
                clearDetails()
                noEdit()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearDetails()
        refreshButtons()
        noEdit()
        dgvSuppliers.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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