Public Class Form1

    Function scomponi_data(data As String, tipo As Char)
        Dim giorno As String = ""
        Dim mese As String = ""
        Dim anno As String = ""
        Dim i As Integer = 0
        For Each c As Char In data
            i += 1
            If ((i = 3) Or (i = 6)) Then Continue For
            If (i > 10) Then Exit For
            If (i <= 2) Then
                giorno = giorno + c
            ElseIf (i <= 5) Then
                mese = mese + c
            Else : anno = anno + c
            End If
        Next
        Select Case tipo
            Case "g"
                Return giorno
            Case "m"
                Return mese
            Case "a"
                Return anno
            Case Else
                Return giorno
        End Select
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        calendario.SelectionStart = Now.ToShortDateString
        calendario.MinDate = Now.ToShortDateString
    End Sub

    Private Sub btndata_Click(sender As System.Object, e As System.EventArgs) Handles btndata.Click
        calendario.Visible = Not calendario.Visible
    End Sub

    Private Sub calendario_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles calendario.DateChanged
        Dim giorno_calendario As Integer
        Dim mese_calendario As Integer
        Dim anno_calendario As Integer
        giorno_calendario = scomponi_data(Convert.ToString(calendario.SelectionStart), "g")
        mese_calendario = scomponi_data(Convert.ToString(calendario.SelectionStart), "m")
        anno_calendario = scomponi_data(Convert.ToString(calendario.SelectionStart), "a")
        Dim giorno_attuale As Integer
        Dim mese_attuale As Integer
        Dim anno_attuale As Integer
        giorno_attuale = scomponi_data(Now.ToShortDateString, "g")
        mese_attuale = scomponi_data(Now.ToShortDateString, "m")
        anno_attuale = scomponi_data(Now.ToShortDateString, "a")
        'cosi' ottengo i giorno/mese/anno dal calendario e li metto nelle variabili

        'inizio del programma effettivo
        Dim contatore As Integer = 0
        Dim FEBBRAIO As Integer = 28 'dice quanti giorni ha febbraio per gli anni bisestili
        Do While True
            contatore += 1
            giorno_attuale += 1
            If (anno_attuale Mod 4 = 0 And (anno_attuale Mod 100 <> 0 Or anno_attuale Mod 400 = 0)) Then febbraio = 29 Else febbraio = 28
            If ((mese_attuale = 4) Or (mese_attuale = 6) Or (mese_attuale = 9) Or (mese_attuale = 11)) And (giorno_attuale > 30) Then
                'If ((mese_attuale = 4 Or 6 Or 9 Or 11) And (giorno_attuale > 30)) Then
                giorno_attuale = 1
                mese_attuale += 1
            ElseIf ((mese_attuale = 2) And (giorno_attuale > 29)) Then
                giorno_attuale = 1
                mese_attuale += 1
            ElseIf (giorno_attuale > 31) Then
                giorno_attuale = 1
                mese_attuale += 1
            End If
            If (mese_attuale > 12) Then
                mese_attuale = 1
                anno_attuale += 1
            End If
            If ((giorno_attuale = giorno_calendario) And (mese_attuale = mese_calendario) And (anno_attuale = anno_calendario)) Then
                Exit Do
            End If
        Loop

        txtgiorni.Text = contatore

    End Sub

End Class
