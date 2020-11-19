Public Class Динамика

    Public n As Integer
    Private Sub Динамика_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim graph As Graphics = e.Graphics
        Dim pen As New Pen(Color.Indigo, 7)
        Static z As Integer = 0

        z = z + 1

        Dim point() As Point = {New Point(100, 30),
            New Point(z + 200, 30),
            New Point(150, 120), New Point(50, 120)}
        graph.DrawClosedCurve(pen, point)


        Static x As Integer = 0
        Static y As Integer = 0

        x = x + n
        y = y + n

        point = {New Point(x + 100, y + 30),
            New Point(x + 200, y + 30),
            New Point(x + 150, y + 120),
            New Point(x + 50, y + 120)}
        graph.DrawClosedCurve(pen, point)

        If (point(2).X > 640 Or point(2).Y > 300) Or (point(0).X < 0 Or point(0).Y < 0) Then
            n = n * -1
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub

    Private Sub Динамика_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n = 1
    End Sub
End Class