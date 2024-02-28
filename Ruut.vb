Public Class Ruut
    Inherits Nelinurk
    ' Konstruktor baasklassi atribuutide väärtustamiseks
    Public Sub New(kylg As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Ruut", kylg, kylg, kylg, kylg)
    End Sub
    ' Funktsioon arvutab ja tagastab ruudu pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function
End Class
