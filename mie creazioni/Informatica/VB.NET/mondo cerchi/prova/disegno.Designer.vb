<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class disegno
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
        Me.tmrrettangolo = New System.Windows.Forms.Timer(Me.components)
        Me.tmrconsuma_cibo = New System.Windows.Forms.Timer(Me.components)
        Me.tmrspostamento = New System.Windows.Forms.Timer(Me.components)
        Me.tmrdisegna_cerchi = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tmrrettangolo
        '
        '
        'tmrconsuma_cibo
        '
        Me.tmrconsuma_cibo.Interval = 500
        '
        'tmrspostamento
        '
        Me.tmrspostamento.Interval = 10
        '
        'tmrdisegna_cerchi
        '
        Me.tmrdisegna_cerchi.Interval = 250
        '
        'disegno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "disegno"
        Me.Text = "Disegno"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrrettangolo As System.Windows.Forms.Timer
    Friend WithEvents tmrconsuma_cibo As System.Windows.Forms.Timer
    Friend WithEvents tmrspostamento As System.Windows.Forms.Timer
    Friend WithEvents tmrdisegna_cerchi As System.Windows.Forms.Timer

End Class
