Public Class Form1

    Dim manca_2013 As String
    Dim manca_fine_festa As String
    Dim ora_attuale As String

    Sub capodanno()
        Dim attuale_ora, attuale_minuto, attuale_secondo As Integer
        attuale_ora = Now().Hour
        attuale_minuto = Now().Minute
        attuale_secondo = Now().Second

        Dim manca_ore, manca_minuti, manca_secondi As Integer
        manca_ore = 23 - attuale_ora
        manca_minuti = 59 - attuale_minuto
        manca_secondi = 60 - attuale_secondo
        If (manca_secondi = 60) Then
            manca_secondi = 0
            manca_minuti += 1
        End If

        If (manca_ore = 0) And (manca_minuti = 0) And (manca_secondi = 11) Then
            'mettere il coro buon anno
            My.Computer.Audio.Play("coro.wav", AudioPlayMode.Background)
        End If

        If (Now().Year = 2015) Then
            lblminuti_2013.Text = ""
            lblora_2013.Text = ""
            lblsecondi_2013.Text = ""
            Me.Width = 615
            Me.Height = 390
        Else
            Me.Width = 615
            Me.Height = 250
            lblora_2013.Text = manca_ore
            lblminuti_2013.Text = manca_minuti
            lblsecondi_2013.Text = manca_secondi
        End If

    End Sub

    Sub fine_festa()
        If (Now.Year = 2013) Then
            lblminuti_fine.Visible = 1
            lblore_fine.Visible = 1
            lblsecondi_fine.Visible = 1
            lblfine_festa.Visible = 1
            lblduepunti.Visible = 1
            lblduepunti2.Visible = 1
        Else
            lblminuti_fine.Visible = 0
            lblore_fine.Visible = 0
            lblsecondi_fine.Visible = 0
            lblfine_festa.Visible = 0
            lblduepunti.Visible = 0
            lblduepunti2.Visible = 0
            Exit Sub
        End If

        Dim attuale_ora, attuale_minuto, attuale_secondo As Integer
        attuale_ora = Now().Hour
        attuale_minuto = Now().Minute
        attuale_secondo = Now().Second

        Dim manca_ore, manca_minuti, manca_secondi As Integer
        manca_ore = 2 - attuale_ora
        manca_minuti = 29 - attuale_minuto
        manca_secondi = 60 - attuale_secondo

        If (manca_minuti < 0) Then
            manca_minuti += 60
            manca_ore -= 1
        End If

        If (manca_ore = 0) And (manca_minuti = 0) Then
            'mettere il form con il buon anno!
        End If

        lblore_fine.Text = manca_ore
        lblminuti_fine.Text = manca_minuti
        lblsecondi_fine.Text = manca_secondi

        If ((Now.Hour = 2) And (Now.Minute >= 30)) Then
            Shell("shutdown -s -t 1")
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = 1
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ora_attuale = Format(Now, "hh:mm")
        tmrora_attuale.Start()
    End Sub

    Private Sub tmrora_attuale_Tick(sender As System.Object, e As System.EventArgs) Handles tmrora_attuale.Tick
        ora_attuale = Format(Now, "hh:mm")
        capodanno()
        fine_festa()
    End Sub
End Class
