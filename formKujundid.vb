Public Class formKujundid
    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tyybi valimine'
        lblTyyp.Text = kujund.annaTyyp

        'pindala ja ymbermoot arvutamine ja väljastamine
        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmbermoot
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        'objekti kolmnurga klassist'
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        'võib teha sama asja ka nii...'
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub
End Class
