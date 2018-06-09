<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtnuova_psw = New System.Windows.Forms.TextBox()
        Me.txtnuova_psw_conferma = New System.Windows.Forms.TextBox()
        Me.btncambia = New System.Windows.Forms.Button()
        Me.lbltentativi = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optpassattiva = New System.Windows.Forms.RadioButton()
        Me.optpassdisattiva = New System.Windows.Forms.RadioButton()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(37, 27)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(91, 13)
        Label1.TabIndex = 0
        Label1.Text = "Nuova Password:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(37, 67)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(103, 13)
        Label2.TabIndex = 2
        Label2.Text = "Conferma password:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(29, 116)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(51, 13)
        Label3.TabIndex = 5
        Label3.Text = "Tentativi:"
        '
        'txtnuova_psw
        '
        Me.txtnuova_psw.Location = New System.Drawing.Point(24, 43)
        Me.txtnuova_psw.Name = "txtnuova_psw"
        Me.txtnuova_psw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnuova_psw.Size = New System.Drawing.Size(114, 20)
        Me.txtnuova_psw.TabIndex = 1
        '
        'txtnuova_psw_conferma
        '
        Me.txtnuova_psw_conferma.Location = New System.Drawing.Point(24, 83)
        Me.txtnuova_psw_conferma.Name = "txtnuova_psw_conferma"
        Me.txtnuova_psw_conferma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnuova_psw_conferma.Size = New System.Drawing.Size(114, 20)
        Me.txtnuova_psw_conferma.TabIndex = 3
        '
        'btncambia
        '
        Me.btncambia.Location = New System.Drawing.Point(38, 136)
        Me.btncambia.Name = "btncambia"
        Me.btncambia.Size = New System.Drawing.Size(75, 23)
        Me.btncambia.TabIndex = 4
        Me.btncambia.Text = "Cambia"
        Me.btncambia.UseVisualStyleBackColor = True
        '
        'lbltentativi
        '
        Me.lbltentativi.AutoSize = True
        Me.lbltentativi.Location = New System.Drawing.Point(86, 116)
        Me.lbltentativi.Name = "lbltentativi"
        Me.lbltentativi.Size = New System.Drawing.Size(0, 13)
        Me.lbltentativi.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnuova_psw_conferma)
        Me.GroupBox1.Controls.Add(Me.lbltentativi)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.txtnuova_psw)
        Me.GroupBox1.Controls.Add(Me.btncambia)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 170)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambio Password"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optpassattiva)
        Me.GroupBox2.Controls.Add(Me.optpassdisattiva)
        Me.GroupBox2.Location = New System.Drawing.Point(185, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 120)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Attivazione Password"
        '
        'optpassattiva
        '
        Me.optpassattiva.AutoSize = True
        Me.optpassattiva.Location = New System.Drawing.Point(16, 83)
        Me.optpassattiva.Name = "optpassattiva"
        Me.optpassattiva.Size = New System.Drawing.Size(52, 17)
        Me.optpassattiva.TabIndex = 1
        Me.optpassattiva.Text = "Attiva"
        Me.optpassattiva.UseVisualStyleBackColor = True
        '
        'optpassdisattiva
        '
        Me.optpassdisattiva.AutoSize = True
        Me.optpassdisattiva.Checked = True
        Me.optpassdisattiva.Location = New System.Drawing.Point(16, 46)
        Me.optpassdisattiva.Name = "optpassdisattiva"
        Me.optpassdisattiva.Size = New System.Drawing.Size(66, 17)
        Me.optpassdisattiva.TabIndex = 0
        Me.optpassdisattiva.TabStop = True
        Me.optpassdisattiva.Text = "Disattiva"
        Me.optpassdisattiva.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AcceptButton = Me.btncambia
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 200)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestisci password"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtnuova_psw As System.Windows.Forms.TextBox
    Friend WithEvents txtnuova_psw_conferma As System.Windows.Forms.TextBox
    Friend WithEvents btncambia As System.Windows.Forms.Button
    Friend WithEvents lbltentativi As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optpassattiva As System.Windows.Forms.RadioButton
    Friend WithEvents optpassdisattiva As System.Windows.Forms.RadioButton
End Class
