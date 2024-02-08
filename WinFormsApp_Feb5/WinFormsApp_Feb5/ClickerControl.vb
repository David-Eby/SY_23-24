Public Class ClickerControl
    Dim c As New Clicker

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.increment = NumericUpDown1.Value
        c.Click()
        TextBox1.Text = c.count
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.Reset()
        TextBox1.Text = c.count
    End Sub
End Class
