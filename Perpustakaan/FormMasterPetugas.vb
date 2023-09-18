Imports System.Data.OleDb
Public Class FormMasterPetugas
    Sub KodeOtomatis()
        Cmd = New OleDbCommand("select KodePetugas from TBL_PETUGAS order by KodePetugas desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            TextBox1.Text = "PTG001"
        Else
            TextBox1.Text = "PTG" + Format(Microsoft.VisualBasic.Right(Rd.Item("KodePetugas"), 3) + 1, "000")
        End If
        TextBox1.Enabled = False
    End Sub
    Sub KondisiAwal()
        Call KodeOtomatis()
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox3.PasswordChar = "X"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Call Koneksi()
        Da = New OleDbDataAdapter("select * from TBL_PETUGAS", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_PETUGAS")
        DataGridView1.DataSource = Ds.Tables(0)
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
        TextBox3.PasswordChar = "*"
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
    End Sub
    Private Sub FormMasterPetugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.MaxLength = 8
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 30
    End Sub
    Sub CariId()
        Cmd = New OleDbCommand("select * from TBL_PETUGAS where KodePetugas ='" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CariId()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan Anda Mengisi Semua Field")
        Else
            If Not Rd.HasRows Then
                Call Koneksi()
                Dim SimpanData As String = "insert into TBL_PETUGAS values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OleDbCommand(SimpanData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!")
                Call KondisiAwal()
            Else
                Call Koneksi()
                Dim EditData As String = "update TBL_PETUGAS set NamaPetugas='" & TextBox2.Text & "', PasswordPetugas='" & TextBox3.Text & "', LevelPetugas='" & ComboBox1.Text & "' where KodePetugas='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit!")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan Anda Mengisi Semua Field")
        Else
            If MsgBox("Apakah Anda Yakin Akan Menghapus?", MsgBoxStyle.Exclamation + _
            MsgBoxStyle.OkCancel, "Hapus Data") = _
            MsgBoxResult.Ok Then
                Call Koneksi()
                Dim HapusData As String = "delete * from TBL_PETUGAS where KodePetugas='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus!")
                Call KondisiAwal()
            Else

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Da = New OleDbDataAdapter("select * from TBL_PETUGAS where NamaPetugas like '%" & TextBox4.Text & "%' or LevelPetugas like '%" & TextBox4.Text & "%'", Conn)
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
        ComboBox1.Text = DataGridView1.Item(3, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
    End Sub
End Class