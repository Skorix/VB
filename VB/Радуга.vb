Public Class Радуга
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        _11.Show()
    End Sub

    Dim i As Object
    Private Sub Радуга_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        i = 0 ' обнуление счетчика

        Timer1.Enabled = False ' таймер не доступен

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer1.Enabled = True ' таймер доступен

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        i = i + 1

        Select Case i

            Case 1
                Label1.Font = New System.Drawing.Font("Impact", 30.0!)
                Label1.ForeColor = System.Drawing.Color.Red
                Label1.Text = "Каждый "

            Case 2
                Label2.Font = New System.Drawing.Font("Impact", 30.0!)
                Label2.ForeColor = System.Drawing.Color.Orange
                Label2.Text = "Охотник"

            Case 3
                Label3.Font = New System.Drawing.Font("Impact", 30.0!)
                Label3.ForeColor = System.Drawing.Color.Yellow
                Label3.Text = "Желает"

            Case 4
                Label4.Font = New System.Drawing.Font("Impact", 30.0!)
                Label4.ForeColor = System.Drawing.Color.Lime
                Label4.Text = "Знать"

            Case 5
                Label5.Font = New System.Drawing.Font("Impact", 30.0!)
                Label5.ForeColor = System.Drawing.Color.SkyBlue
                Label5.Text = "Где"

            Case 6
                Label6.Font = New System.Drawing.Font("Impact", 30.0!)
                Label6.ForeColor = System.Drawing.Color.Blue
                Label6.Text = "Сидят"

            Case 7
                Label7.Font = New System.Drawing.Font("Impact", 30.0!)
                Label7.ForeColor = System.Drawing.Color.BlueViolet
                Label7.Text = "Фазаны"

                Timer1.Enabled = False

        End Select

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

End Class