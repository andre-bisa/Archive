<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtmax = New System.Windows.Forms.NumericUpDown()
        Me.btncambia = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.txtmax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(46, 10)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(117, 13)
        Label1.TabIndex = 0
        Label1.Text = "Nuovo valore massimo:"
        '
        'txtmax
        '
        Me.txtmax.Location = New System.Drawing.Point(43, 39)
        Me.txtmax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtmax.Name = "txtmax"
        Me.txtmax.Size = New System.Drawing.Size(120, 20)
        Me.txtmax.TabIndex = 0
        Me.txtmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtmax.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btncambia
        '
        Me.btncambia.Location = New System.Drawing.Point(67, 85)
        Me.btncambia.Name = "btncambia"
        Me.btncambia.Size = New System.Drawing.Size(75, 23)
        Me.btncambia.TabIndex = 2
        Me.btncambia.Text = "Cambia"
        Me.btncambia.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AcceptButton = Me.btncambia
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 133)
        Me.Controls.Add(Me.btncambia)
        Me.Controls.Add(Me.txtmax)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambia valore massimo"
        Me.TopMost = True
        CType(Me.txtmax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmax As System.Windows.Forms.NumericUpDown
    Friend WithEvents btncambia As System.Windows.Forms.Button
End Class
