Imports System.Diagnostics

Public Class Form1

    Dim processo() As Process
    Dim minuti = 0, ore = 0, secondi As Integer = 0
    Dim str As String = ""
    Dim start As Boolean = 0
    Dim t_sec = 0, t_min = 0, t_ore As Integer = 0 'tempo di chiusura
    Dim secondi_chiusura As Integer = 0 'tempo rimasto in secondi
    Dim chiusura As Boolean = 0 'si sta chiudendo??
    Dim allarga_ristringi As Boolean = 0 '0=finestra ristretta, 1=finestra allargata

    Sub stringa()
        str = Format(ore, "00") & ":" & Format(minuti, "00") & ":" & Format(secondi, "00")
    End Sub

    Private Sub tmrtimer_Tick(sender As System.Object, e As System.EventArgs) Handles tmrtimer.Tick
        processo = Process.GetProcessesByName("TClient", My.Computer.Name)
        If processo.Length > 0 Then secondi += 1

        If (secondi >= 60) Then
            minuti += 1
            secondi -= 60
        End If

        If (minuti >= 60) Then
            ore += 1
            minuti -= 60
        End If

        stringa()
        lbltempo.Text = str

    End Sub

    Private Sub btninizia_Click(sender As System.Object, e As System.EventArgs) Handles btninizia.Click
        'se contatore fermo
        If (start = 0) Then
            tmrtimer.Start()
            start = 1
            btninizia.Text = "Pausa"
        Else 'contatore in movimento
            tmrtimer.Stop()
            start = 0
            btninizia.Text = "Riprendi"
        End If
    End Sub

    Private Sub btnstop_Click(sender As System.Object, e As System.EventArgs) Handles btnstop.Click
        start = 0
        tmrtimer.Stop()
        minuti = 0
        ore = 0
        secondi = 0
        btninizia.Text = "Inizia!"
        stringa()
        lbltempo.Text = str
    End Sub

    Private Sub Form1_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        lbltempo.Focus()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (chiusura) Then
            If MessageBox.Show("Vuoi uscire e bloccare la chiusura in corso?", "Contatore Tempo 4Story", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tipo_tempo.Items.Add("Secondi")
        tipo_tempo.Items.Add("Minuti")
        tipo_tempo.Items.Add("Ore")
        tipo_tempo.SelectedItem = "Secondi"
        stringa()
        lbltempo.Text = str
        btninizia.PerformClick()
        processo = Process.GetProcessesByName("TClient", My.Computer.Name)
        If processo.Length > 0 Then Exit Sub
        processo = Process.GetProcessesByName("4story", My.Computer.Name)
        If processo.Length > 0 Then Exit Sub
        Process.Start("C:\\Program Files (x86)\\4StoryEG\\4Story.exe")
    End Sub

    Private Sub btnchiudi4_Click(sender As System.Object, e As System.EventArgs) Handles btnchiudi.Click
        Dim myProcesses() As Process
        Dim myProcess As Process
        ' Restituisce un'array con tutti i processi
        myProcesses = Process.GetProcessesByName("TClient", My.Computer.Name)
        'chiude ogni processo
        For Each myProcess In myProcesses
            myProcess.CloseMainWindow()
        Next
        myProcesses = Process.GetProcessesByName("4story", My.Computer.Name)
        'chiude ogni processo
        For Each myProcess In myProcesses
            myProcess.CloseMainWindow()
        Next
    End Sub

    Private Sub btnapri_Click(sender As System.Object, e As System.EventArgs) Handles btnapri.Click
        processo = Process.GetProcessesByName("TClient", My.Computer.Name)
        If processo.Length > 0 Then Exit Sub
        processo = Process.GetProcessesByName("4story", My.Computer.Name)
        If processo.Length > 0 Then Exit Sub
        Process.Start("C:\\Program Files (x86)\\4StoryEG\\4Story.exe")
    End Sub

    Private Sub btnfai_Click(sender As System.Object, e As System.EventArgs) Handles btnfai.Click
        If ((txttempo.Value < 60) And (tipo_tempo.SelectedIndex = 0)) Then
            If MessageBox.Show("Il tempo è minore di 60 secondi, vuoi continuare?", "Contatore Tempo 4Story", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        btnannulla.Enabled = 1
        opt4story.Enabled = 0
        optpc.Enabled = 0
        txttempo.Enabled = 0
        tipo_tempo.Enabled = 0
        btnfai.Enabled = 0
        chiusura = 1
        t_sec = 0
        t_min = 0
        t_ore = 0

        If (tipo_tempo.SelectedIndex = 0) Then
            t_sec = txttempo.Value
            While (t_sec >= 60)
                t_min += 1
                t_sec -= 60
            End While
        ElseIf (tipo_tempo.SelectedIndex = 1) Then
            t_min = txttempo.Value
            While (t_min >= 60)
                t_ore += 1
                t_min -= 60
            End While
        ElseIf (tipo_tempo.SelectedIndex = 2) Then
            t_ore = txttempo.Value
        End If
        secondi_chiusura = t_sec + t_min * 60 + t_ore * 3600
        lblcountdown.Text = Format(t_ore, "00") & ":" & Format(t_min, "00") & ":" & Format(t_sec, "00")
        tmrchiusura.Start()
    End Sub

    Private Sub btnannulla_Click(sender As System.Object, e As System.EventArgs) Handles btnannulla.Click
        chiusura = 0
        btnannulla.Enabled = 0
        opt4story.Enabled = 1
        optpc.Enabled = 1
        txttempo.Enabled = 1
        tipo_tempo.Enabled = 1
        btnfai.Enabled = 1
        lblcountdown.Text = ""
        secondi_chiusura = 0
        t_sec = 0
        t_min = 0
        t_ore = 0
        tmrchiusura.Stop()
    End Sub

    Private Sub tmrchiusura_Tick(sender As System.Object, e As System.EventArgs) Handles tmrchiusura.Tick
        'è un secondo in ritardo il contatore
        If (secondi_chiusura = 1) Then
            lblcountdown.Text = "00:00:00"
            If (optpc.Checked) Then
                Process.Start("shutdown", "/s /t 1")
            ElseIf (opt4story.Checked) Then
                btnchiudi.PerformClick() 'clicca il bottone chiudi 4story
            End If
            btnannulla.PerformClick()
        Else
            secondi_chiusura -= 1
            t_sec -= 1
            If (t_sec < 0) Then
                t_min -= 1
                t_sec += 60
            End If
            If (t_min < 0) Then
                t_ore -= 1
                t_min += 60
            End If
            lblcountdown.Text = Format(t_ore, "00") & ":" & Format(t_min, "00") & ":" & Format(t_sec, "00")
        End If
    End Sub

    Private Sub btnallarga_stringi_Click(sender As System.Object, e As System.EventArgs) Handles btnallarga_stringi.Click
        tmrfinestra.Start()
        If (allarga_ristringi) Then 'se è allargato
            btnallarga_stringi.Text = "Allarga -->"
            allarga_ristringi = 0
        Else 'se è ristretto
            btnallarga_stringi.Text = "<-- Ristringi"
            allarga_ristringi = 1
        End If
    End Sub

    Private Sub tmrfinestra_Tick(sender As System.Object, e As System.EventArgs) Handles tmrfinestra.Tick
        If (allarga_ristringi = False) Then 'se è allargato (=false perchè inverte lo 0-1 al click del pulsante
            If (secondi_chiusura > 0) Then
                tmrfinestra.Stop()
                btnallarga_stringi.Text = "<-- Ristringi"
                allarga_ristringi = 1
                Exit Sub
            End If
            If (Me.Width <= 380) Then
                tmrfinestra.Stop()
            Else
                Me.Width -= 5
                lbltitolo.Width -= 5
            End If
        Else 'se è ristretto
            If (Me.Width >= 660) Then
                tmrfinestra.Stop()
            Else
                Me.Width += 5
                lbltitolo.Width += 5
            End If
        End If
    End Sub
End Class
