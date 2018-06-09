Public Class Form1

    Dim errore As Boolean = 0

    Function intero(str As String)
        If (errore = 0) Then
            If Not IsNumeric(str) Then
                MsgBox("Errore inserimento dati.")
                errore = 1
                Return 0
            Else
                Return Convert.ToInt32(str)
            End If
        End If
        Return "0"
    End Function

    Private Sub btncalcola_Click(sender As System.Object, e As System.EventArgs) Handles btncalcola.Click
        errore = 0
        Dim nome, diploma As String
        Dim prova1, prova2, prova3, orale, credito, bonus, tot As Integer

        nome = txtnome.Text
        prova1 = intero(txtprima.Text)
        prova2 = intero(txtseconda.Text)
        prova3 = intero(txtterza.Text)
        orale = intero(txtorale.Text)
        credito = intero(txtcrediti.Text)
        If (errore) Then
            Exit Sub
        End If
        tot = prova1 + prova2 + prova3 + orale
        If (credito >= 15 And tot >= 70) Then
            bonus = intero(InputBox("Scrivi quanti punti bonus devo dare"))
        End If

        tot += credito + bonus

        Select Case txtistituto.SelectedValue
            Case 0
                diploma = "Ragioniere"
            Case 1
                diploma = "Ragioniere Programmatore"
            Case 2
                diploma = "Perito Industriale"
            Case 3
                diploma = "Operatore Turistico"
            Case Else
                diploma = "Impossibile determinare tipo di laurea"
        End Select

        If (tot >= 60) Then
            lbldiploma.Text = "Complimenti " & nome & "!! Sei diventato: " & diploma & " con " & tot & " punti"
        Else
            lbldiploma.Text = "Mi dispiace " & nome & " ma " & tot & " non bastano per superare l'esame!"
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtistituto.SelectedIndex = 0
    End Sub
End Class
