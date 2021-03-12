Public Module Mode

    ''' <summary>
    ''' Modeのﾃﾞｰﾀをiniﾌｧｲﾙに保存するための構造体
    ''' </summary>
    Public Structure Text
        Public Mode As String
        'デフォルト値で初期化
        Public Sub New(Cash As Boolean)
            Mode = "1"
        End Sub
    End Structure

    ''' <summary>
    ''' Modeのﾃﾞｰﾀをｱﾌﾟﾘで管理するための構造体
    ''' </summary>
    Public Structure Data
        Public Mode As UShort
        'デフォルト値で初期化
        Public Sub New(Cash As Boolean)
            Mode = 1
        End Sub
    End Structure

    ''' <summary>
    ''' ﾃﾞﾌｫﾙﾄの初期値をMode.Text構造体で返す
    ''' </summary>
    Public Function DefaultText() As Mode.Text
        Dim TextStruct As Mode.Text
        TextStruct.Mode = "1"
        Return TextStruct
    End Function

    ''' <summary>
    ''' ﾃﾞﾌｫﾙﾄの初期値をMode.Data構造体で返す
    ''' </summary>
    Public Function DefaultData() As Mode.Data
        Dim DataStruct As Mode.Data
        DataStruct.Mode = 1
        Return DataStruct
    End Function

    ''' <summary>
    ''' 指定したiniﾌｧｲﾙからﾃﾞｰﾀを読み込みMode.Text構造体で返す
    ''' </summary>
    ''' <param name="IniPath">読み込むiniﾌｧｲﾙのﾌﾙﾊﾟｽ</param>
    Public Function ReadIni(IniPath As String) As Mode.Text
        Dim Ini As New ClsIni(IniPath)
        Dim TextStruct As Mode.Text
        TextStruct.Mode = Ini.GetProfileString("Mode", "Mode", "Error")
        Return TextStruct
    End Function

    ''' <summary>
    ''' 指定したiniﾌｧｲﾙにﾃﾞｰﾀを書き込む
    ''' </summary>
    ''' <param name="IniPath">ﾃﾞｰﾀを保存するiniﾌｧｲﾙのﾌﾙﾊﾟｽ</param>
    ''' <param name="TextStruct">保存するﾃﾞｰﾀ(Mode.Text構造体)</param>
    Public Sub WriteIni(IniPath As String, TextStruct As Mode.Text)
        Dim Ini As New ClsIni(IniPath)
        Ini.WriteProfileString("Mode", "Mode", TextStruct.Mode)
    End Sub

    ''' <summary>
    ''' Mode.Text構造体の情報をMode.Data構造体で返す
    ''' </summary>
    ''' <param name="TextStruct"></param>
    Public Function ToData(TextStruct As Mode.Text) As Mode.Data
        Dim DataStruct As Mode.Data
        DataStruct.Mode = UShort.Parse(TextStruct.Mode)
        Return DataStruct
    End Function

    ''' <summary>
    ''' Mode.Data構造体のﾃﾞｰﾀをMode.Text構造体で返す
    ''' </summary>
    ''' <param name="DataStruct">変換するMode.Data構造体</param>
    Public Function ToText(DataStruct As Mode.Data) As Mode.Text
        Dim TextStruct As Mode.Text
        TextStruct.Mode = DataStruct.Mode.ToString()
        Return TextStruct
    End Function

    ''' <summary>
    ''' 引数のMode.Text構造体がMode.Data構造体に変換可能ならTrueを返す
    ''' </summary>
    ''' <param name="TextStruct">変換可能か判定するCount.Text構造体</param>
    ''' <returns></returns>
    Public Function IsValidText(TextStruct As Mode.Text) As Boolean
        Dim Result As Boolean
        Dim Num As UShort
        Result = UShort.TryParse(TextStruct.Mode, Num)
        If (Result) Then
            If (Num = 1 Or Num = 2) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function


End Module
