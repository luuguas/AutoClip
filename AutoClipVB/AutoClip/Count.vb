Public Module Count

    ''' <summary>
    ''' Countﾓｰﾄﾞのﾃﾞｰﾀをiniﾌｧｲﾙに保存するための構造体
    ''' </summary>
    Public Structure Text
        Public Min As String
        Public Max As String
        Public Stp As String
        Public Init As String
        Public Up As String
        Public Down As String
        Public Luup As String
        Public Clip As String
        Public Sub New(Cash As Boolean)
            'デフォルト値で初期化
            Min = "1"
            Max = "100"
            Stp = "1"
            Init = "1"
            Up = "True"
            Down = "False"
            Luup = "False"
            Clip = "#\f"
        End Sub
    End Structure

    ''' <summary>
    ''' Countﾓｰﾄﾞのﾃﾞｰﾀをｱﾌﾟﾘに表示するための構造体
    ''' </summary>
    Public Structure Data
        Public Min As Integer
        Public Max As Integer
        Public Stp As Integer
        Public Init As Integer
        Public Up As Boolean
        Public Down As Boolean
        Public Luup As Boolean
        Public Clip As String
        Public Sub New(Cash As Boolean)
            'デフォルト値で初期化
            Min = 1
            Max = 100
            Stp = 1
            Init = 1
            Up = True
            Down = False
            Luup = False
            Clip = "#\f"
        End Sub
    End Structure

    ''' <summary>
    ''' Countﾓｰﾄﾞでｺﾋﾟｰする文字列をﾃﾞｰﾀ変換＆埋込済み文字列変換するｸﾗｽ
    ''' </summary>
    Class ClsForClip
        Private Structure Block
            Public Type As UInteger 'ﾀｲﾌﾟ( 0:通常文字列(\\を含む) / 1:\d / 2:\f / 3:\n / 11~20:\1~\0 )
            Public NormalText As String 'Type=0 の時の文字列
        End Structure
        Private Blocks As New List(Of Block)
        Public Sub New()
            Blocks.Clear()
        End Sub

        ''' <summary>
        ''' ﾕｰｻﾞｰの入力文字列からﾃﾞｰﾀに変換してBlocksに格納
        ''' </summary>
        ''' <param name="Clip">変換する文字列</param>
        Public Sub ToClipData(Clip As String)
            Blocks.Clear()
            Dim X As Block 'Blocksに要素を追加するための使いまわし
            Dim ii As Integer
            If Clip.Substring(0, 1) = "\" Then
                Select Case Clip.Substring(1, 1)
                    Case "\"
                        X.Type = 0
                        X.NormalText = "\"
                    Case "d"
                        X.Type = 1
                        X.NormalText = ""
                    Case "f"
                        X.Type = 2
                        X.NormalText = ""
                    Case "n"
                        X.Type = 3
                        X.NormalText = ControlChars.CrLf
                    Case "0"
                        X.Type = 20
                        X.NormalText = ""
                    Case "1"
                        X.Type = 11
                        X.NormalText = ""
                    Case "2"
                        X.Type = 12
                        X.NormalText = ""
                    Case "3"
                        X.Type = 13
                        X.NormalText = ""
                    Case "4"
                        X.Type = 14
                        X.NormalText = ""
                    Case "5"
                        X.Type = 15
                        X.NormalText = ""
                    Case "6"
                        X.Type = 16
                        X.NormalText = ""
                    Case "7"
                        X.Type = 17
                        X.NormalText = ""
                    Case "8"
                        X.Type = 18
                        X.NormalText = ""
                    Case "9"
                        X.Type = 19
                        X.NormalText = ""
                    Case "0"
                        X.Type = 20
                        X.NormalText = ""
                    Case Else 'IsValidClipで確かめてたらここには当てはまらないはず...
                        X.Type = 0
                        X.NormalText = ""
                End Select
                Blocks.Add(X)
                ii = 2
            Else
                X.Type = 0
                X.NormalText = Clip.Substring(0, 1)
                Blocks.Add(X)
                ii = 1
            End If
            For i = ii To Clip.Length() - 1
                If Clip.Substring(i, 1) = "\" Then
                    Select Case Clip.Substring(i + 1, 1)
                        Case "\"
                            If Blocks(Blocks.Count() - 1).Type = 0 Then
                                X.Type = 0
                                X.NormalText = Blocks(Blocks.Count() - 1).NormalText + "\"
                                Blocks(Blocks.Count() - 1) = X
                            Else
                                X.Type = 0
                                X.NormalText = "\"
                                Blocks.Add(X)
                            End If
                        Case "d"
                            X.Type = 1
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "f"
                            X.Type = 2
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "n"
                            X.Type = 3
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "1"
                            X.Type = 11
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "2"
                            X.Type = 12
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "3"
                            X.Type = 13
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "4"
                            X.Type = 14
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "5"
                            X.Type = 15
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "6"
                            X.Type = 16
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "7"
                            X.Type = 17
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "8"
                            X.Type = 18
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "9"
                            X.Type = 19
                            X.NormalText = ""
                            Blocks.Add(X)
                        Case "0"
                            X.Type = 20
                            X.NormalText = ""
                            Blocks.Add(X)
                    End Select
                    i += 1
                Else
                    If Blocks(Blocks.Count() - 1).Type = 0 Then
                        X.Type = 0
                        X.NormalText = Blocks(Blocks.Count() - 1).NormalText + Clip.Substring(i, 1)
                        Blocks(Blocks.Count() - 1) = X
                    Else
                        X.Type = 0
                        X.NormalText = Clip.Substring(i, 1)
                        Blocks.Add(X)
                    End If
                End If
            Next
        End Sub

        ''' <summary>
        ''' 予め変換されたﾃﾞｰﾀをもとに引数を埋め込んだ文字列(コピー用)を返す
        ''' </summary>
        ''' <param name="EmbedNum">埋め込む数値</param>
        ''' <param name="Max">範囲の最大値(\f用)</param>>
        ''' <returns></returns>
        Public Function ToClipText(EmbedNum As UInteger, Max As Integer) As String
            Dim Ret As String = ""
            For Each PickedBlock As Block In Blocks
                Select Case PickedBlock.Type
                    Case 0 '通常文字列
                        Ret += PickedBlock.NormalText
                    Case 1 '\d
                        Ret += EmbedNum.ToString()
                    Case 2 '\f
                        Ret += EmbedNum.ToString(New String("0", Max.ToString().Length()))
                    Case 3 '\n
                        Ret += ControlChars.CrLf
                    Case 11 '\1
                        Ret += EmbedNum.ToString(New String("0", 1))
                    Case 12 '\2
                        Ret += EmbedNum.ToString(New String("0", 2))
                    Case 13 '\3
                        Ret += EmbedNum.ToString(New String("0", 3))
                    Case 14 '\4
                        Ret += EmbedNum.ToString(New String("0", 4))
                    Case 15 '\5
                        Ret += EmbedNum.ToString(New String("0", 5))
                    Case 16 '\6
                        Ret += EmbedNum.ToString(New String("0", 6))
                    Case 17 '\7
                        Ret += EmbedNum.ToString(New String("0", 7))
                    Case 18 '\8
                        Ret += EmbedNum.ToString(New String("0", 8))
                    Case 19 '\9
                        Ret += EmbedNum.ToString(New String("0", 9))
                    Case 20 '\0
                        Ret += EmbedNum.ToString(New String("0", 10))
                End Select
            Next
            Return Ret
        End Function

        ''' <summary>
        ''' 予め変換されたﾃﾞｰﾀをもとに引数を埋め込んだ文字列(表示用)を返す
        ''' </summary>
        ''' <param name="EmbedNum">埋め込む数値</param>
        ''' <param name="Max">範囲の最大値(\f用)</param>>
        ''' <returns></returns>
        Public Function ToClipDisp(EmbedNum As UInteger, Max As Integer) As String
            Dim Ret As String = ""
            For Each PickedBlock As Block In Blocks
                Select Case PickedBlock.Type
                    Case 0 '通常文字列
                        Ret += PickedBlock.NormalText
                    Case 1 '\d
                        Ret += EmbedNum.ToString()
                    Case 2 '\f
                        Ret += EmbedNum.ToString(New String("0", Max.ToString().Length()))
                    Case 3 '\n
                        Ret += "↲"
                    Case 11 '\1
                        Ret += EmbedNum.ToString(New String("0", 1))
                    Case 12 '\2
                        Ret += EmbedNum.ToString(New String("0", 2))
                    Case 13 '\3
                        Ret += EmbedNum.ToString(New String("0", 3))
                    Case 14 '\4
                        Ret += EmbedNum.ToString(New String("0", 4))
                    Case 15 '\5
                        Ret += EmbedNum.ToString(New String("0", 5))
                    Case 16 '\6
                        Ret += EmbedNum.ToString(New String("0", 6))
                    Case 17 '\7
                        Ret += EmbedNum.ToString(New String("0", 7))
                    Case 18 '\8
                        Ret += EmbedNum.ToString(New String("0", 8))
                    Case 19 '\9
                        Ret += EmbedNum.ToString(New String("0", 9))
                    Case 20 '\0
                        Ret += EmbedNum.ToString(New String("0", 10))
                End Select
            Next
            Return Ret
        End Function

    End Class

    ''' <summary>
    ''' Countﾓｰﾄﾞのﾃﾞﾌｫﾙﾄの初期値をCount.Text構造体で返す
    ''' </summary>
    Public Function DefaultText() As Count.Text
        Dim TextStruct As New Count.Text(False)
        Return TextStruct
    End Function

    ''' <summary>
    ''' Countﾓｰﾄﾞのﾃﾞﾌｫﾙﾄの初期値をCount.Data構造体で返す
    ''' </summary>
    Public Function DefaultData() As Count.Data
        Dim DataStruct As New Count.Data(False)
        Return DataStruct
    End Function

    ''' <summary>
    ''' 指定したiniﾌｧｲﾙからCountﾓｰﾄﾞのﾃﾞｰﾀを読み込みCount.Text構造体で返す
    ''' </summary>
    ''' <param name="IniPath">読み込むiniﾌｧｲﾙのﾌﾙﾊﾟｽ</param>
    Public Function ReadIni(IniPath As String) As Count.Text
        Dim Ini As New ClsIni(IniPath)
        Dim TextStruct As New Count.Text(False)
        TextStruct.Min = Ini.GetProfileString("Count_Init", "MIN", "Error")
        TextStruct.Max = Ini.GetProfileString("Count_Init", "MAX", "Error")
        TextStruct.Stp = Ini.GetProfileString("Count_Init", "STEP", "Error")
        TextStruct.Init = Ini.GetProfileString("Count_Init", "INIT", "Error")
        TextStruct.Up = Ini.GetProfileString("Count_Init", "UP", "Error")
        TextStruct.Down = Ini.GetProfileString("Count_Init", "DOWN", "Error")
        TextStruct.Luup = Ini.GetProfileString("Count_Init", "LOOP", "Error")
        TextStruct.Clip = Ini.GetProfileString("Count_Init", "CLIP", "Error")
        Return TextStruct
    End Function

    ''' <summary>
    ''' 指定したiniﾌｧｲﾙにCountﾓｰﾄﾞのﾃﾞｰﾀを書き込む
    ''' </summary>
    ''' <param name="IniPath">ﾃﾞｰﾀを保存するiniﾌｧｲﾙのﾌﾙﾊﾟｽ</param>
    ''' <param name="TextStruct">保存するﾃﾞｰﾀ(Count.Text構造体)</param>
    Public Sub WriteIni(IniPath As String, TextStruct As Count.Text)
        Dim Ini As New ClsIni(IniPath)
        Ini.WriteProfileString("Count_Init", "MIN", TextStruct.Min)
        Ini.WriteProfileString("Count_Init", "MAX", TextStruct.Max)
        Ini.WriteProfileString("Count_Init", "STEP", TextStruct.Stp)
        Ini.WriteProfileString("Count_Init", "INIT", TextStruct.Init)
        Ini.WriteProfileString("Count_Init", "UP", TextStruct.Up)
        Ini.WriteProfileString("Count_Init", "DOWN", TextStruct.Down)
        Ini.WriteProfileString("Count_Init", "LOOP", TextStruct.Luup)
        Ini.WriteProfileString("Count_Init", "CLIP", TextStruct.Clip)
    End Sub

    ''' <summary>
    ''' Count.Text構造体の情報をCount.Data構造体で返す
    ''' </summary>
    ''' <param name="TextStruct">変換するCount.Text構造体</param>
    Public Function ToData(TextStruct As Count.Text) As Count.Data
        Dim DataStruct As New Count.Data(False)
        DataStruct.Min = Integer.Parse(TextStruct.Min)
        DataStruct.Max = Integer.Parse(TextStruct.Max)
        DataStruct.Stp = Integer.Parse(TextStruct.Stp)
        DataStruct.Init = Integer.Parse(TextStruct.Init)
        If (TextStruct.Up = "True") Then
            DataStruct.Up = True
            DataStruct.Down = False
        Else
            DataStruct.Up = False
            DataStruct.Down = True
        End If
        If (TextStruct.Luup = "True") Then
            DataStruct.Luup = True
        Else
            DataStruct.Luup = False
        End If
        DataStruct.Clip = TextStruct.Clip
        Return DataStruct
    End Function

    ''' <summary>
    ''' Count.Data構造体のﾃﾞｰﾀをCount.Text構造体で返す
    ''' </summary>
    ''' <param name="DataStruct">変換するCount.Data構造体</param>
    Public Function ToText(DataStruct As Count.Data) As Count.Text
        Dim TextStruct As New Count.Text(False)
        TextStruct.Min = DataStruct.Min.ToString()
        TextStruct.Max = DataStruct.Max.ToString()
        TextStruct.Stp = DataStruct.Stp.ToString()
        TextStruct.Init = DataStruct.Init.ToString()
        If (DataStruct.Up) Then
            TextStruct.Up = "True"
            TextStruct.Down = "False"
        Else
            TextStruct.Up = "False"
            TextStruct.Down = "True"
        End If
        If DataStruct.Luup Then
            TextStruct.Luup = "True"
        Else
            TextStruct.Luup = "False"
        End If
        TextStruct.Clip = DataStruct.Clip
        Return TextStruct
    End Function

    ''' <summary>
    ''' 引数のCount.Text構造体がCount.Data構造体に変換可能ならTrueを返す
    ''' </summary>
    ''' <param name="TextStruct">変換可能か判定するCount.Text構造体</param>
    ''' <returns></returns>
    Public Function IsValidText(TextStruct As Count.Text) As Boolean
        Dim Result As Boolean
        Dim Num As Integer

        Result = Integer.TryParse(TextStruct.Min, Num)
        If (Result) Then
            If (Num < 0 Or 1000000000 < Num) Then
                Return False
            Else
                'OK
            End If
        Else
            Return False
        End If

        Result = Integer.TryParse(TextStruct.Max, Num)
        If (Result) Then
            If (Num < 0 Or 1000000000 < Num) Then
                Return False
            Else
                If Num < Integer.Parse(TextStruct.Min) Then
                    Return False
                Else
                    'OK
                End If
            End If
        Else
            Return False
        End If

        Result = Integer.TryParse(TextStruct.Stp, Num)
        If (Result) Then
            If (Num < 0 Or 10000 < Num) Then
                Return False
            End If
        Else
            Return False

        End If

        Result = Integer.TryParse(TextStruct.Init, Num)
        If (Result) Then
            If (Num < 0 Or 1000000000 < Num) Then
                Return False
            Else
                If Num < Integer.Parse(TextStruct.Min) Or Num > Integer.Parse(TextStruct.Max) Then
                    Return False
                Else
                    'OK
                End If
            End If
        Else
            Return False
        End If

        If (TextStruct.Up = "True") Then
            If (TextStruct.Down <> "False") Then
                Return False
            End If
        ElseIf (TextStruct.Up = "False") Then
            If (TextStruct.Down <> "True") Then
                Return False
            End If
        Else
            Return False
        End If

        If (TextStruct.Luup <> "True" And TextStruct.Luup <> "False") Then
            Return False
        End If

        If Not IsValidClip(TextStruct.Clip) Then
            Return False
        End If

        Return True
    End Function

    Private Function IsSingleDigit(Num As String) As Boolean
        If Num = "1" OrElse Num = "2" OrElse Num = "3" OrElse Num = "4" OrElse Num = "5" OrElse Num = "6" OrElse Num = "7" OrElse Num = "8" OrElse Num = "9" OrElse Num = "0" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function IsValidClip(Clip As String) As Boolean
        For i As Integer = 0 To Clip.Length() - 1
            If Clip.Substring(i, 1) = "\" Then
                If i = Clip.Length() - 1 OrElse (Clip.Substring(i + 1, 1) <> "d" AndAlso Clip.Substring(i + 1, 1) <> "f" AndAlso (Not IsSingleDigit(Clip.Substring(i + 1, 1))) AndAlso Clip.Substring(i + 1, 1) <> "\" AndAlso Clip.Substring(i + 1, 1) <> "n") Then
                    Return False
                Else
                    i += 1
                End If
            End If
        Next
        Return True
    End Function

End Module
