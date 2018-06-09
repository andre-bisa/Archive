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
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcronologia = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Label1.Text = "Password:"
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
        Me.GroupBox2.Controls.Add(Me.txtcronologia)
        Me.GroupBox2.Controls.Add(Me.txttesto)
        Me.GroupBox2.Controls.Add(Me.btninvia)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 283)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chat"
        '
        'txtcronologia
        '
        Me.txtcronologia.Location = New System.Drawing.Point(6, 19)
        Me.txtcronologia.Name = "txtcronologia"
        Me.txtcronologia.ReadOnly = True
        Me.txtcronologia.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtcronologia.Size = New System.Drawing.Size(458, 196)
        Me.txtcronologia.TabIndex = 2
        Me.txtcronologia.TabStop = False
        Me.txtcronologia.Text = ""
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btninvia
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 422)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcronologia As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
