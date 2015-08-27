Public Class MsgWindow

    Public Sub ShowWinodw(ByVal Title As String, ByVal Content As Object, Optional ByVal Width As Integer = 300, Optional ByVal Height As Integer = 300)
        Me.Title = Title
        ContentBox.Content = Content
        ShowDialog()
    End Sub

End Class
