Public Class Form1

    Const COSTOBIANCO = 0.1
    Const COSTOCOLORI = 0.8
    Const COSTORILEGATURA = 1.3

    Private Sub txtbianco_LostFocus(sender As System.Object, e As System.EventArgs) Handles txtbianco.TextChanged, txtcolori.TextChanged, chkrilegatura.CheckedChanged
        Dim bianco, colori, tot As Single

        If Not IsNumeric(txtbianco.Text) Then
            bianco = 0
        Else : bianco = Convert.ToSingle(txtbianco.Text)
        End If
        If Not IsNumeric(txtcolori.Text) Then
            colori = 0
        Else : colori = Convert.ToSingle(txtcolori.Text)
        End If

        If (bianco < 0) Then
            txtbianco.Text = "0.00"
            txtbianco.Focus()
            Exit Sub
        End If
        If (colori < 0) Then
            txtcolori.Text = "0.00"
            txtcolori.Focus()
            Exit Sub
        End If

        lbltotfotoc.Text = Convert.ToString(bianco + colori)
        lblprbianco.Text = Format(bianco * COSTOBIANCO, "0.00")
        lblprcolori.Text = Format(colori * COSTOCOLORI, "0.00")
        tot = bianco * COSTOBIANCO + colori * COSTOCOLORI
        If (chkrilegatura.Checked) Then tot += COSTORILEGATURA
        lbltot.Text = Format(tot, "0.00")

    End Sub

    Private Sub btnsvuota_Click(sender As System.Object, e As System.EventArgs) Handles btnsvuota.Click
        txtbianco.Text = ""
        txtcolori.Text = ""
        lblprbianco.Text = "0.00"
        lblprcolori.Text = "0.00"
        lbltot.Text = "0.00"
        lbltotfotoc.Text = "0"
        chkrilegatura.Checked = 0
    End Sub
End Class
