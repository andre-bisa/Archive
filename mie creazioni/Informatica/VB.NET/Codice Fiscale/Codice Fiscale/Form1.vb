Public Class Form1
    Dim codice As String = String.Empty

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
        txtsesso.SelectedIndex = 0
        txtdata.MaxDate = Now.Day & "/" & Now.Month & "/" & Now.Year
        txtdata.Value = "01/01/2000"
    End Sub

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        If (txtcognome.Text = "") Or (txtcognome.Text.Length <= 1) Or (txtnome.Text = "") Or (txtnome.Text.Length <= 1) Or (txtluogo.Text = "") Or (txtcognome.Text.Length <= 1) Or (txtprovincia.Text = "") Or (txtprovincia.Text.Length <= 1) Then
            MsgBox("Errore, non tutti i campi sono riempiti!")
            Exit Sub
        End If

        txtcodice_fiscale.Text = ""
        codice = ""
        Dim nome, cognome, luogo, provincia, sesso As String
        Dim giorno, mese, anno As Integer

        nome = LCase(txtnome.Text)
        cognome = LCase(txtcognome.Text)
        luogo = LCase(txtluogo.Text)
        provincia = LCase(txtprovincia.Text)
        sesso = LCase(txtsesso.SelectedText)
        giorno = scomponi_data(txtdata.Text, "g")
        mese = scomponi_data(txtdata.Text, "m")
        anno = scomponi_data(txtdata.Text, "a")

        Dim cognome_codice As Integer = 3

        For Each c As Char In cognome
            If (c = "a" Or c = "e" Or c = "i" Or c = "o" Or c = "u") Then Continue For
            If (c < "a" Or c > "z") Then Continue For
            codice = codice & c
            cognome_codice -= 1
            If (cognome_codice = 0) Then Exit For
        Next
        If (cognome_codice > 0) Then
            For Each c As Char In cognome
                If Not (c = "a" Or c = "e" Or c = "i" Or c = "o" Or c = "u") Then Continue For
                If (c < "a" Or c > "z") Then Continue For
                codice = codice & c
                cognome_codice -= 1
                If (cognome_codice = 0) Then Exit For
            Next
        End If
        If (cognome_codice > 0) Then
            codice = codice & "x"
        End If

        Dim nome_codice As Integer = 3

        For Each c As Char In nome
            If (c = "a" Or c = "e" Or c = "i" Or c = "o" Or c = "u") Then Continue For
            If (c < "a" Or c > "z") Then Continue For
            codice = codice & c
            nome_codice -= 1
            If (nome_codice = 0) Then Exit For
        Next
        If (nome_codice > 0) Then
            For Each c As Char In nome
                If Not (c = "a" Or c = "e" Or c = "i" Or c = "o" Or c = "u") Then Continue For
                If (c < "a" Or c > "z") Then Continue For
                codice = codice & c
                nome_codice -= 1
                If (nome_codice = 0) Then Exit For
            Next
        End If
        If (nome_codice > 0) Then
            codice = codice & "x"
        End If

        codice = codice & Mid(Convert.ToString(anno), 3, 2)



        Select Case mese
            Case 1
                codice = codice & "A"
            Case 2
                codice = codice & "B"
            Case 3
                codice = codice & "C"
            Case 4
                codice = codice & "D"
            Case 5
                codice = codice & "E"
            Case 6
                codice = codice & "H"
            Case 7
                codice = codice & "L"
            Case 8
                codice = codice & "M"
            Case 9
                codice = codice & "P"
            Case 10
                codice = codice & "R"
            Case 11
                codice = codice & "S"
            Case 12
                codice = codice & "T"
            Case Else
                MsgBox("ERRORE MESE")
        End Select

        If (txtsesso.SelectedIndex = 1) Then 'femmina
            giorno += 40
        End If
        codice = codice & Format(giorno, "00")

        If (luogo = "bologna") And (provincia = "bo") Then
            codice = codice & "A944"
        ElseIf (luogo = "pescara") And (provincia = "pe") Then
            codice = codice & "G482"
        ElseIf (luogo = "roma") And (provincia = "rm") Then
            codice = codice & "H501"
        Else
            codice = codice & "????"
        End If

        codice = UCase(codice) 'maiuscolo

        Dim somma_pari, somma_dispari, totale As Integer
        Dim i As Integer = 1


        For Each c As Char In codice
            If (i Mod 2 = 0) Then 'pari
                Select Case c
                    Case "0", "A"
                        somma_pari += 0
                    Case "1", "B"
                        somma_pari += 1
                    Case "2", "C"
                        somma_pari += 2
                    Case "3", "D"
                        somma_pari += 3
                    Case "4", "E"
                        somma_pari += 4
                    Case "5", "F"
                        somma_pari += 5
                    Case "6", "G"
                        somma_pari += 6
                    Case "7", "H"
                        somma_pari += 7
                    Case "8", "I"
                        somma_pari += 8
                    Case "9", "J"
                        somma_pari += 9
                    Case "K"
                        somma_pari += 10
                    Case "L"
                        somma_pari += 11
                    Case "M"
                        somma_pari += 12
                    Case "N"
                        somma_pari += 13
                    Case "O"
                        somma_pari += 14
                    Case "P"
                        somma_pari += 15
                    Case "Q"
                        somma_pari += 16
                    Case "R"
                        somma_pari += 17
                    Case "S"
                        somma_pari += 18
                    Case "T"
                        somma_pari += 19
                    Case "U"
                        somma_pari += 20
                    Case "V"
                        somma_pari += 21
                    Case "W"
                        somma_pari += 22
                    Case "X"
                        somma_pari += 23
                    Case "Y"
                        somma_pari += 24
                    Case "Z"
                        somma_pari += 25
                End Select

            Else 'dispari

                Select Case c
                    Case "0", "A"
                        somma_dispari += 1
                    Case "1", "B"
                        somma_dispari += 0
                    Case "2", "C"
                        somma_dispari += 5
                    Case "3", "D"
                        somma_dispari += 7
                    Case "4", "E"
                        somma_dispari += 9
                    Case "5", "F"
                        somma_dispari += 13
                    Case "6", "G"
                        somma_dispari += 15
                    Case "7", "H"
                        somma_dispari += 17
                    Case "8", "I"
                        somma_dispari += 19
                    Case "9", "J"
                        somma_dispari += 21
                    Case "K"
                        somma_dispari += 2
                    Case "L"
                        somma_dispari += 4
                    Case "M"
                        somma_dispari += 18
                    Case "N"
                        somma_dispari += 20
                    Case "O"
                        somma_dispari += 11
                    Case "P"
                        somma_dispari += 3
                    Case "Q"
                        somma_dispari += 6
                    Case "R"
                        somma_dispari += 8
                    Case "S"
                        somma_dispari += 12
                    Case "T"
                        somma_dispari += 14
                    Case "U"
                        somma_dispari += 16
                    Case "V"
                        somma_dispari += 10
                    Case "W"
                        somma_dispari += 22
                    Case "X"
                        somma_dispari += 25
                    Case "Y"
                        somma_dispari += 24
                    Case "Z"
                        somma_dispari += 23
                End Select
            End If
            i += 1
        Next

        totale = somma_dispari + somma_pari

        Select Case totale Mod 26
            Case 0
                codice = codice & "A"
            Case 1
                codice = codice & "B"
            Case 2
                codice = codice & "C"
            Case 3
                codice = codice & "D"
            Case 4
                codice = codice & "E"
            Case 5
                codice = codice & "F"
            Case 6
                codice = codice & "G"
            Case 7
                codice = codice & "H"
            Case 8
                codice = codice & "I"
            Case 9
                codice = codice & "J"
            Case 10
                codice = codice & "K"
            Case 11
                codice = codice & "L"
            Case 12
                codice = codice & "M"
            Case 13
                codice = codice & "N"
            Case 14
                codice = codice & "O"
            Case 15
                codice = codice & "P"
            Case 16
                codice = codice & "Q"
            Case 17
                codice = codice & "R"
            Case 18
                codice = codice & "S"
            Case 19
                codice = codice & "T"
            Case 20
                codice = codice & "U"
            Case 21
                codice = codice & "V"
            Case 22
                codice = codice & "W"
            Case 23
                codice = codice & "X"
            Case 24
                codice = codice & "Y"
            Case 25
                codice = codice & "Z"
        End Select

        txtcodice_fiscale.Text = codice

    End Sub

    Private Sub txtcognome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcognome.GotFocus
        txtcognome.SelectAll()
    End Sub

    Private Sub txtnome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnome.GotFocus
        txtnome.SelectAll()
    End Sub

    Private Sub txtluogo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtluogo.GotFocus
        txtluogo.SelectAll()
    End Sub

    Private Sub txtprovincia_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtprovincia.GotFocus
        txtprovincia.SelectAll()
    End Sub

    Private Sub txtcodice_fiscale_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcodice_fiscale.GotFocus
        txtcodice_fiscale.SelectAll()
    End Sub

    Private Sub btncopia_Click(sender As System.Object, e As System.EventArgs) Handles btncopia.Click
        If (txtcodice_fiscale.Text = "") Then Exit Sub
        Clipboard.SetText(txtcodice_fiscale.Text)
        MsgBox("""" & txtcodice_fiscale.Text & """ copiato con successo", MsgBoxStyle.Information)
    End Sub

    Private Sub btncancella_Click(sender As System.Object, e As System.EventArgs) Handles btncancella.Click
        txtcodice_fiscale.Text = ""
    End Sub
End Class
