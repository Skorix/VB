Public Class MyForLoop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Меню.Show()
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim i As Integer

        For i = 1 To 4

            PictureBox1.Image = System.Drawing.Image.FromFile("D:\GitHub\VB\VB\Pictures\7Pictures\" & i & ".jpg")
            MsgBox("Щелкните здесь, чтобы посмотреть следующую картинку.")

        Next

    End Sub


End Class