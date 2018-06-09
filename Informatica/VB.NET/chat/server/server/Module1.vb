Imports System.Net.Sockets
Imports System.Text
Imports System.Net


Module Module1
    Const PASSWORD As String = "melanzana"

    Dim clientsList As New Hashtable
    Dim bannati As New ArrayList
    Dim admin As New ArrayList
    Dim online As New ArrayList
    Dim ip_online As New Hashtable

    Sub Main()
        Dim serverSocket As New TcpListener(8888)
        Dim clientSocket As TcpClient

        serverSocket.Start()
        msg("Server Iniziato ....")

        While (True)
            clientSocket = serverSocket.AcceptTcpClient()

            'legge l'ip del client che si sta connettendo
            Dim ipend As Net.IPEndPoint = clientSocket.Client.RemoteEndPoint
            Dim ip As String = ipend.Address.ToString()

            Dim bytesFrom(10024) As Byte
            Dim dataFromClient As String

            Dim networkStream As NetworkStream = clientSocket.GetStream()
            networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
            dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
            dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))

            'controllo che l'ip non sia già connesso
            '127.0.0.1 può accedere visto che è il "capo" del server
            Dim Item As DictionaryEntry
            For Each Item In ip_online
                If (Item.Value = ip) Then
                    If (ip = "127.0.0.1") Then Exit For
                    Dim messaggio As String = "***** Non puoi accedere con piu' account alla volta dallo stesso pc *****"
                    networkStream.Write(Encoding.ASCII.GetBytes(messaggio), 0, messaggio.Length)
                    networkStream.Flush()
                    Continue While
                End If
            Next

            'controlla che l'account non sia bannato per ip
            If (bannati.Contains(ip)) Then
                broadcast(ip & " ha tentato di accedere ma e' bannato", dataFromClient, False)

                Dim messaggio As String = "***** Sei risultato bannato per ip *****"
                networkStream.Write(Encoding.ASCII.GetBytes(messaggio), 0, messaggio.Length)
                networkStream.Flush()
                Continue While
            End If

            'controlla che l'account non sia bannato
            If (bannati.Contains(dataFromClient)) Then
                broadcast(dataFromClient & " ha tentato di accedere ma e' bannato", dataFromClient, False)

                Dim messaggio As String = "***** Sei risultato bannato *****"
                networkStream.Write(Encoding.ASCII.GetBytes(messaggio), 0, messaggio.Length)
                networkStream.Flush()
                Continue While
            End If

            'controlla che l'account non sia già loggato
            If (clientsList.Contains(dataFromClient)) Then
                Dim messaggio As String = "***** Sei risultato gia' loggato *****"
                networkStream.Write(Encoding.ASCII.GetBytes(messaggio), 0, messaggio.Length)
                networkStream.Flush()
                Continue While
            Else 'altrimenti lo aggiungi a quelli online
                online.Add(dataFromClient)
            End If

            'aggiunge l'ip all'elenco
            ip_online(dataFromClient) = ip

            'aggiunge il client all'elenco dei client
            clientsList(dataFromClient) = clientSocket

            broadcast(dataFromClient + " e' entrato nella sala! ", dataFromClient, False)

            Threading.Thread.Sleep(10)

            aggiorna_online()

            Dim client As New handleClinet
            client.startClient(clientSocket, dataFromClient, clientsList)

        End While

        clientSocket.Close()
        serverSocket.Stop()
        msg("exit")
        Console.ReadLine()
    End Sub

    Sub msg(ByVal mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub

    Private Sub broadcast(ByVal mex As String, ByVal nome As String, ByVal chat_generale As Boolean)
        'chat_generale:
        'True  : messaggio di chat composto da nome + ":" + messaggio
        'False : messaggio generale non di chat composto da "$$$$$" + messaggio + "$$$$$"

        Dim messaggio As String = String.Empty
        Dim Item As DictionaryEntry
        For Each Item In clientsList
            messaggio = mex
            Dim broadcastSocket As TcpClient
            broadcastSocket = CType(Item.Value, TcpClient)
            Try
                Dim broadcastStream As NetworkStream = broadcastSocket.GetStream()
                Dim broadcastBytes As [Byte]()

                messaggio = messaggio.Replace("à", "a'")
                messaggio = messaggio.Replace("è", "e'")
                messaggio = messaggio.Replace("é", "e'")
                messaggio = messaggio.Replace("ì", "i'")
                messaggio = messaggio.Replace("ò", "o'")
                messaggio = messaggio.Replace("ù", "u'")

                If chat_generale = True Then
                    messaggio = nome & ": " & messaggio
                    broadcastBytes = Encoding.ASCII.GetBytes(messaggio)
                Else
                    messaggio = "$$$$$ " & messaggio & " $$$$$"
                    broadcastBytes = Encoding.ASCII.GetBytes(messaggio)
                End If

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length)
                broadcastStream.Flush()
            Catch ex As Exception
                'niente
            End Try
        Next
        msg(messaggio)
    End Sub

    Private Sub aggiorna_online()
        broadcast("[LISTA_ONLINE_SVUOTA]", "", False)
        Threading.Thread.Sleep(100)
        Dim Item As DictionaryEntry
        For Each Item In clientsList
            Threading.Thread.Sleep(10)
            broadcast("[LISTA_ONLINE_AGGIUNGI] " & Item.Key, "", False)
        Next
    End Sub

    Private Sub disconnetti(ByVal nome As String, ByVal da As String)
        If (ip_online.Contains(nome)) Then
            'bisogna far disconnettere un ip quindi adesso ricavo il nome
            For Each item As DictionaryEntry In ip_online
                If (item.Value = nome) Then
                    'item.value è ip
                    'nome è l'ip inserito

                    'quindi il nome diventa uguale al vero nome
                    nome = item.Key
                    Exit Sub
                End If
            Next
        End If

        'controllo che ci sia prima di eliminarlo dalla lista
        If (clientsList.Contains(nome)) Then
            'se nome <> da vuol dire che si è stati cacciati
            If (nome <> da) Then
                mex_singolo(nome, "Sei stato cacciato da: " & da)
                Threading.Thread.Sleep(10)
                broadcast(nome & " e' stato cacciato da " & da, da, False)
            Else
                broadcast(nome & " si e' disconnesso", nome, False)
            End If
            Threading.Thread.Sleep(10)
            mex_singolo(nome, "[DISCONNETTI]")
            clientsList.Remove(nome)
            ip_online.Remove(nome)
            aggiorna_online()
            If (admin.Contains(nome)) Then admin.Remove(nome)
        Else 'altrimenti avviso che l'account non è online
            mex_singolo(da, "L'account non e' online")
        End If
    End Sub

    Private Sub banna(ByVal nome As String, ByVal da As String)
        'controllo che non sia già bannato
        If Not (bannati.Contains(nome)) Then
            broadcast(nome & " e' stato bannato", nome, False)
            bannati.Add(nome)
        Else 'se è già bannato
            mex_singolo(da, "L'account e' gia' bannato")
        End If
        disconnetti(nome, da)
    End Sub

    Private Sub debanna(ByVal nome As String, ByVal da As String)
        'controllo che sia effettivamente bannato
        If (bannati.Contains(nome)) Then
            broadcast(nome & " e' stato de-bannato", nome, False)
            bannati.Remove(nome)
        Else
            mex_singolo(da, "L'utente o l'ip non erano bannati")
        End If
    End Sub

    Private Sub trova_ip(ByVal nome As String, ByVal da As String)
        'controllo che l'account sia online
        If Not (clientsList.Contains(nome)) Then Exit Sub
        For Each item As DictionaryEntry In ip_online
            If Not (nome = item.Key) Then Continue For
            mex_singolo(da, "L'ip di """ & item.Key & """ è : " & item.Value)
            'item.key = nome
            'item.value = ip
        Next
    End Sub

    Private Sub lista_on(ByVal nome As String)
        Dim messaggio As String = String.Empty
        messaggio = "Nella sala attualmente online ci sono:" & vbNewLine & "***** /////////////// *****"
        Dim Item As DictionaryEntry
        For Each Item In clientsList
            messaggio &= vbNewLine & Item.Key
        Next
        messaggio &= vbNewLine & "***** ///////////////"
        mex_singolo(nome, messaggio)
    End Sub

    Private Sub mex_singolo(ByVal nome As String, ByVal messaggio As String)
        Dim Item As DictionaryEntry
        For Each Item In clientsList
            Dim privataSocket As TcpClient
            privataSocket = CType(Item.Value, TcpClient)

            messaggio = messaggio.Replace("à", "a'")
            messaggio = messaggio.Replace("è", "e'")
            messaggio = messaggio.Replace("é", "e'")
            messaggio = messaggio.Replace("ì", "i'")
            messaggio = messaggio.Replace("ò", "o'")
            messaggio = messaggio.Replace("ù", "u'")

            'trova il valore corrispondente al value della socket
            'quindi se la key corrisponde col nome a cui si vuole
            'inviare il messaggio questo verrà mandato solo a quello
            Dim destinatario As String = Item.Key
            If (destinatario <> nome) Then Continue For

            Dim privataStream As NetworkStream = privataSocket.GetStream()
            Dim privataBytes As [Byte]()

            privataBytes = Encoding.ASCII.GetBytes("***** " & messaggio & " *****")

            privataStream.Write(privataBytes, 0, privataBytes.Length)
            privataStream.Flush()
            Exit For
        Next
    End Sub

    Public Class handleClinet
        Dim clientSocket As TcpClient
        Dim clNo As String
        Dim clientsList As Hashtable

        Public Sub startClient(ByVal inClientSocket As TcpClient, ByVal clineNo As String, ByVal cList As Hashtable)
            Me.clientSocket = inClientSocket
            Me.clNo = clineNo
            Me.clientsList = cList
            Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf doChat)
            ctThread.Start()
        End Sub

        Private Sub doChat()
            Dim bytesFrom(10024) As Byte
            Dim dataFromClient As String

            While (True)
                Try
                    Dim networkStream As NetworkStream = clientSocket.GetStream()
                    networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))

                    If Not (clientsList.Contains(clNo)) Then Exit While

                    'se si disconnette riparti col ciclo per evitare
                    'di inviare il messaggio a tutti
                    Dim comandi() As String
                    comandi = Split(dataFromClient, " ")


                    'controllo del comando mandato
                    Select Case comandi(0)
                        Case "/chiudi"
                            If Not (admin.Contains(clNo)) Then Continue While
                            Environment.Exit(0)

                        Case "/caccia"
                            'controllo che esista comandi(1)
                            'comandi.count è sempre un valore in più
                            If Not (admin.Contains(clNo)) Then Continue While
                            If (comandi.Count = 1) Then Continue While
                            'controllo che non cacci un admin
                            If (admin.Contains(comandi(1)) And (clNo <> comandi(1))) Then
                                broadcast(clNo & " ha provato a cacciare " & comandi(1), clNo, False)
                                mex_singolo(clNo, "Impossibile cacciare un admin")
                                Continue While
                            End If
                            'controllo che non cacci l'ip di un admin
                            For Each item As DictionaryEntry In ip_online
                                'item.key = nome
                                'item.value = ip
                                If (comandi(1) = item.Value) Then
                                    If (admin.Contains(item.Key) And (clNo <> comandi(1))) Then
                                        broadcast(clNo & " ha provato a cacciare " & item.Key, clNo, False)
                                        mex_singolo(clNo, "Impossibile cacciare un admin")
                                        Continue While
                                    End If
                                End If
                            Next
                            'altrimenti caccia l'utente
                            disconnetti(comandi(1), clNo)
                            Continue While

                        Case "/disconnetti"
                            disconnetti(clNo, clNo)
                            Continue While

                        Case "/banna"
                            If Not (admin.Contains(clNo)) Then Continue While
                            If (comandi.Count = 1) Then Continue While
                            'controllo che non banni un admin
                            If (admin.Contains(comandi(1))) Then
                                'non puoi bannare un admin
                                broadcast(clNo & " ha provato a bannare " & comandi(1), clNo, False)
                                mex_singolo(clNo, "Impossibile bannare un admin")
                                Continue While
                            End If
                            'controllo che non banni l'ip di un admin
                            For Each item As DictionaryEntry In ip_online
                                'item.key = nome
                                'item.value = ip
                                If (comandi(1) = item.Value) Then
                                    If (admin.Contains(item.Key)) Then
                                        broadcast(clNo & " ha provato a bannare " & item.Key & " per ip", clNo, False)
                                        mex_singolo(clNo, "Impossibile bannare un admin")
                                        Continue While
                                    End If
                                End If
                            Next
                            banna(comandi(1), clNo)
                            Continue While

                        Case "/debanna"
                            If (comandi.Count = 1) Then Continue While
                            If Not (admin.Contains(clNo)) Then Continue While
                            debanna(comandi(1), clNo)
                            Continue While

                        Case "/trova-ip"
                            If (comandi.Count = 1) Then Continue While
                            If Not (admin.Contains(clNo)) Then Continue While
                            trova_ip(comandi(1), clNo)
                            Continue While

                        Case "/lista-on"
                            If Not (admin.Contains(clNo)) Then Continue While
                            lista_on(clNo)
                            Continue While

                        Case "/psw"
                            If (comandi.Count = 1) Then Continue While
                            If (comandi(1) = PASSWORD) Then
                                If Not (admin.Contains(clNo)) Then
                                    admin.Add(clNo)
                                    broadcast("""" & clNo & """ e' ora admin", clNo, False)
                                    mex_singolo(clNo, "Sei ora [ADMIN]")
                                Else
                                    mex_singolo(clNo, "Sei gia' [ADMIN]")
                                End If
                            Else
                                mex_singolo(clNo, "Password errata, impossibile riconoscere autenticita'")
                            End If
                            Continue While

                        Case Else
                            If (Mid(comandi(0), 1, 1) = "/") Then
                                mex_singolo(clNo, "Comando errato")
                                Continue While
                            End If
                    End Select

                    broadcast(dataFromClient, clNo, True)
                Catch ex As Exception
                    'se c'è un errore smetti di 
                    Exit Sub
                End Try
            End While
        End Sub

    End Class
End Module
