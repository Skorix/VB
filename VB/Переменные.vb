Public Class Переменные
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Меню.Show()
    End Sub
    Private Sub Переменные_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim anInteger As Integer = 42
        Dim aSingle As Single = 39.5
        Dim aString As String = "I like candy"
        Dim aBoolean As Boolean = True
        MsgBox(anInteger)
        MsgBox(aSingle)
        MsgBox(aString)
        MsgBox(aBoolean)


    End Sub

End Class