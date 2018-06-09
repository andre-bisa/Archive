<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnesegui = New System.Windows.Forms.Button()
        Me.lbltentativi = New System.Windows.Forms.Label()
        Me.tmrtempo = New System.Windows.Forms.Timer(Me.components)
        Me.lbltempo = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(14, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 13)
        Label1.TabIndex = 0
        Label1.Text = "Password:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(14, 51)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 13)
        Label2.TabIndex = 3
        Label2.Text = "Tentativi:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(118, 51)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(112, 13)
        Label3.TabIndex = 14
        Label3.Text = "Tempo nuovi tentativi:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(76, 12)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(137, 20)
        Me.txtpassword.TabIndex = 1
        '
        'btnesegui
        '
        Me.btnesegui.Location = New System.Drawing.Point(219, 10)
        Me.btnesegui.Name = "btnesegui"
        Me.btnesegui.Size = New System.Drawing.Size(75, 23)
        Me.btnesegui.TabIndex = 2
        Me.btnesegui.Text = "&Esegui"
        Me.btnesegui.UseVisualStyleBackColor = True
        '
        'lbltentativi
        '
        Me.lbltentativi.AutoSize = True
        Me.lbltentativi.Location = New System.Drawing.Point(73, 51)
        Me.lbltentativi.Name = "lbltentativi"
        Me.lbltentativi.Size = New System.Drawing.Size(24, 13)
        Me.lbltentativi.TabIndex = 4
        Me.lbltentativi.Text = "0/5"
        '
        'tmrtempo
        '
        '
        'lbltempo
        '
        Me.lbltempo.AutoSize = True
        Me.lbltempo.Location = New System.Drawing.Point(236, 51)
        Me.lbltempo.Name = "lbltempo"
        Me.lbltempo.Size = New System.Drawing.Size(34, 13)
        Me.lbltempo.TabIndex = 15
        Me.lbltempo.Text = "00:00"
        '
        'Form4
        '
        Me.AcceptButton = Me.btnesegui
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 82)
        Me.Controls.Add(Me.lbltempo)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.lbltentativi)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.btnesegui)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inserire password prima di eseguire"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnesegui As System.Windows.Forms.Button
    Friend WithEvents lbltentativi As System.Windows.Forms.Label
    Friend WithEvents tmrtempo As System.Windows.Forms.Timer
    Friend WithEvents lbltempo As System.Windows.Forms.Label
End Class
