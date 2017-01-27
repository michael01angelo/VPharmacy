Friend Class frmStockAdjustment

    Dim lstAdjustments As New List(Of adjustment)
    Dim adjustment As New adjustment
    Dim product As New product

    Dim editable As Boolean = False

    Private Sub updateCode()
        Dim maxCode As Integer = getMaxCode("adjustments")
        txtCode.Text = maxCode + 1
        While txtCode.TextLength < 5
            txtCode.Text = "0" + txtCode.Text
        End While
    End Sub

    Private Sub refreshAdjustments()
        dgvAdjustments.Rows.Clear()
        lstAdjustments = getAdjustments()
        For Each oneAdjustment As adjustment In lstAdjustments
            While oneAdjustment.code.Length < 5
                oneAdjustment.code = "0" + oneAdjustment.code
            End While
            dgvAdjustments.Rows.Add(oneAdjustment.code, oneAdjustment.type, getProduct(oneAdjustment.productID, , ).name, oneAdjustment.variance, oneAdjustment.eventdate.ToString("yyyy-MM-dd"))
        Next
        dgvAdjustments.ClearSelection()
    End Sub

    Private Sub setItem()
        txtProductCode.Text = product.code
        txtProductDescription.Text = product.name
        txtItemStock.Text = product.stock
    End Sub

    Private Sub showDetails()
        txtCode.Text = adjustment.code
        dtpDate.Value = adjustment.eventdate
        product = getProduct(adjustment.productID)
        setItem()
        For Each oneType As String In cbxTypes.Items
            If String.Compare(oneType, adjustment.type, True) = 0 Then
                cbxTypes.SelectedItem = oneType
                Exit For
            End If
        Next
        nudVariance.Value = CDec(adjustment.variance)
        txtRemarks.Text = adjustment.remarks
    End Sub

    Private Sub clearDetails()
        txtCode.Text = String.Empty
        dtpDate.Value = Date.Today
        txtProductCode.Text = String.Empty
        txtProductDescription.Text = String.Empty
        txtItemStock.Text = String.Empty
        cbxTypes.SelectedItem = Nothing
        nudVariance.Value = CDec(0)
        txtRemarks.Text = String.Empty
    End Sub

    Private Sub yesEdit()
        nudVariance.ReadOnly = False
        txtRemarks.ReadOnly = False
        editable = True
    End Sub
    Private Sub noEdit()
        nudVariance.ReadOnly = True
        txtRemarks.ReadOnly = True
        editable = False
    End Sub

    Private Sub refreshButtons()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        Me.CancelButton = btnCancel
    End Sub

    Private Sub frmStockAdjustment_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        refreshAdjustments()
    End Sub

    Dim titleForm As New lblTitle("Stock Adjustments")
    Private Sub frmStockAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvAdjustments.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        adjustmentCode.DefaultCellStyle = dgvRightStyle
        adjustmentType.DefaultCellStyle = dgvLeftStyle
        adjustmentProductName.DefaultCellStyle = dgvLeftStyle
        adjustmentVariance.DefaultCellStyle = dgvRightStyle
        adjustmentDate.DefaultCellStyle = dgvRightStyle
        refreshButtons()
        clearDetails()
    End Sub

    Private Sub dgvAdjustments_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAdjustments.SelectionChanged
        If dgvAdjustments.SelectedRows.Count > 0 Then
            For Each oneAdjustment As adjustment In lstAdjustments
                If CInt(oneAdjustment.code) = CInt(dgvAdjustments.SelectedRows(0).Cells("adjustmentCode").Value) Then
                    adjustment = oneAdjustment
                    Exit For
                End If
            Next
            showDetails()
        Else
            clearDetails()
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If Not editable Then
            If adjustment.id = 0 Then
                dtpDate.Value = Date.Today
            Else
                dtpDate.Value = adjustment.eventdate
            End If
        End If
    End Sub

    Private Sub cbxTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTypes.SelectedIndexChanged
        If Not editable Then
            If adjustment.id = 0 Then
                cbxTypes.SelectedIndex = -1
            Else
                cbxTypes.SelectedIndex = cbxTypes.FindStringExact(adjustment.type)
            End If
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        adjustment = New adjustment
        clearDetails()
        yesEdit()
        updateCode()
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        Me.CancelButton = btnCancel
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        transBegin()
        With adjustment
            .code = txtCode.Text
            .eventdate = dtpDate.Value
            .productID = product.id
            .type = cbxTypes.SelectedItem.ToString
            .variance = CInt(nudVariance.Value)
            .remarks = txtRemarks.Text
        End With
        query_adjustment(adjustment, sqlType.insert)
        inventory_update(product, CInt(nudVariance.Value), cbxTypes.SelectedItem.ToString)
        If query.err Then
            transRollback()
            MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            transCommit()
            frmMain.showQueryResult("Stock Adjustment has been saved.")
            refreshButtons()
            refreshAdjustments()
            noEdit()
            clearDetails()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        refreshButtons()
        clearDetails()
        noEdit()
        dgvAdjustments.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChooseItem_Click(sender As Object, e As EventArgs) Handles btnChooseItem.Click
        If editable Then
            MASK.now(slcInventory, Me)
            slcInventory.ShowDialog()
        End If
    End Sub
    Dim WithEvents frmInventorySLC As Form = slcInventory
    Private Sub frmInventorySLC_FormClosed() Handles frmInventorySLC.FormClosed
        product = slcInventory.product
        setItem()
    End Sub

End Class