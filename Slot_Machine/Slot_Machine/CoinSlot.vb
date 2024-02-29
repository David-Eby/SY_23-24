Public Class CoinSlot
    'Events
    Public Event coinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)

    'Properties
    Public Property dollars As Integer
    Public Property amountOfDollars
    Public Property quarters As Integer
    Public Property amountOfQuarters
    Public Property dimes As Integer
    Public Property amountOfDimes
    Public Property nickles As Integer
    Public Property amountOfNickles
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = (dollars) + (quarters * 0.25) + (dimes * 0.1) + (nickles * 0.05)
            Return _total
        End Get
    End Property

    'Methods
    Public Sub InsertDollar()
        dollars += 1
        amountOfDollars -= 1
    End Sub
    Public Sub InsertQuarter()
        quarters += 1
        amountOfQuarters -= 1
    End Sub
    Public Sub InsertDime()
        dimes += 1
        amountOfDimes -= 1
    End Sub
    Public Sub InsertNickle()
        nickles += 1
        amountOfNickles -= 1
    End Sub
    Public Sub Buy()
        If total >= 1 Then
            _total = total - 1
            dollars = 0
            quarters = 0
            dimes = 0
            nickles = _total / 0.05
        End If
    End Sub
End Class