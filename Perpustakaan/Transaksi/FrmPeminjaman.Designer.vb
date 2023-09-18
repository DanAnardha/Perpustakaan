<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPeminjaman
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
        Me.components = New System.ComponentModel.Container()
        Me.lblkodepeminjaman = New System.Windows.Forms.Label()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtptahunterbit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtpengarang = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpenerbit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtjudulbuku = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtkodebuku = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnamasiswa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtnisn = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblkodepeminjaman
        '
        Me.lblkodepeminjaman.AutoSize = True
        Me.lblkodepeminjaman.BackColor = System.Drawing.Color.Transparent
        Me.lblkodepeminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodepeminjaman.ForeColor = System.Drawing.Color.Black
        Me.lblkodepeminjaman.Location = New System.Drawing.Point(9, 14)
        Me.lblkodepeminjaman.Name = "lblkodepeminjaman"
        Me.lblkodepeminjaman.Size = New System.Drawing.Size(157, 20)
        Me.lblkodepeminjaman.TabIndex = 1
        Me.lblkodepeminjaman.Text = "Kode Peminjaman "
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "PRIA"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "WANITA"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Location = New System.Drawing.Point(407, 275)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(92, 25)
        Me.ButtonX2.TabIndex = 4
        Me.ButtonX2.Text = "Tambah"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Location = New System.Drawing.Point(502, 275)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(92, 25)
        Me.ButtonX3.TabIndex = 5
        Me.ButtonX3.Text = "Update"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.Location = New System.Drawing.Point(693, 275)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(92, 25)
        Me.ButtonX4.TabIndex = 6
        Me.ButtonX4.Text = "Hapus"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 267)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(774, 241)
        Me.DataGridView1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Cari Data :"
        '
        'txtcari
        '
        '
        '
        '
        Me.txtcari.Border.Class = "TextBoxBorder"
        Me.txtcari.Location = New System.Drawing.Point(76, 241)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(145, 20)
        Me.txtcari.TabIndex = 109
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.Button3)
        Me.PanelEx1.Controls.Add(Me.DataGridView1)
        Me.PanelEx1.Controls.Add(Me.Button2)
        Me.PanelEx1.Controls.Add(Me.Button1)
        Me.PanelEx1.Controls.Add(Me.dtptahunterbit)
        Me.PanelEx1.Controls.Add(Me.txtpengarang)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.txtpenerbit)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.txtjudulbuku)
        Me.PanelEx1.Controls.Add(Me.txtkodebuku)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.Label13)
        Me.PanelEx1.Controls.Add(Me.DateTimePicker2)
        Me.PanelEx1.Controls.Add(Me.DateTimePicker1)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.txtnamasiswa)
        Me.PanelEx1.Controls.Add(Me.txtnisn)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.ButtonX6)
        Me.PanelEx1.Controls.Add(Me.txtcari)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.lblkodepeminjaman)
        Me.PanelEx1.Location = New System.Drawing.Point(7, 39)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(785, 569)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_silver
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 111
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_tua
        Me.Button3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(5, 514)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 50)
        Me.Button3.TabIndex = 152
        Me.Button3.Text = "Proses Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_tua
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(632, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 24)
        Me.Button2.TabIndex = 151
        Me.Button2.Text = "Cari"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_tua
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(333, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 24)
        Me.Button1.TabIndex = 150
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtptahunterbit
        '
        '
        '
        '
        Me.dtptahunterbit.Border.Class = "TextBoxBorder"
        Me.dtptahunterbit.Location = New System.Drawing.Point(519, 163)
        Me.dtptahunterbit.Name = "dtptahunterbit"
        Me.dtptahunterbit.ReadOnly = True
        Me.dtptahunterbit.Size = New System.Drawing.Size(136, 20)
        Me.dtptahunterbit.TabIndex = 145
        '
        'txtpengarang
        '
        '
        '
        '
        Me.txtpengarang.Border.Class = "TextBoxBorder"
        Me.txtpengarang.Location = New System.Drawing.Point(519, 106)
        Me.txtpengarang.Name = "txtpengarang"
        Me.txtpengarang.ReadOnly = True
        Me.txtpengarang.Size = New System.Drawing.Size(176, 20)
        Me.txtpengarang.TabIndex = 144
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(410, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Tahun Terbit :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(409, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Penerbit :"
        '
        'txtpenerbit
        '
        '
        '
        '
        Me.txtpenerbit.Border.Class = "TextBoxBorder"
        Me.txtpenerbit.Location = New System.Drawing.Point(519, 136)
        Me.txtpenerbit.Name = "txtpenerbit"
        Me.txtpenerbit.ReadOnly = True
        Me.txtpenerbit.Size = New System.Drawing.Size(259, 20)
        Me.txtpenerbit.TabIndex = 141
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(410, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = "Penulis :"
        '
        'txtjudulbuku
        '
        '
        '
        '
        Me.txtjudulbuku.Border.Class = "TextBoxBorder"
        Me.txtjudulbuku.Location = New System.Drawing.Point(519, 80)
        Me.txtjudulbuku.Name = "txtjudulbuku"
        Me.txtjudulbuku.ReadOnly = True
        Me.txtjudulbuku.Size = New System.Drawing.Size(259, 20)
        Me.txtjudulbuku.TabIndex = 139
        '
        'txtkodebuku
        '
        '
        '
        '
        Me.txtkodebuku.Border.Class = "TextBoxBorder"
        Me.txtkodebuku.Location = New System.Drawing.Point(519, 52)
        Me.txtkodebuku.Name = "txtkodebuku"
        Me.txtkodebuku.Size = New System.Drawing.Size(113, 20)
        Me.txtkodebuku.TabIndex = 138
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(410, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "Judul Buku :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(410, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Kode Buku :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(134, 138)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 20)
        Me.DateTimePicker2.TabIndex = 134
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 108)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 20)
        Me.DateTimePicker1.TabIndex = 131
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Tanggal Kembali :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Tanggal Pinjam :"
        '
        'txtnamasiswa
        '
        '
        '
        '
        Me.txtnamasiswa.Border.Class = "TextBoxBorder"
        Me.txtnamasiswa.Location = New System.Drawing.Point(133, 78)
        Me.txtnamasiswa.Name = "txtnamasiswa"
        Me.txtnamasiswa.ReadOnly = True
        Me.txtnamasiswa.Size = New System.Drawing.Size(241, 20)
        Me.txtnamasiswa.TabIndex = 127
        '
        'txtnisn
        '
        '
        '
        '
        Me.txtnisn.Border.Class = "TextBoxBorder"
        Me.txtnisn.Location = New System.Drawing.Point(134, 52)
        Me.txtnisn.Name = "txtnisn"
        Me.txtnisn.Size = New System.Drawing.Size(199, 20)
        Me.txtnisn.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Nama Siswa :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "No Anggota :"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.Location = New System.Drawing.Point(590, 236)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(92, 25)
        Me.ButtonX6.TabIndex = 113
        Me.ButtonX6.Text = "Batal"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(306, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 18)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Peminjaman Buku"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_tua
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(756, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 30)
        Me.Button4.TabIndex = 112
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_muda
        Me.ClientSize = New System.Drawing.Size(798, 615)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPeminjaman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblkodepeminjaman As System.Windows.Forms.Label
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnamasiswa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnisn As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtptahunterbit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtpengarang As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtpenerbit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtjudulbuku As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtkodebuku As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
