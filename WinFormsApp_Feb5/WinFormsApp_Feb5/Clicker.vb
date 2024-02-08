Public Class Clicker
    'Properties
    Public Property count As Integer
    Public Property increment As Integer = 1

    'Methods
    Public Sub Click()
        count = count + increment
    End Sub
    Public Sub Reset()
        count = 0
    End Sub
End Class