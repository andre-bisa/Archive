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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblora_2013 = New System.Windows.Forms.Label()
        Me.lblminuti_2013 = New System.Windows.Forms.Label()
        Me.tmrora_attuale = New System.Windows.Forms.Timer(Me.components)
        Me.lblsecondi_2013 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblsecondi_fine = New System.Windows.Forms.Label()
        Me.lblduepunti2 = New System.Windows.Forms.Label()
        Me.lblminuti_fine = New System.Windows.Forms.Label()
        Me.lblore_fine = New System.Windows.Forms.Label()
        Me.lblduepunti = New System.Windows.Forms.Label()
        Me.lblfine_festa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Capodanno"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(408, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 57)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2014"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 60)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "2015 tra:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 60)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = ":"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblora_2013
        '
        Me.lblora_2013.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblora_2013.Location = New System.Drawing.Point(240, 100)
        Me.lblora_2013.Name = "lblora_2013"
        Me.lblora_2013.Size = New System.Drawing.Size(84, 60)
        Me.lblora_2013.TabIndex = 8
        Me.lblora_2013.Text = "00"
        Me.lblora_2013.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblminuti_2013
        '
        Me.lblminuti_2013.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuti_2013.Location = New System.Drawing.Point(366, 100)
        Me.lblminuti_2013.Name = "lblminuti_2013"
        Me.lblminuti_2013.Size = New System.Drawing.Size(79, 60)
        Me.lblminuti_2013.TabIndex = 9
        Me.lblminuti_2013.Text = "00"
        Me.lblminuti_2013.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrora_attuale
        '
        '
        'lblsecondi_2013
        '
        Me.lblsecondi_2013.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondi_2013.Location = New System.Drawing.Point(487, 100)
        Me.lblsecondi_2013.Name = "lblsecondi_2013"
        Me.lblsecondi_2013.Size = New System.Drawing.Size(79, 60)
        Me.lblsecondi_2013.TabIndex = 11
        Me.lblsecondi_2013.Text = "00"
        Me.lblsecondi_2013.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(451, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 60)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsecondi_fine
        '
        Me.lblsecondi_fine.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondi_fine.Location = New System.Drawing.Point(487, 232)
        Me.lblsecondi_fine.Name = "lblsecondi_fine"
        Me.lblsecondi_fine.Size = New System.Drawing.Size(79, 60)
        Me.lblsecondi_fine.TabIndex = 18
        Me.lblsecondi_fine.Text = "00"
        Me.lblsecondi_fine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblduepunti2
        '
        Me.lblduepunti2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduepunti2.Location = New System.Drawing.Point(451, 232)
        Me.lblduepunti2.Name = "lblduepunti2"
        Me.lblduepunti2.Size = New System.Drawing.Size(30, 60)
        Me.lblduepunti2.TabIndex = 17
        Me.lblduepunti2.Text = ":"
        Me.lblduepunti2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblminuti_fine
        '
        Me.lblminuti_fine.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuti_fine.Location = New System.Drawing.Point(366, 232)
        Me.lblminuti_fine.Name = "lblminuti_fine"
        Me.lblminuti_fine.Size = New System.Drawing.Size(79, 60)
        Me.lblminuti_fine.TabIndex = 16
        Me.lblminuti_fine.Text = "00"
        Me.lblminuti_fine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblore_fine
        '
        Me.lblore_fine.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblore_fine.Location = New System.Drawing.Point(240, 232)
        Me.lblore_fine.Name = "lblore_fine"
        Me.lblore_fine.Size = New System.Drawing.Size(84, 60)
        Me.lblore_fine.TabIndex = 15
        Me.lblore_fine.Text = "00"
        Me.lblore_fine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblduepunti
        '
        Me.lblduepunti.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduepunti.Location = New System.Drawing.Point(330, 232)
        Me.lblduepunti.Name = "lblduepunti"
        Me.lblduepunti.Size = New System.Drawing.Size(30, 60)
        Me.lblduepunti.TabIndex = 14
        Me.lblduepunti.Text = ":"
        Me.lblduepunti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfine_festa
        '
        Me.lblfine_festa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfine_festa.Location = New System.Drawing.Point(13, 230)
        Me.lblfine_festa.Name = "lblfine_festa"
        Me.lblfine_festa.Size = New System.Drawing.Size(159, 87)
        Me.lblfine_festa.TabIndex = 13
        Me.lblfine_festa.Text = "Fine festa tra:"
        Me.lblfine_festa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 352)
        Me.Controls.Add(Me.lblsecondi_fine)
        Me.Controls.Add(Me.lblduepunti2)
        Me.Controls.Add(Me.lblminuti_fine)
        Me.Controls.Add(Me.lblore_fine)
        Me.Controls.Add(Me.lblduepunti)
        Me.Controls.Add(Me.lblfine_festa)
        Me.Controls.Add(Me.lblsecondi_2013)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblminuti_2013)
        Me.Controls.Add(Me.lblora_2013)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Capodanno"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblora_2013 As System.Windows.Forms.Label
    Friend WithEvents lblminuti_2013 As System.Windows.Forms.Label
    Friend WithEvents tmrora_attuale As System.Windows.Forms.Timer
    Friend WithEvents lblsecondi_2013 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblsecondi_fine As System.Windows.Forms.Label
    Friend WithEvents lblduepunti2 As System.Windows.Forms.Label
    Friend WithEvents lblminuti_fine As System.Windows.Forms.Label
    Friend WithEvents lblore_fine As System.Windows.Forms.Label
    Friend WithEvents lblduepunti As System.Windows.Forms.Label
    Friend WithEvents lblfine_festa As System.Windows.Forms.Label

End Class
