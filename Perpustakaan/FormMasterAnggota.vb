Imports System.Data.OleDb
Public Class FormMasterAnggota
    Dim jeniskelamin As String
    Sub KodeOtomatis()
        Cmd = New OleDbCommand("select KodeAnggota from TBL_ANGGOTA order by KodeAnggota desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            TextBox1.Text = "AGT001"
        Else
            TextBox1.Text = "AGT" + Format(Microsoft.VisualBasic.Right(Rd.Item("KodeAnggota"), 3) + 1, "000")
        End If
        TextBox1.Enabled = False
    End Sub
    Sub KondisiAwal()
        Call KodeOtomatis()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        jeniskelamin = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Call Koneksi()
        Da = New OleDbDataAdapter("select * from TBL_ANGGOTA", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_ANGGOTA")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
    End Sub

    Private Sub FormMasterAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point)
        Call KondisiAwal()
    End Sub
    Sub CariId()
        Cmd = New OleDbCommand("select * from TBL_ANGGOTA where KodeAnggota ='" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CariId()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or jeniskelamin = "" Or TextBox4.Text = "" Then
            MsgBox("Pastikan Anda Mengisi Semua Field")
        Else
            If Not Rd.HasRows Then
                Call Koneksi()
                Dim SimpanData As String = "insert into TBL_ANGGOTA values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & jeniskelamin & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                Cmd = New OleDbCommand(SimpanData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!")
                Call KondisiAwal()
            Else
                Call Koneksi()
                Dim EditData As String = "update TBL_ANGGOTA set NamaANGGOTA='" & TextBox2.Text & "', AlamatANGGOTA='" & TextBox3.Text & "',TeleponANGGOTA='" & TextBox4.Text & "', JenisKelamin='" & jeniskelamin & "' where KodeANGGOTA='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit!")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or jeniskelamin = "" Or TextBox4.Text = "" Then
            MsgBox("Pastikan Anda Mengisi Semua Field")
        Else
            If MsgBox("Apakah Anda Yakin Akan Menghapus?", MsgBoxStyle.Exclamation + _
            MsgBoxStyle.OkCancel, "Hapus Data") = _
            MsgBoxResult.Ok Then
                Call Koneksi()
                Dim HapusData As String = "delete * from TBL_ANGGOTA where KodeANGGOTA='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus!")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Da = New OleDbDataAdapter("select * from TBL_ANGGOTA where NamaANGGOTA like '%" & TextBox5.Text & "%' or AlamatANGGOTA like '%" & TextBox5.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(3, i).Value
        TextBox4.Text = DataGridView1.Item(4, i).Value
        If DataGridView1.Item(2, i).Value = "Pria" Then
            CheckBox1.Checked = True
            CheckBox2.Checked = False
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            jeniskelamin = "Pria"
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            jeniskelamin = "Wanita"
        End If
    End Sub

End Class