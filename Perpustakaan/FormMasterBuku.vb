Imports System.Data.OleDb
Public Class FormMasterBuku
    Private PathFile As String = Nothing
    Sub KodeOtomatis()
        Cmd = New OleDbCommand("select KodeBuku from TBL_BUKU order by KodeBuku desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            TextBox1.Text = "B0001"
        Else
            TextBox1.Text = "B" + Format(Microsoft.VisualBasic.Right(Rd.Item("KodeBuku"), 4) + 1, "0000")
        End If
        TextBox1.Enabled = False
    End Sub
    Sub KondisiAwal()
        Call KodeOtomatis()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox3.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DateTimePicker1.Text = ""
        TextBox5.Text = ""
        TextBox5.Enabled = False
        PictureBox1.Image = Nothing
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Dim i As Integer
        Dim Tahun As String
        Tahun = Date.Now.Year
        With ComboBox3
            While Tahun >= 1999
                .Items.Add(Tahun)
                Tahun = Tahun - 1
            End While
        End With
        For i = 15 - 14 To 15
            ComboBox2.Items.Add(i)
        Next

        Call Koneksi()
        Da = New OleDbDataAdapter("select * from TBL_BUKU", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_Buku")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        Call MunculKategori()
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Sub Hilangkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        ComboBox3.Text = ""
        TextBox8.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DateTimePicker1.Text = Today
        TextBox5.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = False

        TextBox2.Enabled = True

        TextBox3.Enabled = True

        TextBox4.Enabled = True

        ComboBox3.Enabled = True

        TextBox6.Enabled = True

        TextBox8.Enabled = True

        ComboBox1.Enabled = True

        ComboBox2.Enabled = True

        DateTimePicker1.Enabled = True

        Button5.Enabled = True
    End Sub
    Private Sub FormMasterBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.MaxLength = 8
        TextBox2.MaxLength = 50
        TextBox3.MaxLength = 50
        TextBox4.MaxLength = 50
        ComboBox3.MaxLength = 4
        TextBox6.MaxLength = 4
        TextBox8.MaxLength = 24
    End Sub
    Sub CariId()
        Cmd = New OleDbCommand("select * from TBL_BUKU where KodeBuku ='" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CariId()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox3.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or DateTimePicker1.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Pastikan Anda Mengisi Semua Field")
        Else
            If Not Rd.HasRows Then
                Call Koneksi()
                Dim SimpanData As String = "insert into TBL_BUKU values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & ComboBox3.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Text & "','" & TextBox5.Text & "')"
                Cmd = New OleDbCommand(SimpanData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!")
                Call KondisiAwal()
            Else
                Call Koneksi()
                Dim EditData As String = "update TBL_BUKU set JudulBuku='" & TextBox2.Text & "', PengarangBuku='" & TextBox3.Text & "', JumlahBuku='" & TextBox6.Text & "', PenerbitBuku='" & TextBox4.Text & "',Kategori='" & ComboBox1.Text & "', TahunBuku='" & ComboBox3.Text & "', HargaBuku='" & TextBox8.Text & "', TanggalMasuk='" & DateTimePicker1.Text & "', Gambar='" & TextBox5.Text & "' where KodeBuku='" & TextBox1.Text & "'"
                Cmd = New OleDbCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diedit!")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus?", MsgBoxStyle.Exclamation + _
            MsgBoxStyle.OkCancel, "Hapus Data") = _
            MsgBoxResult.Ok Then
            Call Koneksi()
            Dim HapusData As String = "delete * from TBL_BUKU where KodeBuku='" & TextBox1.Text & "'"
            Cmd = New OleDbCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus!")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Hilangkan()
        Call KodeOtomatis()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
            Close()
    End Sub
    Sub Ketemu()
        On Error Resume Next
        TextBox1.Text = Rd.Item("KodeBuku")
        TextBox2.Text = Rd.Item("JudulBuku")
        TextBox3.Text = Rd.Item("PengarangBuku")
        TextBox4.Text = Rd.Item("PenerbitBuku")
        ComboBox3.Text = Rd.Item("TahunBuku")
        TextBox6.Text = Rd.Item("JumlahBuku")
        ComboBox1.Text = Rd.Item("Kategori")
        ComboBox2.Text = Rd.Item("LokasiRak")
        DateTimePicker1.Text = Rd.Item("TanggalMasuk")
        TextBox8.Text = Rd.Item("HargaBuku")
        TextBox5.Text = Rd.Item("Gambar")
        PictureBox1.Load(TextBox5.Text)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        TextBox1.Text = Focus()
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Da = New OleDbDataAdapter("select * from TBL_BUKU where JudulBuku like '%" & TextBox7.Text & "%' or PengarangBuku like '%" & TextBox7.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
    Sub MunculKategori()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OleDbCommand("select * from TBL_KATEGORI", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            Button5.Enabled = True
            PathFile = OpenFileDialog1.FileName
            TextBox5.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(TextBox5.Text)
        End If
    End Sub
    Sub CarIdBuku()
        Cmd = New OleDbCommand("select * from TBL_BUKU where KodeBuku = '" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        TextBox4.Text = DataGridView1.Item(3, i).Value
        ComboBox1.Text = DataGridView1.Item(4, i).Value
        ComboBox3.Text = DataGridView1.Item(5, i).Value
        TextBox6.Text = DataGridView1.Item(6, i).Value
        TextBox8.Text = DataGridView1.Item(7, i).Value
        ComboBox2.Text = DataGridView1.Item(8, i).Value
        DateTimePicker1.Text = DataGridView1.Item(9, i).Value
        TextBox5.Text = DataGridView1.Item(10, i).Value
        PictureBox1.Load(TextBox5.Text)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub
End Class