﻿Public Class CoinSlot
    'Events
    Public Event coinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)

    'Properties
    Public Property dollars As Integer
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property nickles As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _Total = (dollars) + (quarters * 0.25) + (dimes * 0.1) + (nickles * 0.05)
            Return _Total
        End Get
    End Property

    'Methods
    Public Sub InsertDollar()
        dollars += 1
    End Sub
    Public Sub InsertQuarter()
        quarters += 1
    End Sub
    Public Sub InsertDime()
        dimes += 1
    End Sub
    Public Sub InsertNickle()
        nickles += 1
    End Sub

    Public Sub CoinReturn()
        RaiseEvent coinReturnEvent(dollars, quarters, dimes, nickles)
        dollars = 0
        quarters = 0
        dimes = 0
        nickles = 0
    End Sub

    Public Sub Buy(pC As Product_Control)
        If pC.productCount > 0 AndAlso Total >= pC.productPrice Then
            pC.Buy()
            _Total = _Total - pC.productPrice
            dollars = 0
            quarters = 0
            dimes = 0
            nickles = _Total / 0.05
        End If
    End Sub
End Class