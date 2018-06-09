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
        Me.txtdata = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btntrova = New System.Windows.Forms.Button()
        Me.lblgiorno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtdata
        '
        Me.txtdata.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtdata.Location = New System.Drawing.Point(96, 34)
        Me.txtdata.Mask = "00/00/0000"
        Me.txtdata.Name = "txtdata"
        Me.txtdata.ResetOnSpace = False
        Me.txtdata.Size = New System.Drawing.Size(100, 20)
        Me.txtdata.TabIndex = 0
        Me.txtdata.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Giorno settimana:"
        '
        'btntrova
        '
        Me.btntrova.Location = New System.Drawing.Point(57, 77)
        Me.btntrova.Name = "btntrova"
        Me.btntrova.Size = New System.Drawing.Size(100, 23)
        Me.btntrova.TabIndex = 3
        Me.btntrova.Text = "Trova giorno:"
        Me.btntrova.UseVisualStyleBackColor = True
        '
        'lblgiorno
        '
        Me.lblgiorno.AutoSize = True
        Me.lblgiorno.Location = New System.Drawing.Point(139, 128)
        Me.lblgiorno.Name = "lblgiorno"
        Me.lblgiorno.Size = New System.Drawing.Size(0, 13)
        Me.lblgiorno.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 262)
        Me.Controls.Add(Me.lblgiorno)
        Me.Controls.Add(Me.btntrova)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Trova giorno settimana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdata As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btntrova As System.Windows.Forms.Button
    Friend WithEvents lblgiorno As System.Windows.Forms.Label

End Class
