Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim cassa As Single
        Dim assegno As Single
        Dim c10, c20, c50 As Integer

        If Not IsNumeric(txtcassa.Text) Then
            MsgBox("Errore")
            txtcassa.Focus()
            Exit Sub
        Else : cassa = Convert.ToSingle(txtcassa.Text)
        End If

        If Not IsNumeric(txtassegno.Text) Then
            MsgBox("Errore")
            txtassegno.Focus()
            Exit Sub
        Else : assegno = Convert.ToSingle(txtassegno.Text)
        End If

        If (assegno > cassa) Then
            MsgBox("Assegno>cassa")
            Exit Sub
        End If

        Do While assegno >= 50
            assegno -= 50
            c50 += 1
        Loop

        Do While assegno >= 20
            assegno -= 20
            c20 += 1
        Loop
        If (assegno >= 10) Then
            c10 += 1
            assegno -= 10
        End If
        lblris.Text = "Banconote da 50: " & c50 & " da 20: " & c20 & " da 10: " & c10 & " resto: " & assegno
    End Sub
End Class
