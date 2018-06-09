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
        Me.txtcassa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblris = New System.Windows.Forms.Label()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.txtassegno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtcassa
        '
        Me.txtcassa.Location = New System.Drawing.Point(117, 28)
        Me.txtcassa.Name = "txtcassa"
        Me.txtcassa.Size = New System.Drawing.Size(100, 20)
        Me.txtcassa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cassa iniziale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Assegno da pagare"
        '
        'lblris
        '
        Me.lblris.AutoSize = True
        Me.lblris.Location = New System.Drawing.Point(29, 181)
        Me.lblris.Name = "lblris"
        Me.lblris.Size = New System.Drawing.Size(0, 13)
        Me.lblris.TabIndex = 3
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(85, 131)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 4
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'txtassegno
        '
        Me.txtassegno.Location = New System.Drawing.Point(117, 65)
        Me.txtassegno.Name = "txtassegno"
        Me.txtassegno.Size = New System.Drawing.Size(100, 20)
        Me.txtassegno.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtassegno)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.lblris)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcassa)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcassa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblris As System.Windows.Forms.Label
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents txtassegno As System.Windows.Forms.TextBox

End Class
