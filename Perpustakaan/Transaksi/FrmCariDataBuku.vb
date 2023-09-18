Public Class FrmCariDataBuku

    Private Sub FrmCariDataBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da_buku = New OleDb.OleDbDataAdapter _
           ("select * from tb_buku", conperpus)
        con_da_buku()
        DataGridView1.DataSource = tb_buku
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "KODE BUKU"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "JENIS BUKU"
            .Columns(1).Width = 100
            .Columns(2).HeaderText = "JUDUL"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "PENULIS"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "PENERBIT"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "THN TERBIT"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = "JUMLAH BUKU"
            .Columns(6).Width = 100
        End With
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        da_buku = New OleDb.OleDbDataAdapter _
          ("select * from tb_buku where kode_buku like '%" & Trim(txtCari.Text) & _
               "%' or judul like '%" & Trim(txtCari.Text) & _
               "%' or thn_terbit like '%" & Trim(txtCari.Text) & _
               "%' or penerbit like '%" & Trim(txtCari.Text) & _
               "%' or status like '%" & Trim(txtCari.Text) & _
               "%' or pengarang like '%" & Trim(txtCari.Text) & "%'", conperpus)
        con_da_buku()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        On Error GoTo adaError
        With DataGridView1
            FrmPeminjaman.txtkodebuku.Text = .SelectedCells(0).Value
            FrmPeminjaman.txtjudulbuku.Text = .SelectedCells(2).Value
            FrmPeminjaman.txtpengarang.Text = .SelectedCells(3).Value
            FrmPeminjaman.txtpenerbit.Text = .SelectedCells(4).Value
            FrmPeminjaman.dtptahunterbit.Text = .SelectedCells(5).Value
        End With
        Close()
        Exit Sub
adaError:
        MsgBox("Data buku belum dipilih", MsgBoxStyle.Critical, "pesan")
    End Sub
End Class