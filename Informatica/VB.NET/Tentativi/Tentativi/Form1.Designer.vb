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
        Me.txtCaratteri = New System.Windows.Forms.TextBox()
        Me.txtNumCaratteri = New System.Windows.Forms.NumericUpDown()
        Me.lstRisultati = New System.Windows.Forms.ListBox()
        Me.btnEsegui = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tlsStato = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsTempoRestante = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chkFile = New System.Windows.Forms.CheckBox()
        Me.chkListBox = New System.Windows.Forms.CheckBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.txtNumCaratteri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(43, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 13)
        Label1.TabIndex = 0
        Label1.Text = "Caratteri da testare"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(43, 70)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(96, 13)
        Label2.TabIndex = 1
        Label2.Text = "Numero di caratteri"
        '
        'txtCaratteri
        '
        Me.txtCaratteri.Location = New System.Drawing.Point(192, 30)
        Me.txtCaratteri.Name = "txtCaratteri"
        Me.txtCaratteri.Size = New System.Drawing.Size(224, 20)
        Me.txtCaratteri.TabIndex = 2
        '
        'txtNumCaratteri
        '
        Me.txtNumCaratteri.Location = New System.Drawing.Point(192, 68)
        Me.txtNumCaratteri.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNumCaratteri.Name = "txtNumCaratteri"
        Me.txtNumCaratteri.Size = New System.Drawing.Size(224, 20)
        Me.txtNumCaratteri.TabIndex = 3
        Me.txtNumCaratteri.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lstRisultati
        '
        Me.lstRisultati.FormattingEnabled = True
        Me.lstRisultati.Location = New System.Drawing.Point(31, 147)
        Me.lstRisultati.Name = "lstRisultati"
        Me.lstRisultati.Size = New System.Drawing.Size(448, 238)
        Me.lstRisultati.TabIndex = 4
        '
        'btnEsegui
        '
        Me.btnEsegui.Location = New System.Drawing.Point(178, 107)
        Me.btnEsegui.Name = "btnEsegui"
        Me.btnEsegui.Size = New System.Drawing.Size(75, 23)
        Me.btnEsegui.TabIndex = 5
        Me.btnEsegui.Text = "Esegui"
        Me.btnEsegui.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsStato, Me.tlsTempoRestante})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(544, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tlsStato
        '
        Me.tlsStato.Name = "tlsStato"
        Me.tlsStato.Size = New System.Drawing.Size(121, 17)
        Me.tlsStato.Text = "ToolStripStatusLabel1"
        '
        'tlsTempoRestante
        '
        Me.tlsTempoRestante.Name = "tlsTempoRestante"
        Me.tlsTempoRestante.Size = New System.Drawing.Size(121, 17)
        Me.tlsTempoRestante.Text = "ToolStripStatusLabel1"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(323, 107)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 7
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'chkFile
        '
        Me.chkFile.AutoSize = True
        Me.chkFile.Location = New System.Drawing.Point(423, 94)
        Me.chkFile.Name = "chkFile"
        Me.chkFile.Size = New System.Drawing.Size(89, 17)
        Me.chkFile.TabIndex = 8
        Me.chkFile.Text = "Salva su file?"
        Me.chkFile.UseVisualStyleBackColor = True
        '
        'chkListBox
        '
        Me.chkListBox.AutoSize = True
        Me.chkListBox.Location = New System.Drawing.Point(431, 66)
        Me.chkListBox.Name = "chkListBox"
        Me.chkListBox.Size = New System.Drawing.Size(103, 17)
        Me.chkListBox.TabIndex = 9
        Me.chkListBox.Text = "Vedere ListBox?"
        Me.chkListBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEsegui
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 441)
        Me.Controls.Add(Me.chkListBox)
        Me.Controls.Add(Me.chkFile)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnEsegui)
        Me.Controls.Add(Me.lstRisultati)
        Me.Controls.Add(Me.txtNumCaratteri)
        Me.Controls.Add(Me.txtCaratteri)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.txtNumCaratteri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCaratteri As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCaratteri As System.Windows.Forms.NumericUpDown
    Friend WithEvents lstRisultati As System.Windows.Forms.ListBox
    Friend WithEvents btnEsegui As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tlsStato As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents tlsTempoRestante As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkFile As System.Windows.Forms.CheckBox
    Friend WithEvents chkListBox As System.Windows.Forms.CheckBox

End Class
