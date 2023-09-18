Public Class FrmDaftarBuku
    Public Sub penerbit()
        cmbPenerbit.Items.Clear()
        cmdperpus = New OleDb.OleDbCommand _
        ("select * from penerbit", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        While dtrperpus.Read
            cmbPenerbit.Items.Add(dtrperpus("penerbit"))
        End While
    End Sub
    Public Sub bersihkan()
        txtkodebuku.Clear()
        cmbJenisBuku.Clear()
        txtjudulbuku.Clear()
        txtpengarang.Clear()
        cmbPenerbit.SelectedIndex = -1
        txtTahunterbit.Clear()
        txtStok.Clear()
        txtkodebuku.Focus()
    End Sub

    Private Sub FrmDaftarBuku_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        bersihkan()
    End Sub
    Private Sub FrmDaftarBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonX3.Visible = True
        ButtonX4.Visible = True
        penerbit()

        ButtonX3.Enabled = False
        ButtonX4.Enabled = False
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
            .Columns(3).HeaderText = "PENGARANG"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "PENERBIT"
            .Columns(4).Width = 150
            .Columns(5).HeaderText = "THN TERBIT"
            .Columns(5).Width = 100
            .Columns(6).HeaderText = "STOK BUKU"
            .Columns(6).Width = 100
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            txtkodebuku.Text = .SelectedCells(0).Value
            cmbJenisBuku.Text = .SelectedCells(1).Value
            txtjudulbuku.Text = .SelectedCells(2).Value
            txtpengarang.Text = .SelectedCells(3).Value
            cmbPenerbit.Text = .SelectedCells(4).Value
            txtTahunterbit.Text = .SelectedCells(5).Value
            txtStok.Text = .SelectedCells(6).Value
        End With
        txtkodebuku.ReadOnly = True
        ButtonX3.Enabled = True
        ButtonX4.Enabled = True
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If Trim(txtkodebuku.Text) = "" Then
            ErrorProvider1.SetError(txtkodebuku, "Kode buku harus diisi")
        ElseIf Trim(cmbJenisBuku.Text) = "" Then
            ErrorProvider1.SetError(cmbJenisBuku, "Pilih jenis buku")
        ElseIf Trim(txtjudulbuku.Text) = "" Then
            ErrorProvider1.SetError(txtjudulbuku, "Judul buku harus diisi")
        ElseIf Trim(txtpengarang.Text) = "" Then
            ErrorProvider1.SetError(txtpengarang, "Pengarang harus diisi")
        ElseIf Trim(cmbPenerbit.Text) = "" Then
            ErrorProvider1.SetError(cmbPenerbit, "Penerbit harus diisi")
        ElseIf Trim(txtTahunterbit.Text) = "" Then
            ErrorProvider1.SetError(txtTahunterbit, "Tahun terbit harus diisi")
        ElseIf Trim(txtStok.Text) = "" Then
            ErrorProvider1.SetError(txtStok, "Jumlah Stok harus diisi")
        Else
            cmdperpus = New OleDb.OleDbCommand _
               ("update tb_buku set " &
                "[jenis_buku]='" & cmbJenisBuku.Text & "', " & _
                "[judul]='" & txtjudulbuku.Text & "', " & _
                "[pengarang]='" & txtpengarang.Text & "', " & _
                "[penerbit]='" & cmbPenerbit.Text & "', " & _
                "[thn_terbit]='" & txtTahunterbit.Text & "', " & _
                "[stok]=" & txtStok.Text & " where " & _
                "[kode_buku]='" & txtkodebuku.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            con_da_buku()
            MsgBox("Data petugas berhasil diupdate", MsgBoxStyle.Information, "terupdate")
            bersihkan()
            ButtonX3.Enabled = False
            ButtonX4.Enabled = False
            txtkodebuku.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click

        If Trim(txtkodebuku.Text) = "" Then
            MsgBox("Pilih data yang ingin dihapus...", MsgBoxStyle.Exclamation, "pilih data")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("delete from tb_buku where kode_buku='" & txtkodebuku.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            con_da_buku()
            MsgBox("data berhasil dihapus", MsgBoxStyle.Information, "terhapus")
            bersihkan()
            ButtonX3.Enabled = False
            ButtonX4.Enabled = False
            txtkodebuku.ReadOnly = False
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        da_buku = New OleDb.OleDbDataAdapter _
          ("select * from tb_buku where kode_buku like '%" & Trim(txtcari.Text) & _
               "%' or judul like '%" & Trim(txtcari.Text) & _
               "%' or thn_terbit like '%" & Trim(txtcari.Text) & _
               "%' or penerbit like '%" & Trim(txtcari.Text) & _
               "%' or status like '%" & Trim(txtcari.Text) & _
               "%' or pengarang like '%" & Trim(txtcari.Text) & "%'", conperpus)
        con_da_buku()
    End Sub

    Private Sub txtkodebuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkodebuku.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub cmbJenisBuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenisBuku.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtjudulbuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjudulbuku.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtpengarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpengarang.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub cmbPenerbit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPenerbit.SelectedIndexChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtTahunterbit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahunterbit.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtStok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStok.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class