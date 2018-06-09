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
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtlet_iniz = New System.Windows.Forms.TextBox()
        Me.txtlet_fin = New System.Windows.Forms.TextBox()
        Me.txtcanone = New System.Windows.Forms.TextBox()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome utente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lettura iniziale"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(27, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lettura finale"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(27, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Costo canone"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(133, 24)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(100, 20)
        Me.txtnome.TabIndex = 4
        '
        'txtlet_iniz
        '
        Me.txtlet_iniz.Location = New System.Drawing.Point(133, 73)
        Me.txtlet_iniz.Name = "txtlet_iniz"
        Me.txtlet_iniz.Size = New System.Drawing.Size(100, 20)
        Me.txtlet_iniz.TabIndex = 5
        '
        'txtlet_fin
        '
        Me.txtlet_fin.Location = New System.Drawing.Point(133, 119)
        Me.txtlet_fin.Name = "txtlet_fin"
        Me.txtlet_fin.Size = New System.Drawing.Size(100, 20)
        Me.txtlet_fin.TabIndex = 6
        '
        'txtcanone
        '
        Me.txtcanone.Location = New System.Drawing.Point(133, 162)
        Me.txtcanone.Name = "txtcanone"
        Me.txtcanone.Size = New System.Drawing.Size(100, 20)
        Me.txtcanone.TabIndex = 7
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(90, 209)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 8
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.txtcanone)
        Me.Controls.Add(Me.txtlet_fin)
        Me.Controls.Add(Me.txtlet_iniz)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Spesa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtlet_iniz As System.Windows.Forms.TextBox
    Friend WithEvents txtlet_fin As System.Windows.Forms.TextBox
    Friend WithEvents txtcanone As System.Windows.Forms.TextBox
    Friend WithEvents btncalcola As System.Windows.Forms.Button

End Class
