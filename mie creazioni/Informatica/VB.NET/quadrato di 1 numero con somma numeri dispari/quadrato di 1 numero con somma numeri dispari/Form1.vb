Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim numero As Single
        Dim ris As Single
        numero = txtnumero.Value
        Dim dispari As Integer = 1 'tiene il numero dispari corrente
        For i As Integer = 1 To numero Step 1
            ris += dispari
            dispari += 2
        Next
        txtris.Text = ris
    End Sub
End Class
