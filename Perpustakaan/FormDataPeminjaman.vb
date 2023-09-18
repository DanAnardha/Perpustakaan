Imports System.Data.OleDb
Public Class FormDataPeminjaman

    Private Sub FormDataPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OleDbDataAdapter("select NoPinjam, KodeAnggota, TotalPinjam, TanggalPinjam,TanggalKembali, KodePetugas from TBL_PEMINJAMAN", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_PEMINJAMAN")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Da = New OleDbDataAdapter("select * from TBL_PEMINJAMAN where NoPinjam like '%" & TextBox1.Text & "%' or KodeAnggota like '%" & TextBox1.Text & "%' or KodePetugas like '%" & TextBox1.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Silakan Memilih Data Terlebih Dahulu")
        Else
            FormDetailPeminjaman.LBLNoPinjam.Text = DataGridView1.SelectedCells(0).Value
            FormDetailPeminjaman.LBLKodeAnggota.Text = DataGridView1.SelectedCells(1).Value
            FormDetailPeminjaman.LBLKodePetugas.Text = DataGridView1.SelectedCells(5).Value
            FormDetailPeminjaman.LBLTanggalPinjam.Text = DataGridView1.SelectedCells(3).Value
            FormDetailPeminjaman.LBLTanggalKembali.Text = DataGridView1.SelectedCells(4).Value
            FormDetailPeminjaman.ShowDialog()
        End If
    End Sub
End Class