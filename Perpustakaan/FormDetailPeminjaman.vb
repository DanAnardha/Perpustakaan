﻿Imports System.Data.OleDb
Public Class FormDetailPeminjaman

    Private Sub FormDetailPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Da = New OleDbDataAdapter("select KodeBuku, JudulBuku, JumlahBuku, Pengarang, Status from TBL_DETAILPEMINJAMAN where NoPinjam='" & LBLNoPinjam.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "TBL_DETAILPEMINJAMAN")
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class