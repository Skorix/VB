Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n, n1 As Integer
        Dim del As Byte
        Dim str As String

        n = Val(TextBox1.Text)
        del = 2
        n1 = n
        str = ""

        Do

            If n Mod del = 0 Then

                n = n \ del
                str = str & CStr(del)
                If n <> 1 Then str = str & "*"

            Else

                If del = 2 Then

                    del = 3

                Else

                    del = del + 2

                End If

            End If

        Loop Until n = 1

        If del > 10 Then

            MsgBox("Error")

        End If

        Label2.Text = n1 & "=" & str

    End Sub

End Class
