<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logo
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
        Me.lblPHARMA = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tplContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPHARMA
        '
        Me.lblPHARMA.BackColor = System.Drawing.Color.Transparent
        Me.lblPHARMA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPHARMA.Font = New System.Drawing.Font("Maiandra GD", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHARMA.ForeColor = System.Drawing.Color.Black
        Me.lblPHARMA.Location = New System.Drawing.Point(0, 179)
        Me.lblPHARMA.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPHARMA.Name = "lblPHARMA"
        Me.lblPHARMA.Size = New System.Drawing.Size(512, 153)
        Me.lblPHARMA.TabIndex = 0
        Me.lblPHARMA.Text = "PHARMA"
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.BackColor = System.Drawing.Color.Transparent
        Me.lblV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblV.Font = New System.Drawing.Font("Cooper Black", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.ForeColor = System.Drawing.Color.Black
        Me.lblV.Location = New System.Drawing.Point(0, 0)
        Me.lblV.Margin = New System.Windows.Forms.Padding(0)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(512, 179)
        Me.lblV.TabIndex = 1
        Me.lblV.Text = "V"
        Me.lblV.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(0, 332)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(512, 102)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Tarlac City"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 434)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 78)
        Me.Label1.TabIndex = 3
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tplContainer
        '
        Me.tplContainer.BackColor = System.Drawing.Color.Transparent
        Me.tplContainer.ColumnCount = 1
        Me.tplContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContainer.Controls.Add(Me.Label1, 0, 3)
        Me.tplContainer.Controls.Add(Me.lblV, 0, 0)
        Me.tplContainer.Controls.Add(Me.lblPHARMA, 0, 1)
        Me.tplContainer.Controls.Add(Me.lblAddress, 0, 2)
        Me.tplContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContainer.ForeColor = System.Drawing.Color.Black
        Me.tplContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContainer.Location = New System.Drawing.Point(0, 0)
        Me.tplContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.tplContainer.Name = "tplContainer"
        Me.tplContainer.RowCount = 4
        Me.tplContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tplContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tplContainer.Size = New System.Drawing.Size(512, 512)
        Me.tplContainer.TabIndex = 4
        '
        'logo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(512, 512)
        Me.Controls.Add(Me.tplContainer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Enabled = False
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "logo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "logo"
        Me.TransparencyKey = System.Drawing.Color.SkyBlue
        Me.tplContainer.ResumeLayout(False)
        Me.tplContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPHARMA As System.Windows.Forms.Label
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tplContainer As System.Windows.Forms.TableLayoutPanel
End Class
