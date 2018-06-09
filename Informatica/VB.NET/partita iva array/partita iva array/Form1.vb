Public Class Form1
    Dim vet(10) As Integer
    Dim i As Integer = 1

    Private Sub btnaggiungi_Click(sender As System.Object, e As System.EventArgs) Handles btnaggiungi.Click
        Dim num As Integer = 0
        If Not IsNumeric(txtcifra.Text) Then
            MsgBox("Errore")
            Exit Sub
        End If
        num = Convert.ToInt32(txtcifra.Text)
        vet(i) = num
        i += 1

        If (i > 10) Then
            Dim x, y, z, t, tot As Single

            For p As Integer = 1 To 10 Step 1
                If ((p Mod 2) = 0) Then 'pari
                    y += 2 * vet(p)
                    If (vet(p) > 5) Then z += 1

                Else 'dispari
                    x += vet(p)

                End If
            Next

            t = x + y + z
            tot = (10 - t) Mod t
            lbl11.Text = tot
            MsgBox("Fine!")
        End If

    End Sub
End Class
