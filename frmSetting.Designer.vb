<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.tbSpeed = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbSize = New System.Windows.Forms.TrackBar
        Me.lblSpeed = New System.Windows.Forms.Label
        Me.lblSize = New System.Windows.Forms.Label
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSpeed
        '
        Me.tbSpeed.LargeChange = 100
        Me.tbSpeed.Location = New System.Drawing.Point(214, 38)
        Me.tbSpeed.Maximum = 500
        Me.tbSpeed.Minimum = 100
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(242, 45)
        Me.tbSpeed.SmallChange = 10
        Me.tbSpeed.TabIndex = 0
        Me.tbSpeed.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "速度指標"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "字體大小"
        '
        'tbSize
        '
        Me.tbSize.Location = New System.Drawing.Point(214, 113)
        Me.tbSize.Maximum = 99
        Me.tbSize.Minimum = 9
        Me.tbSize.Name = "tbSize"
        Me.tbSize.Size = New System.Drawing.Size(242, 45)
        Me.tbSize.TabIndex = 0
        Me.tbSize.Value = 14
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSpeed.Location = New System.Drawing.Point(466, 47)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(19, 19)
        Me.lblSpeed.TabIndex = 2
        Me.lblSpeed.Text = "0"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblSize.Location = New System.Drawing.Point(466, 113)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(19, 19)
        Me.lblSize.TabIndex = 2
        Me.lblSize.Text = "0"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 191)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSize)
        Me.Controls.Add(Me.tbSpeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSetting"
        Me.Text = "Setting"
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSize As System.Windows.Forms.TrackBar
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
End Class
