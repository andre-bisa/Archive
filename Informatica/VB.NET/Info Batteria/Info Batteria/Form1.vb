Public Class Form1

    Dim BatteryStatus As PowerStatus = SystemInformation.PowerStatus
    Dim BatteryPower As Single = BatteryStatus.BatteryLifePercent

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblpercentuale.Text = BatteryPower * 100 & "%"

        If Not (BatteryPower = BatteryChargeStatus.NoSystemBattery) Then
            If BatteryStatus.PowerLineStatus = PowerLineStatus.Online Then
                lblcarica.Text = "Si"  ' Batteria in carica
            ElseIf BatteryStatus.PowerLineStatus = PowerLineStatus.Offline Then
                lblcarica.Text = "No"  ' Batteria non in carica
            End If
        Else : lblcarica.Text = "No batteria"
        End If
        If BatteryPower = BatteryChargeStatus.High Then
            lblalto.Text = "Si"
        Else : lblalto.Text = "No"
        End If

        If BatteryPower = BatteryChargeStatus.Critical Then
            lblcritica.Text = "Si"
        Else : lblcritica.Text = "No"
        End If

        If BatteryPower = BatteryChargeStatus.Low Then
            lblbasso.Text = "Si"
        Else : lblbasso.Text = "No"
        End If

        If BatteryPower = BatteryChargeStatus.NoSystemBattery Then
            lblbatteria.Text = "No"
        Else : lblbatteria.Text = "Si"
        End If

        If BatteryPower = BatteryChargeStatus.Unknown Then
            lblnonso.Text = "Non so..."
        Else : lblnonso.Text = "Si lo so..."
        End If

    End Sub
End Class
