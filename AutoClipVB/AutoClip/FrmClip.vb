Imports System.ComponentModel

Public Class FrmClip
    '一時停止フラグ
    Private Pause As Boolean = False
    'CloseForm起動フラグ
    Private CloseFlag As Boolean = False
    'ダイアログボックスに渡す引数
    Public CloseMessage As String

    'モード及びオートコピー用のデータとインデックス
    Private RunMode As New Mode.Data(False)
    Private Count_Data As New Count.Data(False)
    Private Count_ClipData As New Count.ClsForClip
    Private List_Data As New Rist.Data(False)
    Private List_ClipData As New List(Of String)
    Private NowIndex As Integer

    Private Sub CloseForm(Message As String, FWidth As Integer)
        'ダイアログボックスの幅を設定
        FrmAutoCloseMsg.Width = FWidth
        'キーボードフックのイベントハンドラーを破棄
        KeyboardHooker1.Dispose()
        'フラグ立てる(ダイアログボックスの多重起動防止)
        CloseFlag = True
        CloseMessage = Message
        'ダイアログボックスの表示
        FrmAutoCloseMsg.ShowDialog()
        FrmMain.Enabled = True
        'フォームを閉じる
        Me.Close()
    End Sub

    Private Sub FrmClip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'データの格納
        RunMode = FrmMain.SucceedMode

        'モードによるインデックスの設定
        Select Case RunMode.Mode
            Case 1
                LblList.Visible = False
                Count_Data = FrmMain.Count_SucceedData
                Count_ClipData.ToClipData(Count_Data.Clip)
                NowIndex = Count_Data.Init

                If Count_Data.Luup Then

                    If Count_Data.Up Then
                        LblMode.Text = "カウントアップ(ループあり)"
                    Else
                        LblMode.Text = "カウントダウン(ループあり)"
                    End If
                Else
                    If Count_Data.Up Then
                        LblMode.Text = "カウントアップ(ループなし)"
                    Else
                        LblMode.Text = "カウントダウン(ループなし)"
                    End If
                End If
                Count_Show()
            Case 2
                LblList.Visible = True
                List_Data = FrmMain.List_SucceedData
                List_ClipData = Rist.ToClipText(List_Data.ClipList)
                NowIndex = List_Data.StartIndex - 1

                If List_Data.Luup Then
                    LblMode.Text = "リスト(ループあり)"
                Else
                    LblMode.Text = "リスト(ループなし)"
                End If
                List_Show()
        End Select
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        '一時停止フラグの切り替え
        If Pause Then
            Pause = False
            BtnPause.Text = "オートコピーの一時停止(&C)"
            Select Case RunMode.Mode
                Case 1
                    Count_Show()
                Case 2
                    List_Show()
            End Select
        Else
            Pause = True
            BtnPause.Text = "オートコピーを再開(&C)"
            BtnBef.Enabled = False
            BtnNext.Enabled = False
            LblBef.BackColor = SystemColors.Control
            LblNow.BackColor = SystemColors.Control
            LblNext.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub Count_Show()
        With Count_Data
            If .Luup Then

                If Count_Data.Up Then
                    'LblBefを表示
                    Dim Now As Integer = NowIndex
                    If (NowIndex - .Min - .Stp) < 0 Then
                        Now += .Max - .Min + 1
                    End If
                    LblBef.Text = Count_ClipData.ToClipDisp((Now - .Min - .Stp) Mod (.Max - .Min + 1) + .Min, .Max)
                    BtnBef.Enabled = True
                    LblBef.BackColor = SystemColors.Window
                    'LblNowを表示
                    LblNow.Text = Count_ClipData.ToClipDisp(NowIndex, .Max)
                    LblNow.BackColor = SystemColors.Window
                    'LblNextを表示
                    LblNext.Text = Count_ClipData.ToClipDisp((NowIndex - .Min + .Stp) Mod (.Max - .Min + 1) + .Min, .Max)
                    BtnNext.Enabled = True
                    LblNext.BackColor = SystemColors.Window
                Else
                    'LblBefを表示
                    LblBef.Text = Count_ClipData.ToClipDisp((NowIndex - .Min + .Stp) Mod (.Max - .Min + 1) + .Min, .Max)
                    BtnBef.Enabled = True
                    LblBef.BackColor = SystemColors.Window
                    'LblNowを表示
                    LblNow.Text = Count_ClipData.ToClipDisp(NowIndex, .Max)
                    LblNow.BackColor = SystemColors.Window
                    'LblNextを表示
                    Dim Now As Integer = NowIndex
                    If (NowIndex - .Min - .Stp) < 0 Then
                        Now += .Max - .Min + 1
                    End If
                    LblNext.Text = Count_ClipData.ToClipDisp((Now - .Min - .Stp) Mod (.Max - .Min + 1) + .Min, .Max)
                    BtnNext.Enabled = True
                    LblNext.BackColor = SystemColors.Window
                End If

            Else

                If Count_Data.Up Then
                    'LblBefを表示
                    If (NowIndex - .Stp) < .Min Then
                        LblBef.Text = "(指定範囲外)"
                        BtnBef.Enabled = False
                        LblBef.BackColor = SystemColors.Control
                    Else
                        LblBef.Text = Count_ClipData.ToClipDisp(NowIndex - .Stp, .Max)
                        BtnBef.Enabled = True
                        LblBef.BackColor = SystemColors.Window
                    End If
                    'LblNowを表示
                    LblNow.Text = Count_ClipData.ToClipDisp(NowIndex, .Max)
                    LblNow.BackColor = SystemColors.Window
                    'LblNextを表示
                    If (NowIndex + .Stp) > .Max Then
                        LblNext.Text = "(指定範囲外)"
                        BtnNext.Enabled = False
                        LblNext.BackColor = SystemColors.Control
                    Else
                        LblNext.Text = Count_ClipData.ToClipDisp(NowIndex + .Stp, .Max)
                        BtnNext.Enabled = True
                        LblNext.BackColor = SystemColors.Window
                    End If
                Else
                    'LblBefを表示
                    If (NowIndex + .Stp) > .Max Then
                        LblBef.Text = "(指定範囲外)"
                        BtnBef.Enabled = False
                        LblBef.BackColor = SystemColors.Control
                    Else
                        LblBef.Text = Count_ClipData.ToClipDisp(NowIndex + .Stp, .Max)
                        BtnBef.Enabled = True
                        LblBef.BackColor = SystemColors.Window
                    End If
                    'LblNowを表示
                    LblNow.Text = Count_ClipData.ToClipDisp(NowIndex, .Max)
                    LblNow.BackColor = SystemColors.Window
                    'LblNextを表示
                    If (NowIndex - .Stp) < .Min Then
                        LblNext.Text = "(指定範囲外)"
                        BtnNext.Enabled = False
                        LblNext.BackColor = SystemColors.Control
                    Else
                        LblNext.Text = Count_ClipData.ToClipDisp(NowIndex - .Stp, .Max)
                        BtnNext.Enabled = True
                        LblNext.BackColor = SystemColors.Window
                    End If

                End If

            End If
        End With
    End Sub
    Private Sub Count_AutoClip()
        'クリップボードにコピー
        Clipboard.SetText(Count_ClipData.ToClipText(NowIndex, Count_Data.Max))

        With Count_Data
            '次の数値をNowIndexに格納
            If .Luup Then

                If Count_Data.Up Then

                    NowIndex = (NowIndex - .Min + .Stp) Mod (.Max - .Min + 1) + .Min
                Else
                    Dim Now As Integer = NowIndex
                    If (NowIndex - .Min - .Stp) < 0 Then
                        Now += .Max - .Min + 1
                    End If
                    NowIndex = (Now - .Min - .Stp) Mod (.Max - .Min + 1) + .Min
                End If

            Else

                If Count_Data.Up Then
                    If (NowIndex + .Stp) > .Max Then
                        GoTo Finish 'オートコピーを終了
                    Else
                        NowIndex += .Stp
                    End If
                Else
                    If (NowIndex - .Stp) < .Min Then
                        GoTo Finish 'オートコピーを終了
                    Else
                        NowIndex -= .Stp
                    End If
                End If

            End If

            Exit Sub
        End With

Finish:
        CloseForm("指定範囲の最後の値を貼り付けました。" & ControlChars.CrLf & "オートコピーを終了します。", 300)

    End Sub

    Private Sub List_Show()
        LblList.Text = (NowIndex + 1).ToString() + "/" + List_Data.Count.ToString()
        With List_Data
            If .Luup Then
                'LblBefを表示
                If NowIndex = 0 Then
                    LblBef.Text = .ClipList(.Count - 1)
                    BtnBef.Enabled = True
                    LblBef.BackColor = SystemColors.Window
                Else
                    LblBef.Text = .ClipList(NowIndex - 1)
                    BtnBef.Enabled = True
                    LblBef.BackColor = SystemColors.Window
                End If
                'LblNowを表示
                LblNow.Text = .ClipList(NowIndex)
                LblNow.BackColor = SystemColors.Window
                'LblNextを表示
                If NowIndex = .Count - 1 Then
                    LblNext.Text = .ClipList(0)
                    BtnNext.Enabled = True
                    LblNext.BackColor = SystemColors.Window
                Else
                    LblNext.Text = .ClipList(NowIndex + 1)
                    BtnNext.Enabled = True
                    LblNext.BackColor = SystemColors.Window
                End If
            Else
                'LblBefを表示
                If NowIndex = 0 Then
                    LblBef.Text = "(指定範囲外)"
                    BtnBef.Enabled = False
                    LblBef.BackColor = SystemColors.Control
                Else
                    LblBef.Text = .ClipList(NowIndex - 1)
                    BtnBef.Enabled = True
                    LblBef.BackColor = SystemColors.Window
                End If
                'LblNowを表示
                LblNow.Text = .ClipList(NowIndex)
                LblNow.BackColor = SystemColors.Window
                'LblNextを表示
                If NowIndex = .Count - 1 Then
                    LblNext.Text = "(指定範囲外)"
                    BtnNext.Enabled = False
                    LblNext.BackColor = SystemColors.Control
                Else
                    LblNext.Text = .ClipList(NowIndex + 1)
                    BtnNext.Enabled = True
                    LblNext.BackColor = SystemColors.Window
                End If
            End If
        End With
    End Sub
    Private Sub List_AutoClip()
        'クリップボードにコピー
        Clipboard.SetText(List_ClipData(NowIndex))

        With List_Data
            If .Luup = True Then
                If NowIndex = List_Data.Count - 1 Then
                    NowIndex = 0
                Else
                    NowIndex += 1
                End If
            Else
                If NowIndex = List_Data.Count - 1 Then
                    GoTo Finish
                Else
                    NowIndex += 1
                End If
            End If
            Exit Sub
        End With
Finish:
        CloseForm("指定範囲の最後の値を貼り付けました。" & ControlChars.CrLf & "オートコピーを終了します。", 300)
    End Sub

    Private Sub BtnBef_Click(sender As Object, e As EventArgs) Handles BtnBef.Click
        Select Case RunMode.Mode
            Case 1
                With Count_Data
                    '前の数値をNowIndexに格納
                    If .Luup Then

                        If Count_Data.Up Then
                            Dim Now As Integer = NowIndex
                            If (NowIndex - .Min - .Stp) < 0 Then
                                Now += .Max - .Min + 1
                            End If
                            NowIndex = (Now - .Min - .Stp) Mod (.Max - .Min + 1) + .Min
                        Else
                            NowIndex = (NowIndex - .Min + .Stp) Mod (.Max - .Min + 1) + .Min
                        End If
                    Else
                        If Count_Data.Up Then
                            NowIndex -= .Stp
                        Else
                            NowIndex += .Stp
                        End If
                    End If
                End With

                '画面に表示
                Count_Show()

            Case 2
                With List_Data
                    If .Luup Then
                        If NowIndex = 0 Then
                            NowIndex = .Count - 1
                        Else
                            NowIndex -= 1
                        End If
                    Else
                        NowIndex -= 1
                    End If
                End With

                '画面に表示
                List_Show()
        End Select
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Select Case RunMode.Mode
            Case 1
                With Count_Data
                    '次の数値をNowIndexに格納
                    If .Luup Then
                        If Count_Data.Up Then
                            NowIndex = (NowIndex - .Min + .Stp) Mod (.Max - .Min + 1) + .Min
                        Else
                            Dim Now As Integer = NowIndex
                            If (NowIndex - .Min - .Stp) < 0 Then
                                Now += .Max - .Min + 1
                            End If
                            NowIndex = (Now - .Min - .Stp) Mod (.Max - .Min + 1) + .Min
                        End If
                    Else
                        If Count_Data.Up Then
                            NowIndex += .Stp
                        Else
                            NowIndex -= .Stp
                        End If

                    End If
                End With

                '画面に表示
                Count_Show()

            Case 2
                With List_Data
                    If .Luup Then
                        If NowIndex = .Count - 1 Then
                            NowIndex = 0
                        Else
                            NowIndex += 1
                        End If
                    Else
                        NowIndex += 1
                    End If
                End With

                '画面に表示
                List_Show()
        End Select
    End Sub
    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        'オートコピーを終了
        CloseForm("オートコピーを終了します。", 240)
    End Sub

    'キーボードフック(グローバルフック)とやらで[Ctrl+V]のキー入力を検知
    WithEvents KeyboardHooker1 As New KeyboardHooker
    Sub KeybordHooker1_KeyDown(sender As Object, e As KeyBoardHookerEventArgs) Handles KeyboardHooker1.KeyDown
        If Pause = False AndAlso Control.ModifierKeys = Keys.Control AndAlso e.VkCode = Keys.V Then

#If DEBUG Then
            'Debug用
            Debug.WriteLine("Pressed[Ctrl+V]!")
#End If
            'モードに応じてオートコピーを発動
            Select Case RunMode.Mode
                Case 1
                    Count_AutoClip()
                    Count_Show()
                Case 2
                    List_AutoClip()
                    List_Show()
            End Select
        End If

    End Sub

    Private Sub FrmClip_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If CloseFlag = False Then
            CloseForm("オートコピーを終了します。", 240)
        End If
    End Sub

End Class