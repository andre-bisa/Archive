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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcolori = New System.Windows.Forms.TextBox()
        Me.txtbianco = New System.Windows.Forms.TextBox()
        Me.lbltotfotoc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblprbianco = New System.Windows.Forms.Label()
        Me.lblprcolori = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.btnsvuota = New System.Windows.Forms.Button()
        Me.chkrilegatura = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fotocopie bianco e nero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fotocopie colori:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Totale fotocopie:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcolori
        '
        Me.txtcolori.Location = New System.Drawing.Point(149, 48)
        Me.txtcolori.Name = "txtcolori"
        Me.txtcolori.Size = New System.Drawing.Size(100, 20)
        Me.txtcolori.TabIndex = 1
        Me.txtcolori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbianco
        '
        Me.txtbianco.Location = New System.Drawing.Point(149, 16)
        Me.txtbianco.Name = "txtbianco"
        Me.txtbianco.Size = New System.Drawing.Size(100, 20)
        Me.txtbianco.TabIndex = 0
        Me.txtbianco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltotfotoc
        '
        Me.lbltotfotoc.Location = New System.Drawing.Point(149, 80)
        Me.lbltotfotoc.Name = "lbltotfotoc"
        Me.lbltotfotoc.Size = New System.Drawing.Size(100, 23)
        Me.lbltotfotoc.TabIndex = 5
        Me.lbltotfotoc.Text = "0"
        Me.lbltotfotoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Costo bianco e nero:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Costo colori:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprbianco
        '
        Me.lblprbianco.Location = New System.Drawing.Point(146, 126)
        Me.lblprbianco.Name = "lblprbianco"
        Me.lblprbianco.Size = New System.Drawing.Size(103, 23)
        Me.lblprbianco.TabIndex = 8
        Me.lblprbianco.Text = "0"
        Me.lblprbianco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprcolori
        '
        Me.lblprcolori.Location = New System.Drawing.Point(146, 168)
        Me.lblprcolori.Name = "lblprcolori"
        Me.lblprcolori.Size = New System.Drawing.Size(103, 23)
        Me.lblprcolori.TabIndex = 9
        Me.lblprcolori.Text = "0.00"
        Me.lblprcolori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Spesa totale:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltot
        '
        Me.lbltot.Location = New System.Drawing.Point(146, 214)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(103, 23)
        Me.lbltot.TabIndex = 11
        Me.lbltot.Text = "0.00"
        Me.lbltot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnsvuota
        '
        Me.btnsvuota.Location = New System.Drawing.Point(124, 250)
        Me.btnsvuota.Name = "btnsvuota"
        Me.btnsvuota.Size = New System.Drawing.Size(75, 23)
        Me.btnsvuota.TabIndex = 3
        Me.btnsvuota.Text = "Svuota"
        Me.btnsvuota.UseVisualStyleBackColor = True
        '
        'chkrilegatura
        '
        Me.chkrilegatura.AutoSize = True
        Me.chkrilegatura.Location = New System.Drawing.Point(255, 141)
        Me.chkrilegatura.Name = "chkrilegatura"
        Me.chkrilegatura.Size = New System.Drawing.Size(74, 17)
        Me.chkrilegatura.TabIndex = 2
        Me.chkrilegatura.Text = "Rilegatura"
        Me.chkrilegatura.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 285)
        Me.Controls.Add(Me.chkrilegatura)
        Me.Controls.Add(Me.btnsvuota)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblprcolori)
        Me.Controls.Add(Me.lblprbianco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltotfotoc)
        Me.Controls.Add(Me.txtbianco)
        Me.Controls.Add(Me.txtcolori)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Fotocopie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcolori As System.Windows.Forms.TextBox
    Friend WithEvents txtbianco As System.Windows.Forms.TextBox
    Friend WithEvents lbltotfotoc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblprbianco As System.Windows.Forms.Label
    Friend WithEvents lblprcolori As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents btnsvuota As System.Windows.Forms.Button
    Friend WithEvents chkrilegatura As System.Windows.Forms.CheckBox

End Class
