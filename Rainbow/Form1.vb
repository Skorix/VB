Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Single

        i = 0
        Timer1.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim i As Single
        For h As Integer = 1 To 7
            h = h + 1
            Timer1.Enabled = False
            Timer1.Enabled = True
            Select Case h
                Case 1
                    Label1.ForeColor = System.Drawing.Color.Red
                    Label1.Text = "Каждый "
                Case 2
                    Label2.ForeColor = System.Drawing.Color.DarkOrange
                    Label2.Text = "Охотник"
                Case 3
                    Label3.ForeColor = System.Drawing.Color.Yellow
                    Label3.Text = "Желает"
                Case 4
                    Label4.ForeColor = System.Drawing.Color.Lime
                    Label4.Text = "Знать"
                Case 5
                    Label5.ForeColor = System.Drawing.Color.SkyBlue
                    Label5.Text = "Где"
                Case 6
                    Label6.ForeColor = System.Drawing.Color.Blue
                    Label6.Text = "Сидят"
                Case 7
                    Label7.ForeColor = System.Drawing.Color.BlueViolet
                    Label7.Text = "Фазаны"
                    Timer1.Enabled = False
            End Select
        Next

    End Sub
End Class
