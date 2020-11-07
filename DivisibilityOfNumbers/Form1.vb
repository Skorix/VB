Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n, n1, sum As Integer
        Dim cifra As Byte

        n = Val(TextBox1.Text)
        n1 = n
        sum = 0

        Do While n1 <> 0
            cifra = n1 Mod 10
            sum = sum + cifra
            n1 = n1 \ 10
        Loop

        If n <> 0 Then
            If sum Mod 3 = 0 Then
                Label2.Text = "Число " & n & " делится на 3"
            Else
                Label2.Text = "Число " & n & " не делится на 3"
            End If
        Else
            Label2.Text = "Вы Ввели 0"
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim n, ost As Integer

        n = Val(TextBox1.Text)

        If n <> 0 Then

            ost = n Mod 100

            If ost Mod 4 = 0 Then
                Label2.Text = "Число " & n & " делится на 4"
            Else
                Label2.Text = "Число " & n & " не делится на 4"
            End If
        Else
            Label2.Text = "Вы ввели 0"
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim n, ost As Integer

        n = Val(TextBox1.Text)

        If n <> 0 Then

            ost = n Mod 10

            If ost = 0 Or ost = 5 Then
                Label2.Text = "Число " & n & " делитсяна 5"
            Else
                Label2.Text = "Число " & n & " не делится на 5"
            End If
        Else
            Label2.Text = "Выввели 0"
        End If

    End Sub

End Class
