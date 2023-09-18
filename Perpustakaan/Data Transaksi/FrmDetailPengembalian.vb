Public Class FrmDetailPengembalian

    Private Sub FrmDetailPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        detail_pengembalian = New OleDb.OleDbDataAdapter _
            ("select kode_buku,judul,jumlah,terlambat from tb_pengembalian_detail where kode_kembali='" & lblkodekembali.Text & "'", conperpus)
        con_detail_pengembalian()
        DataGridView1.DataSource = tb_detail_pengembalian
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