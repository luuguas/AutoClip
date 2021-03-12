<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAutoCloseMsg
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAutoCloseMsg))
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.TmrClose = New System.Windows.Forms.Timer(Me.components)
        Me.ImgInfo = New System.Windows.Forms.PictureBox()
        CType(Me.ImgInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblInfo
        '
        Me.LblInfo.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(63, 1)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(197, 62)
        Me.LblInfo.TabIndex = 0
        Me.LblInfo.Text = "指定範囲の最後の値を貼り付けました。オートコピーを終了します。"
        Me.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TmrClose
        '
        Me.TmrClose.Interval = 2000
        '
        'ImgInfo
        '
        Me.ImgInfo.Image = CType(resources.GetObject("ImgInfo.Image"), System.Drawing.Image)
        Me.ImgInfo.ImageLocation = ""
        Me.ImgInfo.Location = New System.Drawing.Point(18, 16)
        Me.ImgInfo.Name = "ImgInfo"
        Me.ImgInfo.Size = New System.Drawing.Size(32, 33)
        Me.ImgInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImgInfo.TabIndex = 1
        Me.ImgInfo.TabStop = False
        '
        'FrmAutoCloseMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(274, 67)
        Me.Controls.Add(Me.ImgInfo)
        Me.Controls.Add(Me.LblInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAutoCloseMsg"
        Me.Text = "AutoClip - オートコピーの終了"
        Me.TopMost = True
        CType(Me.ImgInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblInfo As Label
    Friend WithEvents TmrClose As Timer
    Friend WithEvents ImgInfo As PictureBox
End Class
