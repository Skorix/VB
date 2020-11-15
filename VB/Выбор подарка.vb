Public Class Выбор_подарка

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Меню.Show()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = TextBox1.Text & ComboBox1.SelectedItem & vbNewLine
    End Sub


End Class