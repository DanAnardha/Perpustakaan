Public Class FrmDataKembali
    Private Sub FrmDataKembali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_pengembalian = New OleDb.OleDbDataAdapter _
            ("SELECT tb_anggota.nama, tb_pengembalian.nisn, tb_pengembalian.kode_kembali, tb_pengembalian.tgl_transaksi, tb_pengembalian.total_denda, tb_login.nm_lengkap FROM tb_anggota INNER JOIN (tb_login INNER JOIN tb_pengembalian ON tb_login.kode_login = tb_pengembalian.kode_login) ON tb_anggota.nisn = tb_pengembalian.nisn", conperpus)
        con_data_pengembalian()
        DataGridView1.DataSource = tb_data_pengembalian
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "NAMA SISWA"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "NO ANGGOTA"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "KODE KEMBALI"
            .Columns(2).Width = 250
            .Columns(3).HeaderText = "TGL TRANSAKSI"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "DENDA"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "NAMA PETUGAS"
            .Columns(5).Width = 150
        End With
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        data_pengembalian = New OleDb.OleDbDataAdapter _
          ("SELECT tb_anggota.nama, tb_pengembalian.nisn, tb_pengembalian.kode_kembali, tb_pengembalian.tgl_transaksi, tb_pengembalian.total_denda, tb_login.nm_lengkap FROM tb_anggota INNER JOIN (tb_login INNER JOIN tb_pengembalian ON tb_login.kode_login = tb_pengembalian.kode_login) ON tb_anggota.nisn = tb_pengembalian.nisn WHERE tb_pengembalian.nisn like '%" & Trim(txtcari.Text) & _
               "%' or tb_anggota.nama like '%" & Trim(txtcari.Text) & _
               "%' or tb_login.nm_lengkap like '%" & Trim(txtcari.Text) & _
               "%' or tb_pengembalian.kode_kembali like '%" & Trim(txtcari.Text) & "%'", conperpus)
        con_data_pengembalian()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With DataGridView1
            FrmDetailPengembalian.lblnamasiswa.Text = "NAMA SISWA : " & .SelectedCells(0).Value
            FrmDetailPengembalian.lblnisnsiswa.Text = "NO ANGGOTA : " & .SelectedCells(1).Value
            FrmDetailPengembalian.lblkodekembali.Text = .SelectedCells(2).Value
            FrmDetailPengembalian.lbltgltransaksi.Text = "TANGGAL TRANSAKSI : " & .SelectedCells(3).Value
            FrmDetailPengembalian.lbldenda.Text = "TOTAL DENDA : " & .SelectedCells(4).Value
            FrmDetailPengembalian.lblpetugas.Text = "NAMA PETUGAS : " & .SelectedCells(5).Value
            FrmDetailPengembalian.ShowDialog()
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class