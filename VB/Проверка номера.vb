﻿Public Class Проверка_номера

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        _9.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Const nmax = 7
        Dim n As Integer
        Dim k As Byte

        n = Val(TextBox1.Text)
        k = 0

        Do

            k = k + 1
            n = n \ 10

        Loop Until n = 0

        If k = nmax Then

            Label2.Text = "Соединение возможно" : Beep()

        ElseIf k < nmax Then

            Label2.Text = "Неправильно набран номер: не хватает цифр"

        Else

            Label2.Text = "Неправильно набран номер: слишком много цифр"

        End If

    End Sub

End Class