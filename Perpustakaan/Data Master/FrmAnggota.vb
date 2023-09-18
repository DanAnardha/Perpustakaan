Public Class FrmAnggota
    Dim jns_kelamin, status As String
    Public Sub bersihkan()
        txtnisn.Clear()
        txtnamasiswa.Clear()
        txtalamat.Clear()
        rd1.Checked = False
        rd2.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        jns_kelamin = ""
        status = ""
        txtnohp.Clear()
        txtnisn.Focus()
    End Sub
    Private Sub FrmAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonX3.Enabled = False
        ButtonX4.Enabled = False
        da_anggota = New OleDb.OleDbDataAdapter _
           ("select * from tb_anggota", conperpus)
        con_da_anggota()
        DataGridView1.DataSource = tb_anggota
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "No Anggota"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "NAMA SISWA"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "JNS KELAMIN"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "ALAMAT"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "NO HP"
            .Columns(4).Width = 100
            .Columns(5).HeaderText = "STATUS"
            .Columns(5).Width = 100
        End With
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_anggota where nisn='" & txtnisn.Text & "'", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            MsgBox("Data anggota sudah ada", MsgBoxStyle.Exclamation, "data anggota")
            ButtonX3.Focus()
        ElseIf Trim(txtnisn.Text) = "" Then
            ErrorProvider1.SetError(txtnisn, "NISN harus diisi")
        ElseIf Trim(txtnamasiswa.Text) = "" Then
            ErrorProvider1.SetError(txtnamasiswa, "Nama siswa harus diisi")
        ElseIf Trim(jns_kelamin) = "" Then
            ErrorProvider1.SetError(rd1, "Pilih jenis kelamin")
        ElseIf Trim(txtalamat.Text) = "" Then
            ErrorProvider1.SetError(txtalamat, "Alamat siswa harus diisi")
        ElseIf Trim(txtnohp.Text) = "" Then
            ErrorProvider1.SetError(txtnohp, "No HP harus diisi")
        ElseIf Trim(status) = "" Then
            ErrorProvider1.SetError(CheckBox2, "Pilih Status Anggota")
        Else
            cmdperpus = New OleDb.OleDbCommand _
            ("insert into tb_anggota " & _
             "values('" & txtnisn.Text & "', " & _
             "'" & txtnamasiswa.Text & "', " & _
             "'" & jns_kelamin & "', " & _
              "'" & txtalamat.Text & "', " & _
               "'" & txtnohp.Text & "', " & _
             "'" & status & "')", conperpus)
            cmdperpus.ExecuteNonQuery()

            MsgBox("Data anggota Berhasil Disimpan", MsgBoxStyle.Information, "Tersimpan")
            con_da_anggota()
            bersihkan()
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If Trim(txtnisn.Text) = "" Then
            ErrorProvider1.SetError(txtnisn, "NISN harus diisi")
        ElseIf Trim(txtnamasiswa.Text) = "" Then
            ErrorProvider1.SetError(txtnamasiswa, "Nama siswa harus diisi")
        ElseIf Trim(jns_kelamin) = "" Then
            ErrorProvider1.SetError(rd1, "Pilih jenis kelamin")
        ElseIf Trim(txtalamat.Text) = "" Then
            ErrorProvider1.SetError(txtalamat, "Alamat siswa harus diisi")
        ElseIf Trim(txtnohp.Text) = "" Then
            ErrorProvider1.SetError(txtnohp, "No HP harus diisi")
        ElseIf Trim(status) = "" Then
            ErrorProvider1.SetError(CheckBox2, "Pilih Status Anggota")
        Else
            cmdperpus = New OleDb.OleDbCommand _
               ("update tb_anggota set " & _
                "[nama]='" & txtnamasiswa.Text & "', " & _
                "[jenkel]='" & jns_kelamin & "', " & _
                "[alamat]='" & txtalamat.Text & "', " & _
                "[no_hp]='" & txtnohp.Text & "', " & _
                "[status]='" & status & "' where " & _
                "[nisn]='" & txtnisn.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            con_da_anggota()
            MsgBox("Data anggota berhasil diupdate", MsgBoxStyle.Information, "terupdate")
            bersihkan()
            ButtonX3.Enabled = False
            ButtonX4.Enabled = False
            txtnisn.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If Trim(txtnisn.Text) = "" Then
            MsgBox("Pilih data yang ingin dihapus...", MsgBoxStyle.Exclamation, "pilih data")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("delete from tb_anggota where nisn='" & txtnisn.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            con_da_anggota()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "terhapus")
            bersihkan()
            ButtonX3.Enabled = False
            ButtonX4.Enabled = False
            txtnisn.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            txtnisn.Text = .SelectedCells(0).Value
            txtnamasiswa.Text = .SelectedCells(1).Value
            jns_kelamin = .SelectedCells(2).Value
            If jns_kelamin = "Laki laki" Then
                rd1.Checked = True
            ElseIf jns_kelamin = "Perempuan" Then
                rd2.Checked = True
            End If
            txtalamat.Text = .SelectedCells(3).Value
            txtnohp.Text = .SelectedCells(4).Value
            status = .SelectedCells(5).Value
            If status = "Aktif" Then
                CheckBox1.Checked = True
                CheckBox2.Checked = False
            ElseIf status = "Tidak Aktif" Then
                CheckBox2.Checked = True
                CheckBox1.Checked = False
            End If

        End With
        txtnisn.ReadOnly = True
        ButtonX3.Enabled = True
        ButtonX4.Enabled = True
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        da_anggota = New OleDb.OleDbDataAdapter _
          ("select * from tb_anggota where nisn like '%" & Trim(txtcari.Text) & _
               "%' or nama like '%" & Trim(txtcari.Text) & _
               "%' or alamat like '%" & Trim(txtcari.Text) & "%'", conperpus)
        con_da_anggota()
    End Sub

    Private Sub txtnisn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnisn.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnamasiswa.Focus()
        End If
    End Sub
    Private Sub txtnisn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnisn.TextChanged

    End Sub

    Private Sub txtnohp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnohp.TextChanged
        ErrorProvider1.Clear()
        If Len(txtnohp.Text) = 12 Then
            ButtonX2.Focus()
        End If
        'txtnohp.Clear()
    End Sub

    Private Sub rd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd1.CheckedChanged
        ErrorProvider1.Clear()
        If rd1.Checked = True Then
            jns_kelamin = "Laki laki"
        End If
    End Sub
    Private Sub rd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd2.CheckedChanged
        ErrorProvider1.Clear()
        If rd2.Checked = True Then
            jns_kelamin = "Perempuan"
        End If
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'CheckBox1.Checked = True
        CheckBox2.Checked = False
        status = "Aktif"
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        'CheckBox2.Checked = True
        CheckBox1.Checked = False
        status = "Tidak Aktif"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class