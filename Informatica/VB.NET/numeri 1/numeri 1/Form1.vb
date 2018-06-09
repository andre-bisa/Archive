Public Class Form1

    Private Sub btnvai_Click(sender As System.Object, e As System.EventArgs) Handles btnvai.Click
        Dim i As Integer
        i = 20
        Do While i <= 30
            MsgBox(i)
            i = i + 1
        Loop
    End Sub
End Class
