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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.btnmanda = New System.Windows.Forms.Button()
        Me.txttesto = New System.Windows.Forms.TextBox()
        Me.barraprogressiva = New System.Windows.Forms.ProgressBar()
        Me.tmriniziale = New System.Windows.Forms.Timer(Me.components)
        Me.lblsecondi = New System.Windows.Forms.Label()
        Me.chba_capo = New System.Windows.Forms.CheckBox()
        Me.chbinfinito = New System.Windows.Forms.CheckBox()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.lblinviate = New System.Windows.Forms.Label()
        Me.txtintervallo = New System.Windows.Forms.NumericUpDown()
        Me.txtvolte = New System.Windows.Forms.NumericUpDown()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.txtintervallo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvolte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmanda
        '
        Me.btnmanda.Location = New System.Drawing.Point(98, 117)
        Me.btnmanda.Name = "btnmanda"
        Me.btnmanda.Size = New System.Drawing.Size(75, 23)
        Me.btnmanda.TabIndex = 2
        Me.btnmanda.Text = "Manda"
        Me.btnmanda.UseVisualStyleBackColor = True
        '
        'txttesto
        '
        Me.txttesto.Location = New System.Drawing.Point(87, 22)
        Me.txttesto.Name = "txttesto"
        Me.txttesto.Size = New System.Drawing.Size(100, 20)
        Me.txttesto.TabIndex = 0
        Me.txttesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'barraprogressiva
        '
        Me.barraprogressiva.Location = New System.Drawing.Point(12, 191)
        Me.barraprogressiva.Name = "barraprogressiva"
        Me.barraprogressiva.Size = New System.Drawing.Size(302, 23)
        Me.barraprogressiva.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.barraprogressiva.TabIndex = 0
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(32, 25)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 2
        Label1.Text = "Testo"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(32, 51)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(31, 13)
        Label2.TabIndex = 3
        Label2.Text = "Volte"
        '
        'tmriniziale
        '
        '
        'lblsecondi
        '
        Me.lblsecondi.Location = New System.Drawing.Point(84, 154)
        Me.lblsecondi.Name = "lblsecondi"
        Me.lblsecondi.Size = New System.Drawing.Size(166, 23)
        Me.lblsecondi.TabIndex = 0
        '
        'chba_capo
        '
        Me.chba_capo.AutoSize = True
        Me.chba_capo.Location = New System.Drawing.Point(193, 24)
        Me.chba_capo.Name = "chba_capo"
        Me.chba_capo.Size = New System.Drawing.Size(87, 17)
        Me.chba_capo.TabIndex = 4
        Me.chba_capo.Text = "Testo + invio"
        Me.chba_capo.UseVisualStyleBackColor = True
        '
        'chbinfinito
        '
        Me.chbinfinito.AutoSize = True
        Me.chbinfinito.Location = New System.Drawing.Point(193, 50)
        Me.chbinfinito.Name = "chbinfinito"
        Me.chbinfinito.Size = New System.Drawing.Size(57, 17)
        Me.chbinfinito.TabIndex = 5
        Me.chbinfinito.Text = "Infinite"
        Me.chbinfinito.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(32, 80)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(50, 13)
        Label3.TabIndex = 6
        Label3.Text = "Intervallo"
        '
        'btnstop
        '
        Me.btnstop.Enabled = False
        Me.btnstop.Location = New System.Drawing.Point(205, 117)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(75, 23)
        Me.btnstop.TabIndex = 8
        Me.btnstop.Text = "Stop!"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(32, 232)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(42, 13)
        Label4.TabIndex = 9
        Label4.Text = "Inviate:"
        '
        'lblinviate
        '
        Me.lblinviate.AutoSize = True
        Me.lblinviate.Location = New System.Drawing.Point(104, 232)
        Me.lblinviate.Name = "lblinviate"
        Me.lblinviate.Size = New System.Drawing.Size(0, 13)
        Me.lblinviate.TabIndex = 10
        '
        'txtintervallo
        '
        Me.txtintervallo.Location = New System.Drawing.Point(88, 78)
        Me.txtintervallo.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.txtintervallo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtintervallo.Name = "txtintervallo"
        Me.txtintervallo.Size = New System.Drawing.Size(113, 20)
        Me.txtintervallo.TabIndex = 12
        Me.txtintervallo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtintervallo.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'txtvolte
        '
        Me.txtvolte.Location = New System.Drawing.Point(87, 49)
        Me.txtvolte.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtvolte.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtvolte.Name = "txtvolte"
        Me.txtvolte.Size = New System.Drawing.Size(100, 20)
        Me.txtvolte.TabIndex = 13
        Me.txtvolte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtvolte.ThousandsSeparator = True
        Me.txtvolte.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Form1
        '
        Me.AcceptButton = Me.btnmanda
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 272)
        Me.Controls.Add(Me.txtvolte)
        Me.Controls.Add(Me.txtintervallo)
        Me.Controls.Add(Me.lblinviate)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.chbinfinito)
        Me.Controls.Add(Me.chba_capo)
        Me.Controls.Add(Me.lblsecondi)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.barraprogressiva)
        Me.Controls.Add(Me.txttesto)
        Me.Controls.Add(Me.btnmanda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(342, 300)
        Me.MinimumSize = New System.Drawing.Size(342, 300)
        Me.Name = "Form1"
        Me.Text = "Scrivi stringhe"
        CType(Me.txtintervallo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvolte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmanda As System.Windows.Forms.Button
    Friend WithEvents txttesto As System.Windows.Forms.TextBox
    Friend WithEvents barraprogressiva As System.Windows.Forms.ProgressBar
    Friend WithEvents tmriniziale As System.Windows.Forms.Timer
    Friend WithEvents lblsecondi As System.Windows.Forms.Label
    Friend WithEvents chba_capo As System.Windows.Forms.CheckBox
    Friend WithEvents chbinfinito As System.Windows.Forms.CheckBox
    Friend WithEvents btnstop As System.Windows.Forms.Button
    Friend WithEvents lblinviate As System.Windows.Forms.Label
    Friend WithEvents txtintervallo As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtvolte As System.Windows.Forms.NumericUpDown

End Class
