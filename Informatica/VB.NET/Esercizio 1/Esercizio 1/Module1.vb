Module Module1

    Sub Main()
        Dim minuti As Single
        Dim str As String
        Dim pr As Single

        Console.WriteLine("Scrivi il numero di minuti di conversazione")
        str = Console.ReadLine()

        If Not IsNumeric(str) Then
            Console.WriteLine("Errore input")
            Console.ReadKey()
            Return
        End If

        minuti = Convert.ToSingle(str)

        If (minuti >= 300 Or minuti <= 0) Then
            Console.WriteLine("I minuti inseriti sono minori di 0 o maggiori di 300")
            Console.ReadKey()
            Return
        End If

        If (minuti <= 50) Then
            pr = minuti * 50
        ElseIf minuti <= 100 Then
            pr = 50 * 5 + (minuti - 50) * 4
        Else
            pr = 50 * 5 + 50 * 4 + (minuti - 100) * 3
        End If

        Console.WriteLine("Il costo di {0} minuti e' uguale a {1} centesimi ", minuti, pr)
        Console.ReadKey()

    End Sub

End Module
