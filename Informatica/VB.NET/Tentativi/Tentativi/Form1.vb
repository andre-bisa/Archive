Imports System.IO

Public Class Form1

    Dim max As Object = 0
    Dim index As Object = 0
    Dim index_old As Object = 0
    Dim tempo As DateTime = Now
    Dim booferma As Boolean = False
    Dim scrivi As System.IO.StreamWriter
    Dim boofile As Boolean = False
    Dim booListBox As Boolean = False

    Private Sub btnEsegui_Click(sender As System.Object, e As System.EventArgs) Handles btnEsegui.Click
        Dim caratteri As String() = Nothing
        max = 0
        index = 0
        index_old = 0
        tempo = Now
        For Each c As Char In txtCaratteri.Text
            If IsNothing(caratteri) Then ReDim caratteri(0) Else ReDim Preserve caratteri(UBound(caratteri) + 1)
            caratteri(UBound(caratteri)) = c
        Next c
        lstRisultati.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        For i As Integer = 1 To txtNumCaratteri.Value Step 1
            max = max + (caratteri.Length ^ i)
        Next i
        boofile = chkFile.Checked
        booListBox = chkListBox.Checked
        If boofile Then
            System.IO.File.Delete(My.Computer.FileSystem.SpecialDirectories.Desktop & "\\Tentativi.txt")
            scrivi = System.IO.File.CreateText(My.Computer.FileSystem.SpecialDirectories.Desktop & "\\Tentativi.txt")
        End If
        btnEsegui.Enabled = False
        btnStop.Enabled = True
        booferma = False
        Timer1.Start()
        Tentativi(caratteri, txtNumCaratteri.Value)
        Timer1.Stop()
        tlsTempoRestante.Text = "Terminato."
        Me.Cursor = Cursors.Default
        btnStop.Enabled = False
        btnEsegui.Enabled = True
        If boofile Then scrivi.Close()
    End Sub

    Private Sub Tentativi(ByVal caratteri As String(), ByVal NumCaratteriMax As Integer, Optional ByVal base As String = vbNullString)
        For Each c As Char In caratteri
            If booListBox Then
                lstRisultati.Items.Add(base & c)
                lstRisultati.TopIndex = lstRisultati.Items.Count - 1
            End If
            If boofile Then scrivi.WriteLine(base & c)
            index += 1
            ScriviStato(Format(index, "#,###,###,##0") & " / " & Format(max, "#,###,###,##0"))
            'Application.DoEvents()
            If booferma Then Exit Sub
            'Me.Refresh()
        Next c
        If Len(base) + 1 < NumCaratteriMax Then
            For Each c As Char In caratteri
                Application.DoEvents()
                If booferma Then Exit Sub
                Tentativi(caratteri, NumCaratteriMax, base & c)
            Next c
        End If
    End Sub

    Private Sub ScriviStato(ByVal str As String, Optional ByVal Accoda As Boolean = False)
        If Accoda Then
            tlsStato.Text &= str
        Else
            tlsStato.Text = str
        End If
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        booferma = True
        btnEsegui.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        On Error GoTo Ext
        Dim ora As DateTime = Now
        Dim secondi As Object = ((max - index_old) \ ((index - index_old) / (Differenza(ora, tempo) / Timer1.Interval)))
        tlsTempoRestante.Text = FormatOrario(secondi)
        GoTo Salta
Ext:
        tlsTempoRestante.Text = " Errore... "
Salta:
        index_old = index
        tempo = ora
    End Sub

    Private Function Differenza(ByVal d1 As DateTime, ByVal d2 As DateTime) As Object
        Dim m1 As Long = 0
        Dim m2 As Long = 0

        m1 = ((d1.Minute * 60) + d1.Second) * Timer1.Interval
        m2 = ((d2.Minute * 60) + d2.Second) * Timer1.Interval
        Return (m1 - m2)
    End Function

    Private Function FormatOrario(ByVal sec As Object) As String
        Dim min As Object = 0
        Dim ore As Object = 0
        Dim giorni As Object = 0
        Dim anni As Object = 0

        min = Int(sec / 60)
        sec = sec - (min * 60)

        ore = Int(min / 60)
        min = min - (ore * 60)

        giorni = Int(ore / 24)
        ore = ore - (giorni * 24)

        anni = Int(giorni / 365)
        giorni = giorni - anni * 365

        FormatOrario = "Restanti: " & IIf(anni > 0, anni & " Anni, ", vbNullString) & IIf(giorni > 0, giorni & " Giorni, ", vbNullString) & IIf(ore > 0, ore & " Ore, ", vbNullString) & IIf(min > 0, min & " Minuti, ", vbNullString) & sec & " Secondi."

    End Function

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        On Error GoTo Err
        Timer1.Stop()
        scrivi.Close()
Err:
    End Sub

    Private Sub chkListBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkListBox.CheckedChanged
        booListBox = chkListBox.Checked
    End Sub
End Class
