Public Class Form1

    Private Sub btncalc_Click(sender As System.Object, e As System.EventArgs) Handles btncalc.Click
        Dim da, a, i As Integer

        da = txtda.Text
        a = txta.Text

        For i = da To a Step 1
            MsgBox(i)
        Next

    End Sub
End Class
