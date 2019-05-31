Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public query As String
    Public cmd As SqlCommand


    Sub njir()
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=HANIIFA-PC;Initial Catalog=simulasiujikom;Integrated Security=True"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("Berhasil :)")
            End If
        Catch ex As Exception
            MsgBox("Gagal")
        End Try
    End Sub

End Module
