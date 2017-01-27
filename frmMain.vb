Friend Class frmMain

    Private Sub checkStatus()
        Select Case checkConnection()
            Case ConnectionState.Open
                With lblStatus
                    .BackColor = Color.Lime
                    .Text = "Status: Online"
                End With
            Case Not ConnectionState.Open
                With lblStatus
                    .BackColor = Color.Crimson
                    .Text = "Status: Offline"
                End With
        End Select
    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        lblDateTime.Text = Date.Now.ToString("dddd, dd MMMM yyyy - hh:mm tt")
        checkStatus()
    End Sub

    Private Sub prodDetails_Click(sender As Object, e As EventArgs) Handles prodDetails.Click
        If currentUserType.fm.Contains("products") Then
            With frmProducts
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub prodExpiration_Click(sender As Object, e As EventArgs) Handles prodExpiration.Click
        If currentUserType.fm.Contains("products") Then
            With frmExpiry
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub suppDetails_Click(sender As Object, e As EventArgs) Handles suppDetails.Click
        If currentUserType.fm.Contains("suppliers") Then
            With frmSuppliers
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub suppProductSupplied_Click(sender As Object, e As EventArgs) Handles suppProductSupplied.Click
        If currentUserType.fm.Contains("suppliers") Then
            With frmSuppliersProducts
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub cateMain_Click(sender As Object, e As EventArgs) Handles cateMain.Click
        If currentUserType.fm.Contains("categories") Then
            With frmCategories
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub cateSub_Click(sender As Object, e As EventArgs) Handles cateSub.Click
        If currentUserType.fm.Contains("categories") Then
            With frmSubCategories
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub miscDiscounts_Click(sender As Object, e As EventArgs) Handles miscDiscounts.Click
        If currentUserType.fm.Contains("miscellaneous") Then
            With frmDiscounts
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub miscUnits_Click(sender As Object, e As EventArgs) Handles miscUnits.Click
        If currentUserType.fm.Contains("miscellaneous") Then
            With frmUnits
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub miscReceiptNumber_Click(sender As Object, e As EventArgs) Handles miscReceiptNumber.Click
        If currentUserType.fm.Contains("miscellaneous") Then
            With frmReceiptNumber
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub miscVAT_Click(sender As Object, e As EventArgs) Handles miscVAT.Click
        If currentUserType.fm.Contains("miscellaneous") Then
            With frmVAT
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tnPointOfSale_Click(sender As Object, e As EventArgs) Handles tnPointOfSale.Click
        If currentUserType.tn.Contains("pointofsales") Then
            frmPointOfSale.Show()
            Me.Close()
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub tnPurchase_Click(sender As Object, e As EventArgs) Handles tnPurchase.Click
        If currentUserType.tn.Contains("purchase") Then
            With frmPurchase
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub tnReceive_Click(sender As Object, e As EventArgs) Handles tnReceive.Click
        If currentUserType.tn.Contains("receive") Then
            With frmReceive
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub tnReturn_Click(sender As Object, e As EventArgs) Handles tnReturn.Click
        If currentUserType.tn.Contains("return") Then
            With frmReturnToSupplier
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub tnStockAdjustments_Click(sender As Object, e As EventArgs) Handles tnStockAdjustments.Click
        If currentUserType.tn.Contains("stockadjustments") Then
            With frmStockAdjustment
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub scUsers_Click(sender As Object, e As EventArgs) Handles scUsers.Click
        If currentUserType.sc.Contains("users") Then
            With frmUsers
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub scUserTypes_Click(sender As Object, e As EventArgs) Handles scUserTypes.Click
        If currentUserType.sc.Contains("users") Then
            With frmUserTypes
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub rpExpirations_Click(sender As Object, e As EventArgs) Handles rpExpirations.Click
        If currentUserType.rp.Contains("expirations") Then
            With frmExpiration
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub rpSales_Click(sender As Object, e As EventArgs) Handles rpSales.Click
        If currentUserType.rp.Contains("sales") Then
            With frmSales
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub rpStocks_Click(sender As Object, e As EventArgs) Handles rpStocks.Click
        If currentUserType.rp.Contains("stocks") Then
            With frmStocks
                .MdiParent = Me
                .Show()
            End With
        Else
            MessageBox.Show("You don't have permission to view this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mainAbout_Click(sender As Object, e As EventArgs) Handles mainAbout.Click
        MASK.now(frmAbout, Me)
        frmAbout.ShowDialog()
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim ctrl = Nothing
        For Each ctrls In Me.Controls
            Try
                ctrl = CType(ctrls, MdiClient)
                With ctrl
                    .BackColor = Color.SkyBlue
                End With
            Catch
            End Try
        Next
        logo.MdiParent = Me
        logo.Show()
    End Sub

    Dim titleForm As New lblTitle("V-PHARMA" + vbCrLf + "Pharmacy Management System")
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tplForm.Controls.Add(titleForm, 0, 0)
        userMain.Text = currentUser.name
        lblQueryStatus.Text = String.Empty
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            disconnect()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Friend Sub showQueryResult(msg As String)
        tmrQuery.Enabled = True
        lblQueryStatus.Text = msg
    End Sub
    Private Sub tmrQuery_Tick(sender As Object, e As EventArgs) Handles tmrQuery.Tick
        tmrQuery.Enabled = False
        lblQueryStatus.Text = String.Empty
    End Sub

    Dim WithEvents frmPasswordDlg As Form
    Private Sub uoChangePassword_Click(sender As Object, e As EventArgs) Handles uoChangePassword.Click
        frmPasswordDlg = frmPassword
        MASK.now(frmPassword, Me)
        frmPassword.ShowDialog()
    End Sub
    Private Sub frmPasswordDlg_FormClosed() Handles frmPasswordDlg.FormClosed
        transBegin()
        If frmPassword.password <> String.Empty Then
            user_passwordchange(frmPassword.password)
        End If
        If query.err Then
            transRollback()
            MessageBox.Show(query.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            transCommit()
            Me.showQueryResult("Password has been changed.")
        End If
    End Sub

End Class