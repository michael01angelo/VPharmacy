<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tplContents = New System.Windows.Forms.TableLayoutPanel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblApplicationTitle = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.tplContents.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.BackColor = System.Drawing.Color.Transparent
        Me.tplContents.ColumnCount = 3
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplContents.Controls.Add(Me.lblVersion, 1, 1)
        Me.tplContents.Controls.Add(Me.lblApplicationTitle, 1, 0)
        Me.tplContents.Controls.Add(Me.pbxLogo, 0, 0)
        Me.tplContents.Controls.Add(Me.lblCopyright, 2, 1)
        Me.tplContents.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(0)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 2
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tplContents.Size = New System.Drawing.Size(285, 65)
        Me.tplContents.TabIndex = 0
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblVersion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.Black
        Me.lblVersion.Location = New System.Drawing.Point(82, 42)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblVersion.Size = New System.Drawing.Size(94, 23)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblApplicationTitle
        '
        Me.lblApplicationTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApplicationTitle.AutoSize = True
        Me.lblApplicationTitle.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.tplContents.SetColumnSpan(Me.lblApplicationTitle, 2)
        Me.lblApplicationTitle.Font = New System.Drawing.Font("Maiandra GD", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationTitle.ForeColor = System.Drawing.Color.Black
        Me.lblApplicationTitle.Location = New System.Drawing.Point(82, 0)
        Me.lblApplicationTitle.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblApplicationTitle.Name = "lblApplicationTitle"
        Me.lblApplicationTitle.Padding = New System.Windows.Forms.Padding(5)
        Me.lblApplicationTitle.Size = New System.Drawing.Size(203, 42)
        Me.lblApplicationTitle.TabIndex = 2
        Me.lblApplicationTitle.Text = "Pharmacy System"
        Me.lblApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pbxLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxLogo.Image = Global.pharmacy.My.Resources.Resources.heartbeat128
        Me.pbxLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.tplContents.SetRowSpan(Me.pbxLogo, 2)
        Me.pbxLogo.Size = New System.Drawing.Size(67, 65)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblCopyright.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(176, 42)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Padding = New System.Windows.Forms.Padding(0, 0, 5, 5)
        Me.lblCopyright.Size = New System.Drawing.Size(109, 23)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "Copyright"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.Aqua
        Me.pnlForm.Controls.Add(Me.tplContents)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlForm.ForeColor = System.Drawing.Color.Black
        Me.pnlForm.Location = New System.Drawing.Point(5, 5)
        Me.pnlForm.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Padding = New System.Windows.Forms.Padding(15)
        Me.pnlForm.Size = New System.Drawing.Size(315, 95)
        Me.pnlForm.TabIndex = 33
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(325, 105)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlForm)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents pnlForm As System.Windows.Forms.Panel

End Class
