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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optdiviso = New System.Windows.Forms.RadioButton()
        Me.optmeno = New System.Windows.Forms.RadioButton()
        Me.optper = New System.Windows.Forms.RadioButton()
        Me.optpiu = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblris = New System.Windows.Forms.Label()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.btnazzera = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstcronologia = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optdiviso)
        Me.GroupBox1.Controls.Add(Me.optmeno)
        Me.GroupBox1.Controls.Add(Me.optper)
        Me.GroupBox1.Controls.Add(Me.optpiu)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operazioni"
        '
        'optdiviso
        '
        Me.optdiviso.AutoSize = True
        Me.optdiviso.Location = New System.Drawing.Point(24, 93)
        Me.optdiviso.Name = "optdiviso"
        Me.optdiviso.Size = New System.Drawing.Size(30, 17)
        Me.optdiviso.TabIndex = 3
        Me.optdiviso.TabStop = True
        Me.optdiviso.Text = "/"
        Me.optdiviso.UseVisualStyleBackColor = True
        '
        'optmeno
        '
        Me.optmeno.AutoSize = True
        Me.optmeno.Location = New System.Drawing.Point(24, 47)
        Me.optmeno.Name = "optmeno"
        Me.optmeno.Size = New System.Drawing.Size(28, 17)
        Me.optmeno.TabIndex = 1
        Me.optmeno.TabStop = True
        Me.optmeno.Text = "-"
        Me.optmeno.UseVisualStyleBackColor = True
        '
        'optper
        '
        Me.optper.AutoSize = True
        Me.optper.Location = New System.Drawing.Point(24, 70)
        Me.optper.Name = "optper"
        Me.optper.Size = New System.Drawing.Size(29, 17)
        Me.optper.TabIndex = 2
        Me.optper.TabStop = True
        Me.optper.Text = "*"
        Me.optper.UseVisualStyleBackColor = True
        '
        'optpiu
        '
        Me.optpiu.AutoSize = True
        Me.optpiu.Checked = True
        Me.optpiu.Location = New System.Drawing.Point(24, 24)
        Me.optpiu.Name = "optpiu"
        Me.optpiu.Size = New System.Drawing.Size(31, 17)
        Me.optpiu.TabIndex = 0
        Me.optpiu.TabStop = True
        Me.optpiu.Text = "+"
        Me.optpiu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero:"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(190, 29)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Risultato:"
        '
        'lblris
        '
        Me.lblris.Location = New System.Drawing.Point(190, 63)
        Me.lblris.Name = "lblris"
        Me.lblris.Size = New System.Drawing.Size(100, 23)
        Me.lblris.TabIndex = 4
        Me.lblris.Text = "0"
        Me.lblris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncalcola
        '
        Me.btncalcola.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalcola.Location = New System.Drawing.Point(106, 139)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 5
        Me.btncalcola.Text = "&Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'btnazzera
        '
        Me.btnazzera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnazzera.Location = New System.Drawing.Point(206, 139)
        Me.btnazzera.Name = "btnazzera"
        Me.btnazzera.Size = New System.Drawing.Size(75, 23)
        Me.btnazzera.TabIndex = 6
        Me.btnazzera.Text = "&Azzera"
        Me.btnazzera.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cronologia:"
        '
        'lstcronologia
        '
        Me.lstcronologia.FormattingEnabled = True
        Me.lstcronologia.Location = New System.Drawing.Point(106, 197)
        Me.lstcronologia.Name = "lstcronologia"
        Me.lstcronologia.Size = New System.Drawing.Size(120, 95)
        Me.lstcronologia.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 307)
        Me.Controls.Add(Me.lstcronologia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnazzera)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.lblris)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calcolatrice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optdiviso As System.Windows.Forms.RadioButton
    Friend WithEvents optmeno As System.Windows.Forms.RadioButton
    Friend WithEvents optper As System.Windows.Forms.RadioButton
    Friend WithEvents optpiu As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblris As System.Windows.Forms.Label
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents btnazzera As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstcronologia As System.Windows.Forms.ListBox

End Class
