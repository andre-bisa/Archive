Public Class Form1

    Function controlla(str As String) As Boolean
        If IsNumeric(str) Then
            controlla = 1 'se è numerica e quindi va bene
        Else
            controlla = 0 'se non è numerica e quindi non va bene
        End If
    End Function

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim reddito As Single
        Dim totale As Single = 0
        Dim s1, s2, s3, s4, s5 As Single

        If Not controlla(txtreddito.Text) Then
            MsgBox("Errore, reddito non numerico")
            Exit Sub
        End If


        reddito = txtreddito.Text

        If (reddito <= 15000) Then
            s1 = reddito * 0.23
        ElseIf (reddito <= 28000) Then
            s1 = 3450
            s2 = (reddito - 15000) * 0.27
        ElseIf (reddito <= 55000) Then
            s1 = 3450
            s2 = 3510
            s3 = (reddito - 28000) * 0.38
        ElseIf (reddito <= 75000) Then
            s1 = 3450
            s2 = 3510
            s3 = 10260
            s4 = (reddito - 55000) * 0.41
        ElseIf (reddito > 75000) Then
            s1 = 3450
            s2 = 3510
            s3 = 10260
            s4 = 8200
            s5 = (reddito - 75000) * 0.43
        End If

        totale = s1 + s2 + s3 + s4 + s5

        lblprimo.Text = s1
        lblsecondo.Text = s2
        lblterzo.Text = s3
        lblquarto.Text = s4
        lblquinto.Text = s5
        lbltot.Text = totale

    End Sub

    Private Sub txtreddito_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtreddito.KeyPress
        e.Handled = 1
        Select Case e.KeyChar
            Case Convert.ToChar(Keys.Back), Convert.ToChar(Keys.Cancel)
                e.Handled = 0
                Exit Select
            Case "-"
                If (InStr(txtreddito.Text, "-") = 1) Then Exit Sub
                txtreddito.Text = "-" & txtreddito.Text
            Case Is < "0", Is > "9"
                Exit Sub
            Case Else
                txtreddito.Text = txtreddito.Text & e.KeyChar
        End Select
    End Sub

    Private Sub txtreddito_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtreddito.TextChanged
        If (txtreddito.Text = "") Then txtreddito.Text = "0"
    End Sub
End Class
