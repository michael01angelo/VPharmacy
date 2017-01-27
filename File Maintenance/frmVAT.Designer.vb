<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVAT
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
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 3
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tplContents.Controls.Add(Me.nudValue, 0, 0)
        Me.tplContents.Controls.Add(Me.lblPercent, 2, 0)
        Me.tplContents.Controls.Add(Me.lblVAT, 0, 0)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 1)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 2
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tplContents.Size = New System.Drawing.Size(160, 90)
        Me.tplContents.TabIndex = 0
        '
        'nudValue
        '
        Me.nudValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudValue.BackColor = System.Drawing.Color.LightGreen
        Me.nudValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudValue.DecimalPlaces = 2
        Me.nudValue.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudValue.ForeColor = System.Drawing.Color.Black
        Me.nudValue.Location = New System.Drawing.Point(48, 0)
        Me.nudValue.Margin = New System.Windows.Forms.Padding(0)
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(80, 26)
        Me.nudValue.TabIndex = 1
        Me.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPercent
        '
        Me.lblPercent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPercent.BackColor = System.Drawing.Color.LightGreen
        Me.lblPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPercent.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(128, 0)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(32, 26)
        Me.lblPercent.TabIndex = 2
        Me.lblPercent.Text = "%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVAT
        '
        Me.lblVAT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVAT.BackColor = System.Drawing.Color.Lime
        Me.lblVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVAT.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.Location = New System.Drawing.Point(0, 0)
        Me.lblVAT.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(48, 26)
        Me.lblVAT.TabIndex = 0
        Me.lblVAT.Text = "VAT"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 3)
        Me.pnlControls.Controls.Add(Me.btnUpdate)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 55)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(160, 35)
        Me.pnlControls.TabIndex = 21
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.BackColor = System.Drawing.Color.Khaki
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(0, 0)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(72, 35)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.Khaki
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Indigo
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Impact", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(98, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'tplForm
        '
        Me.tplForm.BackColor = System.Drawing.Color.Aqua
        Me.tplForm.ColumnCount = 1
        Me.tplForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Controls.Add(Me.tplContents, 0, 1)
        Me.tplForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tplForm.Location = New System.Drawing.Point(5, 0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(190, 120)
        Me.tplForm.TabIndex = 36
        '
        'frmVAT
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Indigo
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(200, 125)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVAT"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Value Added Tax"
        Me.tplContents.ResumeLayout(False)
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents nudValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
End Class
