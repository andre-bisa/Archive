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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblselezionata = New System.Windows.Forms.Label()
        Me.image_scacchiera = New System.Windows.Forms.PictureBox()
        Me.Box_scacchiera = New System.Windows.Forms.GroupBox()
        Me.q8 = New System.Windows.Forms.PictureBox()
        Me.q7 = New System.Windows.Forms.PictureBox()
        Me.q5 = New System.Windows.Forms.PictureBox()
        Me.q6 = New System.Windows.Forms.PictureBox()
        Me.q4 = New System.Windows.Forms.PictureBox()
        Me.q3 = New System.Windows.Forms.PictureBox()
        Me.q2 = New System.Windows.Forms.PictureBox()
        Me.q1 = New System.Windows.Forms.PictureBox()
        Me.box_comandi = New System.Windows.Forms.GroupBox()
        Me.btnprecedente = New System.Windows.Forms.Button()
        Me.btnsuccessivo = New System.Windows.Forms.Button()
        Me.lblcontarisultati = New System.Windows.Forms.Label()
        Me.lstsoluzioni = New System.Windows.Forms.ListBox()
        Me.btnpausa = New System.Windows.Forms.Button()
        Me.tmrtrova_risultati = New System.Windows.Forms.Timer(Me.components)
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.image_scacchiera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Box_scacchiera.SuspendLayout()
        CType(Me.q8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box_comandi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(10, 161)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(52, 13)
        Label1.TabIndex = 3
        Label1.Text = "Soluzioni:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 203)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(72, 13)
        Label2.TabIndex = 4
        Label2.Text = "Segui ricerca:"
        '
        'lblselezionata
        '
        Me.lblselezionata.Location = New System.Drawing.Point(123, 161)
        Me.lblselezionata.Name = "lblselezionata"
        Me.lblselezionata.Size = New System.Drawing.Size(39, 13)
        Me.lblselezionata.TabIndex = 5
        Me.lblselezionata.Text = "0/"
        Me.lblselezionata.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'image_scacchiera
        '
        Me.image_scacchiera.BackgroundImage = CType(resources.GetObject("image_scacchiera.BackgroundImage"), System.Drawing.Image)
        Me.image_scacchiera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.image_scacchiera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.image_scacchiera.Location = New System.Drawing.Point(6, 19)
        Me.image_scacchiera.Name = "image_scacchiera"
        Me.image_scacchiera.Size = New System.Drawing.Size(450, 450)
        Me.image_scacchiera.TabIndex = 0
        Me.image_scacchiera.TabStop = False
        Me.image_scacchiera.WaitOnLoad = True
        '
        'Box_scacchiera
        '
        Me.Box_scacchiera.Controls.Add(Me.q8)
        Me.Box_scacchiera.Controls.Add(Me.q7)
        Me.Box_scacchiera.Controls.Add(Me.q5)
        Me.Box_scacchiera.Controls.Add(Me.q6)
        Me.Box_scacchiera.Controls.Add(Me.q4)
        Me.Box_scacchiera.Controls.Add(Me.q3)
        Me.Box_scacchiera.Controls.Add(Me.q2)
        Me.Box_scacchiera.Controls.Add(Me.q1)
        Me.Box_scacchiera.Controls.Add(Me.image_scacchiera)
        Me.Box_scacchiera.Location = New System.Drawing.Point(12, 12)
        Me.Box_scacchiera.Name = "Box_scacchiera"
        Me.Box_scacchiera.Size = New System.Drawing.Size(483, 493)
        Me.Box_scacchiera.TabIndex = 1
        Me.Box_scacchiera.TabStop = False
        Me.Box_scacchiera.Text = "Scacchiera"
        '
        'q8
        '
        Me.q8.BackgroundImage = CType(resources.GetObject("q8.BackgroundImage"), System.Drawing.Image)
        Me.q8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q8.Location = New System.Drawing.Point(400, 21)
        Me.q8.Name = "q8"
        Me.q8.Size = New System.Drawing.Size(56, 56)
        Me.q8.TabIndex = 9
        Me.q8.TabStop = False
        Me.q8.WaitOnLoad = True
        '
        'q7
        '
        Me.q7.BackgroundImage = CType(resources.GetObject("q7.BackgroundImage"), System.Drawing.Image)
        Me.q7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q7.Location = New System.Drawing.Point(344, 21)
        Me.q7.Name = "q7"
        Me.q7.Size = New System.Drawing.Size(56, 56)
        Me.q7.TabIndex = 8
        Me.q7.TabStop = False
        Me.q7.WaitOnLoad = True
        '
        'q5
        '
        Me.q5.BackgroundImage = CType(resources.GetObject("q5.BackgroundImage"), System.Drawing.Image)
        Me.q5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q5.Location = New System.Drawing.Point(233, 21)
        Me.q5.Name = "q5"
        Me.q5.Size = New System.Drawing.Size(56, 56)
        Me.q5.TabIndex = 7
        Me.q5.TabStop = False
        Me.q5.WaitOnLoad = True
        '
        'q6
        '
        Me.q6.BackgroundImage = CType(resources.GetObject("q6.BackgroundImage"), System.Drawing.Image)
        Me.q6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q6.Location = New System.Drawing.Point(290, 21)
        Me.q6.Name = "q6"
        Me.q6.Size = New System.Drawing.Size(56, 56)
        Me.q6.TabIndex = 5
        Me.q6.TabStop = False
        Me.q6.WaitOnLoad = True
        '
        'q4
        '
        Me.q4.BackgroundImage = CType(resources.GetObject("q4.BackgroundImage"), System.Drawing.Image)
        Me.q4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q4.Location = New System.Drawing.Point(176, 21)
        Me.q4.Name = "q4"
        Me.q4.Size = New System.Drawing.Size(56, 56)
        Me.q4.TabIndex = 4
        Me.q4.TabStop = False
        Me.q4.WaitOnLoad = True
        '
        'q3
        '
        Me.q3.BackgroundImage = CType(resources.GetObject("q3.BackgroundImage"), System.Drawing.Image)
        Me.q3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q3.Location = New System.Drawing.Point(120, 21)
        Me.q3.Name = "q3"
        Me.q3.Size = New System.Drawing.Size(56, 56)
        Me.q3.TabIndex = 3
        Me.q3.TabStop = False
        Me.q3.WaitOnLoad = True
        '
        'q2
        '
        Me.q2.BackgroundImage = CType(resources.GetObject("q2.BackgroundImage"), System.Drawing.Image)
        Me.q2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q2.Location = New System.Drawing.Point(63, 21)
        Me.q2.Name = "q2"
        Me.q2.Size = New System.Drawing.Size(56, 56)
        Me.q2.TabIndex = 2
        Me.q2.TabStop = False
        Me.q2.WaitOnLoad = True
        '
        'q1
        '
        Me.q1.BackgroundImage = CType(resources.GetObject("q1.BackgroundImage"), System.Drawing.Image)
        Me.q1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.q1.Location = New System.Drawing.Point(6, 21)
        Me.q1.Name = "q1"
        Me.q1.Size = New System.Drawing.Size(56, 56)
        Me.q1.TabIndex = 1
        Me.q1.TabStop = False
        Me.q1.WaitOnLoad = True
        '
        'box_comandi
        '
        Me.box_comandi.Controls.Add(Me.btnprecedente)
        Me.box_comandi.Controls.Add(Me.btnsuccessivo)
        Me.box_comandi.Controls.Add(Me.lblselezionata)
        Me.box_comandi.Controls.Add(Label2)
        Me.box_comandi.Controls.Add(Label1)
        Me.box_comandi.Controls.Add(Me.lblcontarisultati)
        Me.box_comandi.Controls.Add(Me.lstsoluzioni)
        Me.box_comandi.Controls.Add(Me.btnpausa)
        Me.box_comandi.Location = New System.Drawing.Point(519, 12)
        Me.box_comandi.Name = "box_comandi"
        Me.box_comandi.Size = New System.Drawing.Size(206, 236)
        Me.box_comandi.TabIndex = 0
        Me.box_comandi.TabStop = False
        Me.box_comandi.Text = "Comandi"
        '
        'btnprecedente
        '
        Me.btnprecedente.Location = New System.Drawing.Point(6, 21)
        Me.btnprecedente.Name = "btnprecedente"
        Me.btnprecedente.Size = New System.Drawing.Size(43, 23)
        Me.btnprecedente.TabIndex = 7
        Me.btnprecedente.Text = "<<"
        Me.btnprecedente.UseVisualStyleBackColor = True
        '
        'btnsuccessivo
        '
        Me.btnsuccessivo.Location = New System.Drawing.Point(157, 21)
        Me.btnsuccessivo.Name = "btnsuccessivo"
        Me.btnsuccessivo.Size = New System.Drawing.Size(43, 23)
        Me.btnsuccessivo.TabIndex = 6
        Me.btnsuccessivo.Text = ">>"
        Me.btnsuccessivo.UseVisualStyleBackColor = True
        '
        'lblcontarisultati
        '
        Me.lblcontarisultati.Location = New System.Drawing.Point(159, 161)
        Me.lblcontarisultati.Name = "lblcontarisultati"
        Me.lblcontarisultati.Size = New System.Drawing.Size(19, 13)
        Me.lblcontarisultati.TabIndex = 2
        Me.lblcontarisultati.Text = "00"
        Me.lblcontarisultati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstsoluzioni
        '
        Me.lstsoluzioni.ColumnWidth = 90
        Me.lstsoluzioni.FormattingEnabled = True
        Me.lstsoluzioni.HorizontalScrollbar = True
        Me.lstsoluzioni.Location = New System.Drawing.Point(6, 50)
        Me.lstsoluzioni.MultiColumn = True
        Me.lstsoluzioni.Name = "lstsoluzioni"
        Me.lstsoluzioni.ScrollAlwaysVisible = True
        Me.lstsoluzioni.Size = New System.Drawing.Size(194, 95)
        Me.lstsoluzioni.TabIndex = 1
        '
        'btnpausa
        '
        Me.btnpausa.Location = New System.Drawing.Point(103, 193)
        Me.btnpausa.Name = "btnpausa"
        Me.btnpausa.Size = New System.Drawing.Size(75, 23)
        Me.btnpausa.TabIndex = 0
        Me.btnpausa.Text = "Pausa"
        Me.btnpausa.UseVisualStyleBackColor = True
        '
        'tmrtrova_risultati
        '
        Me.tmrtrova_risultati.Enabled = True
        Me.tmrtrova_risultati.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 552)
        Me.Controls.Add(Me.box_comandi)
        Me.Controls.Add(Me.Box_scacchiera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "8 Regine"
        CType(Me.image_scacchiera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Box_scacchiera.ResumeLayout(False)
        CType(Me.q8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box_comandi.ResumeLayout(False)
        Me.box_comandi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents image_scacchiera As System.Windows.Forms.PictureBox
    Friend WithEvents Box_scacchiera As System.Windows.Forms.GroupBox
    Friend WithEvents q7 As System.Windows.Forms.PictureBox
    Friend WithEvents q5 As System.Windows.Forms.PictureBox
    Friend WithEvents q6 As System.Windows.Forms.PictureBox
    Friend WithEvents q4 As System.Windows.Forms.PictureBox
    Friend WithEvents q3 As System.Windows.Forms.PictureBox
    Friend WithEvents q2 As System.Windows.Forms.PictureBox
    Friend WithEvents q1 As System.Windows.Forms.PictureBox
    Friend WithEvents box_comandi As System.Windows.Forms.GroupBox
    Friend WithEvents lstsoluzioni As System.Windows.Forms.ListBox
    Friend WithEvents btnpausa As System.Windows.Forms.Button
    Friend WithEvents lblcontarisultati As System.Windows.Forms.Label
    Friend WithEvents tmrtrova_risultati As System.Windows.Forms.Timer
    Friend WithEvents q8 As System.Windows.Forms.PictureBox
    Friend WithEvents btnprecedente As System.Windows.Forms.Button
    Friend WithEvents btnsuccessivo As System.Windows.Forms.Button
    Friend WithEvents lblselezionata As System.Windows.Forms.Label

End Class
