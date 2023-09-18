Imports System.Data.OleDb
Public Class FormCariDataBuku

    Private Sub FormCariDataBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        TextBox1.Clear()
        TextBox2.Clear()
        Da = New OleDbDataAdapter("select * from TBL_BUKU", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_Buku")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        TextBox2.Enabled = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox2.Text = DataGridView1.Item(10, i).Value
        PictureBox1.Load(TextBox2.Text)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo adaError
        FormTransaksiPeminjaman.TextBox1.Text = DataGridView1.SelectedCells(0).Value
        FormTransaksiPeminjaman.LBLJudul.Text = DataGridView1.SelectedCells(1).Value
        FormTransaksiPeminjaman.LBLPengarang.Text = DataGridView1.SelectedCells(2).Value
        FormTransaksiPeminjaman.LBLTahun.Text = DataGridView1.SelectedCells(5).Value
        FormTransaksiPeminjaman.TextBox2.Text = 1
        FormTransaksiPeminjaman.TextBox3.Text = DataGridView1.SelectedCells(10).Value
        FormTransaksiPeminjaman.PictureBox1.Load(FormTransaksiPeminjaman.TextBox3.Text)
        FormTransaksiPeminjaman.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        FormTransaksiPeminjaman.Label17.Text = DataGridView1.SelectedCells(6).Value
        TextBox1.Text = DataGridView1.SelectedCells(0).Value
        Close()
        Exit Sub
adaError:
        MsgBox("Data buku belum dipilih", MsgBoxStyle.Critical, "Pesan")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Da = New OleDbDataAdapter("select * from TBL_BUKU where KodeBuku like '%" & TextBox1.Text & "%' or JudulBuku like '%" & TextBox1.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
End Class