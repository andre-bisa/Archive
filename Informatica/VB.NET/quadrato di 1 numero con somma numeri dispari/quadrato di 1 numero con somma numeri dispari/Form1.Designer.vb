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
        Me.txtris = New System.Windows.Forms.TextBox()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.txtnumero = New System.Windows.Forms.NumericUpDown()
        CType(Me.txtnumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero da elevare al quadrato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quadrato:"
        '
        'txtris
        '
        Me.txtris.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtris.Location = New System.Drawing.Point(183, 82)
        Me.txtris.Name = "txtris"
        Me.txtris.ReadOnly = True
        Me.txtris.Size = New System.Drawing.Size(100, 20)
        Me.txtris.TabIndex = 4
        Me.txtris.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(105, 132)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 5
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(186, 48)
        Me.txtnumero.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtnumero.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(97, 20)
        Me.txtnumero.TabIndex = 6
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnumero.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 178)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.txtris)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Quadrato"
        CType(Me.txtnumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtris As System.Windows.Forms.TextBox
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents txtnumero As System.Windows.Forms.NumericUpDown

End Class
