Public Class Form1

    Function gira_stringa(str As String)
        Dim str_girata As String = ""
        For Each c As Char In str
            str_girata = c + str_girata
        Next
        Return str_girata
    End Function

    Private Sub optbinario_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optbinario.CheckedChanged, optesadecimale.CheckedChanged, optottale.CheckedChanged
        Dim decimale As Integer = txtdecimale.Value
        Dim risultato As String = String.Empty

        Dim tipo_conversione As Integer

        If (optbinario.Checked = True) Then
            tipo_conversione = 2
        ElseIf (optottale.Checked = True) Then
            tipo_conversione = 8
        ElseIf (optesadecimale.Checked = True) Then
            tipo_conversione = 16
        End If

        Do
            Dim resto As Integer = decimale Mod tipo_conversione
            If (resto >= 10) Then
                Select Case resto
                    Case 10
                        risultato = "A" & risultato
                    Case 11
                        risultato = "B" & risultato
                    Case 12
                        risultato = "C" & risultato
                    Case 13
                        risultato = "D" & risultato
                    Case 14
                        risultato = "E" & risultato
                    Case 15
                        risultato = "F" & risultato
                End Select
            Else
                risultato = Convert.ToString(resto) & risultato
            End If

            decimale = decimale \ tipo_conversione
        Loop While decimale >= tipo_conversione

        If decimale > 0 Then
            If (decimale >= 10) Then
                Select Case decimale
                    Case 10
                        risultato = "A" & risultato
                    Case 11
                        risultato = "B" & risultato
                    Case 12
                        risultato = "C" & risultato
                    Case 13
                        risultato = "D" & risultato
                    Case 14
                        risultato = "E" & risultato
                    Case 15
                        risultato = "F" & risultato
                End Select
            Else
                risultato = Convert.ToString(decimale) & risultato
            End If
        End If

        txtrisultato.Text = risultato

    End Sub
End Class
