Public Class FrmPengembalian
    Dim denda, hargadenda As Integer
    Dim kodekembali As Integer
    Private kode_buku As New AutoCompleteStringCollection()
    Private nisn As New AutoCompleteStringCollection()
    Private Sub nisn_auto()
        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=perpus.accdb")
        Dim cmd As New OleDb.OleDbCommand("select * from tb_anggota", conn)
        conn.Open()
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read()
                nisn.Add(dr("nisn"))
            End While
        Else
            MsgBox("Tidak ada data anggota", MsgBoxStyle.Critical, "kosong")
        End If
        dr.Close()
        txtnis.AutoCompleteMode = AutoCompleteMode.Suggest
        txtnis.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtnis.AutoCompleteCustomSource = nisn
    End Sub
    Private Sub kode_otomatis()
        cmdperpus = New OleDb.OleDbCommand _
        ("select * from nomor", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        While dtrperpus.Read
            kodekembali = dtrperpus("kode") + 1
        End While
        lblkodekembali.Text = "KBL-MAN-LABOR-JBI-" & Format(Now, "MM.yy.") & Format(kodekembali, "0000000")
    End Sub
    Private Sub buku_auto()
        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=perpus.accdb")
        Dim cmd As New OleDb.OleDbCommand("select * from tb_buku", conn)
        conn.Open()
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If dr.HasRows = True Then
            While dr.Read()
                kode_buku.Add(dr("kode_buku"))
            End While
        Else
            MsgBox("Semua buku terpinjam", MsgBoxStyle.Critical, "kosong")
        End If
        dr.Close()
        txtkodebuku.AutoCompleteMode = AutoCompleteMode.Suggest
        txtkodebuku.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtkodebuku.AutoCompleteCustomSource = kode_buku
    End Sub
    Public Sub tampilkan_data()
        da_pengembalian = New OleDb.OleDbDataAdapter _
            ("select * from tb_pengembalian_temp", conperpus)
        con_da_pengembalian()
        DataGridView1.DataSource = tb_pengembalian
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "KODE BUKU"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "JUMLAH KEMBALI"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "JUDUL"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "PENGARANG"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "PENERBIT"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "TGL PINJAM"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = "TGL HARUS KEMBALI"
            .Columns(6).Width = 100
        End With
    End Sub
    Public Sub bersihkan()
        txtkodebuku.Clear()
        txtnamapeminjam.Clear()
        txtjudul.Clear()
        DateTimePicker2.Value = Now
        txtkodebuku.Focus()
    End Sub

    Private Sub FrmPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        buku_auto()
        nisn_auto()
        kode_otomatis()
        tampilkan_data()
    End Sub

    Private Sub txtkodebuku_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then

        End If
    End Sub

    Private Sub txtkodebuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        On Error GoTo bebas
        Dim kode_buku As String
        kode_buku = DataGridView1.SelectedCells(0).Value
        If MsgBox("Apakah buku dengan kode : " & kode_buku & " tidak jadi dikembalikan..?", MsgBoxStyle.Question + _
                  MsgBoxStyle.OkCancel, "Peringatan") = MsgBoxResult.Ok Then
            cmdperpus = New OleDb.OleDbCommand _
            ("delete from tb_pengembalian_temp where kode_buku='" & kode_buku & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            tampilkan_data()
            MsgBox("Buku dengan kode : " & kode_buku & " tidak jadi dikembalikan", MsgBoxStyle.Information, "Pesan")
        Else
            MsgBox("Buku tidak Jadi dihapus", MsgBoxStyle.Information, "Pesan")
        End If
        Exit Sub
bebas:
        MsgBox("Silahkan pilih data yang akan dihapus", MsgBoxStyle.Information, "Pesan")
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        Close()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If MsgBox("Anda yakin ingin membatalkan proses ini..?", MsgBoxStyle.Question + _
        MsgBoxStyle.OkCancel, "Pesan") = MsgBoxResult.Ok Then

            cmdperpus = New OleDb.OleDbCommand _
            ("delete from tb_pengembalian_temp", conperpus)
            cmdperpus.ExecuteNonQuery()
            tampilkan_data()
            bersihkan()
        End If
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Dim tgl1 As Date
        Dim tgl2 As Long
        cmdperpus = New OleDb.OleDbCommand _
        ("select * from tb_pengembalian_temp", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        If Trim(txtjudul.Text) = "" Then
            MsgBox("Silahkan inputkan NIS siswa", MsgBoxStyle.Information, "Pesan")
            Button2.Focus()
        ElseIf dtrperpus.HasRows Then
            cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_pengembalian_temp", conperpus)
            dtrperpus = cmdperpus.ExecuteReader

            'simpan data ke tabel pengembalian
            cmdperpus = New OleDb.OleDbCommand _
                ("insert into tb_pengembalian " & _
                "values ('" & lblkodekembali.Text & "', " & _
                "'" & MenuUtama.lblkodelogin.Text & "', " & _
                "'" & txtnis.Text & "', " & _
                "'" & DateTimePicker1.Text & "', " & _
                "'" & denda & "')", conperpus)
            cmdperpus.ExecuteNonQuery()

            'simpan data ke tabel pengembalian detail
            While dtrperpus.Read
                tgl1 = dtrperpus("tgl_harus_kembali")
                tgl2 = DateDiff(DateInterval.Day, tgl1, DateTimePicker1.Value)
                If tgl2 < 0 Then
                    tgl2 = 0
                End If

                cmdperpus = New OleDb.OleDbCommand _
                ("insert into tb_pengembalian_detail(kode_kembali,kode_buku,judul,jumlah,terlambat)" & _
                 "values('" & lblkodekembali.Text & "'," & _
                        "'" & dtrperpus("kode_buku") & "'," & _
                        "'" & dtrperpus("judul") & "'," & _
                        "'" & dtrperpus("jumlah") & "'," & _
                        "'" & (tgl2 & " Hari") & "')", conperpus)
                cmdperpus.ExecuteNonQuery()

                'mengembalikan stok yang ada di tabel buku
                cmdperpus = New OleDb.OleDbCommand _
                ("update tb_buku inner join tb_pengembalian_detail on (tb_buku.kode_buku=tb_pengembalian_detail.kode_buku) " & _
                 "set tb_buku.stok=tb_buku.stok+tb_pengembalian_detail.jumlah " & _
                 "where tb_pengembalian_detail.kode_kembali='" & lblkodekembali.Text & "'", conperpus)

                cmdperpus.ExecuteNonQuery()

                cmdperpus = New OleDb.OleDbCommand _
                ("update tb_peminjaman_detail set status='KEMBALI', jumlah=0 where kode_buku='" & dtrperpus("kode_buku") & "'", conperpus)
                cmdperpus.ExecuteNonQuery()
            End While

            cmdperpus = New OleDb.OleDbCommand _
            ("update nomor set kode='" & kodekembali & "'", conperpus)
            cmdperpus.ExecuteNonQuery()

            MsgBox("Data pengembalian berhasil disimpan", MsgBoxStyle.Information, "Pesan")

            cmdperpus = New OleDb.OleDbCommand _
            ("delete from tb_pengembalian_temp", conperpus)
            cmdperpus.ExecuteNonQuery()
            tampilkan_data()
            bersihkan()
            kode_otomatis()
        Else
            MsgBox("Silahkan pilih data buku yang akan dikembalikan", MsgBoxStyle.Information, "Pesan")
            Button2.Focus()
        End If
    End Sub

    Private Sub ButtonX1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_peminjaman_detail where kode_buku='" & txtkodebuku.Text & "' and status='PINJAM'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If Trim(txtkodebuku.Text) = "" Then
            ErrorProvider1.SetError(txtkodebuku, "Kode buku kosong")
        ElseIf Trim(txtnamapeminjam.Text) = "" Then
            ErrorProvider1.SetError(txtnamapeminjam, "NISN dan nama masih kosong")
        ElseIf dtrperpus.HasRows Then
            cmdperpus = New OleDb.OleDbCommand _
                ("SELECT tb_peminjaman.kode_peminjaman, tb_peminjaman.nisn, tb_peminjaman.tgl_pinjam, " & _
                 "tb_peminjaman.tgl_kembali, tb_peminjaman_detail.kode_buku, tb_peminjaman_detail.judul, " & _
                 "tb_peminjaman_detail.jumlah, tb_peminjaman_detail.status, tb_buku.pengarang, tb_buku.penerbit, tb_anggota.nama " & _
                 "FROM tb_anggota INNER JOIN ((tb_peminjaman INNER JOIN tb_peminjaman_detail " & _
                 "ON tb_peminjaman.kode_peminjaman = tb_peminjaman_detail.kode_peminjaman) INNER JOIN " & _
                 "tb_buku ON tb_peminjaman_detail.kode_buku = tb_buku.kode_buku) ON (tb_peminjaman.nisn = tb_anggota.nisn) " & _
                 "AND (tb_anggota.nisn = tb_peminjaman.nisn) where tb_peminjaman_detail.kode_buku='" & txtkodebuku.Text & "' and  tb_peminjaman_detail.status='PINJAM' and tb_peminjaman.nisn='" & txtnis.Text & "'", conperpus)
            dtrperpus = cmdperpus.ExecuteReader
            If dtrperpus.HasRows Then
                While dtrperpus.Read
                    txtjudul.Text = dtrperpus("judul")
                    DateTimePicker2.Value = dtrperpus("tgl_kembali")
                    cmdperpus = New OleDb.OleDbCommand _
                    ("insert into tb_pengembalian_temp(kode_buku,jumlah,judul,pengarang,penerbit,tgl_pinjam,tgl_harus_kembali)" & _
                    "values('" & dtrperpus("kode_buku") & "'," & _
                        "'" & dtrperpus("jumlah") & "'," & _
                        "'" & dtrperpus("judul") & "'," & _
                        "'" & dtrperpus("pengarang") & "'," & _
                        "'" & dtrperpus("penerbit") & "'," & _
                        "'" & dtrperpus("tgl_pinjam") & "'," & _
                        "'" & dtrperpus("tgl_kembali") & "')", conperpus)
                    cmdperpus.ExecuteNonQuery()
                    con_da_pengembalian()
                    txtkodebuku.Clear()
                    txtkodebuku.Focus()
                End While
            Else
                MsgBox("siswa ini tidak meminjam buku dengan kode buku " & txtkodebuku.Text, MsgBoxStyle.Exclamation, "pesan")
                txtkodebuku.Clear()
            End If
        Else
            MsgBox("Tidak ada data peminjaman buku dengan kode " & txtkodebuku.Text, MsgBoxStyle.Critical, "tidak ada")
            txtkodebuku.Clear()
            txtkodebuku.Focus()
        End If
        ButtonX3_Click_1(sender, AcceptButton)
    End Sub

    Private Sub ButtonX3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Dim jumlah_buku As Integer
        Dim tgl1 As Date
        Dim tgl2 As Long

        cmdperpus = New OleDb.OleDbCommand _
            ("select * from denda", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            While dtrperpus.Read
                hargadenda = dtrperpus("nominal")
            End While

            cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_pengembalian_temp", conperpus)
            dtrperpus = cmdperpus.ExecuteReader

            If dtrperpus.HasRows Then
                While dtrperpus.Read
                    cmdperpus = New OleDb.OleDbCommand _
                    ("select count (*) from tb_pengembalian_temp", conperpus)
                    jumlah_buku = cmdperpus.ExecuteScalar
                    tgl1 = dtrperpus("tgl_harus_kembali")
                    tgl2 = DateDiff(DateInterval.Day, tgl1, DateTimePicker1.Value)

                    If tgl2 <= 0 Then
                        denda = 0
                    Else
                        denda = (tgl2 * hargadenda) * jumlah_buku
                        'MsgBox("Anda Terlambat Mengembalikan Buku " & tgl2 & " Hari", MsgBoxStyle.Critical, "terlambat")
                    End If
                    txt_denda.Text = "Rp." & denda
                End While
            End If
        End If
    End Sub
    Private Sub TextBoxX1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnis.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtnamapeminjam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnamapeminjam.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("SELECT tb_peminjaman.*, tb_peminjaman_detail.status, tb_anggota.nama " & _
            "FROM (tb_anggota INNER JOIN tb_peminjaman ON tb_anggota.nisn = tb_peminjaman.nisn) INNER JOIN tb_peminjaman_detail ON tb_peminjaman.kode_peminjaman = tb_peminjaman_detail.kode_peminjaman where " & _
            "tb_peminjaman_detail.status<>'KEMBALI' AND tb_peminjaman.nisn='" & txtnis.Text & "'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            While dtrperpus.Read
                txtnamapeminjam.Text = dtrperpus("nama")
            End While
        Else
            MsgBox("tidak ada buku yang dipinjam oleh siswa ini", MsgBoxStyle.Exclamation, "pesan")
            txtnis.Clear()
        End If
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub txtkodebuku_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodebuku.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_peminjaman_detail where kode_buku='" & txtkodebuku.Text & "' and status='PINJAM'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If Trim(txtkodebuku.Text) = "" Then
            ErrorProvider1.SetError(txtkodebuku, "Kode buku kosong")
        ElseIf Trim(txtnamapeminjam.Text) = "" Then
            ErrorProvider1.SetError(txtnamapeminjam, "NISN dan nama masih kosong")
        ElseIf dtrperpus.HasRows Then
            cmdperpus = New OleDb.OleDbCommand _
                ("SELECT tb_peminjaman.kode_peminjaman, tb_peminjaman.nisn, tb_peminjaman.tgl_pinjam, " & _
                 "tb_peminjaman.tgl_kembali, tb_peminjaman_detail.kode_buku, tb_peminjaman_detail.judul, " & _
                 "tb_peminjaman_detail.jumlah, tb_peminjaman_detail.status, tb_buku.pengarang, tb_buku.penerbit, tb_anggota.nama " & _
                 "FROM tb_anggota INNER JOIN ((tb_peminjaman INNER JOIN tb_peminjaman_detail " & _
                 "ON tb_peminjaman.kode_peminjaman = tb_peminjaman_detail.kode_peminjaman) INNER JOIN " & _
                 "tb_buku ON tb_peminjaman_detail.kode_buku = tb_buku.kode_buku) ON (tb_peminjaman.nisn = tb_anggota.nisn) " & _
                 "AND (tb_anggota.nisn = tb_peminjaman.nisn) where tb_peminjaman_detail.kode_buku='" & txtkodebuku.Text & "' and  tb_peminjaman_detail.status='PINJAM' and tb_peminjaman.nisn='" & txtnis.Text & "'", conperpus)
            dtrperpus = cmdperpus.ExecuteReader
            If dtrperpus.HasRows Then
                While dtrperpus.Read
                    txtjudul.Text = dtrperpus("judul")
                    DateTimePicker2.Value = dtrperpus("tgl_kembali")
                    cmdperpus = New OleDb.OleDbCommand _
                    ("insert into tb_pengembalian_temp(kode_buku,jumlah,judul,pengarang,penerbit,tgl_pinjam,tgl_harus_kembali)" & _
                    "values('" & dtrperpus("kode_buku") & "'," & _
                        "'" & dtrperpus("jumlah") & "'," & _
                        "'" & dtrperpus("judul") & "'," & _
                        "'" & dtrperpus("pengarang") & "'," & _
                        "'" & dtrperpus("penerbit") & "'," & _
                        "'" & dtrperpus("tgl_pinjam") & "'," & _
                        "'" & dtrperpus("tgl_kembali") & "')", conperpus)
                    cmdperpus.ExecuteNonQuery()
                    con_da_pengembalian()
                    txtkodebuku.Clear()
                    txtkodebuku.Focus()
                End While
            Else
                MsgBox("siswa ini tidak meminjam buku dengan kode buku " & txtkodebuku.Text, MsgBoxStyle.Exclamation, "pesan")
                txtkodebuku.Clear()
            End If
        Else
            MsgBox("Tidak ada data peminjaman buku dengan kode " & txtkodebuku.Text, MsgBoxStyle.Critical, "tidak ada")
            txtkodebuku.Clear()
            txtkodebuku.Focus()
        End If
        ButtonX3_Click_1(sender, AcceptButton)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class