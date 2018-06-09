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
        Me.lbln = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.txtm = New System.Windows.Forms.TextBox()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbln
        '
        Me.lbln.AutoSize = True
        Me.lbln.Location = New System.Drawing.Point(13, 34)
        Me.lbln.Name = "lbln"
        Me.lbln.Size = New System.Drawing.Size(13, 13)
        Me.lbln.TabIndex = 0
        Me.lbln.Text = "n"
        '
        'lblm
        '
        Me.lblm.AutoSize = True
        Me.lblm.Location = New System.Drawing.Point(13, 59)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(15, 13)
        Me.lblm.TabIndex = 1
        Me.lblm.Text = "m"
        '
        'txtn
        '
        Me.txtn.Location = New System.Drawing.Point(154, 26)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(100, 20)
        Me.txtn.TabIndex = 2
        '
        'txtm
        '
        Me.txtm.Location = New System.Drawing.Point(154, 52)
        Me.txtm.Name = "txtm"
        Me.txtm.Size = New System.Drawing.Size(100, 20)
        Me.txtm.TabIndex = 3
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(116, 196)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 4
        Me.btncalcola.Text = "calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.txtm)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.lblm)
        Me.Controls.Add(Me.lbln)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbln As System.Windows.Forms.Label
    Friend WithEvents lblm As System.Windows.Forms.Label
    Friend WithEvents txtn As System.Windows.Forms.TextBox
    Friend WithEvents txtm As System.Windows.Forms.TextBox
    Friend WithEvents btncalcola As System.Windows.Forms.Button

End Class
