<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetailPengembalian
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
        Me.lbldenda = New System.Windows.Forms.Label()
        Me.lbltgltransaksi = New System.Windows.Forms.Label()
        Me.lblnisnsiswa = New System.Windows.Forms.Label()
        Me.lblnamasiswa = New System.Windows.Forms.Label()
        Me.lblkodekembali = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblpetugas = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldenda
        '
        Me.lbldenda.AutoSize = True
        Me.lbldenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldenda.ForeColor = System.Drawing.Color.Black
        Me.lbldenda.Location = New System.Drawing.Point(273, 29)
        Me.lbldenda.Name = "lbldenda"
        Me.lbldenda.Size = New System.Drawing.Size(44, 13)
        Me.lbldenda.TabIndex = 11
        Me.lbldenda.Text = "Denda"
        '
        'lbltgltransaksi
        '
        Me.lbltgltransaksi.AutoSize = True
        Me.lbltgltransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltgltransaksi.ForeColor = System.Drawing.Color.Black
        Me.lbltgltransaksi.Location = New System.Drawing.Point(273, 9)
        Me.lbltgltransaksi.Name = "lbltgltransaksi"
        Me.lbltgltransaksi.Size = New System.Drawing.Size(80, 13)
        Me.lbltgltransaksi.TabIndex = 10
        Me.lbltgltransaksi.Text = "Tgl transaksi"
        '
        'lblnisnsiswa
        '
        Me.lblnisnsiswa.AutoSize = True
        Me.lblnisnsiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnisnsiswa.ForeColor = System.Drawing.Color.Black
        Me.lblnisnsiswa.Location = New System.Drawing.Point(14, 55)
        Me.lblnisnsiswa.Name = "lblnisnsiswa"
        Me.lblnisnsiswa.Size = New System.Drawing.Size(69, 13)
        Me.lblnisnsiswa.TabIndex = 9
        Me.lblnisnsiswa.Text = "NIS Siswa "
        '
        'lblnamasiswa
        '
        Me.lblnamasiswa.AutoSize = True
        Me.lblnamasiswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamasiswa.ForeColor = System.Drawing.Color.Black
        Me.lblnamasiswa.Location = New System.Drawing.Point(14, 29)
        Me.lblnamasiswa.Name = "lblnamasiswa"
        Me.lblnamasiswa.Size = New System.Drawing.Size(39, 13)
        Me.lblnamasiswa.TabIndex = 8
        Me.lblnamasiswa.Text = "Nama"
        '
        'lblkodekembali
        '
        Me.lblkodekembali.AutoSize = True
        Me.lblkodekembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodekembali.ForeColor = System.Drawing.Color.Black
        Me.lblkodekembali.Location = New System.Drawing.Point(14, 5)
        Me.lblkodekembali.Name = "lblkodekembali"
        Me.lblkodekembali.Size = New System.Drawing.Size(36, 13)
        Me.lblkodekembali.TabIndex = 7
        Me.lblkodekembali.Text = "Kode"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 235)
        Me.DataGridView1.TabIndex = 6
        '
        'lblpetugas
        '
        Me.lblpetugas.AutoSize = True
        Me.lblpetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpetugas.ForeColor = System.Drawing.Color.Black
        Me.lblpetugas.Location = New System.Drawing.Point(273, 55)
        Me.lblpetugas.Name = "lblpetugas"
        Me.lblpetugas.Size = New System.Drawing.Size(97, 13)
        Me.lblpetugas.TabIndex = 12
        Me.lblpetugas.Text = "Nama Petugas :"
        '
        'PanelEx1
        '
        Me.PanelEx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.lblpetugas)
        Me.PanelEx1.Controls.Add(Me.lbldenda)
        Me.PanelEx1.Controls.Add(Me.lbltgltransaksi)
        Me.PanelEx1.Controls.Add(Me.lblnisnsiswa)
        Me.PanelEx1.Controls.Add(Me.lblnamasiswa)
        Me.PanelEx1.Controls.Add(Me.lblkodekembali)
        Me.PanelEx1.Controls.Add(Me.DataGridView1)
        Me.PanelEx1.Location = New System.Drawing.Point(4, 32)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(531, 327)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_putih
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 13
        Me.PanelEx1.Text = "PanelEx1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(183, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 18)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Detail Pengembalian"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.bg_biru_tua
        Me.Button4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(501, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 30)
        Me.Button4.TabIndex = 143
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmDetailPengembalian
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
        Me.Name = "FrmDetailPengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Pengembalian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldenda As System.Windows.Forms.Label
    Friend WithEvents lbltgltransaksi As System.Windows.Forms.Label
    Friend WithEvents lblnisnsiswa As System.Windows.Forms.Label
    Friend WithEvents lblnamasiswa As System.Windows.Forms.Label
    Friend WithEvents lblkodekembali As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblpetugas As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
