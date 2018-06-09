Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim y, n, a, b, m, q, w, g As Integer
        Dim str, risultato As String

        risultato = ""

        str = InputBox("Dammi l'anno")

        If Not IsNumeric(str) Then
            MsgBox("Errore, dato non numerico")
            Exit Sub
        End If

        y = Convert.ToSingle(str)

        If y < 0 Then
            MsgBox("Errore, anno < 0")
            Exit Sub
        End If

        n = y - 1900
        a = n Mod 19
        b = (7 * a + 1) \ 19
        m = (11 * a + 4 - b) Mod 29
        q = n \ 4
        w = (n + q + 31 - m) Mod 7
        g = 25 - m - w

        If (g > 0) Then
            risultato = (Convert.ToString(g)) + " aprile " + (Convert.ToString(y))
        Else : risultato = (Convert.ToString(g + 31)) + " marzo " + (Convert.ToString(y))
        End If

        MsgBox(risultato, MsgBoxStyle.OkOnly, "Pasqua")

    End Sub
End Class
