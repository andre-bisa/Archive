Imports System.Math

Public Class Form1

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        Dim mq, tot, tariffa As Single
        Dim abitanti As UInteger

        'controllo metri quadrati
        'IMPOSSIBILE MA PER SICUREZZA
        If Not IsNumeric(txtmq.Text) Then
            MsgBox("I metri quadrati devono essere numerici", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxSetForeground, "Errore inserimento dati")
            txtmq.Focus()
            Exit Sub
        End If

        'controllo numero abitanti
        'IMPOSSIBILE MA PER SICUREZZA
        If Not IsNumeric(txtabitanti.Text) Then
            MsgBox("I metri quadrati devono essere numerici", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxSetForeground, "Errore inserimento dati")
            txtabitanti.Focus()
            Exit Sub
        End If

        'controllo se abitanti minore di 0
        'IMPOSSIBILE <0 MA PER SICUREZZA
        If ((Convert.ToSingle(Int(txtabitanti.Text)) <= 0) And (optdomestica.Checked)) Then
            If (Convert.ToSingle(Int(txtabitanti.Text))) = 0 Then
                MsgBox("Errore, gli abitanti sono uguali a 0", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxSetForeground, "Errore inserimento dati")
            Else : MsgBox("Errore, gli abitanti sono minori di 0", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxSetForeground, "Errore inserimento dati")
            End If
            txtabitanti.Focus()
            Exit Sub
        End If

        mq = Convert.ToSingle(txtmq.Text)
        abitanti = Convert.ToSingle(Int(txtabitanti.Text))
        tariffa = Convert.ToSingle(lbltariffa.Text)
        tot = tariffa * mq * 1.1 * 1.05

        If ((abitanti = 1) And (optdomestica.Checked)) Then
            tot = Round(tot * 0.7, 2)
        End If

        lbltot.Text = FormatNumber(tot, 2)

    End Sub

    Private Sub optdomestica_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optdomestica.CheckedChanged, optnodomestica.CheckedChanged
        If (optdomestica.Checked) Then
            'domestica attivo
            optclasse1.Enabled = False
            optclasse2.Enabled = False
            optclasse3.Enabled = False
            optclasse4.Enabled = False
            optclasse5.Enabled = False
            optclasse6.Enabled = False
            optclasse7.Enabled = False
            optclasse8.Enabled = False
            optclasse9.Enabled = False
            optclasse10.Enabled = False
            optclasse11.Enabled = False
            optclasse12.Enabled = False
            optclasse13.Enabled = False
            optclasse14.Enabled = False
            optclasse15.Enabled = False
            optclasse16.Enabled = False
            optclasse17.Enabled = False
            optclasse18.Enabled = False
            optclasse19.Enabled = False
            optclasse20.Enabled = False
            optclasse21.Enabled = False
            optclasse22.Enabled = False
            'toglie selezionati seconda colonna
            optclasse1.Checked = True
            optclasse1.Checked = False
            'disattiva abitanti
            txtabitanti.Enabled = True
            'imposta tariffa
            lbltariffa.Text = "2,36"
            'imposta descrizione
            txtdescrizione.Text = "Prezzo metri quadrati l'anno per un abitante a Bologna"
        Else
            'se attivo non domestica
            optclasse1.Enabled = True
            optclasse2.Enabled = True
            optclasse3.Enabled = True
            optclasse4.Enabled = True
            optclasse5.Enabled = True
            optclasse6.Enabled = True
            optclasse7.Enabled = True
            optclasse8.Enabled = True
            optclasse9.Enabled = True
            optclasse10.Enabled = True
            optclasse11.Enabled = True
            optclasse12.Enabled = True
            optclasse13.Enabled = True
            optclasse14.Enabled = True
            optclasse15.Enabled = True
            optclasse16.Enabled = True
            optclasse17.Enabled = True
            optclasse18.Enabled = True
            optclasse19.Enabled = True
            optclasse20.Enabled = True
            optclasse21.Enabled = True
            optclasse22.Enabled = True
            'seleziona classe1
            optclasse1.Checked = True
            'attiva abitanti
            txtabitanti.Enabled = False
        End If
    End Sub

    Private Sub opt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optclasse1.CheckedChanged, optclasse2.CheckedChanged, optclasse3.CheckedChanged, optclasse4.CheckedChanged, optclasse5.CheckedChanged, optclasse6.CheckedChanged, optclasse7.CheckedChanged, optclasse8.CheckedChanged, optclasse9.CheckedChanged, optclasse10.CheckedChanged, optclasse11.CheckedChanged, _
        optclasse12.CheckedChanged, optclasse13.CheckedChanged, optclasse14.CheckedChanged, optclasse15.CheckedChanged, optclasse16.CheckedChanged, optclasse17.CheckedChanged, optclasse18.CheckedChanged, optclasse19.CheckedChanged, optclasse20.CheckedChanged, optclasse21.CheckedChanged, optclasse22.CheckedChanged

        If (optclasse1.Checked) Then
            lbltariffa.Text = "2,54"
            txtdescrizione.Text = "Associazioni, Circoli e Istituzioni: Culturali, Politiche, Sindacali, Sportive, Religiose, Tecnico - Economiche Enti di Assistenza, Enti Pubb. non economici, Istituti Religiosi, Scuole, Biblioteche, Musei"
        ElseIf (optclasse2.Checked) Then
            lbltariffa.Text = "2,71"
            txtdescrizione.Text = "Cinematografi e teatri"
        ElseIf (optclasse3.Checked) Then
            lbltariffa.Text = "3,92"
            txtdescrizione.Text = "Stazioni, Autorimesse, Autoservizi, Autotrasport., Mag. Dep. non al servizio di attività industriali o commerciali e senza alcuna vendita diretta"
        ElseIf (optclasse4.Checked) Then
            lbltariffa.Text = "3,30"
            txtdescrizione.Text = "Distributori carburante, Aree di parcheggio, Aree di posteggio, Campeggi, Impianti sportivi e termali"
        ElseIf (optclasse5.Checked) Then
            lbltariffa.Text = "3,02"
            txtdescrizione.Text = "Esposizioni, Autosaloni"
        ElseIf (optclasse6.Checked) Then
            lbltariffa.Text = "5,46"
            txtdescrizione.Text = "Alberghi (senza ristorante), Pensioni, Locande, Affittacamere, Convitti, Collegi, Caserme, Carceri ed ogni altro tipo di convivenza"
        ElseIf (optclasse7.Checked) Then
            lbltariffa.Text = "7,50"
            txtdescrizione.Text = "Case di cura e riposo"
        ElseIf (optclasse8.Checked) Then
            lbltariffa.Text = "7,55"
            txtdescrizione.Text = "Ospedali"
        ElseIf (optclasse9.Checked) Then
            lbltariffa.Text = "6,36"
            txtdescrizione.Text = "Uffici commerciali, Studi professionali, Agenzie finanziarie, Agenzie di viaggi, Assicurazioni, Agenzie ippiche, Ricevitorie totip, Ambulatori, Poliambulatori, Laboratori analisi cliniche, Studi medici, Studi veterinari"
        ElseIf (optclasse10.Checked) Then
            lbltariffa.Text = "5,41"
            txtdescrizione.Text = "Banche ed Istituti di credito"
        ElseIf (optclasse11.Checked) Then
            lbltariffa.Text = "6,31"
            txtdescrizione.Text = "Esercizi commerciali di generi non alimentari"
        ElseIf (optclasse12.Checked) Then
            lbltariffa.Text = "7,60"
            txtdescrizione.Text = "Banchi di mercato di generi non alimentari (beni durevoli)"
        ElseIf (optclasse13.Checked) Then
            lbltariffa.Text = "5,55"
            txtdescrizione.Text = "Attività artigianali tipo botteghe: parrucchiera, barbiere, estetista"
        ElseIf (optclasse14.Checked) Then
            lbltariffa.Text = "4,31"
            txtdescrizione.Text = "Officine, Carrozzerie, Laboratori, Botteghe artigianali"
        ElseIf (optclasse15.Checked) Then
            lbltariffa.Text = "4,27"
            txtdescrizione.Text = "Attività industriali con capannoni di produzione"
        ElseIf (optclasse16.Checked) Then
            lbltariffa.Text = "13,63"
            txtdescrizione.Text = "Ristoranti (anche inseriti in strutture alberghiere), Trattorie, Pizzerie, Tavole calde, Osterie, Pub, Mense, Birrerie, Amburgherie"
        ElseIf (optclasse17.Checked) Then
            lbltariffa.Text = "13,30"
            txtdescrizione.Text = "Bar, Gelaterie, Pasticcerie"
        ElseIf (optclasse18.Checked) Then
            lbltariffa.Text = "10,29"
            txtdescrizione.Text = "Rosticcerie, Supermercati alimentari, Esercizi commerciali di generi alimentari (con esclusione di quelli previsti alla classe 19)"
        ElseIf (optclasse19.Checked) Then
            lbltariffa.Text = "15,12"
            txtdescrizione.Text = "Ortofrutta, Pescherie, Fiori e piante"
        ElseIf (optclasse20.Checked) Then
            lbltariffa.Text = "10,25"
            txtdescrizione.Text = "Ipermercati di generi misti"
        ElseIf (optclasse21.Checked) Then
            lbltariffa.Text = "12,84"
            txtdescrizione.Text = "Banchi di mercato generi alimentari"
        ElseIf (optclasse22.Checked) Then
            lbltariffa.Text = "7,90"
            txtdescrizione.Text = "Discoteche, Sale da ballo, Sale giochi"
        End If

    End Sub

    Private Sub txtdescrizione_GotFocus(sender As Object, e As System.EventArgs) Handles txtdescrizione.GotFocus
        txtmq.Focus()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtdescrizione.Text = "Prezzo metri quadrati l'anno per un abitante a Bologna"
        optdomestica.Checked = True
    End Sub
End Class
