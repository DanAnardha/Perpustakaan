Public Class FrmDetailPeminjaman

    Private Sub FrmDetailPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        detail_peminjaman = New OleDb.OleDbDataAdapter _
            ("select kode_buku,judul,jumlah,status from tb_peminjaman_detail where kode_peminjaman='" & lblkodepeminjaman.Text & "'", conperpus)
        con_detail_peminjaman()
        DataGridView1.DataSource = tb_detail_peminjaman
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class