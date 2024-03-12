Public Class Roopkylik
    Inherits Nelinurk
    Dim Korgus As Double
    ' Konstruktor baasklassi atribuutide algväärtustamiseks
    Public Sub New(alus As Double, kylg As Double, korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Rööpkülik", alus, kylg, alus, kylg)
        Me.Korgus = korgus
    End Sub
    ' Funktsioon arvutab ja tagastab ristküliku pindala.
    Public Overrides Function leiaPindala() As Double
        Return kylgA * Korgus
    End Function
End Class