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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblbatteria = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblcarica = New System.Windows.Forms.Label()
        Me.lblpercentuale = New System.Windows.Forms.Label()
        Me.lblcritica = New System.Windows.Forms.Label()
        Me.lblalto = New System.Windows.Forms.Label()
        Me.lblbasso = New System.Windows.Forms.Label()
        Me.lblnonso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batteria: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Critica:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Percentuale:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "In carica:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alto livello:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Basso"
        '
        'lblbatteria
        '
        Me.lblbatteria.AutoSize = True
        Me.lblbatteria.Location = New System.Drawing.Point(147, 9)
        Me.lblbatteria.Name = "lblbatteria"
        Me.lblbatteria.Size = New System.Drawing.Size(26, 13)
        Me.lblbatteria.TabIndex = 6
        Me.lblbatteria.Text = "Bho"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Non definita:"
        '
        'lblcarica
        '
        Me.lblcarica.AutoSize = True
        Me.lblcarica.Location = New System.Drawing.Point(147, 32)
        Me.lblcarica.Name = "lblcarica"
        Me.lblcarica.Size = New System.Drawing.Size(26, 13)
        Me.lblcarica.TabIndex = 8
        Me.lblcarica.Text = "Bho"
        '
        'lblpercentuale
        '
        Me.lblpercentuale.AutoSize = True
        Me.lblpercentuale.Location = New System.Drawing.Point(147, 147)
        Me.lblpercentuale.Name = "lblpercentuale"
        Me.lblpercentuale.Size = New System.Drawing.Size(21, 13)
        Me.lblpercentuale.TabIndex = 9
        Me.lblpercentuale.Text = "0%"
        '
        'lblcritica
        '
        Me.lblcritica.AutoSize = True
        Me.lblcritica.Location = New System.Drawing.Point(147, 56)
        Me.lblcritica.Name = "lblcritica"
        Me.lblcritica.Size = New System.Drawing.Size(26, 13)
        Me.lblcritica.TabIndex = 10
        Me.lblcritica.Text = "Bho"
        '
        'lblalto
        '
        Me.lblalto.AutoSize = True
        Me.lblalto.Location = New System.Drawing.Point(147, 78)
        Me.lblalto.Name = "lblalto"
        Me.lblalto.Size = New System.Drawing.Size(26, 13)
        Me.lblalto.TabIndex = 11
        Me.lblalto.Text = "Bho"
        '
        'lblbasso
        '
        Me.lblbasso.AutoSize = True
        Me.lblbasso.Location = New System.Drawing.Point(147, 100)
        Me.lblbasso.Name = "lblbasso"
        Me.lblbasso.Size = New System.Drawing.Size(26, 13)
        Me.lblbasso.TabIndex = 12
        Me.lblbasso.Text = "Bho"
        '
        'lblnonso
        '
        Me.lblnonso.AutoSize = True
        Me.lblnonso.Location = New System.Drawing.Point(147, 124)
        Me.lblnonso.Name = "lblnonso"
        Me.lblnonso.Size = New System.Drawing.Size(26, 13)
        Me.lblnonso.TabIndex = 13
        Me.lblnonso.Text = "Bho"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblnonso)
        Me.Controls.Add(Me.lblbasso)
        Me.Controls.Add(Me.lblalto)
        Me.Controls.Add(Me.lblcritica)
        Me.Controls.Add(Me.lblpercentuale)
        Me.Controls.Add(Me.lblcarica)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblbatteria)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Info batteria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblbatteria As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblcarica As System.Windows.Forms.Label
    Friend WithEvents lblpercentuale As System.Windows.Forms.Label
    Friend WithEvents lblcritica As System.Windows.Forms.Label
    Friend WithEvents lblalto As System.Windows.Forms.Label
    Friend WithEvents lblbasso As System.Windows.Forms.Label
    Friend WithEvents lblnonso As System.Windows.Forms.Label

End Class
