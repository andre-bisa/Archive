Public Class mastrini

    Public y_riga As Integer = 0
    Public x1, y1, x2, y2 As Integer

    Sub linea_sit_mastrini(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, intensita As Integer)
        Dim pen As New Pen(Color.Black, intensita)
        Me.CreateGraphics.DrawLine(pen, x1, y1, x2, y2)
    End Sub

    Private Sub situazione_economica_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        'tmrdisegna.Start()
    End Sub

    Private Sub tmrdisegna_Tick(sender As System.Object, e As System.EventArgs) Handles tmrdisegna.Tick
        If (y_riga > 0) Then
            Me.linea_sit_mastrini(x1, x2, y1, y2, 2)
        End If

        'per creare label
        'Dim lbl As New Label()
        'lbl.Text = "Prova"
        'lbl.Location = New Point(10, 10)
        'lbl.AutoSize = 1
        'lbl.Visible = 1
        'Me.Controls.Add(lbl)

        tmrdisegna.Stop()
    End Sub

    Private Sub mastrini_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Principale.Enabled = 1
    End Sub

    Private Sub tmriniziale_Tick(sender As System.Object, e As System.EventArgs) Handles tmriniziale.Tick
        Me.linea_sit_mastrini(x1, y1, x2, y2, 2)

        tmriniziale.Stop()
    End Sub
End Class