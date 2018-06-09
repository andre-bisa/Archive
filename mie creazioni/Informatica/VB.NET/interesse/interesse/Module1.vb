Module Module1

    Sub Main()
        Dim str, tipo As String
        Dim c, r, t, i As Single

        '---------------- CAPITALE ---------------
        Console.WriteLine("Scrivi il capitale")
        str = Console.ReadLine()
        If Not IsNumeric(str) Then
            Console.WriteLine("Capitale errato")
        End If
        c = Convert.ToSingle(str)

        '---------------- TASSO ------------------
        Console.WriteLine("Scrivi il tasso")
        str = Console.ReadLine()
        If Not IsNumeric(str) Then
            Console.WriteLine("Tasso errata")
        End If
        r = Convert.ToSingle(str)

        '--------------- TEMPO --------------------
        Console.WriteLine("Scrivi il tempo")
        str = Console.ReadLine()
        If Not IsNumeric(str) Then
            Console.WriteLine("Tempo errato")
        End If
        t = Convert.ToSingle(str)


        '--------------- TIPO ---------------------
        Console.WriteLine("Scrivi tipo di tempo inserito (c=anno commerciale, a=anno, m=mesi, g=giorni civili)")
        tipo = Console.ReadLine()

        '-------------- CONDIZIONI ----------------
        Select Case tipo
            Case "a"
                i = c * r * t / 100
                Console.WriteLine("Interessi = {0}", i)
            Case "A"
                i = c * r * t / 100
                Console.WriteLine("Interessi = {0}", i)
            Case "c"
                i = c * r * t / 36000
                Console.WriteLine("Interessi = {0}", i)
            Case "C"
                i = c * r * t / 36000
                Console.WriteLine("Interessi = {0}", i)
            Case "m"
                i = c * r * t / 1200
                Console.WriteLine("Interessi = {0}", i)
            Case "M"
                i = c * r * t / 1200
                Console.WriteLine("Interessi = {0}", i)
            Case "g"
                i = c * r * t / 36500
                Console.WriteLine("Interessi = {0}", i)
            Case "G"
                i = c * r * t / 36500
                Console.WriteLine("Interessi = {0}", i)
            Case Else
                Console.WriteLine("Errore inserimento tipo tempo")
                Console.WriteLine("Interessi = ?")
        End Select

        Console.ReadKey()

    End Sub

End Module
