Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cof, pir As String
        If RadioButton1.Checked Then
            cof = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            cof = RadioButton2.Text
        Else
            cof = RadioButton3.Text
        End If
        If RadioButton4.Checked Then
            pir = RadioButton4.Text
        ElseIf RadioButton5.Checked Then
            pir = RadioButton5.Text
        Else
            pir = RadioButton6.Text
        End If
        MsgBox(cof & " и " & pir, , "Ваш выбор")

    End Sub

End Class
