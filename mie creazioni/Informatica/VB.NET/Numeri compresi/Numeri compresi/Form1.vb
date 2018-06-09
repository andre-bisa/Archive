Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim n, i, m, tot As Integer

        m = txtm.Text
        n = txtn.Text

        tot = n + m
        MsgBox(tot)
        i = n
        Do While i <= m
            MsgBox(i)
            i = i + 1
        Loop
    End Sub
End Class
