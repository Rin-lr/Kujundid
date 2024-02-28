Imports System.Math
Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    Public Sub New(alus As Double, haar As Double)
        'kutsume baasklassi'
        MyBase.New(("Võrdhaarne kolmnurk"), alus, haar, haar)
        'kolmnurga kõrgus'
        Me.korgus = Sqrt(haar * haar - (alus * alus / 4))
    End Sub

    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC
    End Function

    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus / 2
    End Function
End Class
