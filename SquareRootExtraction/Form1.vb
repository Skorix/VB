Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()
        Label1.Text = ""
        Label1.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show("Следует вводить числа", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox1.Focus()
        End If
        Dim X, Y As Single
        X = Convert.ToSingle(TextBox1.Text)
        Y = Math.Sqrt(X)
        Label1.Text = "Корень из " + X.ToString + " равен " + Y.ToString
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = ""
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class
