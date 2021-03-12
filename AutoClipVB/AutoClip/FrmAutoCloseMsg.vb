Imports System.ComponentModel

Public Class FrmAutoCloseMsg
    Private Sub FrmAutoCloseMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'メッセージの表示
        LblInfo.Text = FrmClip.CloseMessage

        'Beep!
        Beep()

        '自動的に閉じる用のタイマーを有効化
        TmrClose.Enabled = True
    End Sub

    Private Sub TmrClose_Tick(sender As Object, e As EventArgs) Handles TmrClose.Tick
        'タイマーを止める
        TmrClose.Enabled = False
        'ダイアログボックスを閉じる
        Me.Close()
    End Sub

    Private Sub FrmAutoCloseMsg_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'タイマーを止める
        TmrClose.Enabled = False
    End Sub

End Class