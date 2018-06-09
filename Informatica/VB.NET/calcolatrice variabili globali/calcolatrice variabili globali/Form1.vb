Public Class Form1
    Dim risultato As Single = 0

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim numero As Single = 0
        Dim segno As String = ""

        If Not IsNumeric(txtnumero.Text) Then
            MsgBox("Errore inserimento dati")
            txtnumero.Focus()
            Exit Sub
        End If
        numero = Convert.ToSingle(txtnumero.Text)

        If optdiviso.Checked Then
            segno = "/"
        ElseIf optmeno.Checked Then
            segno = "-"
        ElseIf optper.Checked Then
            segno = "*"
        Else
            segno = "+"
        End If

        Select Case segno
            Case "+"
                risultato += numero
            Case "-"
                risultato -= numero
            Case "/"
                If (numero = 0) Then
                    MsgBox("Impossibile dividere per 0")
                    Exit Sub
                End If
                risultato /= numero
            Case "*"
                risultato *= numero
        End Select

        lblris.Text = risultato

        lstcronologia.Items.Add(segno & " " & numero & "= " & risultato)

    End Sub

    Private Sub btnazzera_Click(sender As System.Object, e As System.EventArgs) Handles btnazzera.Click
        lstcronologia.Items.Clear()
        txtnumero.Text = ""
        risultato = 0
        lblris.Text = ""
        optpiu.Checked = 1
    End Sub
End Class
