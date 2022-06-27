Imports System.Data.OleDb
Module Mdkoneksi

    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dt As DataTable
    Public find As Boolean

    Public koneksi As New OleDbConnection(" provider=microsoft.ace.oledb.12.0; data source=db_20304005.accdb ")

    Sub konek()

        Try
            koneksi.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub diskonek()
        koneksi.Close()
    End Sub
End Module
