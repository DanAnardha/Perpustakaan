Public Class FrmCariDataAnggota

    Private Sub FrmCariDataAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da_anggota = New OleDb.OleDbDataAdapter _
            ("SELECT * FROM tb_anggota", conperpus)
        con_da_anggota()
        DataGridView1.DataSource = tb_anggota
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        On Error GoTo adaError
        With DataGridView1
            FrmPeminjaman.txtnisn.Text = .SelectedCells(0).Value
            FrmPeminjaman.txtnamasiswa.Text = .SelectedCells(1).Value
        End With
        Close()
        Exit Sub
adaError:
        MsgBox("Data anggota belum dipilih", MsgBoxStyle.Critical, "pesan")
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        da_anggota = New OleDb.OleDbDataAdapter _
          ("select * from tb_anggota where nisn like '%" & Trim(txtCari.Text) & _
               "%' or nama like '%" & Trim(txtCari.Text) & _
               "%' or alamat like '%" & Trim(txtCari.Text) & "%'", conperpus)
        con_da_anggota()
    End Sub
End Class