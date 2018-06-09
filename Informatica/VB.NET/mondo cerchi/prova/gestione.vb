Public Class gestione

    Public x_disegno As New ArrayList()
    Public y_disegno As New ArrayList()
    Public conta_cerchi As Integer = 0
    Public cibo As New ArrayList()
    Public tempo_spostamento As New ArrayList()

    Public Sub elimina_cerchio(ByVal elimina As Integer)
        Dim eliminato As Boolean = 0 'se = 1 significa che è eliminato

        For i As Integer = 0 To conta_cerchi Step 1
            If (i = elimina) Then
                eliminato = 1
                conta_cerchi -= 1
                Continue For
            End If

            If (eliminato) Then
                If (i + 1 = conta_cerchi) Then Exit For
                x_disegno.Item(i) = x_disegno.Item(i + 1)
                y_disegno.Item(i) = y_disegno(i + 1)
                cibo.Item(i) = cibo.Item(i + 1)
                tempo_spostamento.Item(i) = tempo_spostamento.Item(i + 1)
            End If

        Next


    End Sub

    Private Sub btncrea_Click(sender As System.Object, e As System.EventArgs) Handles btncrea.Click
        Dim casuale As New Random
        Dim x As Single
        Dim y As Single

        x = casuale.Next(0, disegno.Width - 10)
        y = casuale.Next(0, disegno.Height - 10)
        conta_cerchi += 1

        'aggiunge in coda all'array il punto
        x_disegno.Add(x)
        y_disegno.Add(y)

        'creo il valore del cibo corrispondente
        cibo.add(100)

        'aggiungo il tempo per lo spostamento
        tempo_spostamento.Add(disegno.tmrspostamento.Interval)

        disegno.cerchio(x, y, 10)
    End Sub

    Private Sub btnsvuota_Click(sender As System.Object, e As System.EventArgs) Handles btnsvuota.Click
        disegno.Refresh()
        disegno.rettangolo(Color.Red, 0, 30, 3)
    End Sub

    Private Sub btnchiudi_Click(sender As System.Object, e As System.EventArgs) Handles btnchiudi.Click
        disegno.Close()
    End Sub

End Class