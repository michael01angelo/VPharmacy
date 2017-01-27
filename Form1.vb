Public Class Form1

    Dim fl As String = "d:\Documents\Project\data.txt"
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnRemoveProducta(sender As Object, e As EventArgs)
        With csbConnStr
            .Database = "pharmacy"
            .Password = "Admin"
            .Port = CUInt(3306)
            .Server = "127.0.0.1"
            .SqlServerMode = True
            .UserID = "root"
        End With
        cn.ConnectionString = csbConnStr.ConnectionString
        cmd.Connection = cn
        cn.Open()
        cn.Close()
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

    End Sub

    Private Sub prn_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawString("Hello from VB.NET", New Font("Arial", 60, FontStyle.Regular), Brushes.Blue, 100, 100)
    End Sub

    Private Sub PrintTest()
        
    End Sub

    Private Sub btnRemoveProduct_Click(sender As Object, e As EventArgs) Handles btnRemoveProduct.Click
        MessageBox.Show(CInt(MaskedTextBox1.Text))
    End Sub
End Class