Public Class Form1
    Dim x, dx, b, y As Double


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = 1
        dx = 0.2
        b = 3.2
        While (x < 2.2)
            ListBox1.Items.Add("(x" & " = " & x & ")            y = " & 9 * (x ^ 3 + b ^ 3) * System.Math.Tan(x))
            x = x + dx
        End While
    End Sub


End Class
