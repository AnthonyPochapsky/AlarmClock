Public Class DigitLED
    Inherits System.Windows.Forms.Label
    Public Property MaxDigit As Integer
    Private Property CanUpdate As Boolean
    Public Sub SetMaxDigit(Digit As Integer)
        MaxDigit = Digit
    End Sub

    Public Function GetMaxDigit()
        Return MaxDigit
    End Function

    Public Sub SetCanUpdate(state As Boolean)
        CanUpdate = state
    End Sub

    Public Function GetCanUpdate()
        Return CanUpdate
    End Function

    Public Sub MakeRed()
        MyBase.ForeColor = Color.Red
    End Sub

    Public Sub MakeBlack()
        MyBase.ForeColor = Color.Black
    End Sub

End Class
