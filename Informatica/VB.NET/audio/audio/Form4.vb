Public Class Form4

    Private Sub btnesegui_Click(sender As System.Object, e As System.EventArgs) Handles btnesegui.Click
        txtpassword.Text = Trim(txtpassword.Text)
        If (txtpassword.Text = "") Then Exit Sub

        If Form1.tentativi >= 5 Then
            Exit Sub
        End If

        If (txtpassword.Text = Form1.PASSWORD) Then
            Form1.PASS_OK = 1
            Me.Close()
        Else
            If (Form1.tentativi < 5) Then
                Form1.tentativi += 1
            End If
            txtpassword.Text = ""
        End If
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        txtpassword.Text = ""
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Form1.pass_attiva = 0 Then 'password non richiesta
            Form1.PASS_OK = 1
            Me.Close()
        End If
        tmrtempo.Start()
    End Sub

    Private Sub tmrtempo_Tick(sender As System.Object, e As System.EventArgs) Handles tmrtempo.Tick
        lbltempo.Text = Form1.tempo_tentativi_str
    End Sub
End Class