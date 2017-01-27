Public Class frmSales

    Dim lstReceipts As New List(Of receipt)

    Private Sub refreshData()
        Dim total As New Decimal
        dgvReceipts.Rows.Clear()
        lstReceipts = getReceipts(dtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00"), dtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59"))
        For Each oneReceipt As receipt In lstReceipts
            While oneReceipt.code.Length < 16
                oneReceipt.code = "0" + oneReceipt.code
            End While
            dgvReceipts.Rows.Add(oneReceipt.code, oneReceipt.datetime, user_get(oneReceipt.cashierID, ).givenname, oneReceipt.amountdue)
            total += oneReceipt.amountdue
        Next
        txtTotalRevenue.Text = FormatNumber(total, 2)
        dgvReceipts.ClearSelection()
    End Sub

    Dim titleForm As New lblTitle("Sales Report")
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvReceipts.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        receiptCode.DefaultCellStyle = dgvRightStyle
        receiptDate.DefaultCellStyle = dgvLeftStyle
        receiptCashier.DefaultCellStyle = dgvLeftStyle
        receiptRevenue.DefaultCellStyle = dgvRightStyle
    End Sub

    Private Sub cbxRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRange.SelectedIndexChanged
        If cbxRange.SelectedIndex > -1 Then
            Select Case cbxRange.SelectedItem.ToString
                Case "Daily"
                    dtpEndDate.Value = dtpStartDate.Value
                Case "Weekly"
                    dtpEndDate.Value = dtpStartDate.Value.AddDays(7)
                Case "Monthly"
                    dtpEndDate.Value = dtpStartDate.Value.AddMonths(1)
                Case "Yearly"
                    dtpEndDate.Value = dtpStartDate.Value.AddYears(1)
            End Select
            refreshData()
        Else
            cbxRange.SelectedIndex = cbxRange.FindStringExact("<Custom>")
            refreshData()
        End If
        Me.ActiveControl = dgvReceipts
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        If cbxRange.SelectedIndex > -1 Then
            Select Case cbxRange.SelectedItem.ToString
                Case "Daily"
                    dtpEndDate.Value = dtpStartDate.Value
                Case "Weekly"
                    dtpEndDate.Value = dtpStartDate.Value.AddDays(7)
                Case "Monthly"
                    dtpEndDate.Value = dtpStartDate.Value.AddMonths(1)
                Case "Yearly"
                    dtpEndDate.Value = dtpStartDate.Value.AddYears(1)
            End Select
            refreshData()
        Else
            cbxRange.SelectedIndex = cbxRange.FindStringExact("<Custom>")
            refreshData()
        End If
        Me.ActiveControl = dgvReceipts
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        cbxRange.SelectedIndex = cbxRange.FindStringExact("<Custom>")
        refreshData()
        Me.ActiveControl = dgvReceipts
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class