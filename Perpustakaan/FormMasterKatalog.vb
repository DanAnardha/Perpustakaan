Imports System.Data.OleDb
Public Class FormMasterKatalog

    Sub KondisiAwal()
        TextBox1.Text = ""
        Call Koneksi()
        Da = New OleDbDataAdapter("select * from TBL_BUKU", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_Buku")
        DataGridView1.DataSource = Ds.Tables(0)
        TextBox2.Enabled = False
        DataGridView1.ReadOnly = True
        TextBox1.Focus()
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call Koneksi()
        Da = New OleDbDataAdapter("select * from TBL_BUKU where JudulBuku like '%" & TextBox1.Text & "%' or PengarangBuku like '%" & TextBox1.Text & "%'or PenerbitBuku like '%" & TextBox1.Text & "%'", Conn)
        Ds = New DataSet
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormMasterKatalog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox2.Text = DataGridView1.Item(10, i).Value
        PictureBox1.Load(TextBox2.Text)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class