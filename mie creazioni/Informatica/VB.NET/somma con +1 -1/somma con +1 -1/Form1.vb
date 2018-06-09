Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim numero1, numero2 As Integer
        Dim ris As Integer

        numero1 = txtnumero1.Value
        numero2 = txtnumero2.Value

        ris += numero1
        For i As Integer = 1 To numero2 Step 1
            ris += 1
        Next

        txtris.Text = ris

    End Sub
End Class
