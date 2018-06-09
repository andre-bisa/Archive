Public Class Form1

    Function controlla(str As String)
        If Not IsNumeric(str) Then
            MsgBox("Errore, valore non numerico")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnfai_Click(sender As System.Object, e As System.EventArgs) Handles btnfai.Click
        Dim primo, secondo As Integer

        If (controlla(txtprimo.Text) = False) Then Exit Sub
        If (controlla(txtsecondo.Text) = False) Then Exit Sub
        primo = Convert.ToInt32(txtprimo.Text)
        secondo = Convert.ToInt32(txtsecondo.Text)

        If (primo < 3) Or (primo > 100) Or (secondo < 3) Or (secondo > 100) Then
            MsgBox("Errore, valore troppo basso o alto")
            Exit Sub
        End If



        Dim conta_pari, conta_dispari, somma_pari, somma_dispari As Integer

        For i As Integer = primo To secondo Step 1
            If (i Mod 2 = 0) Then 'pari
                conta_pari += 1
                somma_pari += i
            Else 'dispari
                conta_dispari += 1
                somma_dispari += i
            End If
        Next

        lblconta_pari.Text = conta_pari
        lblconta_dispari.Text = conta_dispari
        lblsomma_dispari.Text = somma_dispari
        lblsomma_pari.Text = somma_pari

        Dim media_pari, media_dispari As Single

        media_pari = somma_pari / conta_pari
        media_dispari = somma_dispari / conta_dispari

        lblmedia_dispari.Text = media_dispari
        lblmedia_pari.Text = media_pari



    End Sub
End Class
