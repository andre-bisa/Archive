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
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblprimo = New System.Windows.Forms.Label()
        Me.lblsecondo = New System.Windows.Forms.Label()
        Me.lblterzo = New System.Windows.Forms.Label()
        Me.lblquarto = New System.Windows.Forms.Label()
        Me.lblquinto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.txtreddito = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reddito:"
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(114, 96)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 2
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0 - 15.000"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "15.000 - 28.000"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "28.000 - 55.000"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "55.000 - 75.000"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "75.000 - oo"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprimo
        '
        Me.lblprimo.Location = New System.Drawing.Point(182, 159)
        Me.lblprimo.Name = "lblprimo"
        Me.lblprimo.Size = New System.Drawing.Size(100, 23)
        Me.lblprimo.TabIndex = 8
        Me.lblprimo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsecondo
        '
        Me.lblsecondo.Location = New System.Drawing.Point(182, 182)
        Me.lblsecondo.Name = "lblsecondo"
        Me.lblsecondo.Size = New System.Drawing.Size(100, 23)
        Me.lblsecondo.TabIndex = 10
        Me.lblsecondo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblterzo
        '
        Me.lblterzo.Location = New System.Drawing.Point(182, 205)
        Me.lblterzo.Name = "lblterzo"
        Me.lblterzo.Size = New System.Drawing.Size(100, 23)
        Me.lblterzo.TabIndex = 11
        Me.lblterzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblquarto
        '
        Me.lblquarto.Location = New System.Drawing.Point(182, 228)
        Me.lblquarto.Name = "lblquarto"
        Me.lblquarto.Size = New System.Drawing.Size(100, 23)
        Me.lblquarto.TabIndex = 12
        Me.lblquarto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblquinto
        '
        Me.lblquinto.Location = New System.Drawing.Point(182, 251)
        Me.lblquinto.Name = "lblquinto"
        Me.lblquinto.Size = New System.Drawing.Size(100, 23)
        Me.lblquinto.TabIndex = 13
        Me.lblquinto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Irpef da pagare"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltot
        '
        Me.lbltot.Location = New System.Drawing.Point(182, 293)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(100, 23)
        Me.lbltot.TabIndex = 15
        Me.lbltot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtreddito
        '
        Me.txtreddito.Location = New System.Drawing.Point(134, 38)
        Me.txtreddito.Name = "txtreddito"
        Me.txtreddito.Size = New System.Drawing.Size(100, 20)
        Me.txtreddito.TabIndex = 16
        Me.txtreddito.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 340)
        Me.Controls.Add(Me.txtreddito)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblquinto)
        Me.Controls.Add(Me.lblquarto)
        Me.Controls.Add(Me.lblterzo)
        Me.Controls.Add(Me.lblsecondo)
        Me.Controls.Add(Me.lblprimo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Irpef"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblprimo As System.Windows.Forms.Label
    Friend WithEvents lblsecondo As System.Windows.Forms.Label
    Friend WithEvents lblterzo As System.Windows.Forms.Label
    Friend WithEvents lblquarto As System.Windows.Forms.Label
    Friend WithEvents lblquinto As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents txtreddito As System.Windows.Forms.TextBox

End Class
