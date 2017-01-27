Friend NotInheritable Class frmSplash

    Private Sub setDataGridStyle()
        With dgvHeaderStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter
            .BackColor = Color.Lime
            .Font = New Font("Corbel", 10.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = Color.Black
            .WrapMode = DataGridViewTriState.[False]
        End With
        With dgvLeftStyle
            .Alignment = DataGridViewContentAlignment.MiddleLeft
            .BackColor = Color.LightGreen
            .Font = New Font("Consolas", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = Color.Black
            .SelectionBackColor = Color.Khaki
            .SelectionForeColor = Color.Black
            .WrapMode = DataGridViewTriState.[False]
        End With
        With dgvRightStyle
            .Alignment = DataGridViewContentAlignment.MiddleRight
            .BackColor = Color.LightGreen
            .Font = New Font("Consolas", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            .ForeColor = Color.Black
            .SelectionBackColor = Color.Khaki
            .SelectionForeColor = Color.Black
            .WrapMode = DataGridViewTriState.[False]
        End With
    End Sub

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setDataGridStyle()
        lblApplicationTitle.Text = My.Application.Info.Title
        lblVersion.Text = Application.ProductVersion
        lblCopyright.Text = My.Application.Info.Copyright
    End Sub

End Class