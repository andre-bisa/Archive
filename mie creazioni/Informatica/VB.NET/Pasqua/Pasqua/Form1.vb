Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim y, n, a, b, m, q, w, g As Integer


        If Not IsNumeric(txtanno.Text) Then
            lblrisultato.BackColor = Color.Red
            lblrisultato.Text = "Errore, anno non numerico"
            txtanno.Text = ""
            txtanno.Focus()
            Exit Sub
        Else : lblrisultato.BackColor = Color.Transparent
        End If

        If Convert.ToSingle(txtanno.Text) < 0 Then
            lblrisultato.BackColor = Color.Red
            lblrisultato.Text = "Errore, anno < 0"
            txtanno.Text = ""
            txtanno.Focus()
            Exit Sub
        Else : lblrisultato.BackColor = Color.Transparent
        End If

        y = txtanno.Text
        n = y - 1900
        a = n Mod 19
        b = (7 * a + 1) \ 19
        m = (11 * a + 4 - b) Mod 29
        q = n \ 4
        w = (n + q + 31 - m) Mod 7
        g = 25 - m - w

        If (g > 0) Then
            lblrisultato.Text = (Convert.ToString(g)) + " aprile " + (Convert.ToString(y))
        Else : lblrisultato.Text = (Convert.ToString(g + 31)) + " marzo " + (Convert.ToString(y))
        End If



    End Sub
End Class
