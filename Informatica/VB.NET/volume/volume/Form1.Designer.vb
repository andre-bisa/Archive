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
        Me.btnMute = New System.Windows.Forms.Button()
        Me.btnDiminuisciVolume = New System.Windows.Forms.Button()
        Me.btnAumentaVolume = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMute
        '
        Me.btnMute.Location = New System.Drawing.Point(12, 109)
        Me.btnMute.Name = "btnMute"
        Me.btnMute.Size = New System.Drawing.Size(75, 23)
        Me.btnMute.TabIndex = 0
        Me.btnMute.Text = "Mute"
        Me.btnMute.UseVisualStyleBackColor = True
        '
        'btnDiminuisciVolume
        '
        Me.btnDiminuisciVolume.Location = New System.Drawing.Point(113, 109)
        Me.btnDiminuisciVolume.Name = "btnDiminuisciVolume"
        Me.btnDiminuisciVolume.Size = New System.Drawing.Size(75, 23)
        Me.btnDiminuisciVolume.TabIndex = 1
        Me.btnDiminuisciVolume.Text = "- volume"
        Me.btnDiminuisciVolume.UseVisualStyleBackColor = True
        '
        'btnAumentaVolume
        '
        Me.btnAumentaVolume.Location = New System.Drawing.Point(218, 109)
        Me.btnAumentaVolume.Name = "btnAumentaVolume"
        Me.btnAumentaVolume.Size = New System.Drawing.Size(75, 23)
        Me.btnAumentaVolume.TabIndex = 2
        Me.btnAumentaVolume.Text = "+ volume"
        Me.btnAumentaVolume.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 317)
        Me.Controls.Add(Me.btnAumentaVolume)
        Me.Controls.Add(Me.btnDiminuisciVolume)
        Me.Controls.Add(Me.btnMute)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMute As System.Windows.Forms.Button
    Friend WithEvents btnDiminuisciVolume As System.Windows.Forms.Button
    Friend WithEvents btnAumentaVolume As System.Windows.Forms.Button

End Class
