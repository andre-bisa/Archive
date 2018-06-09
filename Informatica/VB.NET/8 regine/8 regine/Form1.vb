Public Class Form1
    Dim scacchiera(8, 8) As Boolean
    Dim celle_no(8, 8) As Boolean
    Dim soluzione_corrente As String = String.Empty
    Dim soluzioni As Integer = 0
    Dim inizio_colonna As Integer = 1
    Dim inizio_riga As Integer = 1
    Dim riparti As Boolean = False

    Dim pausa As Boolean = False

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 8 Step 1
            For j As Integer = 1 To 8 Step 1
                scacchiera(i, j) = 0
                celle_no(i, j) = 0
            Next
        Next

        'metti_regina(2, 7)

    End Sub

    Private Sub tmrtrova_risultati_Tick(sender As System.Object, e As System.EventArgs) Handles tmrtrova_risultati.Tick
        Dim x As Integer = inizio_colonna
        Dim y As Integer = inizio_riga

        If soluzioni >= 1 Then
            lstsoluzioni.Items.Add(soluzione_corrente)
            If soluzioni = 1 Then lstsoluzioni.SelectedIndex = 0
            riparti = True
            lblcontarisultati.Text = soluzioni
        End If


        For colonna As Integer = x To 8 Step 1
            inizio_colonna = colonna
            x = 1
            For riga As Integer = y To 8 Step 1
                y = 1
                inizio_riga = riga

                If (celle_no(colonna, riga) = False) Then 'se posso mettere
                    metti_regina(colonna, riga) 'posiziono la regina
                    soluzione_corrente &= colonna & riga 'metto la soluzione attuale nella stringa nel caso si finisca in un binario morto
                    Exit For 'esco dal for della riga per andare alla prossima colonna
                End If


                'qundi se non c'è soluzione (binario morto)
                'si torna indietro:

                If (riga = 8) Then
fine_riga:

                    Dim col As Integer = 0
                    Dim rig As Integer = 0

                    Try
                        col = Convert.ToInt32(soluzione_corrente.Substring(soluzione_corrente.Length - 2, 1))
                        rig = Convert.ToInt32(soluzione_corrente.Substring(soluzione_corrente.Length - 1, 1))
                    Catch ex As Exception
                        tmrtrova_risultati.Stop()
                        btnpausa.Enabled = 0
                        Exit Sub
                    End Try

                    soluzione_corrente = soluzione_corrente.Remove(soluzione_corrente.Length - 2, 2)

                    colonna = col
                    riga = rig

                    scacchiera(colonna, riga) = 0

                    If (riga = 8) Then GoTo fine_riga 'se la soluzione caricata ha ancora la riga 8 torna un'altra volta indietro
                    If (riparti = True) Then 'per evitare che rifaccia un giro ricarcicando l'ultima colonna
                        riparti = 0
                        GoTo fine_riga
                    End If


                    aggiorna_celle_no()
                    Me.Refresh()


                End If
            Next riga
            Threading.Thread.Sleep(1)
        Next colonna

        soluzioni += 1

        Threading.Thread.Sleep(10)

    End Sub

    Private Sub metti_regina(ByVal colonna As Integer, ByVal riga As Integer)

        scacchiera(colonna, riga) = 1 'metto la regina
        aggiorna_celle_no() 'aggiorno celle no

        If (pausa = True) Then
            Exit Sub
        End If


        Box_scacchiera.Controls.Item("q" & Convert.ToString(colonna)).Location = New Point(Box_scacchiera.Controls.Item("q" & Convert.ToString(colonna)).Location.X, 21 + 56.25 * (riga - 1))

    End Sub

    Private Sub aggiorna_celle_no()

        For colonna As Integer = 1 To 8
            For riga As Integer = 1 To 8
                celle_no(colonna, riga) = 0
            Next
        Next

        For colonna As Integer = 1 To 8 Step 1
            For riga As Integer = 1 To 8 Step 1

                If (scacchiera(colonna, riga) = True) Then 'se c'è la regina
                    For i As Integer = 1 To 8 Step 1


                        'colonne e righe:
                        celle_no(colonna, i) = 1
                        celle_no(i, riga) = 1

                        'diagonali:
                        If Not ((colonna + i) > 8 Or (riga + i) > 8) Then celle_no(colonna + i, riga + i) = 1
                        If Not ((colonna - i) < 1 Or (riga - i) < 1) Then celle_no(colonna - i, riga - i) = 1
                        If Not ((colonna - i) < 1 Or (riga + i) > 8) Then celle_no(colonna - i, riga + i) = 1
                        If Not ((colonna + i) > 8 Or (riga - i) < 1) Then celle_no(colonna + i, riga - i) = 1

                    Next i
                End If

            Next riga
        Next colonna

    End Sub

    Private Sub btnpausa_Click(sender As System.Object, e As System.EventArgs) Handles btnpausa.Click
        If (pausa = False) Then
            pausa = True
            btnpausa.Text = "Riprendi"
        Else
            pausa = False
            btnpausa.Text = "Pausa"
        End If

    End Sub

    Private Sub btnprecedente_Click(sender As System.Object, e As System.EventArgs) Handles btnprecedente.Click
        If (lstsoluzioni.SelectedIndex = 0) Then Exit Sub
        lstsoluzioni.SelectedIndex -= 1
    End Sub

    Private Sub btnsuccessivo_Click(sender As System.Object, e As System.EventArgs) Handles btnsuccessivo.Click
        If (lstsoluzioni.SelectedIndex = lstsoluzioni.Items.Count - 1) Then Exit Sub
        lstsoluzioni.SelectedIndex += 1
    End Sub

    Private Sub lstsoluzioni_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstsoluzioni.SelectedIndexChanged
        Dim colonna_riga As Boolean = 0
        Dim colonna As Integer = 1
        Dim riga As Integer = 1

        'salto il primo giro di ogniuno perché serve per evitare che mi legga la colonna
        For Each c As String In lstsoluzioni.Items(lstsoluzioni.SelectedIndex).ToString
            If (colonna_riga = 0) Then 'colonna
                colonna = Convert.ToInt32(c)
            Else 'riga
                riga = Convert.ToInt32(c)
                Box_scacchiera.Controls.Item("q" & Convert.ToString(colonna)).Location = New Point(Box_scacchiera.Controls.Item("q" & Convert.ToString(colonna)).Location.X, 21 + 56.25 * (riga - 1))
                lblselezionata.Text = lstsoluzioni.SelectedIndex + 1 & "/"
            End If

            colonna_riga = Not colonna_riga
        Next

        
    End Sub
End Class
