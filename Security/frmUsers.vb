Friend Class frmUsers

    Dim lstUsers As New List(Of user)
    Dim user As New user
    Dim lstUserTypes As List(Of usertype) = getUserTypes()

    Dim editable As Boolean = False

    Private Sub refreshUsers()
        dgvUsers.Rows.Clear()
        lstUsers = getUsers()
        For Each oneUser As user In lstUsers
            dgvUsers.Rows.Add(oneUser.name, user_getType(oneUser.typeID).name, oneUser.surname, oneUser.givenname)
        Next
        dgvUsers.ClearSelection()
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
        txtName.Text = user.name
        cbxUserTypes.SelectedIndex = cbxUserTypes.FindStringExact(user_getType(user.typeID).name)
        txtLastName.Text = user.surname
        txtGivenName.Text = user.givenname
    End Sub
    Private Sub clearDetails()
        txtName.Clear()
        cbxUserTypes.SelectedIndex = -1
        txtLastName.Clear()
        txtGivenName.Clear()
    End Sub

    Private Sub yesEdit()
        txtName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtGivenName.ReadOnly = False
        editable = True
    End Sub
    Private Sub noEdit()
        txtName.ReadOnly = True
        txtLastName.ReadOnly = True
        txtGivenName.ReadOnly = True
        editable = False
    End Sub

    Private Sub frmUsers_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        refreshUsers()
        cbxUserTypes.Items.Clear()
        For Each oneUserType As usertype In lstUserTypes
            cbxUserTypes.Items.Add(oneUserType.name)
        Next
    End Sub

    Dim titleForm As New lblTitle("Users' Details Maintenance")
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        dgvUsers.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        userName.DefaultCellStyle = dgvLeftStyle
        userType.DefaultCellStyle = dgvLeftStyle
        userSurName.DefaultCellStyle = dgvLeftStyle
        userGivenName.DefaultCellStyle = dgvLeftStyle
        refreshButtons()
        clearDetails()
        noEdit()
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
        If dgvUsers.SelectedRows.Count > 0 Then
            For Each oneUser As user In lstUsers
                If oneUser.name.Equals(dgvUsers.SelectedRows(0).Cells("userName").Value.ToString) Then
                    user = oneUser
                End If
            Next
            showDetails()
            btnEdit.Enabled = True
        Else
            clearDetails()
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub cbxUserTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUserTypes.SelectedIndexChanged
        If Not editable Then
            If user.id = 0 Then
                cbxUserTypes.SelectedIndex = -1
            Else
                cbxUserTypes.SelectedIndex = cbxUserTypes.FindStringExact(user_getType(user.typeID).name)
            End If
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        user = New user
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

    Dim WithEvents frmPasswordDlg As Form = frmPassword
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text <> String.Empty Then
            With user
                .name = txtName.Text
                For Each oneUserType As usertype In lstUserTypes
                    If oneUserType.name.Equals(cbxUserTypes.SelectedItem.ToString) Then
                        .typeID = oneUserType.id
                        Exit For
                    End If
                Next
                .surname = txtLastName.Text
                .givenname = txtGivenName.Text
                .address = txtAddress.Text
            End With
            If user.id = 0 Then
                MASK.now(frmPassword, Me)
                frmPassword.ShowDialog()
            Else
                saveUserDetails()
            End If
        End If
    End Sub
    Private Sub frmPasswordDlg_FormClosed() Handles frmPasswordDlg.FormClosed
        If frmPassword.password <> String.Empty Then
            transBegin()
            user_create(user, frmPassword.password)
            user_grant(user)
            If query.err Then
                transRollback()
                MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                transCommit()
                frmMain.showQueryResult("User has been created.")
                saveUserDetails()
            End If
        End If
    End Sub
    Private Sub saveUserDetails()
        transBegin()
        If user.id = 0 Then
            user_save(user, sqlType.insert)
        Else
            user_save(user, sqlType.update)
        End If
        If query.err Then
            transRollback()
            MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            transCommit()
            frmMain.showQueryResult("User has been saved.")
            refreshUsers()
            refreshButtons()
            clearDetails()
            noEdit()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearDetails()
        noEdit()
        refreshButtons()
        dgvUsers.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class