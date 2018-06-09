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
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprima = New System.Windows.Forms.TextBox()
        Me.txtseconda = New System.Windows.Forms.TextBox()
        Me.txtterza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtistituto = New System.Windows.Forms.ComboBox()
        Me.txtorale = New System.Windows.Forms.TextBox()
        Me.txtcrediti = New System.Windows.Forms.TextBox()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.lbldiploma = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(121, 8)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(100, 20)
        Me.txtnome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome studente"
        '
        'txtprima
        '
        Me.txtprima.Location = New System.Drawing.Point(121, 38)
        Me.txtprima.Name = "txtprima"
        Me.txtprima.Size = New System.Drawing.Size(100, 20)
        Me.txtprima.TabIndex = 1
        '
        'txtseconda
        '
        Me.txtseconda.Location = New System.Drawing.Point(121, 64)
        Me.txtseconda.Name = "txtseconda"
        Me.txtseconda.Size = New System.Drawing.Size(100, 20)
        Me.txtseconda.TabIndex = 2
        '
        'txtterza
        '
        Me.txtterza.Location = New System.Drawing.Point(121, 90)
        Me.txtterza.Name = "txtterza"
        Me.txtterza.Size = New System.Drawing.Size(100, 20)
        Me.txtterza.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Voto prima prova"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Voto seconda prova"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Voto terza prova"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Voto orale"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Crediti"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tipo di istituto"
        '
        'txtistituto
        '
        Me.txtistituto.FormattingEnabled = True
        Me.txtistituto.Items.AddRange(New Object() {"Istituto Tecnico Commerciale IGEA", "Istituto Tectino Commerciale MERCURIO", "Istituto Tecnico Industriale", "Istituto Professionale Turistico"})
        Me.txtistituto.Location = New System.Drawing.Point(121, 166)
        Me.txtistituto.Name = "txtistituto"
        Me.txtistituto.Size = New System.Drawing.Size(222, 21)
        Me.txtistituto.TabIndex = 6
        '
        'txtorale
        '
        Me.txtorale.Location = New System.Drawing.Point(121, 113)
        Me.txtorale.Name = "txtorale"
        Me.txtorale.Size = New System.Drawing.Size(100, 20)
        Me.txtorale.TabIndex = 4
        '
        'txtcrediti
        '
        Me.txtcrediti.Location = New System.Drawing.Point(121, 140)
        Me.txtcrediti.Name = "txtcrediti"
        Me.txtcrediti.Size = New System.Drawing.Size(100, 20)
        Me.txtcrediti.TabIndex = 5
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(100, 193)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 7
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'lbldiploma
        '
        Me.lbldiploma.AutoSize = True
        Me.lbldiploma.Location = New System.Drawing.Point(15, 231)
        Me.lbldiploma.Name = "lbldiploma"
        Me.lbldiploma.Size = New System.Drawing.Size(0, 13)
        Me.lbldiploma.TabIndex = 15
        Me.lbldiploma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 262)
        Me.Controls.Add(Me.lbldiploma)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.txtcrediti)
        Me.Controls.Add(Me.txtorale)
        Me.Controls.Add(Me.txtistituto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtterza)
        Me.Controls.Add(Me.txtseconda)
        Me.Controls.Add(Me.txtprima)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnome)
        Me.Name = "Form1"
        Me.Text = "Esame"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprima As System.Windows.Forms.TextBox
    Friend WithEvents txtseconda As System.Windows.Forms.TextBox
    Friend WithEvents txtterza As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtistituto As System.Windows.Forms.ComboBox
    Friend WithEvents txtorale As System.Windows.Forms.TextBox
    Friend WithEvents txtcrediti As System.Windows.Forms.TextBox
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents lbldiploma As System.Windows.Forms.Label

End Class
