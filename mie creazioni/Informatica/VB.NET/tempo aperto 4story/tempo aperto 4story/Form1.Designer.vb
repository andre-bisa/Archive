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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrtimer = New System.Windows.Forms.Timer(Me.components)
        Me.btninizia = New System.Windows.Forms.Button()
        Me.lbltempo = New System.Windows.Forms.Label()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.lbltitolo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnchiudi = New System.Windows.Forms.Button()
        Me.btnapri = New System.Windows.Forms.Button()
        Me.tipo_tempo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcountdown = New System.Windows.Forms.Label()
        Me.btnannulla = New System.Windows.Forms.Button()
        Me.btnfai = New System.Windows.Forms.Button()
        Me.txttempo = New System.Windows.Forms.NumericUpDown()
        Me.opt4story = New System.Windows.Forms.RadioButton()
        Me.optpc = New System.Windows.Forms.RadioButton()
        Me.tmrchiusura = New System.Windows.Forms.Timer(Me.components)
        Me.btnallarga_stringi = New System.Windows.Forms.Button()
        Me.tmrfinestra = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.txttempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrtimer
        '
        Me.tmrtimer.Interval = 1000
        '
        'btninizia
        '
        Me.btninizia.Location = New System.Drawing.Point(38, 156)
        Me.btninizia.Name = "btninizia"
        Me.btninizia.Size = New System.Drawing.Size(83, 23)
        Me.btninizia.TabIndex = 0
        Me.btninizia.Text = "Inizia!"
        Me.btninizia.UseVisualStyleBackColor = True
        '
        'lbltempo
        '
        Me.lbltempo.AutoSize = True
        Me.lbltempo.Location = New System.Drawing.Point(109, 209)
        Me.lbltempo.Name = "lbltempo"
        Me.lbltempo.Size = New System.Drawing.Size(49, 13)
        Me.lbltempo.TabIndex = 1
        Me.lbltempo.Text = "00:00:00"
        '
        'btnstop
        '
        Me.btnstop.Location = New System.Drawing.Point(150, 156)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(83, 23)
        Me.btnstop.TabIndex = 2
        Me.btnstop.Text = "Azzera!"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'lbltitolo
        '
        Me.lbltitolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitolo.ForeColor = System.Drawing.Color.Red
        Me.lbltitolo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitolo.Name = "lbltitolo"
        Me.lbltitolo.Size = New System.Drawing.Size(346, 46)
        Me.lbltitolo.TabIndex = 3
        Me.lbltitolo.Text = "Contatore di tempo"
        Me.lbltitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ecco quanto tempo stai su 4story"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnchiudi
        '
        Me.btnchiudi.Location = New System.Drawing.Point(150, 109)
        Me.btnchiudi.Name = "btnchiudi"
        Me.btnchiudi.Size = New System.Drawing.Size(83, 23)
        Me.btnchiudi.TabIndex = 5
        Me.btnchiudi.Text = "Chiudi 4Story"
        Me.btnchiudi.UseVisualStyleBackColor = True
        '
        'btnapri
        '
        Me.btnapri.Location = New System.Drawing.Point(38, 109)
        Me.btnapri.Name = "btnapri"
        Me.btnapri.Size = New System.Drawing.Size(83, 23)
        Me.btnapri.TabIndex = 6
        Me.btnapri.Text = "Apri 4Story"
        Me.btnapri.UseVisualStyleBackColor = True
        '
        'tipo_tempo
        '
        Me.tipo_tempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipo_tempo.FormattingEnabled = True
        Me.tipo_tempo.Location = New System.Drawing.Point(162, 28)
        Me.tipo_tempo.Name = "tipo_tempo"
        Me.tipo_tempo.Size = New System.Drawing.Size(66, 21)
        Me.tipo_tempo.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcountdown)
        Me.GroupBox1.Controls.Add(Me.btnannulla)
        Me.GroupBox1.Controls.Add(Me.btnfai)
        Me.GroupBox1.Controls.Add(Me.txttempo)
        Me.GroupBox1.Controls.Add(Me.tipo_tempo)
        Me.GroupBox1.Controls.Add(Me.opt4story)
        Me.GroupBox1.Controls.Add(Me.optpc)
        Me.GroupBox1.Location = New System.Drawing.Point(389, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 130)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chiusura"
        '
        'lblcountdown
        '
        Me.lblcountdown.AutoSize = True
        Me.lblcountdown.Location = New System.Drawing.Point(92, 104)
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(0, 13)
        Me.lblcountdown.TabIndex = 10
        '
        'btnannulla
        '
        Me.btnannulla.Enabled = False
        Me.btnannulla.Location = New System.Drawing.Point(132, 74)
        Me.btnannulla.Name = "btnannulla"
        Me.btnannulla.Size = New System.Drawing.Size(75, 23)
        Me.btnannulla.TabIndex = 9
        Me.btnannulla.Text = "Annulla"
        Me.btnannulla.UseVisualStyleBackColor = True
        '
        'btnfai
        '
        Me.btnfai.Location = New System.Drawing.Point(21, 74)
        Me.btnfai.Name = "btnfai"
        Me.btnfai.Size = New System.Drawing.Size(75, 23)
        Me.btnfai.TabIndex = 8
        Me.btnfai.Text = "Fai"
        Me.btnfai.UseVisualStyleBackColor = True
        '
        'txttempo
        '
        Me.txttempo.Location = New System.Drawing.Point(87, 29)
        Me.txttempo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txttempo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txttempo.Name = "txttempo"
        Me.txttempo.Size = New System.Drawing.Size(59, 20)
        Me.txttempo.TabIndex = 2
        Me.txttempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txttempo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'opt4story
        '
        Me.opt4story.AutoSize = True
        Me.opt4story.Checked = True
        Me.opt4story.Location = New System.Drawing.Point(6, 23)
        Me.opt4story.Name = "opt4story"
        Me.opt4story.Size = New System.Drawing.Size(55, 17)
        Me.opt4story.TabIndex = 1
        Me.opt4story.TabStop = True
        Me.opt4story.Text = "4Story"
        Me.opt4story.UseVisualStyleBackColor = True
        '
        'optpc
        '
        Me.optpc.AutoSize = True
        Me.optpc.Location = New System.Drawing.Point(6, 46)
        Me.optpc.Name = "optpc"
        Me.optpc.Size = New System.Drawing.Size(39, 17)
        Me.optpc.TabIndex = 0
        Me.optpc.Text = "PC"
        Me.optpc.UseVisualStyleBackColor = True
        '
        'tmrchiusura
        '
        Me.tmrchiusura.Interval = 1000
        '
        'btnallarga_stringi
        '
        Me.btnallarga_stringi.Location = New System.Drawing.Point(284, 108)
        Me.btnallarga_stringi.Name = "btnallarga_stringi"
        Me.btnallarga_stringi.Size = New System.Drawing.Size(75, 23)
        Me.btnallarga_stringi.TabIndex = 9
        Me.btnallarga_stringi.Text = "Allarga -->"
        Me.btnallarga_stringi.UseVisualStyleBackColor = True
        '
        'tmrfinestra
        '
        Me.tmrfinestra.Interval = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 262)
        Me.Controls.Add(Me.btnallarga_stringi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnapri)
        Me.Controls.Add(Me.btnchiudi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltitolo)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.lbltempo)
        Me.Controls.Add(Me.btninizia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Contatore Tempo 4Story"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txttempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrtimer As System.Windows.Forms.Timer
    Friend WithEvents btninizia As System.Windows.Forms.Button
    Friend WithEvents lbltempo As System.Windows.Forms.Label
    Friend WithEvents btnstop As System.Windows.Forms.Button
    Friend WithEvents lbltitolo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnchiudi As System.Windows.Forms.Button
    Friend WithEvents btnapri As System.Windows.Forms.Button
    Friend WithEvents tipo_tempo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opt4story As System.Windows.Forms.RadioButton
    Friend WithEvents optpc As System.Windows.Forms.RadioButton
    Friend WithEvents txttempo As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnannulla As System.Windows.Forms.Button
    Friend WithEvents btnfai As System.Windows.Forms.Button
    Friend WithEvents tmrchiusura As System.Windows.Forms.Timer
    Friend WithEvents lblcountdown As System.Windows.Forms.Label
    Friend WithEvents btnallarga_stringi As System.Windows.Forms.Button
    Friend WithEvents tmrfinestra As System.Windows.Forms.Timer

End Class
