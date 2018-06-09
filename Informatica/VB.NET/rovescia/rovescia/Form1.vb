Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        i = txtnumero.Text
        Do While i >= 0
            MsgBox(i)
            i = i - 1

        Loop
    End Sub
End Class
