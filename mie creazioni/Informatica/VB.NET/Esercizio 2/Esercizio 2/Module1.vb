Module Module1

    Sub Main()
        Dim reddito As Single
        Dim str As String
        Dim irpef As Single

        Console.WriteLine("Scrivi il numero di reddito annuo")
        str = Console.ReadLine()

        If Not IsNumeric(str) Then
            Console.WriteLine("Errore input")
            Console.ReadKey()
            Return
        End If

        reddito = Convert.ToSingle(str)

        If (reddito <= 0) Then
            Console.WriteLine("Errore reddito")
            Console.ReadKey()
            Return
        End If

        If reddito <= 15000 Then
            irpef = reddito * 0.23
        ElseIf reddito <= 28000 Then
            irpef = 3450 + (reddito - 15000) * 0.27
        ElseIf reddito <= 55000 Then
            irpef = 6960 + (reddito - 28000) * 0.38
        ElseIf reddito <= 75000 Then
            irpef = 17220 + (reddito - 55000) * 0.41
        Else
            irpef = 25420 + (reddito - 75000) * 0.43
        End If

        Console.WriteLine("Con {0} euro di reddito bisogna pagare {1} euro di IRPEF", reddito, irpef)
        Console.ReadKey()

    End Sub

End Module
