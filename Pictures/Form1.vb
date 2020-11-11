Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i As Integer

        For i = 1 To 4

            PictureBox1.Image = System.Drawing.Image.FromFile("D:\GitHub\VB\Pictures\Pictures\" & i & ".jpg")
            MsgBox("Щелкните здесь, чтобы посмотреть следующую картинку.")

        Next

    End Sub

End Class
