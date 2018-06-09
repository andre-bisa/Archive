Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.Reflection

Module Funzioni

    Public Conn As New OdbcConnection("dsn=ODBCMamma;uid=Admin;pwd=;")

    Public Const LABEL = "LABEL"
    Public Const BUTTON = "BUTTON"
    Public Const TEXTBOX = "TEXTBOX"

    Public Sub CaricaNomiControlli(ByVal Form As Form)
        On Error Resume Next
        If (Conn.State = ConnectionState.Open) Then Conn.Close()
        Conn.Open()
        Dim Cmd As OdbcCommand = Conn.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "SELECT NomeControllo, TestoControllo, TipoControllo, AttivoControllo FROM Controlli WHERE Form='" & Form.Name & "';"
        Dim letto As OdbcDataReader = Cmd.ExecuteReader()
        If IsNothing(letto) Then GoTo Ext
        While letto.Read()
            With letto
                Select Case UCase(.Item("TipoControllo"))
                    Case LABEL, TEXTBOX, BUTTON
                        Form.Controls(.Item("NomeControllo")).Text = .Item("TestoControllo")
                        Form.Controls(.Item("NomeControllo")).Visible = .Item("AttivoControllo")
                End Select
            End With
        End While
Ext:
        Conn.Close()
        Exit Sub
    End Sub
End Module
