<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGetNumber = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRestart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTotalNumber = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.opfDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.987949!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.50273!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.67577!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(847, 549)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnGetNumber, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 432)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.29914!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.70086!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(824, 114)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'btnGetNumber
        '
        Me.btnGetNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGetNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGetNumber.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnGetNumber.Location = New System.Drawing.Point(3, 54)
        Me.btnGetNumber.Name = "btnGetNumber"
        Me.btnGetNumber.Size = New System.Drawing.Size(818, 57)
        Me.btnGetNumber.TabIndex = 0
        Me.btnGetNumber.Text = "開           獎   (Enter)"
        Me.btnGetNumber.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtStart, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEnd, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(818, 45)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(411, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "結束號碼"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 45)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "開始號碼"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStart
        '
        Me.txtStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStart.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStart.Location = New System.Drawing.Point(207, 3)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(198, 30)
        Me.txtStart.TabIndex = 1
        Me.txtStart.Text = "1"
        Me.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEnd
        '
        Me.txtEnd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEnd.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEnd.Location = New System.Drawing.Point(615, 3)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(200, 30)
        Me.txtEnd.TabIndex = 2
        Me.txtEnd.Text = "99"
        Me.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblNumber, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTotalNumber, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(11, 13)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 427.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(824, 413)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumber.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumber.Font = New System.Drawing.Font("新細明體", 198.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(3, 0)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(406, 413)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "99"
        Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRestart, Me.mnuOpen})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 48)
        '
        'mnuRestart
        '
        Me.mnuRestart.Name = "mnuRestart"
        Me.mnuRestart.Size = New System.Drawing.Size(150, 22)
        Me.mnuRestart.Text = "重新開始(&r)"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(150, 22)
        Me.mnuOpen.Text = "開啟舊計錄(&o)"
        '
        'txtTotalNumber
        '
        Me.txtTotalNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalNumber.Font = New System.Drawing.Font("新細明體", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtTotalNumber.Location = New System.Drawing.Point(415, 3)
        Me.txtTotalNumber.Multiline = True
        Me.txtTotalNumber.Name = "txtTotalNumber"
        Me.txtTotalNumber.ReadOnly = True
        Me.txtTotalNumber.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTotalNumber.Size = New System.Drawing.Size(406, 407)
        Me.txtTotalNumber.TabIndex = 3
        '
        'Timer1
        '
        '
        'opfDialog
        '
        Me.opfDialog.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnGetNumber
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 549)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "賓果開獎"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtTotalNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnGetNumber As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuRestart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opfDialog As System.Windows.Forms.OpenFileDialog

End Class
