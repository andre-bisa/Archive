Public Class Form1

    Dim messaggio As Boolean = 1
    Dim x As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 + 55
    Dim y As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Bottom() / 2 + 32

    Private Sub Form1_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        If (messaggio) Then
            MsgBox("La prossima volta ci doveva pensare prima di commettere reati!", MsgBoxStyle.OkOnly)
            messaggio = 0
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.F4 Then
            e.Handled = True 'è stato gestito da me
            MsgBox("Va bene adesso mi chiudo... come vuoi", MsgBoxStyle.OkOnly)
            Environment.Exit(0) 'chiudi
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Bottom() / 2)
        Timer1.Start()
        'x = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width + 55
        'y = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Bottom() + 32
        MsgBox("Il tuo mouse è stato condannato al carcere!", MsgBoxStyle.OkOnly)
        Cursor.Position = New Point(x, y)
    End Sub

    Private Sub Form1_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        Cursor.Position = New Point(x, y)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Cursor.Position = New Point(x, y)
    End Sub
End Class
