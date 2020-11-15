Public Class Приветствие
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Меню.Show()
    End Sub

    Private Sub Приветсвие_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Англия")
        ListBox1.Items.Add("Германия")
        ListBox1.Items.Add("Мексика")
        ListBox1.Items.Add("Италия")
        ListBox1.Items.Add("Россия")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label2.Text = ListBox1.Text
        Select Case ListBox1.SelectedIndex
            Case 0
                Label3.Text = "Hello, programmer"
            Case 1
                Label3.Text = "Hallo, programmierer"
            Case 2
                Label3.Text = "Hola, programador"
            Case 3
                Label3.Text = "Ciao, programmatore"
            Case 4
                Label3.Text = "Здравствуй, программист"
        End Select
    End Sub


End Class