<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class situazione_economica
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
        Me.tmrdisegna = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltitoloeconomica = New System.Windows.Forms.Label()
        Me.tmrriga_finale = New System.Windows.Forms.Timer(Me.components)
        Me.tmranimazione = New System.Windows.Forms.Timer(Me.components)
        Me.btnstampa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrdisegna
        '
        Me.tmrdisegna.Interval = 200
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "AVERE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DARE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitoloeconomica
        '
        Me.lbltitoloeconomica.AutoSize = True
        Me.lbltitoloeconomica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitoloeconomica.Location = New System.Drawing.Point(122, 21)
        Me.lbltitoloeconomica.Name = "lbltitoloeconomica"
        Me.lbltitoloeconomica.Size = New System.Drawing.Size(185, 20)
        Me.lbltitoloeconomica.TabIndex = 3
        Me.lbltitoloeconomica.Text = "Situazione economica"
        Me.lbltitoloeconomica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrriga_finale
        '
        Me.tmrriga_finale.Interval = 200
        '
        'tmranimazione
        '
        Me.tmranimazione.Interval = 5
        '
        'btnstampa
        '
        Me.btnstampa.Location = New System.Drawing.Point(12, 12)
        Me.btnstampa.Name = "btnstampa"
        Me.btnstampa.Size = New System.Drawing.Size(62, 23)
        Me.btnstampa.TabIndex = 6
        Me.btnstampa.Text = "Stampa"
        Me.btnstampa.UseVisualStyleBackColor = True
        '
        'situazione_economica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.btnstampa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltitoloeconomica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "situazione_economica"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "situazione_economica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrdisegna As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltitoloeconomica As System.Windows.Forms.Label
    Friend WithEvents tmrriga_finale As System.Windows.Forms.Timer
    Friend WithEvents tmranimazione As System.Windows.Forms.Timer
    Friend WithEvents btnstampa As System.Windows.Forms.Button
End Class
