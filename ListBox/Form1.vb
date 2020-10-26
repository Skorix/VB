Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox2.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub
End Class
