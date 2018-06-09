Module Module1

    Function numero_intero()
        Dim str As String
        str = Console.ReadLine()
        If Not IsNumeric(str) Then
            Console.WriteLine("Errore, dato non numerico")
            Console.ReadKey()
            Environment.Exit(0)
        End If
        Return Convert.ToSingle(str)
    End Function

    Sub Main()
        Dim anno As Integer

        Console.WriteLine("Scrivi un anno (maggiore di 1582 e minore di 2100)")
        anno = numero_intero()

        If ((anno < 1582) Or (anno > 2100)) Then
            Console.WriteLine("Errore")
            Console.ReadKey()
            Return
        End If

        If ((anno Mod 4 = 0) And ((anno Mod 100 <> 0) Or (anno Mod 400 = 0))) Then
            Console.WriteLine("Anno bisestile")
        Else : Console.WriteLine("Anno non bisestile")
        End If

        Console.ReadKey()
    End Sub

End Module
