Public Class Form1

    Function controlla(ByVal str As String) As Boolean
        If Not IsNumeric(str) Then
            MsgBox("Errore, hai inserito delle lettere tra i numeri")
            controlla = 0
        Else
            controlla = 1
        End If
        Return controlla
    End Function

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        If (controlla(txta.Text) = 0) Then Exit Sub
        If (controlla(txtb.Text) = 0) Then Exit Sub
        If (controlla(txtc.Text) = 0) Then Exit Sub

        Dim a, b, c As Single
        a = txta.Text
        b = txtb.Text
        c = txtc.Text
        If (a = 0) Then
            MsgBox("Divisione per 0, errore")
            Exit Sub
        End If

        Dim delta As Single = 0
        Dim x1, x2 As Single
        Dim conta_ris As Integer = 0

        delta = (b ^ 2) - (4 * a * c)

        Select Case delta
            Case Is = 0
                conta_ris = 1
                x1 = -b / (2 * a)
                x2 = x1

            Case Is > 0
                conta_ris = 2
                x1 = -b + Math.Sqrt(delta) / (2 * a)
                x2 = -b - Math.Sqrt(delta) / (2 * a)

            Case Is < 0
                conta_ris = 0
        End Select

        If conta_ris = 0 Then
            txtx1.Text = "Impossibile"
            txtx2.Text = "impossibile"
        Else
            txtx1.Text = x1
            txtx2.Text = x2
        End If
        txtrisultati.Text = conta_ris


    End Sub
End Class
