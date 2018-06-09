<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim GroupBox2 As System.Windows.Forms.GroupBox
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSecondi = New System.Windows.Forms.NumericUpDown()
        Me.cmbaltro = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblcollegato = New System.Windows.Forms.Label()
        Me.lblincarica = New System.Windows.Forms.Label()
        Me.lblPercentuale = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnannulla = New System.Windows.Forms.Button()
        Me.btnSalva = New System.Windows.Forms.Button()
        Me.tmrLoop = New System.Windows.Forms.Timer(Me.components)
        Me.tmrbatteriacriticasecondi = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.txtpercentualeavviso = New System.Windows.Forms.NumericUpDown()
        Me.chksogliacriticaavviso = New System.Windows.Forms.CheckBox()
        Me.chkazioneattiva = New System.Windows.Forms.CheckBox()
        Me.txtsogliacriticaesegui = New System.Windows.Forms.TextBox()
        Me.optaltro = New System.Windows.Forms.RadioButton()
        Me.optEsegui = New System.Windows.Forms.RadioButton()
        Me.txtsogliacritica = New System.Windows.Forms.NumericUpDown()
        Me.chkstartup = New System.Windows.Forms.CheckBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox2 = New System.Windows.Forms.GroupBox()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        GroupBox1.SuspendLayout()
        CType(Me.txtSecondi, System.ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.txtpercentualeavviso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsogliacritica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Label1.Location = New System.Drawing.Point(45, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(87, 23)
        Label1.TabIndex = 0
        Label1.Text = "Percentuale"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(149, 16)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(87, 20)
        Label2.TabIndex = 7
        Label2.Text = "Percentuale"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label2.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(303, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(15, 20)
        Label3.TabIndex = 9
        Label3.Text = "%"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label3.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(7, 54)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(56, 20)
        Label4.TabIndex = 10
        Label4.Text = "Azione"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(282, 54)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(56, 20)
        Label5.TabIndex = 15
        Label5.Text = "Secondi"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label5.UseCompatibleTextRendering = True
        '
        'GroupBox1
        '
        GroupBox1.Controls.Add(Me.txtSecondi)
        GroupBox1.Controls.Add(Me.chkazioneattiva)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Me.cmbaltro)
        GroupBox1.Controls.Add(Me.txtsogliacriticaesegui)
        GroupBox1.Controls.Add(Me.optaltro)
        GroupBox1.Controls.Add(Me.optEsegui)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Me.txtsogliacritica)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New System.Drawing.Point(6, 54)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(426, 96)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Soglia critica"
        '
        'txtSecondi
        '
        Me.txtSecondi.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.gestione_computer.My.MySettings.Default, "SogliaCriticaValoreSecondi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtSecondi.Location = New System.Drawing.Point(344, 54)
        Me.txtSecondi.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.txtSecondi.Name = "txtSecondi"
        Me.txtSecondi.Size = New System.Drawing.Size(76, 20)
        Me.txtSecondi.TabIndex = 19
        Me.txtSecondi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbaltro
        '
        Me.cmbaltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbaltro.FormattingEnabled = True
        Me.cmbaltro.Items.AddRange(New Object() {"Sospensione", "Ibernazione", "Chiusura"})
        Me.cmbaltro.Location = New System.Drawing.Point(133, 64)
        Me.cmbaltro.Name = "cmbaltro"
        Me.cmbaltro.Size = New System.Drawing.Size(130, 21)
        Me.cmbaltro.TabIndex = 14
        '
        'GroupBox2
        '
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Me.txtpercentualeavviso)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Me.chksogliacriticaavviso)
        GroupBox2.Location = New System.Drawing.Point(6, 156)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New System.Drawing.Size(426, 54)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "Avviso batteria bassa"
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(238, 16)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(15, 20)
        Label6.TabIndex = 20
        Label6.Text = "%"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label6.UseCompatibleTextRendering = True
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(84, 16)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(87, 20)
        Label7.TabIndex = 18
        Label7.Text = "Percentuale"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Label7.UseCompatibleTextRendering = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(18, 9)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(479, 258)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(GroupBox2)
        Me.TabPage1.Controls.Add(Me.lblcollegato)
        Me.TabPage1.Controls.Add(Me.lblincarica)
        Me.TabPage1.Controls.Add(GroupBox1)
        Me.TabPage1.Controls.Add(Me.lblPercentuale)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Location = New System.Drawing.Point(35, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(440, 250)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Batteria"
        '
        'lblcollegato
        '
        Me.lblcollegato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcollegato.Location = New System.Drawing.Point(208, 16)
        Me.lblcollegato.Name = "lblcollegato"
        Me.lblcollegato.Size = New System.Drawing.Size(87, 23)
        Me.lblcollegato.TabIndex = 6
        Me.lblcollegato.Text = "Collegato"
        Me.lblcollegato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblcollegato.UseCompatibleTextRendering = True
        '
        'lblincarica
        '
        Me.lblincarica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblincarica.Location = New System.Drawing.Point(301, 16)
        Me.lblincarica.Name = "lblincarica"
        Me.lblincarica.Size = New System.Drawing.Size(87, 23)
        Me.lblincarica.TabIndex = 5
        Me.lblincarica.Text = "In Carica"
        Me.lblincarica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblincarica.UseCompatibleTextRendering = True
        '
        'lblPercentuale
        '
        Me.lblPercentuale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentuale.Location = New System.Drawing.Point(138, 16)
        Me.lblPercentuale.Name = "lblPercentuale"
        Me.lblPercentuale.Size = New System.Drawing.Size(39, 23)
        Me.lblPercentuale.TabIndex = 3
        Me.lblPercentuale.Text = "...%"
        Me.lblPercentuale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPercentuale.UseCompatibleTextRendering = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(35, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(440, 250)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Volume"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.chkstartup)
        Me.TabPage3.Location = New System.Drawing.Point(35, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(440, 250)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        '
        'btnannulla
        '
        Me.btnannulla.Location = New System.Drawing.Point(263, 265)
        Me.btnannulla.Name = "btnannulla"
        Me.btnannulla.Size = New System.Drawing.Size(75, 23)
        Me.btnannulla.TabIndex = 8
        Me.btnannulla.Text = "Annulla"
        Me.btnannulla.UseVisualStyleBackColor = True
        '
        'btnSalva
        '
        Me.btnSalva.Location = New System.Drawing.Point(149, 265)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva.TabIndex = 7
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'tmrLoop
        '
        Me.tmrLoop.Enabled = True
        '
        'tmrbatteriacriticasecondi
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Gestione computer"
        Me.NotifyIcon1.Visible = True
        '
        'txtpercentualeavviso
        '
        Me.txtpercentualeavviso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.gestione_computer.My.MySettings.Default, "AvvisoBatteriaPercentuale", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtpercentualeavviso.Location = New System.Drawing.Point(177, 16)
        Me.txtpercentualeavviso.Name = "txtpercentualeavviso"
        Me.txtpercentualeavviso.Size = New System.Drawing.Size(55, 20)
        Me.txtpercentualeavviso.TabIndex = 19
        Me.txtpercentualeavviso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpercentualeavviso.Value = Global.gestione_computer.My.MySettings.Default.AvvisoBatteriaPercentuale
        '
        'chksogliacriticaavviso
        '
        Me.chksogliacriticaavviso.AutoSize = True
        Me.chksogliacriticaavviso.Checked = Global.gestione_computer.My.MySettings.Default.AvvisoBatteriaAvviso
        Me.chksogliacriticaavviso.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksogliacriticaavviso.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.gestione_computer.My.MySettings.Default, "SogliaCriticaAvviso", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chksogliacriticaavviso.Location = New System.Drawing.Point(7, 19)
        Me.chksogliacriticaavviso.Name = "chksogliacriticaavviso"
        Me.chksogliacriticaavviso.Size = New System.Drawing.Size(59, 17)
        Me.chksogliacriticaavviso.TabIndex = 17
        Me.chksogliacriticaavviso.Text = "Attivo?"
        Me.chksogliacriticaavviso.UseVisualStyleBackColor = True
        '
        'chkazioneattiva
        '
        Me.chkazioneattiva.AutoSize = True
        Me.chkazioneattiva.Checked = Global.gestione_computer.My.MySettings.Default.SogliaCriticaEseguiAzione
        Me.chkazioneattiva.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.gestione_computer.My.MySettings.Default, "SogliaCriticaEseguiAzione", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkazioneattiva.Location = New System.Drawing.Point(7, 19)
        Me.chkazioneattiva.Name = "chkazioneattiva"
        Me.chkazioneattiva.Size = New System.Drawing.Size(98, 17)
        Me.chkazioneattiva.TabIndex = 18
        Me.chkazioneattiva.Text = "Esegui azione?"
        Me.chkazioneattiva.UseVisualStyleBackColor = True
        '
        'txtsogliacriticaesegui
        '
        Me.txtsogliacriticaesegui.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.gestione_computer.My.MySettings.Default, "SogliaCriticaEsegui", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtsogliacriticaesegui.Location = New System.Drawing.Point(132, 41)
        Me.txtsogliacriticaesegui.Name = "txtsogliacriticaesegui"
        Me.txtsogliacriticaesegui.Size = New System.Drawing.Size(131, 20)
        Me.txtsogliacriticaesegui.TabIndex = 13
        Me.txtsogliacriticaesegui.Text = Global.gestione_computer.My.MySettings.Default.SogliaCriticaEsegui
        '
        'optaltro
        '
        Me.optaltro.AutoSize = True
        Me.optaltro.Checked = Global.gestione_computer.My.MySettings.Default.SogliaCriticaAltroCombo
        Me.optaltro.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.gestione_computer.My.MySettings.Default, "SogliaCriticaAltroCombo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.optaltro.Location = New System.Drawing.Point(70, 65)
        Me.optaltro.Name = "optaltro"
        Me.optaltro.Size = New System.Drawing.Size(46, 17)
        Me.optaltro.TabIndex = 12
        Me.optaltro.Text = "Altro"
        Me.optaltro.UseVisualStyleBackColor = True
        '
        'optEsegui
        '
        Me.optEsegui.AutoSize = True
        Me.optEsegui.Checked = Global.gestione_computer.My.MySettings.Default.SogliaCriticaEseguiCombo
        Me.optEsegui.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.gestione_computer.My.MySettings.Default, "SogliaCriticaEseguiCombo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.optEsegui.Location = New System.Drawing.Point(69, 42)
        Me.optEsegui.Name = "optEsegui"
        Me.optEsegui.Size = New System.Drawing.Size(57, 17)
        Me.optEsegui.TabIndex = 11
        Me.optEsegui.TabStop = True
        Me.optEsegui.Text = "Esegui"
        Me.optEsegui.UseVisualStyleBackColor = True
        '
        'txtsogliacritica
        '
        Me.txtsogliacritica.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.gestione_computer.My.MySettings.Default, "SogliaCriticaValue", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtsogliacritica.Location = New System.Drawing.Point(242, 16)
        Me.txtsogliacritica.Name = "txtsogliacritica"
        Me.txtsogliacritica.Size = New System.Drawing.Size(55, 20)
        Me.txtsogliacritica.TabIndex = 8
        Me.txtsogliacritica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtsogliacritica.Value = Global.gestione_computer.My.MySettings.Default.SogliaCriticaPercentuale
        '
        'chkstartup
        '
        Me.chkstartup.AutoSize = True
        Me.chkstartup.Checked = Global.gestione_computer.My.MySettings.Default.Startup
        Me.chkstartup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkstartup.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.gestione_computer.My.MySettings.Default, "Startup", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkstartup.Location = New System.Drawing.Point(19, 26)
        Me.chkstartup.Name = "chkstartup"
        Me.chkstartup.Size = New System.Drawing.Size(152, 17)
        Me.chkstartup.TabIndex = 0
        Me.chkstartup.Text = "Avvia all'avvio di Windows"
        Me.chkstartup.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 300)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnannulla)
        Me.Controls.Add(Me.btnSalva)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione computer"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Me.txtSecondi, System.ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.txtpercentualeavviso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsogliacritica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblPercentuale As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents tmrLoop As System.Windows.Forms.Timer
    Friend WithEvents lblincarica As System.Windows.Forms.Label
    Friend WithEvents lblcollegato As System.Windows.Forms.Label
    Friend WithEvents txtsogliacritica As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnannulla As System.Windows.Forms.Button
    Friend WithEvents cmbaltro As System.Windows.Forms.ComboBox
    Friend WithEvents txtsogliacriticaesegui As System.Windows.Forms.TextBox
    Friend WithEvents optaltro As System.Windows.Forms.RadioButton
    Friend WithEvents optEsegui As System.Windows.Forms.RadioButton
    Friend WithEvents chkazioneattiva As System.Windows.Forms.CheckBox
    Friend WithEvents chksogliacriticaavviso As System.Windows.Forms.CheckBox
    Friend WithEvents tmrbatteriacriticasecondi As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents txtSecondi As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtpercentualeavviso As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkstartup As System.Windows.Forms.CheckBox

End Class
