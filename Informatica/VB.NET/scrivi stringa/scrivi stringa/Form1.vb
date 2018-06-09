Public Class Form1

    Dim contatore As Integer = 10000
    Dim volte As Integer = 0
    Dim testo As String = 0
    Dim a_capo As Boolean = 0
    Dim inviate As Integer = 0
    Dim infinito As Boolean = 0 'se infinito aspetta lo stop

    Private Sub fine()
        tmriniziale.Stop()
        tmriniziale.Interval = 100
        Me.TopMost = False
        MsgBox("Ho finito")
        txtintervallo.Enabled = 1
        txttesto.Enabled = True
        txtvolte.Enabled = True
        chba_capo.Enabled = True
        chbinfinito.Enabled = True
        chbinfinito.Checked = 0
        btnmanda.Enabled = True
        btnstop.Enabled = False
        lblsecondi.Text = ""
        lblinviate.Text = ""
        contatore = 10000
        inviate = 0
        a_capo = 0
        testo = ""
        infinito = 0
        barraprogressiva.Value = barraprogressiva.Minimum
        Me.PerformLayout()
    End Sub

    Private Sub btnmanda_Click(sender As System.Object, e As System.EventArgs) Handles btnmanda.Click
        Me.TopMost = True
        inviate = 0
        contatore = 10000
        testo = ""
        infinito = 0
        volte = txtvolte.Value

        If chbinfinito.Checked Then
            infinito = 1
            volte = 0
        End If

        a_capo = chba_capo.Checked
        barraprogressiva.Minimum = 0
        barraprogressiva.Maximum = volte
        barraprogressiva.Value = 0
        testo = txttesto.Text
        txtintervallo.Enabled = 0
        txttesto.Enabled = False
        txtvolte.Enabled = False
        chba_capo.Enabled = False
        chbinfinito.Enabled = False
        btnmanda.Enabled = False
        btnstop.Enabled = True
        tmriniziale.Start()
    End Sub

    Private Sub tmriniziale_Tick(sender As System.Object, e As System.EventArgs) Handles tmriniziale.Tick
        If (contatore > 0) Then
            contatore -= 100
            lblsecondi.Text = "Inizio tra " + Convert.ToString(contatore / 1000) + " secondi"
            Exit Sub
        Else : tmriniziale.Interval = txtintervallo.Value
        End If

        lblinviate.Text = inviate + 1

        SendKeys.Send(testo)
        If a_capo Then
            SendKeys.Send("{ENTER}")
        End If

        inviate += 1

        If (infinito) Then
            Exit Sub 'aspetto lo stop!
        End If

        If barraprogressiva.Value < volte Then 'volte=barraprogressiva.Maximum
            barraprogressiva.Value += 1
            barraprogressiva.Refresh()
        End If
        Me.PerformLayout()

        'se non è infinito controllo di non essere già arrivato al massimo
        If (inviate >= volte) Then
            fine()
            Exit Sub
        End If

    End Sub

    Private Sub chbinfinito_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbinfinito.CheckedChanged
        If (chbinfinito.Checked) Then
            txtvolte.Value = 10
            txtvolte.Enabled = 0
        Else
            txtvolte.Enabled = 1
        End If
    End Sub

    Private Sub btnstop_Click(sender As System.Object, e As System.EventArgs) Handles btnstop.Click
        fine()
    End Sub
End Class
