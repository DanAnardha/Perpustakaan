Imports System.Data.OleDb
Public Class FormMasterKategori
    Sub KondisiAwal()
        TextBox1.Text = ""
        Call Koneksi()
        Da = New OleDbDataAdapter("select * from TBL_KATEGORI", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_KATEGORI")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Anda Harus Mengisi Field Terlebih Dahulu!")
        Else
            Call Koneksi()
            Dim SimpanData As String = "insert into TBL_KATEGORI values('" & TextBox1.Text & "')"
            Cmd = New OleDbCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Koneksi()
        If DataGridView1.SelectedCells.Count = 0 Then
            MsgBox("Anda Harus Memilih Data Terlebih Dahulu!")
        Else
            Dim HapusData As String = "delete * from TBL_KATEGORI where Kategori='" & DataGridView1.SelectedCells(0).Value & "'"
            Cmd = New OleDbCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus!")
            Call KondisiAwal()
        End If
    End Sub
    Private Sub FormMasterKategori_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, AcceptButton)
        End If
    End Sub
End Class