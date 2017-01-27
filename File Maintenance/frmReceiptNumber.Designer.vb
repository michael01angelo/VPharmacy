<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiptNumber
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
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tplForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tplContents.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.tplForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'tplContents
        '
        Me.tplContents.ColumnCount = 2
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tplContents.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tplContents.Controls.Add(Me.txtEnd, 0, 1)
        Me.tplContents.Controls.Add(Me.txtStart, 1, 0)
        Me.tplContents.Controls.Add(Me.lblStart, 0, 0)
        Me.tplContents.Controls.Add(Me.lblEnd, 0, 1)
        Me.tplContents.Controls.Add(Me.pnlControls, 0, 2)
        Me.tplContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tplContents.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tplContents.Location = New System.Drawing.Point(15, 15)
        Me.tplContents.Margin = New System.Windows.Forms.Padding(15)
        Me.tplContents.Name = "tplContents"
        Me.tplContents.RowCount = 3
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tplContents.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tplContents.Size = New System.Drawing.Size(260, 125)
        Me.tplContents.TabIndex = 0
        '
        'txtEnd
        '
        Me.txtEnd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnd.BackColor = System.Drawing.Color.LightGreen
        Me.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEnd.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.ForeColor = System.Drawing.Color.Black
        Me.txtEnd.Location = New System.Drawing.Point(65, 45)
        Me.txtEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEnd.MaxLength = 16
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(195, 26)
        Me.txtEnd.TabIndex = 3
        Me.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStart
        '
        Me.txtStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStart.BackColor = System.Drawing.Color.LightGreen
        Me.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStart.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.ForeColor = System.Drawing.Color.Black
        Me.txtStart.Location = New System.Drawing.Point(65, 0)
        Me.txtStart.Margin = New System.Windows.Forms.Padding(0)
        Me.txtStart.MaxLength = 16
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(195, 26)
        Me.txtStart.TabIndex = 1
        Me.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStart
        '
        Me.lblStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStart.BackColor = System.Drawing.Color.Lime
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStart.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(0, 0)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(65, 26)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Start"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnd
        '
        Me.lblEnd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEnd.BackColor = System.Drawing.Color.Lime
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEnd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(0, 45)
        Me.lblEnd.Margin = New System.Windows.Forms.Padding(0)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(65, 26)
        Me.lblEnd.TabIndex = 2
        Me.lblEnd.Text = "End"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.tplContents.SetColumnSpan(Me.pnlControls, 2)
        Me.pnlControls.Controls.Add(Me.btnUpdate)
        Me.pnlControls.Controls.Add(Me.btnClose)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControls.Location = New System.Drawing.Point(0, 90)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(260, 35)
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
        Me.btnClose.Location = New System.Drawing.Point(198, 0)
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
        Me.tplForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tplForm.Name = "tplForm"
        Me.tplForm.RowCount = 2
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tplForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tplForm.Size = New System.Drawing.Size(290, 155)
        Me.tplForm.TabIndex = 36
        '
        'frmReceiptNumber
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(300, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.tplForm)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceiptNumber"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Receipt Number"
        Me.tplContents.ResumeLayout(False)
        Me.tplContents.PerformLayout()
        Me.pnlControls.ResumeLayout(False)
        Me.pnlControls.PerformLayout()
        Me.tplForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tplContents As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents pnlControls As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents tplForm As System.Windows.Forms.TableLayoutPanel
End Class
