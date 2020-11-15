Public Class Решение_квадратного_уравнения
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Меню.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, x1, x2 As Single
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        d = b ^ 2 - 4 * a * c
        If d > 0 Then
            x1 = (-b + System.Math.Sqrt(d)) / (2 * a)
            x2 = (-b - System.Math.Sqrt(d)) / (2 * a)
            TextBox4.Text = Str(x1)
            TextBox5.Text = Str(x2)
        ElseIf d = 0 Then
            x1 = -b / (2 * a)
            TextBox4.Text = Str(x1)
            TextBox5.Text = Str(x1)
        Else
            MsgBox("Корней нет.")
        End If

    End Sub

End Class