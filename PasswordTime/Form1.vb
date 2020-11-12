Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = “Open” Then
            Me.Hide()
            Form2.Show
            Timer1.Enabled = False
        ElseIf TextBox1.Text = “” Then
            MsgBox(“Время вышло. Повторите ввод пароля!”)
        Else
            MsgBox(“Пароль не верен. Введите пароль снова!”)
            TextBox1.Text = “”
            Timer1.Enabled = True
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
