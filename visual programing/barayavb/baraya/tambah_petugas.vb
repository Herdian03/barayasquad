Imports MySql.Data.MySqlClient
Imports baraya.koneksi

Public Class tambah_petugas
    Dim e As String

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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If btnedit.Text = "edit" Then
            btnedit.Text = "simpan"
            btnhapus.Text = "batal"
            btntambah.Enabled = False
            btnhapus.Enabled = False
            tbnip.Enabled = False
            tbnamapetugas.Enabled = True
            tbpassword.Enabled = True
            cbjeniskelamin.Enabled = True
        ElseIf btnedit.Text = "simpan" Then
            Try
                Dim qupdate As String
                qupdate = "update petugas set nama_petugas='" & tbnamapetugas.Text & "', password='" & tbpassword.Text & "', jenis_kelamin='" & cbjeniskelamin.Text & "' where nip='" & tbnip.Text & "'"
                cmd.CommandType = CommandType.Text
                cmd.CommandText = qupdate
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil Di Rubah", MsgBoxStyle.Information, "Informasi")
                statusinput(False, False, False, False)
                statustombol(True, False, False)
                tampildata()
                btnedit.Text = "edit"
            Catch ex As Exception
                MsgBox("ubah data gagal", MsgBoxStyle.Critical, "Warning")
            End Try
        End If
    End Sub

    Private Sub tbpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpassword.KeyPress
        'syntax ketika enter langsung lajut ke textbox selanjutnya
        If Asc(e.KeyChar) = 13 Then
            cbjeniskelamin.Focus()
        End If
    End Sub

    Private Sub tbpassword_TextChanged(sender As Object, e As EventArgs) Handles tbpassword.TextChanged

    End Sub

    Private Sub tabelpetugas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelpetugas.CellContentClick

    End Sub

    Private Sub tabelpetugas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles tabelpetugas.CellFormatting
        'ini cara menampilkan password char di data gridview
        If (e.ColumnIndex <> -1 AndAlso tabelpetugas.Columns(e.ColumnIndex).Name = "password") Then
            If (Not e.Value Is Nothing) Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub tbnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnip.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbnamapetugas.Focus()
        End If
    End Sub

    Private Sub tbnamapetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbnamapetugas.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbpassword.Focus()
        End If
    End Sub

    Private Sub tbnamapetugas_TextChanged(sender As Object, e As EventArgs) Handles tbnamapetugas.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim yakinhapus1 As MsgBoxResult = MessageBox.Show("Yakin Mau Keluar BEB ??", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If yakinhapus1 = vbYes Then
            Try
                Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbcari_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class