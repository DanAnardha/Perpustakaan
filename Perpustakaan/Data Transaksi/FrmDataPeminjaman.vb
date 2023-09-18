Public Class FrmDataPeminjaman

    Private Sub FrmDataPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_peminjaman = New OleDb.OleDbDataAdapter _
            ("SELECT * from tb_peminjaman", conperpus)
        con_data_peminjaman()
        DataGridView1.DataSource = tb_data_peminjaman
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "KODE PEMINJAMAN"
            .Columns(0).Width = 250
            .Columns(1).HeaderText = "KODE PETUGAS"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "NO ANGGOTA"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "TANGGAL PINJAM"
            .Columns(3).Width = 150
            .Columns(4).HeaderText = "TANGGAL KEMBALI"
            .Columns(4).Width = 150
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        data_peminjaman = New OleDb.OleDbDataAdapter _
          ("select * from tb_peminjaman WHERE nisn like '%" & Trim(txtcari.Text) & _
               "%' or kode_peminjaman like '%" & Trim(txtcari.Text) & "%'", conperpus)
        con_data_peminjaman()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With DataGridView1
            FrmDetailPeminjaman.lblkodepeminjaman.Text = .SelectedCells(0).Value
            FrmDetailPeminjaman.lblkodepetugas.Text = "KODE PETUGAS : " & .SelectedCells(1).Value
            FrmDetailPeminjaman.lblnisnsiswa.Text = "NO ANGGOTA : " & .SelectedCells(2).Value
            FrmDetailPeminjaman.lbltglpinjam.Text = "TANGGAL PINJAM : " & .SelectedCells(3).Value
            FrmDetailPeminjaman.lbltglkembali.Text = "TANGGAL KEMBALI : " & .SelectedCells(4).Value
            FrmDetailPeminjaman.ShowDialog()
        End With
    End Sub
End Class