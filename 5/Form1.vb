Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = TextBox1.Text & ComboBox1.SelectedItem & vbNewLine
    End Sub
End Class
