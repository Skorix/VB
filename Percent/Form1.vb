Public Class Form1

    Dim i As Integer
    Dim bl As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text & TextBox2.Text & TextBox3.Text) Then
            If RadioButton1.Checked Then
                Label4.Text = TextBox1.Text & " + " & ((TextBox1.Text * TextBox3.Text) / 100)
            ElseIf RadioButton2.Checked Then
                bl = TextBox1.Text
                For i = 1 To TextBox2.Text
                    bl = bl + (bl * TextBox3.Text) / 100
                    Label4.Text = bl
                Next
            End If
        End If
    End Sub
End Class
