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
        Me.txttesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnick = New System.Windows.Forms.TextBox()
        Me.btninvia = New System.Windows.Forms.Button()
        Me.btnconnetti = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndisconnetti = New System.Windows.Forms.Button()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstonline = New System.Windows.Forms.ListBox()
        Me.txtcronologia = New System.Windows.Forms.RichTextBox()
        Me.txtnome_comandi = New System.Windows.Forms.TextBox()
        Me.btncomandi = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcacciaip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdebannaip = New System.Windows.Forms.TextBox()
        Me.txtbannaip = New System.Windows.Forms.TextBox()
        Me.btnlista_online = New System.Windows.Forms.Button()
        Me.btntrova_ip = New System.Windows.Forms.Button()
        Me.btnchiudi_server = New System.Windows.Forms.Button()
        Me.btndebanna = New System.Windows.Forms.Button()
        Me.btnbanna = New System.Windows.Forms.Button()
        Me.btncaccia = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnautentica = New System.Windows.Forms.Button()
        Me.tmrfinestra = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttesto
        '
        Me.txttesto.AcceptsReturn = True
        Me.txttesto.Location = New System.Drawing.Point(16, 237)
        Me.txttesto.Name = "txttesto"
        Me.txttesto.Size = New System.Drawing.Size(370, 20)
        Me.txttesto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome da usare:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnick
        '
        Me.txtnick.Location = New System.Drawing.Point(94, 28)
        Me.txtnick.MaxLength = 30
        Me.txtnick.Name = "txtnick"
        Me.txtnick.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtnick.Size = New System.Drawing.Size(181, 20)
        Me.txtnick.TabIndex = 0
        '
        'btninvia
        '
        Me.btninvia.Location = New System.Drawing.Point(392, 235)
        Me.btninvia.Name = "btninvia"
        Me.btninvia.Size = New System.Drawing.Size(72, 23)
        Me.btninvia.TabIndex = 1
        Me.btninvia.Text = "Invia"
        Me.btninvia.UseVisualStyleBackColor = True
        '
        'btnconnetti
        '
        Me.btnconnetti.Location = New System.Drawing.Point(294, 26)
        Me.btnconnetti.Name = "btnconnetti"
        Me.btnconnetti.Size = New System.Drawing.Size(75, 23)
        Me.btnconnetti.TabIndex = 2
        Me.btnconnetti.Text = "Connetti"
        Me.btnconnetti.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "IP:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndisconnetti)
        Me.GroupBox1.Controls.Add(Me.txtip)
        Me.GroupBox1.Controls.Add(Me.txtnick)
        Me.GroupBox1.Controls.Add(Me.btnconnetti)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connessione"
        '
        'btndisconnetti
        '
        Me.btndisconnetti.Enabled = False
        Me.btndisconnetti.Location = New System.Drawing.Point(294, 62)
        Me.btndisconnetti.Name = "btndisconnetti"
        Me.btndisconnetti.Size = New System.Drawing.Size(75, 23)
        Me.btndisconnetti.TabIndex = 5
        Me.btndisconnetti.Text = "Disconnetti"
        Me.btndisconnetti.UseVisualStyleBackColor = True
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(94, 64)
        Me.txtip.MaxLength = 30
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(181, 20)
        Me.txtip.TabIndex = 1
        Me.txtip.Text = "127.0.0.1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lstonline)
        Me.GroupBox2.Controls.Add(Me.txtcronologia)
        Me.GroupBox2.Controls.Add(Me.txttesto)
        Me.GroupBox2.Controls.Add(Me.btninvia)
        Me.GroupBox2.Controls.Add(Me.txtnome_comandi)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 283)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chat"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(358, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Account online:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstonline
        '
        Me.lstonline.FormattingEnabled = True
        Me.lstonline.HorizontalScrollbar = True
        Me.lstonline.Location = New System.Drawing.Point(358, 42)
        Me.lstonline.Name = "lstonline"
        Me.lstonline.ScrollAlwaysVisible = True
        Me.lstonline.Size = New System.Drawing.Size(106, 173)
        Me.lstonline.Sorted = True
        Me.lstonline.TabIndex = 3
        Me.lstonline.TabStop = False
        '
        'txtcronologia
        '
        Me.txtcronologia.Location = New System.Drawing.Point(6, 19)
        Me.txtcronologia.Name = "txtcronologia"
        Me.txtcronologia.ReadOnly = True
        Me.txtcronologia.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtcronologia.Size = New System.Drawing.Size(346, 196)
        Me.txtcronologia.TabIndex = 2
        Me.txtcronologia.TabStop = False
        Me.txtcronologia.Text = ""
        '
        'txtnome_comandi
        '
        Me.txtnome_comandi.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtnome_comandi.Enabled = False
        Me.txtnome_comandi.Location = New System.Drawing.Point(361, 50)
        Me.txtnome_comandi.Name = "txtnome_comandi"
        Me.txtnome_comandi.ReadOnly = True
        Me.txtnome_comandi.Size = New System.Drawing.Size(78, 20)
        Me.txtnome_comandi.TabIndex = 12
        Me.txtnome_comandi.TabStop = False
        Me.txtnome_comandi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncomandi
        '
        Me.btncomandi.Location = New System.Drawing.Point(400, 40)
        Me.btncomandi.Name = "btncomandi"
        Me.btncomandi.Size = New System.Drawing.Size(82, 42)
        Me.btncomandi.TabIndex = 1
        Me.btncomandi.Text = "Mostra tutti i comandi-->"
        Me.btncomandi.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtcacciaip)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtdebannaip)
        Me.GroupBox3.Controls.Add(Me.txtbannaip)
        Me.GroupBox3.Controls.Add(Me.btnlista_online)
        Me.GroupBox3.Controls.Add(Me.btntrova_ip)
        Me.GroupBox3.Controls.Add(Me.btnchiudi_server)
        Me.GroupBox3.Controls.Add(Me.btndebanna)
        Me.GroupBox3.Controls.Add(Me.btnbanna)
        Me.GroupBox3.Controls.Add(Me.btncaccia)
        Me.GroupBox3.Controls.Add(Me.txtpassword)
        Me.GroupBox3.Controls.Add(Me.btnautentica)
        Me.GroupBox3.Location = New System.Drawing.Point(500, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(252, 363)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comandi admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Per ip:"
        '
        'txtcacciaip
        '
        Me.txtcacciaip.Enabled = False
        Me.txtcacciaip.Location = New System.Drawing.Point(140, 127)
        Me.txtcacciaip.Name = "txtcacciaip"
        Me.txtcacciaip.Size = New System.Drawing.Size(100, 20)
        Me.txtcacciaip.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Per ip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Per ip:"
        '
        'txtdebannaip
        '
        Me.txtdebannaip.Enabled = False
        Me.txtdebannaip.Location = New System.Drawing.Point(140, 186)
        Me.txtdebannaip.Name = "txtdebannaip"
        Me.txtdebannaip.Size = New System.Drawing.Size(100, 20)
        Me.txtdebannaip.TabIndex = 14
        '
        'txtbannaip
        '
        Me.txtbannaip.Enabled = False
        Me.txtbannaip.Location = New System.Drawing.Point(140, 156)
        Me.txtbannaip.Name = "txtbannaip"
        Me.txtbannaip.Size = New System.Drawing.Size(100, 20)
        Me.txtbannaip.TabIndex = 13
        '
        'btnlista_online
        '
        Me.btnlista_online.Enabled = False
        Me.btnlista_online.Location = New System.Drawing.Point(107, 317)
        Me.btnlista_online.Name = "btnlista_online"
        Me.btnlista_online.Size = New System.Drawing.Size(130, 23)
        Me.btnlista_online.TabIndex = 11
        Me.btnlista_online.Text = "Lista account online"
        Me.btnlista_online.UseVisualStyleBackColor = True
        '
        'btntrova_ip
        '
        Me.btntrova_ip.Enabled = False
        Me.btntrova_ip.Location = New System.Drawing.Point(6, 212)
        Me.btntrova_ip.Name = "btntrova_ip"
        Me.btntrova_ip.Size = New System.Drawing.Size(88, 23)
        Me.btntrova_ip.TabIndex = 9
        Me.btntrova_ip.Text = "Trova ip"
        Me.btntrova_ip.UseVisualStyleBackColor = True
        '
        'btnchiudi_server
        '
        Me.btnchiudi_server.Enabled = False
        Me.btnchiudi_server.Location = New System.Drawing.Point(6, 317)
        Me.btnchiudi_server.Name = "btnchiudi_server"
        Me.btnchiudi_server.Size = New System.Drawing.Size(95, 23)
        Me.btnchiudi_server.TabIndex = 10
        Me.btnchiudi_server.Text = "Chiudi server"
        Me.btnchiudi_server.UseVisualStyleBackColor = True
        '
        'btndebanna
        '
        Me.btndebanna.Enabled = False
        Me.btndebanna.Location = New System.Drawing.Point(6, 183)
        Me.btndebanna.Name = "btndebanna"
        Me.btndebanna.Size = New System.Drawing.Size(88, 23)
        Me.btndebanna.TabIndex = 7
        Me.btndebanna.Text = "De-banna"
        Me.btndebanna.UseVisualStyleBackColor = True
        '
        'btnbanna
        '
        Me.btnbanna.Enabled = False
        Me.btnbanna.Location = New System.Drawing.Point(6, 154)
        Me.btnbanna.Name = "btnbanna"
        Me.btnbanna.Size = New System.Drawing.Size(88, 23)
        Me.btnbanna.TabIndex = 5
        Me.btnbanna.Text = "Banna"
        Me.btnbanna.UseVisualStyleBackColor = True
        '
        'btncaccia
        '
        Me.btncaccia.Enabled = False
        Me.btncaccia.Location = New System.Drawing.Point(6, 125)
        Me.btncaccia.Name = "btncaccia"
        Me.btncaccia.Size = New System.Drawing.Size(88, 23)
        Me.btncaccia.TabIndex = 3
        Me.btncaccia.Text = "Caccia"
        Me.btncaccia.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(6, 54)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(137, 20)
        Me.txtpassword.TabIndex = 0
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'btnautentica
        '
        Me.btnautentica.Location = New System.Drawing.Point(149, 52)
        Me.btnautentica.Name = "btnautentica"
        Me.btnautentica.Size = New System.Drawing.Size(88, 23)
        Me.btnautentica.TabIndex = 1
        Me.btnautentica.Text = "Autenticati"
        Me.btnautentica.UseVisualStyleBackColor = True
        '
        'tmrfinestra
        '
        Me.tmrfinestra.Interval = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 422)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btncomandi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Chat by Bisa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txttesto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnick As System.Windows.Forms.TextBox
    Friend WithEvents btninvia As System.Windows.Forms.Button
    Friend WithEvents btnconnetti As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents btndisconnetti As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btncomandi As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tmrfinestra As System.Windows.Forms.Timer
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnautentica As System.Windows.Forms.Button
    Friend WithEvents btndebanna As System.Windows.Forms.Button
    Friend WithEvents btnbanna As System.Windows.Forms.Button
    Friend WithEvents btncaccia As System.Windows.Forms.Button
    Friend WithEvents btnchiudi_server As System.Windows.Forms.Button
    Friend WithEvents btntrova_ip As System.Windows.Forms.Button
    Friend WithEvents txtcronologia As System.Windows.Forms.RichTextBox
    Friend WithEvents btnlista_online As System.Windows.Forms.Button
    Friend WithEvents lstonline As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdebannaip As System.Windows.Forms.TextBox
    Friend WithEvents txtbannaip As System.Windows.Forms.TextBox
    Friend WithEvents txtnome_comandi As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcacciaip As System.Windows.Forms.TextBox

End Class
