<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim Label3 As System.Windows.Forms.Label
        Dim Menu_profili As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Menu_profili_contenuto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ScegliProfiloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RinominaProfiloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_icona_volume = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_volume = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblvolume = New System.Windows.Forms.Label()
        Me.trkvolume = New System.Windows.Forms.TrackBar()
        Me.btnmuto = New System.Windows.Forms.Button()
        Me.tmraggiorna = New System.Windows.Forms.Timer(Me.components)
        Me.btncambia = New System.Windows.Forms.Button()
        Me.lblmax = New System.Windows.Forms.Label()
        Me.btncambia_psw = New System.Windows.Forms.Button()
        Me.Area_notifica = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Menu_area_notifica = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_icona_apri = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_icona_mute = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_icona_massimo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_icona_chiudi = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblbatteria = New System.Windows.Forms.Label()
        Me.lbltempocarica = New System.Windows.Forms.Label()
        Me.Menu_alto = New System.Windows.Forms.MenuStrip()
        Me.Menu_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_alto_mute = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_alto_volume = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_alto_massimo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_alto_chiudi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_chiudi = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrtempo_tentativi = New System.Windows.Forms.Timer(Me.components)
        Me.tmraggiorna_tempo_tentativi = New System.Windows.Forms.Timer(Me.components)
        Me.imm_batteria = New System.Windows.Forms.PictureBox()
        Me.lbltempo = New System.Windows.Forms.Label()
        Me.tmrsalva_profili = New System.Windows.Forms.Timer(Me.components)
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Label3 = New System.Windows.Forms.Label()
        Menu_profili = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_profili_contenuto.SuspendLayout()
        Me.Menu_volume.SuspendLayout()
        CType(Me.trkvolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_area_notifica.SuspendLayout()
        Me.Menu_alto.SuspendLayout()
        CType(Me.imm_batteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 39)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(80, 13)
        Label2.TabIndex = 1
        Label2.Text = "Volume attuale:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 65)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(135, 13)
        Label1.TabIndex = 3
        Label1.Text = "Valore massimo consentito:"
        '
        'ToolStripSeparator2
        '
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New System.Drawing.Size(32, 6)
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(119, 6)
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 324)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(112, 13)
        Label3.TabIndex = 12
        Label3.Text = "Tempo nuovi tentativi:"
        '
        'Menu_profili
        '
        Menu_profili.DropDown = Me.Menu_profili_contenuto
        Menu_profili.Name = "Menu_profili"
        Menu_profili.Size = New System.Drawing.Size(50, 20)
        Menu_profili.Text = "Profili"
        '
        'Menu_profili_contenuto
        '
        Me.Menu_profili_contenuto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScegliProfiloToolStripMenuItem, Me.RinominaProfiloToolStripMenuItem})
        Me.Menu_profili_contenuto.Name = "Menu_profili_contenuto"
        Me.Menu_profili_contenuto.OwnerItem = Menu_profili
        Me.Menu_profili_contenuto.ShowCheckMargin = True
        Me.Menu_profili_contenuto.ShowImageMargin = False
        Me.Menu_profili_contenuto.Size = New System.Drawing.Size(164, 70)
        '
        'ScegliProfiloToolStripMenuItem
        '
        Me.ScegliProfiloToolStripMenuItem.Name = "ScegliProfiloToolStripMenuItem"
        Me.ScegliProfiloToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ScegliProfiloToolStripMenuItem.Text = "Scegli Profilo"
        '
        'RinominaProfiloToolStripMenuItem
        '
        Me.RinominaProfiloToolStripMenuItem.Name = "RinominaProfiloToolStripMenuItem"
        Me.RinominaProfiloToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RinominaProfiloToolStripMenuItem.Text = "Rinomina Profilo"
        '
        'Menu_icona_volume
        '
        Me.Menu_icona_volume.Name = "Menu_icona_volume"
        Me.Menu_icona_volume.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.Menu_icona_volume.ShowShortcutKeys = False
        Me.Menu_icona_volume.Size = New System.Drawing.Size(122, 22)
        Me.Menu_icona_volume.Text = "&Volume"
        Me.Menu_icona_volume.ToolTipText = "Volume"
        '
        'Menu_volume
        '
        Me.Menu_volume.Items.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripSeparator2})
        Me.Menu_volume.Name = "Menu_area_notifica_volume"
        Me.Menu_volume.ShowImageMargin = False
        Me.Menu_volume.ShowItemToolTips = False
        Me.Menu_volume.Size = New System.Drawing.Size(36, 10)
        '
        'lblvolume
        '
        Me.lblvolume.Location = New System.Drawing.Point(153, 34)
        Me.lblvolume.Name = "lblvolume"
        Me.lblvolume.Size = New System.Drawing.Size(40, 23)
        Me.lblvolume.TabIndex = 0
        Me.lblvolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trkvolume
        '
        Me.trkvolume.LargeChange = 10
        Me.trkvolume.Location = New System.Drawing.Point(12, 81)
        Me.trkvolume.Maximum = 100
        Me.trkvolume.Name = "trkvolume"
        Me.trkvolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkvolume.Size = New System.Drawing.Size(45, 240)
        Me.trkvolume.TabIndex = 0
        Me.trkvolume.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'btnmuto
        '
        Me.btnmuto.Location = New System.Drawing.Point(66, 119)
        Me.btnmuto.Name = "btnmuto"
        Me.btnmuto.Size = New System.Drawing.Size(75, 49)
        Me.btnmuto.TabIndex = 1
        Me.btnmuto.Text = "Attiva &Muto"
        Me.btnmuto.UseVisualStyleBackColor = True
        '
        'tmraggiorna
        '
        Me.tmraggiorna.Interval = 50
        '
        'btncambia
        '
        Me.btncambia.Location = New System.Drawing.Point(66, 174)
        Me.btncambia.Name = "btncambia"
        Me.btncambia.Size = New System.Drawing.Size(75, 49)
        Me.btncambia.TabIndex = 2
        Me.btncambia.Text = "&Cambia Valore Massimo"
        Me.btncambia.UseVisualStyleBackColor = True
        '
        'lblmax
        '
        Me.lblmax.Location = New System.Drawing.Point(153, 60)
        Me.lblmax.Name = "lblmax"
        Me.lblmax.Size = New System.Drawing.Size(40, 23)
        Me.lblmax.TabIndex = 4
        Me.lblmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncambia_psw
        '
        Me.btncambia_psw.Location = New System.Drawing.Point(66, 229)
        Me.btncambia_psw.Name = "btncambia_psw"
        Me.btncambia_psw.Size = New System.Drawing.Size(75, 49)
        Me.btncambia_psw.TabIndex = 3
        Me.btncambia_psw.Text = "Gestisci &Password"
        Me.btncambia_psw.UseVisualStyleBackColor = True
        '
        'Area_notifica
        '
        Me.Area_notifica.ContextMenuStrip = Me.Menu_area_notifica
        Me.Area_notifica.Icon = CType(resources.GetObject("Area_notifica.Icon"), System.Drawing.Icon)
        Me.Area_notifica.Text = "Volume"
        Me.Area_notifica.Visible = True
        '
        'Menu_area_notifica
        '
        Me.Menu_area_notifica.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_icona_apri, ToolStripSeparator1, Me.Menu_icona_mute, Me.Menu_icona_volume, Me.Menu_icona_massimo, Me.Menu_icona_chiudi})
        Me.Menu_area_notifica.Name = "ContextMenuStrip1"
        Me.Menu_area_notifica.ShowCheckMargin = True
        Me.Menu_area_notifica.ShowImageMargin = False
        Me.Menu_area_notifica.Size = New System.Drawing.Size(123, 120)
        '
        'Menu_icona_apri
        '
        Me.Menu_icona_apri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Menu_icona_apri.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_icona_apri.MergeIndex = 0
        Me.Menu_icona_apri.Name = "Menu_icona_apri"
        Me.Menu_icona_apri.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.Menu_icona_apri.ShowShortcutKeys = False
        Me.Menu_icona_apri.Size = New System.Drawing.Size(122, 22)
        Me.Menu_icona_apri.Text = "&Apri"
        Me.Menu_icona_apri.ToolTipText = "Apri"
        '
        'Menu_icona_mute
        '
        Me.Menu_icona_mute.Name = "Menu_icona_mute"
        Me.Menu_icona_mute.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.Menu_icona_mute.ShowShortcutKeys = False
        Me.Menu_icona_mute.Size = New System.Drawing.Size(122, 22)
        Me.Menu_icona_mute.Text = "&Mute"
        '
        'Menu_icona_massimo
        '
        Me.Menu_icona_massimo.Name = "Menu_icona_massimo"
        Me.Menu_icona_massimo.Size = New System.Drawing.Size(122, 22)
        Me.Menu_icona_massimo.Text = "&Massimo"
        '
        'Menu_icona_chiudi
        '
        Me.Menu_icona_chiudi.Name = "Menu_icona_chiudi"
        Me.Menu_icona_chiudi.Size = New System.Drawing.Size(122, 22)
        Me.Menu_icona_chiudi.Text = "&Chiudi"
        '
        'lblbatteria
        '
        Me.lblbatteria.Location = New System.Drawing.Point(156, 245)
        Me.lblbatteria.Name = "lblbatteria"
        Me.lblbatteria.Size = New System.Drawing.Size(37, 19)
        Me.lblbatteria.TabIndex = 7
        Me.lblbatteria.Text = "%"
        Me.lblbatteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltempocarica
        '
        Me.lbltempocarica.Location = New System.Drawing.Point(156, 264)
        Me.lbltempocarica.Name = "lbltempocarica"
        Me.lbltempocarica.Size = New System.Drawing.Size(37, 19)
        Me.lbltempocarica.TabIndex = 9
        Me.lbltempocarica.Text = "00:00"
        Me.lbltempocarica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu_alto
        '
        Me.Menu_alto.Dock = System.Windows.Forms.DockStyle.None
        Me.Menu_alto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_file, Menu_profili, Me.Menu_chiudi})
        Me.Menu_alto.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Menu_alto.Location = New System.Drawing.Point(0, 0)
        Me.Menu_alto.Name = "Menu_alto"
        Me.Menu_alto.ShowItemToolTips = True
        Me.Menu_alto.Size = New System.Drawing.Size(241, 24)
        Me.Menu_alto.TabIndex = 10
        Me.Menu_alto.Text = "MenuStrip1"
        '
        'Menu_file
        '
        Me.Menu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_alto_mute, Me.Menu_alto_volume, Me.Menu_alto_massimo, Me.Menu_alto_chiudi})
        Me.Menu_file.Name = "Menu_file"
        Me.Menu_file.Size = New System.Drawing.Size(37, 20)
        Me.Menu_file.Text = "&File"
        '
        'Menu_alto_mute
        '
        Me.Menu_alto_mute.Name = "Menu_alto_mute"
        Me.Menu_alto_mute.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.Menu_alto_mute.Size = New System.Drawing.Size(165, 22)
        Me.Menu_alto_mute.Text = "&Mute"
        '
        'Menu_alto_volume
        '
        Me.Menu_alto_volume.Name = "Menu_alto_volume"
        Me.Menu_alto_volume.Size = New System.Drawing.Size(165, 22)
        Me.Menu_alto_volume.Text = "&Volume"
        '
        'Menu_alto_massimo
        '
        Me.Menu_alto_massimo.Name = "Menu_alto_massimo"
        Me.Menu_alto_massimo.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.Menu_alto_massimo.Size = New System.Drawing.Size(165, 22)
        Me.Menu_alto_massimo.Text = "&Massimo"
        '
        'Menu_alto_chiudi
        '
        Me.Menu_alto_chiudi.Name = "Menu_alto_chiudi"
        Me.Menu_alto_chiudi.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Menu_alto_chiudi.Size = New System.Drawing.Size(165, 22)
        Me.Menu_alto_chiudi.Text = "&Chiudi"
        '
        'Menu_chiudi
        '
        Me.Menu_chiudi.Name = "Menu_chiudi"
        Me.Menu_chiudi.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Menu_chiudi.Size = New System.Drawing.Size(54, 20)
        Me.Menu_chiudi.Text = "&Chiudi"
        '
        'tmrtempo_tentativi
        '
        Me.tmrtempo_tentativi.Interval = 1000
        '
        'tmraggiorna_tempo_tentativi
        '
        '
        'imm_batteria
        '
        Me.imm_batteria.ErrorImage = CType(resources.GetObject("imm_batteria.ErrorImage"), System.Drawing.Image)
        Me.imm_batteria.Image = Global.audio.My.Resources.Resources.batteria
        Me.imm_batteria.InitialImage = Global.audio.My.Resources.Resources.batteria
        Me.imm_batteria.Location = New System.Drawing.Point(156, 119)
        Me.imm_batteria.Name = "imm_batteria"
        Me.imm_batteria.Size = New System.Drawing.Size(40, 120)
        Me.imm_batteria.TabIndex = 11
        Me.imm_batteria.TabStop = False
        '
        'lbltempo
        '
        Me.lbltempo.AutoSize = True
        Me.lbltempo.Location = New System.Drawing.Point(130, 324)
        Me.lbltempo.Name = "lbltempo"
        Me.lbltempo.Size = New System.Drawing.Size(34, 13)
        Me.lbltempo.TabIndex = 13
        Me.lbltempo.Text = "00:00"
        '
        'tmrsalva_profili
        '
        Me.tmrsalva_profili.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(219, 346)
        Me.Controls.Add(Me.lbltempo)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.imm_batteria)
        Me.Controls.Add(Me.lbltempocarica)
        Me.Controls.Add(Me.lblbatteria)
        Me.Controls.Add(Me.btncambia_psw)
        Me.Controls.Add(Me.lblmax)
        Me.Controls.Add(Me.Menu_alto)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btncambia)
        Me.Controls.Add(Me.btnmuto)
        Me.Controls.Add(Me.trkvolume)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.lblvolume)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audio"
        Me.TopMost = True
        Me.Menu_profili_contenuto.ResumeLayout(False)
        Me.Menu_volume.ResumeLayout(False)
        CType(Me.trkvolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_area_notifica.ResumeLayout(False)
        Me.Menu_alto.ResumeLayout(False)
        Me.Menu_alto.PerformLayout()
        CType(Me.imm_batteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblvolume As System.Windows.Forms.Label
    Friend WithEvents trkvolume As System.Windows.Forms.TrackBar
    Friend WithEvents btnmuto As System.Windows.Forms.Button
    Friend WithEvents tmraggiorna As System.Windows.Forms.Timer
    Friend WithEvents btncambia As System.Windows.Forms.Button
    Friend WithEvents lblmax As System.Windows.Forms.Label
    Friend WithEvents btncambia_psw As System.Windows.Forms.Button
    Friend WithEvents Area_notifica As System.Windows.Forms.NotifyIcon
    Friend WithEvents Menu_area_notifica As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Menu_icona_apri As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_icona_mute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblbatteria As System.Windows.Forms.Label
    Friend WithEvents lbltempocarica As System.Windows.Forms.Label
    Friend WithEvents Menu_alto As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_alto_mute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_alto_volume As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_alto_massimo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_alto_chiudi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_icona_volume As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrtempo_tentativi As System.Windows.Forms.Timer
    Friend WithEvents tmraggiorna_tempo_tentativi As System.Windows.Forms.Timer
    Friend WithEvents Menu_icona_massimo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_icona_chiudi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imm_batteria As System.Windows.Forms.PictureBox
    Friend WithEvents Menu_chiudi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbltempo As System.Windows.Forms.Label
    Friend WithEvents Menu_volume As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Menu_profili_contenuto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tmrsalva_profili As System.Windows.Forms.Timer
    Friend WithEvents ScegliProfiloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RinominaProfiloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
