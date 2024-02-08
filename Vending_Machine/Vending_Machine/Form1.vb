Public Class Form1
    Dim cS As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cS.InsertDollar()
        Label1.Text = cS.Total
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cS.InsertQuarter()
        Label1.Text = cS.Total
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cS.InsertDime()
        Label1.Text = cS.Total
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cS.InsertNickle()
        Label1.Text = cS.Total
    End Sub
End Class