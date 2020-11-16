Public Class Анимация
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        _11.Show()
    End Sub




    Dim i As Object
    Private Sub Анимация_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        i = 0 ' обнуление счетчика

        Timer1.Enabled = True ' таймер не доступен

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        i = 0 ' обнуление счетчика

        Timer1.Enabled = True ' таймер не доступен

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i = i + 1

        Select Case i

            Case 1
                PictureBox1.Image = System.Drawing.Image.FromFile("D:\GitHub\VB\VB\Pictures\11_4\1.jpg")

            Case 2
                PictureBox1.Image = System.Drawing.Image.FromFile("D:\GitHub\VB\VB\Pictures\11_4\2.jpg")

            Case 3
                PictureBox1.Image = System.Drawing.Image.FromFile("D:\GitHub\VB\VB\Pictures\11_4\3.jpg")

            Case 4
                PictureBox1.Image = System.Drawing.Image.FromFile("D:\GitHub\VB\VB\Pictures\11_4\4.jpg")

                Timer1.Enabled = True

        End Select

    End Sub
End Class