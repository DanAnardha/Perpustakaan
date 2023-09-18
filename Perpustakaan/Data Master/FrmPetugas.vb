Public Class FrmPetugas
    Dim kodelogin As Integer
    Public Sub bersihkan()
        txtkodelogin.Clear()
        txtnamalengkap.Clear()
        txtpassword.Clear()
        txtusername.Clear()
        txtnamalengkap.Focus()
    End Sub
    Public Sub kode_otomatis()
        cmdperpus = New OleDb.OleDbCommand _
        ("select * from nomor", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        While dtrperpus.Read
            kodelogin = dtrperpus("kode") + 1
        End While
        txtkodelogin.Text = Format(kodelogin, "0000")
    End Sub

    Private Sub FrmPetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonX3.Enabled = False
        ButtonX4.Enabled = False
        kode_otomatis()
        da_login = New OleDb.OleDbDataAdapter _
           ("select * from tb_login", conperpus)
        con_da_login()
        DataGridView1.DataSource = tb_login
        With DataGridView1
            .ReadOnly = True
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "KODE LOGIN"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "NAMA LENGKAP"
            .Columns(1).Width = 150
            .Columns(2).HeaderText = "USERNAME"
            .Columns(2).Width = 100
            .Columns(3).HeaderText = "PASSWORD"
            .Columns(3).Width = 100
            .Columns(4).HeaderText = "HAK AKSES"
            .Columns(4).Width = 100
        End With
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        cmdperpus = New OleDb.OleDbCommand _
            ("select * from tb_login where kode_login=" & txtkodelogin.Text & "", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            MsgBox("Data petugas sudah ada", MsgBoxStyle.Exclamation, "data petugas")
            ButtonX3.Focus()
        ElseIf Trim(txtnamalengkap.Text) = "" Then
            ErrorProvider1.SetError(txtnamalengkap, "Nama Lengkap harus diisi")
        ElseIf Trim(txtusername.Text) = "" Then
            ErrorProvider1.SetError(txtusername, "Username harus diisi")
        ElseIf Trim(txtpassword.Text) = "" Then
            ErrorProvider1.SetError(txtpassword, "Password harus diisi")
        Else
            cmdperpus = New OleDb.OleDbCommand _
            ("insert into tb_login " & _
             "values('" & txtkodelogin.Text & "', " & _
             "'" & txtnamalengkap.Text & "', " & _
             "'" & txtusername.Text & "', " & _
              "'" & txtpassword.Text & "', " & _
             "'" & ("admin") & "')", conperpus)
            cmdperpus.ExecuteNonQuery()

            'menambah nomor otomatis di tabel nomor
            cmdperpus = New OleDb.OleDbCommand _
            ("update nomor set kode='" & kodelogin & "'", conperpus)
            cmdperpus.ExecuteNonQuery()

            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Tersimpan")
            con_da_login()
            bersihkan()
            kode_otomatis()
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If Trim(txtnamalengkap.Text) = "" Then
            ErrorProvider1.SetError(txtnamalengkap, "Nama Lengkap harus diisi")
        ElseIf Trim(txtusername.Text) = "" Then
            ErrorProvider1.SetError(txtusername, "Username harus diisi")
        ElseIf Trim(txtpassword.Text) = "" Then
            ErrorProvider1.SetError(txtpassword, "Password harus diisi")
        Else
            cmdperpus = New OleDb.OleDbCommand _
               ("update tb_login set " & _
                "[nm_lengkap]='" & txtnamalengkap.Text & "', " & _
                "[usernm]='" & txtusername.Text & "', " & _
                "[passwd]='" & txtpassword.Text & "', " & _
                "[level]='" & ("admin") & "' where " & _
                "[kode_login]=" & txtkodelogin.Text & "", conperpus)
            cmdperpus.ExecuteNonQuery()
            con_da_login()
            MsgBox("Data petugas berhasil diupdate", MsgBoxStyle.Information, "terupdate")
            bersihkan()

            kode_otomatis()
            ButtonX3.Enabled = False
            ButtonX4.Enabled = False
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        If Trim(txtkodelogin.Text) = "" Then
            MsgBox("Pilih data yang ingin dihapus...", MsgBoxStyle.Exclamation, "pilih data")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("delete from tb_login where kode_login=" & txtkodelogin.Text & "", conperpus)
            cmdperpus.ExecuteNonQuery()
            con_da_login()
            MsgBox("data berhasil dihapus", MsgBoxStyle.Information, "terhapus")
            bersihkan()
            kode_otomatis()
            ButtonX3.Enabled = False
            ButtonX4.Enabled = False
        End If
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
        da_login = New OleDb.OleDbDataAdapter _
          ("select * from tb_login where kode_login like '%" & Trim(txtcari.Text) & _
               "%' or nm_lengkap like '%" & Trim(txtcari.Text) & _
               "%' or level like '%" & Trim(txtcari.Text) & "%'", conperpus)
        con_da_login()
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        With DataGridView1
            txtkodelogin.Text = .SelectedCells(0).Value
            txtnamalengkap.Text = .SelectedCells(1).Value
            txtusername.Text = .SelectedCells(2).Value
            txtpassword.Text = .SelectedCells(3).Value
        End With
        ButtonX3.Enabled = True
        ButtonX4.Enabled = True
    End Sub

    Private Sub txtnamalengkap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnamalengkap.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub cmbhakakses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ErrorProvider1.Clear()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class