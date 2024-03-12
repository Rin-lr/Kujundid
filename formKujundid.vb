Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formKujundid
    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tyybi valimine'
        lblTyyp.Text = kujund.annaTyyp

        'pindala ja ymbermoot arvutamine ja väljastamine
        txtPindala.Text = Math.Round(kujund.leiaPindala, ComboBox.SelectedIndex)
        txtYmbermoot.Text = Math.Round(kujund.leiaYmberMoot, ComboBox.SelectedIndex)
    End Sub

    Private Sub Allboxes(ByVal box As Control)
        txtYmbermoot.Enabled = False
        ComboBox.SelectedIndex = 0
        txtPindala.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Allboxes(Me)
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(txtKylgA.Text, a) And Double.TryParse(txtKylgB.Text, b) Then
            If (a > 0 And b > 0) Then
                If (a / 2 < b) Then
                    Dim objektKolmnurk As New Kolmnurk(a, b)
                    tootleKujund(objektKolmnurk)
                Else
                    MsgBox("Selline Võrdhaarne kolmnurk on võimatu. Sisestage a väärtus, mis on väiksem kui b")
                End If
            Else
                MsgBox("Sisesta positiivne arv.")
            End If
        Else
            MsgBox("404! Sisesta arv.")
        End If

    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim a As Double
        If Double.TryParse(txtKylgA.Text, a) Then
            If (a > 0) Then
                Dim objektRuut As New Ruut(a)
                tootleKujund(objektRuut)
            Else
                MsgBox("Sisesta positiivne arv.")
            End If
        Else
            MsgBox("404! Sisesta arv.")
        End If
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(txtKylgA.Text, a) And Double.TryParse(txtKylgB.Text, b) Then
            If (a > 0 And b > 0) Then
                'võib teha sama asja ka nii...'
                tootleKujund(New Ristkylik(a, b))
            Else
                MsgBox("Sisesta positiivne arv.")
            End If
        Else
            MsgBox("404! Sisesta arv.")
        End If
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(txtKylgA.Text, a) And Double.TryParse(txtKylgB.Text, b) Then
            If (a > 0 And b > 0) Then
                tootleKujund(New Romb(a, b))
            Else
                MsgBox("Sisesta positiivne arv.")
            End If
        Else
            MsgBox("404! Sisesta arv.")
        End If
    End Sub

    Private Sub btnRoopkulik_Click(sender As Object, e As EventArgs) Handles btnRoopkulik.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        If Double.TryParse(txtKylgA.Text, a) And
            Double.TryParse(txtKylgB.Text, b) And
            Double.TryParse(txtKylgC.Text, c) Then
            If (a > 0 And b > 0 And c > 0) Then
                If (b < c) Then
                    MsgBox("Selline rööpkülik on võimatu. Sisestage c väärtus, mis on väiksem b")
                Else
                    tootleKujund(New Roopkylik(a, b, c))
                End If
            ElseIf (a < 0) Then
                MsgBox("Sisesta positiivne arv a")
            ElseIf (b < 0) Then
                MsgBox("Sisesta positiivne arv b")
            ElseIf (c < 0) Then
                MsgBox("Sisesta positiivne arv c")
            End If
        Else
            MsgBox("Sisesta arv kõikidesse väljadesse.")
        End If

    End Sub

End Class
