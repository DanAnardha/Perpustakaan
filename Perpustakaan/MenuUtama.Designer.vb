<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DendaKeterlambatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenerbitBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelompokBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbllevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblkodelogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblnamaop = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbltanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbljam = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(341, 374)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_muda
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengaturanToolStripMenuItem, Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(710, 26)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem, Me.DataPetugasToolStripMenuItem, Me.DendaKeterlambatanToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PengaturanToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'DataPetugasToolStripMenuItem
        '
        Me.DataPetugasToolStripMenuItem.Name = "DataPetugasToolStripMenuItem"
        Me.DataPetugasToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.DataPetugasToolStripMenuItem.Text = "Data Petugas"
        '
        'DendaKeterlambatanToolStripMenuItem
        '
        Me.DendaKeterlambatanToolStripMenuItem.Name = "DendaKeterlambatanToolStripMenuItem"
        Me.DendaKeterlambatanToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.DendaKeterlambatanToolStripMenuItem.Text = "Denda dan Keterlambatan"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenerbitBukuToolStripMenuItem, Me.KelompokBukuToolStripMenuItem, Me.DataAnggotaToolStripMenuItem, Me.DataBukuToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataMasterToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DataMasterToolStripMenuItem.Text = "Data Master"
        '
        'PenerbitBukuToolStripMenuItem
        '
        Me.PenerbitBukuToolStripMenuItem.Name = "PenerbitBukuToolStripMenuItem"
        Me.PenerbitBukuToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.PenerbitBukuToolStripMenuItem.Text = "Penerbit Buku"
        '
        'KelompokBukuToolStripMenuItem
        '
        Me.KelompokBukuToolStripMenuItem.Name = "KelompokBukuToolStripMenuItem"
        Me.KelompokBukuToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.KelompokBukuToolStripMenuItem.Text = "Kelompok Buku"
        '
        'DataAnggotaToolStripMenuItem
        '
        Me.DataAnggotaToolStripMenuItem.Name = "DataAnggotaToolStripMenuItem"
        Me.DataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DataAnggotaToolStripMenuItem.Text = "Data Anggota"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahBukuToolStripMenuItem, Me.DaftarBukuToolStripMenuItem})
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'TambahBukuToolStripMenuItem
        '
        Me.TambahBukuToolStripMenuItem.Name = "TambahBukuToolStripMenuItem"
        Me.TambahBukuToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.TambahBukuToolStripMenuItem.Text = "Tambah Buku"
        '
        'DaftarBukuToolStripMenuItem
        '
        Me.DaftarBukuToolStripMenuItem.Name = "DaftarBukuToolStripMenuItem"
        Me.DaftarBukuToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DaftarBukuToolStripMenuItem.Text = "Daftar Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem, Me.PengembalianToolStripMenuItem, Me.DataPeminjamanToolStripMenuItem, Me.DataPengembalianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.PeminjamanToolStripMenuItem.Text = "Peminjaman"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'DataPeminjamanToolStripMenuItem
        '
        Me.DataPeminjamanToolStripMenuItem.Name = "DataPeminjamanToolStripMenuItem"
        Me.DataPeminjamanToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DataPeminjamanToolStripMenuItem.Text = "Data Peminjaman"
        '
        'DataPengembalianToolStripMenuItem
        '
        Me.DataPengembalianToolStripMenuItem.Name = "DataPengembalianToolStripMenuItem"
        Me.DataPengembalianToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DataPengembalianToolStripMenuItem.Text = "Data Pengembalian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataBukuToolStripMenuItem, Me.LaporanDataAnggotaToolStripMenuItem, Me.LaporanPeminjamanToolStripMenuItem, Me.LaporanPengembalianToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanDataBukuToolStripMenuItem
        '
        Me.LaporanDataBukuToolStripMenuItem.Name = "LaporanDataBukuToolStripMenuItem"
        Me.LaporanDataBukuToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.LaporanDataBukuToolStripMenuItem.Text = "Laporan Data Buku"
        '
        'LaporanDataAnggotaToolStripMenuItem
        '
        Me.LaporanDataAnggotaToolStripMenuItem.Name = "LaporanDataAnggotaToolStripMenuItem"
        Me.LaporanDataAnggotaToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.LaporanDataAnggotaToolStripMenuItem.Text = "Laporan Data Anggota"
        '
        'LaporanPeminjamanToolStripMenuItem
        '
        Me.LaporanPeminjamanToolStripMenuItem.Name = "LaporanPeminjamanToolStripMenuItem"
        Me.LaporanPeminjamanToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.LaporanPeminjamanToolStripMenuItem.Text = "Laporan Peminjaman"
        '
        'LaporanPengembalianToolStripMenuItem
        '
        Me.LaporanPengembalianToolStripMenuItem.Name = "LaporanPengembalianToolStripMenuItem"
        Me.LaporanPengembalianToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.LaporanPengembalianToolStripMenuItem.Text = "Laporan Pengembalian"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_muda
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbllevel, Me.lblkodelogin, Me.lblnamaop, Me.lbltanggal, Me.lbljam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 754)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(710, 23)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbllevel
        '
        Me.lbllevel.ActiveLinkColor = System.Drawing.Color.Black
        Me.lbllevel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllevel.ForeColor = System.Drawing.Color.White
        Me.lbllevel.Name = "lbllevel"
        Me.lbllevel.Size = New System.Drawing.Size(16, 18)
        Me.lbllevel.Text = "-"
        '
        'lblkodelogin
        '
        Me.lblkodelogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodelogin.ForeColor = System.Drawing.Color.White
        Me.lblkodelogin.Name = "lblkodelogin"
        Me.lblkodelogin.Size = New System.Drawing.Size(16, 18)
        Me.lblkodelogin.Text = "-"
        '
        'lblnamaop
        '
        Me.lblnamaop.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamaop.ForeColor = System.Drawing.Color.White
        Me.lblnamaop.Name = "lblnamaop"
        Me.lblnamaop.Size = New System.Drawing.Size(16, 18)
        Me.lblnamaop.Text = "-"
        '
        'lbltanggal
        '
        Me.lbltanggal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggal.ForeColor = System.Drawing.Color.White
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(647, 18)
        Me.lbltanggal.Spring = True
        Me.lbltanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbljam
        '
        Me.lbljam.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.ForeColor = System.Drawing.Color.White
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(0, 18)
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.logo_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 777)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HALAMAN UTAMA (Aplikasi Perpustakaan MAN LABOR KOTA JAMBI)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PengaturanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPetugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DendaKeterlambatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenerbitBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelompokBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPeminjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanDataAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPeminjamanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbllevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblkodelogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblnamaop As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbltanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbljam As System.Windows.Forms.ToolStripStatusLabel

End Class
