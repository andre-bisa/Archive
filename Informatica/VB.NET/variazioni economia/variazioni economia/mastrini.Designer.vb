﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mastrini
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrdisegna = New System.Windows.Forms.Timer(Me.components)
        Me.tmriniziale = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tmrdisegna
        '
        Me.tmrdisegna.Interval = 200
        '
        'tmriniziale
        '
        Me.tmriniziale.Interval = 10
        '
        'mastrini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 362)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mastrini"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "mastrini"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents tmrdisegna As System.Windows.Forms.Timer
    Public WithEvents tmriniziale As System.Windows.Forms.Timer
End Class
