Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Public Class FormTransaksiPeminjaman
    Sub KondisiAwal()
        Call NomorOtomatis()
        Call MunculKodeAnggota()
        LBLNama.Text = ""
        LBLAlamat.Text = ""
        LBLJudul.Text = ""
        Label17.Text = ""
        LBLPengarang.Text = ""
        LBLTahun.Text = ""
        LBLTotalBuku.Text = "0"
        ComboBox1.Text = ""
        LBLPinjamanSekarang.Text = "0"
        TextBox1.Text = ""
        TextBox3.Enabled = False
        PictureBox1.Image = Nothing
        DataGridView1.Rows.Clear()
        LBLPernahPinjam.Text = "0"
        Call BuatKolom()
    End Sub
    Private Sub FormTransaksiPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        LBLTanggal.Text = Format(Today, "dd MMMM yyyy")
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point)
        DataGridView2.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point)
        LBLTanggalKembali.Text = Today.AddDays(HalamanUtama.STLabel16.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub
    Sub NomorOtomatis()
          Cmd = New OleDbCommand("select NoPinjam from TBL_PEMINJAMAN order by NoPinjam desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            LBLNoPinjam.Text = "PJM" + Format(Today, "yyMMdd") + "001"
        Else
            LBLNoPinjam.Text = "PJM" + Format(Today, "yyMMdd") + Format(Microsoft.VisualBasic.Right(Rd.Item("NoPinjam"), 3) + 1, "000")
        End If
    End Sub
    Sub MunculKodeAnggota()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OleDbCommand("select * from TBL_ANGGOTA", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OleDbCommand("select * from TBL_ANGGOTA where KodeAnggota = '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNama.Text = Rd("NamaAnggota")
            LBLAlamat.Text = Rd("AlamatAnggota")
        End If
        'Da = New OleDbDataAdapter("select TBL_DETAILPEMINJAMAN.NoPinjam, DETAIL_PEMINJAMAN.KodeBuku, TBL_BUKU.JudulBuku, PengarangBuku, PenerbitBuku from TBL_DETAILPEMINJAMAN, TBL_PEMINJAMAN, TBL_BUKU where TBL_DETAILPEMINJAMAN.NoPinjam=TBL_PEMINJAMAN.NoPinjam and TBL_BUKU.KodeBuku=TBL_DETAILPEMINJAMAN.KodeBuku and TBL_PEMINJAMAN.KodeAnggota='" & ComboBox1.Text & "' and TBL_DETAILPEMINJAMAN.Status='Dipinjam'", Conn)
        Da = New OleDbDataAdapter("select KodeBuku, JudulBuku, JumlahBuku, Pengarang, Status from TBL_DETAILPEMINJAMAN where KodeAnggota='" & ComboBox1.Text & "' and Status='Dipinjam'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView2.DataSource = Ds.Tables(0)
        DataGridView2.ReadOnly = True
        DataGridView2.AllowUserToAddRows = False
        'LBLPernahPinjam.Text = DataGridView2.Rows.Count - 2
        Dim HitungItem As Integer
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            HitungItem = HitungItem + DataGridView2.Rows(i).Cells(2).Value
            LBLPernahPinjam.Text = HitungItem
        Next
        If DataGridView2.Rows.Count = 0 Then
            LBLPernahPinjam.Text = 0
        End If
    End Sub
    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Buku")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Pengarang", "Pengarang")
        DataGridView1.Columns.Add("Penerbit", "Penerbit")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OleDbCommand("select * from TBL_BUKU where KodeBuku='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Buku Tidak Ada!")
            Else
                TextBox1.Text = Rd.Item("KodeBuku")
                LBLJudul.Text = Rd.Item("JudulBuku")
                LBLPengarang.Text = Rd.Item("PengarangBuku")
                LBLTahun.Text = Rd.Item("TahunBuku")
                TextBox3.Text = Rd.Item("Gambar")
                Label17.Text = Rd.Item("JumlahBuku")
                PictureBox1.Load(TextBox3.Text)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                TextBox2.Enabled = True
                TextBox2.Text = "1"
            End If
        End If
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox2.Text) > Val(Label17.Text) Then
            MsgBox("Jumlah Buku Yang Dipinjam Melebihi Jumlah Stok Buku!")
        Else
            If TextBox2.Text = "0" Or TextBox2.Text = "" Then
                MsgBox("Masukkan Jumlah Buku!")
            Else
                If Label17.Text = "0" Then
                    MsgBox("Stok Buku Sudah Habis")
                Else
                    If Val(LBLTotalBuku.Text) > Val(HalamanUtama.STLabel12.Text) Or Val(LBLTotalBuku.Text) + Val(TextBox2.Text) > Val(HalamanUtama.STLabel12.Text) Then
                        MsgBox("Buku Yang Dipinjam Melebihi Batas Maksimal!")
                    Else
                        If LBLJudul.Text = "" Or TextBox2.Text = "" Then
                            MsgBox("Silakan Masukkan Kode Buku dan Tekan Enter!")
                        Else
                            For i As Integer = Val(TextBox2.Text) To 1 Step -1
                                DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLJudul.Text, LBLPengarang.Text, LBLTahun.Text, "1"})
                            Next
                            Label17.Text = ""
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                            LBLJudul.Text = ""
                            LBLPengarang.Text = ""
                            LBLTahun.Text = ""
                            PictureBox1.Image = Nothing

                            Call TotalBuku()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub TotalBuku()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(4).Value
            LBLPinjamanSekarang.Text = HitungItem
            LBLTotalBuku.Text = Val(LBLPinjamanSekarang.Text) + Val(LBLPernahPinjam.Text)
        Next
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LBLNama.Text = "" Or LBLTotalBuku.Text = "0" Or LBLPinjamanSekarang.Text = "0" Then
            MsgBox("Transaksi Tidak Ada, Silakan Melakukan Transaksi Terlebih Dahulu!")
        Else
            Call Koneksi()
            Dim tgldb As String
            tgldb = Format(Today, "yyyy-MM-dd")
            Dim PinjamBuku As String = "insert into TBL_PEMINJAMAN values ('" & LBLNoPinjam.Text & "','" & tgldb & "','" & LBLJam.Text & "','" & ComboBox1.Text & "','" & LBLTotalBuku.Text & "','" & LBLTotalBuku.Text & "','" & HalamanUtama.STLabel2.Text & "','" & LBLTanggalKembali.Text & "','" & LBLNama.Text & "')"
            Cmd = New OleDbCommand(PinjamBuku, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "insert into TBL_DETAILPEMINJAMAN values('" & LBLNoPinjam.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(1).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & Label15.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OleDbCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Call Koneksi()
                Cmd = New OleDbCommand("select * from TBL_BUKU where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call Koneksi()
                Dim KurangiStok As String = "update TBL_BUKU set JumlahBuku='" & Rd.Item("JumlahBuku") - DataGridView1.Rows(Baris).Cells(4).Value & "'where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New OleDbCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()
            Next

            If MessageBox.Show("Cetak Bukti Peminjaman?", "Cetak Bukti", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                'AxCrystalReport1.SelectionFormula = "totext ({TBL_PEMINJAMAN.NoPinjam}) = '" & LBLNoPinjam.Text & "'"
                'AxCrystalReport1.ReportFileName = "NotaPeminjaman.rpt"
                'AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                'AxCrystalReport1.RetrieveDataFiles()
                'AxCrystalReport1.Action = 0
                NotaPeminjaman.Show()
                Call KondisiAwal()
            Else
                Call KondisiAwal()
                MsgBox("Transaksi Berhasil Disimpan!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FormCariDataBuku.ShowDialog()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FormCariDataAnggota.ShowDialog()
        Da = New OleDbDataAdapter("select KodeBuku, JudulBuku, JumlahBuku, Pengarang, Status from TBL_DETAILPEMINJAMAN where KodeAnggota='" & ComboBox1.Text & "' and Status='Dipinjam'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView2.DataSource = Ds.Tables(0)
        DataGridView2.ReadOnly = True
        'LBLPernahPinjam.Text = DataGridView2.Rows.Count - 2
        Dim HitungItem As Integer
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            HitungItem = HitungItem + DataGridView2.Rows(i).Cells(2).Value
            LBLPernahPinjam.Text = HitungItem
        Next
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            LBLPinjamanSekarang.Text = DataGridView1.RowCount - 1
            LBLTotalBuku.Text = Val(LBLPernahPinjam.Text) + Val(LBLPinjamanSekarang.Text)
        End If
    End Sub
End Class