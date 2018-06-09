Public Class frmMain
    Public DevEnum As New MMDeviceEnumerator()
    Public device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)

    Dim FlagAvviso As Boolean = True


    Public Function get_battery() As Integer
        get_battery = SystemInformation.PowerStatus.BatteryLifePercent * 100
    End Function

    Public Sub set_volume(ByVal nuovo As Single)
        device.AudioEndpointVolume.MasterVolumeLevelScalar = nuovo
    End Sub

    Public Function get_volume() As Integer
        get_volume = Int(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
    End Function

    Public Function get_mute() As Boolean
        get_mute = device.AudioEndpointVolume.Mute
    End Function

    Public Sub set_mute(ByVal flag As Boolean)
        device.AudioEndpointVolume.Mute = flag
    End Sub

    Private Sub batteria_critica()
        If My.Settings.SogliaCriticaEseguiAzione = False Then Exit Sub ' Nessuna azione da compiere
        If My.Settings.SogliaCriticaEseguiCombo Then ' Il primo combobox
            Try
                Process.Start(My.Settings.SogliaCriticaEsegui)
            Catch ex As Exception
            End Try
        Else 'il secondo combobox
            Select Case My.Settings.SogliaCriticaAltroAzione
                Case 0
                    Application.SetSuspendState(PowerState.Suspend, True, False)
                Case 1
                    Application.SetSuspendState(PowerState.Hibernate, True, False)
                Case 2
                    Process.Start("shutdown", "-s -t 1")
                Case Else

            End Select
        End If
    End Sub

    Private Sub LoopBattery() ' eseguita come loop
        If (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.NoSystemBattery) Then
            lblPercentuale.Text = "N/D"
        Else
            lblPercentuale.Text = get_battery() & " %"
        End If
        lblincarica.Enabled = (SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.Charging)
        lblcollegato.Enabled = (SystemInformation.PowerStatus.PowerLineStatus = PowerLineStatus.Online)

        If (FlagAvviso) And (get_battery() <= My.Settings.AvvisoBatteriaPercentuale) And (My.Settings.AvvisoBatteriaAvviso) And (SystemInformation.PowerStatus.BatteryChargeStatus <> BatteryChargeStatus.Charging) And (SystemInformation.PowerStatus.PowerLineStatus <> PowerLineStatus.Online) Then
            FlagAvviso = False
            NotifyIcon1.ShowBalloonTip(5000, "Batteria Critica!", "Il livello della batteria è critico." & vbNewLine & "Verrà eseguita l'azione impostata.", ToolTipIcon.Warning)
        End If

        If (get_battery() <= My.Settings.SogliaCriticaPercentuale) And (SystemInformation.PowerStatus.PowerLineStatus <> PowerLineStatus.Online) Then
            Try
                tmrbatteriacriticasecondi.Interval = 1000 * IIf(CInt(My.Settings.SogliaCriticaValoreSecondi) = 0, 1, CInt(My.Settings.SogliaCriticaValoreSecondi))
            Catch ex As Exception
            End Try
            tmrbatteriacriticasecondi.Start()
        End If
    End Sub

    Private Sub LoopVolume() ' eseguita come loop

    End Sub

    Private Sub tmrLoop_Tick(sender As System.Object, e As System.EventArgs) Handles tmrLoop.Tick
        LoopBattery()
        LoopVolume()
    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click
        My.Settings.Save()
        Try
            If My.Settings.Startup Then
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            Else
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnannulla_Click(sender As System.Object, e As System.EventArgs) Handles btnannulla.Click
        My.Settings.Reload()
        cmbaltro.SelectedIndex = My.Settings.SogliaCriticaAltroAzione
    End Sub

    Public Sub MostraNascondiForm(ByVal flag As Boolean)
        Me.ShowInTaskbar = flag
        Me.ShowIcon = flag
        Me.Visible = flag
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        MostraNascondiForm(False)
    End Sub

    Private Sub frmMain_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            MostraNascondiForm(False)
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        MostraNascondiForm(True)
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbaltro.SelectedIndex = My.Settings.SogliaCriticaAltroAzione
        Try
            If My.Settings.Startup Then
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            Else
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbaltro_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbaltro.SelectedIndexChanged
        My.Settings.SogliaCriticaAltroAzione = cmbaltro.SelectedIndex
    End Sub

    Private Sub optEsegui_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optEsegui.CheckedChanged, optaltro.CheckedChanged
        txtsogliacriticaesegui.Enabled = (optEsegui.Checked)
        cmbaltro.Enabled = (optaltro.Checked)
    End Sub

    Private Sub optaltro_Click(sender As Object, e As System.EventArgs) Handles optaltro.Click
        optaltro.Checked = True
    End Sub

    Private Sub optesegui_Click(sender As Object, e As System.EventArgs) Handles optEsegui.Click
        optEsegui.Checked = True
    End Sub

    Private Sub tmrbatteriacriticasecondi_Tick(sender As System.Object, e As System.EventArgs) Handles tmrbatteriacriticasecondi.Tick
        tmrbatteriacriticasecondi.Stop()
        System.Threading.Tasks.Parallel.Invoke( _
            Sub() batteria_critica(), _
            Sub() MsgBox("Raggiunto il livello di batteria critica." & vbNewLine & "Sta per essere eseguita l'opzione impostata.", MsgBoxStyle.Information, "Batteria critica"))
    End Sub

    Private Sub chkstartup_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkstartup.CheckedChanged

    End Sub
End Class
