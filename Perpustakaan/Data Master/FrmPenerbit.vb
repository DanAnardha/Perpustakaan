Public Class FrmPenerbit
    Dim kode As Integer
    Private Sub FrmPenerbit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        da_penerbit = New OleDb.OleDbDataAdapter _
            ("select * from penerbit", conperpus)
        con_da_penerbit()
        DataGridView1.DataSource = tb_penerbit
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "KODE"
            .Columns(0).Width = 100
            .Columns(1).HeaderText = "PENERBIT BUKU"
            .Columns(1).Width = 300
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(txtpenerbit.Text) = "" Then
            ErrorProvider1.SetError(txtpenerbit, "Penerbit harus diisi")
        Else
            cmdperpus = New OleDb.OleDbCommand _
            ("insert into penerbit (penerbit) " & _
             "values('" & txtpenerbit.Text & "')", conperpus)
            cmdperpus.ExecuteNonQuery()
            MsgBox("Data penerbit Berhasil Disimpan", MsgBoxStyle.Information, "Tersimpan")
            con_da_penerbit()
            txtpenerbit.Clear()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("update penerbit set penerbit='" & txtpenerbit.Text & "' where kode=" & kode & "", conperpus)
        cmdperpus.ExecuteNonQuery()
        MsgBox("Data penerbit berhasil diubah", MsgBoxStyle.Information, "ubah")
        txtpenerbit.Clear()
        con_da_penerbit()
        kode = vbNull
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            kode = .SelectedCells(0).Value
            txtpenerbit.Text = .SelectedCells(1).Value
        End With
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error GoTo b
        Dim a As Integer
        a = DataGridView1.SelectedCells(0).Value
        cmdperpus = New OleDb.OleDbCommand _
            ("delete from penerbit where kode=" & a & "", conperpus)
        cmdperpus.ExecuteNonQuery()
        MsgBox("Penerbit berhasil dihapus", MsgBoxStyle.Information, "hapus")
        txtpenerbit.Clear()
        con_da_penerbit()
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True

        Exit Sub
b:
        MsgBox("Pilih data yang akan dihapus", MsgBoxStyle.Exclamation, "pilih data")
        DataGridView1.Focus()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        da_penerbit = New OleDb.OleDbDataAdapter _
          ("select * from penerbit where kode like '%" & Trim(txtCari.Text) & _
               "%' or penerbit like '%" & Trim(txtCari.Text) & "%'", conperpus)
        con_da_penerbit()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class