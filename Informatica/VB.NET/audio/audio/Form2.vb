Public Class Form2

    Private Sub btncambia_Click(sender As System.Object, e As System.EventArgs) Handles btncambia.Click
        If (Form1.pass_attiva = 0) Then
            Form1.cambia_massimo(txtmax.Value)
        Else
            Form1.PASS_OK = 0
            Form4.ShowDialog()
            If (Form1.PASS_OK) Then
                Form1.cambia_massimo(txtmax.Value)
            End If
            Form1.PASS_OK = 0
        End If

        Me.Close()

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtmax.Value = Form1.volume_attuale()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtmax.Minimum = Form1.trkvolume.Value
    End Sub
End Class