﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtda = New System.Windows.Forms.TextBox()
        Me.txta = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Da"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A"
        '
        'txtda
        '
        Me.txtda.Location = New System.Drawing.Point(99, 21)
        Me.txtda.Name = "txtda"
        Me.txtda.Size = New System.Drawing.Size(100, 20)
        Me.txtda.TabIndex = 2
        '
        'txta
        '
        Me.txta.Location = New System.Drawing.Point(99, 57)
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(100, 20)
        Me.txta.TabIndex = 3
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(67, 107)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(75, 23)
        Me.btncalc.TabIndex = 4
        Me.btncalc.Text = "Calcola"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 162)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txta)
        Me.Controls.Add(Me.txtda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtda As System.Windows.Forms.TextBox
    Friend WithEvents txta As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button

End Class
