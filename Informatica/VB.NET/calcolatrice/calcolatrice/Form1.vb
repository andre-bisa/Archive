Imports System.Math

Public Class Form1

    Const C_PUNTO = 190
    Const C_VIRGOLA = 188
    Const C_PIU = 187
    Const C_MENO = 189
    Const C_PER = 0
    Const C_DIVISO = 0

    Dim primo As Double
    Dim secondo As Double
    Dim numero As Double
    Dim numero_str As String
    Dim memoria As Double
    Dim p_s As Boolean = 1 'se vera mette in primo altrimenti mette in secondo
    Dim segno As Char = ""
    Dim virgola As Boolean = 0 'se scrivere la virgola
    Dim virgola2 As Boolean = 0 'se lo scrivere della vergola è già stato usato nello stesso numero

    Sub numero_str_f()
        If Not IsNumeric(numero_str) Then
            numero_str = "0"
        End If
        numero_str = CDbl(numero)
        txtnumero.Text = numero_str
    End Sub

    Sub inserisci_numero(cha As String)
        If (virgola) Then
            numero_str = txtnumero.Text + "," + cha
            txtnumero.Text = numero_str
            virgola = 0
        Else : numero_str = txtnumero.Text + cha
        End If

        If Not IsNumeric(numero_str) Then
            numero_str = cha
            virgola = 0
            virgola2 = 0
            segno = ""
        End If
        numero = CDbl(numero_str)
        numero_str = Convert.ToString(numero)
        txtnumero.Text = numero_str

    End Sub

    Private Sub btnindietro_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, btn0.KeyPress, btn1.KeyPress, btn2.KeyPress, btn3.KeyPress, btn4.KeyPress, btn5.KeyPress, btn6.KeyPress, btn7.KeyPress, btn8.KeyPress, btn9.KeyPress, btncancel.KeyPress, btnce.KeyPress, btndenominatore.KeyPress, btndiviso.KeyPress, btnindietro.KeyPress, btnmc.KeyPress, btnmeno.KeyPress, btnmpiu.KeyPress, btnmr.KeyPress, btnms.KeyPress, btnper.KeyPress, btnpercento.KeyPress, btnpercento.KeyPress, btnpiu.KeyPress, btnpiumeno.KeyPress, btnradice.KeyPress, btnuguale.KeyPress, btnvirgola.KeyPress, txtnumero.KeyPress
        Select Case e.KeyChar
            Case "+"
                btnpiu.PerformClick()
            Case "-"
                btnmeno.PerformClick()
            Case "*"
                btnper.PerformClick()
            Case "/"
                btndiviso.PerformClick()
        End Select

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp, btn0.KeyUp, btn1.KeyUp, btn2.KeyUp, btn3.KeyUp, btn4.KeyUp, btn5.KeyUp, btn6.KeyUp, btn7.KeyUp, btn8.KeyUp, btn9.KeyUp, btncancel.KeyUp, btnce.KeyUp, btndenominatore.KeyUp, btndiviso.KeyUp, btnindietro.KeyUp, btnmc.KeyUp, btnmeno.KeyUp, btnmpiu.KeyUp, btnmr.KeyUp, btnms.KeyUp, btnper.KeyUp, btnpercento.KeyUp, btnpercento.KeyUp, btnpiu.KeyUp, btnpiumeno.KeyUp, btnradice.KeyUp, btnuguale.KeyUp, btnvirgola.KeyUp, txtnumero.KeyUp
        e.Handled = True
        If (e.KeyCode = Keys.D0 Or e.KeyCode = Keys.NumPad0) Then btn0.PerformClick()
        If (e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad1) Then btn1.PerformClick()
        If (e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad2) Then btn2.PerformClick()
        If (e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad3) Then btn3.PerformClick()
        If (e.KeyCode = Keys.D4 Or e.KeyCode = Keys.NumPad4) Then btn4.PerformClick()
        If (e.KeyCode = Keys.D5 Or e.KeyCode = Keys.NumPad5) Then btn5.PerformClick()
        If (e.KeyCode = Keys.D6 Or e.KeyCode = Keys.NumPad6) Then btn6.PerformClick()
        If (e.KeyCode = Keys.D7 Or e.KeyCode = Keys.NumPad7) Then btn7.PerformClick()
        If (e.KeyCode = Keys.D8 Or e.KeyCode = Keys.NumPad8) Then btn8.PerformClick()
        If (e.KeyCode = Keys.D9 Or e.KeyCode = Keys.NumPad9) Then btn9.PerformClick()
        If (e.KeyCode = Keys.Escape) Then Application.Exit()
        If (btnuguale.Focused = False And (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return)) Then btnuguale.PerformClick()
        If (e.KeyCode = Keys.Delete) Then btncancel.PerformClick()


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        primo = CDbl(txtnumero.Text)
        numero_str = txtnumero.Text
        memoria = 0
    End Sub

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click
        inserisci_numero("0")
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        inserisci_numero("1")
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        inserisci_numero("2")
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        inserisci_numero("3")
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        inserisci_numero("4")
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        inserisci_numero("5")
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        inserisci_numero("6")
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        inserisci_numero("7")
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        inserisci_numero("8")
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        inserisci_numero("9")
    End Sub

    Private Sub btnpiu_Click(sender As System.Object, e As System.EventArgs) Handles btnpiu.Click
        If (p_s) Then 'se è vera metti in primo
            virgola = 0
            virgola2 = 0
            primo = numero
            p_s = 0
            numero = 0
            numero_str_f()
        End If
        segno = "+"
    End Sub

    Private Sub btnuguale_Click(sender As System.Object, e As System.EventArgs) Handles btnuguale.Click
        If (p_s = 0) Then
            secondo = numero
            p_s = 1
            Select Case segno
                Case "+"
                    numero = primo + secondo
                Case "-"
                    numero = primo - secondo
                Case "*"
                    numero = primo * secondo
                Case "/"
                    Try
                        numero = primo / secondo
                    Catch numero As DivideByZeroException
                        MsgBox("Diviso per 0", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore calcolo")
                    End Try
            End Select
            numero_str = CDbl(numero)
            txtnumero.Text = numero_str
        Else
            primo = numero
            Select Case segno
                Case "+"
                    numero = primo + secondo
                Case "-"
                    numero = primo - secondo
                Case "*"
                    numero = primo * secondo
                Case "/"
                    Try
                        numero = primo / secondo
                    Catch numero As DivideByZeroException
                        Beep()
                        MsgBox("Diviso per 0", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Errore")
                    End Try
            End Select
            numero_str_f()
        End If
    End Sub

    Private Sub btnmeno_Click(sender As System.Object, e As System.EventArgs) Handles btnmeno.Click
        If (p_s) Then 'se è vera metti in primo
            virgola = 0
            virgola2 = 0
            primo = numero
            p_s = 0
            numero = 0
            numero_str_f()
        End If
        segno = "-"
    End Sub

    Private Sub btnper_Click(sender As System.Object, e As System.EventArgs) Handles btnper.Click
        If (p_s) Then 'se è vera metti in primo
            virgola = 0
            virgola2 = 0
            primo = numero
            p_s = 0
            numero = 0
            numero_str_f()
        End If
        segno = "*"
    End Sub

    Private Sub btndiviso_Click(sender As System.Object, e As System.EventArgs) Handles btndiviso.Click
        If (p_s) Then 'se è vera metti in primo
            virgola = 0
            virgola2 = 0
            primo = numero
            p_s = 0
            numero = 0
            numero_str_f()
        End If
        segno = "/"
    End Sub

    Private Sub btncancel_Click(sender As System.Object, e As System.EventArgs) Handles btncancel.Click
        p_s = 1
        virgola = 0
        virgola2 = 0
        primo = 0
        secondo = 0
        numero = 0
        numero_str_f()
        segno = ""
    End Sub

    Private Sub btnmpiu_Click(sender As System.Object, e As System.EventArgs) Handles btnmpiu.Click
        memoria += numero
        If (memoria <> 0) Then
            lblmemoria.Text = "M"
        Else : lblmemoria.Text = ""
        End If
    End Sub

    Private Sub btnms_Click(sender As System.Object, e As System.EventArgs) Handles btnms.Click
        memoria = numero
        If (memoria <> 0) Then
            lblmemoria.Text = "M"
        Else : lblmemoria.Text = ""
        End If
    End Sub

    Private Sub btnmr_Click(sender As System.Object, e As System.EventArgs) Handles btnmr.Click
        numero = memoria
        numero_str_f()
    End Sub

    Private Sub btnmc_Click(sender As System.Object, e As System.EventArgs) Handles btnmc.Click
        memoria = 0
        lblmemoria.Text = ""
    End Sub

    Private Sub btnce_Click(sender As System.Object, e As System.EventArgs) Handles btnce.Click
        If (p_s) Then p_s = 0
        numero = 0
        virgola = 0
        virgola2 = 0
        numero_str_f()
    End Sub

    Private Sub btnindietro_Click(sender As System.Object, e As System.EventArgs) Handles btnindietro.Click
        Dim str As String = ""
        If (numero_str.Length <= 1) Then
            str = "0"
        Else
            For i As Integer = 0 To numero_str.Length - 2 Step 1
                str = str + numero_str(i)
            Next
        End If
        numero = CDbl(str)
        numero_str_f()
    End Sub

    Private Sub btnpiumeno_Click(sender As System.Object, e As System.EventArgs) Handles btnpiumeno.Click
        numero *= -1
        numero_str_f()
    End Sub

    Private Sub btnvirgola_Click(sender As System.Object, e As System.EventArgs) Handles btnvirgola.Click
        If virgola2 = 0 Then
            virgola = 1
            virgola2 = 1
        End If
    End Sub

    Private Sub btnradice_Click(sender As System.Object, e As System.EventArgs) Handles btnradice.Click
        numero = Sqrt(numero)
        numero_str_f()
    End Sub

    Private Sub btnpercento_Click(sender As System.Object, e As System.EventArgs) Handles btnpercento.Click
        Select Case segno
            Case "+"
                numero = primo + (numero / primo) * primo
            Case "-"
                numero = primo - (numero / primo) * primo
            Case Else
                numero = primo
        End Select
        numero_str_f()
    End Sub

    Private Sub btndenominatore_Click(sender As System.Object, e As System.EventArgs) Handles btndenominatore.Click
        numero = 1 / numero
        numero_str_f()
    End Sub
End Class
