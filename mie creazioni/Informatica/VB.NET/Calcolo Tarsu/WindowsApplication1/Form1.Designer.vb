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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optnodomestica = New System.Windows.Forms.RadioButton()
        Me.optdomestica = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optclasse16 = New System.Windows.Forms.RadioButton()
        Me.optclasse17 = New System.Windows.Forms.RadioButton()
        Me.optclasse18 = New System.Windows.Forms.RadioButton()
        Me.optclasse19 = New System.Windows.Forms.RadioButton()
        Me.optclasse20 = New System.Windows.Forms.RadioButton()
        Me.optclasse21 = New System.Windows.Forms.RadioButton()
        Me.optclasse22 = New System.Windows.Forms.RadioButton()
        Me.optclasse12 = New System.Windows.Forms.RadioButton()
        Me.optclasse15 = New System.Windows.Forms.RadioButton()
        Me.optclasse14 = New System.Windows.Forms.RadioButton()
        Me.optclasse13 = New System.Windows.Forms.RadioButton()
        Me.optclasse11 = New System.Windows.Forms.RadioButton()
        Me.optclasse10 = New System.Windows.Forms.RadioButton()
        Me.optclasse9 = New System.Windows.Forms.RadioButton()
        Me.optclasse8 = New System.Windows.Forms.RadioButton()
        Me.optclasse7 = New System.Windows.Forms.RadioButton()
        Me.optclasse6 = New System.Windows.Forms.RadioButton()
        Me.optclasse5 = New System.Windows.Forms.RadioButton()
        Me.optclasse4 = New System.Windows.Forms.RadioButton()
        Me.optclasse3 = New System.Windows.Forms.RadioButton()
        Me.optclasse2 = New System.Windows.Forms.RadioButton()
        Me.optclasse1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltariffa = New System.Windows.Forms.Label()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.txtmq = New System.Windows.Forms.NumericUpDown()
        Me.txtabitanti = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtdescrizione = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtmq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtabitanti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optnodomestica)
        Me.GroupBox1.Controls.Add(Me.optdomestica)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo utenza"
        '
        'optnodomestica
        '
        Me.optnodomestica.AutoSize = True
        Me.optnodomestica.Location = New System.Drawing.Point(31, 100)
        Me.optnodomestica.Name = "optnodomestica"
        Me.optnodomestica.Size = New System.Drawing.Size(96, 17)
        Me.optnodomestica.TabIndex = 3
        Me.optnodomestica.Text = "Non domestica"
        Me.optnodomestica.UseVisualStyleBackColor = True
        '
        'optdomestica
        '
        Me.optdomestica.AutoSize = True
        Me.optdomestica.Checked = True
        Me.optdomestica.Location = New System.Drawing.Point(31, 55)
        Me.optdomestica.Name = "optdomestica"
        Me.optdomestica.Size = New System.Drawing.Size(75, 17)
        Me.optdomestica.TabIndex = 2
        Me.optdomestica.TabStop = True
        Me.optdomestica.Text = "Domestica"
        Me.optdomestica.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optclasse16)
        Me.GroupBox2.Controls.Add(Me.optclasse17)
        Me.GroupBox2.Controls.Add(Me.optclasse18)
        Me.GroupBox2.Controls.Add(Me.optclasse19)
        Me.GroupBox2.Controls.Add(Me.optclasse20)
        Me.GroupBox2.Controls.Add(Me.optclasse21)
        Me.GroupBox2.Controls.Add(Me.optclasse22)
        Me.GroupBox2.Controls.Add(Me.optclasse12)
        Me.GroupBox2.Controls.Add(Me.optclasse15)
        Me.GroupBox2.Controls.Add(Me.optclasse14)
        Me.GroupBox2.Controls.Add(Me.optclasse13)
        Me.GroupBox2.Controls.Add(Me.optclasse11)
        Me.GroupBox2.Controls.Add(Me.optclasse10)
        Me.GroupBox2.Controls.Add(Me.optclasse9)
        Me.GroupBox2.Controls.Add(Me.optclasse8)
        Me.GroupBox2.Controls.Add(Me.optclasse7)
        Me.GroupBox2.Controls.Add(Me.optclasse6)
        Me.GroupBox2.Controls.Add(Me.optclasse5)
        Me.GroupBox2.Controls.Add(Me.optclasse4)
        Me.GroupBox2.Controls.Add(Me.optclasse3)
        Me.GroupBox2.Controls.Add(Me.optclasse2)
        Me.GroupBox2.Controls.Add(Me.optclasse1)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 155)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo utenza non domestica"
        '
        'optclasse16
        '
        Me.optclasse16.AutoSize = True
        Me.optclasse16.Enabled = False
        Me.optclasse16.Location = New System.Drawing.Point(246, 32)
        Me.optclasse16.Name = "optclasse16"
        Me.optclasse16.Size = New System.Drawing.Size(71, 17)
        Me.optclasse16.TabIndex = 23
        Me.optclasse16.Text = "Classe 16"
        Me.optclasse16.UseVisualStyleBackColor = True
        '
        'optclasse17
        '
        Me.optclasse17.AutoSize = True
        Me.optclasse17.Enabled = False
        Me.optclasse17.Location = New System.Drawing.Point(246, 55)
        Me.optclasse17.Name = "optclasse17"
        Me.optclasse17.Size = New System.Drawing.Size(71, 17)
        Me.optclasse17.TabIndex = 22
        Me.optclasse17.Text = "Classe 17"
        Me.optclasse17.UseVisualStyleBackColor = True
        '
        'optclasse18
        '
        Me.optclasse18.AutoSize = True
        Me.optclasse18.Enabled = False
        Me.optclasse18.Location = New System.Drawing.Point(246, 78)
        Me.optclasse18.Name = "optclasse18"
        Me.optclasse18.Size = New System.Drawing.Size(71, 17)
        Me.optclasse18.TabIndex = 21
        Me.optclasse18.Text = "Classe 18"
        Me.optclasse18.UseVisualStyleBackColor = True
        '
        'optclasse19
        '
        Me.optclasse19.AutoSize = True
        Me.optclasse19.Enabled = False
        Me.optclasse19.Location = New System.Drawing.Point(246, 100)
        Me.optclasse19.Name = "optclasse19"
        Me.optclasse19.Size = New System.Drawing.Size(71, 17)
        Me.optclasse19.TabIndex = 20
        Me.optclasse19.Text = "Classe 19"
        Me.optclasse19.UseVisualStyleBackColor = True
        '
        'optclasse20
        '
        Me.optclasse20.AutoSize = True
        Me.optclasse20.Enabled = False
        Me.optclasse20.Location = New System.Drawing.Point(246, 123)
        Me.optclasse20.Name = "optclasse20"
        Me.optclasse20.Size = New System.Drawing.Size(71, 17)
        Me.optclasse20.TabIndex = 19
        Me.optclasse20.Text = "Classe 20"
        Me.optclasse20.UseVisualStyleBackColor = True
        '
        'optclasse21
        '
        Me.optclasse21.AutoSize = True
        Me.optclasse21.Enabled = False
        Me.optclasse21.Location = New System.Drawing.Point(323, 32)
        Me.optclasse21.Name = "optclasse21"
        Me.optclasse21.Size = New System.Drawing.Size(71, 17)
        Me.optclasse21.TabIndex = 18
        Me.optclasse21.Text = "Classe 21"
        Me.optclasse21.UseVisualStyleBackColor = True
        '
        'optclasse22
        '
        Me.optclasse22.AutoSize = True
        Me.optclasse22.Enabled = False
        Me.optclasse22.Location = New System.Drawing.Point(323, 55)
        Me.optclasse22.Name = "optclasse22"
        Me.optclasse22.Size = New System.Drawing.Size(71, 17)
        Me.optclasse22.TabIndex = 17
        Me.optclasse22.Text = "Classe 22"
        Me.optclasse22.UseVisualStyleBackColor = True
        '
        'optclasse12
        '
        Me.optclasse12.AutoSize = True
        Me.optclasse12.Enabled = False
        Me.optclasse12.Location = New System.Drawing.Point(169, 54)
        Me.optclasse12.Name = "optclasse12"
        Me.optclasse12.Size = New System.Drawing.Size(71, 17)
        Me.optclasse12.TabIndex = 16
        Me.optclasse12.Text = "Classe 12"
        Me.optclasse12.UseVisualStyleBackColor = True
        '
        'optclasse15
        '
        Me.optclasse15.AutoSize = True
        Me.optclasse15.Enabled = False
        Me.optclasse15.Location = New System.Drawing.Point(169, 123)
        Me.optclasse15.Name = "optclasse15"
        Me.optclasse15.Size = New System.Drawing.Size(71, 17)
        Me.optclasse15.TabIndex = 15
        Me.optclasse15.Text = "Classe 15"
        Me.optclasse15.UseVisualStyleBackColor = True
        '
        'optclasse14
        '
        Me.optclasse14.AutoSize = True
        Me.optclasse14.Enabled = False
        Me.optclasse14.Location = New System.Drawing.Point(169, 100)
        Me.optclasse14.Name = "optclasse14"
        Me.optclasse14.Size = New System.Drawing.Size(71, 17)
        Me.optclasse14.TabIndex = 14
        Me.optclasse14.Text = "Classe 14"
        Me.optclasse14.UseVisualStyleBackColor = True
        '
        'optclasse13
        '
        Me.optclasse13.AutoSize = True
        Me.optclasse13.Enabled = False
        Me.optclasse13.Location = New System.Drawing.Point(169, 77)
        Me.optclasse13.Name = "optclasse13"
        Me.optclasse13.Size = New System.Drawing.Size(71, 17)
        Me.optclasse13.TabIndex = 13
        Me.optclasse13.Text = "Classe 13"
        Me.optclasse13.UseVisualStyleBackColor = True
        '
        'optclasse11
        '
        Me.optclasse11.AutoSize = True
        Me.optclasse11.Enabled = False
        Me.optclasse11.Location = New System.Drawing.Point(169, 32)
        Me.optclasse11.Name = "optclasse11"
        Me.optclasse11.Size = New System.Drawing.Size(71, 17)
        Me.optclasse11.TabIndex = 12
        Me.optclasse11.Text = "Classe 11"
        Me.optclasse11.UseVisualStyleBackColor = True
        '
        'optclasse10
        '
        Me.optclasse10.AutoSize = True
        Me.optclasse10.Enabled = False
        Me.optclasse10.Location = New System.Drawing.Point(92, 123)
        Me.optclasse10.Name = "optclasse10"
        Me.optclasse10.Size = New System.Drawing.Size(71, 17)
        Me.optclasse10.TabIndex = 11
        Me.optclasse10.Text = "Classe 10"
        Me.optclasse10.UseVisualStyleBackColor = True
        '
        'optclasse9
        '
        Me.optclasse9.AutoSize = True
        Me.optclasse9.Enabled = False
        Me.optclasse9.Location = New System.Drawing.Point(92, 100)
        Me.optclasse9.Name = "optclasse9"
        Me.optclasse9.Size = New System.Drawing.Size(65, 17)
        Me.optclasse9.TabIndex = 10
        Me.optclasse9.Text = "Classe 9"
        Me.optclasse9.UseVisualStyleBackColor = True
        '
        'optclasse8
        '
        Me.optclasse8.AutoSize = True
        Me.optclasse8.Enabled = False
        Me.optclasse8.Location = New System.Drawing.Point(92, 77)
        Me.optclasse8.Name = "optclasse8"
        Me.optclasse8.Size = New System.Drawing.Size(65, 17)
        Me.optclasse8.TabIndex = 9
        Me.optclasse8.Text = "Classe 8"
        Me.optclasse8.UseVisualStyleBackColor = True
        '
        'optclasse7
        '
        Me.optclasse7.AutoSize = True
        Me.optclasse7.Enabled = False
        Me.optclasse7.Location = New System.Drawing.Point(92, 55)
        Me.optclasse7.Name = "optclasse7"
        Me.optclasse7.Size = New System.Drawing.Size(65, 17)
        Me.optclasse7.TabIndex = 8
        Me.optclasse7.Text = "Classe 7"
        Me.optclasse7.UseVisualStyleBackColor = True
        '
        'optclasse6
        '
        Me.optclasse6.AutoSize = True
        Me.optclasse6.Enabled = False
        Me.optclasse6.Location = New System.Drawing.Point(92, 32)
        Me.optclasse6.Name = "optclasse6"
        Me.optclasse6.Size = New System.Drawing.Size(65, 17)
        Me.optclasse6.TabIndex = 7
        Me.optclasse6.Text = "Classe 6"
        Me.optclasse6.UseVisualStyleBackColor = True
        '
        'optclasse5
        '
        Me.optclasse5.AutoSize = True
        Me.optclasse5.Enabled = False
        Me.optclasse5.Location = New System.Drawing.Point(21, 123)
        Me.optclasse5.Name = "optclasse5"
        Me.optclasse5.Size = New System.Drawing.Size(65, 17)
        Me.optclasse5.TabIndex = 6
        Me.optclasse5.Text = "Classe 5"
        Me.optclasse5.UseVisualStyleBackColor = True
        '
        'optclasse4
        '
        Me.optclasse4.AutoSize = True
        Me.optclasse4.Enabled = False
        Me.optclasse4.Location = New System.Drawing.Point(21, 100)
        Me.optclasse4.Name = "optclasse4"
        Me.optclasse4.Size = New System.Drawing.Size(65, 17)
        Me.optclasse4.TabIndex = 5
        Me.optclasse4.Text = "Classe 4"
        Me.optclasse4.UseVisualStyleBackColor = True
        '
        'optclasse3
        '
        Me.optclasse3.AutoSize = True
        Me.optclasse3.Enabled = False
        Me.optclasse3.Location = New System.Drawing.Point(21, 77)
        Me.optclasse3.Name = "optclasse3"
        Me.optclasse3.Size = New System.Drawing.Size(65, 17)
        Me.optclasse3.TabIndex = 4
        Me.optclasse3.Text = "Classe 3"
        Me.optclasse3.UseVisualStyleBackColor = True
        '
        'optclasse2
        '
        Me.optclasse2.AutoSize = True
        Me.optclasse2.Enabled = False
        Me.optclasse2.Location = New System.Drawing.Point(21, 55)
        Me.optclasse2.Name = "optclasse2"
        Me.optclasse2.Size = New System.Drawing.Size(65, 17)
        Me.optclasse2.TabIndex = 3
        Me.optclasse2.Text = "Classe 2"
        Me.optclasse2.UseVisualStyleBackColor = True
        '
        'optclasse1
        '
        Me.optclasse1.AutoSize = True
        Me.optclasse1.Enabled = False
        Me.optclasse1.Location = New System.Drawing.Point(21, 32)
        Me.optclasse1.Name = "optclasse1"
        Me.optclasse1.Size = New System.Drawing.Size(65, 17)
        Me.optclasse1.TabIndex = 2
        Me.optclasse1.Text = "Classe 1"
        Me.optclasse1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Metri quadrati:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(44, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero abitanti:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(44, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tariffa:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(44, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Totale calcolato:"
        '
        'lbltariffa
        '
        Me.lbltariffa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbltariffa.Location = New System.Drawing.Point(184, 290)
        Me.lbltariffa.Name = "lbltariffa"
        Me.lbltariffa.Size = New System.Drawing.Size(100, 23)
        Me.lbltariffa.TabIndex = 6
        Me.lbltariffa.Text = "2,36"
        Me.lbltariffa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltot
        '
        Me.lbltot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbltot.Location = New System.Drawing.Point(184, 325)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(100, 23)
        Me.lbltot.TabIndex = 7
        Me.lbltot.Text = "0,00"
        Me.lbltot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(198, 383)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(86, 34)
        Me.btncalcola.TabIndex = 10
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'txtmq
        '
        Me.txtmq.DecimalPlaces = 2
        Me.txtmq.Location = New System.Drawing.Point(187, 216)
        Me.txtmq.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtmq.Name = "txtmq"
        Me.txtmq.Size = New System.Drawing.Size(149, 20)
        Me.txtmq.TabIndex = 11
        '
        'txtabitanti
        '
        Me.txtabitanti.Location = New System.Drawing.Point(187, 252)
        Me.txtabitanti.Name = "txtabitanti"
        Me.txtabitanti.Size = New System.Drawing.Size(120, 20)
        Me.txtabitanti.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtdescrizione)
        Me.GroupBox3.Location = New System.Drawing.Point(367, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 176)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descrizione"
        '
        'txtdescrizione
        '
        Me.txtdescrizione.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtdescrizione.DetectUrls = False
        Me.txtdescrizione.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescrizione.ForeColor = System.Drawing.Color.Red
        Me.txtdescrizione.Location = New System.Drawing.Point(6, 19)
        Me.txtdescrizione.Name = "txtdescrizione"
        Me.txtdescrizione.ReadOnly = True
        Me.txtdescrizione.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtdescrizione.Size = New System.Drawing.Size(287, 151)
        Me.txtdescrizione.TabIndex = 16
        Me.txtdescrizione.TabStop = False
        Me.txtdescrizione.Text = "Prezzo metri quadrati l'anno per un abitante a Bologna"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 480)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtabitanti)
        Me.Controls.Add(Me.txtmq)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.lbltariffa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calcolo tarsu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtmq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtabitanti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optnodomestica As System.Windows.Forms.RadioButton
    Friend WithEvents optdomestica As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optclasse4 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse3 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse2 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltariffa As System.Windows.Forms.Label
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents txtmq As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtabitanti As System.Windows.Forms.NumericUpDown
    Friend WithEvents optclasse5 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse16 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse17 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse18 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse19 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse20 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse21 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse22 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse12 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse15 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse14 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse13 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse11 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse10 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse9 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse8 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse7 As System.Windows.Forms.RadioButton
    Friend WithEvents optclasse6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescrizione As System.Windows.Forms.RichTextBox

End Class
