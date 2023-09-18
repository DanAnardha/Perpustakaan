Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Rd As OleDbDataReader
    Public Cmd As OleDbCommand
    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "provider=microsoft.Ace.oledb.12.0;data source=DB_Perpustakaan.mdb"
        Conn = New OleDbConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
