Public Class _13
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Меню.Show()
    End Sub
    Private Function Fact(ByVal a As Byte) As Integer
        Dim i As Byte
        Dim p As Integer
        p = 1
        For i = 1 To a
            p = p * i
        Next
        Return p
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As Integer
        Dim n As Integer
        n = Val(InputBox("Введитезаданноечисло:", "Ввод"))
        f = Fact(n)
        MsgBox(Str(n) & "!= " & Str(f), , "Вывод")
    End Sub
End Class