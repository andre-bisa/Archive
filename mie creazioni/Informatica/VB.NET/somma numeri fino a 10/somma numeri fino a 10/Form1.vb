Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i, tot As Integer

        Do While i <= 10
            tot = tot + i
            i = i + 1
        Loop
        MsgBox(tot)


    End Sub
End Class
