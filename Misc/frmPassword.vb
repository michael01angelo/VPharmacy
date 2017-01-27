Friend Class frmPassword

    Friend password As String = String.Empty

    Dim titleForm As New lblTitle("Set Password")
    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtNewPassword.Text <> String.Empty And txtNewPassword.Text = txtConfirmPassword.Text Then
            password = txtNewPassword.Text
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class