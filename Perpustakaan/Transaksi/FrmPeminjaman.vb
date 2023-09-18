Public Class FrmPeminjaman
    Private nisn As New AutoCompleteStringCollection()
    Private kode_buku As New AutoCompleteStringCollection()
    Dim hari As Integer
    Dim kodepeminjaman As Integer
    Dim jumlah As String
    Dim jumlah_pinjam As Integer
    Public Sub tampilkan_data()
        da_peminjaman = New OleDb.OleDbDataAdapter _
            ("select * from tb_peminjaman_temp", conperpus)
        con_da_peminjaman()
        DataGridView1.DataSource = tb_peminjaman
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "KODE BUKU"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "JUDUL"
            .Columns(1).Width = 250
            .Columns(2).HeaderText = "PENGARANG"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "PENERBIT"
            .Columns(3).Width = 200
        End With
    End Sub
    Public Sub bersihkan_buku()
        txtkodebuku.Clear()
        txtjudulbuku.Clear()
        txtpengarang.Clear()
        txtpenerbit.Clear()
        dtptahunterbit.Clear()
        txtkodebuku.Focus()
    End Sub
    Public Sub bersihkan_semua()
        txtkodebuku.Clear()
        txtjudulbuku.Clear()
        txtpengarang.Clear()
        txtpenerbit.Clear()
        dtptahunterbit.Text = Now
        txtnisn.Clear()
        txtnamasiswa.Clear()
        txtnisn.Focus()
    End Sub
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
        txtnisn.AutoCompleteMode = AutoCompleteMode.Suggest
        txtnisn.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtnisn.AutoCompleteCustomSource = nisn
    End Sub
    Private Sub buku_auto()
        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=perpus.accdb")
        Dim cmd As New OleDb.OleDbCommand("select * from tb_buku where stok<>0", conn)
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
    Private Sub kode_otomatis()
        cmdperpus = New OleDb.OleDbCommand _
        ("select * from nomor", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        While dtrperpus.Read
            kodepeminjaman = dtrperpus("kode") + 1
        End While
        lblkodepeminjaman.Text = "PERPUS-MAN-LABOR-JBI-" & Format(Now, "MM.yy.") & Format(kodepeminjaman, "0000000")

    End Sub

    Private Sub FrmPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kode_otomatis()
        'nisn_auto()
        'buku_auto()
        cmdperpus = New OleDb.OleDbCommand _
            ("select * from keterlambatan", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            While dtrperpus.Read
                hari = dtrperpus("hari")
            End While
            DateTimePicker2.Text = Format(System.DateTime.FromOADate(Today.ToOADate + hari))
        End If
        tampilkan_data()
        jumlah_pinjam = 1
    End Sub
    Private Sub TextBoxX4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            ButtonX2.Focus()
        ElseIf Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("select count(kode_buku) as jumlah_pinjam from tb_peminjaman_temp", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            While dtrperpus.Read
                jumlah = dtrperpus("jumlah_pinjam")
            End While
            If jumlah >= 2 Then
                MsgBox("Jumlah pinjam maksimal 3 buku", MsgBoxStyle.Exclamation, "jumlah")
                bersihkan_buku()
            Else
                cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_peminjaman_temp where kode_buku='" & txtkodebuku.Text & "'", conperpus)
                dtrperpus = cmdperpus.ExecuteReader
                If dtrperpus.HasRows Then
                    MsgBox("Data buku sudah ada dalam keranjang", MsgBoxStyle.Exclamation, "sudah ada")
                    bersihkan_buku()
                ElseIf Trim(txtnisn.Text) = "" Then
                    ErrorProvider1.SetError(txtnisn, "NISN harus diisi")
                ElseIf Trim(txtnamasiswa.Text) = "" Then
                    ErrorProvider1.SetError(txtnamasiswa, "Nama siswa harus diisi")
                ElseIf Trim(txtkodebuku.Text) = "" Then
                    ErrorProvider1.SetError(txtkodebuku, "Kode buku harus diisi")
                ElseIf Trim(txtjudulbuku.Text) = "" Then
                    ErrorProvider1.SetError(txtjudulbuku, "Judul buku harus diisi")
                Else
                    cmdperpus = New OleDb.OleDbCommand _
                        ("insert into tb_peminjaman_temp " & _
                         "values('" & txtkodebuku.Text & "', " & _
                         "'" & txtjudulbuku.Text & "', " & _
                         "'" & txtpengarang.Text & "', " &
                          "'" & txtpenerbit.Text & "', " & _
                         "'" & jumlah_pinjam & "')", conperpus)
                    cmdperpus.ExecuteNonQuery()
                    bersihkan_buku()
                    tampilkan_data()
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            txtkodebuku.Text = .SelectedCells(0).Value
            txtjudulbuku.Text = .SelectedCells(1).Value
            'txtjumlahPinjam.Text = .SelectedCells(4).Value
            'txtjumlahpinjam.Text = .SelectedCells(2).Value
            cmdperpus = New OleDb.OleDbCommand _
                ("select * from tb_buku where kode_buku='" & txtkodebuku.Text & "'", conperpus)
            dtrperpus = cmdperpus.ExecuteReader
            If dtrperpus.HasRows Then
                While dtrperpus.Read
                    txtpengarang.Text = dtrperpus("pengarang")
                    txtpenerbit.Text = dtrperpus("penerbit")
                    dtptahunterbit.Text = dtrperpus("thn_terbit")
                End While
                'txtkodebuku.ReadOnly = True
                txtjudulbuku.ReadOnly = True
                tampilkan_data()
            End If
        End With
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If Trim(txtkodebuku.Text) = "" Then
            ErrorProvider1.SetError(txtkodebuku, "Kode buku kosong")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("update tb_peminjaman_temp set " & _
                 "judul='" & txtjudulbuku.Text & "', " & _
                 "pengarang='" & txtpengarang.Text & "', " & _
                 "penerbit='" & txtpenerbit.Text & "', " & _
                 "jumlah='" & jumlah_pinjam & "' where " & _
                 "kode_buku='" & txtkodebuku.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            bersihkan_buku()
            txtjudulbuku.ReadOnly = False
            txtkodebuku.ReadOnly = False
            tampilkan_data()
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If Trim(txtkodebuku.Text) = "" Then
            ErrorProvider1.SetError(txtkodebuku, "Kode buku kosong")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("delete from tb_peminjaman_temp where kode_buku='" & txtkodebuku.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            bersihkan_buku()
            txtjudulbuku.ReadOnly = False
            txtkodebuku.ReadOnly = False
            tampilkan_data()
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        da_peminjaman = New OleDb.OleDbDataAdapter _
          ("select * from tb_peminjaman_temp where kode_buku like '%" & Trim(txtcari.Text) & _
               "%' or judul like '%" & Trim(txtcari.Text) & _
               "%' or jumlah like '%" & Trim(txtcari.Text) & "%'", conperpus)
        con_da_peminjaman()
    End Sub
    Private Sub txtnamasiswa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        cmdperpus = New OleDb.OleDbCommand _
        ("select * from tb_peminjaman where kode_peminjaman='" & lblkodepeminjaman.Text & "'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        If Trim(txtnisn.Text) = "" Then
            MsgBox("NISN masih kosong..", MsgBoxStyle.Critical, "pesan")
            txtnisn.Focus()
        ElseIf dtrperpus.HasRows Then
            MsgBox("Kode Peminjaman sudah ada..?", MsgBoxStyle.Critical, "pesan")
            txtnisn.Focus()
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("select * from tb_peminjaman_temp", conperpus)
            dtrperpus = cmdperpus.ExecuteReader
            If dtrperpus.HasRows Then
                'simpan data ke tabel peminjaman
                cmdperpus = New OleDb.OleDbCommand _
                    ("insert into tb_peminjaman " & _
                    "values ('" & lblkodepeminjaman.Text & "', " & _
                    "'" & MenuUtama.lblkodelogin.Text & "', " & _
                    "'" & txtnisn.Text & "', " & _
                    "'" & DateTimePicker1.Text & "', " & _
                    "'" & DateTimePicker2.Text & "')", conperpus)
                cmdperpus.ExecuteNonQuery()

                While dtrperpus.Read
                    'simpan data ke tabel peminjaman detail
                    cmdperpus = New OleDb.OleDbCommand _
                    ("insert into tb_peminjaman_detail(kode_peminjaman,kode_buku,judul,jumlah,status) " & _
                     "values ('" & lblkodepeminjaman.Text & "', " & _
                             "'" & dtrperpus("kode_buku") & "', " & _
                             "'" & dtrperpus("judul") & "', " & _
                             "'" & dtrperpus("jumlah") & "', " & _
                             "'" & "PINJAM" & "')", conperpus)
                    cmdperpus.ExecuteNonQuery()


                    'mengurang stok yang ada di tabel buku
                    cmdperpus = New OleDb.OleDbCommand _
                    ("update tb_buku inner join tb_peminjaman_detail on (tb_buku.kode_buku=tb_peminjaman_detail.kode_buku) " & _
                     "set tb_buku.stok=tb_buku.stok-tb_peminjaman_detail.jumlah " & _
                     "where tb_peminjaman_detail.kode_peminjaman='" & lblkodepeminjaman.Text & "'", conperpus)

                    cmdperpus.ExecuteNonQuery()
                End While

                'menambah nomor otomatis di tabel nomor
                cmdperpus = New OleDb.OleDbCommand _
                ("update nomor set kode='" & kodepeminjaman & "'", conperpus)
                cmdperpus.ExecuteNonQuery()
                MsgBox("Data peminjaman berhasil disimpan", MsgBoxStyle.Information, "berhasil")

                'menghapus data di keranjang
                cmdperpus = New OleDb.OleDbCommand _
                ("delete from tb_peminjaman_temp", conperpus)
                cmdperpus.ExecuteNonQuery()

                con_da_peminjaman()
                bersihkan_semua()
                kode_otomatis()
            Else

                MsgBox("Belum ada data buku yang dipinjam", MsgBoxStyle.Critical, "pilih buku")
                bersihkan_buku()

            End If

        End If
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        bersihkan_buku()
        cmdperpus = New OleDb.OleDbCommand _
            ("delete from tb_peminjaman_temp", conperpus)
        cmdperpus.ExecuteNonQuery()
        bersihkan_buku()
        txtjudulbuku.ReadOnly = False
        txtkodebuku.ReadOnly = False
        tampilkan_data()
    End Sub

    Private Sub txtjumlahPinjam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cek As Integer
        cmdperpus = New OleDb.OleDbCommand _
            ("select stok from tb_buku where kode_buku='" & txtkodebuku.Text & "'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            While dtrperpus.Read
                cek = dtrperpus("stok")
            End While
        End If
        If Val(jumlah_pinjam) > Val(cek) Then
            MsgBox("Stok Buku Dengan Kode " & txtkodebuku.Text & Chr(13) & _
                "Tidak Mencukupi, Jumlah Stok Tersedia " & cek, MsgBoxStyle.Exclamation, "Tidak Cukup")
            bersihkan_buku()
        End If

    End Sub
    Private Sub txtnisn_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnisn.TextChanged
        ErrorProvider1.Clear()
    End Sub
    Private Sub txtkodebuku_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodebuku.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtjumlahPinjam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            ButtonX2.Focus()
        ElseIf Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmdperpus = New OleDb.OleDbCommand _
        '("select * from tb_anggota where nisn='" & txtnisn.Text & "'", conperpus)
        'dtrperpus = cmdperpus.ExecuteReader
        'If dtrperpus.HasRows Then
        'While dtrperpus.Read
        'txtnamasiswa.Text = dtrperpus("nama")
        'End While
        'End If
        FrmCariDataAnggota.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'cmdperpus = New OleDb.OleDbCommand _
        '("select * from tb_buku where kode_buku='" & txtkodebuku.Text & "'", conperpus)
        'dtrperpus = cmdperpus.ExecuteReader
        'If dtrperpus.HasRows Then
        'While dtrperpus.Read
        'txtjudulbuku.Text = dtrperpus("judul")
        'txtpengarang.Text = dtrperpus("pengarang")
        'txtpenerbit.Text = dtrperpus("penerbit")
        'dtptahunterbit.Text = dtrperpus("thn_terbit")
        'End While
        'End If
        FrmCariDataBuku.ShowDialog()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        cmdperpus = New OleDb.OleDbCommand _
        ("select * from tb_peminjaman where kode_peminjaman='" & lblkodepeminjaman.Text & "'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        If Trim(txtnisn.Text) = "" Then
            MsgBox("NISN masih kosong..", MsgBoxStyle.Critical, "pesan")
            txtnisn.Focus()
        ElseIf dtrperpus.HasRows Then
            MsgBox("Kode Peminjaman sudah ada..?", MsgBoxStyle.Critical, "pesan")
            txtnisn.Focus()
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("select * from tb_peminjaman_temp", conperpus)
            dtrperpus = cmdperpus.ExecuteReader
            If dtrperpus.HasRows Then
                'simpan data ke tabel peminjaman
                cmdperpus = New OleDb.OleDbCommand _
                    ("insert into tb_peminjaman " & _
                    "values ('" & lblkodepeminjaman.Text & "', " & _
                    "'" & MenuUtama.lblkodelogin.Text & "', " & _
                    "'" & txtnisn.Text & "', " & _
                    "'" & DateTimePicker1.Text & "', " & _
                    "'" & DateTimePicker2.Text & "')", conperpus)
                cmdperpus.ExecuteNonQuery()

                While dtrperpus.Read
                    'simpan data ke tabel peminjaman detail
                    cmdperpus = New OleDb.OleDbCommand _
                    ("insert into tb_peminjaman_detail(kode_peminjaman,kode_buku,judul,jumlah,status) " & _
                     "values ('" & lblkodepeminjaman.Text & "', " & _
                             "'" & dtrperpus("kode_buku") & "', " & _
                             "'" & dtrperpus("judul") & "', " & _
                             "'" & dtrperpus("jumlah") & "', " & _
                             "'" & "PINJAM" & "')", conperpus)
                    cmdperpus.ExecuteNonQuery()


                    'mengurang stok yang ada di tabel buku
                    cmdperpus = New OleDb.OleDbCommand _
                    ("update tb_buku inner join tb_peminjaman_detail on (tb_buku.kode_buku=tb_peminjaman_detail.kode_buku) " & _
                     "set tb_buku.stok=tb_buku.stok-tb_peminjaman_detail.jumlah " & _
                     "where tb_peminjaman_detail.kode_peminjaman='" & lblkodepeminjaman.Text & "'", conperpus)

                    cmdperpus.ExecuteNonQuery()
                End While

                'menambah nomor otomatis di tabel nomor
                cmdperpus = New OleDb.OleDbCommand _
                ("update nomor set kode='" & kodepeminjaman & "'", conperpus)
                cmdperpus.ExecuteNonQuery()
                MsgBox("Data peminjaman berhasil disimpan", MsgBoxStyle.Information, "berhasil")

                'menghapus data di keranjang
                cmdperpus = New OleDb.OleDbCommand _
                ("delete from tb_peminjaman_temp", conperpus)
                cmdperpus.ExecuteNonQuery()

                con_da_peminjaman()
                bersihkan_semua()
                kode_otomatis()
            Else

                MsgBox("Belum ada data buku yang dipinjam", MsgBoxStyle.Critical, "pilih buku")
                bersihkan_buku()

            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class