Public Class Перемещение_иконки

    Dim GoingUp As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GoingUp = True
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GoingUp = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim point(0) As Point
        If GoingUp = True Then
            If PictureBox1.Top > 10 Then
                PictureBox1.Location = New Point(PictureBox1.Location.X - 10, _PictureBox1.Location.Y - 10)
            End If
        Else
            If PictureBox1.Top < (Me.Size.Height - 75) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X + 10,
PictureBox1.Location.Y + 10)
            End If
        End If


    End Sub
End Class