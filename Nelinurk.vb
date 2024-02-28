Public MustInherit Class Nelinurk
    Inherits Kujund

    Protected kylgD As Double

    'konstruktor baasklassi algväärtustamiseks ning kylgD väärtustamiseks
    Public Sub New(tyyp As String, kylgA As Double,
                   kylgB As Double, kylgC As Double, kylgD As Double)
        'kutsume baasklassi'
        MyBase.New(tyyp, kylgA, kylgB, kylgC)
        'kylgD algväärtustamine'
        Me.kylgD = kylgD
    End Sub

    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC + kylgD
    End Function

    Public Overrides Function leiaPindala() As Double
        Return 0
    End Function
End Class
