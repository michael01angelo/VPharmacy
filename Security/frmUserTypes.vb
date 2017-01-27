Public Class frmUserTypes

    Dim lstUserTypes As New List(Of usertype)
    Dim usertype As New usertype

    Private Sub refreshUserTypes()
        dgvUserTypes.Rows.Clear()
        lstUserTypes = getUserTypes()
        For Each oneType As usertype In lstUserTypes
            dgvUserTypes.Rows.Add(oneType.name)
        Next
        dgvUserTypes.ClearSelection()
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
        clearDetails()
        txtName.Text = usertype.name
        If usertype.fm.Contains("products") Then
            chbProducts.Checked = True
        End If
        If usertype.fm.Contains("suppliers") Then
            chbSuppliers.Checked = True
        End If
        If usertype.fm.Contains("categories") Then
            chbCategories.Checked = True
        End If
        If usertype.fm.Contains("miscellaneous") Then
            chbMiscellaneous.Checked = True
        End If
        If usertype.tn.Contains("purchase") Then
            chbPurchase.Checked = True
        End If
        If usertype.tn.Contains("receive") Then
            chbReceive.Checked = True
        End If
        If usertype.tn.Contains("return") Then
            chbReturn.Checked = True
        End If
        If usertype.tn.Contains("stockadjustments") Then
            chbStockAdjustments.Checked = True
        End If
        If usertype.tn.Contains("pointofsales") Then
            chbPointOfSales.Checked = True
        End If
        If usertype.rp.Contains("sales") Then
            chbSales.Checked = True
        End If
        If usertype.rp.Contains("stocks") Then
            chbStocks.Checked = True
        End If
        If usertype.rp.Contains("expirations") Then
            chbExpirations.Checked = True
        End If
        If usertype.sc.Contains("users") Then
            chbUsers.Checked = True
        End If
    End Sub

    Private Sub clearDetails()
        txtName.Clear()
        chbProducts.Checked = False
        chbSuppliers.Checked = False
        chbCategories.Checked = False
        chbMiscellaneous.Checked = False
        chbPurchase.Checked = False
        chbReceive.Checked = False
        chbReturn.Checked = False
        chbStockAdjustments.Checked = False
        chbPointOfSales.Checked = False
        chbSales.Checked = False
        chbStocks.Checked = False
        chbExpirations.Checked = False
        chbUsers.Checked = False
    End Sub

    Private Sub yesEdit()
        txtName.ReadOnly = False
        chbProducts.AutoCheck = True
        chbSuppliers.AutoCheck = True
        chbCategories.AutoCheck = True
        chbMiscellaneous.AutoCheck = True
        chbPurchase.AutoCheck = True
        chbReceive.AutoCheck = True
        chbReturn.AutoCheck = True
        chbStockAdjustments.AutoCheck = True
        chbPointOfSales.AutoCheck = True
        chbSales.AutoCheck = True
        chbStocks.AutoCheck = True
        chbExpirations.AutoCheck = True
        chbUsers.AutoCheck = True
    End Sub
    Private Sub noEdit()
        txtName.ReadOnly = True
        chbProducts.AutoCheck = False
        chbSuppliers.AutoCheck = False
        chbCategories.AutoCheck = False
        chbMiscellaneous.AutoCheck = False
        chbPurchase.AutoCheck = False
        chbReceive.AutoCheck = False
        chbReturn.AutoCheck = False
        chbStockAdjustments.AutoCheck = False
        chbPointOfSales.AutoCheck = False
        chbSales.AutoCheck = False
        chbStocks.AutoCheck = False
        chbExpirations.AutoCheck = False
        chbUsers.AutoCheck = False
    End Sub

    Private Sub frmUserTypes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        refreshUserTypes()
    End Sub

    Dim titleForm As New lblTitle("User Types Maintenance")
    Private Sub frmUserTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvUserTypes.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        typeName.DefaultCellStyle = dgvLeftStyle
        refreshButtons()
        clearDetails()
        noEdit()
    End Sub

    Private Sub dgvUserTypes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUserTypes.SelectionChanged
        If dgvUserTypes.SelectedRows.Count > 0 Then
            For Each oneUserType As usertype In lstUserTypes
                If oneUserType.name.Equals(dgvUserTypes.SelectedRows(0).Cells("typeName").Value.ToString) Then
                    usertype = oneUserType
                End If
            Next
            btnEdit.Enabled = True
            showDetails()
        Else
            btnEdit.Enabled = False
            clearDetails()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        usertype = New usertype
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
            Dim fm As String = String.Empty
            If chbProducts.Checked Then
                fm = "products "
            End If
            If chbSuppliers.Checked Then
                fm += "suppliers "
            End If
            If chbCategories.Checked Then
                fm += "categories "
            End If
            If chbMiscellaneous.Checked Then
                fm += "miscellaneous"
            End If
            Dim tn As String = String.Empty
            If chbPurchase.Checked Then
                tn = "purchase "
            End If
            If chbReceive.Checked Then
                tn += "receive "
            End If
            If chbReturn.Checked Then
                tn += "return "
            End If
            If chbStockAdjustments.Checked Then
                tn += "stockadjustments "
            End If
            If chbPointOfSales.Checked Then
                tn += "pointofsales"
            End If
            Dim rp As String = String.Empty
            If chbSales.Checked Then
                rp = "sales "
            End If
            If chbStocks.Checked Then
                rp += "stocks "
            End If
            If chbExpirations.Checked Then
                rp += "expirations"
            End If
            Dim sc As String = String.Empty
            If chbUsers.Checked Then
                sc = "users"
            End If
            transBegin()
            With usertype
                .name = txtName.Text
                .fm = fm
                .tn = tn
                .rp = rp
                .sc = sc
            End With
            If usertype.id = 0 Then
                user_saveType(usertype, sqlType.insert)
            Else
                user_saveType(usertype, sqlType.update)
            End If
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("User Type has been saved.")
                refreshUserTypes()
                refreshButtons()
                clearDetails()
                noEdit()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearDetails()
        noEdit()
        refreshButtons()
        dgvUserTypes.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class