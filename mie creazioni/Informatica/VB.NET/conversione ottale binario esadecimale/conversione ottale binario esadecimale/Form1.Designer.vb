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
        Me.txtdecimale = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optesadecimale = New System.Windows.Forms.RadioButton()
        Me.optottale = New System.Windows.Forms.RadioButton()
        Me.optbinario = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtrisultato = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtdecimale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdecimale)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Numero decimale"
        '
        'txtdecimale
        '
        Me.txtdecimale.Location = New System.Drawing.Point(27, 70)
        Me.txtdecimale.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txtdecimale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtdecimale.Name = "txtdecimale"
        Me.txtdecimale.Size = New System.Drawing.Size(101, 20)
        Me.txtdecimale.TabIndex = 0
        Me.txtdecimale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero decimale:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optesadecimale)
        Me.GroupBox2.Controls.Add(Me.optottale)
        Me.GroupBox2.Controls.Add(Me.optbinario)
        Me.GroupBox2.Location = New System.Drawing.Point(173, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Converti in"
        '
        'optesadecimale
        '
        Me.optesadecimale.AutoSize = True
        Me.optesadecimale.Location = New System.Drawing.Point(23, 93)
        Me.optesadecimale.Name = "optesadecimale"
        Me.optesadecimale.Size = New System.Drawing.Size(85, 17)
        Me.optesadecimale.TabIndex = 3
        Me.optesadecimale.Text = "Esadecimale"
        Me.optesadecimale.UseVisualStyleBackColor = True
        '
        'optottale
        '
        Me.optottale.AutoSize = True
        Me.optottale.Location = New System.Drawing.Point(23, 61)
        Me.optottale.Name = "optottale"
        Me.optottale.Size = New System.Drawing.Size(53, 17)
        Me.optottale.TabIndex = 2
        Me.optottale.Text = "Ottale"
        Me.optottale.UseVisualStyleBackColor = True
        '
        'optbinario
        '
        Me.optbinario.AutoSize = True
        Me.optbinario.Checked = True
        Me.optbinario.Location = New System.Drawing.Point(23, 30)
        Me.optbinario.Name = "optbinario"
        Me.optbinario.Size = New System.Drawing.Size(57, 17)
        Me.optbinario.TabIndex = 1
        Me.optbinario.TabStop = True
        Me.optbinario.Text = "Binario"
        Me.optbinario.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtrisultato)
        Me.GroupBox3.Location = New System.Drawing.Point(337, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 126)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Risultato conversione"
        '
        'txtrisultato
        '
        Me.txtrisultato.Location = New System.Drawing.Point(28, 58)
        Me.txtrisultato.Name = "txtrisultato"
        Me.txtrisultato.ReadOnly = True
        Me.txtrisultato.Size = New System.Drawing.Size(159, 20)
        Me.txtrisultato.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 163)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Conversione numeri"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtdecimale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdecimale As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optesadecimale As System.Windows.Forms.RadioButton
    Friend WithEvents optottale As System.Windows.Forms.RadioButton
    Friend WithEvents optbinario As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtrisultato As System.Windows.Forms.TextBox

End Class
