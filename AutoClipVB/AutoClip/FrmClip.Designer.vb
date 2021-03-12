<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClip
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClip))
        Me.LblM = New System.Windows.Forms.Label()
        Me.LblMode = New System.Windows.Forms.Label()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.LblA = New System.Windows.Forms.Label()
        Me.LblB = New System.Windows.Forms.Label()
        Me.BtnBef = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.LblDiscription = New System.Windows.Forms.Label()
        Me.LblNow = New System.Windows.Forms.Label()
        Me.LblBef = New System.Windows.Forms.Label()
        Me.LblNext = New System.Windows.Forms.Label()
        Me.LblList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblM
        '
        Me.LblM.AutoSize = True
        Me.LblM.Location = New System.Drawing.Point(12, 10)
        Me.LblM.Name = "LblM"
        Me.LblM.Size = New System.Drawing.Size(62, 12)
        Me.LblM.TabIndex = 0
        Me.LblM.Text = "コピーモード:"
        '
        'LblMode
        '
        Me.LblMode.AutoSize = True
        Me.LblMode.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblMode.Location = New System.Drawing.Point(80, 9)
        Me.LblMode.Name = "LblMode"
        Me.LblMode.Size = New System.Drawing.Size(84, 14)
        Me.LblMode.TabIndex = 1
        Me.LblMode.Text = "カウントアップ"
        Me.LblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPause
        '
        Me.BtnPause.Location = New System.Drawing.Point(25, 180)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(161, 23)
        Me.BtnPause.TabIndex = 99
        Me.BtnPause.Text = "オートコピーの一時停止(&C)"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(194, 180)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(131, 23)
        Me.BtnStop.TabIndex = 99
        Me.BtnStop.Text = "オートコピーを終了(&E)"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblA.Location = New System.Drawing.Point(196, 68)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(19, 15)
        Me.LblA.TabIndex = 100
        Me.LblA.Text = "∧"
        Me.LblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblB
        '
        Me.LblB.AutoSize = True
        Me.LblB.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblB.Location = New System.Drawing.Point(196, 115)
        Me.LblB.Name = "LblB"
        Me.LblB.Size = New System.Drawing.Size(19, 15)
        Me.LblB.TabIndex = 100
        Me.LblB.Text = "∧"
        Me.LblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBef
        '
        Me.BtnBef.Location = New System.Drawing.Point(37, 38)
        Me.BtnBef.Name = "BtnBef"
        Me.BtnBef.Size = New System.Drawing.Size(58, 31)
        Me.BtnBef.TabIndex = 103
        Me.BtnBef.Text = "1つ戻る"
        Me.BtnBef.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(37, 130)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(58, 31)
        Me.BtnNext.TabIndex = 103
        Me.BtnNext.Text = "1つ進む"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'LblDiscription
        '
        Me.LblDiscription.AutoSize = True
        Me.LblDiscription.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblDiscription.Location = New System.Drawing.Point(13, 94)
        Me.LblDiscription.Name = "LblDiscription"
        Me.LblDiscription.Size = New System.Drawing.Size(63, 12)
        Me.LblDiscription.TabIndex = 100
        Me.LblDiscription.Text = "Ctrl+V ->"
        Me.LblDiscription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNow
        '
        Me.LblNow.AutoEllipsis = True
        Me.LblNow.BackColor = System.Drawing.SystemColors.Window
        Me.LblNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNow.Font = New System.Drawing.Font("游ゴシック", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblNow.Location = New System.Drawing.Point(81, 89)
        Me.LblNow.Name = "LblNow"
        Me.LblNow.Size = New System.Drawing.Size(248, 20)
        Me.LblNow.TabIndex = 104
        Me.LblNow.Text = "０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９"
        Me.LblNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBef
        '
        Me.LblBef.AutoEllipsis = True
        Me.LblBef.BackColor = System.Drawing.SystemColors.Window
        Me.LblBef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBef.Font = New System.Drawing.Font("游ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblBef.Location = New System.Drawing.Point(105, 44)
        Me.LblBef.Name = "LblBef"
        Me.LblBef.Size = New System.Drawing.Size(201, 18)
        Me.LblBef.TabIndex = 104
        Me.LblBef.Text = "０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９"
        Me.LblBef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNext
        '
        Me.LblNext.AutoEllipsis = True
        Me.LblNext.BackColor = System.Drawing.SystemColors.Window
        Me.LblNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNext.Font = New System.Drawing.Font("游ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblNext.Location = New System.Drawing.Point(105, 136)
        Me.LblNext.Name = "LblNext"
        Me.LblNext.Size = New System.Drawing.Size(201, 18)
        Me.LblNext.TabIndex = 104
        Me.LblNext.Text = "０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９"
        Me.LblNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblList
        '
        Me.LblList.AutoSize = True
        Me.LblList.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.LblList.Location = New System.Drawing.Point(255, 9)
        Me.LblList.Name = "LblList"
        Me.LblList.Size = New System.Drawing.Size(38, 14)
        Me.LblList.TabIndex = 105
        Me.LblList.Text = "xx/xx"
        '
        'FrmClip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 215)
        Me.Controls.Add(Me.LblList)
        Me.Controls.Add(Me.LblNext)
        Me.Controls.Add(Me.LblBef)
        Me.Controls.Add(Me.LblNow)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnBef)
        Me.Controls.Add(Me.LblDiscription)
        Me.Controls.Add(Me.LblB)
        Me.Controls.Add(Me.LblA)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.LblMode)
        Me.Controls.Add(Me.LblM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmClip"
        Me.Text = "AutoClip v1.4.0 [オートコピー中]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblM As Label
    Friend WithEvents LblMode As Label
    Friend WithEvents BtnPause As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents LblA As Label
    Friend WithEvents LblB As Label
    Friend WithEvents BtnBef As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents LblDiscription As Label
    Friend WithEvents LblNow As Label
    Friend WithEvents LblBef As Label
    Friend WithEvents LblNext As Label
    Friend WithEvents LblList As Label
End Class
