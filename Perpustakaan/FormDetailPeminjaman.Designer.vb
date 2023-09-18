<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailPeminjaman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetailPeminjaman))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLTanggalKembali = New System.Windows.Forms.Label()
        Me.LBLTanggalPinjam = New System.Windows.Forms.Label()
        Me.LBLKodePetugas = New System.Windows.Forms.Label()
        Me.LBLKodeAnggota = New System.Windows.Forms.Label()
        Me.LBLNoPinjam = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 23)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "No. Pinjam"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Kode Anggota"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Kode Petugas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tanggal Pinjam"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Tanggal Kembali"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTanggalKembali
        '
        Me.LBLTanggalKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggalKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTanggalKembali.Location = New System.Drawing.Point(398, 36)
        Me.LBLTanggalKembali.Name = "LBLTanggalKembali"
        Me.LBLTanggalKembali.Size = New System.Drawing.Size(136, 23)
        Me.LBLTanggalKembali.TabIndex = 24
        Me.LBLTanggalKembali.Text = "LBLTanggalKembali"
        Me.LBLTanggalKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTanggalPinjam
        '
        Me.LBLTanggalPinjam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggalPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTanggalPinjam.Location = New System.Drawing.Point(398, 9)
        Me.LBLTanggalPinjam.Name = "LBLTanggalPinjam"
        Me.LBLTanggalPinjam.Size = New System.Drawing.Size(136, 23)
        Me.LBLTanggalPinjam.TabIndex = 25
        Me.LBLTanggalPinjam.Text = "LBLTanggalPinjam"
        Me.LBLTanggalPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLKodePetugas
        '
        Me.LBLKodePetugas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKodePetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLKodePetugas.Location = New System.Drawing.Point(116, 63)
        Me.LBLKodePetugas.Name = "LBLKodePetugas"
        Me.LBLKodePetugas.Size = New System.Drawing.Size(156, 23)
        Me.LBLKodePetugas.TabIndex = 26
        Me.LBLKodePetugas.Text = "LBLKodePetugas"
        Me.LBLKodePetugas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLKodeAnggota
        '
        Me.LBLKodeAnggota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKodeAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLKodeAnggota.Location = New System.Drawing.Point(116, 36)
        Me.LBLKodeAnggota.Name = "LBLKodeAnggota"
        Me.LBLKodeAnggota.Size = New System.Drawing.Size(156, 23)
        Me.LBLKodeAnggota.TabIndex = 27
        Me.LBLKodeAnggota.Text = "LBLKodeAnggota"
        Me.LBLKodeAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLNoPinjam
        '
        Me.LBLNoPinjam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNoPinjam.Location = New System.Drawing.Point(116, 9)
        Me.LBLNoPinjam.Name = "LBLNoPinjam"
        Me.LBLNoPinjam.Size = New System.Drawing.Size(156, 23)
        Me.LBLNoPinjam.TabIndex = 28
        Me.LBLNoPinjam.Text = "LBLNoPinjam"
        Me.LBLNoPinjam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(546, 193)
        Me.DataGridView1.TabIndex = 1
        '
        'FormDetailPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 286)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LBLNoPinjam)
        Me.Controls.Add(Me.LBLKodeAnggota)
        Me.Controls.Add(Me.LBLKodePetugas)
        Me.Controls.Add(Me.LBLTanggalPinjam)
        Me.Controls.Add(Me.LBLTanggalKembali)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDetailPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Peminjaman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggalKembali As System.Windows.Forms.Label
    Friend WithEvents LBLTanggalPinjam As System.Windows.Forms.Label
    Friend WithEvents LBLKodePetugas As System.Windows.Forms.Label
    Friend WithEvents LBLKodeAnggota As System.Windows.Forms.Label
    Friend WithEvents LBLNoPinjam As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
