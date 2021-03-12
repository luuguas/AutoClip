<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TbcSelect = New System.Windows.Forms.TabControl()
        Me.TbpCount = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblClip_Count = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbDown = New System.Windows.Forms.RadioButton()
        Me.RdbUp = New System.Windows.Forms.RadioButton()
        Me.LblDiscription = New System.Windows.Forms.Label()
        Me.ChkLoop_Count = New System.Windows.Forms.CheckBox()
        Me.LblWave = New System.Windows.Forms.Label()
        Me.TxtInit = New System.Windows.Forms.TextBox()
        Me.TxtMax = New System.Windows.Forms.TextBox()
        Me.TxtStep = New System.Windows.Forms.TextBox()
        Me.TxtClip = New System.Windows.Forms.TextBox()
        Me.TxtMin = New System.Windows.Forms.TextBox()
        Me.LblStep = New System.Windows.Forms.Label()
        Me.LblRange = New System.Windows.Forms.Label()
        Me.TbpList = New System.Windows.Forms.TabPage()
        Me.BtnChangeStartIndex = New System.Windows.Forms.Button()
        Me.ChkLoop_List = New System.Windows.Forms.CheckBox()
        Me.LblStartIndex = New System.Windows.Forms.Label()
        Me.TxtStartIndex = New System.Windows.Forms.TextBox()
        Me.BtnReadFile = New System.Windows.Forms.Button()
        Me.BtnReverse = New System.Windows.Forms.Button()
        Me.BtnDeleteAll = New System.Windows.Forms.Button()
        Me.BtnDeleteSelected = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAddSelected = New System.Windows.Forms.Button()
        Me.BtnAddEnd = New System.Windows.Forms.Button()
        Me.BtnInsertCrLf = New System.Windows.Forms.Button()
        Me.BtnAddFront = New System.Windows.Forms.Button()
        Me.TxtAdd = New System.Windows.Forms.TextBox()
        Me.LblAdd = New System.Windows.Forms.Label()
        Me.LblClip_List = New System.Windows.Forms.Label()
        Me.LstClip = New System.Windows.Forms.ListBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ChkTopMost = New System.Windows.Forms.CheckBox()
        Me.TbcSelect.SuspendLayout()
        Me.TbpCount.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TbpList.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbcSelect
        '
        Me.TbcSelect.Controls.Add(Me.TbpCount)
        Me.TbcSelect.Controls.Add(Me.TbpList)
        Me.TbcSelect.Location = New System.Drawing.Point(12, 12)
        Me.TbcSelect.Name = "TbcSelect"
        Me.TbcSelect.SelectedIndex = 0
        Me.TbcSelect.Size = New System.Drawing.Size(459, 285)
        Me.TbcSelect.TabIndex = 0
        '
        'TbpCount
        '
        Me.TbpCount.Controls.Add(Me.Label1)
        Me.TbpCount.Controls.Add(Me.LblClip_Count)
        Me.TbpCount.Controls.Add(Me.GroupBox1)
        Me.TbpCount.Controls.Add(Me.LblDiscription)
        Me.TbpCount.Controls.Add(Me.ChkLoop_Count)
        Me.TbpCount.Controls.Add(Me.LblWave)
        Me.TbpCount.Controls.Add(Me.TxtInit)
        Me.TbpCount.Controls.Add(Me.TxtMax)
        Me.TbpCount.Controls.Add(Me.TxtStep)
        Me.TbpCount.Controls.Add(Me.TxtClip)
        Me.TbpCount.Controls.Add(Me.TxtMin)
        Me.TbpCount.Controls.Add(Me.LblStep)
        Me.TbpCount.Controls.Add(Me.LblRange)
        Me.TbpCount.Location = New System.Drawing.Point(4, 22)
        Me.TbpCount.Name = "TbpCount"
        Me.TbpCount.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpCount.Size = New System.Drawing.Size(451, 259)
        Me.TbpCount.TabIndex = 0
        Me.TbpCount.Text = "カウントで作成"
        Me.TbpCount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "初期値:"
        '
        'LblClip_Count
        '
        Me.LblClip_Count.AutoSize = True
        Me.LblClip_Count.Location = New System.Drawing.Point(34, 143)
        Me.LblClip_Count.Name = "LblClip_Count"
        Me.LblClip_Count.Size = New System.Drawing.Size(89, 12)
        Me.LblClip_Count.TabIndex = 10
        Me.LblClip_Count.Text = "コピーするテキスト:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbDown)
        Me.GroupBox1.Controls.Add(Me.RdbUp)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 43)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "カウントの種類"
        '
        'RdbDown
        '
        Me.RdbDown.AutoSize = True
        Me.RdbDown.Location = New System.Drawing.Point(128, 18)
        Me.RdbDown.Name = "RdbDown"
        Me.RdbDown.Size = New System.Drawing.Size(85, 16)
        Me.RdbDown.TabIndex = 1
        Me.RdbDown.Text = "カウントダウン"
        Me.RdbDown.UseVisualStyleBackColor = True
        '
        'RdbUp
        '
        Me.RdbUp.AutoSize = True
        Me.RdbUp.Location = New System.Drawing.Point(6, 18)
        Me.RdbUp.Name = "RdbUp"
        Me.RdbUp.Size = New System.Drawing.Size(83, 16)
        Me.RdbUp.TabIndex = 0
        Me.RdbUp.Text = "カウントアップ"
        Me.RdbUp.UseVisualStyleBackColor = True
        '
        'LblDiscription
        '
        Me.LblDiscription.AutoSize = True
        Me.LblDiscription.Location = New System.Drawing.Point(13, 174)
        Me.LblDiscription.Name = "LblDiscription"
        Me.LblDiscription.Size = New System.Drawing.Size(290, 72)
        Me.LblDiscription.TabIndex = 12
        Me.LblDiscription.Text = "※\d: これを入力した箇所にカウントの数値が挿入されます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　 \f: 最大値の桁数に合わせて数値の先頭に0が加わり、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 桁数のそろった数値が挿入され" &
    "ます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　 \x: x桁(xは1桁の自然数)に満たない数値には、その桁を" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　　　 満たすよう先頭に0が加わった値が挿入されます。 例:\3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　 \\: \" &
    "が表示されます。  \n: 改行が挿入されます。"
        '
        'ChkLoop_Count
        '
        Me.ChkLoop_Count.AutoSize = True
        Me.ChkLoop_Count.Location = New System.Drawing.Point(36, 111)
        Me.ChkLoop_Count.Name = "ChkLoop_Count"
        Me.ChkLoop_Count.Size = New System.Drawing.Size(237, 16)
        Me.ChkLoop_Count.TabIndex = 9
        Me.ChkLoop_Count.Text = "最大値に達したら再び最小値からカウントする"
        Me.ChkLoop_Count.UseVisualStyleBackColor = True
        '
        'LblWave
        '
        Me.LblWave.AutoSize = True
        Me.LblWave.Location = New System.Drawing.Point(181, 13)
        Me.LblWave.Name = "LblWave"
        Me.LblWave.Size = New System.Drawing.Size(17, 12)
        Me.LblWave.TabIndex = 2
        Me.LblWave.Text = "～"
        '
        'TxtInit
        '
        Me.TxtInit.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtInit.Location = New System.Drawing.Point(204, 35)
        Me.TxtInit.MaxLength = 10
        Me.TxtInit.Name = "TxtInit"
        Me.TxtInit.Size = New System.Drawing.Size(75, 19)
        Me.TxtInit.TabIndex = 7
        '
        'TxtMax
        '
        Me.TxtMax.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtMax.Location = New System.Drawing.Point(204, 10)
        Me.TxtMax.MaxLength = 10
        Me.TxtMax.Name = "TxtMax"
        Me.TxtMax.Size = New System.Drawing.Size(75, 19)
        Me.TxtMax.TabIndex = 3
        '
        'TxtStep
        '
        Me.TxtStep.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtStep.Location = New System.Drawing.Point(100, 35)
        Me.TxtStep.MaxLength = 5
        Me.TxtStep.Name = "TxtStep"
        Me.TxtStep.Size = New System.Drawing.Size(48, 19)
        Me.TxtStep.TabIndex = 5
        '
        'TxtClip
        '
        Me.TxtClip.Location = New System.Drawing.Point(129, 140)
        Me.TxtClip.Name = "TxtClip"
        Me.TxtClip.Size = New System.Drawing.Size(156, 19)
        Me.TxtClip.TabIndex = 11
        '
        'TxtMin
        '
        Me.TxtMin.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtMin.Location = New System.Drawing.Point(100, 10)
        Me.TxtMin.MaxLength = 10
        Me.TxtMin.Name = "TxtMin"
        Me.TxtMin.Size = New System.Drawing.Size(75, 19)
        Me.TxtMin.TabIndex = 1
        '
        'LblStep
        '
        Me.LblStep.AutoSize = True
        Me.LblStep.Location = New System.Drawing.Point(51, 39)
        Me.LblStep.Name = "LblStep"
        Me.LblStep.Size = New System.Drawing.Size(43, 12)
        Me.LblStep.TabIndex = 4
        Me.LblStep.Text = "増加量:"
        '
        'LblRange
        '
        Me.LblRange.AutoSize = True
        Me.LblRange.Location = New System.Drawing.Point(28, 13)
        Me.LblRange.Name = "LblRange"
        Me.LblRange.Size = New System.Drawing.Size(65, 12)
        Me.LblRange.TabIndex = 0
        Me.LblRange.Text = "数値の範囲:"
        '
        'TbpList
        '
        Me.TbpList.Controls.Add(Me.BtnChangeStartIndex)
        Me.TbpList.Controls.Add(Me.ChkLoop_List)
        Me.TbpList.Controls.Add(Me.LblStartIndex)
        Me.TbpList.Controls.Add(Me.TxtStartIndex)
        Me.TbpList.Controls.Add(Me.BtnReadFile)
        Me.TbpList.Controls.Add(Me.BtnReverse)
        Me.TbpList.Controls.Add(Me.BtnDeleteAll)
        Me.TbpList.Controls.Add(Me.BtnDeleteSelected)
        Me.TbpList.Controls.Add(Me.GroupBox2)
        Me.TbpList.Controls.Add(Me.LblClip_List)
        Me.TbpList.Controls.Add(Me.LstClip)
        Me.TbpList.Location = New System.Drawing.Point(4, 22)
        Me.TbpList.Name = "TbpList"
        Me.TbpList.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpList.Size = New System.Drawing.Size(451, 259)
        Me.TbpList.TabIndex = 1
        Me.TbpList.Text = "リストから作成"
        Me.TbpList.UseVisualStyleBackColor = True
        '
        'BtnChangeStartIndex
        '
        Me.BtnChangeStartIndex.Location = New System.Drawing.Point(343, 177)
        Me.BtnChangeStartIndex.Name = "BtnChangeStartIndex"
        Me.BtnChangeStartIndex.Size = New System.Drawing.Size(95, 37)
        Me.BtnChangeStartIndex.TabIndex = 9
        Me.BtnChangeStartIndex.Text = "選択した要素を" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "開始位置に指定"
        Me.BtnChangeStartIndex.UseVisualStyleBackColor = True
        '
        'ChkLoop_List
        '
        Me.ChkLoop_List.AutoSize = True
        Me.ChkLoop_List.Location = New System.Drawing.Point(193, 222)
        Me.ChkLoop_List.Name = "ChkLoop_List"
        Me.ChkLoop_List.Size = New System.Drawing.Size(139, 28)
        Me.ChkLoop_List.TabIndex = 7
        Me.ChkLoop_List.Text = "リストの終端に達したら" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "再び先頭から貼り付ける"
        Me.ChkLoop_List.UseVisualStyleBackColor = True
        '
        'LblStartIndex
        '
        Me.LblStartIndex.AutoSize = True
        Me.LblStartIndex.Location = New System.Drawing.Point(191, 189)
        Me.LblStartIndex.Name = "LblStartIndex"
        Me.LblStartIndex.Size = New System.Drawing.Size(92, 12)
        Me.LblStartIndex.TabIndex = 5
        Me.LblStartIndex.Text = "コピーの開始位置:"
        '
        'TxtStartIndex
        '
        Me.TxtStartIndex.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtStartIndex.Location = New System.Drawing.Point(289, 186)
        Me.TxtStartIndex.MaxLength = 6
        Me.TxtStartIndex.Name = "TxtStartIndex"
        Me.TxtStartIndex.Size = New System.Drawing.Size(43, 19)
        Me.TxtStartIndex.TabIndex = 6
        '
        'BtnReadFile
        '
        Me.BtnReadFile.Location = New System.Drawing.Point(343, 217)
        Me.BtnReadFile.Name = "BtnReadFile"
        Me.BtnReadFile.Size = New System.Drawing.Size(95, 37)
        Me.BtnReadFile.TabIndex = 8
        Me.BtnReadFile.Text = "ﾃｷｽﾄﾌｧｲﾙから" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ﾘｽﾄを読み込み..."
        Me.BtnReadFile.UseVisualStyleBackColor = True
        '
        'BtnReverse
        '
        Me.BtnReverse.Location = New System.Drawing.Point(30, 231)
        Me.BtnReverse.Name = "BtnReverse"
        Me.BtnReverse.Size = New System.Drawing.Size(142, 23)
        Me.BtnReverse.TabIndex = 3
        Me.BtnReverse.Text = "ﾘｽﾄを逆順に並べ替える"
        Me.BtnReverse.UseVisualStyleBackColor = True
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.Location = New System.Drawing.Point(41, 202)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(120, 23)
        Me.BtnDeleteAll.TabIndex = 3
        Me.BtnDeleteAll.Text = "全ての要素を削除"
        Me.BtnDeleteAll.UseVisualStyleBackColor = True
        '
        'BtnDeleteSelected
        '
        Me.BtnDeleteSelected.Location = New System.Drawing.Point(41, 176)
        Me.BtnDeleteSelected.Name = "BtnDeleteSelected"
        Me.BtnDeleteSelected.Size = New System.Drawing.Size(120, 23)
        Me.BtnDeleteSelected.TabIndex = 2
        Me.BtnDeleteSelected.Text = "選択した要素を削除"
        Me.BtnDeleteSelected.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnAddSelected)
        Me.GroupBox2.Controls.Add(Me.BtnAddEnd)
        Me.GroupBox2.Controls.Add(Me.BtnInsertCrLf)
        Me.GroupBox2.Controls.Add(Me.BtnAddFront)
        Me.GroupBox2.Controls.Add(Me.TxtAdd)
        Me.GroupBox2.Controls.Add(Me.LblAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(238, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 172)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'BtnAddSelected
        '
        Me.BtnAddSelected.Location = New System.Drawing.Point(21, 140)
        Me.BtnAddSelected.Name = "BtnAddSelected"
        Me.BtnAddSelected.Size = New System.Drawing.Size(158, 23)
        Me.BtnAddSelected.TabIndex = 4
        Me.BtnAddSelected.Text = "文字列を選択した位置に追加"
        Me.BtnAddSelected.UseVisualStyleBackColor = True
        '
        'BtnAddEnd
        '
        Me.BtnAddEnd.Location = New System.Drawing.Point(40, 88)
        Me.BtnAddEnd.Name = "BtnAddEnd"
        Me.BtnAddEnd.Size = New System.Drawing.Size(120, 23)
        Me.BtnAddEnd.TabIndex = 3
        Me.BtnAddEnd.Text = "文字列を末尾に追加"
        Me.BtnAddEnd.UseVisualStyleBackColor = True
        '
        'BtnInsertCrLf
        '
        Me.BtnInsertCrLf.Location = New System.Drawing.Point(21, 54)
        Me.BtnInsertCrLf.Name = "BtnInsertCrLf"
        Me.BtnInsertCrLf.Size = New System.Drawing.Size(158, 23)
        Me.BtnInsertCrLf.TabIndex = 2
        Me.BtnInsertCrLf.Text = "選択位置に改行文字を挿入"
        Me.BtnInsertCrLf.UseVisualStyleBackColor = True
        '
        'BtnAddFront
        '
        Me.BtnAddFront.Location = New System.Drawing.Point(40, 114)
        Me.BtnAddFront.Name = "BtnAddFront"
        Me.BtnAddFront.Size = New System.Drawing.Size(120, 23)
        Me.BtnAddFront.TabIndex = 2
        Me.BtnAddFront.Text = "文字列を先頭に追加"
        Me.BtnAddFront.UseVisualStyleBackColor = True
        '
        'TxtAdd
        '
        Me.TxtAdd.Location = New System.Drawing.Point(13, 29)
        Me.TxtAdd.Name = "TxtAdd"
        Me.TxtAdd.Size = New System.Drawing.Size(175, 19)
        Me.TxtAdd.TabIndex = 1
        '
        'LblAdd
        '
        Me.LblAdd.AutoSize = True
        Me.LblAdd.Location = New System.Drawing.Point(6, 13)
        Me.LblAdd.Name = "LblAdd"
        Me.LblAdd.Size = New System.Drawing.Size(86, 12)
        Me.LblAdd.TabIndex = 0
        Me.LblAdd.Text = "追加する文字列:"
        '
        'LblClip_List
        '
        Me.LblClip_List.AutoSize = True
        Me.LblClip_List.Location = New System.Drawing.Point(7, 8)
        Me.LblClip_List.Name = "LblClip_List"
        Me.LblClip_List.Size = New System.Drawing.Size(113, 12)
        Me.LblClip_List.TabIndex = 0
        Me.LblClip_List.Text = "コピーする文字列リスト:"
        '
        'LstClip
        '
        Me.LstClip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LstClip.FormattingEnabled = True
        Me.LstClip.HorizontalScrollbar = True
        Me.LstClip.ItemHeight = 12
        Me.LstClip.Items.AddRange(New Object() {"０１２３４５６７８９０１２３４５６７８９", "おはようございます。", "今日もいい天気ですね！"})
        Me.LstClip.Location = New System.Drawing.Point(14, 24)
        Me.LstClip.Name = "LstClip"
        Me.LstClip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LstClip.Size = New System.Drawing.Size(215, 148)
        Me.LstClip.TabIndex = 1
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(328, 303)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(126, 23)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "オートコピーの開始(&C)"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'ChkTopMost
        '
        Me.ChkTopMost.AutoSize = True
        Me.ChkTopMost.Location = New System.Drawing.Point(16, 307)
        Me.ChkTopMost.Name = "ChkTopMost"
        Me.ChkTopMost.Size = New System.Drawing.Size(154, 16)
        Me.ChkTopMost.TabIndex = 2
        Me.ChkTopMost.Text = "画面を常に前面に表示する"
        Me.ChkTopMost.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnAddEnd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 336)
        Me.Controls.Add(Me.ChkTopMost)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.TbcSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Text = "AutoClip v1.4.0"
        Me.TbcSelect.ResumeLayout(False)
        Me.TbpCount.ResumeLayout(False)
        Me.TbpCount.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TbpList.ResumeLayout(False)
        Me.TbpList.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbcSelect As TabControl
    Friend WithEvents TbpCount As TabPage
    Friend WithEvents LblClip_Count As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbDown As RadioButton
    Friend WithEvents RdbUp As RadioButton
    Friend WithEvents ChkLoop_Count As CheckBox
    Friend WithEvents LblWave As Label
    Friend WithEvents TxtMax As TextBox
    Friend WithEvents TxtStep As TextBox
    Friend WithEvents TxtClip As TextBox
    Friend WithEvents TxtMin As TextBox
    Friend WithEvents LblStep As Label
    Friend WithEvents LblRange As Label
    Friend WithEvents TbpList As TabPage
    Friend WithEvents BtnStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInit As TextBox
    Friend WithEvents LblClip_List As Label
    Friend WithEvents LstClip As ListBox
    Friend WithEvents LblDiscription As Label
    Friend WithEvents LblStartIndex As Label
    Friend WithEvents TxtStartIndex As TextBox
    Friend WithEvents BtnReadFile As Button
    Friend WithEvents BtnDeleteAll As Button
    Friend WithEvents BtnDeleteSelected As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAddSelected As Button
    Friend WithEvents BtnAddEnd As Button
    Friend WithEvents BtnAddFront As Button
    Friend WithEvents TxtAdd As TextBox
    Friend WithEvents LblAdd As Label
    Friend WithEvents ChkLoop_List As CheckBox
    Friend WithEvents BtnReverse As Button
    Friend WithEvents BtnInsertCrLf As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents ChkTopMost As CheckBox
    Friend WithEvents BtnChangeStartIndex As Button
End Class
