Imports System.Data.OleDb
Public Class FormCariDataAnggota

    Private Sub FormCariDataAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        TextBox1.Clear()
        Da = New OleDbDataAdapter("select * from TBL_ANGGOTA", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_ANGGOTA")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo AdaError
        FormTransaksiPeminjaman.ComboBox1.Text = DataGridView1.SelectedCells(0).Value
        FormTransaksiPeminjaman.LBLNama.Text = DataGridView1.SelectedCells(1).Value
        FormTransaksiPeminjaman.LBLAlamat.Text = DataGridView1.SelectedCells(3).Value
        Close()
        Exit Sub
AdaError:
        MsgBox("Data buku belum dipilih", MsgBoxStyle.Critical, "Pesan")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Da = New OleDbDataAdapter("select * from TBL_ANGGOTA where KodeAnggota like '%" & TextBox1.Text & "%' or NamaAnggota like '%" & TextBox1.Text & "%' or AlamatAnggota like '%" & TextBox1.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
End Class