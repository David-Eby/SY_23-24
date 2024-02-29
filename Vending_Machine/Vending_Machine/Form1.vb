Public Class Form1
    Dim WithEvents cS As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cS.InsertDollar()
        totalLabel.Text = cS.Total.ToString("C2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cS.InsertQuarter()
        totalLabel.Text = cS.Total.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cS.InsertDime()
        totalLabel.Text = cS.Total.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cS.InsertNickle()
        totalLabel.Text = cS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cS.CoinReturn()
        totalLabel.Text = cS.Total.ToString("C2")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTB.Text.ToUpper()
            Case Product_Control1.productID
                cS.Buy(Product_Control1)
                productPB.Visible = True

            Case Product_Control2.productID
                cS.Buy(Product_Control2)
                productPB.Visible = True

            Case Product_Control3.productID
                cS.Buy(Product_Control3)
                productPB.Visible = True

            Case Product_Control4.productID
                cS.Buy(Product_Control4)
                productPB.Visible = True

            Case Product_Control5.productID
                cS.Buy(Product_Control5)
                productPB.Visible = True

            Case Product_Control6.productID
                cS.Buy(Product_Control6)
                productPB.Visible = True

            Case Product_Control7.productID
                cS.Buy(Product_Control7)
                productPB.Visible = True

            Case Product_Control8.productID
                cS.Buy(Product_Control8)
                productPB.Visible = True

            Case Product_Control9.productID
                cS.Buy(Product_Control9)
                productPB.Visible = True

            Case Product_Control10.productID
                cS.Buy(Product_Control10)
                productPB.Visible = True

            Case Product_Control11.productID
                cS.Buy(Product_Control11)
                productPB.Visible = True

            Case Product_Control12.productID
                cS.Buy(Product_Control12)
                productPB.Visible = True

            Case Product_Control13.productID
                cS.Buy(Product_Control13)
                productPB.Visible = True

            Case Product_Control14.productID
                cS.Buy(Product_Control14)
                productPB.Visible = True

            Case Product_Control15.productID
                cS.Buy(Product_Control15)
                productPB.Visible = True

            Case Product_Control16.productID
                cS.Buy(Product_Control16)
                productPB.Visible = True
        End Select
        totalLabel.Text = cS.Total.ToString("C2")
    End Sub

    Private Sub cS_coinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles cS.coinReturnEvent
        If d > 0 Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
        If q > 0 Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
        If dm > 0 Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If
        If n > 0 Then
            PictureBox4.Visible = True
        Else
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub Product_Control1_dispenseProduct(p As Image) Handles Product_Control1.dispenseProduct, Product_Control2.dispenseProduct, Product_Control3.dispenseProduct, Product_Control4.dispenseProduct, Product_Control5.dispenseProduct, Product_Control6.dispenseProduct, Product_Control7.dispenseProduct, Product_Control8.dispenseProduct, Product_Control9.dispenseProduct, Product_Control10.dispenseProduct, Product_Control11.dispenseProduct, Product_Control12.dispenseProduct, Product_Control13.dispenseProduct, Product_Control14.dispenseProduct, Product_Control15.dispenseProduct, Product_Control16.dispenseProduct
        productPB.Image = p
    End Sub
End Class