Imports System.IO

Public Class aggiungi_voci

    Sub scrivi_file(sfile As String, testo As String)
        Dim objfile As StreamWriter = File.AppendText(sfile)
        objfile.WriteLine(testo)
        objfile.Close()
    End Sub

    Private Sub aggiungi_voci_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Principale.Enabled = 1
    End Sub

    Private Sub btnaggiungi_voce_Click(sender As System.Object, e As System.EventArgs) Handles btnaggiungi_voce.Click
        If (combotipo.SelectedItem = String.Empty) Then
            MsgBox("Inserire il testo", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Errore")
            txtvoce.Focus()
            Exit Sub
        End If

        Select Case combotipo.SelectedItem
            Case "LIQUIDITA'"
                scrivi_file("liquidita.txt", txtvoce.Text)
            Case "DEBITI"
                scrivi_file("debiti.txt", txtvoce.Text)
            Case "CREDITI"
                scrivi_file("crediti.txt", txtvoce.Text)
            Case "RICAVI"
                scrivi_file("ricavi", txtvoce.Text)
            Case "COSTI"
                scrivi_file("costi.txt", txtvoce.Text)
            Case "CAPITALE PROPRIO"
                scrivi_file("capitale_proprio.txt", txtvoce.Text)
            Case Else
                MsgBox("Selezionare almeno una voce", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                Exit Sub
        End Select

        'qua ci va solo se non c'è un msgbox per errore
        txtvoce.Clear()
        combotipo.SelectedIndex = 0
        Me.ControlBox = True
    End Sub
End Class