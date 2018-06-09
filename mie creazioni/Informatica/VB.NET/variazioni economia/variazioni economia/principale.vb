Imports System
Imports System.IO
Imports System.Collections

Public Class Principale
    Dim righe_libro_giornale As Integer = 0 'numero di righe del libro giornale || usato per  inserire le celle
    Dim n_r As Integer = 1 'conteggio del n.r. del libro giornale
    Dim tot_dare = 0, tot_avere As Single = 0

    '///////////////////////////////////  INFO ARRAY "NOMI"  ///////////////////////////////////////
    '//                     nomi(x,y,z): tridimensionale                                          //
    '//                     -x= valori possibili: 0-1 0=economica 1=finanziaria                   //
    '//                     -y= valori possibili: 0-1 0=dare 1=avere                              //
    '//                     -z= valori possibili 0-1024 stringa contenente il testo del conto     //
    '///////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////  INFO ARRAY "VALORI"  /////////////////////////////////////
    '//                     valori(x,y,z,q): quadrimensionale                                     //
    '//                     -x= valori possibili: 0-1 0=economica 1=finanziaria                   //
    '//                     -y= valori possibili: 0-1 0=dare 1=avere                              //
    '//                     -z= valori possibili 0-1024 numeri corrispondenti ai conti di nomi    //
    '//                     -q= valori possibili 0-1024 elenco delle operazioni fatte ai conti    //
    '///////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////  VALORI SPECIALI NOMI E VALORI  ////////////////////////////////
    '//                     nomi(0,1,0) = "Utile" oppure "Perdita"                                //
    '//                     valori(0,0,0,0) = totale economica dare                               //
    '//                     valori(0,1,0,0) = totale economica avere                              //
    '//                     valori(1,0,0,0) = totale finanziaria dare                             //
    '//                     valori(1,1,0,0) = totale finanziaria avere                            //
    '//                     valori(0,1,0,1) = utile/perdita                                       //
    '///////////////////////////////////////////////////////////////////////////////////////////////

    Dim nomi(2, 2, 1024) As String
    Dim valori(2, 2, 1024, 1024) As Single

    Dim eco_fina As Integer = 0 '0=economica 1=finanziaria
    Dim errore_elimina_riga As Integer = 0

    Sub carica_da_file(sfile As String)
        'se il file non esiste:
        If Not File.Exists(sfile) Then
            Dim objfile2 As New StreamWriter(sfile)
            objfile2.Write("")
            objfile2.Close()
            btnaggiungi_voci.PerformClick()
            aggiungi_voci.ControlBox = False
            Exit Sub
        End If
        'se il file esiste
        Dim objfile As New StreamReader(sfile)
        Dim riga As String = ""
        Dim arr_testo As New ArrayList()
        Do
            riga = objfile.ReadLine()
            If Not riga Is Nothing Then
                arr_testo.Add(riga)
            End If
        Loop Until riga Is Nothing
        objfile.Close()
        combovoce.Enabled = 1
        combovoce.Items.Clear()
        Dim i As Integer = 0
        For Each riga In arr_testo
            combovoce.Items.Add(arr_testo(i))
            i += 1
        Next
        combovoce.SelectedIndex = 0
    End Sub

    Function posizione_libera(e_f As Integer, d_a As Integer, numeri As Single)
        For p As Integer = 1 To 1024 Step 1
            If (valori(e_f, d_a, numeri, p) = 0) Then Return p
        Next
        Return 0
    End Function

    Sub linea(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer, intensita As Integer)
        Dim pen As New Pen(Color.Black, intensita)
        Me.CreateGraphics.DrawLine(pen, x1, y1, x2, y2)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        linea(0, 0, 0, 0, 1)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        combovariazione.SelectedIndex = 0
        combosegno.SelectedIndex = 0
        combotipo.SelectedIndex = 0
        nomi(0, 1, 0) = " "       'tengo un posto per utile/ perdita
        valori(0, 1, 0, 0) = 0    '"""""""""""""""""""""""""""""""""
    End Sub

    Private Sub combotipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combotipo.SelectedIndexChanged
        Select Case combotipo.SelectedItem
            Case "LIQUIDITA'"
                carica_da_file("liquidita.txt")
            Case "DEBITI"
                carica_da_file("debiti.txt")
            Case "CREDITI"
                carica_da_file("crediti.txt")
            Case "RICAVI"
                carica_da_file("ricavi.txt")
            Case "COSTI"
                carica_da_file("costi.txt")
            Case "CAPITALE PROPRIO"
                carica_da_file("capitale_proprio.txt")
            Case Else
                carica_da_file("errore.txt")
        End Select
    End Sub

    Private Sub btninserischi_Click(sender As System.Object, e As System.EventArgs) Handles btninserisci.Click
        Dim data As String = String.Empty
        Dim voce As String = String.Empty
        data = txtdata.Text
        voce = combovoce.SelectedItem

        Dim segno As String = combosegno.SelectedItem
        Dim tipo As String = combotipo.SelectedItem
        'Dim dare_avere As Boolean = 0 'falso=dare    vero=avere
        Dim dare_avere As Integer = 0

        If (txtvalore.Value <= 0) Then Exit Sub

        libro_giornale.Rows.Add()
        libro_giornale.Rows(righe_libro_giornale).Cells(0).Value = data  'data
        libro_giornale.Rows(righe_libro_giornale).Cells(1).Value = Convert.ToString(n_r)   'n.r. valore crescente
        libro_giornale.Rows(righe_libro_giornale).Cells(2).Value = ""    'codice non disponibile
        libro_giornale.Rows(righe_libro_giornale).Cells(3).Value = voce  'conto
        libro_giornale.Rows(righe_libro_giornale).Cells(4).Value = txtdescrizione.Text    'descrizione 
        libro_giornale.Rows(righe_libro_giornale).Cells(7).Value = "Cancella" 'scritta sul bottone per eliminare la riga
        libro_giornale.Rows(righe_libro_giornale).Cells(8).Value = eco_fina

        Select Case segno
            Case "+"
                If ((tipo = "CREDITI") Or (tipo = "LIQUIDITA'") Or (tipo = "COSTI")) Then dare_avere = 0
                If ((tipo = "DEBITI") Or (tipo = "CAPITALE PROPRIO") Or (tipo = "RICAVI")) Then dare_avere = 1
            Case "-"
                If ((tipo = "CREDITI") Or (tipo = "LIQUIDITA'")) Then dare_avere = 1
                If ((tipo = "DEBITI") Or (tipo = "CAPITALE PROPRIO")) Then dare_avere = 0
        End Select

        'inizio ciclo di aggiunta valori
        For p As Integer = 1 To 1024 Step 1
            Dim punto As Integer
            If (nomi(eco_fina, dare_avere, p) = voce) Then
                punto = posizione_libera(eco_fina, dare_avere, p) 'punto libero
                valori(eco_fina, dare_avere, p, punto) = txtvalore.Value
                valori(eco_fina, dare_avere, p, 0) += txtvalore.Value 'somma finale dei mastrini
                Exit For
            End If
            If (nomi(eco_fina, dare_avere, p) = String.Empty) Then
                nomi(eco_fina, dare_avere, p) = voce
                p -= 1 'perchè p aumenta di 1
                Continue For
            End If
        Next
        'fine ciclo di aggiunta valori

        If (eco_fina) Then 'finanziaria
            If (dare_avere) Then 'avere
                valori(1, 1, 0, 0) += txtvalore.Value
            Else 'dare
                valori(1, 0, 0, 0) += txtvalore.Value
            End If
        Else 'economica
            If (dare_avere) Then 'avere
                valori(0, 1, 0, 0) += txtvalore.Value
            Else 'dare
                valori(0, 0, 0, 0) += txtvalore.Value
            End If
        End If

        If (dare_avere) Then 'se è avere
            libro_giornale.Rows(righe_libro_giornale).Cells(5).Value = ""    'dare
            libro_giornale.Rows(righe_libro_giornale).Cells(6).Value = Format(txtvalore.Value, "#,###,###,##0.00") 'avere
            tot_avere += txtvalore.Value
        Else   ' se è dare
            libro_giornale.Rows(righe_libro_giornale).Cells(5).Value = Format(txtvalore.Value, "#,###,###,##0.00") 'dare
            libro_giornale.Rows(righe_libro_giornale).Cells(6).Value = ""    'avere
            tot_dare += txtvalore.Value
        End If

        If (tot_avere - tot_dare = 0) Then
            lblquadratura.Text = "Quadra"
            lblquadratura.ForeColor = Color.Green
        Else
            lblquadratura.Text = "Non quadra!"
            lblquadratura.ForeColor = Color.Red
        End If

        lbltotavere.Text = Format(tot_avere, "#,###,###,##0.00")
        lbltotdare.Text = Format(tot_dare, "#,###,###,##0.00")
        n_r += 1
        righe_libro_giornale += 1
    End Sub

    Private Sub btnvisualizza_finanziaria_Click(sender As System.Object, e As System.EventArgs) Handles btnvisualizza_finanziaria.Click
        situazione_finanziaria.Visible = 1
        Me.Enabled = 0

        'inserisci label con i valori per i mastrini
        Dim i As Integer
        Dim x_voce_dare, y_voce_dare, x_valore_dare, y_valore_dare As Integer
        Dim x_voce_avere, y_voce_avere, x_valore_avere, y_valore_avere As Integer
        x_voce_dare = 5
        y_voce_dare = 80
        x_valore_dare = 150
        y_valore_dare = 80

        x_voce_avere = 205
        y_voce_avere = 80
        x_valore_avere = 350
        y_valore_avere = 80

        '//////////////////////////////////  DARE  ///////////////////////////////////
        'inserisci voce e valore
        For i = 1 To 1024
            'voce
            If (nomi(1, 0, i) = String.Empty) Then Exit For
            Dim lbl As New Label()
            lbl.Name = "lbltitolodare" & Convert.ToSingle(i)
            lbl.Text = nomi(1, 0, i)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Location = New Point(x_voce_dare, y_voce_dare)
            lbl.AutoSize = 0
            lbl.Width = 110
            lbl.Height = 23
            lbl.Visible = 1
            situazione_finanziaria.Controls.Add(lbl)
            y_voce_dare += 23
            situazione_finanziaria.y_riga += 23

            'valore
            Dim lbl2 As New Label()
            lbl2.Name = "lblvaloredare" & Convert.ToString(i)
            lbl2.Text = Format(valori(1, 0, i, 0), "#,###,###,##0.00")
            lbl2.Location = New Point(x_valore_dare, y_valore_dare)
            lbl2.AutoSize = 0
            lbl2.TextAlign = ContentAlignment.MiddleCenter
            lbl2.Width = 49
            lbl2.Height = 23
            lbl2.Visible = 1
            situazione_finanziaria.Controls.Add(lbl2)
            y_valore_dare += 23

        Next

        '///////////////////////////  AVERE  /////////////////////////////////

        '// inizio utile perdita //
        valori(0, 1, 0, 1) = valori(0, 1, 0, 0) - valori(0, 0, 0, 0)
        'valori(1,1,0,0) è uguale all'ultile/perdita

        If (valori(0, 1, 0, 1) < 0) Then
            nomi(0, 1, 0) = "Perdita"
            valori(0, 1, 0, 1) *= -1  'se è negativa (quindi perdita) il valore lo rimetto positivo
        Else
            nomi(0, 1, 0) = "Utile"
        End If
        '// fine utile perdita //

        '////////////////////////////////////////////////////////////////
        'voce
        Dim lb As New Label()
        lb.Name = "lbltitoloavere" & Convert.ToSingle(i)
        lb.Text = nomi(0, 1, 0)
        lb.TextAlign = ContentAlignment.MiddleCenter
        lb.Location = New Point(x_voce_avere, y_voce_avere)
        lb.AutoSize = 0
        lb.Width = 110
        lb.Height = 23
        lb.Visible = 1
        situazione_finanziaria.Controls.Add(lb)
        y_voce_avere += 23
        situazione_finanziaria.y_riga += 23

        'valore
        Dim lbl4 As New Label()
        lbl4.Name = "lblvaloreavere" & Convert.ToString(i)
        lbl4.Text = Format(valori(0, 1, 0, 1), "#,###,###,##0.00")
        lbl4.Location = New Point(x_valore_avere, y_valore_avere)
        lbl4.AutoSize = 0
        lbl4.TextAlign = ContentAlignment.MiddleCenter
        lbl4.Width = 49
        lbl4.Height = 23
        lbl4.Visible = 1
        situazione_finanziaria.Controls.Add(lbl4)
        y_valore_avere += 23
        '///////////////////////////////////////////////////////////////

        'inserisci voce e valore
        For i = 1 To 1024
            'voce
            If (nomi(1, 1, i) = String.Empty) Then Exit For
            Dim lbl3 As New Label()
            lbl3.Name = "lbltitoloavere" & Convert.ToSingle(i)
            lbl3.Text = nomi(1, 1, i)
            lbl3.TextAlign = ContentAlignment.MiddleCenter
            lbl3.Location = New Point(x_voce_avere, y_voce_avere)
            lbl3.AutoSize = 0
            lbl3.Width = 110
            lbl3.Height = 23
            lbl3.Visible = 1
            situazione_finanziaria.Controls.Add(lbl3)
            y_voce_avere += 23
            situazione_finanziaria.y_riga += 23

            'valore
            Dim l As New Label()
            l.Name = "lblvaloreavere" & Convert.ToString(i)
            l.Text = Format(valori(1, 1, i, 0), "#,###,###,##0.00")
            l.Location = New Point(x_valore_avere, y_valore_avere)
            l.AutoSize = 0
            l.TextAlign = ContentAlignment.MiddleCenter
            l.Width = 49
            l.Height = 23
            l.Visible = 1
            situazione_finanziaria.Controls.Add(l)
            y_valore_avere += 23
        Next

        'creazione della riga di fine con sotto i totali
        situazione_finanziaria.tmrriga_finale.Start() 'fa la riga finale
        If (y_valore_dare > y_valore_avere) Then
            situazione_finanziaria.y1_finale = y_valore_dare + 50
        Else
            situazione_finanziaria.y1_finale = y_valore_avere + 50
        End If

        situazione_finanziaria.x1_finale = 10
        situazione_finanziaria.x2_finale = 410
        situazione_finanziaria.y2_finale = situazione_finanziaria.y1_finale


        'scrittura dei totali

        'dare finale
        Dim lbltotdarefina As New Label()
        lbltotdarefina.Name = "lbltotdarefina"
        lbltotdarefina.Text = Format(valori(1, 0, 0, 0), "#,###,###,##0.00")
        lbltotdarefina.AutoSize = 1
        lbltotdarefina.Visible = 1
        lbltotdarefina.ForeColor = Color.Red
        lbltotdarefina.Font = New Font(lbltotdarefina.Font, FontStyle.Bold)
        lbltotdarefina.Location = New Point(situazione_finanziaria.x1_finale + 100, situazione_finanziaria.y1_finale + 10)
        situazione_finanziaria.Controls.Add(lbltotdarefina)

        'avere finale
        Dim lbltotaverefina As New Label()
        lbltotaverefina.Name = "lbltotaverefina"
        lbltotaverefina.Text = Format(valori(1, 1, 0, 0) + valori(0, 1, 0, 0) - valori(0, 0, 0, 0), "#,###,###,##0.00")
        lbltotaverefina.AutoSize = 1
        lbltotaverefina.Visible = 1
        lbltotaverefina.ForeColor = Color.Red
        lbltotaverefina.Font = New Font(lbltotaverefina.Font, FontStyle.Bold)
        lbltotaverefina.Location = New Point(situazione_finanziaria.x2_finale - 50, situazione_finanziaria.y2_finale + 10)
        situazione_finanziaria.Controls.Add(lbltotaverefina)

    End Sub

    Private Sub combovariazione_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combovariazione.SelectedIndexChanged, combosegno.SelectedIndexChanged
        'LIQUIDITA'
        'DEBITI
        'CREDITI
        'RICAVI
        'COSTI
        'CAPITALE PROPRIO

        combotipo.Items.Clear()

        Select Case combovariazione.SelectedItem

            Case "VFA"
                'se è +
                If (combosegno.SelectedItem = "+") Then
                    combotipo.Items.Add("LIQUIDITA'")
                    combotipo.Items.Add("CREDITI")
                Else ' se è -
                    combotipo.Items.Add("DEBITI")
                End If
                eco_fina = 1 '=finanziaria

            Case "VFP"
                'se è +
                If (combosegno.SelectedItem = "+") Then
                    combotipo.Items.Add("DEBITI")
                Else ' se è -
                    combotipo.Items.Add("LIQUIDITA'")
                    combotipo.Items.Add("CREDITI")
                End If
                eco_fina = 1 '=finanziaria

            Case "VEP"
                If (combosegno.SelectedItem = "+") Then
                    combotipo.Items.Add("RICAVI")
                    combotipo.Items.Add("CAPITALE PROPRIO")
                Else ' se è -
                    combotipo.Items.Add("COSTI")
                End If
                eco_fina = 0 '=economica

            Case "VEN"
                If (combosegno.SelectedItem = "+") Then
                    combotipo.Items.Add("COSTI")
                Else ' se è -
                    combotipo.Items.Add("RICAVI")
                    combotipo.Items.Add("CAPITALE PROPRIO")
                End If
                eco_fina = 0 '=economica

        End Select

        combotipo.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnvisualizza_economia.Click
        situazione_economica.Visible = 1
        Me.Enabled = 0

        'inserisci label con i valori per i mastrini
        Dim i As Integer
        Dim x_voce_dare, y_voce_dare, x_valore_dare, y_valore_dare As Integer
        Dim x_voce_avere, y_voce_avere, x_valore_avere, y_valore_avere As Integer
        x_voce_dare = 5
        y_voce_dare = 80
        x_valore_dare = 150
        y_valore_dare = 80

        x_voce_avere = 205
        y_voce_avere = 80
        x_valore_avere = 350
        y_valore_avere = 80


        '//////////////////////////////////  DARE  ///////////////////////////////////
        'inserisci voce e valore
        For i = 1 To 1024
            'voce
            If (nomi(0, 0, i) = String.Empty) Then Exit For
            Dim lbl As New Label()
            lbl.Name = "lbltitolodare" & Convert.ToSingle(i)
            lbl.Text = nomi(0, 0, i)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Location = New Point(x_voce_dare, y_voce_dare)
            lbl.AutoSize = 0
            lbl.Width = 110
            lbl.Height = 23
            lbl.Visible = 1
            situazione_economica.Controls.Add(lbl)
            y_voce_dare += 23
            situazione_economica.y_riga += 23

            'valore
            Dim lbl2 As New Label()
            lbl2.Name = "lblvaloredare" & Convert.ToString(i)
            lbl2.Text = Format(valori(0, 0, i, 0), "#,###,###,##0.00")
            lbl2.Location = New Point(x_valore_dare, y_valore_dare)
            lbl2.AutoSize = 0
            lbl2.TextAlign = ContentAlignment.MiddleCenter
            lbl2.Width = 49
            lbl2.Height = 23
            lbl2.Visible = 1
            situazione_economica.Controls.Add(lbl2)
            y_valore_dare += 23

        Next

        '///////////////////////////  AVERE  /////////////////////////////////

        '// inizio utile-perdita //
        Dim utile_perdita As Single
        Dim str_utile_perdita As String
        utile_perdita = valori(0, 1, 0, 0) - valori(0, 0, 0, 0)
        If (utile_perdita < 0) Then
            str_utile_perdita = "Perdita"
        Else
            str_utile_perdita = "Utile"
        End If
        '// fine utile-perdita //

        'inserisci voce e valore
        For i = 1 To 1024
            'voce
            If (nomi(0, 1, i) = String.Empty) Then Exit For
            Dim lbl3 As New Label()
            lbl3.Name = "lbltitoloavere" & Convert.ToSingle(i)
            lbl3.Text = nomi(0, 1, i)
            lbl3.TextAlign = ContentAlignment.MiddleCenter
            lbl3.Location = New Point(x_voce_avere, y_voce_avere)
            lbl3.AutoSize = 0
            lbl3.Width = 110
            lbl3.Height = 23
            lbl3.Visible = 1
            situazione_economica.Controls.Add(lbl3)
            y_voce_avere += 23
            situazione_economica.y_riga += 23

            'valore
            Dim lbl4 As New Label()
            lbl4.Name = "lblvaloreavere" & Convert.ToString(i)
            lbl4.Text = Format(valori(0, 1, i, 0), "#,###,###,##0.00")
            lbl4.Location = New Point(x_valore_avere, y_valore_avere)
            lbl4.AutoSize = 0
            lbl4.TextAlign = ContentAlignment.MiddleCenter
            lbl4.Width = 49
            lbl4.Height = 23
            lbl4.Visible = 1
            situazione_economica.Controls.Add(lbl4)
            y_valore_avere += 23
        Next

        'creazione della riga di fine con sotto i totali
        situazione_economica.tmrriga_finale.Start() 'fa la riga finale
        If (y_valore_dare > y_valore_avere) Then
            situazione_economica.y1_finale = y_valore_dare + 50
        Else
            situazione_economica.y1_finale = y_valore_avere + 50
        End If

        situazione_economica.x1_finale = 10
        situazione_economica.x2_finale = 410
        situazione_economica.y2_finale = situazione_economica.y1_finale


        'scrittura dei totali

        'dare finale
        Dim lbltotdare As New Label()
        lbltotdare.Name = "lbltotdarefina"
        lbltotdare.Text = Format(valori(0, 0, 0, 0), "#,###,###,##0.00")
        lbltotdare.AutoSize = 1
        lbltotdare.Visible = 1
        lbltotdare.ForeColor = Color.Red
        lbltotdare.Font = New Font(lbltotdare.Font, FontStyle.Bold)
        lbltotdare.Location = New Point(situazione_economica.x1_finale + 100, situazione_economica.y1_finale + 10)
        situazione_economica.Controls.Add(lbltotdare)

        'avere finale
        Dim lbltotavere As New Label()
        lbltotavere.Name = "lbltotaverefina"
        lbltotavere.Text = Format(valori(0, 1, 0, 0), "#,###,###,##0.00")
        lbltotavere.AutoSize = 1
        lbltotavere.Visible = 1
        lbltotavere.ForeColor = Color.Red
        lbltotavere.Font = New Font(lbltotavere.Font, FontStyle.Bold)
        lbltotavere.Location = New Point(situazione_economica.x2_finale - 50, situazione_economica.y2_finale + 10)
        situazione_economica.Controls.Add(lbltotavere)

    End Sub

    Private Sub btnaggiungi_voci_Click(sender As System.Object, e As System.EventArgs) Handles btnaggiungi_voci.Click
        aggiungi_voci.Visible = 1
        Me.Enabled = 0
    End Sub

    Private Sub libro_giornale_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles libro_giornale.CellContentClick
        If (e.ColumnIndex <> 7) Then Exit Sub 'esce se hai premuto qualcosa che non sia il pulsante
        If (e.RowIndex <> (righe_libro_giornale - 1)) Then 'puoi eliminare solo l'ultima riga
            If (errore_elimina_riga < 2) Then  'se il messaggio è stato visto 2 volte smetti di darlo
                MsgBox("Puoi eliminare solo l'ultima riga inserita", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Errore, riga troppo vecchia")
                errore_elimina_riga += 1
            End If
            Exit Sub
        End If

        eco_fina = libro_giornale.Rows(e.RowIndex).Cells(8).Value

        'stesso codice dell'aggiunta a riga ma modificato in negativo
        Dim voce As String = libro_giornale.Rows(e.RowIndex).Cells("CONTO").Value 'cells(3) è il conto quindi la voce
        Dim dare_avere As Integer = 0 'falso=dare    vero=avere

        'se nella casella dare c'è scritto qualcosa:
        If (libro_giornale.Rows(e.RowIndex).Cells("DARE").Value = String.Empty) Then
            dare_avere = 1
        Else
            dare_avere = 0
        End If

        Dim riga_da_eliminare As Integer = e.RowIndex

        'elimina valori dalla riga
        For p As Integer = 1 To 1024 Step 1
            If (nomi(eco_fina, dare_avere, p) = voce) Then
                ' togliamo entrambi tanto una è vuota quindi 0
                ' l'altra è il valore
                Dim punto = posizione_libera(eco_fina, dare_avere, p)

                If (dare_avere) Then 'avere
                    valori(eco_fina, dare_avere, p, punto) -= libro_giornale.Rows(e.RowIndex).Cells("AVERE").Value
                    valori(eco_fina, dare_avere, p, 0) -= libro_giornale.Rows(e.RowIndex).Cells("AVERE").Value
                    Exit For
                Else 'dare
                    valori(eco_fina, dare_avere, p, punto) -= libro_giornale.Rows(e.RowIndex).Cells("DARE").Value
                    valori(eco_fina, dare_avere, p, 0) -= libro_giornale.Rows(e.RowIndex).Cells("DARE").Value
                    Exit For
                End If
            End If
        Next

        If (eco_fina) Then 'finanziaria
            If (dare_avere) Then 'avere
                valori(1, 1, 0, 0) -= libro_giornale.Rows(e.RowIndex).Cells("AVERE").Value
                tot_avere -= libro_giornale.Rows(e.RowIndex).Cells("AVERE").Value
            Else 'dare
                valori(1, 0, 0, 0) -= libro_giornale.Rows(e.RowIndex).Cells("DARE").Value
                tot_dare -= libro_giornale.Rows(e.RowIndex).Cells("DARE").Value
            End If
        Else 'economica
            If (dare_avere) Then 'avere
                valori(0, 1, 0, 0) -= libro_giornale.Rows(e.RowIndex).Cells("AVERE").Value
                tot_avere -= libro_giornale.Rows(e.RowIndex).Cells("AVERE").Value
            Else 'dare
                valori(0, 0, 0, 0) -= libro_giornale.Rows(e.RowIndex).Cells("DARE").Value
                tot_dare -= libro_giornale.Rows(e.RowIndex).Cells("DARE").Value
            End If
        End If

        If (tot_avere - tot_dare = 0) Then
            lblquadratura.Text = "Quadra"
            lblquadratura.ForeColor = Color.Green
        Else
            lblquadratura.Text = "Non quadra!"
            lblquadratura.ForeColor = Color.Red
        End If

        lbltotavere.Text = Format(tot_avere, "#,###,###,##0.00")
        lbltotdare.Text = Format(tot_dare, "#,###,###,##0.00")
        n_r -= 1
        righe_libro_giornale -= 1
        'fine codice copiato

        libro_giornale.Rows.RemoveAt(riga_da_eliminare)
    End Sub
End Class
