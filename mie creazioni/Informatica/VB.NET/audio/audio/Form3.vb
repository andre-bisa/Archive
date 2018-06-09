Public Class Form3

    Private Sub btncambia_Click(sender As System.Object, e As System.EventArgs) Handles btncambia.Click
        If (Form1.pass_attiva = 0) Then Exit Sub
        txtnuova_psw.Text = Trim(txtnuova_psw.Text)
        txtnuova_psw_conferma.Text = Trim(txtnuova_psw_conferma.Text)

        If (txtnuova_psw.Text = "") Then Exit Sub
        If (txtnuova_psw.Text <> txtnuova_psw_conferma.Text) Then
            MsgBox("Errore, le password devono corrispondere!")
            Exit Sub
        End If


        Form1.PASS_OK = 0
        Form4.ShowDialog()
        If (Form1.PASS_OK) Then
            Form1.PASSWORD = txtnuova_psw.Text
            txtnuova_psw.Text = ""
            txtnuova_psw_conferma.Text = ""
            Me.Close()

        End If
        Form1.PASS_OK = 0
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtnuova_psw.Text = ""
        txtnuova_psw_conferma.Text = ""
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btncambia.Enabled = 1

        If (Form1.pass_attiva) Then
            optpassattiva.Checked = 1
        Else 'se è disattivata
            optpassdisattiva.Checked = 1
            btncambia.Enabled = 0
        End If
    End Sub

    Private Sub optpassattiva_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optpassattiva.CheckedChanged
        If (optpassattiva.Checked) Then
            Form1.pass_attiva = 1
        Else
            Form1.PASS_OK = 0
            Form4.ShowDialog()
            If (Form1.PASS_OK) Then 'se non inserisco la password corretta non disattivo la password
                Form1.pass_attiva = 0
            Else
                optpassattiva.Checked = 1 'rimetto la password come attiva
            End If
            Form1.PASS_OK = 0

        End If

        If (Form1.pass_attiva) Then
            btncambia.Enabled = 1
        Else
            btncambia.Enabled = 0
        End If
    End Sub

End Class