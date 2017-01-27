Friend Class frmReceiptNumber

    Dim receiptcode As New receiptnumber

    Dim titleForm As New lblTitle("Receipt's Number Maintenance")
    Private Sub frmVAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        receiptcode = getReceiptCode()
        txtStart.Text = receiptcode.startCode
        txtEnd.Text = receiptcode.endCode
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        transBegin()
        With receiptcode
            .startCode = txtStart.Text
            .endCode = txtEnd.Text
        End With
        query_receiptcode(receiptcode)
        If query.err Then
            transRollback()
            MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            transCommit()
            frmMain.showQueryResult("Receipt Number has been saved.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class