Public Class _12
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Меню.Show()
    End Sub

    Private Sub MyMessage()
        MessageBox.Show("Сообщение выведено подпрограммой MyMessage.")
    End Sub

    Private Sub GeneralMessage(ByVal InMessage As String)
        MessageBox.Show(InMessage)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyMessage()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GeneralMessage("Первое сообщение.")
        GeneralMessage("Второе сообщение.")
        GeneralMessage("Третье сообщение.")

    End Sub

    Private Sub fact(ByVal a As Byte, ByRef p As Integer)
        Dim i As Byte
        p = 1
        For i = 1 To a
            p = p * i
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n As Byte
        Dim f As Integer
        n = Val(InputBox("Введите заданное число:", "Ввод"))
        fact(n, f)
        MsgBox(Str(n) & "!= " & Str(f), , "Вывод")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Меню.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class