Module Funzioni
    Public Const PATH As String = "C:\Program Files\Audio\"
    Public Const PATH_PROFILI As String = PATH & "Profili\"

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "kernel32.dll" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Friend Function IniRead(ByVal Filename As String, ByVal Section As String, ByVal Key As String, Optional ByVal lpDefault As String = "", Optional ByVal bRaiseError As Boolean = False) As String
        Dim RetVal As String = New String(" ", 255)
        Dim LenResult As Integer
        Dim ErrString As String

        LenResult = GetPrivateProfileString(Section, Key, lpDefault, RetVal, RetVal.Length, Filename)
        If LenResult = 0 AndAlso bRaiseError Then
            If Not (System.IO.File.Exists(Filename)) Then
                ErrString = "Impossibile aprire il file INI" & Filename
            Else
                ErrString = "La sezione o la chiave sono errate oppure l’accesso al file non è consentito"
            End If
            Throw New Exception(ErrString)
        End If
        Return RetVal.Substring(0, LenResult)
    End Function

    Friend Function IniWrite(ByVal Filename As String, ByVal Section As String, ByVal Key As String, ByVal Value As String, Optional ByVal bRaiseError As Boolean = False) As Boolean
        Dim LenResult As Integer
        Dim ErrString As String

        LenResult = WritePrivateProfileString(Section, Key, Value, Filename)
        If LenResult = 0 And bRaiseError Then
            If Not (System.IO.File.Exists(Filename)) Then
                ErrString = "Impossibile aprire il file INI " & Filename
            Else
                ErrString = "Accesso al file non consentito"
            End If
            Throw New Exception(ErrString)
        End If
        Return IIf(LenResult = 0, False, True)
        End
    End Function

    Sub crea_directory()
        If Not (IO.Directory.Exists(PATH)) Then
            IO.Directory.CreateDirectory(PATH)
        End If
        If Not (IO.Directory.Exists(PATH_PROFILI)) Then
            IO.Directory.CreateDirectory(PATH_PROFILI)
        End If
    End Sub

    Sub crea_settings()
        If Not (IO.File.Exists(PATH & "settings.ini")) Then
            IO.File.CreateText(PATH & "settings.ini")
        End If
    End Sub

    Sub leggi_profili()
        'svuoto l'array contenente i profili per poi riempirlo
        Try
            Form1.ScegliProfiloToolStripMenuItem.DropDownItems.Clear()
            Array.Clear(Form1.profili, 0, Form1.profili.Length)
        Catch ex As Exception
        End Try

        Form1.profili = IO.Directory.GetFiles(PATH_PROFILI, "*.ini")

        If (Form1.profili.Length < 4) Then
            'creo il primo profilo
            MsgBox("Profili mancanti, inizio creazione profili.", MsgBoxStyle.Information)
            For i As Integer = Form1.profili.Length To 4 Step 1
                If IO.File.Exists(PATH_PROFILI & "profilo" & i + 1 & ".ini") Then
                    crea_profilo("default" & i + 1 & ".ini", "50", "100", False, "", 0, 300)
                Else
                    crea_profilo("profilo" & i + 1 & ".ini", "50", "100", False, "", 0, 300)
                End If
            Next

            Form1.profili = IO.Directory.GetFiles(PATH_PROFILI, "*.ini")
        End If

        For i As Integer = 0 To Form1.profili.Length - 1 Step 1
            Form1.profili(i) = Replace(Replace(Form1.profili(i), PATH_PROFILI, ""), ".ini", "")

            Dim profilo As New ToolStripMenuItem

            With profilo
                .Name = Form1.profili(i)
                .Text = Form1.profili(i)
                .ShowShortcutKeys = True
                .ShortcutKeyDisplayString = "CTRL + " & i
            End With
            AddHandler profilo.Click, AddressOf profilo_click
            Form1.ScegliProfiloToolStripMenuItem.DropDownItems.Add(profilo)

        Next

        seleziona_profilo(IniRead(PATH & "settings.ini", "SETTINGS", "profilo_attuale") & ".ini")
        Form1.tmrsalva_profili.Start()
    End Sub

    Sub profilo_click(sender As System.Object, e As System.EventArgs)
        If (Form1.pass_attiva) Then
            Form1.PASS_OK = 0
            Form4.ShowDialog()
            If Not (Form1.PASS_OK) Then
                MsgBox("Password errata!")
                Form1.PASS_OK = 0
                Exit Sub
            End If
            Form1.PASS_OK = 0
        End If
        seleziona_profilo(sender.ToString & ".ini")
        MsgBox(sender.ToString & " caricato.")
        Form1.tempo_tentativi = 300
        Call Form1.tmraggiorna_Tick(sender, e)
    End Sub

    Sub seleziona_profilo(ByVal nome As String)
        If (nome = ".ini") Or (nome = "") Then
            nome = "profilo1.ini"
        End If

        If Not (IO.File.Exists(PATH_PROFILI & nome)) Then
            Form1.profilo_attuale = Form1.profili(0)
            MsgBox("Errore caricamento """ & nome & """, caricamento profilo: " & Form1.profili(0))
            nome = Form1.profili(0)
        End If

        Form1.profilo_attuale = Replace(nome, ".ini", "")

        'carico impostazioni del profilo
        Form1.massimo = Convert.ToInt32(IniRead(PATH_PROFILI & Form1.profilo_attuale & ".ini", "VOLUME", "max"))
        Form1.device.AudioEndpointVolume.MasterVolumeLevelScalar = Convert.ToInt32(IniRead(PATH_PROFILI & Form1.profilo_attuale & ".ini", "VOLUME", "volume")) / 100
        Form1.pass_attiva = Convert.ToBoolean(IniRead(PATH_PROFILI & Form1.profilo_attuale & ".ini", "PASSWORD", "pass_attiva"))
        Form1.PASSWORD = IniRead(PATH_PROFILI & Form1.profilo_attuale & ".ini", "PASSWORD", "password")
        Form1.tempo_tentativi = Convert.ToUInt32(IniRead(PATH_PROFILI & Form1.profilo_attuale & ".ini", "PASSWORD", "tempo_tentativi"))
        Form1.tentativi = Convert.ToUInt32(IniRead(PATH_PROFILI & Form1.profilo_attuale & ".ini", "PASSWORD", "tentativi"))
        If (Form1.tentativi > 0) Then Form1.tmrtempo_tentativi.Start()

        If (Form1.pass_attiva) Then
            Form1.tentativi = 0
            Form1.tempo_tentativi = 300
        End If

        'setto tutti i profili come unchecked
        For i As Integer = 0 To Form1.ScegliProfiloToolStripMenuItem.DropDownItems.Count - 1 Step 1
            DirectCast(Form1.ScegliProfiloToolStripMenuItem.DropDownItems(Form1.profili(i)), ToolStripMenuItem).Checked = False
        Next i

        'seleziono il mio profilo come checked
        DirectCast(Form1.ScegliProfiloToolStripMenuItem.DropDownItems(Form1.profilo_attuale), ToolStripMenuItem).Checked = True

        IniWrite(PATH & "settings.ini", "SETTINGS", "profilo_attuale", Form1.profilo_attuale)

    End Sub

    Sub salva_profilo(ByVal nome As String)

        IniWrite(PATH_PROFILI & nome, "VOLUME", "max", Form1.massimo)
        IniWrite(PATH_PROFILI & nome, "VOLUME", "volume", Form1.device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "pass_attiva", Form1.pass_attiva.ToString)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "password", Form1.PASSWORD)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "tentativi", Form1.tentativi)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "tempo_tentativi", Form1.tempo_tentativi)

        'salvo anche le impostazioni
        IniWrite(PATH & "settings.ini", "SETTINGS", "profilo_attuale", Form1.profilo_attuale)
    End Sub

    Sub rinomina_profilo(ByVal nome As String, ByVal nuovo_nome As String)

        If (nuovo_nome = "") Then
            MsgBox("Errore, inserito il nome profilo vuoto.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If (Form1.profili.Contains(nuovo_nome)) Then
            MsgBox("Profilo già esistente!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            FileSystem.Rename(PATH_PROFILI & nome & ".ini", PATH_PROFILI & nuovo_nome & ".ini")
        Catch ex As Exception
            MsgBox("Errore nel rinominare il profilo:" & vbNewLine & ex.ToString, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        Form1.profilo_attuale = nuovo_nome

        salva_profilo(nuovo_nome & ".ini")
        leggi_profili()

    End Sub

    Sub crea_profilo(ByVal nome As String, ByVal volume As String, ByVal max As String, ByVal pass_attiva As Boolean, ByVal password As String, ByVal tentativi As String, ByVal tempo_tentativi As String)

ritorna:
        password = Trim(password)
        If (password = "") Then
            password = InputBox("Inserire una password di almeno un carattere per " & nome, "Password", "password")
            GoTo ritorna
        End If

        IniWrite(PATH_PROFILI & nome, "VOLUME", "max", max)
        IniWrite(PATH_PROFILI & nome, "VOLUME", "volume", volume)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "pass_attiva", pass_attiva.ToString)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "password", password)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "tentativi", tentativi)
        IniWrite(PATH_PROFILI & nome, "PASSWORD", "tempo_tentativi", tempo_tentativi)

        Try
            Form1.ScegliProfiloToolStripMenuItem.DropDownItems.Clear()
            Array.Clear(Form1.profili, 0, Form1.profili.Length)
        Catch ex As Exception
        End Try

        Form1.profili = IO.Directory.GetFiles(PATH_PROFILI, "*.ini")
    End Sub

End Module
