Imports MySql.Data.MySqlClient
Module koneksi

    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public MySQLReader As MySqlDataReader
    Public da As New MySqlDataAdapter

    Public Sub koneksibuka()
        If conn.State = ConnectionState.Closed Then
            Dim mystring As String
            mystring = "server=localhost;user=root;password=;database=ticket"
            Try
                conn.ConnectionString = mystring
                conn.Open()
                MsgBox("Berhasil Connect Ke database", MsgBoxStyle.Critical, "Succesed")
            Catch ex As Exception
                MsgBox("Koneksi gagal", MsgBoxStyle.OkCancel)
            End Try
        End If
    End Sub

    Public Sub koneksitutup()
        Try
            conn.Clone()

        Catch ex As Exception

        End Try
    End Sub
End Module
