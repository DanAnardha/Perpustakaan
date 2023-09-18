<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksiPengembalian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksiPengembalian))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBLKembali = New System.Windows.Forms.Label()
        Me.LBLTotalDenda = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLTotalPinjam = New System.Windows.Forms.Label()
        Me.LBLKodeAnggota = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLNamaAnggota = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLTanggalKembali = New System.Windows.Forms.Label()
        Me.LBLNoPengembalian = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulBuku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LamaPinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Terlambat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rusak = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Hilang = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Denda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Pengembalian"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.LBLKembali)
        Me.GroupBox1.Controls.Add(Me.LBLTotalDenda)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.LBLTotalPinjam)
        Me.GroupBox1.Controls.Add(Me.LBLKodeAnggota)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LBLNamaAnggota)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LBLTanggalKembali)
        Me.GroupBox1.Controls.Add(Me.LBLNoPengembalian)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1121, 115)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False

        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(156, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(754, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(1047, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 76)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Tutup"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(902, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 76)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Simpan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(975, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 76)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Batal"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(3, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1115, 20)
        Me.TextBox1.TabIndex = 18
        '
        'LBLKembali
        '
        Me.LBLKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLKembali.Location = New System.Drawing.Point(754, 60)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.Size = New System.Drawing.Size(138, 18)
        Me.LBLKembali.TabIndex = 17
        Me.LBLKembali.Text = "LBLKembali"
        Me.LBLKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTotalDenda
        '
        Me.LBLTotalDenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotalDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotalDenda.Location = New System.Drawing.Point(754, 16)
        Me.LBLTotalDenda.Name = "LBLTotalDenda"
        Me.LBLTotalDenda.Size = New System.Drawing.Size(138, 18)
        Me.LBLTotalDenda.TabIndex = 15
        Me.LBLTotalDenda.Text = "LBLTotalDenda"
        Me.LBLTotalDenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(610, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 18)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Kembali"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(610, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Dibayar"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(610, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 18)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Total Denda"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTotalPinjam
        '
        Me.LBLTotalPinjam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotalPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotalPinjam.Location = New System.Drawing.Point(455, 60)
        Me.LBLTotalPinjam.Name = "LBLTotalPinjam"
        Me.LBLTotalPinjam.Size = New System.Drawing.Size(138, 18)
        Me.LBLTotalPinjam.TabIndex = 11
        Me.LBLTotalPinjam.Text = "LBLTotalPinjam"
        Me.LBLTotalPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLKodeAnggota
        '
        Me.LBLKodeAnggota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKodeAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLKodeAnggota.Location = New System.Drawing.Point(455, 16)
        Me.LBLKodeAnggota.Name = "LBLKodeAnggota"
        Me.LBLKodeAnggota.Size = New System.Drawing.Size(138, 18)
        Me.LBLKodeAnggota.TabIndex = 9
        Me.LBLKodeAnggota.Text = "LBLKodeAnggota"
        Me.LBLKodeAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(311, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Pinjaman"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLNamaAnggota
        '
        Me.LBLNamaAnggota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNamaAnggota.Location = New System.Drawing.Point(311, 38)
        Me.LBLNamaAnggota.Name = "LBLNamaAnggota"
        Me.LBLNamaAnggota.Size = New System.Drawing.Size(282, 18)
        Me.LBLNamaAnggota.TabIndex = 7
        Me.LBLNamaAnggota.Text = "LBLNama"
        Me.LBLNamaAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Kode Anggota"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTanggalKembali
        '
        Me.LBLTanggalKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggalKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTanggalKembali.Location = New System.Drawing.Point(156, 38)
        Me.LBLTanggalKembali.Name = "LBLTanggalKembali"
        Me.LBLTanggalKembali.Size = New System.Drawing.Size(138, 18)
        Me.LBLTanggalKembali.TabIndex = 4
        Me.LBLTanggalKembali.Text = "LBLTanggalKembali"
        Me.LBLTanggalKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLNoPengembalian
        '
        Me.LBLNoPengembalian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoPengembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNoPengembalian.Location = New System.Drawing.Point(156, 16)
        Me.LBLNoPengembalian.Name = "LBLNoPengembalian"
        Me.LBLNoPengembalian.Size = New System.Drawing.Size(138, 18)
        Me.LBLNoPengembalian.TabIndex = 3
        Me.LBLNoPengembalian.Text = "LBLNoPengembalian"
        Me.LBLNoPengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Pinjam"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Kembali"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1121, 413)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(553, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Dikembalikan"
        Me.Label6.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(952, 172)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(169, 232)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gambar Buku"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 207)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(946, 232)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Peminjaman"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(668, -8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Label8"
        Me.Label8.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(512, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(452, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.Location = New System.Drawing.Point(3, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(940, 210)
        Me.DataGridView2.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBuku, Me.JudulBuku, Me.TanggalPinjam, Me.LamaPinjam, Me.Terlambat, Me.Rusak, Me.Hilang, Me.Denda, Me.Jumlah})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1115, 141)
        Me.DataGridView1.TabIndex = 3
        '
        'KodeBuku
        '
        Me.KodeBuku.HeaderText = "KodeBuku"
        Me.KodeBuku.Name = "KodeBuku"
        Me.KodeBuku.ReadOnly = True
        '
        'JudulBuku
        '
        Me.JudulBuku.HeaderText = "JudulBuku"
        Me.JudulBuku.Name = "JudulBuku"
        Me.JudulBuku.ReadOnly = True
        '
        'TanggalPinjam
        '
        Me.TanggalPinjam.HeaderText = "TanggalPinjam"
        Me.TanggalPinjam.Name = "TanggalPinjam"
        Me.TanggalPinjam.ReadOnly = True
        '
        'LamaPinjam
        '
        Me.LamaPinjam.HeaderText = "LamaPinjam"
        Me.LamaPinjam.Name = "LamaPinjam"
        Me.LamaPinjam.ReadOnly = True
        '
        'Terlambat
        '
        Me.Terlambat.HeaderText = "Terlambat"
        Me.Terlambat.Name = "Terlambat"
        Me.Terlambat.ReadOnly = True
        '
        'Rusak
        '
        Me.Rusak.HeaderText = "Rusak"
        Me.Rusak.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.Rusak.Name = "Rusak"
        '
        'Hilang
        '
        Me.Hilang.HeaderText = "Hilang"
        Me.Hilang.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.Hilang.Name = "Hilang"
        '
        'Denda
        '
        Me.Denda.HeaderText = "Denda"
        Me.Denda.Name = "Denda"
        Me.Denda.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'FormTransaksiPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 531)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormTransaksiPengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Pengembalian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLKembali As System.Windows.Forms.Label
    Friend WithEvents LBLTotalDenda As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LBLTotalPinjam As System.Windows.Forms.Label
    Friend WithEvents LBLKodeAnggota As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLNamaAnggota As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggalKembali As System.Windows.Forms.Label
    Friend WithEvents LBLNoPengembalian As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KodeBuku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulBuku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalPinjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LamaPinjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Terlambat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rusak As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Hilang As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Denda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
