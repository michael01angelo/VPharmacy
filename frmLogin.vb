Public Class frmLogin

    Dim titleForm As New lblTitle("Pharmacy System")
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - (Me.Size.Width * 1.25), My.Computer.Screen.WorkingArea.Height - (Me.Size.Height * 1.75))
        lblTitle.Text = My.Settings.CompanyName
        lblAddress.Text = My.Settings.CompanyAddress
        lblNumbers.Text = My.Settings.CompanyNumbers
        lblVersion.Text = Application.ProductVersion
        With csbConnStr
            .Database = My.Settings.Database
            .Port = My.Settings.Port
            .Server = My.Settings.Server
            .SqlServerMode = True
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        lblDateTime.Text = Date.Now.ToString("dddd, dd MMMM yyyy - hh:mm tt")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        With csbConnStr
            .Password = txtPassword.Text
            .UserID = txtUsername.Text
        End With
        If connect() = ConnectionState.Open Then
            currentUser = user_get(, txtUsername.Text)
            currentUserType = user_getType(currentUser.typeID)
            getCompanyDetails()
            frmMain.Show()
            csbConnStr.Clear()
            Me.Close()
        Else
            MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = String.Empty
            txtUsername.Select()
            txtUsername.SelectAll()
        End If
    End Sub

    Private Sub btnSetUp_Click(sender As Object, e As EventArgs) Handles btnSetUp.Click
        MASK.now(frmDBsettings, Me)
        frmDBsettings.ShowDialog()
    End Sub

    Dim WithEvents frm As Form = frmDBsettings
    Private Sub frm_FormClosed() Handles frm.FormClosed
        txtUsername.Select()
    End Sub

End Class