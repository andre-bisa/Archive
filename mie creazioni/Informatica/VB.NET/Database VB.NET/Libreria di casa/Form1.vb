Imports System
Imports System.Data
Imports System.Data.Odbc

Public Class Form1
    Dim DBConn As New OdbcConnection("dsn=ODBC_LIBRERIA_CASA;uid=Admin;pwd=;")

    Private Sub btnleggi_Click(sender As System.Object, e As System.EventArgs) Handles btnleggi.Click

        DBConn.Open()

        Dim DBCommand As OdbcCommand = DBConn.CreateCommand
        DBCommand.CommandType = CommandType.Text
        DBCommand.CommandText = "Select count(*) FROM Libri;"
        Dim num As Integer = DBCommand.ExecuteScalar()

        DBCommand.CommandText = "Select Libri.Titolo, Libri.Autore, Libri.Casa_editrice, Copie.In_prestito FROM Libri INNER JOIN Copie ON Libri.Titolo=Copie.Titolo;"
        Dim letto As OdbcDataReader
        letto = DBCommand.ExecuteReader()

        While (letto.Read())

            dgvlettura.Rows.Add()
            dgvlettura.Rows(dgvlettura.Rows.Count - 1).Cells(0).Value = letto(0)
            dgvlettura.Rows(dgvlettura.Rows.Count - 1).Cells(1).Value = letto(1)
            dgvlettura.Rows(dgvlettura.Rows.Count - 1).Cells(2).Value = letto(2)
            dgvlettura.Rows(dgvlettura.Rows.Count - 1).Cells(3).Value = letto(3)

        End While
        MsgBox(num)
        DBConn.Close()


    End Sub
End Class
