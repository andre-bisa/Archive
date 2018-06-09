Module Module1

    Sub Main()
        Dim temp, ris As Single
        Dim str, tipo As String

        Console.WriteLine("Scrivi la temperatura")
        str = Console.ReadLine()

        If Not IsNumeric(str) Then
            Console.WriteLine("Errore, i dati inseriti sono alphanumerici")
            Console.ReadKey()
            Return
        End If

        temp = Convert.ToSingle(str)

        Console.WriteLine("Scrivi il tipo: (C=verso celsius, F=verso fharenheit)")
        tipo = Console.ReadLine()

        Select Case tipo
            Case "F"
                ris = 9 / 5 * temp + 32
                Console.WriteLine("{0} gradi Celsius sono uguale {1} gradi Fharenheit", temp, ris)
            Case "f"
                ris = 9 / 5 * temp + 32
                Console.WriteLine("{0} gradi Celsius sono uguale {1} gradi Fharenheit", temp, ris)
            Case "c"
                ris = (temp - 32) * 5 / 9
                Console.WriteLine("{0} gradi Fharenheit sono uguale {1} gradi Celsius", temp, ris)
            Case "C"
                ris = (temp - 32) * 5 / 9
                Console.WriteLine("{0} gradi Fharenheit sono uguale {1} gradi Celsius", temp, ris)
            Case Else
                Console.WriteLine("Errore tipo dati")
        End Select

        Console.ReadKey()

    End Sub

End Module
