Option Explicit On
Imports System.ComponentModel

Public Class FrmMain
    '二重起動防止用ミューテックス
    Private ObjMutex As Threading.Mutex

    'iniファイル書き込み&読み取り用
    Const IniRelativePath As String = "\ACInit.ini"

    'フォームのロード中フラグ(ところでフラグって何なん?)
    Public Loading As Boolean

    '常に前面に表示フラグ
    Public Form_TopMost As Boolean

    '現在表示されているデータ
    Dim Count_ShownText As New Count.Text(False)
    Dim List_ShownText As New Rist.Text(False)

    '最後にオートコピーを起動したときのデータ
    Private _succeedMode As New Mode.Data(False)
    Private _count_SucceedData As New Count.Data(False)
    Private _list_SucceedData As New Rist.Data(False)

    Public Property SucceedMode As Mode.Data
        Get
            Return _succeedMode
        End Get
        Set(value As Mode.Data)
            _succeedMode = value
        End Set
    End Property
    Public Property Count_SucceedData As Count.Data
        Get
            Return _count_SucceedData
        End Get
        Set(value As Count.Data)
            _count_SucceedData = value
        End Set
    End Property
    Friend Property List_SucceedData As Rist.Data
        Get
            Return _list_SucceedData
        End Get
        Set(value As Rist.Data)
            _list_SucceedData = value
        End Set
    End Property

#Region "Countモード"

    ''' <summary>
    ''' Countﾓｰﾄﾞ用にﾌｫｰﾑのｻｲｽﾞを変更
    ''' </summary>
    Private Sub Count_Resize()
        Me.Size = New Size(370, 375)
        TbcSelect.Size = New Size(320, 285)
        BtnStart.Location = New Point(199, 303)
    End Sub

    ''' <summary>
    ''' Count_ShownTextのﾃﾞｰﾀをｱﾌﾟﾘに反映
    ''' </summary>
    Private Sub Count_Show()
        TxtMin.Text = Count_ShownText.Min
        TxtMax.Text = Count_ShownText.Max
        TxtStep.Text = Count_ShownText.Stp
        TxtInit.Text = Count_ShownText.Init
        If Count_ShownText.Up = "True" Then
            RdbUp.Checked = True
            RdbDown.Checked = False
        Else
            RdbUp.Checked = False
            RdbDown.Checked = True
        End If
        If Count_ShownText.Luup = "True" Then
            ChkLoop_Count.Checked = True
        Else
            ChkLoop_Count.Checked = False
        End If
        TxtClip.Text = Count_ShownText.Clip
    End Sub

    ''' <summary>
    ''' ｱﾌﾟﾘの表示状態をCount_ShownTextに格納
    ''' </summary>
    Private Sub Count_Input()
        Count_ShownText.Min = TxtMin.Text
        Count_ShownText.Max = TxtMax.Text
        Count_ShownText.Stp = TxtStep.Text
        Count_ShownText.Init = TxtInit.Text
        If RdbUp.Checked Then
            Count_ShownText.Up = "True"
            Count_ShownText.Down = "False"
        Else
            Count_ShownText.Up = "False"
            Count_ShownText.Down = "True"
        End If
        If ChkLoop_Count.Checked Then
            Count_ShownText.Luup = "True"
        Else
            Count_ShownText.Luup = "False"
        End If
        Count_ShownText.Clip = TxtClip.Text
    End Sub

    Private Sub TxtMin_TextChanged(sender As Object, e As EventArgs) Handles TxtMin.TextChanged
        If Not Loading Then
            If TxtMin.Text = "" Then
                Count_Input()
                Exit Sub
            End If

            Dim Result As Boolean
            Dim Num As Integer
            Result = Integer.TryParse(TxtMin.Text, Num)
            If Result Then
                If (0 <= Num And Num <= 1000000000) Then
                    Count_Input()
                Else
                    TxtMin.Text = Count_ShownText.Min
                    TxtMin.SelectionStart = TxtMin.TextLength
                    Beep()
                End If
            Else
                TxtMin.Text = Count_ShownText.Min
                TxtMin.SelectionStart = TxtMin.TextLength
                Beep()
            End If
        End If
    End Sub

    Private Sub TxtMax_TextChanged(sender As Object, e As EventArgs) Handles TxtMax.TextChanged
        If Not Loading Then
            If TxtMax.Text = "" Then
                Count_Input()
                Exit Sub
            End If

            Dim Result As Boolean
            Dim Num As Integer
            Result = Integer.TryParse(TxtMax.Text, Num)
            If Result Then
                If (0 <= Num And Num <= 1000000000) Then
                    Count_Input()
                Else
                    TxtMax.Text = Count_ShownText.Max
                    TxtMax.SelectionStart = TxtMax.TextLength
                    Beep()
                End If
            Else
                TxtMax.Text = Count_ShownText.Max
                TxtMax.SelectionStart = TxtMax.TextLength
                Beep()
            End If
        End If
    End Sub

    Private Sub TxtStep_TextChanged(sender As Object, e As EventArgs) Handles TxtStep.TextChanged
        If Not Loading Then
            If TxtStep.Text = "" Then
                Count_Input()
                Exit Sub
            End If

            Dim Result As Boolean
            Dim Num As Integer
            Result = Integer.TryParse(TxtStep.Text, Num)
            If Result Then
                If (0 <= Num And Num <= 1000000000) Then
                    Count_Input()
                Else
                    TxtStep.Text = Count_ShownText.Stp
                    TxtStep.SelectionStart = TxtStep.TextLength
                    Beep()
                End If
            Else
                TxtStep.Text = Count_ShownText.Stp
                TxtStep.SelectionStart = TxtStep.TextLength
                Beep()
            End If
        End If
    End Sub

    Private Sub TxtInit_TextChanged(sender As Object, e As EventArgs) Handles TxtInit.TextChanged
        If Not Loading Then
            If TxtInit.Text = "" Then
                Count_Input()
                Exit Sub
            End If

            Dim Result As Boolean
            Dim Num As Integer
            Result = Integer.TryParse(TxtInit.Text, Num)
            If Result Then
                If (0 <= Num And Num <= 1000000000) Then
                    Count_Input()
                Else
                    TxtInit.Text = Count_ShownText.Init
                    TxtInit.SelectionStart = TxtInit.TextLength
                    Beep()
                End If
            Else
                TxtInit.Text = Count_ShownText.Init
                TxtInit.SelectionStart = TxtInit.TextLength
                Beep()
            End If
        End If
    End Sub

    Private Sub RdbUp_CheckedChanged(sender As Object, e As EventArgs) Handles RdbUp.CheckedChanged
        If Not Loading Then
            Count_Input()
        End If
    End Sub

    Private Sub RdbDown_CheckedChanged(sender As Object, e As EventArgs) Handles RdbDown.CheckedChanged
        If Not Loading Then
            Count_Input()
        End If
    End Sub

    Private Sub ChkLoop_Count_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLoop_Count.CheckedChanged
        If Not Loading Then
            Count_Input()
        End If
    End Sub

    Private Sub TxtClip_TextChanged(sender As Object, e As EventArgs) Handles TxtClip.TextChanged
        If Not Loading Then
            Count_Input()
        End If
    End Sub

#End Region

#Region "Listモード"

    ''' <summary>
    ''' Listﾓｰﾄﾞ用にﾌｫｰﾑのｻｲｽﾞを変更
    ''' </summary>
    Private Sub List_Resize()
        Me.Size = New Size(495, 375)
        TbcSelect.Size = New Size(457, 285)
        BtnStart.Location = New Point(325, 303)
    End Sub


    ''' <summary>
    ''' List_ShownTextのﾃﾞｰﾀをｱﾌﾟﾘに反映
    ''' </summary>
    Private Sub List_Show(ListChange As Boolean)
        TxtStartIndex.Text = List_ShownText.StartIndex
        If List_ShownText.Luup = "True" Then
            ChkLoop_List.Checked = True
        Else
            ChkLoop_List.Checked = False
        End If
        If ListChange Then
            LstClip.Items.Clear()
            LstClip.Items.AddRange(List_ShownText.ClipList.ToArray())
        End If
    End Sub
    ''' <summary>
    ''' ｱﾌﾟﾘの表示状態をList_ShownTextに格納(ClipListの変更なし)
    ''' </summary>
    Private Sub List_Input()
        List_ShownText.StartIndex = TxtStartIndex.Text
        If ChkLoop_List.Checked Then
            List_ShownText.Luup = "True"
        Else
            List_ShownText.Luup = "False"
        End If
        List_ShownText.Count = LstClip.Items.Count.ToString()
    End Sub
    ''' <summary>
    ''' ｱﾌﾟﾘの表示状態をList_ShownTextに格納(ClipListに文字列を追加)
    ''' <param name="AddIndex">挿入箇所</param>
    ''' <param name="AddStr">追加する文字列</param>
    ''' </summary>
    Private Sub List_Input(AddIndex As Integer, AddStr As String)
        List_ShownText.StartIndex = TxtStartIndex.Text
        If ChkLoop_List.Checked Then
            List_ShownText.Luup = "True"
        Else
            List_ShownText.Luup = "False"
        End If
        List_ShownText.Count = LstClip.Items.Count.ToString()
        List_ShownText.ClipList.Insert(AddIndex, AddStr)
    End Sub
    ''' <summary>
    ''' ｱﾌﾟﾘの表示状態をList_ShownTextに格納(ClipListから文字列を削除)
    ''' <param name="DelIndex">削除する文字列の添字</param>
    ''' </summary>
    Private Sub List_Input(DelIndex As Integer)
        List_ShownText.StartIndex = TxtStartIndex.Text
        If ChkLoop_List.Checked Then
            List_ShownText.Luup = "True"
        Else
            List_ShownText.Luup = "False"
        End If
        List_ShownText.Count = LstClip.Items.Count.ToString()
        List_ShownText.ClipList.RemoveAt(DelIndex)
    End Sub
    ''' <summary>
    ''' ｱﾌﾟﾘの表示状態をList_ShownTextに格納(True:ClipListを空にする/False:Reverse)
    ''' </summary>
    Private Sub List_Input(Cash As Boolean)
        List_ShownText.StartIndex = TxtStartIndex.Text
        If ChkLoop_List.Checked Then
            List_ShownText.Luup = "True"
        Else
            List_ShownText.Luup = "False"
        End If
        List_ShownText.Count = LstClip.Items.Count.ToString()
        If Cash Then
            List_ShownText.ClipList.Clear()
        Else
            List_ShownText.ClipList.Reverse()
        End If

    End Sub

    Private Sub TxtStartIndex_TextChanged(sender As Object, e As EventArgs) Handles TxtStartIndex.TextChanged
        If Not Loading Then
            If TxtStartIndex.Text = "" Then
                List_Input()
                Exit Sub
            End If

            Dim Result As Boolean
            Dim Num As Integer
            Result = Integer.TryParse(TxtStartIndex.Text, Num)
            If Result Then
                If (0 <= Num And Num <= 100000) Then
                    List_Input()
                Else
                    TxtStartIndex.Text = List_ShownText.StartIndex
                    TxtStartIndex.SelectionStart = TxtStartIndex.TextLength
                    Beep()
                End If
            Else
                TxtStartIndex.Text = List_ShownText.StartIndex
                TxtStartIndex.SelectionStart = TxtStartIndex.TextLength
                Beep()
            End If
        End If
    End Sub

    Private Sub BtnInsertCrLf_Click(sender As Object, e As EventArgs) Handles BtnInsertCrLf.Click
        TxtAdd.SelectedText = "↲"
        Me.ActiveControl = TxtAdd
        TxtAdd.SelectionLength = 0
    End Sub

    Private Sub BtnAddFront_Click(sender As Object, e As EventArgs) Handles BtnAddFront.Click
        If TxtAdd.Text <> "" Then
            LstClip.Items.Insert(0, TxtAdd.Text)
            LstClip.SelectedIndex = 0
            List_Input(0, TxtAdd.Text)
            TxtAdd.Text = ""
        Else
            Beep()
        End If
    End Sub

    Private Sub BtnAddEnd_Click(sender As Object, e As EventArgs) Handles BtnAddEnd.Click
        If TxtAdd.Text <> "" Then
            LstClip.Items.Add(TxtAdd.Text)
            LstClip.SelectedIndex = LstClip.Items.Count - 1
            List_Input(LstClip.Items.Count - 1, TxtAdd.Text)
            TxtAdd.Text = ""
        Else
            Beep()
        End If
    End Sub

    Private Sub BtnAddSelected_Click(sender As Object, e As EventArgs) Handles BtnAddSelected.Click
        If TxtAdd.Text <> "" Then
            Dim Index As Integer = LstClip.SelectedIndex
            LstClip.Items.Insert(Index, TxtAdd.Text)
            List_Input(Index, TxtAdd.Text)
            TxtAdd.Text = ""
        Else
            Beep()
        End If
    End Sub

    Private Sub ChkLoop_List_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLoop_List.CheckedChanged
        If Not Loading Then
            List_Input()
        End If
    End Sub

    Private Sub BtnDeleteSelected_Click(sender As Object, e As EventArgs) Handles BtnDeleteSelected.Click
        If LstClip.SelectedIndex <> -1 Then
            Dim Index As Integer = LstClip.SelectedIndex
            If Index = LstClip.Items.Count - 1 Then
                LstClip.Items.RemoveAt(Index)
                LstClip.SelectedIndex = LstClip.Items.Count - 1
            Else
                LstClip.Items.RemoveAt(Index)
                LstClip.SelectedIndex = Index
            End If
            List_Input(Index)
        Else
            Beep()
        End If
    End Sub

    Private Sub BtnDeleteAll_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll.Click
        Dim Ans = MsgBox("本当に全て削除しますか?", MessageBoxIcon.Exclamation Or MessageBoxButtons.YesNo, "AutoClip - 削除の確認")
        If Ans = MsgBoxResult.Yes Then
            LstClip.Items.Clear()
            List_Input(True)
        End If
    End Sub

    Private Sub BtnReverse_Click(sender As Object, e As EventArgs) Handles BtnReverse.Click
        LstClip.Items.Clear()
        For i As Integer = 0 To List_ShownText.Count - 1
            LstClip.Items.Add(List_ShownText.ClipList(List_ShownText.Count - i - 1))
        Next
        List_Input(False)
    End Sub
    Private Sub BtnChangeStartIndex_Click(sender As Object, e As EventArgs) Handles BtnChangeStartIndex.Click
        If LstClip.SelectedIndex >= 0 Then
            TxtStartIndex.Text = LstClip.SelectedIndex + 1
        End If
    End Sub
#End Region

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        '二重起動の防止
        ObjMutex = New Threading.Mutex(False, "AutoClip")
        If ObjMutex.WaitOne(0, False) = False Then
            MsgBox("既にAutoClipが起動しています。", MessageBoxButtons.OK Or MessageBoxIcon.Exclamation, "AutoClip - 二重起動エラー")
            Me.Close()
        End If

        Loading = True

        Dim IniPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & IniRelativePath '実行ファイルのあるフォルダのパスを格納

        Dim Mode_IniText As New Mode.Text(False)
        Dim Count_IniText As New Count.Text(False)
        Dim List_IniText As New Rist.Text(False)

        If IO.File.Exists(IniPath) Then
            'iniファイルから読み込み
            Mode_IniText = Mode.ReadIni(IniPath)
            Count_IniText = Count.ReadIni(IniPath)
            List_IniText = Rist.ReadIni(IniPath)

            If Mode.IsValidText(Mode_IniText) And Count.IsValidText(Count_IniText) And Rist.IsValidIni(List_IniText) Then
                List_IniText.ClipList = IniToData(List_IniText.ClipList)
                GoTo Show
            Else
                MsgBox("iniファイルが破損しているため、" & ControlChars.CrLf & "デフォルトの初期値を読み込みます。",
                        MessageBoxButtons.OK Or MessageBoxIcon.Error,
                        "AutoClip - 読み込みエラー")
            End If
        Else
            IO.File.CreateText(IniPath)
        End If

        'デフォルトの初期値を格納
        Mode_IniText = Mode.DefaultText()
        Count_IniText = Count.DefaultText()
        List_IniText = Rist.DefaultText()
        'iniファイルに書き込み
        Mode.WriteIni(IniPath, Mode_IniText)
        Count.WriteIni(IniPath, Count_IniText)
        Rist.WriteIni(IniPath, List_IniText)
Show:
        SucceedMode = Mode.ToData(Mode_IniText)
        Count_ShownText = Count_IniText
        Count_SucceedData = Count.ToData(Count_IniText)
        List_ShownText = List_IniText
        List_SucceedData = Rist.ToData(List_IniText)

        '画面に表示
        Select Case SucceedMode.Mode
            Case 1
                TbcSelect.SelectedIndex = 0
                Count_Resize()
            Case 2
                TbcSelect.SelectedIndex = 1
                List_Resize()
        End Select
        Count_Show()
        List_Show(True)

        '常に前面に表示フラグ切り替え
        Form_TopMost = False

        'ロード中フラグ解除
        Loading = False
    End Sub

    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'ミューテックスを開放
        ObjMutex.Close()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        'Modeを格納
        Dim Cash As New Mode.Data(False)
        If TbcSelect.SelectedTab.Equals(TbpCount) Then
            Cash.Mode = 1
        ElseIf TbcSelect.SelectedTab.Equals(TbpList) Then
            Cash.Mode = 2
        End If
        SucceedMode = Cash

        Select Case Cash.Mode
            Case 1
                If Count.IsValidText(Count_ShownText) Then
                    Count_SucceedData = Count.ToData(Count_ShownText)
                Else
                    GoTo Err
                End If
            Case 2
                If Rist.IsValidText(List_ShownText) Then
                    List_SucceedData = Rist.ToData(List_ShownText)
                Else
                    GoTo Err
                End If
        End Select

        Dim IniPath As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & IniRelativePath '実行ファイルのあるフォルダのパスを格納

        '空のiniファイルを作成
        If IO.File.Exists(IniPath) Then
            Using IniFile = New IO.StreamWriter(IniPath, False, System.Text.Encoding.Default)
                IniFile.Write("")
            End Using
        Else
            IO.File.CreateText(IniPath)
        End If

        'Mode情報を書き込み用に変換
        Dim Mode_WriteText As Mode.Text = Mode.ToText(SucceedMode)
        'iniファイルに書き込み
        Mode.WriteIni(IniPath, Mode_WriteText)
        Count.WriteIni(IniPath, Count.ToText(Count_SucceedData))
        Rist.WriteIni(IniPath, Rist.ToText(List_SucceedData))

        MsgBox("現在の設定を保存しました。" & ControlChars.CrLf & "オートコピーを開始します。",
                MessageBoxButtons.OK Or MessageBoxIcon.Information,
                "AutoClip - 設定の保存完了")

        '現在のフォームへの入力を制限してオートコピー用のフォームを表示
        Me.Enabled = False
        FrmClip.Show(Me)

        Exit Sub
Err:
        MsgBox("不正な値が入力されているため、" & ControlChars.CrLf & "オートコピーを開始できません。",
                MessageBoxButtons.OK Or MessageBoxIcon.Exclamation,
                "AutoClip - 入力エラー")
    End Sub

    Private Sub TbcSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TbcSelect.SelectedIndexChanged
        Select Case TbcSelect.SelectedIndex
            Case 0
                Count_Resize()
            Case 1
                List_Resize()
        End Select
    End Sub

    Private Sub BtnReadFile_Click(sender As Object, e As EventArgs) Handles BtnReadFile.Click
        'ダイアログボックスの初期設定
        With OpenFileDialog
            .Title = "AutoClip - テキストファイルの選択"
            .Filter = "テキストファイル(.txt)|*.txt"
        End With
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Dim TxtPath As String = OpenFileDialog.FileName
            Dim Ans = MsgBox("各文字列の末尾に改行文字を追加しますか?",
                    MessageBoxIcon.Exclamation Or MessageBoxButtons.YesNoCancel,
                    "AutoClip - 改行文字の追加")
            If Ans = DialogResult.Cancel Then
                Exit Sub
            Else
                Dim ReadList = New List(Of String)()
                Dim ReadTxt As String
                If Ans = DialogResult.Yes Then
                    Using TxtReader = New IO.StreamReader(TxtPath)
                        While Not TxtReader.EndOfStream
                            ReadTxt = TxtReader.ReadLine()
                            ReadTxt += "↲"
                            ReadList.Add(ReadTxt)
                        End While
                    End Using
                ElseIf Ans = DialogResult.No Then
                    Using TxtReader = New IO.StreamReader(TxtPath)
                        While Not TxtReader.EndOfStream
                            ReadTxt = TxtReader.ReadLine()
                            If ReadTxt = "" Then
                                ReadTxt += " "
                            End If
                            ReadList.Add(ReadTxt)
                        End While
                    End Using
                End If

                List_ShownText.StartIndex = "1"
                List_ShownText.Count = ReadList.Count
                List_ShownText.ClipList = ReadList
                List_Show(True)
            End If
        End If
    End Sub

    Private Sub ChkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTopMost.CheckedChanged
        'フラグ切り替え
        If ChkTopMost.Checked Then
            Form_TopMost = True
        Else
            Form_TopMost = False
        End If
        Me.TopMost = Form_TopMost

    End Sub


End Class
