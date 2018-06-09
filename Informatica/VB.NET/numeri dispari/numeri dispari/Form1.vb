Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i As Integer

        For i = 1 To 20 Step 2
            MsgBox(i)
        Next

    End Sub
End Class
