Public Class FrmDataKelompokBuku
    Dim kode As Integer
    Private Sub FrmDataKelompokBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        da_kelompok_buku = New OleDb.OleDbDataAdapter _
            ("select * from kelompok_buku", conperpus)
        con_da_kelompok_buku()
        DataGridView1.DataSource = tb_kelompok_buku
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "KODE"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "KELOMPOK BUKU"
            .Columns(1).Width = 300
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(txtkelompokbuku.Text) = "" Then
            ErrorProvider1.SetError(txtkelompokbuku, "Penerbit harus diisi")
        Else
            cmdperpus = New OleDb.OleDbCommand _
            ("insert into kelompok_buku (kelompok_buku) " & _
             "values('" & txtkelompokbuku.Text & "')", conperpus)
            cmdperpus.ExecuteNonQuery()
            MsgBox("Data kelompok buku Berhasil Disimpan", MsgBoxStyle.Information, "Tersimpan")
            con_da_kelompok_buku()
            txtkelompokbuku.Clear()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("update kelompok_buku set kelompok_buku='" & txtkelompokbuku.Text & "' where kode=" & kode & "", conperpus)
        cmdperpus.ExecuteNonQuery()
        MsgBox("Data kelompok buku berhasil diubah", MsgBoxStyle.Information, "ubah")
        txtkelompokbuku.Clear()
        con_da_kelompok_buku()
        kode = vbNull
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error GoTo b
        Dim a As Integer
        a = DataGridView1.SelectedCells(0).Value
        cmdperpus = New OleDb.OleDbCommand _
            ("delete from kelompok_buku where kode=" & a & "", conperpus)
        cmdperpus.ExecuteNonQuery()
        MsgBox("Kelompok buku berhasil dihapus", MsgBoxStyle.Information, "hapus")
        txtkelompokbuku.Clear()
        con_da_kelompok_buku()
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True

        Exit Sub
b:
        MsgBox("Pilih data yang akan dihapus", MsgBoxStyle.Exclamation, "pilih data")
        DataGridView1.Focus()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        da_kelompok_buku = New OleDb.OleDbDataAdapter _
          ("select * from kelompok_buku where kode like '%" & Trim(txtCari.Text) & _
               "%' or kelompok_buku like '%" & Trim(txtCari.Text) & "%'", conperpus)
        con_da_kelompok_buku()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            kode = .SelectedCells(0).Value
            txtkelompokbuku.Text = .SelectedCells(1).Value
        End With
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class