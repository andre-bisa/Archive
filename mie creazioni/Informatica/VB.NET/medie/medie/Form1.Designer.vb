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
        Me.lblsomma_pari = New System.Windows.Forms.Label()
        Me.lblsomma_dispari = New System.Windows.Forms.Label()
        Me.txtprimo = New System.Windows.Forms.TextBox()
        Me.txtsecondo = New System.Windows.Forms.TextBox()
        Me.lblconta_pari = New System.Windows.Forms.Label()
        Me.lblconta_dispari = New System.Windows.Forms.Label()
        Me.lblmedia_pari = New System.Windows.Forms.Label()
        Me.lblmedia_dispari = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnfai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primo numero"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Secondo numero"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsomma_pari
        '
        Me.lblsomma_pari.Location = New System.Drawing.Point(132, 171)
        Me.lblsomma_pari.Name = "lblsomma_pari"
        Me.lblsomma_pari.Size = New System.Drawing.Size(103, 23)
        Me.lblsomma_pari.TabIndex = 2
        Me.lblsomma_pari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsomma_dispari
        '
        Me.lblsomma_dispari.Location = New System.Drawing.Point(132, 219)
        Me.lblsomma_dispari.Name = "lblsomma_dispari"
        Me.lblsomma_dispari.Size = New System.Drawing.Size(103, 23)
        Me.lblsomma_dispari.TabIndex = 3
        Me.lblsomma_dispari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtprimo
        '
        Me.txtprimo.Location = New System.Drawing.Point(135, 43)
        Me.txtprimo.Name = "txtprimo"
        Me.txtprimo.Size = New System.Drawing.Size(100, 20)
        Me.txtprimo.TabIndex = 4
        '
        'txtsecondo
        '
        Me.txtsecondo.Location = New System.Drawing.Point(135, 95)
        Me.txtsecondo.Name = "txtsecondo"
        Me.txtsecondo.Size = New System.Drawing.Size(100, 20)
        Me.txtsecondo.TabIndex = 5
        '
        'lblconta_pari
        '
        Me.lblconta_pari.Location = New System.Drawing.Point(132, 254)
        Me.lblconta_pari.Name = "lblconta_pari"
        Me.lblconta_pari.Size = New System.Drawing.Size(103, 23)
        Me.lblconta_pari.TabIndex = 6
        Me.lblconta_pari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblconta_dispari
        '
        Me.lblconta_dispari.Location = New System.Drawing.Point(132, 301)
        Me.lblconta_dispari.Name = "lblconta_dispari"
        Me.lblconta_dispari.Size = New System.Drawing.Size(103, 23)
        Me.lblconta_dispari.TabIndex = 7
        Me.lblconta_dispari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmedia_pari
        '
        Me.lblmedia_pari.Location = New System.Drawing.Point(132, 342)
        Me.lblmedia_pari.Name = "lblmedia_pari"
        Me.lblmedia_pari.Size = New System.Drawing.Size(103, 23)
        Me.lblmedia_pari.TabIndex = 8
        Me.lblmedia_pari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmedia_dispari
        '
        Me.lblmedia_dispari.Location = New System.Drawing.Point(132, 385)
        Me.lblmedia_dispari.Name = "lblmedia_dispari"
        Me.lblmedia_dispari.Size = New System.Drawing.Size(103, 23)
        Me.lblmedia_dispari.TabIndex = 9
        Me.lblmedia_dispari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Somma pari"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Media dispari"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Media pari"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Conta dispari"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Conta pari"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Somma dispari"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnfai
        '
        Me.btnfai.Location = New System.Drawing.Point(86, 132)
        Me.btnfai.Name = "btnfai"
        Me.btnfai.Size = New System.Drawing.Size(75, 23)
        Me.btnfai.TabIndex = 16
        Me.btnfai.Text = "Fai"
        Me.btnfai.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 444)
        Me.Controls.Add(Me.btnfai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblmedia_dispari)
        Me.Controls.Add(Me.lblmedia_pari)
        Me.Controls.Add(Me.lblconta_dispari)
        Me.Controls.Add(Me.lblconta_pari)
        Me.Controls.Add(Me.txtsecondo)
        Me.Controls.Add(Me.txtprimo)
        Me.Controls.Add(Me.lblsomma_dispari)
        Me.Controls.Add(Me.lblsomma_pari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Medie numeri"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblsomma_pari As System.Windows.Forms.Label
    Friend WithEvents lblsomma_dispari As System.Windows.Forms.Label
    Friend WithEvents txtprimo As System.Windows.Forms.TextBox
    Friend WithEvents txtsecondo As System.Windows.Forms.TextBox
    Friend WithEvents lblconta_pari As System.Windows.Forms.Label
    Friend WithEvents lblconta_dispari As System.Windows.Forms.Label
    Friend WithEvents lblmedia_pari As System.Windows.Forms.Label
    Friend WithEvents lblmedia_dispari As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnfai As System.Windows.Forms.Button

End Class
