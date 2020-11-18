Public Class Процедура
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        _13.Show()
    End Sub

    Private Sub MyMessage()
        MessageBox.Show("Сообщение выведено подпрограммой MyMessage.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyMessage()
    End Sub
End Class