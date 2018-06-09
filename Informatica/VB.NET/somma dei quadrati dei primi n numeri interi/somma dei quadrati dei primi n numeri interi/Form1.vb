Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim tot, i As Integer

        Do While i <= txtfine.Text
            tot = tot + i * i
            i = i + 1

        Loop
        MsgBox(tot)
    End Sub
End Class
