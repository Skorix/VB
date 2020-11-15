Public Class Тест_на_время
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Меню.Show()
    End Sub

    Private Sub Тест_на_время_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MsgBox("Лимит времени 10 секунд превышен", , "Контроль времени")
        Timer1.Enabled = False
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If RadioButton3.Checked Then

            MsgBox("Верно", , "Тест")

        Else

            MsgBox("Неверно", , "Тест")

        End If

        Timer1.Enabled = False
        Button2.Enabled = False

    End Sub

End Class