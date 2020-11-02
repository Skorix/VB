Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"
        TextBox1.Font = New System.Drawing.Font("Courier New", 9.0!)
        Label1.Font = New System.Drawing.Font("Courier New", 9.0!)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text
    End Sub
End Class
