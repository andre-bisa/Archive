Imports CoreAudioApi
'Imports audio.Funzioni

Public Class Form1

    'batteria
    Dim StatoBatteria As PowerStatus = SystemInformation.PowerStatus
    Dim PercentualeBatteria As Single = StatoBatteria.BatteryLifePercent * 100

    'trackbar nell'area di notifica
    Dim track_ico As New TrackBar
    Dim track_ico2 As New TrackBar
    Const MAX_TRACK_ICO As UInteger = 100

    'variabili per gestione volume
    Public DevEnum As New MMDeviceEnumerator()
    Public device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
    Public massimo As Single '= 50
    Public PASSWORD As String '= "volumE"

    'password per la chiusura
    Public pass_attiva As Boolean '= 0 '0=disattiva, 1=attiva
    Public PASS_OK As Boolean = 0 '0=sbagliata, 1=giustavariabile utilizzata per il controllo della psw nella form4

    Public tentativi As UInteger = 0
    Public max_tentativi As UInteger = 5
    Public tempo_tentativi As UInteger = 300
    Public tempo_tentativi_str As String = ""

    'profili
    Public profili As String()
    Public profilo_attuale As String = ""


    Public Function volume_attuale() As Integer
        volume_attuale = Int(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
    End Function

    Public Sub cambia_massimo(ByVal nuovo As Single)
        massimo = nuovo
    End Sub

    Private Sub cambia_volume(ByVal nuovo As Single)
        device.AudioEndpointVolume.MasterVolumeLevelScalar = nuovo
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        PASS_OK = 0
        Form4.ShowDialog()

        If PASS_OK = 0 Then
            e.Cancel = 1
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        crea_directory()
        crea_settings()
        leggi_profili()

        tmraggiorna_tempo_tentativi.Start()
        tmraggiorna.Start()
        tmrtempo_tentativi.Start()
        If (device.AudioEndpointVolume.Mute) Then 'se è muto
            btnmuto.Text = "Disattiva &Muto"
            Menu_icona_mute.Checked = 1
            Menu_alto_mute.Checked = 1
        Else 'se non è muto
            btnmuto.Text = "Attiva &Muto"
            Menu_icona_mute.Checked = 0
            Menu_alto_mute.Checked = 0
        End If

        'metto il secondo trackbar anche dentro al menu ad icona
        With track_ico
            .Minimum = 0
            .Maximum = MAX_TRACK_ICO
            .LargeChange = 1
            .TickStyle = TickStyle.None
            .Orientation = Orientation.Vertical
            .Height = 240
            .Width = 45
            .Value = Int(trkvolume.Value / 100)
        End With
        AddHandler track_ico.Scroll, AddressOf track_ico_Scroll
        Dim a As New ToolStripControlHost(track_ico)
        Menu_volume.Items.Add(a)
        Menu_area_notifica.PerformLayout()
        Menu_volume.PerformLayout()


    End Sub

    Private Sub track_ico_Scroll(sender As System.Object, e As System.EventArgs)
        cambia_volume(sender.Value / track_ico.Maximum)
        Call tmraggiorna_Tick(sender, e)
    End Sub

    Private Sub trkvolume_ValueChanged(sender As Object, e As System.EventArgs) Handles trkvolume.ValueChanged
        track_ico.Value = Int(trkvolume.Value / track_ico.Maximum)
    End Sub

    Private Sub trkvolume_Scroll(sender As System.Object, e As System.EventArgs) Handles trkvolume.Scroll
        If (device.AudioEndpointVolume.Mute) Then 'se è muto lo tolgo
            btnmuto.PerformClick()
        End If
        cambia_volume(trkvolume.Value / 100)
        'device.AudioEndpointVolume.MasterVolumeLevelScalar = trkvolume.Value / 100
        Call tmraggiorna_Tick(sender, e)
    End Sub

    Private Sub btnmuto_Click(sender As System.Object, e As System.EventArgs) Handles btnmuto.Click
        device.AudioEndpointVolume.Mute = Not device.AudioEndpointVolume.Mute

        If (device.AudioEndpointVolume.Mute) Then 'se è muto
            btnmuto.Text = "Disattiva &Muto"
            Menu_icona_mute.Checked = 1
            Menu_alto_mute.Checked = 1
        Else 'se non è muto
            btnmuto.Text = "Attiva &Muto"
            Menu_icona_mute.Text = "Mute"
            Menu_icona_mute.Checked = 0
            Menu_alto_mute.Checked = 0
        End If
    End Sub

    Public Sub tmraggiorna_tempo_Tick(sender As System.Object, e As System.EventArgs) Handles tmraggiorna.Tick
        If (device.AudioEndpointVolume.MasterVolumeLevelScalar > massimo / 100) Then
            device.AudioEndpointVolume.MasterVolumeLevelScalar = massimo / 100
            trkvolume.Value = CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
        End If
        trkvolume.Value = CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
        lblvolume.Text = CStr(CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)) & "%"
        lblmax.Text = CStr(massimo) & "%"
        Area_notifica.Text = CStr(CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)) & "%"

        track_ico.Value = Int(trkvolume.Value / (trkvolume.Maximum / track_ico.Maximum))

        'permette la grafica della batteria
        PercentualeBatteria = StatoBatteria.BatteryLifePercent * 100

        Select Case PercentualeBatteria \ 10
            Case 0
                imm_batteria.Image = audio.My.Resources.batteria_10
            Case 1
                imm_batteria.Image = audio.My.Resources.batteria_20
            Case 2
                imm_batteria.Image = audio.My.Resources.batteria_30
            Case 3
                imm_batteria.Image = audio.My.Resources.batteria_40
            Case 4
                imm_batteria.Image = audio.My.Resources.batteria_50
            Case 5
                imm_batteria.Image = audio.My.Resources.batteria_60
            Case 6
                imm_batteria.Image = audio.My.Resources.batteria_70
            Case 7
                imm_batteria.Image = audio.My.Resources.batteria_80
            Case 8
                imm_batteria.Image = audio.My.Resources.batteria_90
            Case 9
                imm_batteria.Image = audio.My.Resources.batteria_100
            Case 10
                imm_batteria.Image = audio.My.Resources.batteria_100
        End Select

        If (StatoBatteria.PowerLineStatus = PowerLineStatus.Online) Then 'in carica
            imm_batteria.Image = audio.My.Resources.batteria_incarica
        End If

        lblbatteria.Text = PercentualeBatteria & "%"

        If (StatoBatteria.BatteryLifeRemaining >= 0) Then
            Dim ore As Integer = 0
            Dim minuti As Integer = 0
            minuti = StatoBatteria.BatteryLifeRemaining / 60
            ore = minuti / 60
            minuti -= ore * 60
            lbltempocarica.Text = ore & ":" & minuti
        Else
            lbltempocarica.Visible = 0
        End If

    End Sub

    Private Sub btncambia_Click(sender As System.Object, e As System.EventArgs) Handles btncambia.Click
        Form2.ShowDialog()
    End Sub

    Private Sub btncambia_psw_Click(sender As System.Object, e As System.EventArgs) Handles btncambia_psw.Click
        Form3.ShowDialog()
    End Sub

    Private Sub ApriToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Menu_icona_apri.Click
        Me.ShowInTaskbar = 1
        Me.Area_notifica.Visible = 0
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        If (Me.WindowState = FormWindowState.Minimized) Then
            Area_notifica.Visible = 1
            Me.ShowInTaskbar = 0
            Menu_icona_volume.DropDown = Menu_volume
        Else
            Area_notifica.Visible = 0
            Me.ShowInTaskbar = 1
            Menu_alto_volume.DropDown = Menu_volume
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Area_notifica.MouseDoubleClick
        Menu_icona_apri.PerformClick()
    End Sub

    Private Sub MutoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles Menu_icona_mute.Click
        btnmuto.PerformClick()
    End Sub

    Private Sub Menu_alto_mute_Click(sender As System.Object, e As System.EventArgs) Handles Menu_alto_mute.Click
        btnmuto.PerformClick()
    End Sub

    Private Sub Menu_alto_massimo_Click(sender As System.Object, e As System.EventArgs) Handles Menu_alto_massimo.Click
        cambia_volume(massimo / 100)
    End Sub

    Private Sub Menu_alto_chiudi_Click(sender As System.Object, e As System.EventArgs) Handles Menu_alto_chiudi.Click, Menu_chiudi.Click
        Me.Close()
    End Sub

    Private Sub tmrtempo_tentativi_Tick(sender As System.Object, e As System.EventArgs) Handles tmrtempo_tentativi.Tick
        If (tentativi = 0) Then Exit Sub

        tempo_tentativi -= 1
        If (tempo_tentativi = 0) Then
            If (tentativi > 0) Then
                tentativi -= 1
            End If
            tempo_tentativi = 300
        End If

    End Sub

    Public Sub tmraggiorna_Tick(sender As System.Object, e As System.EventArgs) Handles tmraggiorna_tempo_tentativi.Tick
        Form3.lbltentativi.Text = tentativi & "/" & max_tentativi
        Form4.lbltentativi.Text = tentativi & "/" & max_tentativi

        If (tentativi = max_tentativi) Then
            Form3.lbltentativi.ForeColor = Color.Red
            Form4.lbltentativi.ForeColor = Color.Red
        Else
            Form3.lbltentativi.ForeColor = DefaultForeColor
            Form4.lbltentativi.ForeColor = DefaultForeColor
        End If

        tempo_tentativi_str = ""
        Dim minuti As UInteger = tempo_tentativi \ 60
        Dim secondi As UInteger = tempo_tentativi - minuti * 60

        If minuti < 10 Then
            tempo_tentativi_str &= "0"
        End If
        tempo_tentativi_str &= minuti & ":"

        If secondi < 10 Then
            tempo_tentativi_str &= "0"
        End If
        tempo_tentativi_str &= secondi

        lbltempo.Text = tempo_tentativi_str
    End Sub

    Private Sub Menu_icona_massimo_Click(sender As System.Object, e As System.EventArgs) Handles Menu_icona_massimo.Click
        cambia_volume(massimo / 100)
    End Sub

    Private Sub Menu_icona_chiudi_Click(sender As System.Object, e As System.EventArgs) Handles Menu_icona_chiudi.Click
        Me.Close()
    End Sub

    Private Sub tmrsalva_profili_Tick(sender As System.Object, e As System.EventArgs) Handles tmrsalva_profili.Tick
        salva_profilo(profilo_attuale & ".ini")
    End Sub

    Private Sub RinominaProfiloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RinominaProfiloToolStripMenuItem.Click
        Dim nuovo As String = Trim(InputBox("Nuovo nome per il profilo """ & profilo_attuale & """.", "Rinomina Profilo", profilo_attuale))
        rinomina_profilo(profilo_attuale, nuovo)
    End Sub
End Class