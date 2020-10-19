Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
