Module Rist 'Listだとコレクション(動的配列)と被るので...
    ''' <summary>
    ''' Listﾓｰﾄﾞのﾃﾞｰﾀをiniﾌｧｲﾙに保存するための構造体
    ''' </summary>
    Public Structure Text
        Public StartIndex As String
        Public Luup As String
        Public Count As String
        Public ClipList As List(Of String)
        Public Sub New(Cash As Boolean)
            'デフォルト値(リストは空)で初期化
            StartIndex = "1"
            Luup = "False"
            Count = "0"
            ClipList = New List(Of String)()
        End Sub
    End Structure

    ''' <summary>
    ''' Listﾓｰﾄﾞのﾃﾞｰﾀをｱﾌﾟﾘに表示するための構造体
    ''' </summary>
    Public Structure Data
        Public StartIndex As Integer
        Public Luup As Boolean
        Public Count As Integer
        Public ClipList As List(Of String)
        Public Sub New(Cash As Boolean)
            'デフォルト値(リストは空)で初期化
            StartIndex = 1
            Luup = False
            Count = 0
            ClipList = New List(Of String)()
        End Sub
    End Structure

    ''' <summary>
    ''' Countﾓｰﾄﾞでｺﾋﾟｰする文字列をﾃﾞｰﾀ変換＆埋込済み文字列変換するｸﾗｽ
    ''' </summary>
    Class ClsForClip
        Private Texts As List(Of String) 'ユーザー入力の文字列リスト

        '文字列リストで初期化
        Public Sub New(InputTexts As List(Of String))
            Texts = InputTexts
        End Sub

        ''' <summary>
        ''' オートクリップ用の文字列リストを返す
        ''' </summary>
        ''' <returns></returns>
        Public Function ToClipText() As List(Of String)
            Dim Ret = New List(Of String)()
            Dim ExText As String
            Dim Picked As String
            For Each i As String In Texts
                ExText = ""
                For j As Integer = 0 To i.Length() - 1
                    Picked = i.Substring(j, 1)
                    If Picked = "↲" Then
                        ExText += ControlChars.CrLf
                    Else
                        ExText += Picked
                    End If
                Next
                Ret.Add(ExText)
            Next
            Return Ret
        End Function

        ''' <summary>
        ''' iniファイル書き込み用の文字列リストを返す
        ''' </summary>
        ''' <returns></returns>
        Public Function ToWriteText() As List(Of String)
            Dim Ret = New List(Of String)()
            Dim ExText As String
            Dim Picked As String
            For Each i As String In Texts
                ExText = ""

                For j As Integer = 0 To i.Length() - 1
                    Picked = i.Substring(j, 1)
                    If Picked = "↲" Then
                        ExText += "\n"
                    ElseIf Picked = "↲" Then
                        ExText += "\\"
                    Else
                        ExText += Picked
                    End If
                Next
                Ret.Add(ExText)
            Next
            Return Ret
        End Function
    End Class

    ''' <summary>
    ''' 文字配列の偽・改行文字"↲"を真・改行文字に変換して返す
    ''' </summary>
    ''' <param name="ClipList"></param>
    ''' <returns></returns>
    Public Function ToClipText(ClipList As List(Of String)) As List(Of String)
        Dim ClipListData As New List(Of String)()
        Dim Str As String
        For Each i As String In ClipList
            Str = ""
            For j As Integer = 0 To i.Length() - 1
                If i.Substring(j, 1) = "↲" Then
                    Str += ControlChars.CrLf
                Else
                    Str += i.Substring(j, 1)
                End If
            Next
            ClipListData.Add(Str)
        Next
        Return ClipListData
    End Function

    ''' <summary>
    ''' Listﾓｰﾄﾞのﾃﾞﾌｫﾙﾄの初期値をRist.Text構造体で返す
    ''' </summary>
    Public Function DefaultText() As Rist.Text
        Dim TextStruct As New Rist.Text(False)
        TextStruct.Count = "2"
        TextStruct.ClipList.AddRange(New String() {"おはようございます。", "今日もいい天気ですね！"})
        Return TextStruct
    End Function

    ''' <summary>
    ''' Listﾓｰﾄﾞのﾃﾞﾌｫﾙﾄの初期値をRist.Data構造体で返す
    ''' </summary>
    Public Function DefaultData() As Rist.Data
        Dim DataStruct As New Rist.Data(False)
        DataStruct.Count = 2
        DataStruct.ClipList.AddRange(New String() {"おはようございます。", "今日もいい天気ですね！"})
        Return DataStruct
    End Function

    ''' <summary>
    ''' iniﾌｧｲﾙの情報からﾕｰｻﾞｰ入力文字列ﾘｽﾄに変換
    ''' </summary>
    ''' <param name="Input"></param>
    ''' <returns></returns>
    Public Function IniToData(Input As List(Of String)) As List(Of String)
        Dim Ret = New List(Of String)()
        Dim Text As String = ""
        Dim Picked As String = ""
        For Each i As String In Input
            Text = ""
            For j As Integer = 0 To i.Length() - 1
                Picked = i.Substring(j, 1)
                If Picked = "\" Then
                    j += 1
                    Picked = i.Substring(j, 1)
                    If Picked = "\" Then
                        Text += "\"
                    ElseIf Picked = "n" Then
                        Text += "↲"
                    ElseIf Picked = "s" Then
                        Text += " "
                    End If
                Else
                    Text += Picked
                End If
            Next
            Ret.Add(Text)
        Next
        Return Ret
    End Function

    ''' <summary>
    ''' 指定したiniﾌｧｲﾙからListﾓｰﾄﾞのﾃﾞｰﾀを読み込みRist.Text構造体で返す
    ''' </summary>
    ''' <param name="IniPath">読み込むiniﾌｧｲﾙのﾌﾙﾊﾟｽ</param>
    Public Function ReadIni(IniPath As String) As Rist.Text
        Dim Ini As New ClsIni(IniPath)
        Dim TextStruct As New Rist.Text(False)
        Dim Num As Integer
        Dim Text As String
        TextStruct.StartIndex = Ini.GetProfileString("List_Init", "START", "Error")
        TextStruct.Luup = Ini.GetProfileString("List_Init", "LOOP", "Error")
        TextStruct.Count = Ini.GetProfileString("List_Init", "COUNT", "Error")
        If Integer.TryParse(TextStruct.Count, Num) AndAlso (0 <= Num And Num <= 10000) Then
            For i As Integer = 0 To Num - 1
                Text = Ini.GetProfileString("List_Init", "CLIP" & i.ToString(), "Error")
                TextStruct.ClipList.Add(Text)
            Next
        End If
        Return TextStruct
    End Function

    Private Function DataToIni(Input As String) As String
        Dim Ret As String = ""
        Dim Picked As String = ""
        For i As Integer = 0 To Input.Length() - 1
            Picked = Input.Substring(i, 1)
            If Picked = "\" Then
                Ret += "\\"
            ElseIf Picked = "↲" Then
                Ret += "\n"
            ElseIf Picked = " " Then
                Ret += "\s"
            Else
                Ret += picked
            End If
        Next
        Return Ret
    End Function

    ''' <summary>
    ''' 指定したiniﾌｧｲﾙにListﾓｰﾄﾞのﾃﾞｰﾀを書き込む
    ''' </summary>
    ''' <param name="IniPath">ﾃﾞｰﾀを保存するiniﾌｧｲﾙのﾌﾙﾊﾟｽ</param>
    ''' <param name="TextStruct">保存するﾃﾞｰﾀ(Rist.Text構造体)</param>
    Public Sub WriteIni(IniPath As String, TextStruct As Rist.Text)
        Dim Ini As New ClsIni(IniPath)
        Ini.WriteProfileString("List_Init", "START", TextStruct.StartIndex)
        Ini.WriteProfileString("List_Init", "LOOP", TextStruct.Luup)
        Ini.WriteProfileString("List_Init", "COUNT", TextStruct.Count)
        For i = 0 To TextStruct.ClipList.Count() - 1
            Ini.WriteProfileString("List_Init", "CLIP" & i.ToString(), DataToIni(TextStruct.ClipList(i)))
        Next
    End Sub

    ''' <summary>
    ''' Rist.Text構造体の情報をRist.Data構造体で返す
    ''' </summary>
    ''' <param name="TextStruct">変換するRist.Text構造体</param>
    Public Function ToData(TextStruct As Rist.Text) As Rist.Data
        Dim DataStruct As New Rist.Data(False)
        DataStruct.StartIndex = Integer.Parse(TextStruct.StartIndex)
        If TextStruct.Luup = "True" Then
            DataStruct.Luup = True
        Else
            DataStruct.Luup = False
        End If
        DataStruct.Count = Integer.Parse(TextStruct.Count)
        DataStruct.ClipList = TextStruct.ClipList
        Return DataStruct
    End Function

    ''' <summary>
    ''' Rist.Data構造体のﾃﾞｰﾀをRist.Text構造体で返す
    ''' </summary>
    ''' <param name="DataStruct">変換するRist.Data構造体</param>
    Public Function ToText(DataStruct As Rist.Data) As Rist.Text
        Dim TextStruct As New Rist.Text(False)
        TextStruct.StartIndex = DataStruct.StartIndex.ToString()
        If DataStruct.Luup Then
            TextStruct.Luup = "True"
        Else
            TextStruct.Luup = "False"
        End If
        TextStruct.Count = DataStruct.Count.ToString()
        TextStruct.ClipList = DataStruct.ClipList
        Return TextStruct
    End Function

    Private Function IsValidElem(Input As String) As Boolean
        For i As Integer = 0 To Input.Length() - 1
            If Input.Substring(i, 1) = "\" Then
                If i = Input.Length() - 1 OrElse (Input.Substring(i + 1, 1) <> "\" AndAlso Input.Substring(i + 1, 1) <> "n" AndAlso Input.Substring(i + 1, 1) <> "s") Then
                    Return False
                Else
                    i += 1
                End If
            End If
        Next
        Return True
    End Function
    Public Function IsValidIni(TextStruct As Rist.Text) As Boolean
        Dim Result As Boolean
        Dim Num As Integer
        Result = Integer.TryParse(TextStruct.Count, Num)
        If Result Then
            If Num <> TextStruct.ClipList.Count() Then
                Return False
            Else
                'OK
            End If
        Else
            Return False
        End If

        If TextStruct.Luup <> "True" And TextStruct.Luup <> "False" Then
            Return False
        End If

        Result = Integer.TryParse(TextStruct.StartIndex, Num)
        If Result Then
            If Num < 1 Or TextStruct.ClipList.Count() < Num Then
                Return False
            Else
                For Each i As String In TextStruct.ClipList
                    If Not IsValidElem(i) Then
                        Return False
                    End If
                Next
                'Else OK
            End If
        Else
            Return False
        End If

        Return True
    End Function

    Public Function IsValidText(TextStruct As Rist.Text) As Boolean
        Dim Result As Boolean
        Dim Num As Integer
        Result = Integer.TryParse(TextStruct.Count, Num)
        If Result Then
            If Num <> TextStruct.ClipList.Count() Then
                Return False
            Else
                'OK
            End If
        Else
            Return False
        End If

        If TextStruct.Luup <> "True" And TextStruct.Luup <> "False" Then
            Return False
        End If

        Result = Integer.TryParse(TextStruct.StartIndex, Num)
        If Result Then
            If Num < 1 Or TextStruct.ClipList.Count() < Num Then
                Return False
            Else
                'OK
            End If
        Else
            Return False
        End If

        Return True
    End Function
End Module
