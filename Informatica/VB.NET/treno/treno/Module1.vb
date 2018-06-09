Module Module1

    Sub Main()
        Dim km, pr, tot As Single
        Dim str, treno As String

        Console.WriteLine("Quanti kilometri vuoi fare?")
        str = Console.ReadLine()

        If Not IsNumeric(str) Then
            Console.WriteLine("Errore, il dato inserito non e' numerico")
            Console.ReadKey()
            Return
        End If

        km = Convert.ToSingle(str)
        pr = 0.5 * km

        Console.WriteLine("Che tipo di treno vuoi prendere? (R=regionale, I=intercity o E=eurostar)")
        treno = Console.ReadLine()

        Select Case treno
            Case "r", "R"
                tot = pr * 1.07
            Case "i", "I"
                tot = pr * 1.12
            Case "e", "E"
                tot = pr * 1.18
            Case Else
                Console.WriteLine("Errore, devi scrivere R od I od E")
        End Select

        Console.WriteLine("Prezzo totale per {0} km = {1}", km, tot)
        Console.ReadKey()
    End Sub

End Module
