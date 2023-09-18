Public Class MenuUtama
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konekdb()
        Me.Show()
        lbljam.Text = "|| Jam " + Format(Now, "HH:mm:ss") + " WIB"
        lbltanggal.Text = Format(Today, "dd MMMM yyyy")
    End Sub
    Private Sub ButtonItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With AxCrystalReport1
            .ReportFileName = "data_buku.rpt"
            .DiscardSavedData = True
            .WindowHeight = 700
            .WindowWidth = 1000
            .WindowTop = 0
            .WindowLeft = 0
            .Action = 1
        End With
    End Sub

    Private Sub ButtonItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With AxCrystalReport1
            .ReportFileName = "data_anggota.rpt"
            .DiscardSavedData = True
            .WindowHeight = 700
            .WindowWidth = 1000
            .WindowTop = 0
            .WindowLeft = 0
            .Action = 1
        End With
    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LaporanPeminjaman.ShowDialog()
    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LaporanPengembalian.ShowDialog()
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmGantiPassword.ShowDialog()
    End Sub

    Private Sub Penerbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPenerbit.ShowDialog()
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmDataKelompokBuku.ShowDialog()
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmDaftarBuku.ShowDialog()
    End Sub
    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        FrmGantiPassword.ShowDialog()
    End Sub

    Private Sub PenerbitBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenerbitBukuToolStripMenuItem.Click
        FrmPenerbit.ShowDialog()
    End Sub

    Private Sub KelompokBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelompokBukuToolStripMenuItem.Click
        FrmDataKelompokBuku.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        If MsgBox("Anda yakin akan keluar dari sistem", MsgBoxStyle.Exclamation + _
            MsgBoxStyle.OkCancel, "Logout") = _
            MsgBoxResult.Ok Then
            lblkodelogin.Text = "-"
            lbllevel.Text = "-"
            lblnamaop.Text = "-"
            FrmLogin.ShowDialog()
            FrmLogin.txtusername.Focus()
        End If
    End Sub

    Private Sub DataPetugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPetugasToolStripMenuItem.Click
        FrmPetugas.ShowDialog()
    End Sub

    Private Sub DataAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAnggotaToolStripMenuItem.Click
        FrmAnggota.ShowDialog()
    End Sub

    Private Sub TambahBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahBukuToolStripMenuItem.Click
        FrmKelompokBuku.ShowDialog()
    End Sub

    Private Sub DaftarBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarBukuToolStripMenuItem.Click
        FrmDaftarBuku.ShowDialog()
    End Sub

    Private Sub DendaKeterlambatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DendaKeterlambatanToolStripMenuItem.Click
        FrmDendaKeterlambatan.ShowDialog()
    End Sub

    Private Sub PeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeminjamanToolStripMenuItem.Click
        FrmPeminjaman.ShowDialog()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengembalianToolStripMenuItem.Click
        FrmPengembalian.ShowDialog()
    End Sub

    Private Sub DataPeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPeminjamanToolStripMenuItem.Click
        FrmDataPeminjaman.ShowDialog()
    End Sub

    Private Sub DataPengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPengembalianToolStripMenuItem.Click
        FrmDataKembali.ShowDialog()
    End Sub

    Private Sub LaporanPengembalianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPengembalianToolStripMenuItem.Click
        LaporanPengembalian.ShowDialog()
    End Sub

    Private Sub LaporanPeminjamanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPeminjamanToolStripMenuItem.Click
        LaporanPeminjaman.ShowDialog()
    End Sub

    Private Sub LaporanDataBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataBukuToolStripMenuItem.Click
        With AxCrystalReport1
            .ReportFileName = "data_buku.rpt"
            .DiscardSavedData = True
            .WindowHeight = 700
            .WindowWidth = 1000
            .WindowTop = 0
            .WindowLeft = 0
            .Action = 1
        End With
    End Sub

    Private Sub LaporanDataAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanDataAnggotaToolStripMenuItem.Click
        With AxCrystalReport1
            .ReportFileName = "data_anggota.rpt"
            .DiscardSavedData = True
            .WindowHeight = 700
            .WindowWidth = 1000
            .WindowTop = 0
            .WindowLeft = 0
            .Action = 1
        End With
    End Sub
End Class
