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
        Me.txtanno = New System.Windows.Forms.TextBox()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.lblrisultato = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(54, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scrivi l'anno: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtanno
        '
        Me.txtanno.Location = New System.Drawing.Point(156, 61)
        Me.txtanno.Name = "txtanno"
        Me.txtanno.Size = New System.Drawing.Size(100, 20)
        Me.txtanno.TabIndex = 0
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(110, 100)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 1
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'lblrisultato
        '
        Me.lblrisultato.AutoSize = True
        Me.lblrisultato.Location = New System.Drawing.Point(143, 177)
        Me.lblrisultato.Name = "lblrisultato"
        Me.lblrisultato.Size = New System.Drawing.Size(73, 13)
        Me.lblrisultato.TabIndex = 0
        Me.lblrisultato.Text = "Non calcolato"
        Me.lblrisultato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(61, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "La pasqua è il: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 267)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblrisultato)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.txtanno)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(337, 305)
        Me.MinimumSize = New System.Drawing.Size(337, 305)
        Me.Name = "Form1"
        Me.Text = "Calcolo della Pasqua"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtanno As System.Windows.Forms.TextBox
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents lblrisultato As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
