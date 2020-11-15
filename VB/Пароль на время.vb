Public Class Пароль_на_время
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        _11.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = “Open” Then
            Me.Hide()
            Пароль_на_время2.Show()
            Timer1.Enabled = False
        ElseIf TextBox1.Text = “” Then
            MsgBox(“Время вышло. Повторите ввод пароля!”)
        Else
            MsgBox(“Пароль не верен. Введите пароль снова!”)
            TextBox1.Text = “”
            Timer1.Enabled = True
        End If

    End Sub


End Class