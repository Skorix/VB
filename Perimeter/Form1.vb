Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P As Single
        P = Convert.ToSingle(TextBox1.Text) + Convert.ToSingle(TextBox2.Text) + Convert.ToSingle(TextBox3.Text)
        Label4.Text = "Периметр = " + P.ToString
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
