<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aggiungi_voci
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnaggiungi_voce = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvoce = New System.Windows.Forms.TextBox()
        Me.combotipo = New System.Windows.Forms.ComboBox()
        Me.tmrchiusura = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnaggiungi_voce)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtvoce)
        Me.GroupBox1.Controls.Add(Me.combotipo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 153)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inserisci:"
        '
        'btnaggiungi_voce
        '
        Me.btnaggiungi_voce.Location = New System.Drawing.Point(135, 95)
        Me.btnaggiungi_voce.Name = "btnaggiungi_voce"
        Me.btnaggiungi_voce.Size = New System.Drawing.Size(75, 23)
        Me.btnaggiungi_voce.TabIndex = 7
        Me.btnaggiungi_voce.Text = "Aggiungi"
        Me.btnaggiungi_voce.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Voce:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo:"
        '
        'txtvoce
        '
        Me.txtvoce.Location = New System.Drawing.Point(197, 55)
        Me.txtvoce.Name = "txtvoce"
        Me.txtvoce.Size = New System.Drawing.Size(132, 20)
        Me.txtvoce.TabIndex = 1
        '
        'combotipo
        '
        Me.combotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotipo.FormattingEnabled = True
        Me.combotipo.Items.AddRange(New Object() {"LIQUIDITA'", "DEBITI", "CREDITI", "RICAVI", "COSTI", "CAPITALE PROPRIO"})
        Me.combotipo.Location = New System.Drawing.Point(23, 55)
        Me.combotipo.Name = "combotipo"
        Me.combotipo.Size = New System.Drawing.Size(123, 21)
        Me.combotipo.TabIndex = 4
        '
        'aggiungi_voci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 176)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aggiungi_voci"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Aggiungi valore nel campo voce"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combotipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtvoce As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnaggiungi_voce As System.Windows.Forms.Button
    Friend WithEvents tmrchiusura As System.Windows.Forms.Timer
End Class
