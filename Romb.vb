﻿Public Class Romb
    Inherits Nelinurk
    Dim Korgus As Double
    ' Konstruktor baasklassi atribuutide algväärtustamiseks
    Public Sub New(alus As Double, korgus As Double)
        ' Baasklassi konstruktori väljakutse
        MyBase.New("Romb", alus, alus, alus, alus)
        Me.Korgus = korgus
    End Sub
    ' Funktsioon arvutab ja tagastab ristküliku pindala.
    Public Overrides Function leiaPindala() As Double
        Return kylgA * Korgus
    End Function
End Class