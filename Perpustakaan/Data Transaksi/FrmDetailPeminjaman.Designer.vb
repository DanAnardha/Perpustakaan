<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetailPeminjaman
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblkodepeminjaman = New System.Windows.Forms.Label()
        Me.lblkodepetugas = New System.Windows.Forms.Label()
        Me.lblnisnsiswa = New System.Windows.Forms.Label()
        Me.lbltglpinjam = New System.Windows.Forms.Label()
        Me.lbltglkembali = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'lblkodepeminjaman
        '
        Me.lblkodepeminjaman.AutoSize = True
        Me.lblkodepeminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodepeminjaman.ForeColor = System.Drawing.Color.Black
        Me.lblkodepeminjaman.Location = New System.Drawing.Point(14, 9)
        Me.lblkodepeminjaman.Name = "lblkodepeminjaman"
        Me.lblkodepeminjaman.Size = New System.Drawing.Size(107, 13)
        Me.lblkodepeminjaman.TabIndex = 1
        Me.lblkodepeminjaman.Text = "Kode Peminjaman"
        '
        'lblkodepetugas
        '
        Me.lblkodepetugas.AutoSize = True
        Me.lblkodepetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodepetugas.ForeColor = System.Drawing.Color.Black
        Me.lblkodepetugas.Location = New System.Drawing.Point(14, 33)
        Me.lblkodepetugas.Name = "lblkodepetugas"
        Me.lblkodepetugas.Size = New System.Drawing.Size(90, 13)
        Me.lblkodepetugas.TabIndex = 2
        Me.lblkodepetugas.Text = "Kode Petugas "
        '
        'lblnisnsiswa
        '
        Me.lblnisnsiswa.AutoSize = True
        Me.lblnisnsiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnisnsiswa.ForeColor = System.Drawing.Color.Black
        Me.lblnisnsiswa.Location = New System.Drawing.Point(14, 59)
        Me.lblnisnsiswa.Name = "lblnisnsiswa"
        Me.lblnisnsiswa.Size = New System.Drawing.Size(69, 13)
        Me.lblnisnsiswa.TabIndex = 3
        Me.lblnisnsiswa.Text = "NIS Siswa "
        '
        'lbltglpinjam
        '
        Me.lbltglpinjam.AutoSize = True
        Me.lbltglpinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltglpinjam.ForeColor = System.Drawing.Color.Black
        Me.lbltglpinjam.Location = New System.Drawing.Point(265, 33)
        Me.lbltglpinjam.Name = "lbltglpinjam"
        Me.lbltglpinjam.Size = New System.Drawing.Size(94, 13)
        Me.lbltglpinjam.TabIndex = 4
        Me.lbltglpinjam.Text = "Tanggal Pinjam"
        '
        'lbltglkembali
        '
        Me.lbltglkembali.AutoSize = True
        Me.lbltglkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltglkembali.ForeColor = System.Drawing.Color.Black
        Me.lbltglkembali.Location = New System.Drawing.Point(265, 57)
        Me.lbltglkembali.Name = "lbltglkembali"
        Me.lbltglkembali.Size = New System.Drawing.Size(101, 13)
        Me.lbltglkembali.TabIndex = 5
        Me.lbltglkembali.Text = "Tanggal Kembali"
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.lbltglkembali)
        Me.PanelEx1.Controls.Add(Me.lbltglpinjam)
        Me.PanelEx1.Controls.Add(Me.lblnisnsiswa)
        Me.PanelEx1.Controls.Add(Me.lblkodepetugas)
        Me.PanelEx1.Controls.Add(Me.lblkodepeminjaman)
        Me.PanelEx1.Controls.Add(Me.DataGridView1)
        Me.PanelEx1.Location = New System.Drawing.Point(6, 31)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(526, 324)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_putih
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 6
        Me.PanelEx1.Text = "PanelEx1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(180, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 18)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Detail Peminjaman"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_tua
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(496, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 30)
        Me.Button4.TabIndex = 141
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmDetailPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_muda
        Me.ClientSize = New System.Drawing.Size(539, 361)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetailPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Peminjaman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblkodepeminjaman As System.Windows.Forms.Label
    Friend WithEvents lblkodepetugas As System.Windows.Forms.Label
    Friend WithEvents lblnisnsiswa As System.Windows.Forms.Label
    Friend WithEvents lbltglpinjam As System.Windows.Forms.Label
    Friend WithEvents lbltglkembali As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
