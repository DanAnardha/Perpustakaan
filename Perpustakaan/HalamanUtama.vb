Imports System.Data.OleDb
Public Class HalamanUtama
    Sub Terkunci()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button17.Enabled = True
        Button17.Text = "Logout"
        'STLabel2.Text = ""
        'STLabel4.Text = ""
        'STLabel6.Text = ""
        Call PengaturanPinjam()
    End Sub
    Public Sub PengaturanPinjam()

        Call Koneksi()
        Cmd = New OleDbCommand("Select * from TBL_PENGATURAN", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        STLabel12.Text = Rd(0)
        STLabel16.Text = Rd(1)
        STLabel14.Text = Rd(2)
        STLabel18.Text = Rd(3)
    End Sub

    Private Sub HalamanUtama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormLogin.Visible = True
    End Sub
    Private Sub HalamanUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Terkunci()
        Call PengaturanPinjam()
        Timer1.Start()
        STLabel10.Text = Format(Today, "dd MMMM yyyy")
        If Not STLabel6.Text = "ADMIN" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button14.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button14.Enabled = True
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormLogin.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Terkunci()
        MsgBox("Anda Telah Berhasil Logout!")
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterPetugas.Show()
    End Sub

    Private Sub AnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterAnggota.Show()
    End Sub

    Private Sub BukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterBuku.Show()
    End Sub

    Private Sub KatalogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterKatalog.Show()
    End Sub

    Private Sub LembagaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterLembaga.Show()
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPengaturan.Show()
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterKategori.Show()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormTransaksiPeminjaman.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        STLabel8.Text = TimeOfDay
    End Sub

    Private Sub PeminjamanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LaporanPeminjaman.Show()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataPeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDataPeminjaman.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormMasterPetugas.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormMasterAnggota.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormMasterBuku.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterKatalog.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FormMasterLembaga.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMasterKategori.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormTransaksiPengembalian.Show()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataPengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDataPengembalian.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        FormTransaksiPeminjaman.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        FormTransaksiPengembalian.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        FormDataPeminjaman.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FormDataPengembalian.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LaporanMaster.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LaporanPeminjaman.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LaporanPengembalian.Show()

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Button17.Text = "Login" Then
            FormLogin.Show()
        Else
            'Button17.Text = "Logout"
            If MsgBox("Apakah Anda Yakin Akan Logout?", MsgBoxStyle.Exclamation + _
           MsgBoxStyle.OkCancel, "Logout") = _
           MsgBoxResult.Ok Then
                Me.Close()
                FormLogin.Show()
            End If
        End If

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPengaturan.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Apakah Anda Yakin Akan Menutup Program?", MsgBoxStyle.Exclamation + _
           MsgBoxStyle.OkCancel, "Tutup Program") = _
           MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FormMasterKategori.Show()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FormMasterKatalog.Show()
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        LaporanMaster.Show()
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        LaporanPeminjaman.Show()
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        LaporanPengembalian.Show()
    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        FormPengaturan.Show()
    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Button17.Text = "Login" Then
            FormLogin.Show()
        Else
            'Button17.Text = "Logout"
            If MsgBox("Apakah Anda Yakin Akan Logout?", MsgBoxStyle.Exclamation + _
           MsgBoxStyle.OkCancel, "Logout") = _
           MsgBoxResult.Ok Then
                Me.Close()
                FormLogin.Show()
            End If
        End If

    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If MsgBox("Apakah Anda Yakin Akan Menutup Program?", MsgBoxStyle.Exclamation + _
           MsgBoxStyle.OkCancel, "Tutup Program") = _
           MsgBoxResult.Ok Then
            End
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|PNG Files(*.png)|*.png"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            Button5.Enabled = True
        End If
    End Sub
End Class
