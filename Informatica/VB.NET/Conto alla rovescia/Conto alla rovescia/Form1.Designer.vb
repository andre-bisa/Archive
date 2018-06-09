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
        Me.btninizia_pausa = New System.Windows.Forms.Button()
        Me.btnazzera = New System.Windows.Forms.Button()
        Me.lblconta = New System.Windows.Forms.Label()
        Me.tmrconto = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btninizia_pausa
        '
        Me.btninizia_pausa.Location = New System.Drawing.Point(40, 39)
        Me.btninizia_pausa.Name = "btninizia_pausa"
        Me.btninizia_pausa.Size = New System.Drawing.Size(75, 23)
        Me.btninizia_pausa.TabIndex = 0
        Me.btninizia_pausa.Text = "Inizia"
        Me.btninizia_pausa.UseVisualStyleBackColor = True
        '
        'btnazzera
        '
        Me.btnazzera.Location = New System.Drawing.Point(152, 39)
        Me.btnazzera.Name = "btnazzera"
        Me.btnazzera.Size = New System.Drawing.Size(75, 23)
        Me.btnazzera.TabIndex = 2
        Me.btnazzera.Text = "Azzera"
        Me.btnazzera.UseVisualStyleBackColor = True
        '
        'lblconta
        '
        Me.lblconta.AutoSize = True
        Me.lblconta.Location = New System.Drawing.Point(140, 127)
        Me.lblconta.Name = "lblconta"
        Me.lblconta.Size = New System.Drawing.Size(25, 13)
        Me.lblconta.TabIndex = 3
        Me.lblconta.Text = "100"
        '
        'tmrconto
        '
        Me.tmrconto.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 262)
        Me.Controls.Add(Me.lblconta)
        Me.Controls.Add(Me.btnazzera)
        Me.Controls.Add(Me.btninizia_pausa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btninizia_pausa As System.Windows.Forms.Button
    Friend WithEvents btnazzera As System.Windows.Forms.Button
    Friend WithEvents lblconta As System.Windows.Forms.Label
    Friend WithEvents tmrconto As System.Windows.Forms.Timer

End Class
