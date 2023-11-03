Imports System.Data.OleDb
Module modulKoneksi
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public dgv As New DataGridView

    Public Sub koneksi()
        conn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data source=c:\User\hp\Desktop\TUGAS RPLG\Database\dbsale.accdb")
        conn.Open()
    End Sub
End Module
