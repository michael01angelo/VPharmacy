Public Class Print

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim pr As New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
        pr.Print(prtReceipt, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
    End Sub

End Class