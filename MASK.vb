Public Class MASK

    Private WithEvents formDialog As New Form
    Private WithEvents formMain As New Form

    Friend Sub now(toForm As Form, fromForm As Form)
        If fromForm.IsMdiChild Then
            With Me
                .Location = fromForm.MdiParent.Location
                .Size = fromForm.MdiParent.Size
            End With
        Else
            With Me
                .Location = fromForm.Location
                .Size = fromForm.Size
            End With
        End If
        Me.Show()
        formDialog = toForm
        formMain = fromForm
    End Sub

    Private Sub formDialog_FormClosed() Handles formDialog.FormClosed
        Me.Close()
        If formMain.IsMdiChild Then
            formMain.MdiParent.Select()
        Else
            formMain.Select()
        End If
    End Sub

End Class