Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formKujundid
    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tyybi valimine'
        lblTyyp.Text = kujund.annaTyyp

        'pindala ja ymbermoot arvutamine ja väljastamine
        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmbermoot
    End Sub

    Private Sub Allboxes(ByVal box As Control)
        txtYmbermoot.Enabled = False
        'txtPindala.Enabled = False
        'txtKylgA.Enabled = False
        'txtKylgB.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Allboxes(Me)
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(txtKylgA.Text, a) And Double.TryParse(txtKylgB.Text, b) Then
            If (a > 0 And b > 0) Then
                Dim objektKolmnurk As New Kolmnurk(a, b)
                tootleKujund(objektKolmnurk)
            Else
                MsgBox("Sisesta positiivne arv.")
            End If
        Else
            MsgBox("404! Sisesta arv.")
        End If

    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        'võib teha sama asja ka nii...'
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        tootleKujund(New Romb(txtKylgA.Text, txtKylgB.Text))
    End Sub

    Private Sub btnRoopkulik_Click(sender As Object, e As EventArgs) Handles btnRoopkulik.Click
        tootleKujund(New Roopkylik(txtKylgA.Text, txtKylgB.Text))
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged

    End Sub
End Class
