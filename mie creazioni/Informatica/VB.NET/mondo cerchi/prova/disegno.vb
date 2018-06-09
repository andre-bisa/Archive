Public Class disegno

    Public Sub cerchio(ByVal x As Single, ByVal y As Single, ByVal intensita As Single)
        'disegna(posizione x, posizione y, quanto colorare)
        Dim pen As New Pen(Color.Black, intensita)
        Me.CreateGraphics.DrawArc(pen, x, y, 10, 10, 0, 360)
    End Sub

    Public Sub rettangolo(ByVal color As Color, ByVal x As Single, ByVal y As Single, ByVal intensita As Single)
        'disegna(colore, posizione x, posizione y, intensità)
        Dim tratteggio() As Single = {2, 2} 'tratteggio
        Dim pen As New Pen(color, intensita)
        pen.DashPattern = tratteggio 'imposta il tratteggio
        Me.CreateGraphics.DrawRectangle(pen, x, y, 60, 200)
    End Sub

    Private Sub disegno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gestione.Show()
        tmrrettangolo.Start()
        tmrconsuma_cibo.Start()
        tmrspostamento.Start()
        tmrdisegna_cerchi.Start()
    End Sub

    Private Sub tmrrettangolo_Tick(sender As System.Object, e As System.EventArgs) Handles tmrrettangolo.Tick
        rettangolo(Color.Red, 0, 30, 3)
        gestione.Visible = 1
    End Sub

    Private Sub tmrconsuma_cibo_Tick(sender As System.Object, e As System.EventArgs) Handles tmrconsuma_cibo.Tick
        If (gestione.conta_cerchi = 0) Then Exit Sub

        For i As Integer = 0 To gestione.conta_cerchi - 1 Step 1
            gestione.cibo.Item(i) -= 1
            If (gestione.cibo.Item(i) <= 0) Then
                gestione.elimina_cerchio(i)
            End If
        Next

    End Sub

    Private Sub tmrspostamento_Tick(sender As System.Object, e As System.EventArgs) Handles tmrspostamento.Tick
        If (gestione.conta_cerchi = 0) Then Exit Sub

        For i As Integer = 0 To gestione.conta_cerchi - 1 Step 1
            If (gestione.tempo_spostamento.Item(i) >= 0) Then
                gestione.tempo_spostamento.Item(i) -= 1
                Continue For
            Else
                gestione.tempo_spostamento.Item(i) = tmrspostamento.Interval
            End If
            Dim casuale As New Random
            Dim al_ba As Integer 'alto=0  basso=1 fermo=2
            Dim dx_sx As Integer 'destra=0 sinistra=1 fermo=2
            al_ba = casuale.Next(1, 100) Mod 3
            dx_sx = casuale.Next(1, 100) Mod 3

            Dim quanto As Integer = 1 'di quanti pixel muovere

            If (gestione.cibo.Item(i) <= 25) Then
                If (gestione.cibo.Item(i) = 1) Then gestione.cibo.Item(i) = 24
                If (gestione.x_disegno.Item(i) > 60) Then dx_sx = 1 Else dx_sx = 2
                If (gestione.y_disegno.Item(i) < 30) Then al_ba = 1 Else al_ba = 2
                If (gestione.y_disegno.Item(i) > 200) Then al_ba = 0
                quanto = 10
            End If

            If (al_ba = 0) Then 'alto
                gestione.y_disegno.Item(i) -= quanto
                If (gestione.y_disegno.Item(i) >= Me.Height) Then gestione.y_disegno.Item(i) -= quanto + 1
                If (gestione.y_disegno.Item(i) <= 0) Then gestione.y_disegno.Item(i) += quanto + 1
            ElseIf al_ba = 1 Then 'basso
                gestione.y_disegno.Item(i) += quanto
                If (gestione.y_disegno.Item(i) >= Me.Height) Then gestione.y_disegno.Item(i) -= quanto + 1
                If (gestione.y_disegno.Item(i) <= 0) Then gestione.y_disegno.Item(i) += quanto + 1
            End If

            If (dx_sx = 0) Then 'destra
                gestione.x_disegno.Item(i) += quanto
                If (gestione.x_disegno.Item(i) >= Me.Width) Then gestione.x_disegno.Item(i) -= quanto + 1
                If (gestione.x_disegno.Item(i) <= 0) Then gestione.x_disegno.Item(i) += quanto + 1
            ElseIf dx_sx = 1 Then 'sinistra
                gestione.x_disegno.Item(i) -= quanto
                If (gestione.x_disegno.Item(i) <= 0) Then gestione.x_disegno.Item(i) += quanto + 1
            End If

            If (gestione.x_disegno.Item(i) <= 60) And ((gestione.y_disegno.Item(i) <= 200) And (gestione.y_disegno.Item(i) >= 30)) Then
                gestione.cibo.Item(i) = 100
            End If

            Dim x_disegno2 As New ArrayList()
            x_disegno2 = gestione.x_disegno.Clone
            x_disegno2.RemoveAt(i)
            Dim y_disegno2 As New ArrayList()
            y_disegno2 = gestione.y_disegno.Clone
            y_disegno2.RemoveAt(i)

            If (x_disegno2.Contains(gestione.x_disegno.Item(i)) And (y_disegno2.Contains(gestione.y_disegno.Item(i)))) Then
                gestione.btncrea.PerformClick()

            End If


        Next

    End Sub

    Private Sub tmrdisegna_cerchi_Tick(sender As System.Object, e As System.EventArgs) Handles tmrdisegna_cerchi.Tick
        If (gestione.conta_cerchi = 0) Then Exit Sub

        Me.Refresh() 'svuoto tutto

        For i As Integer = 0 To gestione.conta_cerchi - 1 Step 1
            cerchio(gestione.x_disegno.Item(i), gestione.y_disegno.Item(i), 10)
        Next

    End Sub
End Class
