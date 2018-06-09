Imports System
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Partial Public Class Form1
    Inherits Form
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319

    <DllImport("user32.dll")> _
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr, _
               ByVal Msg As Integer, ByVal wParam As IntPtr, _
               ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Sub btnMute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMute.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, _
                      Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
    End Sub

    Private Sub btnDiminuisciVolume_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiminuisciVolume.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, _
                     Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
    End Sub

    Private Sub btnAumentaVolume_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAumentaVolume.Click
        SendMessageW(Me.Handle, WM_APPCOMMAND, _
                     Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
