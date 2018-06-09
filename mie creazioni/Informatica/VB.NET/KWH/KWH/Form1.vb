Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Const CS = 0.07
        Dim let_iniz, let_fin, canone, tot As Single

        If Not IsNumeric(txtlet_iniz.Text) Then
            MsgBox("Errore lettura iniziale")
            txtlet_iniz.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtlet_fin.Text) Then
            MsgBox("Errore lettura finale")
            txtlet_fin.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtcanone.Text) Then
            MsgBox("Errore canone")
            txtcanone.Focus()
            Exit Sub
        End If

        let_iniz = Convert.ToSingle(txtlet_iniz.Text)
        let_fin = Convert.ToSingle(txtlet_fin.Text)
        canone = Convert.ToSingle(txtcanone.Text)
        tot = (let_fin - let_iniz) * CS + canone
        MsgBox("Il signor " & txtnome.Text & " spende € " & Convert.ToString(tot), 0, "KWH")
    End Sub
End Class
