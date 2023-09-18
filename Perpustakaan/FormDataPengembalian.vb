Imports System.Data.OleDb
Public Class FormDataPengembalian

    Private Sub FormDataPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OleDbDataAdapter("select * from TBL_PENGEMBALIAN", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_PENGEMBALIAN")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Da = New OleDbDataAdapter("select * from TBL_PENGEMBALIAN where NoKembali like '%" & TextBox1.Text & "%' or KodeAnggota like '%" & TextBox1.Text & "%' or KodePetugas like '%" & TextBox1.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Silakan Memilih Data Terlebih Dahulu")
        Else
            FormDetailPengembalian.LBLNoPinjam.Text = DataGridView1.SelectedCells(0).Value
            FormDetailPengembalian.LBLKodeAnggota.Text = DataGridView1.SelectedCells(2).Value
            FormDetailPengembalian.LBLKodePetugas.Text = DataGridView1.SelectedCells(4).Value
            FormDetailPengembalian.LBLTanggalPinjam.Text = DataGridView1.SelectedCells(1).Value
            FormDetailPengembalian.Show()
        End If
    End Sub
End Class