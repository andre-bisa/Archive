Imports System.Drawing.Printing

Public Class situazione_economica

    Public y_riga As Integer = 0
    Public x1_finale, y1_finale, x2_finale, y2_finale As Integer

    Sub linea_sit_eco(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, intensita As Integer)
        Dim pen As New Pen(Color.Black, intensita)
        Me.CreateGraphics.DrawLine(pen, x1, y1, x2, y2)
    End Sub

    Private Sub tmrdisegna_Tick(sender As System.Object, e As System.EventArgs) Handles tmrdisegna.Tick
        Me.linea_sit_eco(10, 50, 410, 50, 2)
        Me.linea_sit_eco(200, 50, 200, 350, 2)

        If (y_riga > 0) Then
            Me.linea_sit_eco(200, 50, 200, y_riga + 50, 2)
            tmranimazione.Start()
        End If

        'Dim lbl As New Label()
        'lbl.Text = "Prova"
        'lbl.Location = New Point(10, 10)
        'lbl.AutoSize = 1
        'lbl.Visible = 1
        'Me.Controls.Add(lbl)

        tmrdisegna.Stop()
    End Sub

    Private Sub situazione_economica_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Principale.Enabled = 1
    End Sub

    Private Sub situazione_economica_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        tmrdisegna.Start()
    End Sub

    Private Sub tmrriga_finale_Tick(sender As System.Object, e As System.EventArgs) Handles tmrriga_finale.Tick
        Me.linea_sit_eco(x1_finale, y1_finale, x2_finale, y2_finale, 3)
        tmrriga_finale.Stop()
    End Sub

    Private Sub tmranimazione_Tick(sender As System.Object, e As System.EventArgs) Handles tmranimazione.Tick
        If (Me.Height > (y_riga + 200)) Then
            Me.Height -= 5
        ElseIf (Me.Height < (y_riga + 200)) Then
            Me.Height += 1
        End If

        If (Me.Height = (y_riga + 200)) Then
            tmranimazione.Stop()
        End If
    End Sub

    '//////////////////////////// STAMPA /////////////////////////////////////////////////
    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitMap As Bitmap

    Private Sub btnstampa_Click(sender As System.Object, e As System.EventArgs) Handles btnstampa.Click
        'copia il form dentro all'immagine bitmap
        mPrintBitMap = New Bitmap(Me.Width, Me.Width)
        Dim lRect As System.Drawing.Rectangle
        lRect.Width = Me.Width
        lRect.Height = Me.Width
        Me.DrawToBitmap(mPrintBitMap, lRect)


        'crea il PrintDocument e stampa
        mPrintDocument = New PrintDocument
        mPrintDocument.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles mPrintDocument.PrintPage
        'mette l'immagine centrale
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) \ 2
        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) \ 2
        e.Graphics.DrawImage(mPrintBitMap, lWidth, lHeight)

        'non stampa la pagina aggiuntiva
        e.HasMorePages = False
    End Sub
End Class