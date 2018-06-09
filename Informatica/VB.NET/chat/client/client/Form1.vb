Imports System.Net.Sockets
Imports System.Text
Imports System.Net

Public Class Form1
    Const LARGHEZZA_MIN As Integer = 500
    Const LARGHEZZA_MAX As Integer = 770

    'caratteri fondamentali
    Dim caratteri_nick As String() = {" ", "$", "*", "[", "]", "{", "}", "/", "§", """"}

    'colori di partenza txtcronologia
    Dim colore_testo_normale As Color = Color.Black
    Dim stile_testo_normale As New Font("Microsoft Sans Serif", 9)

    'array per memorizzare ultimo messaggio mandato così 
    'da poterlo riscrivere premendo il tasto "su" e "giu"
    Dim ultimo_messaggio As New ArrayList()
    'variabile per il recupero degli ultimi messaggi
    'contenente la posizione che si sta guardando
    Dim posizionamento_ultimo_messaggio As Integer = 0

    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer
    Dim allarga_restringi As Boolean = 0
    Dim admin As Boolean = 0


    Declare Function Beep Lib "kernel32.dll" (ByVal dwFreq As Integer, ByVal dwDuration As Integer) As Boolean

    Private Sub btninvia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninvia.Click
        Dim messaggio As String = txttesto.Text
        If (messaggio = "") Then Exit Sub
        messaggio = messaggio.Trim()
        messaggio = messaggio.Replace("à", "a'")
        messaggio = messaggio.Replace("è", "e'")
        messaggio = messaggio.Replace("é", "e'")
        messaggio = messaggio.Replace("ì", "i'")
        messaggio = messaggio.Replace("ò", "o'")
        messaggio = messaggio.Replace("ù", "u'")
        Try
            Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(messaggio + "$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
            ultimo_messaggio.Add(messaggio)
            posizionamento_ultimo_messaggio = ultimo_messaggio.Count - 1
        Catch ex As Exception
            readData = "***** ERRORE INVIO MESSAGGIO *****"
            msg()
        End Try
        txttesto.Text = ""
    End Sub

    Private Sub msg()
        Dim comandi As Boolean = False
        'queste istruzioni permettono l'inserimento di un testo colorato
        'ora manca solo il modo per rilevare il colore mandato dal server
        '
        'richTextBox1.SelectionStart = richTextBox1.Text.Length
        'dim oldcolor as color = richTextBox1.SelectionColor
        'richTextBox1.SelectionColor = Color.Red
        'richTextBox1.AppendText(vbNewLine & " >> " & readData)
        'richTextBox1.SelectionColor = oldcolor

        'pensavo di ricevere il colore all'interno di <>
        'come i tag html così da trovare il nome del colore
        'Dim colore As Color = Color.FromName("red")
        'con questo trasformo una stringa in colore

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else

            Dim colore As Color = colore_testo_normale
            Dim stile As New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)

            If readData.Contains("$$$$$") Then
                'allora è un messaggio del server quindi importante
                'aumento la grandezza del testo, lo metto grassetto
                'e cambio il colore
                stile = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                colore = Color.Red
            End If

            If readData.Contains("*****") Then
                'allora è un messaggio privato quindi abbastanza importante
                'metto il testo grassetto
                stile = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
                colore = Color.OrangeRed
            End If

            If (readData.Contains("[LISTA_ONLINE_SVUOTA]")) Then
                readData = readData.Replace("$", "")
                lstonline.Items.Clear()
                comandi = 1
                readData = readData.Replace("[LISTA_ONLINE_SVUOTA]", "")
                readData = Trim(readData)
            End If

            If (readData.Contains("[LISTA_ONLINE_AGGIUNGI]")) Then
                readData = readData.Replace("$", "")
                readData = Trim(readData)
                Dim account() As String = Split(readData, "[LISTA_ONLINE_AGGIUNGI]")
                For j As Integer = 0 To account.Count - 1 Step 1
                    If (account(j) = String.Empty) Then Continue For
                    lstonline.Items.Add(Trim(account(j)))
                Next
                'Dim account As String = Replace(readData, "[LISTA_ONLINE_AGGIUNGI]", "")

                comandi = 1
                readData = readData.Replace("[LISTA_ONLINE_AGGIUNGI]", "")
            End If


        If comandi Then
            Exit Sub
        End If

        'inizio a selezionare in modo da modificare il colore
        txtcronologia.SelectionStart = txtcronologia.Text.Length
        'cambio il colore di selezione e il font
        txtcronologia.SelectionColor = colore
        txtcronologia.SelectionFont = stile
        'aggiungo il testo colorato in fondo al textbox
        txtcronologia.AppendText(vbNewLine & " >> " & readData)
        'reimposto il colore e il font
        txtcronologia.SelectionColor = colore_testo_normale
        txtcronologia.SelectionFont = stile_testo_normale


        'txtcronologia.Text = txtcronologia.Text & vbNewLine & " >> " & readData
        Beep(5000, 50)
        fondo_txtcronologia()
        End If
    End Sub

    Private Sub btnconnetti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconnetti.Click
        Dim ip_connessione As IPAddress = Dns.GetHostByName(txtip.Text).AddressList(0)

        Try
            'clientSocket.Connect(txtip.Text, 8888)
            clientSocket.Connect(ip_connessione, 8888)
            serverStream = clientSocket.GetStream()

            Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(txtnick.Text + "$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
            ctThread.Start()

            btnconnetti.Enabled = 0
            txtip.Enabled = 0
            txtnick.Enabled = 0
            btndisconnetti.Enabled = 1

            txttesto.Focus()
        Catch ex As Exception
            MsgBox("Impossibile connettersi a " & txtip.Text)
        End Try

    End Sub

    Private Sub attiva_controlli_admin()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf attiva_controlli_admin))
        Else
            admin = 1
            txtpassword.Enabled = 1
            btnautentica.Enabled = 1
            btncaccia.Enabled = 1
            btnchiudi_server.Enabled = 1
            btnbanna.Enabled = 1
            btndebanna.Enabled = 1
            btntrova_ip.Enabled = 1
            btnlista_online.Enabled = 1
            txtbannaip.Enabled = 1
            txtdebannaip.Enabled = 1
            txtcacciaip.Enabled = 1
        End If
    End Sub

    Private Sub disattiva_controlli_admin()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf disattiva_controlli_admin))
        Else
            admin = 0
            txtpassword.Enabled = 1
            btnautentica.Enabled = 1
            btncaccia.Enabled = 0
            btnchiudi_server.Enabled = 0
            btnbanna.Enabled = 0
            btndebanna.Enabled = 0
            btntrova_ip.Enabled = 0
            btnlista_online.Enabled = 0
            txtbannaip.Enabled = 0
            txtdebannaip.Enabled = 0
            txtcacciaip.Enabled = 0
        End If
    End Sub

    Private Sub comando(ByVal comando As String)
        Try
            comando = comando.Trim()
            Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(comando & "$")
            'Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes("/caccia " & lstonline.SelectedItem.ToString() & "$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
        Catch ex As Exception
            'in caso di errore non fare niente
        End Try
    End Sub

    Private Sub getMessage()
        While (True)
            Dim buffSize As Integer
            Dim inStream(10024) As Byte
            Try
                serverStream = clientSocket.GetStream()
                buffSize = clientSocket.ReceiveBufferSize
                serverStream.Read(inStream, 0, buffSize)

                'fa in modo che se ci sono errori nella ricezione non si blocchi il programma e si discolleghi forzatamente
            Catch ex As Exception
                'controlla di avere la facoltà di eseguire certe istruzioni cioè serve per far andare il performclick()
                If Me.InvokeRequired Then
                    Me.Invoke(New MethodInvoker(AddressOf getMessage))
                Else
                    readData = "***** ERRORE COLLEGAMENTO, DISCOLLEGAMENTO IN CORSO *****"
                    msg()
                    btndisconnetti.PerformClick()
                End If
                Exit While
            End Try

            Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)


            returndata = Replace(returndata, "a'", "à")
            returndata = Replace(returndata, "e'", "è")
            returndata = Replace(returndata, "i'", "ì")
            returndata = Replace(returndata, "o'", "ò")
            returndata = Replace(returndata, "u'", "ù")

            If (returndata.Contains("[ADMIN]")) Then
                attiva_controlli_admin()
            End If

            If (returndata.Contains("[DISCONNETTI]")) Then
                btndisconnetti.PerformClick()
                Exit While
            End If

            readData = "" + returndata
            msg()
        End While
    End Sub

    Private Sub btndisconnetti_Click(sender As System.Object, e As System.EventArgs) Handles btndisconnetti.Click
        Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes("/disconnetti" + "$")
        Try
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
        Catch ex As Exception
            'altrimenti non accetta la sintassi
        End Try

        disattiva_controlli_admin()
        If allarga_restringi Then 'restringe la finestra
            btncomandi.PerformClick()
        End If

        clientSocket = New System.Net.Sockets.TcpClient()
        serverStream = Nothing
        readData = String.Empty
        infiniteCounter = 0
        allarga_restringi = 0

        btnconnetti.Enabled = 1
        txtip.Enabled = 1
        txtnick.Enabled = 1
        btndisconnetti.Enabled = 0
        lstonline.Items.Clear()

    End Sub

    Private Sub fondo_txtcronologia()
        'permette di eseguire modifiche al form di partenza visto che ora ci troviamo in un thread
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf fondo_txtcronologia))
        Else
            txtcronologia.SelectionStart = txtcronologia.Text.Length
            txtcronologia.ScrollToCaret()
        End If
    End Sub

    Private Sub nega_tasti(ByRef e As System.Windows.Forms.KeyPressEventArgs, ByVal caratteri As String())
        If (caratteri.Contains(e.KeyChar)) Then
            e.Handled = 1
        End If
    End Sub

    Private Sub txttesto_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txttesto.KeyDown
        If (e.KeyValue = Keys.Up) Then
            e.Handled = 1
            txttesto.Text = ultimo_messaggio.Item(posizionamento_ultimo_messaggio).ToString
            posizionamento_ultimo_messaggio -= 1
            If (posizionamento_ultimo_messaggio < 0) Then posizionamento_ultimo_messaggio = 0
        ElseIf (e.KeyValue = Keys.Down) Then
            e.Handled = 1
            txttesto.Text = ultimo_messaggio.Item(posizionamento_ultimo_messaggio).ToString
            posizionamento_ultimo_messaggio += 1
            If (posizionamento_ultimo_messaggio >= ultimo_messaggio.Count) Then posizionamento_ultimo_messaggio = ultimo_messaggio.Count - 1
        End If
    End Sub

    Private Sub txttesto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttesto.KeyPress
        Dim caratteri As String() = {"$", "[", "]", "*", "/"}
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = 1
            btninvia.PerformClick()
        End If

    End Sub

    Private Sub txtip_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtip.KeyPress
        Dim caratteri As String() = {"$", "[", "]"}
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            btnconnetti.PerformClick()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        Dim caratteri As String() = {"$", "[", "]", "{", "}", "/", """"}
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = 1
            btnautentica.PerformClick()
        End If
    End Sub

    Private Sub txtnick_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnick.KeyPress
        Dim caratteri As String() = caratteri_nick
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = 1
            btnconnetti.PerformClick()
        End If
    End Sub

    Private Sub txtbannaip_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbannaip.KeyPress
        Dim caratteri As String() = {"$", "[", "]", "{", "}", ",", ";", ":", "-", "_", "?", "!", """", "/"}
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = 1
            btnbanna.PerformClick()
        End If
    End Sub

    Private Sub txtcacciaip_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcacciaip.KeyPress
        Dim caratteri As String() = {"$", "[", "]", "{", "}", ",", ";", ":", "-", "_", "?", "!", """", "/"}
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = 1
            btncaccia.PerformClick()
        End If
    End Sub

    Private Sub txtdebannaip_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdebannaip.KeyPress
        Dim caratteri As String() = {"$", "[", "]", "{", "}", ",", ";", ":", "-", "_", "?", "!", """", "/"}
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = 1
            btndebanna.PerformClick()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        btndisconnetti.PerformClick()
        clientSocket.Close()
        Environment.Exit(0) 'uscita forzata
    End Sub

    Private Sub btncomandi_Click(sender As System.Object, e As System.EventArgs) Handles btncomandi.Click
        allarga_restringi = Not allarga_restringi
        tmrfinestra.Stop()
        tmrfinestra.Start()
    End Sub

    Private Sub tmrfinestra_Tick(sender As System.Object, e As System.EventArgs) Handles tmrfinestra.Tick
        If (allarga_restringi = False) Then 'se restringi (perchè si inverte al click)
            If (Me.Width <= LARGHEZZA_MIN) Then
                allarga_restringi = 0
                tmrfinestra.Stop()
            Else
                btncomandi.Text = "Mostra tutti i comandi -->"
                Me.Width -= 5
            End If

        Else 'se allarga
            If (Me.Width >= LARGHEZZA_MAX) Then
                allarga_restringi = 1
                tmrfinestra.Stop()
            Else
                Me.Width += 5
                btncomandi.Text = "<-- Nascondi tutti i comandi"
            End If

        End If
    End Sub

    Private Sub btnautentica_Click(sender As System.Object, e As System.EventArgs) Handles btnautentica.Click
        comando("/psw " & txtpassword.Text)
        txtpassword.Text = ""
    End Sub

    Private Sub btncaccia_Click(sender As System.Object, e As System.EventArgs) Handles btncaccia.Click
        If (txtcacciaip.Text <> "") Then
            txtnome_comandi.Text = txtcacciaip.Text
            txtcacciaip.Text = ""
        End If
        comando("/caccia " & txtnome_comandi.Text)
        txtnome_comandi.Text = ""
        lstonline.SelectedItem = Nothing
    End Sub

    Private Sub btnbanna_Click(sender As System.Object, e As System.EventArgs) Handles btnbanna.Click
        If (txtbannaip.Text <> "") Then
            txtnome_comandi.Text = txtbannaip.Text
            txtbannaip.Text = ""
        End If
        comando("/banna " & txtnome_comandi.Text)
        txtnome_comandi.Text = ""
        lstonline.SelectedItem = Nothing
    End Sub

    Private Sub btndebanna_Click(sender As System.Object, e As System.EventArgs) Handles btndebanna.Click
        If (txtdebannaip.Text <> "") Then
            txtnome_comandi.Text = txtdebannaip.Text
            txtdebannaip.Text = ""
        End If
        comando("/debanna " & txtnome_comandi.Text)
        txtnome_comandi.Text = ""
        lstonline.SelectedItem = Nothing
    End Sub

    Private Sub btnchiudi_server_Click(sender As System.Object, e As System.EventArgs) Handles btnchiudi_server.Click
        comando("/chiudi")
    End Sub

    Private Sub btntrova_ip_Click(sender As System.Object, e As System.EventArgs) Handles btntrova_ip.Click
        comando("/trova-ip " & txtnome_comandi.Text)
        txtnome_comandi.Text = ""
        lstonline.SelectedItem = Nothing
    End Sub

    Private Sub btnlista_online_Click(sender As System.Object, e As System.EventArgs) Handles btnlista_online.Click
        comando("/lista-on")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Width = LARGHEZZA_MIN
    End Sub

    Private Sub lstonline_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstonline.SelectedIndexChanged
        Try
            txtnome_comandi.Text = lstonline.SelectedItem.ToString()
        Catch ex As Exception
            txtnome_comandi.Text = ""
        End Try
    End Sub
End Class