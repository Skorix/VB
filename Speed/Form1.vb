Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Double
        x = TextBox1.Text * 1000 / 3600
        y = TextBox2.Text

        If x > y Then
            Label1.Text = TextBox1.Text
        Else Label1.Text = TextBox2.Text
        End If

    End Sub
End Class
