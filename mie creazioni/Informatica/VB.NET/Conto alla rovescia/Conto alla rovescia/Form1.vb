Public Class Form1

    Dim inizia_pausa As Boolean = 0 '0=inizia 1=pausa
    Dim fine As Integer = 100

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btninizia_pausa.Click
        If (inizia_pausa = 0) Then
            tmrconto.Start()
            btninizia_pausa.Text = "Pausa"
            inizia_pausa = 1
        Else '=1
            tmrconto.Stop()
            btninizia_pausa.Text = "Riprendi"
            inizia_pausa = 0
        End If
    End Sub

    Private Sub btnazzera_Click(sender As System.Object, e As System.EventArgs) Handles btnazzera.Click
        tmrconto.Stop()
        fine = 100
        lblconta.Text = fine
        btninizia_pausa.Text = "Inizia"
    End Sub

    Private Sub tmrconto_Tick(sender As System.Object, e As System.EventArgs) Handles tmrconto.Tick
        lblconta.Text = fine
        fine -= 1
    End Sub
End Class
