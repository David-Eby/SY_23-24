Imports System.Reflection.Emit

Public Class Product_Control
    'Events
    Public Event dispenseProduct(p As Image)

    'Properties
    Public cS As New CoinSlot
    Public Property productID As String
    Public Property productPrice As Decimal
    Public Property productPicture As Image
    Public Property productCount As Integer

    'Methods
    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = productID
        priceLabel.Text = productPrice.ToString("c2")
        PictureBox1.Image = productPicture
    End Sub
    Sub Buy()
        If productCount > 0 Then
            productCount -= 1
            RaiseEvent dispenseProduct(productPicture)
        End If
        If productCount = 0 Then
            productPicture = Nothing
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class