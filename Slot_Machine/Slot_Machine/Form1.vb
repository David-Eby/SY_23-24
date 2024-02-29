Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Dim rC As New ReelControl
    Dim cS As New CoinSlot
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cS.amountOfDollars = Button6.Text
        cS.amountOfQuarters = Button5.Text
        cS.amountOfDimes = Button4.Text
        cS.amountOfNickles = Button3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cS.total >= 1 AndAlso Timer3.Enabled = False Then
            cS.Buy()
            Dim rand1 As New Random
            ReelControl1.Seed = rand1.Next(20)
            ReelControl1.Spin()
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer3.Enabled = True
            totalLabel.Text = cS.total.ToString("C2")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rand2 As New Random
        ReelControl2.Seed = rand2.Next(rC.ImageList1.Images.Count)
        ReelControl2.Spin()
        Timer1.Enabled = False
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim rand3 As New Random
        ReelControl3.Seed = rand3.Next(rC.ImageList1.Images.Count)
        ReelControl3.Spin()
        Timer2.Enabled = False
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If ReelControl1.itemValue = ReelControl2.itemValue AndAlso ReelControl2.itemValue = ReelControl3.itemValue Then
            winTB.Text = "YOU WIN"
            If ReelControl1.itemValue = 0 Then
                Button6.Text += 50
                Form1_Load(Nothing, Nothing)
            ElseIf ReelControl1.itemValue = 1 Then
                Button6.Text += 40
                Form1_Load(Nothing, Nothing)
            ElseIf ReelControl1.itemValue = 2 Then
                Button6.Text += 32
                Button5.Text += 2
                Form1_Load(Nothing, Nothing)
            ElseIf ReelControl1.itemValue = 3 Then
                Button6.Text += 25
            ElseIf ReelControl1.itemValue = 4 Then
                Button6.Text += 22
                Button5.Text += 2
                Form1_Load(Nothing, Nothing)
            ElseIf ReelControl1.itemValue = 5 Then
                Button6.Text += 15
                Form1_Load(Nothing, Nothing)
            ElseIf ReelControl1.itemValue = 6 Then
                Button6.Text += 10
                Form1_Load(Nothing, Nothing)
            Else
                Button6.Text += 5
                Form1_Load(Nothing, Nothing)
            End If
        Else
            winTB.Text = "You Lose"
        End If
        Timer3.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cS.amountOfDollars > 0 Then
            cS.InsertDollar()
            totalLabel.Text = cS.total.ToString("C2")
            Button6.Text = cS.amountOfDollars
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If cS.amountOfQuarters > 0 Then
            cS.InsertQuarter()
            totalLabel.Text = cS.total.ToString("C2")
            Button5.Text = cS.amountOfQuarters
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cS.amountOfDimes > 0 Then
            cS.InsertDime()
            totalLabel.Text = cS.total.ToString("C2")
            Button4.Text = cS.amountOfDimes
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cS.amountOfNickles > 0 Then
            cS.InsertNickle()
            totalLabel.Text = cS.total.ToString("C2")
            Button3.Text = cS.amountOfNickles
        End If
    End Sub
End Class