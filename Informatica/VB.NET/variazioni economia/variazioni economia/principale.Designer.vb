<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principale
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principale))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnaggiungi_voci = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdescrizione = New System.Windows.Forms.TextBox()
        Me.txtdata = New System.Windows.Forms.DateTimePicker()
        Me.btninserisci = New System.Windows.Forms.Button()
        Me.combovoce = New System.Windows.Forms.ComboBox()
        Me.txtvalore = New System.Windows.Forms.NumericUpDown()
        Me.combotipo = New System.Windows.Forms.ComboBox()
        Me.combosegno = New System.Windows.Forms.ComboBox()
        Me.combovariazione = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.libro_giornale = New System.Windows.Forms.DataGridView()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dare = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.avere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANCELLA = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ECONOMICA_FINANZIARIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltotdare = New System.Windows.Forms.Label()
        Me.lbltotavere = New System.Windows.Forms.Label()
        Me.lblquadratura = New System.Windows.Forms.Label()
        Me.btnvisualizza_finanziaria = New System.Windows.Forms.Button()
        Me.btnvisualizza_economia = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtvalore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.libro_giornale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnaggiungi_voci)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdescrizione)
        Me.GroupBox1.Controls.Add(Me.txtdata)
        Me.GroupBox1.Controls.Add(Me.btninserisci)
        Me.GroupBox1.Controls.Add(Me.combovoce)
        Me.GroupBox1.Controls.Add(Me.txtvalore)
        Me.GroupBox1.Controls.Add(Me.combotipo)
        Me.GroupBox1.Controls.Add(Me.combosegno)
        Me.GroupBox1.Controls.Add(Me.combovariazione)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inserisci variazioni"
        '
        'btnaggiungi_voci
        '
        Me.btnaggiungi_voci.Location = New System.Drawing.Point(566, 22)
        Me.btnaggiungi_voci.Name = "btnaggiungi_voci"
        Me.btnaggiungi_voci.Size = New System.Drawing.Size(32, 23)
        Me.btnaggiungi_voci.TabIndex = 10
        Me.btnaggiungi_voci.Text = "+"
        Me.btnaggiungi_voci.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(677, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Descrizione"
        '
        'txtdescrizione
        '
        Me.txtdescrizione.Location = New System.Drawing.Point(653, 60)
        Me.txtdescrizione.Name = "txtdescrizione"
        Me.txtdescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescrizione.Size = New System.Drawing.Size(113, 20)
        Me.txtdescrizione.TabIndex = 8
        '
        'txtdata
        '
        Me.txtdata.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdata.Location = New System.Drawing.Point(15, 57)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(80, 20)
        Me.txtdata.TabIndex = 7
        Me.txtdata.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
        '
        'btninserisci
        '
        Me.btninserisci.Location = New System.Drawing.Point(334, 102)
        Me.btninserisci.Name = "btninserisci"
        Me.btninserisci.Size = New System.Drawing.Size(75, 23)
        Me.btninserisci.TabIndex = 6
        Me.btninserisci.Text = "Inserisci"
        Me.btninserisci.UseVisualStyleBackColor = True
        '
        'combovoce
        '
        Me.combovoce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combovoce.Enabled = False
        Me.combovoce.FormattingEnabled = True
        Me.combovoce.Location = New System.Drawing.Point(481, 56)
        Me.combovoce.MaxDropDownItems = 100
        Me.combovoce.Name = "combovoce"
        Me.combovoce.Size = New System.Drawing.Size(150, 21)
        Me.combovoce.Sorted = True
        Me.combovoce.TabIndex = 5
        '
        'txtvalore
        '
        Me.txtvalore.DecimalPlaces = 2
        Me.txtvalore.Location = New System.Drawing.Point(370, 55)
        Me.txtvalore.Maximum = New Decimal(New Integer() {9000000, 0, 0, 0})
        Me.txtvalore.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txtvalore.Name = "txtvalore"
        Me.txtvalore.Size = New System.Drawing.Size(92, 20)
        Me.txtvalore.TabIndex = 4
        Me.txtvalore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtvalore.ThousandsSeparator = True
        Me.txtvalore.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'combotipo
        '
        Me.combotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotipo.FormattingEnabled = True
        Me.combotipo.Items.AddRange(New Object() {"CAPITALE PROPRIO", "COSTI", "CREDITI", "DEBITI", "LIQUIDITA'", "RICAVI"})
        Me.combotipo.Location = New System.Drawing.Point(225, 55)
        Me.combotipo.Name = "combotipo"
        Me.combotipo.Size = New System.Drawing.Size(123, 21)
        Me.combotipo.Sorted = True
        Me.combotipo.TabIndex = 3
        '
        'combosegno
        '
        Me.combosegno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combosegno.FormattingEnabled = True
        Me.combosegno.Items.AddRange(New Object() {"+", "-"})
        Me.combosegno.Location = New System.Drawing.Point(171, 56)
        Me.combosegno.Name = "combosegno"
        Me.combosegno.Size = New System.Drawing.Size(35, 21)
        Me.combosegno.TabIndex = 2
        '
        'combovariazione
        '
        Me.combovariazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combovariazione.FormattingEnabled = True
        Me.combovariazione.Items.AddRange(New Object() {"VFA", "VFP", "VEP", "VEN"})
        Me.combovariazione.Location = New System.Drawing.Point(101, 56)
        Me.combovariazione.Name = "combovariazione"
        Me.combovariazione.Size = New System.Drawing.Size(53, 21)
        Me.combovariazione.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(528, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Voce"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valore"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Segno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Variazione"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.libro_giornale)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 265)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Libro giornale"
        '
        'libro_giornale
        '
        Me.libro_giornale.AllowUserToAddRows = False
        Me.libro_giornale.AllowUserToResizeColumns = False
        Me.libro_giornale.AllowUserToResizeRows = False
        Me.libro_giornale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.libro_giornale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.libro_giornale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.libro_giornale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.data, Me.num_reg, Me.codice, Me.conto, Me.descrizione, Me.dare, Me.avere, Me.CANCELLA, Me.ECONOMICA_FINANZIARIA})
        Me.libro_giornale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.libro_giornale.Location = New System.Drawing.Point(3, 16)
        Me.libro_giornale.MultiSelect = False
        Me.libro_giornale.Name = "libro_giornale"
        Me.libro_giornale.ReadOnly = True
        Me.libro_giornale.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.libro_giornale.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.libro_giornale.RowHeadersVisible = False
        Me.libro_giornale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.libro_giornale.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.libro_giornale.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.libro_giornale.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
        Me.libro_giornale.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.libro_giornale.RowTemplate.ReadOnly = True
        Me.libro_giornale.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.libro_giornale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.libro_giornale.Size = New System.Drawing.Size(760, 246)
        Me.libro_giornale.TabIndex = 0
        '
        'data
        '
        Me.data.HeaderText = "DATA"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'num_reg
        '
        Me.num_reg.HeaderText = "N. R."
        Me.num_reg.Name = "num_reg"
        Me.num_reg.ReadOnly = True
        Me.num_reg.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.num_reg.Width = 40
        '
        'codice
        '
        Me.codice.HeaderText = "CODICE"
        Me.codice.Name = "codice"
        Me.codice.ReadOnly = True
        Me.codice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'conto
        '
        Me.conto.HeaderText = "CONTO"
        Me.conto.Name = "conto"
        Me.conto.ReadOnly = True
        Me.conto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'descrizione
        '
        Me.descrizione.HeaderText = "DESCRIZIONE"
        Me.descrizione.Name = "descrizione"
        Me.descrizione.ReadOnly = True
        Me.descrizione.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dare
        '
        Me.dare.HeaderText = "DARE"
        Me.dare.Name = "dare"
        Me.dare.ReadOnly = True
        Me.dare.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'avere
        '
        Me.avere.HeaderText = "AVERE"
        Me.avere.Name = "avere"
        Me.avere.ReadOnly = True
        Me.avere.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CANCELLA
        '
        Me.CANCELLA.HeaderText = "Cancella"
        Me.CANCELLA.Name = "CANCELLA"
        Me.CANCELLA.ReadOnly = True
        '
        'ECONOMICA_FINANZIARIA
        '
        Me.ECONOMICA_FINANZIARIA.HeaderText = "eco_fina"
        Me.ECONOMICA_FINANZIARIA.Name = "ECONOMICA_FINANZIARIA"
        Me.ECONOMICA_FINANZIARIA.ReadOnly = True
        Me.ECONOMICA_FINANZIARIA.Visible = False
        '
        'lbltotdare
        '
        Me.lbltotdare.Location = New System.Drawing.Point(457, 449)
        Me.lbltotdare.Name = "lbltotdare"
        Me.lbltotdare.Size = New System.Drawing.Size(100, 23)
        Me.lbltotdare.TabIndex = 2
        Me.lbltotdare.Text = "0"
        Me.lbltotdare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotavere
        '
        Me.lbltotavere.Location = New System.Drawing.Point(563, 449)
        Me.lbltotavere.Name = "lbltotavere"
        Me.lbltotavere.Size = New System.Drawing.Size(100, 23)
        Me.lbltotavere.TabIndex = 3
        Me.lbltotavere.Text = "0"
        Me.lbltotavere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblquadratura
        '
        Me.lblquadratura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquadratura.ForeColor = System.Drawing.Color.Green
        Me.lblquadratura.Location = New System.Drawing.Point(510, 472)
        Me.lblquadratura.Name = "lblquadratura"
        Me.lblquadratura.Size = New System.Drawing.Size(100, 23)
        Me.lblquadratura.TabIndex = 4
        Me.lblquadratura.Text = "Quadra"
        Me.lblquadratura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnvisualizza_finanziaria
        '
        Me.btnvisualizza_finanziaria.Location = New System.Drawing.Point(15, 472)
        Me.btnvisualizza_finanziaria.Name = "btnvisualizza_finanziaria"
        Me.btnvisualizza_finanziaria.Size = New System.Drawing.Size(105, 50)
        Me.btnvisualizza_finanziaria.TabIndex = 5
        Me.btnvisualizza_finanziaria.Text = "Visualizza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Situazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Patrimoniale"
        Me.btnvisualizza_finanziaria.UseVisualStyleBackColor = True
        '
        'btnvisualizza_economia
        '
        Me.btnvisualizza_economia.Location = New System.Drawing.Point(159, 472)
        Me.btnvisualizza_economia.Name = "btnvisualizza_economia"
        Me.btnvisualizza_economia.Size = New System.Drawing.Size(105, 50)
        Me.btnvisualizza_economia.TabIndex = 6
        Me.btnvisualizza_economia.Text = "Visualizza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Situazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Economica"
        Me.btnvisualizza_economia.UseVisualStyleBackColor = True
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 572)
        Me.Controls.Add(Me.btnvisualizza_economia)
        Me.Controls.Add(Me.btnvisualizza_finanziaria)
        Me.Controls.Add(Me.lblquadratura)
        Me.Controls.Add(Me.lbltotavere)
        Me.Controls.Add(Me.lbltotdare)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principale"
        Me.Text = "Variazioni economia aziendale      by Bisa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtvalore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.libro_giornale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combovariazione As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combosegno As System.Windows.Forms.ComboBox
    Friend WithEvents combotipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtvalore As System.Windows.Forms.NumericUpDown
    Friend WithEvents combovoce As System.Windows.Forms.ComboBox
    Friend WithEvents btninserisci As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents libro_giornale As System.Windows.Forms.DataGridView
    Friend WithEvents lbltotdare As System.Windows.Forms.Label
    Friend WithEvents lbltotavere As System.Windows.Forms.Label
    Friend WithEvents lblquadratura As System.Windows.Forms.Label
    Friend WithEvents txtdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnvisualizza_finanziaria As System.Windows.Forms.Button
    Friend WithEvents btnvisualizza_economia As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdescrizione As System.Windows.Forms.TextBox
    Friend WithEvents btnaggiungi_voci As System.Windows.Forms.Button
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_reg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents conto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dare As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents avere As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANCELLA As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ECONOMICA_FINANZIARIA As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
