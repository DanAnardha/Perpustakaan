Imports System.Data.OleDb
Public Class FormPengaturan
    Sub KondisiAwal()
        Call Koneksi()
        Cmd = New OleDbCommand("select * from TBL_PENGATURAN", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            TextBox1.Text = Rd.Item("BatasBuku")
            TextBox2.Text = Rd.Item("BatasHari")
            TextBox3.Text = Rd.Item("DendaPerHari")
            TextBox4.Text = Rd.Item("DendaRusak")
            HalamanUtama.STLabel12.Text = Rd("BatasBuku")
            HalamanUtama.STLabel14.Text = Rd("DendaPerHari")
            HalamanUtama.STLabel16.Text = Rd("BatasHari")
        Else
            TextBox1.Text = Rd.Item("BatasBuku")
            TextBox2.Text = Rd.Item("BatasHari")
            TextBox3.Text = Rd.Item("DendaPerHari")
            TextBox4.Text = Rd.Item("DendaRusak")
            HalamanUtama.STLabel12.Text = Rd("BatasBuku")
            HalamanUtama.STLabel14.Text = Rd("DendaPerHari")
            HalamanUtama.STLabel16.Text = Rd("BatasHari")
        End If
    End Sub

    Private Sub FormPengaturan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Pastikan Anda Mengisi Semua Field")
        Else
            Call Koneksi()
            Dim EditData As String = "update TBL_PENGATURAN set BatasBuku='" & TextBox1.Text & "',BatasHari='" & TextBox2.Text & "', DendaPerHari='" & TextBox3.Text & "',DendaRusak='" & TextBox4.Text & "'"
            Cmd = New OleDbCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
            Me.Close()
            Dim timer = New Timer
            timer.Interval = 5 * 1000
            timer.Start()
            HalamanUtama.Refresh()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            MsgBox("Anda Hanya Dapat Memasukkan Angka!")
            e.Handled = True
        End If
    End Sub
End Class