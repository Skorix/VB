Public Class Простые_множители
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        _9.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim n, n1 As Integer
        Dim del As Byte
        Dim str As String
        Dim k As Integer

        n = Val(TextBox1.Text)
        del = 2
        n1 = n
        str = ""
        k = 0

        If n1 < 11 Then Label4.Text = "Данное число простое" Else Label4.Text = "Данное число сложное"

        Do
            If n Mod del = 0 Then
                k = k + 1
                n = n \ del
                str = str & CStr(del)
                If n <> 1 Then str = str & "*"

            Else

                If del = 2 Then

                    del = 3

                Else

                    del = del + 2

                End If

            End If
        Loop Until n = 1
        If del > 10 Then
            MsgBox("Данное чиcло не раскладывается полностью на простые множители",, "Ошибка при разложении")
        End If
        Label2.Text = n1 & "=" & str
        Label3.Text = k
    End Sub


End Class