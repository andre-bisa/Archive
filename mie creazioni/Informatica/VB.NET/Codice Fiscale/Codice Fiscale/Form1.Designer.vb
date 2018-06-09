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
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcognome = New System.Windows.Forms.TextBox()
        Me.txtprovincia = New System.Windows.Forms.TextBox()
        Me.txtluogo = New System.Windows.Forms.TextBox()
        Me.txtdata = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsesso = New System.Windows.Forms.ComboBox()
        Me.btncalcola = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcodice_fiscale = New System.Windows.Forms.TextBox()
        Me.btncopia = New System.Windows.Forms.Button()
        Me.btncancella = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(129, 44)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(100, 20)
        Me.txtnome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cognome"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Luogo di nascita"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Provincia"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcognome
        '
        Me.txtcognome.Location = New System.Drawing.Point(129, 11)
        Me.txtcognome.Name = "txtcognome"
        Me.txtcognome.Size = New System.Drawing.Size(100, 20)
        Me.txtcognome.TabIndex = 0
        '
        'txtprovincia
        '
        Me.txtprovincia.Location = New System.Drawing.Point(129, 113)
        Me.txtprovincia.MaxLength = 2
        Me.txtprovincia.Name = "txtprovincia"
        Me.txtprovincia.Size = New System.Drawing.Size(41, 20)
        Me.txtprovincia.TabIndex = 3
        '
        'txtluogo
        '
        Me.txtluogo.Location = New System.Drawing.Point(129, 78)
        Me.txtluogo.Name = "txtluogo"
        Me.txtluogo.Size = New System.Drawing.Size(100, 20)
        Me.txtluogo.TabIndex = 2
        '
        'txtdata
        '
        Me.txtdata.CustomFormat = ""
        Me.txtdata.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdata.Location = New System.Drawing.Point(129, 148)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(100, 20)
        Me.txtdata.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Data di nascita"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sesso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsesso
        '
        Me.txtsesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtsesso.FormattingEnabled = True
        Me.txtsesso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtsesso.Items.AddRange(New Object() {"Maschio", "Femmina"})
        Me.txtsesso.Location = New System.Drawing.Point(129, 185)
        Me.txtsesso.MaxDropDownItems = 2
        Me.txtsesso.Name = "txtsesso"
        Me.txtsesso.Size = New System.Drawing.Size(100, 21)
        Me.txtsesso.TabIndex = 5
        '
        'btncalcola
        '
        Me.btncalcola.Location = New System.Drawing.Point(95, 227)
        Me.btncalcola.Name = "btncalcola"
        Me.btncalcola.Size = New System.Drawing.Size(75, 23)
        Me.btncalcola.TabIndex = 6
        Me.btncalcola.Text = "Calcola"
        Me.btncalcola.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Codice fiscale:"
        '
        'txtcodice_fiscale
        '
        Me.txtcodice_fiscale.Location = New System.Drawing.Point(286, 111)
        Me.txtcodice_fiscale.Name = "txtcodice_fiscale"
        Me.txtcodice_fiscale.ReadOnly = True
        Me.txtcodice_fiscale.Size = New System.Drawing.Size(206, 20)
        Me.txtcodice_fiscale.TabIndex = 12
        Me.txtcodice_fiscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncopia
        '
        Me.btncopia.Location = New System.Drawing.Point(365, 71)
        Me.btncopia.Name = "btncopia"
        Me.btncopia.Size = New System.Drawing.Size(49, 23)
        Me.btncopia.TabIndex = 13
        Me.btncopia.Text = "Copia"
        Me.btncopia.UseVisualStyleBackColor = True
        '
        'btncancella
        '
        Me.btncancella.Location = New System.Drawing.Point(420, 71)
        Me.btncancella.Name = "btncancella"
        Me.btncancella.Size = New System.Drawing.Size(58, 23)
        Me.btncancella.TabIndex = 14
        Me.btncancella.Text = "Cancella"
        Me.btncancella.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 277)
        Me.Controls.Add(Me.btncancella)
        Me.Controls.Add(Me.btncopia)
        Me.Controls.Add(Me.txtcodice_fiscale)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncalcola)
        Me.Controls.Add(Me.txtsesso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdata)
        Me.Controls.Add(Me.txtluogo)
        Me.Controls.Add(Me.txtprovincia)
        Me.Controls.Add(Me.txtcognome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calcolo codice fiscale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcognome As System.Windows.Forms.TextBox
    Friend WithEvents txtprovincia As System.Windows.Forms.TextBox
    Friend WithEvents txtluogo As System.Windows.Forms.TextBox
    Friend WithEvents txtdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsesso As System.Windows.Forms.ComboBox
    Friend WithEvents btncalcola As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcodice_fiscale As System.Windows.Forms.TextBox
    Friend WithEvents btncopia As System.Windows.Forms.Button
    Friend WithEvents btncancella As System.Windows.Forms.Button

End Class
