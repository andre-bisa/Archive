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
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btndata = New System.Windows.Forms.Button()
        Me.txtgiorni = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'calendario
        '
        Me.calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.calendario.Location = New System.Drawing.Point(181, 39)
        Me.calendario.MaxSelectionCount = 1
        Me.calendario.MinDate = New Date(2012, 12, 11, 0, 0, 0, 0)
        Me.calendario.Name = "calendario"
        Me.calendario.TabIndex = 0
        Me.calendario.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleziona una data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "verrà tra: (giorni)"
        '
        'btndata
        '
        Me.btndata.Location = New System.Drawing.Point(152, 4)
        Me.btndata.Name = "btndata"
        Me.btndata.Size = New System.Drawing.Size(34, 23)
        Me.btndata.TabIndex = 3
        Me.btndata.Text = "..."
        Me.btndata.UseVisualStyleBackColor = True
        '
        'txtgiorni
        '
        Me.txtgiorni.Location = New System.Drawing.Point(13, 74)
        Me.txtgiorni.Name = "txtgiorni"
        Me.txtgiorni.ReadOnly = True
        Me.txtgiorni.Size = New System.Drawing.Size(100, 20)
        Me.txtgiorni.TabIndex = 4
        Me.txtgiorni.Text = "0"
        Me.txtgiorni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 225)
        Me.Controls.Add(Me.txtgiorni)
        Me.Controls.Add(Me.btndata)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calendario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btndata As System.Windows.Forms.Button
    Friend WithEvents txtgiorni As System.Windows.Forms.TextBox

End Class
