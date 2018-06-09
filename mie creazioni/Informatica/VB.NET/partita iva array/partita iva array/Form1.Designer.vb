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
        Me.btnaggiungi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcifra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnaggiungi
        '
        Me.btnaggiungi.Location = New System.Drawing.Point(62, 77)
        Me.btnaggiungi.Name = "btnaggiungi"
        Me.btnaggiungi.Size = New System.Drawing.Size(75, 23)
        Me.btnaggiungi.TabIndex = 1
        Me.btnaggiungi.Text = "Aggiungi"
        Me.btnaggiungi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aggiungi cifra:"
        '
        'txtcifra
        '
        Me.txtcifra.Location = New System.Drawing.Point(121, 22)
        Me.txtcifra.Name = "txtcifra"
        Me.txtcifra.Size = New System.Drawing.Size(100, 20)
        Me.txtcifra.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "11° cifra:"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(118, 167)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(0, 13)
        Me.lbl11.TabIndex = 4
        '
        'Form1
        '
        Me.AcceptButton = Me.btnaggiungi
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 234)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcifra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnaggiungi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaggiungi As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcifra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label

End Class
