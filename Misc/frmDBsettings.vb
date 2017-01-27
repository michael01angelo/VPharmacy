Public Class frmDBsettings

    Dim titleForm As New lblTitle("Database Connection Settings")
    Private Sub frmDBsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        txtServer.Text = My.Settings.Server
        txtPort.Text = My.Settings.Port
        txtDatabase.Text = My.Settings.Database
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With My.Settings
            .Server = txtServer.Text
            .Port = txtPort.Text
            .Database = txtDatabase.Text
            .Save()
        End With
        With csbConnStr
            .Server = txtServer.Text
            .Port = txtPort.Text
            .Database = txtDatabase.Text
        End With
    End Sub

End Class