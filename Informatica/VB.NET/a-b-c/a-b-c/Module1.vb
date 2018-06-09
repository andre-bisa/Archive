Module Module1

    Sub Main()
        Dim a, b, c As Single
        Dim str As String
        Dim n_positivi, n_negativi, n_nulli As Single
        Dim s_positivi, s_negativi, s_nulli As Single

        Console.WriteLine("Scrivi un numero")
        str = Console.ReadLine()

        If Not IsNumeric(str) Then
            Console.WriteLine("Errore, il dato inserito non e' numerico.")
            Console.ReadKey()
            Return
        End If
        a = Convert.ToSingle(str)

        Console.WriteLine("Scrivi un numero")
        str = Console.ReadLine()

        If Not IsNumeric(str) Then
            Console.WriteLine("Errore, il dato inserito non e' numerico.")
            Console.ReadKey()
            Return
        End If
        b = Convert.ToSingle(str)

        Console.WriteLine("Scrivi un numero")
        str = Console.ReadLine()

        If Not IsNumeric(str) Then
            Console.WriteLine("Errore, il dato inserito non e' numerico.")
            Console.ReadKey()
            Return
        End If
        c = Convert.ToSingle(str)

        Select Case a
            Case Is > 0
                n_positivi = 1
                s_positivi = a
            Case Is < 0
                n_negativi = 1
                s_negativi = a
            Case Is = 0
                n_nulli = 1
                s_nulli = a
        End Select

        Select Case b
            Case Is > 0
                n_positivi += 1
                s_positivi += b
            Case Is < 0
                n_negativi += 1
                s_negativi += b
            Case Is = 0
                n_nulli += 1
                s_nulli += b
        End Select

        Select Case c
            Case Is > 0
                n_positivi += 1
                s_positivi += c
            Case Is < 0
                n_negativi += 1
                s_negativi += c
            Case Is = 0
                n_nulli += 1
                s_nulli += c
        End Select

        Console.WriteLine("Hai scritto: {0} numeri positivi, {1} numeri negativi, {2} numeri nulli", n_positivi, n_negativi, n_nulli)
        Console.WriteLine("La somma dei numeri positivi e': {0}", s_positivi)
        Console.WriteLine("La somma dei numeri negativi e': {0}", s_negativi)
        Console.WriteLine("La somma dei numeri nulli e': {0}", s_nulli)
        Console.ReadKey()

    End Sub

End Module
