<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestione
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
        Me.btnsvuota = New System.Windows.Forms.Button()
        Me.btncrea = New System.Windows.Forms.Button()
        Me.btnchiudi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsvuota
        '
        Me.btnsvuota.Location = New System.Drawing.Point(28, 37)
        Me.btnsvuota.Name = "btnsvuota"
        Me.btnsvuota.Size = New System.Drawing.Size(75, 23)
        Me.btnsvuota.TabIndex = 0
        Me.btnsvuota.Text = "Svuota"
        Me.btnsvuota.UseVisualStyleBackColor = True
        '
        'btncrea
        '
        Me.btncrea.Location = New System.Drawing.Point(128, 37)
        Me.btncrea.Name = "btncrea"
        Me.btncrea.Size = New System.Drawing.Size(85, 23)
        Me.btncrea.TabIndex = 1
        Me.btncrea.Text = "Crea cerchio"
        Me.btncrea.UseVisualStyleBackColor = True
        '
        'btnchiudi
        '
        Me.btnchiudi.Location = New System.Drawing.Point(28, 109)
        Me.btnchiudi.Name = "btnchiudi"
        Me.btnchiudi.Size = New System.Drawing.Size(75, 23)
        Me.btnchiudi.TabIndex = 2
        Me.btnchiudi.Text = "Chiudi"
        Me.btnchiudi.UseVisualStyleBackColor = True
        '
        'gestione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 274)
        Me.Controls.Add(Me.btnchiudi)
        Me.Controls.Add(Me.btncrea)
        Me.Controls.Add(Me.btnsvuota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "gestione"
        Me.Text = "gestione"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsvuota As System.Windows.Forms.Button
    Friend WithEvents btncrea As System.Windows.Forms.Button
    Friend WithEvents btnchiudi As System.Windows.Forms.Button
End Class
