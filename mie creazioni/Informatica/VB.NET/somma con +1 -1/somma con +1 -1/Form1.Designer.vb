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
        Me.txtnumero1 = New System.Windows.Forms.NumericUpDown()
        Me.txtnumero2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtris = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncalcola = New System.Windows.Forms.Button()
        CType(Me.txtnumero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnumero2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnumero1
        '
        Me.txtnumero1.Location = New System.Drawing.Point(12, 35)
        Me.txtnumero1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtnumero1.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.txtnumero1.Name = "txtnumero1"
        Me.txtnumero1.Size = New System.Drawing.Size(120, 20)
        Me.txtnumero1.TabIndex = 0
        Me.txtnumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumero2
        '
        Me.txtnumero2.Location = New System.Drawing.Point(252, 35)
        Me.txtnumero2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtnumero2.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.txtnumero2.Name = "txtnumero2"
        Me.txtnumero2.Size = New System.Drawing.Size(120, 20)
        Me.txtnumero2.TabIndex = 1
        Me.txtnumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "+"
        '
        'txtris
        '
        Me.txtris.Location = New System.Drawing.Point(91, 94)
        Me.txtris.Name = "txtris"
        Me.txtris.ReadOnly = True
        Me.txtris.Size = New System.Drawing.Size(100, 20)
        Me.txtris.TabIndex = 3
        Me.txtris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Risultato"
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(146, 154)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 5
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 230)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtris)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnumero2)
        Me.Controls.Add(Me.txtnumero1)
        Me.Name = "Form1"
        Me.Text = "Somma"
        CType(Me.txtnumero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnumero2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnumero1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtnumero2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtris As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncalcola As System.Windows.Forms.Button

End Class
