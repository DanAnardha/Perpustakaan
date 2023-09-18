Public Class FrmBuku
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
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub FrmBuku_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        bersihkan()
    End Sub

    Private Sub FrmBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load   
        penerbit()
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

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_buku where kode_buku='" & txtkodebuku.Text & "'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            MsgBox("Data buku sudah ada", MsgBoxStyle.Exclamation, "data buku")
            txtkodebuku.Clear()
        ElseIf Trim(txtkodebuku.Text) = "" Then
            ErrorProvider1.SetError(txtkodebuku, "Kode buku harus diisi")
        ElseIf Trim(cmbJenisBuku.Text) = "" Then
            ErrorProvider1.SetError(cmbJenisBuku, "Pilih Jenis buku")
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
            ("insert into tb_buku " & _
             "values('" & txtkodebuku.Text & "', " & _
             "'" & cmbJenisBuku.Text & "', " & _
             "'" & txtjudulbuku.Text & "', " & _
             "'" & txtpengarang.Text & "', " & _
              "'" & cmbPenerbit.Text & "', " & _
              "'" & txtTahunterbit.Text & "', " & _
             "'" & txtStok.Text & "')", conperpus)
            cmdperpus.ExecuteNonQuery()

            cmdperpus = New OleDb.OleDbCommand _
                ("update nomor set kode=kode+1", conperpus)
            cmdperpus.ExecuteNonQuery()

            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Tersimpan")
            con_da_buku()
            bersihkan()
            Close()
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

    Private Sub txtjudulbuku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjudulbuku.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtpengarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpengarang.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtpenerbit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ErrorProvider1.Clear()
    End Sub
    Private Sub txtstokbuku_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub cmbJenisBuku_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtStok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStok.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtTahunterbit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahunterbit.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class