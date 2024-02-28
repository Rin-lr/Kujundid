Public Class Ristkylik
    Inherits Nelinurk
    ' Konstruktor baasklassi atribuutide algväärtustamiseks
    Public Sub New(alus As Double, korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Ristkülik", alus, korgus, alus, korgus)
    End Sub
    ' Funktsioon arvutab ja tagastab ristküliku pindala.
    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function
End Class