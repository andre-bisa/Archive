Public Class Form1

    Function gira_stringa(str As String)
        Dim str_girata As String = ""
        For Each c As Char In str
            str_girata = c + str_girata
        Next
        Return str_girata
    End Function

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim numero As Integer
        Dim binario As String = String.Empty

        numero = txtnumero.Value

        Do
            binario = binario + Convert.ToString(numero Mod 2)
            numero = numero \ 2
        Loop While numero >= 2

        If (numero = 1) Then binario = binario + Convert.ToString(numero)

        txtbinario.Text = gira_stringa(binario)

    End Sub
End Class
