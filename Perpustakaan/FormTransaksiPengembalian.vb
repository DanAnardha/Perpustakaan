Imports System.Data.OleDb
Public Class FormTransaksiPengembalian
    Sub Kosongkan()
        On Error Resume Next
        ComboBox1.Text = ""
        LBLKodeAnggota.Text = ""
        LBLNamaAnggota.Text = ""
        LBLTotalPinjam.Text = ""
        LBLTotalDenda.Text = ""
        TextBox2.Text = 0
        LBLKembali.Text = ""
        DataGridView1.Rows.Clear()
        Label8.Text = ""
        DataGridView2.Columns.Clear()
        TextBox2.Clear()
        PictureBox1.Load(TextBox1.Text)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Sub NomorOtomatis()
        Cmd = New OleDbCommand("select NoKembali from TBL_PENGEMBALIAN order by NoKembali desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            LBLNoPengembalian.Text = "KB" + Format(Today, "yyMMdd") + "001"
        Else
            LBLNoPengembalian.Text = "KB" + Format(Today, "yyMMdd") + Format(Microsoft.VisualBasic.Right(Rd.Item("NoKembali"), 3) + 1, "000")
        End If
    End Sub
    Sub TampilDipinjam()
        Cmd = New OleDbCommand("select distinct NoPinjam from TBL_DETAILPEMINJAMAN where Status='Dipinjam'", Conn)
        Rd = Cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item("NoPinjam"))
        Loop
    End Sub

    Private Sub FormTransaksiPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call NomorOtomatis()
        LBLTanggalKembali.Text = Format(Today, "dd MMMM yyyy")
        Call TampilDipinjam()
        Call Kosongkan()
        TextBox1.Enabled = False
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(7).ReadOnly = True
        DataGridView1.Columns(8).ReadOnly = True
        LBLKembali.Text = ""
        Label5.Text = HalamanUtama.STLabel6.Text
        'DataGridView1.AllowUserToAddRows = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Cmd = New OleDbCommand("select KodeAnggota, NamaAnggota from TBL_PEMINJAMAN where NoPinjam='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLKodeAnggota.Text = Rd.Item("KodeAnggota")
            LBLNamaAnggota.Text = Rd.Item("NamaAnggota")
        End If
        Da = New OleDbDataAdapter("select KodeBuku, JudulBuku, JumlahBuku, Pengarang, Status from TBL_DETAILPEMINJAMAN where NoPinjam='" & ComboBox1.Text & "' and Status='Dipinjam'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView2.DataSource = Ds.Tables(0)
        DataGridView2.ReadOnly = True
        LBLTotalPinjam.Text = DataGridView2.Rows.Count
        DataGridView1.Rows.Clear()
    End Sub
    Sub HitungDenda()
        Dim Hitung As Double
        For baris As Integer = 0 To DataGridView1.RowCount - 1
            Hitung = Hitung + DataGridView1.Rows(baris).Cells(7).Value
        Next
        LBLTotalDenda.Text = Hitung
        If LBLTotalDenda.Text = 0 Then
            LBLTotalDenda.Text = 0
            TextBox2.Text = 0
            LBLKembali.Text = 0
        Else
        End If
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Dim cols As DataGridViewComboBoxColumn

        Dim baris As Integer = DataGridView1.RowCount - 1
        Cmd = New OleDbCommand("select TanggalPinjam from TBL_PEMINJAMAN where NoPinjam='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            DataGridView1.Rows.Add(DataGridView2.Rows(e.RowIndex).Cells(0).Value, DataGridView2.Rows(e.RowIndex).Cells(1).Value, Format(DateValue(Rd.Item("TanggalPinjam")), "dd/MM/yyyy"), "", "", "Tidak", "Tidak", DataGridView2.Rows(e.RowIndex).Cells(2).Value)
            For barisatas As Integer = 0 To DataGridView1.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To DataGridView1.RowCount - 1
                    If DataGridView1.Rows(barisbawah).Cells(0).Value = DataGridView1.Rows(barisatas).Cells(0).Value Then
                        MsgBox("Buku Sedang Dalam Proses Pengembalian!")
                        DataGridView1.Rows.RemoveAt(barisbawah)
                        Exit Sub
                    End If
                Next
            Next
            If DataGridView1.Rows(baris).Cells(2).Value = Today Then
                DataGridView1.Rows(baris).Cells(3).Value = 1
            Else
                DataGridView1.Rows(baris).Cells(3).Value = DateDiff(DateInterval.Day, DataGridView1.Rows(baris).Cells(2).Value, Today())
            End If
            If DataGridView1.Rows(baris).Cells(3).Value <= Val(HalamanUtama.STLabel12.Text) Then
                DataGridView1.Rows(baris).Cells(4).Value = 0
                DataGridView1.Rows(baris).Cells(7).Value = 0
            Else
                DataGridView1.Rows(baris).Cells(4).Value = DataGridView1.Rows(baris).Cells(3).Value - Val(HalamanUtama.STLabel16.Text)
                DataGridView1.Rows(baris).Cells(7).Value = Val(HalamanUtama.STLabel14.Text) * DataGridView1.Rows(baris).Cells(4).Value
            End If
            DataGridView1.Rows(baris).Cells(8).Value = DataGridView2.Rows(baris).Cells(2).Value
        Else
            MsgBox("Buku Sedang Dalam Proses Pengembalian!")
        End If
        Label4.Text = DataGridView1.Rows.Count - 1
        'DataGridView1.Rows(e.RowIndex).Cells(8).Value = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        'LBLTotalDenda.Text = ""
        'If DataGridView1.Rows(e.RowIndex).Cells(5).Selected = "Ya" Then
        '    DataGridView1.Rows(baris).Cells(7).Value = Val(HalamanUtama.STLabel18.Text)
        'End If

        Cmd = New OleDbCommand("select Gambar from TBL_BUKU where KodeBuku='" & DataGridView1.Rows(baris).Cells(0).Value & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            On Error Resume Next
            TextBox1.Text = Rd.Item("Gambar")
            PictureBox1.Load(TextBox1.Text)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Call HitungDenda()
        Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value + 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Kosongkan()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TextBox2.Text) < Val(LBLTotalDenda.Text) Then
                MsgBox("Pembayaran Kurang!")
                Exit Sub
            ElseIf Val(TextBox2.Text) >= Val(LBLTotalDenda.Text) Then
                LBLKembali.Text = Val(TextBox2.Text) - Val(LBLTotalDenda.Text)
                Button2.Focus()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 5 Then
            If DataGridView1.Rows(e.RowIndex).Cells(5).Value = "Ya" Then
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = "Tidak"
                DataGridView1.Rows(e.RowIndex).Cells(7).Value = Val(HalamanUtama.STLabel14.Text) * DataGridView1.Rows(e.RowIndex).Cells(4).Value + Val(HalamanUtama.STLabel18.Text)
            Else
                DataGridView1.Rows(e.RowIndex).Cells(7).Value = 0
            End If
        End If

        If e.ColumnIndex = 6 Then
            If DataGridView1.Rows(e.RowIndex).Cells(6).Value = "Ya" Then
                'DataGridView1.Rows(e.RowIndex).Cells(4).Value = 0
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = "Tidak"
                Cmd = New OleDbCommand("select * From TBL_BUKU where KodeBuku='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    'DataGridView1.Rows(e.RowIndex).Cells(4).Value = 0
                    DataGridView1.Rows(e.RowIndex).Cells(7).Value = Rd.Item("HargaBuku")
                End If
            Else
                DataGridView1.Rows(e.RowIndex).Cells(7).Value = 0
            End If
        End If
        Call HitungDenda()
        Label8.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value + 0
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            'LBLTotalPinjam.Text = DataGridView2.RowCount - 1
            Call HitungDenda()
            TextBox2.Text = 0
            LBLKembali.Text = 0
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Val(TextBox2.Text) < Val(LBLTotalDenda.Text) Then
            MsgBox("Denda Belum Dibayar")
        Else
            If DataGridView1.Rows.Count <= 1 Then
                MsgBox("Transaksi Tidak Ada, Silakan Melakukan Transaksi!")
            Else
                'Call Koneksi()
                'Dim tgldb As String
                'tgldb = Format(Today, "yyyy-MM-dd")
                'Dim KembaliBuku As String = "insert into TBL_PENGEMBALIAN values ('" & LBLNoPengembalian.Text & "','" & tgldb & "','" & LBLKodeAnggota.Text & "','" & Label4.Text & "','" & HalamanUtama.STLabel2.Text & "','" & LBLTotalDenda.Text & "','" & LBLNamaAnggota.Text & "','" & DataGridView1.Rows(baris).Cells(6).Value & "')"
                'Cmd = New OleDbCommand(KembaliBuku, Conn)
                'Cmd.ExecuteNonQuery()
                Call Koneksi()
                Dim tgldb As String
                tgldb = Format(Today, "yyyy-MM-dd")
                Dim KembaliBuku As String = "insert into TBL_PENGEMBALIAN values ('" & LBLNoPengembalian.Text & "','" & tgldb & "','" & LBLKodeAnggota.Text & "','" & Label4.Text & "','" & HalamanUtama.STLabel2.Text & "','" & LBLTotalDenda.Text & "','" & LBLNamaAnggota.Text & "','" & Label8.Text & "')"
                Cmd = New OleDbCommand(KembaliBuku, Conn)
                Cmd.ExecuteNonQuery()

                For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                    Call Koneksi()
                    Dim SimpanDetail As String = "insert into TBL_DETAILPENGEMBALIAN values('" & LBLNoPengembalian.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(1).Value & "','" & DataGridView1.Rows(Baris).Cells(8).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "','" & Label6.Text & "','" & DataGridView1.Rows(Baris).Cells(6).Value & "','" & DataGridView1.Rows(Baris).Cells(5).Value & "','" & DataGridView1.Rows(Baris).Cells(7).Value & " ')"
                    Cmd = New OleDbCommand(SimpanDetail, Conn)
                    Cmd.ExecuteNonQuery()
                    Call Koneksi()
                    Cmd = New OleDbCommand("select * from TBL_BUKU where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    If DataGridView1.Rows(Baris).Cells(6).Value = "Ya" Then
                        Call Koneksi()
                        Dim TambahStok As String = "update TBL_DETAILPEMINJAMAN set Status='Hilang' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "' and NoPinjam ='" & ComboBox1.Text & "'"
                        Cmd = New OleDbCommand(TambahStok, Conn)
                        Cmd.ExecuteNonQuery()
                    Else
                        Dim Dikembalikan As String = "update TBL_DETAILPEMINJAMAN set Status= '" & Label6.Text & "' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "' and NoPinjam='" & ComboBox1.Text & "'"
                        Cmd = New OleDbCommand(Dikembalikan, Conn)
                        Cmd.ExecuteNonQuery()
                    End If
                    If DataGridView1.Rows(Baris).Cells(6).Value = "Ya" Then
                        Call Koneksi()
                        Dim TambahStok As String = "update TBL_BUKU set JumlahBuku='" & Rd.Item("JumlahBuku") + 0 & "'where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                        Cmd = New OleDbCommand(TambahStok, Conn)
                        Cmd.ExecuteNonQuery()
                    Else
                        Call Koneksi()
                        Dim TambahStok As String = "update TBL_BUKU set JumlahBuku='" & Rd.Item("JumlahBuku") + Val(DataGridView1.Rows(Baris).Cells(8).Value) & "'where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                        Cmd = New OleDbCommand(TambahStok, Conn)
                        Cmd.ExecuteNonQuery()
                    End If
                    'Dim Dikembalikan As String = "update TBL_DETAILPEMINJAMAN set Status= '" & Label6.Text & "' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "' and NoPinjam='" & ComboBox1.Text & "'"
                    'Cmd = New OleDbCommand(Dikembalikan, Conn)
                    'Cmd.ExecuteNonQuery()
                Next
                If MessageBox.Show("Cetak Bukti Pengembalian?", "Cetak Bukti", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    'AxCrystalReport1.SelectionFormula = "totext ({TBL_PENGEMBALIAN.NoKembali}) = '" & LBLNoPengembalian.Text & "'"
                    'AxCrystalReport1.ReportFileName = "NotaPengembalian.rpt"
                    'AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                    'AxCrystalReport1.RetrieveDataFiles()
                    'AxCrystalReport1.Action = 1
                    NotaPengembalian.Show()
                    Call Kosongkan()
                Else
                    Call Kosongkan()
                    Call TampilDipinjam()
                    Call NomorOtomatis()
                    MsgBox("Transaksi Berhasil Disimpan!")
                End If
                Call Kosongkan()
                Call TampilDipinjam()
                Call NomorOtomatis()
            End If
        End If
        'Call Kosongkan()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub

End Class