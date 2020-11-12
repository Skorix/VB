Public Class Form1

    Public st, k
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        k = 1
        Timer1.Interval = 100
        st = " Quod licet Jovi, non licet bovi ! "
        Label1.Text = st

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim n
        n = Len(st)
        st = Mid(st, 2, n - 1) & Mid(st, 1, 1)
        Label1.Text = st
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        k = -k
        If k >= 0 Then
            Label1.Text = ""
            st = " Quod licet Jovi, non licet bovi ! "
            Label1.Text = st
        Else
            Label1.Text = ""
            st = " Что дозволено Юпитеру, не дозволено быку ! "
            Label1.Text = st
        End If
    End Sub

End Class
