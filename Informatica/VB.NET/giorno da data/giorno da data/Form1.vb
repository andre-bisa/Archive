Public Class Form1

    Private Sub btntrova_Click(sender As System.Object, e As System.EventArgs) Handles btntrova.Click
        Dim gg As Integer = 0
        Dim mm As Integer = 0
        Dim ss As Integer = 0
        Dim aa As Integer = 0
        Dim anno As Integer = 0
        Dim bisestile As Boolean = False

        Try
            gg = Convert.ToSingle(txtdata.Text.Substring(0, 2))
            mm = Convert.ToSingle(txtdata.Text.Substring(3, 2))
            ss = Convert.ToSingle(txtdata.Text.Substring(6, 2))
            aa = Convert.ToSingle(txtdata.Text.Substring(8, 2))
            anno = Convert.ToSingle(txtdata.Text.Substring(6, 4))
        Catch ex As Exception
            MsgBox("Inserire prima una data")
        End Try

        If (mm > 12) Or (gg > 31) Then
            MsgBox("Inserire una data esistente")
            Exit Sub
        End If

        If (anno Mod 4 = 0 And (anno Mod 100 <> 0 Or anno Mod 400 = 0)) Then
            bisestile = 1
        End If

        Dim g As Integer = gg Mod 7
        Dim m As Integer = 0

        Select Case mm
            Case 1
                If (bisestile) Then m = 6 Else m = 0
            Case 2, 3
                If (bisestile) Then m = 2 Else m = 3
            Case 4, 7
                m = 6
            Case 5
                m = 1
            Case 6
                m = 4
            Case 8
                m = 2
            Case 9
                m = 5
            Case 10
                m = 0
            Case 11
                m = 3
            Case 12
                m = 5
        End Select

        Dim a As Integer = (aa Mod 28) + Int((aa Mod 28) / 4)

        Dim c As Integer = 0

        Select Case (ss Mod 4)
            Case 0
                c = 6
            Case 1
                c = 4
            Case 2
                c = 2
            Case 3
                c = 0
        End Select

        Select Case ((g + m + a + c) Mod 7)
            Case 0
                lblgiorno.Text = "Domenica"
            Case 1
                lblgiorno.Text = "Lunedì"
            Case 2
                lblgiorno.Text = "Martedì"
            Case 3
                lblgiorno.Text = "Mercoledì"
            Case 4
                lblgiorno.Text = "Giovedì"
            Case 5
                lblgiorno.Text = "Venerdì"
            Case 6
                lblgiorno.Text = "Sabato"
        End Select



    End Sub
End Class
