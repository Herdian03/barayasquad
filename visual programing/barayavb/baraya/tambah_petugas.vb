Imports MySql.Data.MySqlClient
Imports baraya.koneksi

Public Class tambah_petugas

    Sub bersih()
        tbnip.Clear()
        tbnamapetugas.Clear()
        tbpassword.Clear()
        cbjeniskelamin.Text = ""
        btntambah.Text = "tambah"
    End Sub

    Private Sub statusinput(nip As Boolean, nama_petugas As Boolean, password As Boolean, jenis_kelamin As Boolean)
        tbnip.Enabled = nip
        tbnamapetugas.Enabled = nama_petugas
        tbpassword.Enabled = password
        cbjeniskelamin.Enabled = jenis_kelamin
    End Sub
    Private Sub statustombol(tambah As Boolean, edit As Boolean, hapus As Boolean)
        btntambah.Enabled = tambah
        btnedit.Enabled = edit
        btnhapus.Enabled = hapus
    End Sub
    Private Sub tampildata()
        Dim dt As DataTable
        Dim adapter As MySqlDataAdapter
        Dim query As String
        Dim data As Integer

        query = "select nip, nama_petugas, password, jenis_kelamin from petugas"
        adapter = New MySqlDataAdapter(query, conn)
        dt = New DataTable
        data = adapter.Fill(dt)
        If data > 0 Then
            tabelpetugas.DataSource = dt
            tabelpetugas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            tabelpetugas.Columns(0).HeaderText = "nip"
            tabelpetugas.Columns(1).HeaderText = "nama_petugas"
            tabelpetugas.Columns(2).HeaderText = "password"
            tabelpetugas.Columns(3).HeaderText = "jenis_kelamin"
        Else
            tabelpetugas.DataSource = Nothing
        End If
    End Sub
    Private Sub tambah_petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksibuka()
        tampildata()
        statusinput(False, False, False, False)
        statustombol(True, False, False)


    End Sub


    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        statusinput(True, True, True, True)
        statustombol(True, True, True)
        btntambah.Text = "simpan"
        btnhapus.Text = "batal"
        If tbnip.Text = "" Then
            MsgBox("NIP Harus DI isi !!")
            tbnip.Focus()
            Exit Sub
        End If
        If tbnamapetugas.Text = "" Then
            MsgBox("Nama Petugas Harus Di Isi")
            tbnamapetugas.Focus()
            Exit Sub
        End If
        If tbpassword.Text = "" Then
            MsgBox("Password Wajib Di isi")
            tbpassword.Focus()
            Exit Sub
        End If
        If cbjeniskelamin.Text = "" Then
            MsgBox("Jenis Kelamin Wajib DI Pilih")
            cbjeniskelamin.Focus()
            Exit Sub
        End If
        Try
            Dim qinsert As String
            qinsert = "insert into petugas(nip, nama_petugas, password, jenis_kelamin)"
            qinsert = qinsert & "values('" & tbnip.Text & "', '" & tbnamapetugas.Text & "', '" & tbpassword.Text & "', '" & cbjeniskelamin.Text & "')"
            cmd.CommandType = CommandType.Text
            cmd.CommandText = qinsert
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Data Petugas Berhasil DIsimpan")
            Call tampildata()
            bersih()

        Catch ex As Exception
            MsgBox("Data Gagal Tersimpan" & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tabelpetugas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelpetugas.CellClick
        Dim i As Integer
        i = Me.tabelpetugas.CurrentRow.Index
        MsgBox("baris ke :" & i.ToString)
        With tabelpetugas.Rows.Item(i)
            tbnip.Text = .Cells(0).Value
            tbnamapetugas.Text = .Cells(1).Value
            tbpassword.Text = .Cells(2).Value
            cbjeniskelamin.Text = .Cells(3).Value

        End With
        statustombol(True, True, True)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If btnhapus.Text = "hapus" Then
            Dim yakinhapus As MsgBoxResult = MessageBox.Show("Yakin Mau dihapus", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If yakinhapus = vbYes Then
                Try
                    'Dim qdelete As String
                    'qdelete = "delete from jurusan where kode_jurusan='" & tbkodejurusan.Text & "'"
                    'cmd.CommandType = CommandType.Text
                    'cmd.Connection = conn
                    'cmd.ExecuteNonQuery()
                    'cmd.CommandText = "delete from jurusan where kode_jurusan='" & tbkodejurusan.Text & "'"
                    'Call tampildata()
                    cmd.Connection = conn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "delete from petugas where nip='" & tbnip.Text & "'"
                    cmd.ExecuteNonQuery()
                    MsgBox("data Telah dihapus")
                    Call tampildata()
                Catch ex As Exception
                    MsgBox("Gagal Hapus Data")
                End Try
            End If
        End If

        If btnhapus.Text = "batal" Then
            btnhapus.Text = "hapus"
            btntambah.Text = "tambah"
            statusinput(False, False, False, False)

            statustombol(True, False, False)
            'bersih()
        End If
        bersih()

    End Sub
End Class