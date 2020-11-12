Public Class Form1
    Private x, y

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Image1.Left = Image1.Left + x
        Image1.Top = Image1.Top + y
        If Image1.Left > Me.Width = 500 Then
            Image1.Image = System.Drawing.Image.FromFile(“F:\GitHub\VB\11_4\Pictures\Face1.jpg”)
            x = -x
        End If
        If Image1.Left < 0 Then
            Image1.Image = System.Drawing.Image.FromFile(“F:\GitHub\VB\11_4\Pictures\Face2.jpg”)
            x = -x
        End If
        If Image1.Top > Me.Height = 1000 Then
            Image1.Image = System.Drawing.Image.FromFile(“F:\GitHub\VB\11_4\Pictures\Face3.jpg”)
            y = -y
        End If
        If Image1.Top < 0 Then
            Image1.Image = System.Drawing.Image.FromFile(“F:\GitHub\VB\11_4\Pictures\Face4.jpg”)
            y = -y
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = 2000 : y = 2000
    End Sub
End Class
